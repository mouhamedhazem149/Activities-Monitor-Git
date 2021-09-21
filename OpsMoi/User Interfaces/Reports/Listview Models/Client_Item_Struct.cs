using System;

namespace OpsMoi.User_Interfaces.Reports
{
    public struct Client_Item_Struct
    {
        public int id;
        public string name;
        public string phonenumber;
        public string serial;

        public string technician;

        public string city;

        public DateTime date;

        public decimal cost;
        public decimal profit;

        public string category;
        public Utilities.Enums.clientType type;
    }
}
