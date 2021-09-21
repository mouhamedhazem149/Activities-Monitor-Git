using OpsMoi.Database;
using OpsMoi.Models;
using BrightIdeasSoftware;
using Dapper;
using ExcelDataReader;
using Newtonsoft.Json;
using OfficeOpenXml;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OpsMoi.Utilities
{
    public static class HM_Manager
    {
        public static void Update_OLV<T>(List<T> objects,ObjectListView Olv)
        {
            if (Olv.Objects != null && Olv.Objects.OfType<T>().Count() > 0) { Olv.SetObjects(null); }
            Olv.Invoke((Action)delegate()
            {
                Olv.SetObjects(objects.Where(p => p != null));
                Olv.AutoResizeColumns();
            });
        }
        public static void Update_Combobox<T>(ComboBox cmbobx, List<T> dataSource, string displayMember = "", string valueMember = "")
        {
            cmbobx.DataSource = null; cmbobx.Items.Clear(); cmbobx.DataSource = dataSource;
            if (displayMember != "") cmbobx.DisplayMember = displayMember;
            if (valueMember != "") cmbobx.ValueMember = valueMember;
        }
        public static void LightCheckBox(ContainerControl parent,string checkboxName, bool value)
        {
            CheckBox chkbx = parent.Controls.Find(checkboxName, true).First() as CheckBox;
            if (!value) { if (chkbx.Tag.ToString() == "1") chkbx.Visible = value; else { chkbx.Visible = chkbx.Enabled = value; } }
            else chkbx.Visible = true;
        }
        public static void ChangeGroupBox2Name(Control ctrl,string name) => ctrl.Text = name;

        public static void CheckTxtBoxInt(TextBox txtbox, Label lbl)
        {
            decimal value = 0;
            if (decimal.TryParse(txtbox.Text, out value) || txtbox.ForeColor == Color.Silver) lbl.Visible = false;
            else { lbl.Visible = true; txtbox.Text = ""; }
        }

        public static bool CheckUser(string username, string password, Label label, string Caller, ref User usr)
        {
            using (IDbConnection conn = Database_Connection.Create_Connection())
            {
                User user = conn.QuerySingleOrDefault<User>("SELECT * from users WHERE user_name = @usrnm", new { usrnm = username });
                if (user != null)
                    if (user.password == password || (Program.user != null && (Enums.Permission_Level)Program.user.permission_level == Enums.Permission_Level.مدير_البرنامج)) { label.ForeColor = Color.Green; label.Text = "تم تسجيل الدخول"; label.Update(); label.Visible = true; usr = user; Database_Activities.HandleHistory(new string[] { "المستخدمين", $"تسجيل دخول ناجح في {Caller}", $"اسم المستخدم: {username} الموقع الجغرافي:{GetCurrentIPandLocation()[1]} IP الخاص بالمحاولة: {GetCurrentIPandLocation()[0]} " }); return true; }
                    else { label.Text = "كلمة المرور غير صحيحة"; label.ForeColor = Color.DarkRed; label.Visible = true; Database_Activities.HandleHistory(new string[] { "المستخدمين", $"محاولة تسجيل دخول فاشلة في {Caller}", $"اسم المستخدم: {username} الموقع الجغرافي:{GetCurrentIPandLocation()[1]} IP الخاص بالمحاولة: {GetCurrentIPandLocation()[0]} " }); return false; }
                else { label.Text = "اسم المستخدم غير موجود"; label.ForeColor = Color.DarkRed; label.Visible = true; return false; }
            }
        }
        private static string[] GetCurrentIPandLocation()
        {
            try
            {
                string[] Result = new string[2];
                RestClient _clnt = new RestClient("https://ipapi.co/json"); RestRequest _req = new RestRequest() { Method = Method.GET };
                IDictionary response = JsonConvert.DeserializeObject<IDictionary>(_clnt.Execute(_req).Content);
                Result[0] = response["ip"].ToString(); Result[1] = response["country_name"].ToString();
                return Result;
            }
            catch (Exception exe) { return new string[] { "d", "d" }; }
        }
        public static bool CheckIfContainEmptyEntries(GroupBox grpbx) { foreach (Control ctrl in grpbx.Controls) if (ctrl is TextBox) if (ctrl.Visible &&ctrl.Text.Length < 1/* ctrl.ForeColor == Color.Silver*/) return true; return false; }
        public static void Success_addition(Label label, string Msg = "تم الإضافة بنجاح") { label.ForeColor = Color.Green; label.Text = Msg; label.Visible = true; }
        public static void Fail_addition(Label label, string Msg = "برجاء التأكد من صحة البيانات") { label.ForeColor = Color.Red; label.Text = Msg; label.Visible = true; }

        public static void Reset_Textbox_Controls(Control groupbox) { foreach (Control ctrl in groupbox.Controls) if (ctrl is TextBox) { ctrl.Select(); ctrl.ResetText(); ctrl.Refresh(); } groupbox.Focus(); }

        public static void CheckPhoneNumber(object txtbox, Label lbl) { if ((txtbox as TextBox).Text.Split(',').ToList().TrueForAll(p => Regex.IsMatch(p, "^([+][0-9])?[0-9]+$"))) { lbl.Visible = false; } else { (txtbox as ModdedControls.ModdedTextBox).Text = ""; lbl.Visible = true; lbl.ForeColor = Color.DarkRed; lbl.Text = "برجاء إدخال رقم هاتف صالح"; } }
        public static void CheckNationalID(object txtbox, Label lbl) { if (Regex.IsMatch((txtbox as TextBox).Text, "^([0-9]{14})$|^([0-9]{7})$")) { lbl.Visible = false; } else { (txtbox as TextBox).ResetText(); lbl.Visible = true; lbl.ForeColor = Color.DarkRed; lbl.Text = "برجاء إدخال رقم قومي صالح"; } }

        public static string decimalPattern = @"[\d]+[.]?[\d]*";
        public static string datePattern = @"[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])";
        public static string phonePattern = @"^([+][0-9])?[0-9]+$";
        public static string nationalidPattern = @"^([0-9]{14})$|^([0-9]{7})$";

        public static DataSet Read_From_Excel(Label lbl)
        {
            IExcelDataReader excelReader = null;
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog { InitialDirectory = @"C:\", Title = "البحث عن ملفات Excel", CheckFileExists = true, CheckPathExists = true, DefaultExt = "Excel", Filter = "Excel files (*.xls;*.xlsx)|*.xls;*.xlsx", FilterIndex = 2, ReadOnlyChecked = true, ShowReadOnly = true };
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog1.FileName; FileInfo fileInfo = new FileInfo(filePath);
                    FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
                    if (fileInfo.Extension == ".xlsx") excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                    else if (fileInfo.Extension == ".xls") excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
                    DataSet result = excelReader.AsDataSet(new ExcelDataSetConfiguration() { ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true, ReadHeaderRow = (rowReader) => { rowReader.Read(); } } });
                    excelReader.Close();
                    return result;
                }
                return null;
            }
            catch (Exception exce) { if (excelReader != null) excelReader.Close(); Fail_addition(lbl, "فشل التعديل"); return null; }
        }
        public static void To_Excel(Label lbl, List<string> columnNames, List<List<object>> columnValues, string sheetName = "Sheet1", string sheetTitle = "")
        {
            try
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    int rowIndex = 1;
                    //Create the WorkSheet
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add(sheetName);
                    worksheet.View.RightToLeft = true;
                    // // // // // // // // TITLE // // // // // // // //
                    if (sheetTitle != "")
                    {
                        worksheet.Cells[rowIndex, 1, rowIndex, columnNames.Count].Merge = true;
                        worksheet.Cells[rowIndex, 1, rowIndex, columnNames.Count].Value = sheetTitle;
                        worksheet.Cells[rowIndex, 1, rowIndex, columnNames.Count].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        worksheet.Cells[rowIndex, 1, rowIndex, columnNames.Count].Style.Font.Size = 20;
                        worksheet.Cells[rowIndex, 1, rowIndex, columnNames.Count].Style.Font.Color.SetColor(Color.Blue);
                        worksheet.Cells[rowIndex, 1, rowIndex, columnNames.Count].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Gray0625; worksheet.Cells[rowIndex, 1, rowIndex, columnNames.Count].Style.Fill.BackgroundColor.SetColor(Color.Blue); rowIndex++;
                    }
                    // // // // // // // // HEADERS // // // // // // // //
                    if (columnNames.Count(p => (p != null && p != "")) > 0)
                    {
                        for (int x = 1; x <= columnNames.Count; x++) worksheet.Cells[rowIndex, x].Value = columnNames[x - 1];
                        worksheet.Cells[rowIndex, 1, rowIndex, columnNames.Count].Style.Font.Size = 15;
                        worksheet.Cells[rowIndex, 1, rowIndex, columnNames.Count].Style.Font.Color.SetColor(Color.Red);
                        worksheet.Cells[rowIndex, 1, rowIndex, columnNames.Count].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        worksheet.Cells[rowIndex, 1, rowIndex, columnNames.Count].Style.Fill.BackgroundColor.SetColor(Color.Gray);
                        worksheet.Cells[rowIndex, 1, rowIndex, columnNames.Count].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        rowIndex++;
                    }
                    // // // // // // // // CELLS // // // // // // // //
                    for (int r = 0; r < columnValues.Count; r++)
                    {
                        for (int c = 1; c <= columnValues[r].Count; c++)
                        { worksheet.Cells[rowIndex, c].Value = columnValues[r][c - 1]; worksheet.Cells[rowIndex, c].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right; }
                        rowIndex++;
                    }
                    worksheet.Cells.AutoFitColumns();
                    // // // // // // // // Save your file // // // // // // // //
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog { InitialDirectory = @"Desktop\", FileName = sheetName, Title = $"حفظ ملف {sheetName} كملف Excel", OverwritePrompt = true, RestoreDirectory = true, DefaultExt = "Excel", Filter = "Excel files (*.xlsx)|*.xlsx", FilterIndex = 2 };
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo fi = new FileInfo(saveFileDialog1.FileName);
                        excelPackage.SaveAs(fi);
                        Success_addition(lbl, "تم حفظ الملف!");
                    }
                }
            }
            catch (Exception exce) { Fail_addition(lbl, "فشل الحفظ"); }
        }
    }
}
