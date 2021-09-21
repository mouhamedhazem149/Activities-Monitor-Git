using Airconditioning.Interfaces;

namespace Airconditioning.Models
{
    public class Model : IDevice
    {
        public int id { get; set; }

        public string model { get; set; }
        public string code { get; set; }

        public decimal d_price { get; set; }
        public decimal c_price { get; set; }

        public static Model GetModel(int id, string model, string code, decimal cPrice, decimal dPrice) => new Model() { id = id, model = model, code = code, c_price = cPrice, d_price = dPrice };
    }
}
