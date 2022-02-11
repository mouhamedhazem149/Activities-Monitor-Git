using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailyCompanionV2.Models;
using DailyCompanionV2.Utilities;

namespace DailyCompanionV2.User_Interfaces.Dashboard
{
    public static partial class Dashboard_Processor
    {
        public static Dictionary<Enums.DashboardField, string> Dashboard_Elements { get; private set; } = new Dictionary<Enums.DashboardField, string>();
        public static List<History> LoadHistory(DateTime From, DateTime To) =>
            Program.History_List.Where(hst => hst.datetime >= From && hst.datetime <= To).OrderBy(item => item.id).ToList();// ORDER BY id ASC // LIMIT 500
        
        public async static Task LoadDashboardElements()
        {
            Dashboard_Elements.Clear();
            List<Task> tskList = new List<Task> { new Task(Load_TODO_Section), new Task(Load_FNC_Section), new Task(Load_NOT_Section) };
            Parallel.ForEach(tskList, tsk => { tsk.Start(); });
            await Task.WhenAll(tskList);//
        }
        private static void Load_TODO_Section()
        {
            var monthTodos = Reports.Reports_Processor.TodosList(DateTime.Now.AddDays(-1 * (DateTime.Now.Day - 1)), DateTime.Now.AddDays(-1 * (DateTime.Now.Day - 1)).AddMonths(1));
            double Months_Span = Math.Max(Program.Todos_List.Select(tdo => tdo.due_date).Max().Subtract(Program.Todos_List.Select(tdo => tdo.due_date).Min()).TotalDays / 30, 1);
            AddDictionarycheckKey(Dashboard_Elements,Enums.DashboardField.الإجمالي_مهام, $"{Program.Todos_List.Count} مهمة بمدة : {HM_Manager.MinutesToDuration(Program.Todos_List.Select(tdo => tdo.duration).Sum())}");
            AddDictionarycheckKey(Dashboard_Elements,Enums.DashboardField.إجمالي_الشهر_مهام, $"{monthTodos.Count} بإجمالي مدة : {HM_Manager.MinutesToDuration(monthTodos.Select(tdo => tdo.duration).Sum())}");
            AddDictionarycheckKey(Dashboard_Elements,Enums.DashboardField.متوسط_مهام, $"{(Program.Todos_List.Count / Months_Span).ToString("F2")} مهمة بمتوسط مدة : {HM_Manager.MinutesToDuration(Program.Todos_List.Select(tdo => tdo.duration).Sum() / Months_Span)}");
            AddDictionarycheckKey(Dashboard_Elements,Enums.DashboardField.مطلوب_مهام, $"{Program.Todos_List.Where(p => !p.done_date.HasValue).Count()} مهمة");
        
        }
        private static void Load_FNC_Section()
        {
            var monthFNCs = Reports.Reports_Processor.FinancesList(DateTime.Now.Subtract(new TimeSpan(DateTime.Now.Day, 0, 0, 0)), DateTime.Now.AddMonths(1));
            var total = Program.Finances_List;
            var income = Program.Finances_List.Where(fnc => fnc.type == Enums.financeType.دخل).ToList();
            var outcome = Program.Finances_List.Where(fnc => fnc.type == Enums.financeType.مدفوعات).ToList();
            var trans = Program.Finances_List.Where(fnc => fnc.type == Enums.financeType.تحويل_أرصدة).ToList();
            var required = Program.Finances_List.Where(fnc => !fnc.done_date.HasValue);
            double Months_Span = Math.Max(Program.Finances_List.Select(fnc => fnc.due_date).Max().Subtract(Program.Finances_List.Select(fnc => fnc.due_date).Min()).TotalDays / 30, 1);

            double totalSum = monthFNCs.Select(fnc => fnc.paid).Sum(); double incomeSum = monthFNCs.Where(p => p.type == Enums.financeType.دخل).Select(fnc => fnc.paid).Sum(); double outcomeSum = monthFNCs.Where(p => p.type == Enums.financeType.مدفوعات).Select(fnc => fnc.paid).Sum(); double transSum = monthFNCs.Where(p => p.type == Enums.financeType.تحويل_أرصدة).Select(fnc => fnc.paid).Sum();
            AddDictionarycheckKey(Dashboard_Elements,Enums.DashboardField.إجمالي_الشهر_مالية, $"إجمالي عمليات : {monthFNCs.Count}({monthFNCs.Count(p => p.type == Enums.financeType.دخل)}/{monthFNCs.Count(p => p.type == Enums.financeType.مدفوعات)}/{monthFNCs.Count(p => p.type == Enums.financeType.تحويل_أرصدة)})" +
                $" بإجمالي قيمة : {totalSum.ToString("F2")}({incomeSum.ToString("F2")}/{outcomeSum.ToString("F2")}/{(transSum / Months_Span).ToString("F2")}) بصافي : {(incomeSum - outcomeSum).ToString("F2")}");

            totalSum = total.Select(fnc => fnc.paid).Sum(); incomeSum = income.Select(fnc => fnc.paid).Sum(); outcomeSum = outcome.Select(fnc => fnc.paid).Sum(); transSum = trans.Select(fnc => fnc.paid).Sum();
            AddDictionarycheckKey(Dashboard_Elements,Enums.DashboardField.الإجمالي_مالية, $"إجمالي عمليات : {total.Count}({income.Count}/{outcome.Count}/{trans.Count})" +
                $" بإجمالي قيمة : {totalSum.ToString("F2")}({incomeSum.ToString("F2")}/{outcomeSum.ToString("F2")}/{(transSum / Months_Span).ToString("F2")}) بصافي : {(incomeSum - outcomeSum).ToString("F2")}");

            AddDictionarycheckKey(Dashboard_Elements,Enums.DashboardField.متوسط_مالية, $"متوسط عمليات : {(total.Count / Months_Span).ToString("F2")}({(income.Count / Months_Span).ToString("F2")}/{(outcome.Count / Months_Span).ToString("F2")}/{(trans.Count / Months_Span).ToString("F2")})" +
                $"بمتوسط قيمة : {(totalSum / Months_Span).ToString("F2")}({(incomeSum / Months_Span).ToString("F2")}/{(outcomeSum / Months_Span).ToString("F2")}/{(transSum / Months_Span).ToString("F2")}) بصافي : {((incomeSum - outcomeSum) / Months_Span).ToString("F2")}");

            totalSum = required.Select(fnc => fnc.paid).Sum(); incomeSum = required.Where(p => p.type == Enums.financeType.دخل).Select(fnc => fnc.paid).Sum(); outcomeSum = required.Where(p => p.type == Enums.financeType.مدفوعات).Select(fnc => fnc.paid).Sum(); transSum = required.Where(p => p.type == Enums.financeType.تحويل_أرصدة).Select(fnc => fnc.paid).Sum();
            AddDictionarycheckKey(Dashboard_Elements,Enums.DashboardField.مطلوب_مالية, $"إجمالي عمليات : {required.Count()}({required.Count(p => p.type == Enums.financeType.دخل)}/{required.Count(p => p.type == Enums.financeType.مدفوعات)}/{required.Count(p => p.type == Enums.financeType.تحويل_أرصدة)}" +
                $" بإجمالي قيمة : {totalSum.ToString("F2")}({incomeSum.ToString("F2")}/{outcomeSum.ToString("F2")}/{(transSum / Months_Span).ToString("F2")}) بصافي : {(incomeSum - outcomeSum).ToString("F2")}");
        }
        private static void Load_NOT_Section()
        {
            int count = Program.Notes_List.Count; int length = Program.Notes_List.Select(not => not.strNote.Length).Sum();
            AddDictionarycheckKey(Dashboard_Elements,Enums.DashboardField.الإجمالي_ملاحظات, $"{count} ملاحظة بأطوال : {length}");
            AddDictionarycheckKey(Dashboard_Elements,Enums.DashboardField.متوسط_ملاحظات, $"{(length / count).ToString("F2")} حرف / ملاحظة");
        }
        static void AddDictionarycheckKey<T,Y>(Dictionary<T,Y> dict,T Key,Y Value)
        {
            if (dict.Keys.Contains(Key)) dict[Key] = Value;
            else dict.Add(Key, Value);
        }
    }
}
