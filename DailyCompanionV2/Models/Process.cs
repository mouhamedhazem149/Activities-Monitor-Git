namespace DailyCompanionV2.Models
{
    public class Process
    {
        public int id { get; set; }
        public string name { get; set; } //اللي هيظهر في القائمة اللي هتختار منها
        public string processname { get; set; } // اسم ال process اللي هنعملها start
        public int nooutput { get; set; }
        public bool NoWindow
        {
            get => nooutput == 1;
            set { nooutput = value ? 1 : 0; }
        }
    }
}
