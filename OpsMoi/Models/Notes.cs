using OpsMoi.Utilities;

namespace OpsMoi.Models
{
    public class Notes
    {
        public string title { get; set; }
        public byte[] note { get; set; }
        public string strNote { get => HM_Manager.Decrypt(note); set => note = HM_Manager.topEncrypt(value); }
    }
}
