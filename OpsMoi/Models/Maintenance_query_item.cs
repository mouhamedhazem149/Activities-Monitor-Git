using Airconditioning.Interfaces;
using Airconditioning.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Airconditioning.Models
{
    public class Maintenance_query_item : IMaintenance
    {
        public static string regularMTN_Category = "صيانة دورية";

        public decimal cost { get; set; }
        public int type { get; set; }
        public Enums.Maintenance_type _type { get { return (Enums.Maintenance_type)type; } }

        public int id { get; set; }

        public int status { get; set; }
        public Enums.Maintenance_Status _status { get { return (Enums.Maintenance_Status)status; } }
        
        public int client_type { get; set; }
        public Enums.Maintenance_clientType _clientType { get { return (Enums.Maintenance_clientType)client_type; } }

        public string client_name { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string serial { get; set; }
        public string model { get; set; }

        public string technician_name { get; set; }
        public List<string> technicianList => technician_name.Split(new string[] { HM_Manager.technicianSeprator }, StringSplitOptions.None).ToList();

        public string brief { get; set; }
        public string description { get; set; }

        public DateTime req_date { get; set; }
        public string str_Reqdate { get { return req_date.ToString("yyyy-MM-dd"); } }

        public DateTime? done_date { get; set; } = null;
        public string done_state { get { return done_date.HasValue? done_date.Value.ToString("yyyy-MM-dd") : "لم تتم الصيانة بعد"; } }

        public static Maintenance_query_item GetMTN(int id, string clntName, string clntAddress, int Type, string clntSerial, string clntModel, string clntCity, string clntPhone, DateTime reqDate, string techName, string mtnBrief, string mtnDesc, int mtnTyp, int mtnStatus,decimal _cost)
            => new Maintenance_query_item() { id = id, client_name = clntName, address = clntAddress, type = mtnTyp, serial = clntSerial, model = clntModel, city = clntCity, phone = clntPhone, req_date = reqDate, technician_name = techName, brief = mtnBrief, description = mtnDesc, client_type = Type, status = mtnStatus, cost = _cost };

        public User_Interfaces.Reports.Finance_Item_Struct financeStruct
        {
            get
            {
                decimal tempDone = _status == Enums.Maintenance_Status.تم ? cost : 0;
                string tempCategory = _type == Enums.Maintenance_type.صيانة_دورية 
                    ? regularMTN_Category 
                    : _type == Enums.Maintenance_type.مشكلة 
                    ? $" صيانة مشكلة: {brief}" 
                    : $"أوامر شغل أخرى: {brief}";
                return new User_Interfaces.Reports.Finance_Item_Struct()
                {
                    id = id,
                    name = client_name,
                    phonenumber = phone,
                    date = req_date,
                    due_value = cost,
                    paid_value = tempDone,
                    category = tempCategory,
                    type = Enums.financeType.صيانات
                };
            }
        }
        public User_Interfaces.Reports.Client_Item_Struct clientStruct
        {
            get
            {
                decimal tempDone = _status == Enums.Maintenance_Status.تم ? cost : 0;
                string tempCategory = _type == Enums.Maintenance_type.صيانة_دورية
                    ? regularMTN_Category
                    : _type == Enums.Maintenance_type.مشكلة
                    ? $" صيانة مشكلة: {brief}"
                    : $"أوامر شغل أخرى: {brief}";
                return new User_Interfaces.Reports.Client_Item_Struct()
                {
                    id = id,
                    name = client_name,
                    phonenumber = phone,
                    date = req_date,
                    cost = cost,
                    profit = tempDone,
                    category = tempCategory,
                    type = Enums.clientType.عملاء_صيانة,
                    city = city,
                    serial = serial,
                    technician = technician_name
                };
            }
        }
    }
}
