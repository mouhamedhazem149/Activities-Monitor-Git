using OpsMoi.Models;
using OpsMoi.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OpsMoi.User_Interfaces.Reports
{
    public static partial class Reports_Processor
    {
        /*public static List<installmentsList_Item> installmentsList(DateTime From, DateTime To, string searchTerm) =>
            Program.clients_List.Where(p => p.pay_typ == Enums.Payment_type.قسط).Where(p => (p.date.Date <= To && p.date.Date >= From))
            .Where(p => p.name.Contains(searchTerm) || p.model.Contains(searchTerm) || p.city.Contains(searchTerm) || p.phonenumber.Contains(searchTerm) || p.id.ToString().Contains(searchTerm))
            .Select(p => new installmentsList_Item { id = p.id, name = p.name, model = p.model, v_installment = p.v_installments, phonenumber = p.phonenumber, Req_num = p.Req_Count(From, To), Done_num = p.Done_Count(From, To), city = p.city, }).ToList();

        public static List<salesList_Item> salesList(DateTime From, DateTime To, string searchTerm) =>
            Program.clients_List.Where(p => (p.date.Date <= To && p.date.Date >= From))
            .Where(p => p.name.Contains(searchTerm) || p.model.Contains(searchTerm) || p.city.Contains(searchTerm) || p.technician.Contains(searchTerm) || p.id.ToString().Contains(searchTerm))
            .Select(i => new salesList_Item { id = i.id, name = i.name, model = i.model, technician = i.technician, city = i.city, payment_type = i.pay_typ.ToString(), sold_count = 1, price = i.price, profit = i.profit, status = i.status, paymentState = i.paymentState }).ToList();

        public static List<maintenanceList_Item> maintenanceList(DateTime From, DateTime To, string searchTerm) =>
           Program.Maintenance_List.Where(p => (p.req_date.Date <= To && p.req_date.Date >= From))
            .Where(p => p.client_name.Contains(searchTerm) || p.model.Contains(searchTerm) || p.city.Contains(searchTerm) || p.technician_name.Contains(searchTerm) || p.id.ToString().Contains(searchTerm))
            .Select(i => new maintenanceList_Item { id = i.id, name = i.client_name, model = i.model, city = i.city, technician = i.technician_name, count = 1 }).ToList();*/

        public static List<Finances> FinancesList(DateTime from, DateTime to) => Program.Finances_List.Where(tdo => (tdo.due_date > from || (tdo.done_date.HasValue && tdo.done_date.Value > from)) && (tdo.due_date < to || (tdo.done_date.HasValue && tdo.done_date.Value < to))).ToList();

        public static List<Todos> TodosList(DateTime from, DateTime to) => Program.Todos_List.Where(tdo => (tdo.due_date > from || tdo.added_date > from || (tdo.done_date.HasValue && tdo.done_date.Value > from)) &&
        (tdo.due_date < to || tdo.added_date < to || (tdo.done_date.HasValue && tdo.done_date.Value < to))).ToList();

        public static List<Models.Notes> NotesList(string searchWord) => Program.Notes_List.Where(nt => nt.title.Contains(searchWord) || nt.strNote.Contains(searchWord)).ToList();

        public static List<HR_Item_Struct> hrList(DateTime from, DateTime to) =>
           null;
    }
}
