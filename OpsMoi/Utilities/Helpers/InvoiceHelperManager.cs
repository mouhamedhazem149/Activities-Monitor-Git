using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using OfficeOpenXml;

namespace OpsMoi.Utilities
{
    public static partial class HM_Manager
    {
        public static void To_InvoiceExcel(Label lbl,ref List<Models.Invoice> columnValues, string companyName, string companyAddress, string companyPhone, string companyEmail, string companyWebpage, bool print, string sheetName = "فاتورة")
        {
            columnValues = PrepareInvoices(columnValues);
            List<string> columnNames = new List<string> { "م", "موديل الجهاز", "السيريال", "الكمية", "سعر الوحدة", "السعر" };
            try
            {
                foreach (Models.Invoice invoice in columnValues)
                {
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        int rowIndex = 1;
                        //Create the WorkSheet
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add(sheetName);
                        worksheet.View.RightToLeft = true;
                        worksheet.PrinterSettings.FitToPage = true;
                        // // // // // // // // fine adjustments // // // // // // // //
                        worksheet.Column(1).Width = 2;
                        worksheet.Column(2).Width = 10;
                        worksheet.Column(3).Width = 40;
                        worksheet.Column(4).Width = 40;
                        worksheet.Column(5).Width = 19.3;
                        worksheet.Column(6).Width = 21;
                        worksheet.Column(7).Width = 2;
                        worksheet.Column(8).Width = 2;
                        // // // // // // // // Inserting Table // // // // // // // //
                        // 7 is the number of header rows :CHANGE: if any of them changes
                        //ExcelTable SimpleInvoice = worksheet.Tables.Add(worksheet.Cells[7, 1, 7 + invoice.invoiceUnits.Count - 1, 6], "SimpleInvoice");
                        // // // // // // // // TITLE // // // // // // // //
                        worksheet.Cells[rowIndex, 1, rowIndex, 6].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        worksheet.Cells[rowIndex, 1, rowIndex, 6].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(235, 118, 124));
                        // // // // // // // // CompanyName // // // // // // // //
                        worksheet.Cells[rowIndex, 1, rowIndex, 2].Merge = true;
                        worksheet.Cells[rowIndex, 1, rowIndex, 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        worksheet.Cells[rowIndex, 1, rowIndex, 2].Style.Font.SetFromFont(new Font("Cairo", 35F, FontStyle.Bold, GraphicsUnit.Point, 0));
                        worksheet.Cells[rowIndex, 1, rowIndex, 2].Style.Font.Color.SetColor(Color.White);
                        worksheet.Cells[rowIndex, 1, rowIndex, 2].Value = companyName;
                        // // // // // // // // فاتورة مبيعات // // // // // // // //
                        worksheet.Cells[rowIndex, 5, rowIndex, 6].Merge = true;
                        worksheet.Cells[rowIndex, 5, rowIndex, 6].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        worksheet.Cells[rowIndex, 5, rowIndex, 6].Style.Font.SetFromFont(new Font("El Messiri", 25F, FontStyle.Bold, GraphicsUnit.Point, 0));
                        worksheet.Cells[rowIndex, 5, rowIndex, 6].Style.Font.Color.SetColor(Color.White);
                        worksheet.Cells[rowIndex, 5, rowIndex, 6].Value = "فاتورة مبيعات";
                        // // // // // // // // معلومات عن الموزع // // // // // // // //
                        rowIndex++;
                        worksheet.Cells[rowIndex, 1, rowIndex + 1, 6].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        worksheet.Cells[rowIndex, 1, rowIndex + 1, 6].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(168, 191, 223));
                        worksheet.Cells[rowIndex, 1, rowIndex + 1, 6].Style.Font.Color.SetColor(Color.Black);
                        // // // // // // // // عنوان // // // // // // // //
                        worksheet.Cells[rowIndex, 1, rowIndex, 2].Merge = true;
                        worksheet.Cells[rowIndex + 1, 1, rowIndex + 1, 2].Merge = true;
                        worksheet.Cells[rowIndex, 1, rowIndex + 1, 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        worksheet.Cells[rowIndex, 1, rowIndex + 1, 2].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                        worksheet.Cells[rowIndex, 1, rowIndex + 1, 2].Style.Font.SetFromFont(new Font("El Messiri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0));
                        worksheet.Cells[rowIndex, 1, rowIndex + 1, 2].Style.Font.Color.SetColor(Color.Black);
                        worksheet.Cells[rowIndex, 1, rowIndex + 1, 2].Merge = true;
                        worksheet.Cells[rowIndex, 1, rowIndex + 1, 2].Style.WrapText = true;
                        worksheet.Cells[rowIndex, 1, rowIndex + 1, 2].Value = $"العنوان: {companyAddress}";
                        // // // // // // // // رقم الموبايل // // // // // // // //
                        //worksheet.Cells[rowIndex, 4, rowIndex, 5].Merge = true;
                        worksheet.Cells[rowIndex, 3, rowIndex, 4].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        worksheet.Cells[rowIndex, 3, rowIndex, 4].Style.Font.SetFromFont(new Font("El Messiri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0));
                        worksheet.Cells[rowIndex, 3, rowIndex, 4].Style.Font.Color.SetColor(Color.Black);
                        worksheet.Cells[rowIndex, 3].Value = "رقم الموبايل:"; worksheet.Cells[rowIndex, 3].Style.Font.Bold = true;
                        worksheet.Cells[rowIndex, 4].Value = $"{companyPhone}";
                        // // // // // // // // البريد الإلكتروني // // // // // // // //
                        //worksheet.Cells[rowIndex, 6, rowIndex, 7].Merge = true;
                        worksheet.Cells[rowIndex, 5, rowIndex, 6].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        worksheet.Cells[rowIndex, 5, rowIndex, 6].Style.Font.SetFromFont(new Font("El Messiri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0));
                        worksheet.Cells[rowIndex, 5, rowIndex, 6].Style.Font.Color.SetColor(Color.Black);
                        worksheet.Cells[rowIndex, 5].Value = "البريد الإلكتروني:"; worksheet.Cells[rowIndex, 5].Style.Font.Bold = true;
                        worksheet.Cells[rowIndex, 6].Value = $"{companyEmail}";
                        // // // // // // // // الموفع الإلكتروني // // // // // // // //
                        //worksheet.Cells[rowIndex + 1, 6, rowIndex + 1, 7].Merge = true;
                        worksheet.Cells[rowIndex + 1, 5, rowIndex + 1, 6].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        worksheet.Cells[rowIndex + 1, 5, rowIndex + 1, 6].Style.Font.SetFromFont(new Font("El Messiri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0));
                        worksheet.Cells[rowIndex + 1, 5, rowIndex + 1, 6].Style.Font.Color.SetColor(Color.Black);
                        worksheet.Cells[rowIndex + 1, 5].Value = "الموقع الإلكتروني:"; worksheet.Cells[rowIndex + 1, 5].Style.Font.Bold = true;
                        worksheet.Cells[rowIndex + 1, 6].Value = $"{companyWebpage}";
                        rowIndex += 2;
                        // // // // // // // // معلومات العميل // // // // // // // //
                        worksheet.Cells[rowIndex, 1, rowIndex + 4, 6].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        worksheet.Cells[rowIndex, 1, rowIndex + 4, 6].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(255, 255, 255));
                        worksheet.Cells[rowIndex, 1, rowIndex + 4, 6].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        worksheet.Cells[rowIndex, 1, rowIndex + 4, 6].Style.Font.SetFromFont(new Font("A Nasr", 13F, FontStyle.Bold, GraphicsUnit.Point, 0));
                        worksheet.Cells[rowIndex, 1, rowIndex + 4, 6].Style.Font.Color.SetColor(Color.FromArgb(22, 80, 95));
                        worksheet.Cells[rowIndex, 2, rowIndex + 4, 2].Style.Font.SetFromFont(new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point, 0));
                        worksheet.Cells[rowIndex, 6, rowIndex + 3, 6].Style.Font.SetFromFont(new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point, 0));
                        worksheet.Cells[rowIndex, 1].Value = "اسم العميل:";
                        worksheet.Cells[rowIndex, 2].Value = invoice.clientName;
                        worksheet.Cells[rowIndex, 5].Value = "رقم الفاتورة: ";
                        worksheet.Cells[rowIndex, 6].Value = invoice.index;
                        //worksheet.Cells[rowIndex, 4, rowIndex, 5].Merge = true;
                        worksheet.Cells[rowIndex, 3].Value = "رقم الموبايل:";
                        worksheet.Cells[rowIndex, 4].Value = $"{invoice.phonenumber}";
                        worksheet.Cells[rowIndex + 1, 1, rowIndex + 2, 1].Merge = true;
                        worksheet.Cells[rowIndex + 1, 1, rowIndex + 2, 1].Value = "العنوان:";
                        worksheet.Cells[rowIndex + 1, 1, rowIndex + 2, 1].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                        worksheet.Cells[rowIndex + 1, 2, rowIndex + 2, 2].Merge = true;
                        worksheet.Cells[rowIndex + 1, 2, rowIndex + 2, 2].Value = invoice.address;
                        worksheet.Cells[rowIndex + 1, 2, rowIndex + 2, 2].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                        worksheet.Cells[rowIndex + 1, 5].Value = "تاريخ الفاتورة: ";
                        worksheet.Cells[rowIndex + 1, 6].Value = DateTime.Now.ToString("dddd, dd-MMMM-yyyy", System.Globalization.CultureInfo.GetCultureInfo("ar-EG"));
                        //worksheet.Cells[rowIndex + 1, 7].Value = invoice.date.ToString("dddd, dd-MMMM-yyyy", System.Globalization.CultureInfo.GetCultureInfo("ar-EG"));
                        rowIndex += 2;
                        worksheet.Cells[rowIndex, 1].Value = "فاتورة ل:";
                        worksheet.Cells[rowIndex, 2].Value = invoice.category;
                        rowIndex++;
                        // // // // // // // // Table HEADERS // // // // // // // //
                        int tableRowBegin = rowIndex + 1;
                        worksheet.Cells[rowIndex, 1, rowIndex, 6].Style.Font.SetFromFont(new Font("Tahoma", 14, FontStyle.Regular, GraphicsUnit.Point, 0));
                        worksheet.Cells[rowIndex, 1, rowIndex, 6].Style.Font.Color.SetColor(Color.FromArgb(34, 121, 142));
                        worksheet.Cells[rowIndex, 1, rowIndex, 6].Style.Fill.BackgroundColor.SetColor(Color.White);
                        worksheet.Cells[rowIndex, 1, rowIndex, 6].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        worksheet.Cells[rowIndex, 1, rowIndex, 6].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        worksheet.Cells[rowIndex, 1, rowIndex, 6].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                        worksheet.Cells[rowIndex, 1, rowIndex, 6].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thick);
                        worksheet.Cells[rowIndex, 1].Value = "م";
                        worksheet.Cells[rowIndex, 2].Value = "موديل الجهاز";
                        worksheet.Cells[rowIndex, 3].Value = "السيريال";
                        worksheet.Cells[rowIndex, 4].Value = "الكمية";
                        worksheet.Cells[rowIndex, 5].Value = "سعر الوحدة";
                        worksheet.Cells[rowIndex, 6].Value = "السعر الإجمالي";
                        worksheet.Row(rowIndex).Height = 30;
                        worksheet.Column(3).Style.WrapText = true;
                        for (int index = 1; index <= invoice.invoiceUnits.Count; index++)
                        {
                            var unit = invoice.invoiceUnits[index - 1];
                            rowIndex++;
                            //worksheet.Cells[rowIndex, 1, rowIndex, 6].Style.Font.SetFromFont(new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point, 0));
                            worksheet.Row(rowIndex).Height = 25;
                            worksheet.Cells[rowIndex, 1].Style.Border.Left.Style = worksheet.Cells[rowIndex, 6].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
                            worksheet.Cells[rowIndex, 6].Style.Border.Left.Style = worksheet.Cells[rowIndex, 1].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                            worksheet.Cells[rowIndex, 2, rowIndex, 5].Style.Border.Left.Style = worksheet.Cells[rowIndex, 2, rowIndex, 5].Style.Border.Right.Style =
                                worksheet.Cells[rowIndex, 1, rowIndex, 6].Style.Border.Top.Style = worksheet.Cells[rowIndex, 1, rowIndex, 6].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                            worksheet.Cells[rowIndex, 1].Value = index;
                            worksheet.Cells[rowIndex, 2].Value = unit.modelName;
                            worksheet.Cells[rowIndex, 3].Value = string.Join("\n", unit.serial);
                            worksheet.Cells[rowIndex, 4].Value = unit.count;
                            worksheet.Cells[rowIndex, 5].Value = unit.price;
                            worksheet.Cells[rowIndex, 6].Value = unit.price * unit.count;
                            worksheet.Row(rowIndex).Height = unit.serial.Count * 15 + 15;
                        }
                        worksheet.Cells[rowIndex, 1, rowIndex, 6].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
                        rowIndex++;
                        // // // // // // // // Notes & final rows // // // // // // // //
                        worksheet.Cells[tableRowBegin, 1, tableRowBegin + invoice.invoiceUnits.Count + 1, 6].Style.Font.SetFromFont(new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point, 0));
                        worksheet.Cells[tableRowBegin, 1, tableRowBegin + invoice.invoiceUnits.Count + 1, 6].Style.Font.Color.SetColor(Color.Black);
                        worksheet.Cells[tableRowBegin, 1, tableRowBegin + invoice.invoiceUnits.Count + 1, 6].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        worksheet.Cells[tableRowBegin, 1, tableRowBegin + invoice.invoiceUnits.Count + 1, 6].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(210, 238, 244));
                        worksheet.Cells[tableRowBegin, 1, tableRowBegin + invoice.invoiceUnits.Count + 1, 6].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        worksheet.Cells[tableRowBegin, 1, tableRowBegin + invoice.invoiceUnits.Count + 1, 6].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                        worksheet.Row(rowIndex).Height = 34;
                        worksheet.Cells[rowIndex, 1].Value = "ملاحظات: ";
                        worksheet.Cells[rowIndex, 1].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Top;
                        worksheet.Cells[rowIndex, 5, rowIndex + 1, 6].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                        worksheet.Cells[rowIndex, 5, rowIndex + 1, 6].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        worksheet.Cells[rowIndex, 5, rowIndex + 1, 6].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(121, 203, 223));
                        worksheet.Cells[rowIndex, 5].Value = "الإجمالي الفرعي للفاتورة";
                        worksheet.Cells[rowIndex, 6].Formula = $"SUM(F{tableRowBegin}:F{tableRowBegin + invoice.invoiceUnits.Count - 1})";
                        worksheet.Cells[rowIndex, 6, rowIndex + 1, 6].Style.Numberformat.Format = "_-\"ج.م.‏\" * #,##0.00_-;_-\"ج.م.‏\" * #,##0.00-;_-\"ج.م.‏\" * \" - \"??_-;_-@_-";
                        rowIndex++;
                        worksheet.Row(rowIndex).Height = 34;
                        worksheet.Cells[rowIndex, 5].Value = "الإجمالي";
                        worksheet.Cells[rowIndex, 5].Style.Font.SetFromFont(new Font("El Messiri", 15F, FontStyle.Bold, GraphicsUnit.Point, 0));
                        worksheet.Cells[rowIndex, 5].Style.Font.Color.SetColor(Color.Black);
                        worksheet.Cells[rowIndex, 6].Formula = $"F{tableRowBegin + invoice.invoiceUnits.Count}";
                        worksheet.Cells.AutoFitColumns();
                        worksheet.Column(3).Width = worksheet.Column(3).Width < 20 ? 20 : worksheet.Column(3).Width;
                        // // // // // // // // Save your file // // // // // // // //
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog { InitialDirectory = $"{Environment.CurrentDirectory}", FileName = $"{sheetName}_{invoice.clientName}", Title = $"حفظ ملف فاتورة: {sheetName}_{invoice.clientName} كملف Excel", OverwritePrompt = true, RestoreDirectory = true, DefaultExt = "Excel", Filter = "Excel files (*.xlsx)|*.xlsx", FilterIndex = 2 };
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            FileInfo fi = new FileInfo(saveFileDialog1.FileName);
                            byte[] excelStream = excelPackage.GetAsByteArray();
                            File.WriteAllBytes(fi.FullName, excelStream);
                            Success_addition(lbl, "تم حفظ الملف!");
                            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application() { DisplayAlerts = false };
                            Microsoft.Office.Interop.Excel.Workbook wb = excelApp.Workbooks.Open($"{fi.FullName}");
                            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
                            ws.ExportAsFixedFormat(Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF, $"{fi.FullName}.pdf", Microsoft.Office.Interop.Excel.XlFixedFormatQuality.xlQualityStandard);
                            if (print)
                            {
                                PrintDialog printDialog = new PrintDialog
                                {
                                    AllowPrintToFile = true,
                                    AllowCurrentPage = true,
                                    AllowSomePages = true,
                                    AllowSelection = true,
                                    UseEXDialog = true,
                                };
                                printDialog.PrinterSettings.Duplex = Duplex.Simplex;
                                printDialog.PrinterSettings.FromPage = 0;
                                printDialog.PrinterSettings.ToPage = 1;
                                printDialog.PrinterSettings.DefaultPageSettings.Landscape = false;
                                if (printDialog.ShowDialog() == DialogResult.OK)
                                {
                                    ws.PrintOut(printDialog.PrinterSettings.FromPage > 0 ? printDialog.PrinterSettings.FromPage : 1,
                                        printDialog.PrinterSettings.ToPage,
                                        printDialog.PrinterSettings.Copies,
                                        Type.Missing,
                                        printDialog.PrinterSettings.PrinterName,
                                        printDialog.PrinterSettings.PrintToFile,
                                        printDialog.PrinterSettings.Collate,
                                        $"فاتورة_{invoice.clientName}");
                                }
                            }
                            // Cleanup:
                            GC.Collect();
                            GC.WaitForPendingFinalizers();
                            Marshal.FinalReleaseComObject(ws);
                            wb.Close(false);
                            Marshal.FinalReleaseComObject(wb);
                            excelApp.Quit();
                            Marshal.FinalReleaseComObject(excelApp);
                        }
                    }
                }
                columnValues.Clear();
            }
            catch (Exception exce) { Fail_addition(lbl, "فشلت عملية الفوترة"); }
        }

        private static List<Models.Invoice> PrepareInvoices(List<Models.Invoice> invoicesList)
        {
            List<string> invoicesNames = invoicesList.Select(p => p.clientName).Distinct().ToList();
            List<Models.Invoice> tempList = new List<Models.Invoice>(invoicesNames.Count);
            foreach (string name in invoicesNames)
            {
                var temp = invoicesList.Where(p => p.clientName == name);
                List<string> modelList = temp.Select(p => p.invoiceUnits.Select(c => c.modelName)).SelectMany(a => a).Distinct().ToList();
                List<Models.InvoiceUnit> unitTemp = new List<Models.InvoiceUnit>();
                foreach (string modelName in modelList)
                {
                    int count = 1;
                    var tempSimUnits = temp.Select(p => p.invoiceUnits).SelectMany(m => m).Where(unit => unit.modelName == modelName).ToList();
                    while (tempSimUnits.Count > 0)
                    {
                        var tempSimPrice = tempSimUnits.Where(p => p.price == tempSimUnits[0].price).ToList();
                        unitTemp.Add(new Models.InvoiceUnit()
                        {
                            modelName = tempSimPrice[0].modelName,
                            index = count,
                            serial = tempSimPrice.Select(p => p.serial).SelectMany(serial => serial).ToList(),
                            price = tempSimPrice[0].price,
                            count = tempSimPrice.Select(p => p.count).Sum()
                        });
                        tempSimUnits.RemoveAll(p => p.price == tempSimPrice[0].price);
                        count++;
                    }
                }
                tempList.Add(new Models.Invoice()
                {
                    address = temp.First().address,
                    clientName = temp.First().clientName,
                    category = temp.First().category,
                    date = temp.First().date,
                    index = temp.First().index,
                    phonenumber = temp.First().phonenumber,
                    invoiceUnits = unitTemp
                });
            }
            return tempList;
        }
}
}
