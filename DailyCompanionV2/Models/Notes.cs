using DailyCompanionV2.Utilities;
using System;

namespace DailyCompanionV2.Models
{
    public class Notes
    {
        public int id { get; set; }
        public string title { get; set; }
        public byte[] note { get; set; }
        public string strNote { get => HM_Manager.Decrypt(note); set => note = HM_Manager.topEncrypt(value); }
        public string lstupdt { get; set; }
        public DateTime lst_updt { get { return lstupdt != null ? DateTime.Parse(lstupdt) : DateTime.Now; } set { lstupdt = value.ToString("g"); } }
        public bool Equals(Notes obj) => id == obj.id && title == obj.title && note == obj.note;
        public string String => $"{id} {title} {strNote}";
    }
}
