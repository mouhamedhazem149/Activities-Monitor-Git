using System;
using System.Linq;

namespace DailyCompanionV2.Models
{
    public class Finances
    {
        public int id { get; set; }
        
        public int wallet { get; set; }
        public string wltName => Program.Wallets_List.Where(p => p.id == wallet).FirstOrDefault() != null ? Program.Wallets_List.Where(p => p.id == wallet).First().name : "";
        public string relatedentity { get; set; }
        public Utilities.Enums.financeType type { get; set; }
        public string category { get; set; }
        
        public double due { get; set; }
        public double paid { get; set; }
        
        public string duedate { get; set; }
        public DateTime due_date { get { return duedate != null ? DateTime.Parse(duedate) : DateTime.Now; } set { duedate = value.ToString("g"); } }
        
        public string donedate { get; set; }
        public DateTime? done_date { get { if (donedate != null) return DateTime.Parse(donedate); else return null; } set { if (value != null) donedate = value.Value.ToString("g"); else donedate = null; } }
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
        public string lstupdt { get; set; }
        public DateTime lst_updt { get { return lstupdt != null ? DateTime.Parse(lstupdt) : DateTime.Now; } set { lstupdt = value.ToString("g"); } }
        public string notes { get; set; }
        public bool Equals(Finances obj) => (id == obj.id && relatedentity == obj.relatedentity && type == obj.type && category == obj.category && due == obj.due && paid == obj.paid && duedate == obj.duedate && donedate == obj.donedate && notes == obj.notes);
        public string String => $"{id} {relatedentity} {wltName} {Utilities.Enums.GetDisplayName(type)} {category} {due} {paid} {duedate} {str_done_date} {notes}";
    }
}
