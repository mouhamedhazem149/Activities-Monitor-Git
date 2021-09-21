using Airconditioning.Interfaces;
using Airconditioning.Utilities;
using System;
using System.Text.RegularExpressions;

namespace Airconditioning.Models
{
    public class Installment : IInstallment
    {
        public static string buttonPay_Text = "ادفع";

        public int index { get; set; }
        public decimal Value { get; set; }
        
        public DateTime due_Date { get; set; }
        public string due_Date_STRING { get { return due_Date.ToString("dddd, dd MMMM yyyy"); } set { due_Date = DateTime.ParseExact(value, "dddd, dd MMMM yyyy", System.Globalization.CultureInfo.InvariantCulture); } }

        public DateTime? actualpay_Date { get; set; } = null;
        public string actualpay_Date_STRING
        {
            get { return actualpay_Date.HasValue ? actualpay_Date.Value.ToString("dddd, dd MMMM yyyy") : "لم يتم الدفع بعد"; }
            set
            {
                if (value != null)
                    actualpay_Date = DateTime.ParseExact(value, "dddd, dd MMMM yyyy", System.Globalization.CultureInfo.InvariantCulture);
                else actualpay_Date = null;
            }
        }

        public string button { get { return state == Enums.installmentState.مدفوع ? null : buttonPay_Text; } }
        public Enums.installmentState state
        {
            get
            {
                if (actualpay_Date != null)
                    return Enums.installmentState.مدفوع;
                else if (due_Date > DateTime.Now.Date)
                    return Enums.installmentState.منتظر;
                else return Enums.installmentState.مستحق;
            }
        }

        public override string ToString()  //KEY:VALUE.DUE DATE.PAYMENT DATE
        {
            string payment_DATE = actualpay_Date.HasValue ? actualpay_Date.Value.ToString("yyyy-MM-dd") : "";
            return $"{index}:{Value}.{due_Date.ToString("yyyy-MM-dd")}.{payment_DATE}";
        }

        public void SetFromString(string Value)
        {
            if (Regex.IsMatch(Value, $@"({HM_Manager.decimalPattern}):({HM_Manager.decimalPattern}).({HM_Manager.datePattern}).({HM_Manager.datePattern})?"))
            {
                var match = Regex.Match(Value, $@"(?<index>{HM_Manager.decimalPattern}):(?<Value>{HM_Manager.decimalPattern}).(?<dueDate>{HM_Manager.datePattern}).(?<actualpay_Date>{HM_Manager.datePattern})?");
                this.index = int.Parse(match.Groups["index"].Value);
                this.Value = decimal.Parse(match.Groups["Value"].Value);
                this.due_Date = DateTime.Parse(match.Groups["dueDate"].Value);
                if (match.Groups["actualpay_Date"].Value.Length > 1) this.actualpay_Date = DateTime.Parse(match.Groups["actualpay_Date"].Value);
            }
        }

        public static Installment GetInstallment(string ins_string)
        {
            Installment temp = new Installment();
            if (Regex.IsMatch(ins_string, $@"({HM_Manager.decimalPattern}):({HM_Manager.decimalPattern}).({HM_Manager.datePattern}).({HM_Manager.datePattern})?"))
            {
                var match = Regex.Match(ins_string, $@"(?<index>{HM_Manager.decimalPattern}):(?<Value>{HM_Manager.decimalPattern}).(?<dueDate>{HM_Manager.datePattern}).(?<actualpay_Date>{HM_Manager.datePattern})?");
                temp.index = int.Parse(match.Groups["index"].Value);
                temp.Value = decimal.Parse(match.Groups["Value"].Value);
                temp.due_Date = DateTime.Parse(match.Groups["dueDate"].Value);
                if (match.Groups["actualpay_Date"].Value.Length > 1) temp.actualpay_Date = DateTime.Parse(match.Groups["actualpay_Date"].Value);
            }
            return temp;
        }
    }
}
