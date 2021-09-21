using Airconditioning.Utilities;
using System;
using System.Linq;

namespace Airconditioning.Models
{
    public class Installment_query_item
    {
        public static string buttonName = "عرض العميل";

        public int id { get; set; }
        public string name { get; set; }

        public string serialnumber { get; set; }
        public string address { get; set; }
        public string phonenumber { get; set; }

        public string city { get; set; }

        public Enums.installmentState state { get; set; }

        public decimal Value { get; set; }

        public DateTime due_Date { get; set; }
        public string due_Date_STRING { get { return due_Date.ToString("dddd, dd MMMM yyyy"); } set { due_Date = DateTime.ParseExact(value, "dddd, dd MMMM yyyy", System.Globalization.CultureInfo.InvariantCulture); } }
        
        public string model { get; set; }

        public int req_count { get; set; }
        public int done_count { get; set; }

        public string button { get { return buttonName; } }
        
        public string Req_By_Done 
        { get 
            {
                int general_req = Program.clients_List.Where(p => p.pay_typ == Enums.Payment_type.قسط && p.name == this.name).Select(p => p.Req_Count(null,null)).Sum();
                int general_done = Program.clients_List.Where(p => p.pay_typ == Enums.Payment_type.قسط && p.name == this.name).Select(p => p.Done_Count(null, null)).Sum(); ;
                //return $"عدد الأقساط المستحقة علي العميل : {req_count} والمدفوع منها : {done_count}"; 
                return $"الخاص بالجهاز: {done_count} / {req_count}" + Environment.NewLine + $"العام: {general_done} / {general_req}";
            }
        } // the only new here
    }
}
