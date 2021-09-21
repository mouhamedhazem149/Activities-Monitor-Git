using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace OpsMoi.Utilities
{
    public static partial class HM_Manager
    {
        public static string PdfListPattern = @"^(?<customerPrice>[\d,]+) (?<listPrice>[\d,]+) (?<modelName>[\u0621-\u064A\d.\s]+) (?<modelCode>[A-Z\d-]+)";

        public static DataSet PdfDevicesDataSet(FileInfo fileInfo, Label lbl)
        {//6,970 6,320 ىطئاح فييكت زاهج 1.5 دراب ناصح AH-A12USEA 1  [read from pdf line result]
            string[] PdfText = Read_From_Pdf(fileInfo.FullName, lbl).Split(Environment.NewLine.ToCharArray());
            DataSet tempSet = new DataSet();
            DataTable tempTable = new DataTable();
            tempTable.Columns.Add(User_Interfaces.Settings.Settings_Processor.cPrice);
            tempTable.Columns.Add(User_Interfaces.Settings.Settings_Processor.dPrice);
            tempTable.Columns.Add(User_Interfaces.Settings.Settings_Processor.Model);
            tempTable.Columns.Add(User_Interfaces.Settings.Settings_Processor.Code);
            for (int x = 1; x < PdfText.Length; x++)
            {
                var mtch = Regex.Match(PdfText[x], PdfListPattern);
                if (mtch.Groups != null)
                    tempTable.Rows.Add(mtch.Groups["customerPrice"], mtch.Groups["listPrice"], mtch.Groups["modelName"], mtch.Groups["modelCode"]);
            }
            tempSet.Tables.Add(tempTable);
            return tempSet;
        }
        public static string Read_From_Pdf(string filePath,Label lbl)
        {
            try
            {
                string tempTxt = "";
                using (PdfDocument doc = new PdfDocument(new PdfReader(filePath)))
                    for (int page = 1; page <= doc.GetNumberOfPages(); page++)
                        tempTxt += Encoding.UTF8.GetString(Encoding.Convert(Encoding.UTF8, Encoding.UTF8, Encoding.UTF8.GetBytes(PdfTextExtractor.GetTextFromPage(doc.GetPage(page), new SimpleTextExtractionStrategy()))));
                Success_addition(lbl, "تم قراءة ملف PDF بنجاح.");
                return tempTxt;
            }
            catch (Exception exce) { HM_Manager.Success_addition(lbl, "فشل قراءة ملف PDF"); return ""; }
        }
        public static void To_Pdf(Label lbl, List<string> columnNames, List<List<object>> columnValues, string sheetName = "Sheet1", string sheetTitle = "")
        {
            try
            {
                
            }
            catch (Exception exce) { Fail_addition(lbl, "فشل الحفظ"); }
        }
    }
}
