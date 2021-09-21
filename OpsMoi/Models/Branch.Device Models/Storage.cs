using SQL_DBH_Lib;
using Airconditioning.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Airconditioning.Models
{
    public class Storage : IStorage
    {
        public static string extStorage = "مخزن خارجي";
        public static string addStorageRegex = @"تم إضافة: (?<Count>[-\d]+) أجهزة موديل: (?<Model>[ء-يa-zA-Z.-_\d\s]+) إلي المخزن: (?<Storage>[ء-يa-zA-Z.-_\d\s]+)";

        public int id { get; set; }

        public string name { get; set; }
        public string model { get; set; }
        public string code { get { return Program.devices_List.Where(p => p.model == model).First().code; } }

        public int count { get; set; }

        public decimal d_price { get; set; }
        public decimal c_price { get; set; }

        public string[] ToString(string arg = "3")
        {
            return new string[] { $"{model}", $"{name}", $"{count}", $"{d_price}", $"{c_price}" };
        }

        public User_Interfaces.Reports.Storage_Item_Struct storageStruct(DateTime from, DateTime to)
        {
            List<string> dev_Added = Database_Activities.Load_Data<string>("history", new List<string> { "add_info" }, new List<string> { "operation = 'إضافة أجهزة للمخزن' OR operation = 'تعديل أجهزة للمخزن'", $"AND datetime BETWEEN '{from.ToString("yyyy-MM-dd")}' AND '{to.ToString("yyyy-MM-dd")}'" });
            int tempIncome = dev_Added.Select(record => Regex.Match(record, addStorageRegex))
                 .Where(mtch => mtch.Groups["Model"].Value == model && mtch.Groups["Storage"].Value == name)
                 .Select(p => int.Parse(p.Groups["Count"].Value)).Sum();

            int tempOut = Program.clients_List.Where(clnt => clnt.storage == name && clnt.model == model && clnt.date >= from && clnt.date <= to).Count();

            return new User_Interfaces.Reports.Storage_Item_Struct()
            {
                storage = name,
                model = model,
                count = count,
                incoming = tempIncome,
                outgoing = tempOut
            };
        }
    }
}
