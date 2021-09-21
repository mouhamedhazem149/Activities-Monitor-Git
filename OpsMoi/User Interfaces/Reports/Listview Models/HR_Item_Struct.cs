using System;

namespace OpsMoi.User_Interfaces.Reports
{
    public struct HR_Item_Struct
    {
        public int id;
        public string name;
        public string phonenumber;
        
        public Utilities.Enums.employeeType employeeType;

        public DateTime employmentDate;

        public decimal due_wage;
        public decimal paid_bills;

        public int operationsCount;
    }
}
