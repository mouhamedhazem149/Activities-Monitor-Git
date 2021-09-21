using System;
using System.Windows.Forms;
using SQL_DBH_Lib;
using OpsMoi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using OpsMoi.Utilities;

namespace OpsMoi
{
    public static class Program
    {
        [System.Runtime.InteropServices.DllImport("shcore.dll")]
        private static extern int SetProcessDpiAwareness(_Process_DPI_Awareness value);
        private enum _Process_DPI_Awareness
        {
            Process_DPI_Unaware = 0,
            Process_System_DPI_Aware = 1,
            Process_Per_Monitor_DPI_Aware = 2
        }
        public const string serialNumber = "AB12-CD34-51494-zc090";
        public const string emailSender_Email = "mouhamed.helmy149@gmail.com"; public const string emailSender_Password = "01287076976";
        public const string dbName = "opsmoidb.db";
        public static string WebpageLink => mainSettings.webpage;
        public static string companyName => "الرفيق اليومي";
        public static string companyAddress => mainSettings.address;
        public static string companyPhonenumber => mainSettings.phone;
        public static string companyEmail => mainSettings.email;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SetResolution();
            SetProcessDpiAwareness(_Process_DPI_Awareness.Process_DPI_Unaware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (System.Configuration.ConfigurationManager.AppSettings["Initiated"] == "true")
                if (Database_Connection.Create_Connection<SQLiteConnection>(testConn: true) != null && Settings_List.Count > 0 && Settings_List.Where(stng => stng.serialnumber == serialNumber).FirstOrDefault() != null && Settings_List.Where(stng => stng.serialnumber == serialNumber).FirstOrDefault().mainpassword != null)
                {
                    mainSettings = Settings_List[0];
                    if (mainSettings.serialnumber != serialNumber) return;
                    Application.Run(new LogInForm());
                }
                else if (MessageBox.Show("تم اكتشاف مشكلة في قاعدة البيانات الخاصة بالبرنامج. إعادة ضبط البرنامج ؟","إخطار",MessageBoxButtons.OKCancel) == DialogResult.OK) Application.Run(new FirstTime());
                else { Application.Run(new FirstTime()); }
        }
        
        public static Utilities.Enums.Resolution currentResolution = Enums.Resolution.A_1920x1080;
        public static void SetResolution()
        {
            if (Enum.IsDefined(typeof(Utilities.Enums.Resolution), System.Configuration.ConfigurationManager.AppSettings["Resolution"]))
                currentResolution = (Utilities.Enums.Resolution)Enum.Parse(typeof(Utilities.Enums.Resolution), System.Configuration.ConfigurationManager.AppSettings["Resolution"]);
            else Console.WriteLine("WRONG RESOLUTION.setting defaults");
        }

        public static Settings mainSettings;
        public static Form1 WorkingForm;
        public static List<Todos> Todos_List => DBHelper.Load_Data<Todos>("todos", new List<string> { "*" });
        public static List<Finances> Finances_List => DBHelper.Load_Data<Finances>("finances", new List<string> { "*" });
        public static List<Notes> Notes_List => DBHelper.Load_Data<Notes>("notes", new List<string> { "*" });
        public static List<Settings> Settings_List => DBHelper.Load_Data<Settings>("settings", new List<string> { "*" });
        public static List<History> History_List => DBHelper.Load_Data<History>("history", new List<string> { "*" });

    }
}
