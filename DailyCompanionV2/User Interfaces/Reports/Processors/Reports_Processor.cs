using System;
using System.Collections.Generic;
using System.Linq;
using DailyCompanionV2.Models;

namespace DailyCompanionV2.User_Interfaces.Reports
{
    public static partial class Reports_Processor
    {
        public static List<Finances> FinancesList(DateTime from, DateTime to,string searchTerm = "") => Program.Finances_List.Where(tdo => (tdo.due_date >= from || (tdo.done_date.HasValue && tdo.done_date.Value >= from)) && (tdo.due_date <= to || (tdo.done_date.HasValue && tdo.done_date.Value <= to)))
            .Where(p => p.String.ToLower().Contains(searchTerm.ToLower())).ToList();
        public static List<Todos> TodosList(DateTime from, DateTime to, string searchTerm = "") => Program.Todos_List.Where(tdo => (tdo.due_date >= from /*|| tdo.added_date >= from */|| (tdo.done_date.HasValue && tdo.done_date.Value >= from)) &&
        (tdo.due_date <= to /*|| tdo.added_date <= to */|| (tdo.done_date.HasValue && tdo.done_date.Value <= to)))
            .Where(p => p.String.ToLower().Contains(searchTerm.ToLower())).ToList();
        public static List<Models.Notes> NotesList(string searchWord) => Program.Notes_List.Where(nt => nt.title.ToLower().Contains(searchWord.ToLower()) || nt.strNote.ToLower().Contains(searchWord.ToLower())).ToList();
    }
}
