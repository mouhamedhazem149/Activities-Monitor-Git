using SQL_DBH_Lib;
using OpsMoi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using OpsMoi.Utilities;

namespace OpsMoi.User_Interfaces.Dashboard
{
    public static class Dashboard_Processor
    {
        public static Dictionary<string, string> Dashboard_Elements { get; private set; } = new Dictionary<string, string>();
        public static List<History> LoadHistory(DateTime From, DateTime To)
        {
            var history_Lst = DBHelper.Load_Data<History>("history",new List<string> { "*" } , new List<string> { $"datetime BETWEEN '{From.Date.ToString("yyyy-MM-dd hh:mm:ss")}' AND '{To.Date.ToString("yyyy-MM-dd hh:mm:ss")}'" });// LIMIT 500
            return history_Lst.OrderBy(item => item.id).ToList();// ORDER BY id ASC
        }
        /*public async static Task LoadDashboardElements()
        {
            Dashboard_Elements.Clear();
            List<Task> tskList = new List<Task> { new Task(Load_Client_Section), new Task(Load_Maintenance_Section), new Task(Load_Device_Section), new Task(Load_Reports_Section) };
            Parallel.ForEach(tskList, tsk => { tsk.Start(); });
            await Task.WhenAll(tskList);//
            Load_Installment_Section();
        }
        private async static void Load_Client_Section()
        {
            Dashboard_Elements.Add("Total_Clients", await Database_Activities.Load_Item_Async<string>("clients", new List<string> { "COUNT(DISTINCT(name))" }));
            Dashboard_Elements.Add("Today_Clients", await Database_Activities.Load_Item_Async<string>("clients", new List<string> { "COUNT(DISTINCT(name))" },new List<string> { $"date BETWEEN '{DateTime.Now.ToString("yyyy-MM-01")}' AND '{DateTime.Now.AddMonths(1).ToString("yyyy-MM-01")}'" }));
            double Months_Span = (Database_Activities.Load_Item<DateTime?>("clients",new List<string> { "MAX(date)" }).HasValue) ? ( Database_Activities.Load_Item<DateTime?>("clients", new List<string> { "MAX(date)" }).Value.Subtract(Database_Activities.Load_Item<DateTime>("clients", new List<string> { "MIN(date)" })).TotalDays) / 30 : 0;
            Dashboard_Elements.Add("AverageClients",Months_Span != 0 ? (double.Parse(Dashboard_Elements["Total_Clients"]) / Months_Span).ToString("0.00") : "لا توجد بيانات كافية");
        }
        private static void Load_Installment_Section()
        {
            Dashboard_Elements.Add("Month_REQInstallments", Program.clients_List.Select(p => p.Req_Count(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1), new DateTime(DateTime.Now.AddMonths(1).Year, DateTime.Now.AddMonths(1).Month, 1))).Sum().ToString());
            Dashboard_Elements.Add("Month_PaidInstallments", Program.clients_List.Select(p => p.Done_Count(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1), new DateTime(DateTime.Now.AddMonths(1).Year, DateTime.Now.AddMonths(1).Month, 1))).Sum().ToString());
        }
        private async static void Load_Maintenance_Section()
        {
            Dashboard_Elements.Add("MTN_Month", await Database_Activities.Load_Item_Async<string>("maintenance", new List<string> { "COUNT(*)" }, new List<string> { $"req_date BETWEEN '{DateTime.Now.ToString("yyyy-MM-01")}' AND '{DateTime.Now.AddMonths(1).ToString("yyyy-MM-01")}'" }));
            Dashboard_Elements.Add("Total_MTN", await Database_Activities.Load_Item_Async<string>("maintenance", new List<string> { "COUNT(*)" }));
            double Months_Span = (Database_Activities.Load_Item<DateTime?>("maintenance", new List<string> { "MAX(req_date)" }).HasValue) ? (Database_Activities.Load_Item<DateTime?>("maintenance", new List<string> { "MAX(req_date)" }).Value.Subtract(Database_Activities.Load_Item<DateTime>("maintenance", new List<string> { "MIN(req_date)" })).TotalDays) / 30 : 0;
            Dashboard_Elements.Add("MTN_Average" , Months_Span != 0 ? (uint.Parse(Dashboard_Elements["Total_MTN"]) / Months_Span).ToString("0.00") : "لا توجد بيانات كافية");
        }
        private async static void Load_Device_Section()
        {
            Dashboard_Elements.Add("Total_DevicesSales", await Database_Activities.Load_Item_Async<string>("clients", new List<string> { "COUNT(*)" }));
            Dashboard_Elements.Add("Month_DevicesSales", await Database_Activities.Load_Item_Async<string>("clients", new List<string> { "COUNT(*)" }, new List<string> { $"date BETWEEN '{DateTime.Now.ToString("yyyy-MM-01")}' AND '{DateTime.Now.AddMonths(1).ToString("yyyy-MM-01")}'" }));
            double Months_Span = (Database_Activities.Load_Item<DateTime?>("clients", new List<string> { "MAX(date)" }).HasValue) ? (Database_Activities.Load_Item<DateTime?>("clients", new List<string> { "MAX(date)" }).Value.Subtract(Database_Activities.Load_Item<DateTime>("clients", new List<string> { "MIN(date)" })).TotalDays) / 30 : 0;
            Dashboard_Elements.Add("DevicesSold_Average", Months_Span != 0 ? (double.Parse(Dashboard_Elements["Total_DevicesSales"]) / Months_Span).ToString("0.00") : "0");

            int Devices_Added = 0;
            List<string> dev_Added = await Database_Activities.Load_Data_Async<string>("history", new List<string> { "(add_info)" }, new List<string> { "operation = 'إضافة أجهزة للمخزن' OR operation = 'تعديل أجهزة للمخزن'", $"AND datetime BETWEEN '{DateTime.Now.ToString("yyyy-MM-01")}' AND '{DateTime.Now.AddMonths(1).ToString("yyyy-MM-01")}'" });
            foreach (string record in dev_Added) Devices_Added += int.Parse(Regex.Match(record, Storage.addStorageRegex).Groups["Count"].Value);
            Dashboard_Elements.Add("Device_TO_Store", Devices_Added.ToString());
        }
        private async static void Load_Reports_Section()
        {
            List<DateTime> Dates;
            var temp = await Database_Activities.Load_Data_Async<string>("clients", new List<string> { "(date)" }, new List<string> { $"date BETWEEN '{DateTime.Now.ToString("yyyy-01-01")}' AND '{DateTime.Now.AddYears(1).ToString("yyyy-01-01")}'" });
            Dates = temp.Select(p => DateTime.Parse(p)).ToList();
            for (int x = 0; x < Dates.Count; x++) Dates[x] = new DateTime(Dates[x].Year, Dates[x].Month, 1);
            Dashboard_Elements.Add("Month_Most_Sales" , Dates.Count != 0 ? Dates.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First().ToString("MMMM-yyyy", CultureInfo.GetCultureInfo("ar-EG")) : "لا توجد بيانات كافية");
            temp = await Database_Activities.Load_Data_Async<string>("clients", new List<string> { "(date)" }, new List<string> { "date" });
            Dates = temp.Select(p => DateTime.Parse(p)).ToList();
            for (int x = 0; x < Dates.Count; x++) Dates[x] = new DateTime(Dates[x].Year, Dates[x].Month, 1);
            Dashboard_Elements.Add("Month_Sales", Dates.Count != 0 ? Dates.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First().ToString("MMMM-yyyy", CultureInfo.GetCultureInfo("ar-EG")) : "لا توجد بيانات كافية");
            temp = await Database_Activities.Load_Data_Async<string>("maintenance", new List<string> { "(req_date)" }, new List<string> { $"req_date BETWEEN '{DateTime.Now.ToString("yyyy-01-01")}' AND '{DateTime.Now.AddYears(1).ToString("yyyy-01-01")}'" });
            Dates = temp.Select(p => DateTime.Parse(p)).ToList();
            for (int x = 0; x < Dates.Count; x++) Dates[x] = new DateTime(Dates[x].Year, Dates[x].Month, 1);
            Dashboard_Elements.Add("Most_MTN" , Dates.Count != 0 ? Dates.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First().ToString("MMMM-yyyy", CultureInfo.GetCultureInfo("ar-EG")) : "لا توجد بيانات كافية");
            Dashboard_Elements.Add("Most_ModelSales" , Database_Activities.Execute_Async<string>("SELECT model, COUNT(*) AS magnitude FROM clients GROUP BY model ORDER BY magnitude DESC LIMIT 1") != null ? Database_Activities.Execute<string>("SELECT model, COUNT(*) AS magnitude FROM clients GROUP BY model ORDER BY magnitude DESC LIMIT 1") : "لا توجد بيانات كافية");
        }*/
        // // // // // // // // // // // // // // // // // // // // // // // //
        public static void Handle_TODO_Button() => Program.WorkingForm.Click_TODO(Enums.todoArgument.showTodoManager, null);
        public static void Handle_Installment_Button() { }/* => Program.WorkingForm.ClickCustomerService(Utilities.Enums.todoArgument.openInsTab, null);*/
        // // // // // // // // // // // // // // // // // // // // // // // //
        public static void ShowReports_Button() => Program.WorkingForm.Click_Reports("goal");
        // // // // // // // // // // // // // // // // // // // // // // // //
    }
}
