using DailyCompanionV2.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DailyCompanionV2.Models
{
    public class Shortcut
    {
        public int parent_id { get; set; }
        public int id { get; set; }
        public string name { get; set; } //اللي هيظهر في القائمة اللي هتختار منها
        public string shortcut { get; set; }
        public int process { get; set; }
        public Process proModel { get => Program.Processs_List.Where(p => p.id == process).FirstOrDefault() != null ? Program.Processs_List.Where(p => p.id == process).First() : null; }
        public string processname { get => proModel != null ? proModel.name : ""; } //هو ال name بالنسبة لل process
        public Shortcut parent(List<Shortcut> parentsList) => parentsList.Where(p => p.id == parent_id).FirstOrDefault();
        public string category
        {
            get
            {
                string tempCat = "";
                if (parent(Program.Shortcuts_List) != null)
                {
                    if (!string.IsNullOrEmpty(parent(Program.Shortcuts_List).category)) tempCat += $"[{parent(Program.Shortcuts_List).category}]";
                    if (!string.IsNullOrEmpty(parent(Program.Shortcuts_List).name)) tempCat += $"[{parent(Program.Shortcuts_List).name}]";
                }
                return tempCat;
            }
        }// التصنيف بتاعها ,, ممكن تخليه بس اسم بيرنت +كاتيجوري بيرنت
        public List<Shortcut> childrenShrtcuts(List<Shortcut> parentsList) => parentsList.Where(p => p.parent_id == id).ToList();
        public bool Equals(Shortcut shortcut) => id == shortcut.id && parent_id == shortcut.parent_id && this.shortcut == shortcut.shortcut && name == shortcut.name && process == shortcut.process;

    }
}
