using Airconditioning.Interfaces;

namespace Airconditioning.Models
{
    public class Branch : IBranch
    {
        public int id { get; set; }

        public string name { get; set; }
        public string address { get; set; }
        public int type { get; set; }

        public static Branch GetBranch(int id, string branchName, string branchAddress, int branchType) => new Branch() { id = id, name = branchName, address = branchAddress, type = branchType };

    }
}
