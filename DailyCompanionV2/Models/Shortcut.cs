using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyCompanionV2.Models
{
    public class Shortcut
    {// اعمل التعديل ليهم يكون من tree Olistview نود التصنيف وتحته 
     // اللي ملوش category (في قاعدة البيانات)A اعتبره زي parent category ممكن تحط حاجات تحته
     //shortucut الargument اللي هيجي بعد الprocess 
        public static string shrtcutJoint = ",";
        public static string shrtcutSeparator = "||";

        public int id { get; set; }
        public string name { get; set; } //اللي هيظهر في القائمة اللي هتختار منها
        public string shortcut { get; set; }
        public int process { get; set; }
        public Process proModel { get => Program.Processs_List.Where(p => p.id == process).FirstOrDefault() != null ? Program.Processs_List.Where(p => p.id == process).First() : null; }
        public string processname { get => proModel != null ? proModel.name : ""; } //هو ال name بالنسبة لل process
        public Shortcut parent { get; set; }
        public string category
        {
            get
            {
                if (parent != null)
                    return $"[{parent.category}] [{parent.name}]";
                else return "";
            }
        }// التصنيف بتاعها ,, ممكن تخليه بس اسم بيرنت +كاتيجوري بيرنت

        public List<Shortcut> childrenShrtcuts { get; set; }
        public string children
        {
            get => childrenShrtcuts != null ? string.Join(shrtcutSeparator, childrenShrtcuts.Select(p => p.ToString()).ToList()) : "";
            set
            {
                string[] shrtCuts = value.Length > 1 ? value.Split(new string[] { shrtcutSeparator }, StringSplitOptions.None) : new string[0];
                childrenShrtcuts = new List<Shortcut>(shrtCuts.Length);
                foreach (string shrtCut in shrtCuts)
                    childrenShrtcuts.Add(this.GetShortcut(shrtCut));
            }
        }
        public override string ToString()  //كل child هيكون ليه name , shortcut, processname الكاتيجوري هيكون اسم parent, id مش مهم هيتسجل في parent
        {
            byte[] SCName = Encoding.UTF8.GetBytes(name);
            var tempName = string.Join("", SCName.Select(p => p.ToString("X2")));
            byte[] SCShortcut = Encoding.UTF8.GetBytes(shortcut);
            var tempShortcut = string.Join("", SCShortcut.Select(p => p.ToString("X2")));
            byte[] SCChildren = Encoding.UTF8.GetBytes(children);
            var tempChildren = string.Join("", SCChildren.Select(p => p.ToString("X2")));
            return string.Join(shrtcutJoint, new List<string> { id.ToString(), tempName, tempShortcut, process.ToString(),tempChildren });
        }
        public Shortcut GetShortcut(string shrt_string)
        {
            Shortcut temp = new Shortcut();
            var split = shrt_string.Split(new string[] { shrtcutJoint }, StringSplitOptions.None);
            if (split.Length != 5) return temp;
            try
            {
                temp.id = int.Parse(split[0]);

                byte[] tempArray = new byte[split[1].Length / 2];
                for (int x = 0; x < tempArray.Length; x++)
                    tempArray[x] = (byte)Utilities.HM_Manager.FromHex(split[1].Substring(x * 2, 2));
                temp.name = Encoding.UTF8.GetString(tempArray);

                tempArray = new byte[split[2].Length / 2];
                for (int x = 0; x < tempArray.Length; x++)
                    tempArray[x] = (byte)Utilities.HM_Manager.FromHex(split[2].Substring(x * 2, 2));
                temp.shortcut = Encoding.UTF8.GetString(tempArray);

                temp.process = int.Parse(split[3]);

                tempArray = new byte[split[4].Length / 2];
                for (int x = 0; x < tempArray.Length; x++)
                    tempArray[x] = (byte)Utilities.HM_Manager.FromHex(split[4].Substring(x * 2, 2));
                temp.children = Encoding.UTF8.GetString(tempArray);

                temp.parent = this;

                return temp;
            }
            catch (Exception ex) { return GetShortcut(""); }
        }
        public bool Equals(Shortcut shortcut) => this.ToString() == shortcut.ToString();
    }
}
