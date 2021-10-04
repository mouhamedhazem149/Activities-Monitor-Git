using System;
using System.Collections.Generic;
using System.Linq;
using OpsMoi.Models;

namespace OpsMoi.User_Interfaces.Reports
{
    public static partial class Reports_Processor
    {
        public static List<Finances> FinancesList(DateTime from, DateTime to) => Program.Finances_List.Where(tdo => (tdo.due_date > from || (tdo.done_date.HasValue && tdo.done_date.Value > from)) && (tdo.due_date < to || (tdo.done_date.HasValue && tdo.done_date.Value < to))).ToList();

        public static List<Todos> TodosList(DateTime from, DateTime to) => Program.Todos_List.Where(tdo => (tdo.due_date > from || tdo.added_date > from || (tdo.done_date.HasValue && tdo.done_date.Value > from)) &&
        (tdo.due_date < to || tdo.added_date < to || (tdo.done_date.HasValue && tdo.done_date.Value < to))).ToList();

        public static List<Models.Notes> NotesList(string searchWord) => Program.Notes_List.Where(nt => nt.title.Contains(searchWord) || nt.strNote.Contains(searchWord)).ToList();

    }
}
