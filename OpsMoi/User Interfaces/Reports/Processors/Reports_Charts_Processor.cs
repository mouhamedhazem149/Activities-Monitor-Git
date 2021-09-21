using OpsMoi.Utilities;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using LiveCharts;
using System.Drawing;

namespace OpsMoi.User_Interfaces.Reports
{
    public static partial class Reports_Processor
    {
        public delegate int GetItemAtPoint(DateTime from, DateTime to);
        public static void UpdateLiveChart(LiveCharts.WinForms.CartesianChart chart, Enums.report_tabState state, DateTime from, DateTime to, Enums.Span span, Label Msglabel)
        {
            if (from > to) { HM_Manager.Fail_addition(Msglabel, "برجاء ادخال تاريخ صالح"); return; }
            List<DateTime> dateList = getDateList(from, to, span);
            PrepareChart(chart, dateList);
            List<int> valus = new List<int>();
            LiveCharts.SeriesCollection collect = new SeriesCollection();
            switch (state)
            {
                case Enums.report_tabState.مهام:
                    List<int> countValus = new List<int>(chart.AxisX.Count);
                    List<double> durationValus = new List<double>(chart.AxisX.Count);
                    for (int x = 0; x < dateList.Count - 1; x++)
                    {
                        List<Models.Todos> temp = TodosList(dateList[x], dateList[x + 1]);
                        countValus.Add(temp.Count);
                        durationValus.Add(temp.Select(p => p.duration).Sum());
                    }
                    collect.Add(new LineSeries() { Title = "عدد المهام المطلوبة", Values = new ChartValues<int>(countValus) });
                    collect.Add(new LineSeries() { Title = "الفترة المستغرقة لأداء المهام", Values = new ChartValues<double>(durationValus) });
                    break;
                case Enums.report_tabState.مالية:
                    List<double> incomeValues = new List<double>(chart.AxisX.Count);
                    List<int> incomeCount = new List<int>(chart.AxisX.Count);
                    List<double> billsValues = new List<double>(chart.AxisX.Count);
                    List<int> billCount = new List<int>(chart.AxisX.Count);
                    List<double> values = new List<double>(chart.AxisX.Count);
                    List<int> totalCount = new List<int>(chart.AxisX.Count);
                    for (int x = 0; x < dateList.Count - 1; x++)
                    {
                        List<Models.Finances> temp = FinancesList(dateList[x], dateList[x + 1]);
                        var incmList = temp.Where(item => item.type == Enums.financeType.دخل);
                        incomeValues.Add(incmList.Select(p => p.paid).Sum());
                        incomeCount.Add(incmList.Count());
                        var billList = temp.Where(item => item.type == Enums.financeType.مدفوعات);
                        billsValues.Add(billList.Select(p => p.paid).Sum());
                        billCount.Add(billList.Count());
                        values.Add(incomeValues[x] - billsValues[x]);
                        totalCount.Add(temp.Count);
                    }
                    collect.Add(new LineSeries() { Title = "الدخل", Values = new ChartValues<double>(incomeValues) });
                    collect.Add(new LineSeries() { Title = "المصاريف", Values = new ChartValues<double>(billsValues) });
                    collect.Add(new LineSeries() { Title = "الصافي", Values = new ChartValues<double>(values) });
                    collect.Add(new LineSeries() { Title = "عدد عمليات الدخل", Values = new ChartValues<int>(incomeCount) });
                    collect.Add(new LineSeries() { Title = "عدد عمليات المصاريف", Values = new ChartValues<int>(billCount) });
                    collect.Add(new LineSeries() { Title = "عدد العمليات الكلي", Values = new ChartValues<int>(totalCount) });
                    break;
                case Enums.report_tabState.ملاحظات:
                    /*List<int> incomingValus = new List<int>(chart.AxisX.Count);
                    List<int> outgoingValus = new List<int>(chart.AxisX.Count);
                    valus = new List<int>(chart.AxisX.Count);
                    for (int x = 0; x < dateList.Count - 1; x++)
                    {
                        List<Storage_Item_Struct> temp = storageList(dateList[x], dateList[x + 1]);
                        incomingValus.Add(temp.Select(strg => strg.incoming).Sum());
                        outgoingValus.Add(temp.Select(strg => strg.outgoing).Sum());
                        valus.Add(outgoingValus[x] - incomingValus[x]);
                    }
                    collect.Add(new LineSeries() { Title = "أجهزة واردة للمخازن", Values = new ChartValues<int>(incomingValus) });
                    collect.Add(new LineSeries() { Title = "توريد أجهزة للعملاء", Values = new ChartValues<int>(outgoingValus) });
                    collect.Add(new LineSeries() { Title = "صافي الحركات (المورد للعملاء - الوارد)", Values = new ChartValues<int>(valus) });*/
                    break;
            }
            chart.Series = collect;
        }
        private static void PrepareChart(LiveCharts.WinForms.CartesianChart chart, List<DateTime> dateTimes)
        {
            chart.Visible = false;
            chart.Series.Clear();
            chart.BackColor = Color.Transparent;
            chart.AxisX.Clear(); chart.AxisY.Clear();
            chart.AxisX.Add(new Axis
            {
                Title = "التاريخ",
                Labels = dateTimes.Select(p => p.ToString("yyyy-MMMM-dd", CultureInfo.GetCultureInfo("ar-EG"))).ToArray(),
                FontFamily = new System.Windows.Media.FontFamily("El Messiri"),
                FontSize = 13F,
                Foreground = System.Windows.Media.Brushes.Black
            });
            chart.AxisY.Add(new Axis
            {
                Title = "القيمة",
                LabelFormatter = value => value.ToString("00"),
                FontFamily = new System.Windows.Media.FontFamily("El Messiri"),
                FontSize = 13F,
                Foreground = System.Windows.Media.Brushes.Black
            }) ;
            chart.LegendLocation = LegendLocation.Bottom;
            chart.DefaultLegend.FontFamily = new System.Windows.Media.FontFamily("Cairo");
            chart.DefaultLegend.FontSize = 12;
            chart.Visible = true;
        }
        private static List<DateTime> getDateList(DateTime from, DateTime to, Enums.Span Span)
        {
            switch (Span)
            {
                case Enums.Span.سنوي:
                    return Enumerable.Range(from.Year, (to.Year + 2) - from.Year).Select(p => new DateTime(p, 1, 1)).ToList();
                case Enums.Span.شهري:
                    return Enumerable.Range(0,(int)((to.Subtract(from).TotalDays / 30) + 2)).Select(p => new DateTime(from.AddMonths(p).Year, from.AddMonths(p).Month, 1)).ToList();
                case Enums.Span.يومي:
                    return Enumerable.Range(0, (int)(to.Subtract(from).TotalDays  + 2)).Select(p => new DateTime(from.AddDays(p).Year, from.AddDays(p).Month, from.AddDays(p).Day)).ToList();
                default: return null;
            }
        }

        public static void UpdatePieChart(LiveCharts.WinForms.PieChart pieChart, BrightIdeasSoftware.CreateGroupsEventArgs listviewGroupsSortsArgs)
        {
            pieChart.Visible = false;
            pieChart.Series.Clear();
            pieChart.LegendLocation = LegendLocation.Bottom;
            pieChart.DefaultLegend.FontFamily = new System.Windows.Media.FontFamily("Cairo");
            pieChart.DefaultLegend.FontSize = 12;
            pieChart.BackColor = Color.Transparent;
            pieChart.Visible = true;
            SeriesCollection collection = new SeriesCollection();
            if (listviewGroupsSortsArgs.Groups == null || listviewGroupsSortsArgs.Groups.Count == 0) return;
            foreach (var grp in listviewGroupsSortsArgs.Groups)
            {
                switch (listviewGroupsSortsArgs.Parameters.PrimarySort.Tag.ToString())
                {
                    case "decimal":
                    case "double":
                        collection.Add(new PieSeries() { Title = grp.SortValue == null ? "" : grp.SortValue.ToString(), Values = new ChartValues<decimal>(new List<decimal> { grp.Items.OfType<BrightIdeasSoftware.OLVListItem>().Select(item => decimal.Parse(item.SubItems[listviewGroupsSortsArgs.Parameters.PrimarySort.Index].Text)).Sum() }) });
                        break;
                    default:
                        collection.Add(new PieSeries() { Title = grp.SortValue == null ? "" : grp.SortValue.ToString(), Values = new ChartValues<int>(new List<int> { grp.Items.Count }) });
                        break;
                }
            }
            pieChart.Series = collection;
        }
    }
}
