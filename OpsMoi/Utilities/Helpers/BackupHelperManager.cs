using System;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace OpsMoi.Utilities
{
    public static class BackupHelperManager
    {
        public static string compressor_7z = @"C:\Program Files\7-Zip\7z.exe";

        public static void BackUp(Label MsgLabel)
        {
            try
            {
                string table_affected = "قاعدة البيانات"; string operation = "نسخ احتياطي قاعدة البيانات";
                bool compress = MessageBox.Show("هل تريد إنشاء نسخة مضغوطة لقاعدة البيانات", "إخطار", MessageBoxButtons.YesNo) == DialogResult.Yes;
                string compress_password = " -p";
                if (compress)
                {
                    string tempPass = Interaction.InputBox("أدخل كلمة المرور لضغط الملف", "إخطار");
                    if (tempPass == "") compress_password = "";
                    else compress_password += tempPass;
                }
            CHECK_7Z:
                if (compress && !File.Exists(compressor_7z))
                {
                    if (MessageBox.Show("لم يتم العثور علي 7z برجاء ادخال المسار الصحيح للملف أو إالغاء اختيار ضغط الملف.", "خطأ", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        OpenFileDialog openFileDialog = new OpenFileDialog { InitialDirectory = @"C:\", Title = "البحث عن 7z", CheckFileExists = true, CheckPathExists = true, DefaultExt = "exe", Filter = "Exe Files(.exe) | *.exe", FilterIndex = 1, ReadOnlyChecked = true, ShowReadOnly = true };
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            compressor_7z = openFileDialog.FileName;
                            goto CHECK_7Z;
                        }
                        else return;
                    }
                    else return;
                }
                if (SQL_DBH_Lib.Database_Connection.Create_Connection<SQLiteConnection>(testConn: true) == null)
                    if (MessageBox.Show("الإعدادات الخاصة بقواعد البيانات غير مطابقة النسخ الاحتياطي غير ممكن", "خطأ", MessageBoxButtons.OK) == DialogResult.OK)
                        return;

                string path = Environment.CurrentDirectory;
                FolderBrowserDialog folderDialog = new FolderBrowserDialog() { RootFolder = Environment.SpecialFolder.Desktop, ShowNewFolderButton = true, Description = "اختيار مكان حفظ النسخة الاحتياطية لقاعدة البيانات" };
                if (folderDialog.ShowDialog() == DialogResult.OK)
                    path = folderDialog.SelectedPath;

                string backup_name = $@"{path}\backup-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}.db";
                string cmdCompress = $@"a{compress_password} {string.Concat('"', backup_name, ".zip", '"')} {string.Concat('"', backup_name, '"')} -sdel";

                //
                string add_info = $"تم النسخ الاحتياطي للملف: {backup_name} بواسطة: {Program.mainSettings.name}";
                using (IDbConnection location = SQL_DBH_Lib.Database_Connection.Create_Connection<SQLiteConnection>(testConn: true))
                    DBHelper.Execute<dynamic>($@"VACUUM INTO '{backup_name}'");
                if (compress)
                {
                    Process compressProcess = Process.Start(ExecuteProcess(compressor_7z, cmdCompress, path));
                    compressProcess.WaitForExit(); compressProcess.Close();
                    add_info = $"تم النسخ الاحتياطي للملف: {backup_name}.zip بواسطة: {Program.mainSettings.name} بكلمة مرور: {compress_password}";
                }
                HM_Manager.HandleHistory(new string[] { table_affected, operation, add_info });
                HM_Manager.Success_addition(MsgLabel, $"تم النسخ الاحتياطي بنجاح. اسم الملف:" + Environment.NewLine + $"{backup_name}.zip");
            }
            catch (Exception e) { HM_Manager.Fail_addition(MsgLabel); }
        }
        public static void Restore(Label MsgLabel)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog { InitialDirectory = @"C:\", Title = "البحث عن ملفات لقاعدة البيانات", CheckFileExists = true, CheckPathExists = true, FilterIndex = 1, ReadOnlyChecked = true, ShowReadOnly = true };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //string sqlFile = File.ReadAllText(openFileDialog.FileName);
                    DBHelper.Execute<dynamic>($@"ATTACH DATABASE '{openFileDialog.FileName}' AS db2;");

                    //File.WriteAllText($@"{Environment.CurrentDirectory}\{Program.dbName}", sqlFile);
                    HM_Manager.HandleHistory(new string[] {"قاعدة البيانات","استرجاع قاعدة البيانات",$"تم الاسترجاع من الملف: {openFileDialog.FileName} بواسطة: {Program.mainSettings.name}" });
                    if (MessageBox.Show("تم الاسترجاع بنجاح. سيتم الخروج من البرنامج الان", "إخطار", MessageBoxButtons.OK) == DialogResult.OK) Environment.Exit(0);
                }
            }
            catch (Exception ex) { HM_Manager.Fail_addition(MsgLabel); }
        }
        public static ProcessStartInfo ExecuteProcess(string processName, string Args,string path ="")
        {
            var processInfo = new ProcessStartInfo(processName, Args);
            processInfo.WorkingDirectory = path == "" ? processInfo.WorkingDirectory : path;
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;
            return processInfo;
        }
    }
}
