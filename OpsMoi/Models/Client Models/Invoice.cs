using System;
using System.Collections.Generic;
using System.Linq;

namespace Airconditioning.Models
{
    public struct Invoice
    {
        public int index { get; set; }
        public string clientName { get; set; }
        public string address { get; set; }
        public string phonenumber { get; set; }
        public DateTime date { get; set; }
        public string category { get; set; }
        public List<InvoiceUnit> invoiceUnits { get; set; }
        public string unitSerial => string.Join(" , ",invoiceUnits.Select(p => p.serial).SelectMany(ser => ser).ToList());
        public string unitModel => string.Join(" , ", invoiceUnits.Select(p => p.modelName));
    }
    public struct InvoiceUnit
    {
        public int index { get; set; }
        public string modelName { get; set; }
        public List<string> serial { get; set; }
        public int count { get; set; }
        public decimal price { get; set; }
    }
}
