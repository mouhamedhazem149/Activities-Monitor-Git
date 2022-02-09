using DailyCompanionV2.Utilities;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyCompanionV2.User_Interfaces.Dashboard
{
    public static partial class Dashboard_Processor
    {
        public static void Update_DS_FNC_Chart(LiveCharts.WinForms.CartesianChart chart)
        {
            DateTime from = Program.Finances_List.Select(p => p.due_date).Min();
            List<DateTime> dateList = Reports.Reports_Processor.getDateList(from, DateTime.Now, Utilities.Enums.Span.شهري);
            Reports.Reports_Processor.PrepareChart(chart, dateList);
            SeriesCollection collect = new SeriesCollection();

            List<double> incomeValues = new List<double>(chart.AxisX.Count);
            List<double> billsValues = new List<double>(chart.AxisX.Count);
            List<double> transValues = new List<double>(chart.AxisX.Count);
            List<double> values = new List<double>(chart.AxisX.Count);
            for (int x = 0; x < dateList.Count - 1; x++)
            {
                List<Models.Finances> temp = Reports.Reports_Processor.FinancesList(dateList[x], dateList[x + 1]);
                var incmList = temp.Where(item => item.type == Enums.financeType.دخل);
                incomeValues.Add(incmList.Select(p => p.paid).Sum());
                var billList = temp.Where(item => item.type == Enums.financeType.مدفوعات);
                billsValues.Add(billList.Select(p => p.paid).Sum());
                var transList = temp.Where(item => item.type == Enums.financeType.تحويل_أرصدة);
                transValues.Add(transList.Select(p => p.paid).Sum());
                values.Add(incomeValues[x] - billsValues[x]);
            }
            collect.Add(new LineSeries() { Title = "الدخل", Values = new ChartValues<double>(incomeValues) });
            collect.Add(new LineSeries() { Title = "المصاريف", Values = new ChartValues<double>(billsValues/*.Select(p => p * -1)*/.ToList()) });
            collect.Add(new LineSeries() { Title = "التحويلات الشخصية", Values = new ChartValues<double>(transValues) });
            collect.Add(new LineSeries() { Title = "الصافي", Values = new ChartValues<double>(values) });

            chart.Series = collect;
        }
        public static void UpdatePieChart(LiveCharts.WinForms.PieChart pieChart)
        {
            Reports.Reports_Processor.PreparePieChart(pieChart);
            SeriesCollection collection = new SeriesCollection();
            var TDOsGrps = Program.Todos_List.GroupBy(p => p.category);
            foreach (var Group in TDOsGrps)
                collection.Add(new PieSeries() { Title = Group.Key, Values = new ChartValues<double>(new List<double> { Group.Select(p => p.duration).Sum() }) });

            SeriesCollection finalCollection = new SeriesCollection();
            collection.OrderByDescending(serDes => serDes.Values[0]).ToList().ForEach(series => finalCollection.Add(series));
            pieChart.Series = finalCollection;
        }
    }
}
