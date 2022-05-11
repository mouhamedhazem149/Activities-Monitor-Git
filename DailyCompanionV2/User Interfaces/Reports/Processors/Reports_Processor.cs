using System;
using System.Collections.Generic;
using System.Linq;
using DailyCompanionV2.Models;
using DailyCompanionV2.Utilities;

namespace DailyCompanionV2.User_Interfaces.Reports
{
    public static partial class Reports_Processor
    {
        public static List<Finances> FinancesList(DateTime from, DateTime to,string searchTerm = "") => Program.Finances_List.Where(fnc => (fnc.due_date.IsBetween(from,to) || fnc.done_date.IsBetween(from,to)) 
        && fnc.String.ToLower().Contains(searchTerm.ToLower()))
            .ToList();
        public static List<Todos> TodosList(DateTime from, DateTime to, string searchTerm = "") => Program.Todos_List.Where(tdo => (tdo.due_date.IsBetween(from, to) || tdo.done_date.IsBetween(from, to))
        && tdo.String.ToLower().Contains(searchTerm.ToLower()))
            .ToList();
        public static List<Models.Notes> NotesList(string searchWord) => Program.Notes_List.Where(nt => nt.title.ToLower().Contains(searchWord.ToLower()) || nt.strNote.ToLower().Contains(searchWord.ToLower())).ToList();
    }
}
