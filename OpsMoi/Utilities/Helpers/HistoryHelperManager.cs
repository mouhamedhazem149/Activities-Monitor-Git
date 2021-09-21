using System;
using System.Collections.Generic;
using System.Globalization;
using OpsMoi.Models;

namespace OpsMoi.Utilities
{
    public static partial class HM_Manager
    {
        public static void HandleHistory(string[] history_items)
        {
            List<History> History_List = new List<History>();
            History_List.Add(new History
            {
                table_affected = history_items[0],
                operation = history_items[1],
                add_info = history_items[2],
                datetime = history_items.Length == 4 ? DateTime.ParseExact(history_items[3], "yyyy-MM-dd", CultureInfo.InvariantCulture) : DateTime.Now,
            });
            DBHelper.Insert_Database("history", new List<string> { "table_affected", "date", "operation", "add_info" }, History_List);
        }
    }
}
