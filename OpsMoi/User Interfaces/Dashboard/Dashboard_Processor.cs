using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using OpsMoi.Models;
using OpsMoi.Utilities;

namespace OpsMoi.User_Interfaces.Dashboard
{
    public static class Dashboard_Processor
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
            var monthTodos = Reports.Reports_Processor.TodosList(DateTime.Now.Subtract(new TimeSpan(DateTime.Now.Day, 0, 0, 0)), DateTime.Now.AddMonths(1));
            Dashboard_Elements.Add(Enums.DashboardField.إجمالي_عدد_المهام_المطلوبة, Program.Todos_List.Count.ToString());
            Dashboard_Elements.Add(Enums.DashboardField.عدد_المهام_المطلوبة_هذا_الشهر, monthTodos.Count.ToString());
            double Months_Span = Math.Max(Program.Todos_List.Select(tdo => tdo.due_date).Max().Subtract(Program.Todos_List.Select(tdo => tdo.due_date).Min()).TotalDays / 30, 1);
            Dashboard_Elements.Add(Enums.DashboardField.متوسط_عدد_المهام_الشهر, (int.Parse(Dashboard_Elements[Enums.DashboardField.إجمالي_عدد_المهام_المطلوبة]) / Months_Span).ToString("F2"));
            Dashboard_Elements.Add(Enums.DashboardField.إجمالي_المدة_المستغرقة, HM_Manager.MinutesToDuration(Program.Todos_List.Select(tdo => tdo.duration).Sum()));
            Dashboard_Elements.Add(Enums.DashboardField.إجمالي_المدة_المستغرقة_هذا_الشهر, HM_Manager.MinutesToDuration(monthTodos.Select(tdo => tdo.duration).Sum()));
            Dashboard_Elements.Add(Enums.DashboardField.متوسط_المدة_المستغرقة_الشهر, HM_Manager.MinutesToDuration(monthTodos.Select(tdo => tdo.duration).Sum() / Months_Span));
        }
        private static void Load_FNC_Section()
        {
            var monthFNCs = Reports.Reports_Processor.FinancesList(DateTime.Now.Subtract(new TimeSpan(DateTime.Now.Day, 0, 0, 0)), DateTime.Now.AddMonths(1));
            var total = Program.Finances_List; var income = Program.Finances_List.Where(fnc => fnc.type == Enums.financeType.دخل).ToList(); var outcome = Program.Finances_List.Where(fnc => fnc.type == Enums.financeType.مدفوعات).ToList(); var trans = Program.Finances_List.Where(fnc => fnc.type == Enums.financeType.تحويل_أرصدة).ToList();
            Dashboard_Elements.Add(Enums.DashboardField.إجمالي_عدد_العمليات_المالية_, $"إجمالي : {total.Count} (دخل: {income.Count} / مصروف: {outcome.Count} / تحويل: {trans.Count})");
            Dashboard_Elements.Add(Enums.DashboardField.عدد_العمليات_المالية_هذا_الشهر, $"إجمالي : {monthFNCs.Count} (دخل: {monthFNCs.Count(p => p.type == Enums.financeType.دخل)} / مصروف: {monthFNCs.Count(p => p.type == Enums.financeType.مدفوعات)} / تحويل: {monthFNCs.Count(p => p.type == Enums.financeType.تحويل_أرصدة)}  )");

            double Months_Span = Math.Max(Program.Finances_List.Select(fnc => fnc.due_date).Max().Subtract(Program.Finances_List.Select(fnc => fnc.due_date).Min()).TotalDays / 30, 1);
            Dashboard_Elements.Add(Enums.DashboardField.متوسط_عدد_العمليات_المالية__الشهر, $"إجمالي : {(total.Count / Months_Span).ToString("F2")} (دخل: {(income.Count / Months_Span).ToString("F2")} / مصروف: {(outcome.Count / Months_Span).ToString("F2")}) / تحويل: {(trans.Count / Months_Span).ToString("F2")} ");

            double totalSum = monthFNCs.Select(fnc => fnc.paid).Sum(); double incomeSum = monthFNCs.Where(p => p.type == Enums.financeType.دخل).Select(fnc => fnc.paid).Sum(); double outcomeSum = monthFNCs.Where(p => p.type == Enums.financeType.مدفوعات).Select(fnc => fnc.paid).Sum(); double transSum = monthFNCs.Where(p => p.type == Enums.financeType.تحويل_أرصدة).Select(fnc => fnc.paid).Sum();
            Dashboard_Elements.Add(Enums.DashboardField.قيمة_العمليات_المالية_هذا_الشهر, $"إجمالي : {totalSum.ToString("F2")} (دخل: {incomeSum.ToString("F2")} / مصروف: {outcomeSum.ToString("F2")} / تحويل: {(transSum / Months_Span).ToString("F2")}) صافي: {(incomeSum - outcomeSum).ToString("F2")}");

            totalSum = total.Select(fnc => fnc.paid).Sum(); incomeSum = income.Select(fnc => fnc.paid).Sum(); outcomeSum = outcome.Select(fnc => fnc.paid).Sum(); transSum = outcome.Select(fnc => fnc.paid).Sum();
            Dashboard_Elements.Add(Enums.DashboardField.إجمالي_قيمة_العمليات_المالية, $"إجمالي : {totalSum.ToString("F2")} (دخل: {incomeSum.ToString("F2")} / مصروف: {outcomeSum.ToString("F2")} / تحويل: {(transSum / Months_Span).ToString("F2")}) صافي: {(incomeSum - outcomeSum).ToString("F2")}");

            Dashboard_Elements.Add(Enums.DashboardField.متوسط_قيمة_العمليات_المالية_الشهر, $"إجمالي : {(totalSum / Months_Span).ToString("F2")} (دخل: {(incomeSum / Months_Span).ToString("F2")} / تحويل: {(transSum / Months_Span).ToString("F2")} / مصروف: {(outcomeSum / Months_Span).ToString("F2")}) صافي: {((incomeSum - outcomeSum) / Months_Span).ToString("F2")}");
        }
        private static void Load_NOT_Section()
        {
            int count = Program.Notes_List.Count; int length = Program.Notes_List.Select(not => not.strNote.Length).Sum();
            Dashboard_Elements.Add(Enums.DashboardField.إجمالي_عدد_الملاحظات, $"{count}");
            Dashboard_Elements.Add(Enums.DashboardField.إجمالي_طول_الملاحظات, $"{length}");
            Dashboard_Elements.Add(Enums.DashboardField.متوسط_طول_الملاحظات, $"{(length / count).ToString("F2")}");
        }
        // // // // // // // // // // // // // // // // // // // // // // // //
        public static void Add_TODO_Button() => Program.WorkingForm.Click_TODO(Enums.todoArgument.showTodoManager, null);
        public static void Show_TODO_Button() => Program.WorkingForm.Click_Reports(Enums.report_tabState.مهام);
        // // // // // // // // // // // // // // // // // // // // // // // //
        public static void Add_FNC_Button() => Program.WorkingForm.Click_FNC(Enums.financeArgument.showFinanceManager, null);
        public static void Show_FNC_Button() => Program.WorkingForm.Click_Reports(Enums.report_tabState.مالية);
        // // // // // // // // // // // // // // // // // // // // // // // //
        public static void Add_NOT_Button() => Program.WorkingForm.Click_Note(Enums.noteArgument.showNoteManager, null);
        public static void Show_NOT_Button() => Program.WorkingForm.Click_Reports(Enums.report_tabState.ملاحظات);
        // // // // // // // // // // // // // // // // // // // // // // // //
    }
}
