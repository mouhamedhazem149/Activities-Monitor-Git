using System;

namespace Airconditioning.Models
{
    public class Bill
    {
        public int id { get; set; }
        public string due_name { get; set; }
        public string phonenumber { get; set; }
        public decimal value { get; set; }
        public DateTime due_date { get; set; }
        public DateTime registered_date { get; set; }
        public string category { get; set; }
        public string description { get; set; }

        public static Bill GetBill(int id ,string due_name,string phonenumber ,decimal value, string category, string description, DateTime due_date, DateTime registered_date) =>
            new Bill()
            {
                id = id,
                category = category,
                value = value,
                due_date = due_date,
                registered_date = registered_date,
                description = description,
                due_name = due_name,
                phonenumber = phonenumber
            };

        public User_Interfaces.Reports.Finance_Item_Struct financeStruct
        {
            get
            {
                return new User_Interfaces.Reports.Finance_Item_Struct()
                {
                    id = id,
                    name = due_name,
                    phonenumber = phonenumber,
                    date = due_date,
                    due_value = value,
                    paid_value = value,
                    category = category,
                    type = Utilities.Enums.financeType.فاتورة
                };
            }
        }
    }
}
