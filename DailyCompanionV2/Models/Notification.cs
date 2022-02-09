using System;

namespace DailyCompanionV2.Models
{
    public class Notification
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string notifDate { get; set; } = DateTime.Now.ToString("g");
        public DateTime notif_Date { get => DateTime.Parse(notifDate); set { notifDate = value.ToString("g"); } }
        private Utilities.Enums.notifFrequency _frequency;
        public Utilities.Enums.notifFrequency frequency
        {
            get => _frequency;
            set
            {
                switch (value)
                {
                    case Utilities.Enums.notifFrequency.سنوي:
                        freqDInt = 365.25;
                        break;
                    case Utilities.Enums.notifFrequency.شهري:
                        freqDInt = 30;
                        break;
                    case Utilities.Enums.notifFrequency.أسبوعي:
                        freqDInt = 7;
                        break;
                    case Utilities.Enums.notifFrequency.يومي:
                        freqDInt = 1;
                        break;
                }
                _frequency = value;
            }
        }
        public double freqDInt { get; set; }
        
        private Utilities.Enums.notifRepeat _repeat;
        public Utilities.Enums.notifRepeat repeat
        {
            get => _repeat;
            set
            {
                switch (value)
                {
                    case Utilities.Enums.notifRepeat.محدد:
                        repeatInt = 1;
                        break;
                    case Utilities.Enums.notifRepeat.دائم:
                        repeatInt = 0;
                        break;
                }
                _repeat = value;
            }
        }
        public int repeatInt { get; set; } = 0;
        public bool done => !done_date.HasValue ? false : lastDate > done_date ? false : true;
        //(int)Math.Floor(DateTime.Now.Subtract(notif_Date).TotalDays / freqDInt) > (int)Math.Floor(done_date.Value.Subtract(notif_Date).TotalDays / freqDInt) ? 0 : 1;
        // lastDate > done_date
        public string donedate { get; set; }
        public DateTime? done_date { get { if (donedate != null) return DateTime.Parse(donedate); else return null; } set { if (value != null) donedate = value.Value.ToString("g"); } }
        public bool completed =>
            repeat != Utilities.Enums.notifRepeat.دائم && DateTime.Now.Subtract(notif_Date).TotalDays / freqDInt > repeatInt;

        public DateTime lastDate
        {
            get
            {
                int counter = completed ? repeatInt : freqDInt != 0 ? (int)Math.Floor(DateTime.Now.Subtract(notif_Date).TotalDays / freqDInt) : 0;
                switch (frequency)
                {
                    case Utilities.Enums.notifFrequency.سنوي:
                        return notif_Date.AddYears(counter);
                    case Utilities.Enums.notifFrequency.شهري:
                        return notif_Date.AddMonths(counter);
                    case Utilities.Enums.notifFrequency.أسبوعي:
                    case Utilities.Enums.notifFrequency.يومي:
                    case Utilities.Enums.notifFrequency.آخر:
                        return notif_Date.AddDays(freqDInt * counter);
                    default: return DateTime.Now;
                }
            }
        }
        public DateTime? nextDate
        {
            get
            {
                if (completed) return null;
                        int counter = freqDInt != 0 ? (int)Math.Ceiling(DateTime.Now.Subtract(notif_Date).TotalDays / freqDInt) : 0;
                switch (frequency)
                {
                    case Utilities.Enums.notifFrequency.سنوي:
                        return notif_Date.AddYears(counter);
                    case Utilities.Enums.notifFrequency.شهري:
                        return notif_Date.AddMonths(counter);
                    case Utilities.Enums.notifFrequency.أسبوعي:
                    case Utilities.Enums.notifFrequency.يومي:
                    case Utilities.Enums.notifFrequency.آخر:
                        return notif_Date.AddDays(freqDInt * counter);
                    default: return null;
                }
            }
        }
        public string btn => "تم";
        public bool Equals(Notification obj) =>
            id == obj.id && title == obj.title && description == obj.description && category == obj.category && notifDate == obj.notifDate && frequency == obj.frequency && freqDInt == obj.freqDInt && repeat == obj.repeat && repeatInt == obj.repeatInt && done_date == obj.done_date;
    }
}
