using System;
using System.Collections.Generic;
using System.Linq;

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
        public DateTime added_date { get { return addeddate != null ? DateTime.Parse(addeddate) : DateTime.Now; } set { addeddate = value.ToString("g"); } }

        public string duedate { get; set; }
        public DateTime due_date { get { return duedate != null ? DateTime.Parse(duedate) : DateTime.Now; } set { duedate = value.ToString("g"); } }

        public string startdate { get; set; }
        public DateTime start_date { get { return startdate != null ? DateTime.Parse(startdate) : DateTime.Now; } set { startdate = value.ToString("g"); } }
        
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

        public string chklist
        {
            get => chkpoint_list != null ? string.Join(Checkpoint.chkpointSeparator, chkpoint_list.Select(p => p.ToString()).ToList()): "";
            set
            {
                string[] chk_points = value.Length > 1 ? value.Split(new string[] { Checkpoint.chkpointSeparator }, StringSplitOptions.None) : new string[0];
                chkpoint_list = new List<Checkpoint>(chk_points.Length);
                foreach (string chkPoint in chk_points)
                    chkpoint_list.Add(Checkpoint.GetCheckpoint(chkPoint));
            }
        }
        public List<Checkpoint> chkpoint_list { get;  set;}

        public bool Equals(Todos obj) => id == obj.id && duefrom == obj.duefrom && dueto == obj.dueto && category == obj.category && todo == obj.todo && addeddate == obj.addeddate && startdate == obj.startdate && duedate == obj.duedate && donedate == obj.donedate && duration == obj.duration && notes == obj.notes;
    }
}
