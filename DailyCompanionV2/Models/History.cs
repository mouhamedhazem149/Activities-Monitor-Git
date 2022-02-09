using System;

namespace DailyCompanionV2.Models
{
    public class History
    {
        public int id { get; set; }

        public string table_affected { get; set; }
        public string operation { get; set; }
        public string add_info { get; set; }

        public string DT_String => datetime.ToString("dddd, dd MMMM yyyy HH:mm");
        public DateTime datetime { get => DateTime.Parse(date); set { date = value.ToString("g"); } }
        public string date { get; set; }

    }
    public static class HistoryHelper
    {
        public enum historyTables
        {

        }
        public static string aa_gg_addInfo = "";
    }
}
