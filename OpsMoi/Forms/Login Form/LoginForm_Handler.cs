using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;
using OpsMoi.Utilities;

namespace OpsMoi.Forms
{
    public static class LoginForm_Handler
    {
        public static void loginAttempt_Handle(Control sender, string passWord,Label MsgLabel,string source = "نافذة تسجيل الدخول")
        {
            if (HM_Manager.CheckUser(passWord, MsgLabel,source , ref Program.mainSettings))
            {
                sender.Invoke((MethodInvoker)delegate () { sender.Hide(); });
                Form1 MainForm = new Form1();
                MainForm.ShowDialog();
                sender.Dispose();
            }
        }
        public static List<string> dbConnection_Combobox_Items = ConfigurationManager.ConnectionStrings.OfType<ConnectionStringSettings>().Where(p => p.ProviderName == "System.Data.SqlClient").Select(p => p.Name).ToList();

        public static List<EnumStruct> resolution_Combobox_Items =>
            Enum.GetValues(typeof(Enums.Resolution)).Cast<Enums.Resolution>().Select(p => new EnumStruct() {displayName = p.GetDisplayName(),realName = p.ToString() }).ToList();

        public static async System.Threading.Tasks.Task ForgetPassword_Handle(Label MsgLabel)
        {
            HM_Manager.Fail_addition(MsgLabel, "جاري المعالجة ...");
            Random generator = new Random();
            string Temp_Password = generator.Next(0, 99999999).ToString("D6");
            try
            {
                Models.Settings cur;
                using (IDbConnection conn = SQL_DBH_Lib.Database_Connection.Create_Connection<SQLiteConnection>())
                    cur = await DBHelper.Load_Item_Async<Models.Settings>("settings", new List<string>() { "*" });
                if (cur == null) HM_Manager.Fail_addition(MsgLabel, "هذا المستخدم غير موجود");
                else
                {
                    //Console.WriteLine($"{Temp_Password}");
                    HM_Manager.SendEmail(cur.email, Forgetpassword_Email_Body_Helper.GetBody(Temp_Password, Program.WebpageLink));
                    //message.Body = $"نأسف لعدم تمكنك من الدخول لحسابك يمكنك استخدام كلمة المرور : \r\n {Temp_Password} \r\n ككلمة مرور مؤقتة";
                    User_Interfaces.Settings.Settings_Processor.ChangePassword(HM_Manager.Decrypt(cur.mainpassword),Temp_Password,Temp_Password,MsgLabel);
                    HM_Manager.Success_addition(MsgLabel, "تم إرسال كلمة المرور المؤقتة لبريدك الالكتروني المسجل");
                }
            }
            catch (Exception) { HM_Manager.Fail_addition(MsgLabel, "حدثت مشكلة! برجاءالتواصل مع خدمة العملاء"); }
        }
    }
}
