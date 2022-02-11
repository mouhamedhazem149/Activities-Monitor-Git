using DailyCompanionV2.Utilities;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DailyCompanionV2.User_Interfaces.Dashboard
{
    public static partial class Dashboard_Processor
    {
        public static void Update_DS_FNC_Chart(LiveCharts.WinForms.CartesianChart chart)
        {
            DateTime from = Program.Finances_List.Select(p => p.due_date).Min();
            List<DateTime> dateList = Reports.Reports_Processor.getDateList(from, DateTime.Now, Enums.Span.شهري);
            Reports.Reports_Processor.PrepareChart(chart, dateList);
            SeriesCollection collect = new SeriesCollection();
            List<double> incomeValues = new List<double>(chart.AxisX.Count);
            List<double> billsValues = new List<double>(chart.AxisX.Count);
            List<double> transValues = new List<double>(chart.AxisX.Count);
            List<double> values = new List<double>(chart.AxisX.Count);

            var grps = Program.Finances_List.GroupBy(p => new DateTime(p.due_date.Year, p.due_date.Month, 1)).ToList();
            for (int x = 0; x < dateList.Count; x++)
            {
                var FTemp = x == dateList.Count - 1 
                    ? grps.Where(p => p.Key >= dateList[x]).FirstOrDefault() 
                    : grps.Where(p => p.Key >= dateList[x] && p.Key < dateList[x + 1]).FirstOrDefault();
                List<Models.Finances> temp = FTemp != null ? FTemp.ToList() : new List<Models.Finances>();
                incomeValues.Add(temp.Where(item => item.type == Enums.financeType.دخل).Select(p => p.paid).Sum());
                billsValues.Add(temp.Where(item => item.type == Enums.financeType.مدفوعات).Select(p => p.paid).Sum());
                transValues.Add(temp.Where(item => item.type == Enums.financeType.تحويل_أرصدة).Select(p => p.paid).Sum());
                values.Add(incomeValues[x] - billsValues[x]);
            }
            collect.Add(new ColumnSeries() { Title = "الدخل", Values = new ChartValues<double>(incomeValues) });
            collect.Add(new ColumnSeries() { Title = "المصاريف", Values = new ChartValues<double>(billsValues/*.Select(p => p * -1)*/.ToList()) });
            collect.Add(new ColumnSeries() { Title = "التحويلات الشخصية", Values = new ChartValues<double>(transValues) });
            collect.Add(new ColumnSeries() { Title = "الصافي", Values = new ChartValues<double>(values) });

            chart.Series = collect;
        }
        public static void Update_TD_Charts(LiveCharts.WinForms.CartesianChart chart, LiveCharts.WinForms.PieChart pieChart)
        {
            string totalSpline = "الإجمالي";
            DateTime from = Program.Todos_List.Select(p => p.due_date).Min();
            List<DateTime> dateList = Reports.Reports_Processor.getDateList(from, DateTime.Now, Enums.Span.شهري);
            Reports.Reports_Processor.PrepareChart(chart, dateList);
            Reports.Reports_Processor.PreparePieChart(pieChart);
            pieChart.LegendLocation = LegendLocation.Left;
            pieChart.DefaultLegend.FontSize = 8;
            SeriesCollection cartCollection = new SeriesCollection();
            SeriesCollection pieCollection = new SeriesCollection();

            var TDOsGrps = Program.Todos_List.GroupBy(p => p.category).ToList();
            Dictionary<string, double[]> grpValuesDictionary = new Dictionary<string, double[]>();
            grpValuesDictionary.Add(totalSpline, new double[dateList.Count]);
            foreach (var grp in TDOsGrps)
            {
                double[] tempArray = new double[dateList.Count];
                for (int i = 0; i < dateList.Count; i++)
                {
                    tempArray[i] = i == dateList.Count - 1
                        ? grp.Where(p => p.due_date >= dateList[i]).Select(p => p.duration).Sum()
                        : grp.Where(p => p.due_date >= dateList[i] && p.due_date < dateList[i + 1]).Select(p => p.duration).Sum();
                    grpValuesDictionary[totalSpline][i] += tempArray[i];
                }
                grpValuesDictionary.Add(grp.Key, tempArray);
            }
            grpValuesDictionary.Keys.ToList().ForEach(p => cartCollection.Add(new LineSeries() { Title = p, Values = new ChartValues<double>(grpValuesDictionary[p].ToList()) }));
            chart.Series = cartCollection;

            foreach (var Group in TDOsGrps)
                pieCollection.Add(new PieSeries() { Title = Group.Key, Values = new ChartValues<double>(new List<double> { Group.Select(p => p.duration).Sum() }) });
            SeriesCollection finalCollection = new SeriesCollection();
            pieCollection.OrderByDescending(serDes => serDes.Values[0]).ToList().ForEach(series => finalCollection.Add(series));
            pieChart.Series = finalCollection;
        }
    }
}
