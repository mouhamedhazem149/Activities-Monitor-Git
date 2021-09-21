using System;
using System.Collections.Generic;
using System.Linq;

namespace Airconditioning.Models
{
    public class PermissionStruct
    {
        public PermissionState PermissionState { get; set; }
        public List<optionPermissionStruct> optionPermissionStructs { get; set; }
        public List<System.Windows.Forms.Control> control { get; set; }
        public string GetString
        {
            get
            {
                string[] temp = new string[] { PermissionState.ToString() };
                if (optionPermissionStructs != null && optionPermissionStructs.Count > 0) temp = temp.Concat(optionPermissionStructs.Select(opt => opt.GetString).ToArray()).ToArray();
                return string.Join(tabsOptionsHelper.values_Seprator, temp);
            }
        }
    }
    public class tabPermissionStruct : PermissionStruct
    {
        public tabs Name;
        public string fromString(string value)
        {
            var values = value.Split(new string[] { tabsOptionsHelper.values_Seprator }, StringSplitOptions.None).ToList();
            this.PermissionState = (PermissionState)Enum.Parse(typeof(PermissionState), values[0]); values.RemoveAt(0);
            values = SetOptionStructs(values, optionPermissionStructs);
            return string.Join(tabsOptionsHelper.values_Seprator, values);
        }
        private List<string> SetOptionStructs(List<string> val, List<optionPermissionStruct> optionStructs)
        {
            for (int ind = 0; ind < optionStructs.Count; ind++)
            {
                var current = optionStructs[ind];
                current.PermissionState = (PermissionState)Enum.Parse(typeof(PermissionState), val[0]);
                optionStructs[ind] = current;
                val.RemoveAt(0);
                if (current.optionPermissionStructs != null && current.optionPermissionStructs.Count > 0) val = SetOptionStructs(val, current.optionPermissionStructs);
            }
            return val;
        }
    }
    public class optionPermissionStruct : PermissionStruct
    {
        public string Name { get; set; }
    }
}
