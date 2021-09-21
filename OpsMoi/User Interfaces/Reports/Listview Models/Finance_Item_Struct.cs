using System;

namespace OpsMoi.User_Interfaces.Reports
{
    public struct Finance_Item_Struct
    {
        public int id;
        public string name;
        public string phonenumber;

        public DateTime date;

        public decimal due_value;
        public decimal paid_value;

        public string category;

        public Utilities.Enums.financeType type;
    }
}
