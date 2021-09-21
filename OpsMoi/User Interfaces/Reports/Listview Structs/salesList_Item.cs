using OpsMoi.Utilities;

namespace OpsMoi.User_Interfaces.Reports
{
    public struct salesList_Item
    {
        public int id;
        public string name;
        public string model;
        public string city;
        public string technician;
        public string payment_type;
        public Enums.clientpayment_Status paymentState;
        public string status;

        public int sold_count;
        public decimal price;
        public decimal profit;
    }
}
