using System;

namespace OpsMoi.Models
{
    public class Finances
    {
        public int id { get; set; }
        public string relatedentity { get; set; }
        public Utilities.Enums.financeType type { get; set; }
        public string category { get; set; }
        
        public double due { get; set; }
        public double paid { get; set; }
        
        public string duedate { get; set; }
        public DateTime due_date { get => DateTime.Parse(duedate); set { duedate = value.ToString("g"); } }
        
        public string donedate { get; set; }
        public DateTime? done_date { get { if (donedate != null) return DateTime.Parse(donedate); else return null; } set { if (value != null) donedate = value.Value.ToString("g"); } }
        public string str_done_date { get { if (done_date.HasValue) return done_date.Value.ToString("dddd, dd-MMMM-yyyy :: HH-mm"); else return Utilities.HM_Manager.dateNotFinished; ; } }

        public string notes { get; set; }

    }
}
