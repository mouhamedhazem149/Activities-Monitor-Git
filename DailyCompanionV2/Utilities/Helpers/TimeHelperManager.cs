using System;
using System.Text;

namespace DailyCompanionV2.Utilities
{
    public static partial class HM_Manager
    {
        public static string MinutesToDuration(object mins)
        {
            try
            {
                double minutes = double.Parse(mins.ToString());
                TimeSpan tSpan = TimeSpan.FromMinutes(minutes);
                StringBuilder strDuration = new StringBuilder();
                if (tSpan.Days > 365)
                {
                    int years = (int)(tSpan.Days / 365);
                    if (years == 2) strDuration.Append("عامان");
                    else if (years <= 10 && years != 1) strDuration.Append($"{years} أعوام");
                    else strDuration.Append($"{years} عام");
                    tSpan = new TimeSpan(tSpan.Days % 365, tSpan.Hours, tSpan.Minutes, tSpan.Seconds);
                    strDuration.Append(" و ");
                }
                if (tSpan.Days > 30)
                {
                    int months = (int)(tSpan.Days / 30);
                    if (months == 2) strDuration.Append("شهرين");
                    else if (months <= 10 && months != 1) strDuration.Append($"{months} شهور");
                    else strDuration.Append($"{months} شهر");
                    tSpan = new TimeSpan(tSpan.Days % 30, tSpan.Hours, tSpan.Minutes, tSpan.Seconds);
                    strDuration.Append(" و ");
                }
                if (tSpan.Days > 0)
                {
                    int days = tSpan.Days;
                    if (days == 2) strDuration.Append("يومان");
                    else if (days <= 10 && days != 1) strDuration.Append($"{days} أيام");
                    else strDuration.Append($"{days} يوم");
                    tSpan = new TimeSpan(tSpan.Hours, tSpan.Minutes, tSpan.Seconds);
                    strDuration.Append(" و ");
                }
                if (tSpan.Hours > 0)
                {
                    if (tSpan.Hours == 2) strDuration.Append("ساعتان");
                    else if (tSpan.Hours <= 10 && tSpan.Hours != 1) strDuration.Append($"{tSpan.Hours} ساعات");
                    else strDuration.Append($"{tSpan.Hours} ساعة");
                    tSpan = new TimeSpan(0, tSpan.Minutes, tSpan.Seconds);
                    strDuration.Append(" و ");
                }
                if (tSpan.Minutes > 0)
                {
                    if (tSpan.Minutes == 2) strDuration.Append("دقيقتان");
                    else if (tSpan.Minutes <= 10 && tSpan.Minutes != 1) strDuration.Append($"{tSpan.Minutes} دقائق");
                    else strDuration.Append($"{tSpan.Minutes} دقيقة");
                    tSpan = new TimeSpan(0, 0, tSpan.Seconds);
                    strDuration.Append(" و ");
                }
                if (tSpan.Seconds >= 0)
                {
                    if (tSpan.Seconds == 2) strDuration.Append("ثانيتان");
                    else if (tSpan.Seconds <= 10 && tSpan.Seconds != 1) strDuration.Append($"{tSpan.Seconds} ثوانٍ");
                    else strDuration.Append($"{tSpan.Seconds} ثانية");
                }
                return $"{strDuration} تقريبًا";
            }
            catch (Exception) { return ""; }
        }
    }
}
