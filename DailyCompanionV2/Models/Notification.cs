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
                        freqDInt = 365.25M;
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
        public decimal freqDInt { get; set; }
        
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
        private int _repeatInt = 0;
        public int repeatInt
        {
            get => _repeatInt; 
            set
            {
                if (value == 0)
                    _repeat = Utilities.Enums.notifRepeat.دائم;
                _repeatInt = value;
            }
        }
        public bool done => DateTime.Now >= notif_Date ? !done_date.HasValue ? false : lastDate.Value > done_date ? false : true : true;
        // هل تم اخر مرة
        public string donedate { get; set; }
        public DateTime? done_date { get { if (donedate != null) return DateTime.Parse(donedate); else return null; } set { if (value != null) donedate = value.Value.ToString("g"); else donedate = null; } }
        public bool completed => DateTime.Now >= notif_Date && repeat != Utilities.Enums.notifRepeat.دائم && DateTime.Now >= finalDate;
        // هل مش هينبه بعد كده
        public DateTime? lastDate
        {
            get
            {
                if (DateTime.Now < notif_Date) return null;
                int counter = completed ? repeatInt - 1 : freqDInt != 0 ? (int)Math.Floor(DateTime.Now.Subtract(notif_Date).TotalDays / (double)freqDInt) : 0;
                switch (frequency)
                {
                    case Utilities.Enums.notifFrequency.سنوي:
                        return notif_Date.AddYears(counter);
                    case Utilities.Enums.notifFrequency.شهري:
                        return notif_Date.AddMonths(counter);
                    case Utilities.Enums.notifFrequency.أسبوعي:
                    case Utilities.Enums.notifFrequency.يومي:
                    case Utilities.Enums.notifFrequency.آخر:
                        return notif_Date.AddDays((double)freqDInt * counter);
                    default: return DateTime.Now;
                }
            }
        }
        public string STRlastDate => lastDate.HasValue ? lastDate.Value.ToString("g") : "لم يحن موعد التنبيه بعد";
        public DateTime? nextDate
        {
            get
            {
                if (completed) return null;
                        int counter = freqDInt != 0 ? (int)Math.Ceiling(DateTime.Now.Subtract(notif_Date).TotalDays / (double)freqDInt) : 0;
                switch (frequency)
                {
                    case Utilities.Enums.notifFrequency.سنوي:
                        return notif_Date.AddYears(counter);
                    case Utilities.Enums.notifFrequency.شهري:
                        return notif_Date.AddMonths(counter);
                    case Utilities.Enums.notifFrequency.أسبوعي:
                    case Utilities.Enums.notifFrequency.يومي:
                    case Utilities.Enums.notifFrequency.آخر:
                        return notif_Date.AddDays((double)freqDInt * counter);
                    default: return null;
                }
            }
        }
        public string STRnextDate => nextDate.HasValue ? nextDate.Value.ToString("g") : "تم الانتهاء من هذا التنبيه";
        public DateTime? finalDate
        {
            get
            {
                switch (repeat)
                {
                    case Utilities.Enums.notifRepeat.دائم:
                        return null;
                    case Utilities.Enums.notifRepeat.محدد:
                        switch (frequency)
                        {
                            case Utilities.Enums.notifFrequency.سنوي:
                                return notif_Date.AddYears(repeatInt - 1);
                            case Utilities.Enums.notifFrequency.شهري:
                                return notif_Date.AddMonths(repeatInt - 1);
                            case Utilities.Enums.notifFrequency.أسبوعي:
                            case Utilities.Enums.notifFrequency.يومي:
                            case Utilities.Enums.notifFrequency.آخر:
                                return notif_Date.AddDays((double)freqDInt * (repeatInt - 1));
                            default: return DateTime.Now;
                        }
                    default: return null;
                }
            }
        }
        public string btn => "تم";
        public bool Equals(Notification obj) =>
            id == obj.id && title == obj.title && description == obj.description && category == obj.category && notifDate == obj.notifDate && frequency == obj.frequency && freqDInt == obj.freqDInt && repeat == obj.repeat && repeatInt == obj.repeatInt && done_date == obj.done_date;
    }
}
