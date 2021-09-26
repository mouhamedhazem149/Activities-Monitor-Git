using OpsMoi.Utilities;

namespace OpsMoi.Models
{
    public class Notes
    {
        public int id { get; set; }
        public string title { get; set; }
        public byte[] note { get; set; }
        public string strNote { get => HM_Manager.Decrypt(note); set => note = HM_Manager.topEncrypt(value); }
    }
}
