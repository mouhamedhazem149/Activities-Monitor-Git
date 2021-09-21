using System;
using System.Collections.Generic;
using System.Linq;
using Airconditioning.Utilities;
using Airconditioning.Interfaces;

namespace Airconditioning.Models
{
    public class Client : IClient
    {
        public static string installmentJoint = ","; public static string serialJoint = ",";
        public static string installmentCategory = "مبيعات أجهزة قسط";public static string insPaymentCategory = "سداد أقساط"; public static string cashCategory = "مبيعات أجهزة كاش";

        public int id { get; set; }
        public string name { get; set; }

        public string serialnumber { get; set; }
        public List<string> serialList => serialnumber.Split(new string[] { serialJoint }, StringSplitOptions.None).ToList();

        public string model { get; set; }
        public string storage { get; set; }
        public string address { get; set; }
        public string phonenumber { get; set; }
        
        public string technician { get; set; }
        public List<string> technicianList => technician.Split(new string[] { HM_Manager.technicianSeprator }, StringSplitOptions.None).ToList();

        public string city { get; set; }

        public Enums.clientpayment_Status paymentState { get { return (pay_typ == Enums.Payment_type.كاش) || (installments_List.Select(p => p.actualpay_Date).All(s => s != null) && installments_List.Where(p => p.actualpay_Date != null).Select(p => p.Value).Sum() + foree >= price) ? Enums.clientpayment_Status.منتهي : Enums.clientpayment_Status.غير_منتهي; } }
        public string status { get { return paymentState == Enums.clientpayment_Status.منتهي ? "منتهي" : $"غير منتهي والباقي: {price - (installments_List.Where(p => p.actualpay_Date != null).Select(p => p.Value).Sum() + foree)}"; } }

        public string ModelCode { get { try { return Program.devices_List.Where(p => p.model == model).First().code; } catch (Exception exec) { return ""; } } }
       
        public string installments
        {
            get => string.Join(installmentJoint, installments_List.Select(p => p.ToString()).ToList());
            set
            {
                string[] monthly_installments = value.Length > 1 ? value.Split(',') : new string[0];
                installments_List = new List<Installment>(monthly_installments.Length);
                foreach (string item in monthly_installments)
                    installments_List.Add(Installment.GetInstallment(item));
            }
        }
        public List<Installment> installments_List { get; set; }
        
        public DateTime date { get; set; }
        public string date_STRING { get { return date.ToString("dddd, dd MMMM yyyy"); } }

        public decimal d_listprice { get; set; }
        public decimal price { get; set; }
        public decimal profit { get { return price - d_listprice; } }
        public decimal foree { get; set; }
        public decimal v_installments { get; set; }

        public int Req_Count(DateTime? From, DateTime? To)
        {
            if (pay_typ == Enums.Payment_type.كاش) return 0;
            else
            {
                var temp = installments_List.Select(p => p.due_Date);
                if (From.HasValue && To.HasValue)
                    return temp.Count(p => (p.Date <= To.Value && p.Date >= From.Value));
                else return temp.Count();
            } 
        }
        public int Done_Count(DateTime? From, DateTime? To)
        {
            if (pay_typ == Enums.Payment_type.كاش) return 0;
            else
            {
                var temp = installments_List.Where(p => p.actualpay_Date.HasValue).Select(p => p.actualpay_Date.Value);
                if (From.HasValue && To.HasValue)
                    return temp.Count(p => (p.Date <= To.Value && p.Date >= From.Value));
                else return temp.Count();
            }
        }

        public int payment_type { get; set; }
        public Enums.Payment_type pay_typ { get { return (Enums.Payment_type)payment_type; } }
        
        public int Cash { get { return this.pay_typ == Enums.Payment_type.كاش ? 1 : 0; } }
        public int install { get { return this.pay_typ == Enums.Payment_type.قسط ? 1 : 0; } }
        
        public int n_installments { get; set; }

        public List<Installment_query_item> installment_Queries(DateTime from, DateTime to)
        {
            if (pay_typ == Enums.Payment_type.كاش) return null;
            else
            {
                List<Installment_query_item> tempList = new List<Installment_query_item>(installments_List.Count);
                foreach (Installment ins in installments_List)
                    if (ins.due_Date >= from && ins.due_Date <= to)
                        tempList.Add(new Installment_query_item() { name = name, 
                            serialnumber = serialnumber, address = address, city = city,
                            model = model, phonenumber = phonenumber,
                            req_count = Req_Count(from,to), done_count = Done_Count(from,to),
                            Value = ins.Value, due_Date = ins.due_Date, state = ins.state });
                return tempList;
            }
        }

        public string notes { get; set; }

        public string To_String() { return $"{name} {model} {technician} {serialnumber} {city} {address}"; }

        public List<User_Interfaces.Reports.Finance_Item_Struct> financeStruct
        {
            get
            {
                bool cash = pay_typ == Enums.Payment_type.كاش;
                int count = cash ? 1 : installments_List.Count + 1;
                List<User_Interfaces.Reports.Finance_Item_Struct> tempList = new List<User_Interfaces.Reports.Finance_Item_Struct>(count);
                decimal tempDone = cash ? price : foree;
                string tempCategory = pay_typ == Enums.Payment_type.كاش ? cashCategory : installmentCategory;
                tempList.Add(new User_Interfaces.Reports.Finance_Item_Struct() { id = this.id, name = name, phonenumber = phonenumber, date = date, due_value = tempDone, paid_value = tempDone, category = tempCategory, type = Enums.financeType.عملاء });
                if (!cash)
                {
                    foreach (Installment ins in installments_List)
                        tempList.Add(new User_Interfaces.Reports.Finance_Item_Struct()
                        {
                            id = this.id,
                            name = name,
                            phonenumber = phonenumber,
                            date = ins.due_Date,
                            due_value = v_installments,
                            paid_value = ins.Value,
                            category = insPaymentCategory,
                            type = Enums.financeType.أقساط
                        });
                }
                return tempList;
            }
        }
        public User_Interfaces.Reports.Client_Item_Struct clientStruct
        {
            get
            {
                string tempCategory = pay_typ == Enums.Payment_type.كاش ? cashCategory : installmentCategory;
                return new User_Interfaces.Reports.Client_Item_Struct()
                {
                    id = id,
                    name = name,
                    phonenumber = phonenumber,
                    date = date,
                    cost = price,
                    profit = profit,
                    category = tempCategory,
                    type = Enums.clientType.عملاء_تركيب,
                    city = city,
                    serial = serialnumber,
                    technician = technician,
                };
            }
        }
        public Invoice clientInvoice
        {
            get
            {
                return new Invoice()
                {
                    clientName = name,
                    phonenumber = phonenumber,
                    address = address,
                    category = "مبيعات أجهزة تكييف",
                    date = date,
                    index = int.Parse($"{(date.Year % 100).ToString("00")}{date.Month.ToString("00")}{(id % 10000).ToString("0000")}"),
                    invoiceUnits = new List<InvoiceUnit>
                    {
                        new InvoiceUnit()
                        {
                        index = 0,
                        count = 1,
                        modelName = model,
                        price = price,
                        serial = serialList
                        }
                    }
                };
            }
        }
    }
}
