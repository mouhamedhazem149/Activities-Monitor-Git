using System;

namespace OpsMoi.Models
{
    public class Todos
    {
        public int id { get; set; }
        public string duefrom { get; set; }
        public string dueto { get; set; }
        public string category { get; set; }
        public string todo { get; set; }

        public string addeddate { get; set; }
        public DateTime added_date { get => DateTime.Parse(addeddate); set { addeddate = value.ToString("g"); } }

        public string duedate { get; set; }
        public DateTime due_date { get => DateTime.Parse(duedate); set { duedate = value.ToString("g"); } }

        public string donedate { get; set; }
        public DateTime? done_date { get { if (donedate != null) return DateTime.Parse(donedate); else return null; } set {if (value != null) donedate = value.Value.ToString("g"); } }
        public string str_done_date
        {
            get { if (done_date.HasValue) return done_date.Value.ToString("dddd, dd-MMMM-yyyy :: hh-mm tt"); else return Utilities.HM_Manager.dateNotFinished; }
            set
            {
                DateTime temp = new DateTime();
                if (DateTime.TryParse(value, out temp)) done_date = DateTime.Parse(value);
                else done_date = null;
            }
        }

        public double duration { get; set; }
        public string notes { get; set; }

    }
}
