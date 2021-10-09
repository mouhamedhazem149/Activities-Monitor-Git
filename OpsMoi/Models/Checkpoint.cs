using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpsMoi.Models
{
    public class Checkpoint
    {
        public static string chkpointJoint = ",";
        public static string chkpointSeparator = "||";

        public int index { get; set; }

        public string ChkName { get; set; }
        
        public string ChkDate { get; set; }
        public DateTime Chk_Date { get => DateTime.Parse(ChkDate); set { ChkDate = value.ToString("g"); } }

        public override string ToString()  //KEY:VALUE.DUE DATE.PAYMENT DATE
        {
            byte[] ChkNm = Encoding.UTF8.GetBytes(ChkName);
            var tempNm = string.Join("", ChkNm.Select(p => p.ToString("X2")));
            byte[] ChkDt = Encoding.UTF8.GetBytes(ChkDate);
            var tempDt = string.Join("", ChkDt.Select(p => p.ToString("X2")));
            return string.Join(chkpointJoint, new List<string> { index.ToString(), tempNm, tempDt });
        }
        public static Checkpoint GetCheckpoint(string chk_string)
        {
            Checkpoint temp = new Checkpoint();
            var split = chk_string.Split(new string[] { chkpointJoint }, StringSplitOptions.None);
            if (split.Length != 3) return temp;
            try
            {
                temp.index = int.Parse(split[0]);

                byte[] tempNmArr = new byte[split[1].Length / 2];
                for (int x = 0; x < tempNmArr.Length; x++)
                    tempNmArr[x] = (byte)Utilities.HM_Manager.FromHex(split[1].Substring(x * 2, 2));
                temp.ChkName = Encoding.UTF8.GetString(tempNmArr);

                byte[] tempDtArr = new byte[split[2].Length / 2];
                for (int x = 0; x < tempDtArr.Length; x++)
                    tempDtArr[x] = (byte)Utilities.HM_Manager.FromHex(split[2].Substring(x * 2, 2));
                temp.ChkDate = Encoding.UTF8.GetString(tempDtArr);
                return temp;
            }
            catch (Exception ex) { return GetCheckpoint(""); }
        }
    }
}
