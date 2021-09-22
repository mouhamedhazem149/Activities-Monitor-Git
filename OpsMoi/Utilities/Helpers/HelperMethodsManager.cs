using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Dapper;
using OpsMoi.Models;
using SQL_DBH_Lib;

namespace OpsMoi.Utilities
{
    public static partial class HM_Manager
    {
        [DllImport("User32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
        #region Regex Patterns
        public static string decimalPattern = @"[\d]+[.]?[\d]*";
        public static string datePattern = @"[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])";
        public static string phonePattern = @"^([+][0-9])?[0-9]+$";
        public static string nationalidPattern = @"^([0-9]{14})$|^([0-9]{7})$";
        #endregion
        public const string technicianSeprator = " , ";
        public static void SaveScreenShot(Form form, Label Msglabel = null)
        {
            if (Msglabel != null) Msglabel.Visible = false;
            try
            {
                IntPtr primary = GetDC(IntPtr.Zero);
                var bmpScreenshot = new Bitmap(GetDeviceCaps(primary, 118/*DESKTOPHORZRES*/), GetDeviceCaps(primary, 117/*DESKTOPVERTRES*/), PixelFormat.Format32bppArgb);
                Graphics.FromImage(bmpScreenshot).CopyFromScreen(0, 0, 0, 0, bmpScreenshot.Size, CopyPixelOperation.SourceCopy);
                bmpScreenshot.Save($"{Environment.CurrentDirectory}//Screenshot-{DateTime.Now.ToString("yyyyMMddhhmmss")}.png", ImageFormat.Png);
                if (Msglabel != null) Success_addition(Msglabel, "تم حفظ لقطة الشاشة بنجاح!");
            }
            catch (Exception) { Fail_addition(Msglabel, "فشل حفظ لقطة الشاشة!"); }
        }
        public static void SyncAll(Control parentCtrl, Label Msglabel = null)
        {
            if (Msglabel != null) Msglabel.Visible = false;
            try
            {
                parentCtrl.Controls.OfType<ICustomControl>().ToList().ForEach(ctrl => ctrl.Sync());
                if (Msglabel != null) Success_addition(Msglabel, "تمت المزامنة بنجاح!");
            }
            catch (Exception) { Fail_addition(Msglabel, "حدث خطأ اثناء المزامنة!"); }
        }
        public static bool CheckUser(string password, Label label, string Caller, ref Settings stngs)
        {
            using (IDbConnection conn = Database_Connection.Create_Connection<SQLiteConnection>())
            {
                Settings sets = conn.QuerySingleOrDefault<Settings>("SELECT * from settings WHERE serialnumber = @serialnumber;", new { serialnumber = Program.serialNumber });
                var c = Decrypt(sets.mainpassword);
                if (sets != null && Decrypt(sets.mainpassword) == password)
                {
                    Success_addition(label, "تم تسجيل الدخول");
                    stngs = sets;
                    HandleHistory(new string[] { "المستخدمين", $"تسجيل دخول ناجح في {Caller}", $"الوقت :: [{CurrentTime}]" });
                    return true;
                }
                else { Fail_addition(label, "كلمة المرور غير صحيحة"); HandleHistory(new string[] { "المستخدمين", $"محاولة تسجيل دخول فاشلة في {Caller}", $"الوقت :: [{CurrentTime}]" }); return false; }
            }
        }
        private static string CurrentTime => DateTime.Now.ToString("dddd, dd-MMMM-yyyy :: hh:mm tt");

        public delegate object ConstructorDelegate(params object[] args);
        public static ConstructorDelegate CreateConstructor(Type type, params Type[] parameters)
        {
            var constructorInfo = type.GetConstructor(parameters);
            var paramExpr = Expression.Parameter(typeof(object[]));
            var constructorParameters = parameters.Select((paramType, index) =>
                Expression.Convert(Expression.ArrayAccess(paramExpr, Expression.Constant(index)), paramType)).ToArray();
            var body = Expression.New(constructorInfo, constructorParameters);
            var constructor = Expression.Lambda<ConstructorDelegate>(body, paramExpr);
            return constructor.Compile();
        }

        public static MatchEvaluator arabReverse = delegate (Match match) { return new string(match.Value.Reverse().ToArray()); };
        public static string ReverseArabText(string text) => string.Join(" ",
            Regex.Replace(text.Replace("لا", "ل"), "(?<ArabWord>[ضصثقفغإعهخحجدطكمنتاألبيسشئءؤرىآةوزظ]+)", arabReverse)
            .Split(' ').Reverse());

        public static Dictionary<string, object> GetObjectAsDictionary(object obj) => obj.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
                        .ToDictionary(prop => prop.Name, prop => prop.GetValue(obj, null));

        public static void WriteBytesToConsole(byte[] Array,string name = "Array") => Console.WriteLine($"Length:: {Array.Length} {name}:: {string.Join(" ", Array.Select(byt => byt.ToString()))}");

        public static string[] commonEntities => Program.Todos_List.Select(tdo => tdo.duefrom).Union(Program.Todos_List.Select(tdo => tdo.dueto)).Union(Program.Finances_List.Select(fnc => fnc.relatedentity)).ToArray();
        public static string[] commonCategories => Program.Todos_List.Select(tdo => tdo.category).Union(Program.Finances_List.Select(fnc => fnc.category)).ToArray();

        public static void Success_addition(Label label, string Msg = "تم الإضافة بنجاح") => label.Invoke((MethodInvoker)delegate () { label.ForeColor = Color.Green; label.Text = Msg; label.Visible = true; label.Update(); });
        public static void Fail_addition(Label label, string Msg = "برجاء التأكد من صحة البيانات") => label.Invoke((MethodInvoker)delegate () { label.ForeColor = Color.Red; label.Text = Msg; label.Visible = true; });

        public static void CheckPhoneNumber(object txtbox, Label lbl) { if ((txtbox as ModdedControls.ModdedTextBox).IsPlaceholder || (txtbox as ModdedControls.ModdedTextBox).Text.Split(',').ToList().TrueForAll(p => Regex.IsMatch(p, "^([+][0-9])?[0-9]+$"))) { lbl.Visible = false; } else { (txtbox as ModdedControls.ModdedTextBox).Text = ""; lbl.Visible = true; lbl.ForeColor = Color.DarkRed; lbl.Text = "برجاء إدخال رقم هاتف صالح"; } }
        public static void CheckNationalID(object txtbox, Label lbl) { if ((txtbox as ModdedControls.ModdedTextBox).IsPlaceholder || Regex.IsMatch((txtbox as ModdedControls.ModdedTextBox).Text, "^([0-9]{14})$|^([0-9]{7})$")) { lbl.Visible = false; } else { (txtbox as ModdedControls.ModdedTextBox).Text = ""; lbl.Visible = true; lbl.ForeColor = Color.DarkRed; lbl.Text = "برجاء إدخال رقم قومي صالح"; } }
        public static bool Verify_Mail(string email) { try { MailAddress m = new MailAddress(email); return true; } catch (FormatException) { return false; } }
    }
}
