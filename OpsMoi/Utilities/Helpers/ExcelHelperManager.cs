using ExcelDataReader;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OpsMoi.Utilities
{
    public static partial class HM_Manager
    {
        public static DataSet Read_From_Excel(FileInfo fileInfo,Label lbl)
        {
            IExcelDataReader excelReader = null;
            try
            {
                FileStream stream = File.Open(fileInfo.FullName, FileMode.Open, FileAccess.Read);
                if (fileInfo.Extension == ".xlsx") excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                else if (fileInfo.Extension == ".xls") excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
                DataSet result = excelReader.AsDataSet(new ExcelDataSetConfiguration() { ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true, ReadHeaderRow = (rowReader) => { rowReader.Read(); } } });
                excelReader.Close();
                return result;
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
