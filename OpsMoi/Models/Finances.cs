using System;

namespace OpsMoi.Models
{
    public class Finances
    {
        public int id { get; set; }
        
        public int wallet { get; set; }
        
        public string relatedentity { get; set; }
        public Utilities.Enums.financeType type { get; set; }
        public string category { get; set; }
        
        public double due { get; set; }
        public double paid { get; set; }
        
        public string duedate { get; set; }
        public DateTime due_date { get => DateTime.Parse(duedate); set { duedate = value.ToString("g"); } }
        
        public string donedate { get; set; }
        public DateTime? done_date { get { if (donedate != null) return DateTime.Parse(donedate); else return null; } set { if (value != null) donedate = value.Value.ToString("g"); } }
        public string str_done_date
        {
            get { if (done_date.HasValue) return done_date.Value.ToString("dddd, dd-MMMM-yyyy :: hh-mm tt"); else return Utilities.HM_Manager.dateNotFinished; ; }
            set
            {
                DateTime temp = new DateTime();
                if (DateTime.TryParse(value, out temp)) done_date = DateTime.Parse(value);
                else done_date = null;
            }
        }

        public string notes { get; set; }

        public bool Equals(Finances obj) => (id == obj.id && relatedentity == obj.relatedentity && type == obj.type && category == obj.category && due == obj.due && paid == obj.paid && duedate == obj.duedate && donedate == obj.donedate && notes == obj.notes);
    }
}
