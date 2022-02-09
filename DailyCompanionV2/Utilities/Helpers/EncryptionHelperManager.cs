using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DailyCompanionV2.Utilities
{
    public static partial class HM_Manager
    {
        public static byte[] topEncrypt(string plainText, Tuple<byte[], byte[]> KeyIV = null, Label MsgLabel = null)
        {
            try
            {
                byte[] Key = KeyIV != null ? KeyIV.Item1 : null; byte[] IV = KeyIV != null ? KeyIV.Item2 : null; byte[] encrypted = null; byte[] toReturn = null;
                byte keyLength = KeyIV != null ? (byte)KeyIV.Item1.Length : (byte)GetRandomInt(20, 32);
                byte ivLength = KeyIV != null ? (byte)KeyIV.Item2.Length : (byte)GetRandomInt(20, 32);
                var rnd = new RNGCryptoServiceProvider();
                if (Key == null) { Key = new byte[keyLength]; rnd.GetNonZeroBytes(Key); }
                if (IV == null) { IV = new byte[ivLength]; rnd.GetNonZeroBytes(IV); }
                using (AesCryptoServiceProvider AesCrypto = new AesCryptoServiceProvider() { Mode = CipherMode.CBC, KeySize = 256,Padding = PaddingMode.ISO10126})
                {
                    byte[] fKey = new byte[32];
                    byte[] fIV = new byte[16];
                    for (int fCount = 0; fCount < 16; fCount++)
                    {
                        fKey[fCount] = Key[fCount % Key.Length];
                        fIV[fCount] = IV[fCount % IV.Length];
                    }
                    for (int fCount = 16; fCount < 32; fCount++)
                        fKey[fCount] = Key[fCount % Key.Length];
                    ICryptoTransform encryptor = AesCrypto.CreateEncryptor(fKey, fIV);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter sw = new StreamWriter(cs))
                            {
                                var sfs = strEncrypt(plainText);
                                Console.WriteLine($"Length:: {sfs.Length} sfs:: {sfs}");
                                sw.Write(sfs);
                            }
                            encrypted = ms.ToArray();
                            Console.WriteLine($"Length:: {encrypted.Length} encrypted:: {string.Join(" ", encrypted.Select(byt => byt.ToString()))}");
                        }
                    }
                }
                if (KeyIV == null)
                {
                    byte encryptMultiplayer = (byte)GetRandomInt(8, Math.Min((int)(256 / keyLength),(int)(256 / ivLength)));
                    toReturn = new byte[encrypted.Length + keyLength + ivLength + 2];
                    encrypted.CopyTo(toReturn, ivLength + 1);
                    toReturn[0] = (byte)(keyLength * encryptMultiplayer);
                    Key.CopyTo(toReturn, toReturn.Length - keyLength);
                    toReturn[toReturn.Length - keyLength - 1] = (byte)(ivLength * encryptMultiplayer);
                    IV.CopyTo(toReturn, 1);
                    byte[] finalReturn = new byte[toReturn.Length + 1];
                    int position = (int)Math.Floor((decimal)toReturn.Length / 2);
                    finalReturn[position] = encryptMultiplayer;
                    Array.Copy(toReturn, 0, finalReturn, 0, position);
                    Array.Copy(toReturn, position, finalReturn, position + 1, toReturn.Length - position);
                    return finalReturn;
                }
                else { if (MsgLabel != null) Success_addition(MsgLabel, $"تم التشفير بمفتاح : KEY:: '[{Encoding.UTF8.GetString(Key)}]'"); return encrypted; }
            }
            catch (Exception) { if (MsgLabel != null) Fail_addition(MsgLabel, "فشل التشفير"); return Encoding.UTF8.GetBytes("فشل التشفير"); }
        }
        public static string Decrypt(byte[] cipherText,Tuple<byte[], byte[]> KeyIV = null,Label MsgLabel = null)
        {
            try
            {
                byte[] toDecrypt = cipherText;
                Console.WriteLine($"Length:: {toDecrypt.Length} toDecrypt:: {string.Join(" ", toDecrypt.Select(byt => byt.ToString()))}");
                byte[] Key = null; byte[] IV = null; string plaintext = null;
                if (KeyIV == null)
                {
                    byte keyLength = Key != null ? (byte)Key.Length : (byte)0; byte ivLength = IV != null ? (byte)IV.Length : (byte)0;

                    byte encryptMultiplayer = 0;
                    byte[] tempCipher = new byte[cipherText.Length - 1];
                    int index = cipherText.Length % 2 == 0 ? cipherText.Length / 2 - 1 : cipherText.Length / 2;
                    encryptMultiplayer = cipherText[index];
                    Array.Copy(cipherText, 0, tempCipher, 0, index);
                    Array.Copy(cipherText, index + 1, tempCipher, index, tempCipher.Length - index);
                    if (Key == null || IV == null)
                    {
                        keyLength = (byte)(tempCipher[0] / encryptMultiplayer);
                        ivLength = (byte)(tempCipher[tempCipher.Length - keyLength - 1] / encryptMultiplayer);
                        Key = new byte[keyLength];
                        IV = new byte[ivLength];
                    }
                    toDecrypt = new byte[tempCipher.Length - keyLength - ivLength - 2];
                    Array.Copy(tempCipher, tempCipher.Length - keyLength, Key, 0, keyLength);
                    Array.Copy(tempCipher, 1, IV, 0, ivLength);
                    Array.Copy(tempCipher, ivLength + 1, toDecrypt, 0, toDecrypt.Length);
                }
                else { Key = KeyIV.Item1; IV = KeyIV.Item2; }
                using (AesCryptoServiceProvider AesCrypto = new AesCryptoServiceProvider() { Mode = CipherMode.CBC, KeySize = 256,Padding = PaddingMode.ISO10126})
                {
                    byte[] fKey = new byte[32];
                    byte[] fIV = new byte[16];
                    for (int fCount = 0; fCount < 16; fCount++)
                    {
                        fKey[fCount] = Key[fCount % Key.Length];
                        fIV[fCount] = IV[fCount % IV.Length];
                    }
                    for (int fCount = 16; fCount < 32; fCount++)
                        fKey[fCount] = Key[fCount % Key.Length];
                    ICryptoTransform decryptor = AesCrypto.CreateDecryptor(fKey, fIV);
                    using (MemoryStream ms = new MemoryStream(toDecrypt))
                    {
                        using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader reader = new StreamReader(cs))
                                plaintext = reader.ReadToEnd(); 
                        }
                    }
                }
                return strDecrypt(plaintext);
            }
            catch (Exception) { if (MsgLabel != null) Fail_addition(MsgLabel, "فشل فك التشفير"); return Encoding.Unicode.GetString(cipherText); }
        }
        // what i want is get byte for text multiply it by factor then save as factor + encrypted text
        public static int GetRandomInt(int min, int max) => new Random(Guid.NewGuid().GetHashCode()).Next(min, max);
        public static string strEncrypt(string plainText)
        {
            StringBuilder encryptedText = new StringBuilder();
            int encryptMultiplier = GetRandomInt(1,256);
            byte[] textBytes = Encoding.Unicode.GetBytes(plainText);
            foreach (byte byt in textBytes)
                SB_Insert(encryptedText, byt, "x4");
            SB_Insert(encryptedText, encryptMultiplier, "x2", (int)Math.Floor((decimal)encryptedText.Length / 2));
            return encryptedText.ToString();
        }
        static void SB_Insert(StringBuilder stringBuilder, int toEncrypt, string stringFormat, int? index = null)
        {
            stringFormat = GetRandomInt(1,100) % 2 == 0 ? stringFormat.ToLower() : stringFormat.ToUpper();
            if (index.HasValue) stringBuilder.Insert(index.Value, toEncrypt.ToString(stringFormat));
            else stringBuilder.Append(toEncrypt.ToString(stringFormat));
        }
        public static string strDecrypt(string encryptedText)
        {
            int index = (int)Math.Floor((decimal)encryptedText.Length / 4) * 2;
            byte[] OriginalByte = new byte[index / 2];
            int encryptMultiplier = FromHex(encryptedText.Substring(index, 2));
            encryptedText = encryptedText.Remove(index, 2);
            for (int ind = 0; ind < encryptedText.Length - 3; ind += 4)
                OriginalByte[ind / 4] = (byte)FromHex(encryptedText.Substring(ind, 4));
            return Encoding.Unicode.GetString(OriginalByte);
        }
        public static int FromHex(string Hex) => int.Parse(Hex.ToUpper(), System.Globalization.NumberStyles.HexNumber);
    }
}
