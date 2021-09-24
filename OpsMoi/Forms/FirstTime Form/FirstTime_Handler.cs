using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpsMoi.Models;
using OpsMoi.Utilities;
using SQL_DBH_Lib;

namespace OpsMoi.Forms.FirstTime_Form
{
    public static class FirstTime_Handler
    {
        public static string serialPattern = @"[A-Z]{2}[0-9]{2}-[A-Z]{2}[0-9]{2}-[0-9]{5}-[a-z]{2}[0-9]{3}";
        public static void CheckSerial(ModdedControls.ModdedTextBox txtbox, Label MsgLabel, Button startButton)
        {
            Settings settingsItem = DBHelper.Load_Item<Settings>("settings", new List<string> { "*" });
            if (txtbox.Text == settingsItem.serialnumber) { txtbox.BackColor = System.Drawing.Color.Lime; startButton.Enabled = true; }
            else
            {
                HM_Manager.Fail_addition(MsgLabel, "برجاء إدخال رقم سيريال صحيح");
                txtbox.BackColor = System.Drawing.Color.IndianRed; startButton.Enabled = false;
            }
        }
        public static async Task Ignite(string user_name, string user_address, string user_phonenumber, string user_email, GroupBox ownerGrpbox
            , string mainPassword, string serial, string coWebpage, GroupBox userGrpbox
            , Label MsgLabel, ProgressBar progBar, Control sender)
        {
            progBar.Invoke((MethodInvoker)delegate () { progBar.Visible = true; });
            try
            {
                Console.WriteLine("Checking empty entries ...");
                if (HM_Manager.CheckIfContainEmptyEntries(ownerGrpbox) || HM_Manager.CheckIfContainEmptyEntries(userGrpbox))
                    throw new Exception();
                Console.WriteLine("Checked");
                Console.WriteLine("Checking DB Connection ...");
                string connectionString = $@"Data Source=.\{Program.dbName};Version=3;";
                if (!Database_Connection.TestConnection<SQLiteConnection>(connectionString))
                {
                    HM_Manager.Fail_addition(MsgLabel, "حدثت مشكلة أثناء الاتصال بقاعدة البيانات");
                    return;
                }
                Console.WriteLine("Checked");
                Console.WriteLine("Creating Database");
                progBar.Invoke((MethodInvoker)delegate () { progBar.Value = 30; progBar.Update(); });
                PrepareDB(connectionString, Program.dbName);
                HM_Manager.Success_addition(MsgLabel, $"تم إنشاء قاعدة البيانات: {Program.dbName} بنجاح!");
                Console.WriteLine("Done");
                progBar.Invoke((MethodInvoker)delegate () { progBar.Value = 70; progBar.Update(); });
                Console.WriteLine("Adding Settings");
                using (IDbConnection connect = Database_Connection.Create_Connection<SQLiteConnection>())
                {
                    connect.Open();
                    UpdateSettings(connect, serial, HM_Manager.topEncrypt(mainPassword), coWebpage, user_phonenumber, user_email, user_address, user_name);
                    Console.WriteLine("Settings Update Done");
                    Console.WriteLine("Saved");
                    Console.WriteLine("Sending email");
                    await HM_Manager.Email().SendMailAsync(HM_Manager.EMessage(user_email, FirstTimeEmail_Helper.GetBody(user_name, serial, user_address, user_phonenumber, user_email, mainPassword, coWebpage),"OpsMoi Corp,Inc for personal use apps, خدمة عملاء"));
                    Console.WriteLine("Done");
                    progBar.Invoke((MethodInvoker)delegate () { progBar.Value = 90; progBar.Update(); });
                    Console.WriteLine("Logging in");
                    LoginForm_Handler.loginAttempt_Handle(sender, mainPassword, MsgLabel, "تسجيل دخول لأول مرة");
                    Console.WriteLine("Logged in");
                    progBar.Invoke((MethodInvoker)delegate () { progBar.Value = 100; progBar.Update(); });
                }
                // لازم تسجل العميل في قاعدة بيانات عندي
                HM_Manager.Success_addition(MsgLabel, "تم التسجيل بنجاح");
            }
            catch (Exception e) { Console.WriteLine(e.Message); HM_Manager.Fail_addition(MsgLabel); progBar.Value = 0; progBar.Visible = false; }
        }

        private static void PrepareDB(string ConnectionString, string dbName)
        {
            HM_Manager.UpdateConfiguration(new List<Tuple<string, string>> { new Tuple<string, string>("Initiated", "true"), new Tuple<string, string>("dbConnectionName", "default") });

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringsSection csSection = config.ConnectionStrings;
            string conString = $"{ConnectionString}";
            var cm = ConfigurationManager.ConnectionStrings.OfType<ConnectionStringSettings>().FirstOrDefault(p => p.Name == "default");
            if (cm == null) csSection.ConnectionStrings.Add(new ConnectionStringSettings("default", conString, "System.Data.SqlClient"));
            else csSection.ConnectionStrings["default"].ConnectionString = conString;

            config.Save(ConfigurationSaveMode.Modified);
        }

        private static void UpdateSettings(IDbConnection conn, string serialnumber, byte[] mainpassword, string webpage, string phone, string email, string address, string name) =>
            DBHelper.Update_Database("settings", new List<string>() { "mainpassword", "webpage", "phone", "email", "address", "name" }
            , new List<Settings>() { new Settings() { serialnumber = serialnumber, mainpassword = mainpassword, webpage = webpage, phone = phone, email = email, address = address, name = name } }, alt_connection: conn, KEY: "serialnumber",OLDVALUE: "serialnumber");

    }
}
