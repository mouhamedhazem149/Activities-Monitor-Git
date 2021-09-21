using Airconditioning.Interfaces;
using Airconditioning.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Airconditioning.Models
{
    public class Employee : IEmployee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phonenumber { get; set; }
        public string national_id { get; set; }

        public Enums.employeeType employeeType { get; set; }
        public string title { get; set; }

        public int can_log { get; set; }

        public string qualifications { get; set; }
        public decimal wage { get; set; }
        public DateTime employement_Date { get; set; }

        public string user_name { get; set; }
        public string password { get; set; }
        public string Repassword { get { return password; } }
        public string email { get; set; }

        public int branch { get; set; }
        public string branch_name { get { if (Program.branches_List.Where(p => p.id == branch).FirstOrDefault() != null) return Program.branches_List.Where(p => p.id == branch).First().name; else return "الفرع غير مسجل"; } }

        public int permission_level { get; set; }
        public List<tabPermissionStruct> permissions_List;
        public string permissions
        {
            get => string.Join(tabsOptionsHelper.values_Seprator, permissions_List.Select(tabItem => tabItem.GetString));
            set
            {
                permissions_List = permissionsHelper.preparePermissionList();
                if (value.Count(p => p == ',') == tabsOptionsHelper.permsCount)  //44 item permission + 8
                    foreach (var item in permissions_List)
                        value = item.fromString(value);
            }
        }

        public User_Interfaces.Reports.HR_Item_Struct hrStruct(DateTime from, DateTime to)
        {
            {
                decimal billsPaid = Program.bill_List.Where(bill => bill.due_name == name && (bill.due_date >= from && bill.due_date <= to)).Sum(p => p.value);
                int opsCount = 0;
                if (employeeType == Enums.employeeType.فني)
                    opsCount = Program.clients_List.Where(p => p.technicianList.Contains(name) && (p.date >= from && p.date <= to)).Count() +
                          Program.Maintenance_List.Where(p => p.technicianList.Contains(name) && (p.done_date >= from && p.done_date <= to)).Count();
                else if (can_log == 1)
                    opsCount = Program.History_List.Where(p => p.user_name == name && (p.datetime >= from && p.datetime <= to)).Count();
                return new User_Interfaces.Reports.HR_Item_Struct()
                {
                    id = id,
                    name = name,
                    phonenumber = phonenumber,
                    employeeType = employeeType,
                    employmentDate = employement_Date,
                    paid_bills = billsPaid,
                    due_wage = wage,
                    operationsCount = opsCount
                };
            }
        }
        public T CastTo<T>()
        {
            Type objectType = this.GetType();
            Type target = typeof(T);
            var x = Activator.CreateInstance(target, false);
            var z = from source in objectType.GetMembers().ToList()
                    where source.MemberType == MemberTypes.Property
                    select source;
            var d = from source in target.GetMembers().ToList()
                    where source.MemberType == MemberTypes.Property
                    select source;
            List<MemberInfo> members = d.Where(memberInfo => d.Select(c => c.Name)
               .ToList().Contains(memberInfo.Name)).ToList();
            PropertyInfo propertyInfo;
            object value;
            foreach (var memberInfo in members)
            {
                propertyInfo = typeof(T).GetProperty(memberInfo.Name);
                value = this.GetType().GetProperty(memberInfo.Name).GetValue(this, null);

                propertyInfo.SetValue(x, value, null);
            }
            return (T)x;
        }
    }
}
