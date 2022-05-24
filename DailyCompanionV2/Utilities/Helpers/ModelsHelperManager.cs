using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace DailyCompanionV2.Utilities
{
    public static partial class HM_Manager
    {
        public delegate void Func();
        public const string proprtyName = "propertyName"; 
        public static string controlsPattern = $@"^[a-zA-Z]+_(?<{proprtyName}>[\w]+)_[a-zA-Z]+$";
        
        public static bool genericHandler(GroupBox grpbox, string Title, Color color, object oldModel, Label MsgLabel, Func tobeDone, ref string specificMsg, bool bypassCheck = false)
        {
            specificMsg = specificMsg == "" ? "تمت العملية بنجاح" : specificMsg;
            try
            {
                bool sameColor = grpbox != null ? grpbox.ForeColor == color : true;
                if (GroupboxCheck(grpbox, Title, color) || bypassCheck)
                {
                    tobeDone();
                    FinalSteps(grpbox, MsgLabel, specificMsg, bypassCheck); return true;
                }
                else { if (sameColor) Fail_addition(MsgLabel, "برجاء تاكد من ملء جميع البيانات"); else Reset_Groupbox_Controls(grpbox); }
            }
            catch (Exception ex) { Fail_addition(MsgLabel); }
            return false;
        }
        
        public static void SetControlsFromModel(Control grpbox, object oldModel)
        {
            var objectDict = GetObjectAsDictionary(oldModel);
            grpbox.Controls.OfType<CheckBox>().ToList().ForEach(ctrl => HandleControl(ctrl, oldModel, objectDict));
            grpbox.Controls.OfType<RadioButton>().ToList().ForEach(ctrl => HandleControl(ctrl, oldModel, objectDict));
            grpbox.Controls.OfType<ComboBox>().ToList().ForEach(ctrl => HandleControl(ctrl, oldModel, objectDict));
            foreach (Control ctrl in grpbox.Controls.OfType<Control>().OrderBy(ctr => ctr.TabIndex))
                HandleControl(ctrl, oldModel, objectDict);
        }
        private static void HandleControl(Control ctrl, object oldModel, Dictionary<string, object> Dict)
        {
            int ind = 0;
            if (ctrl.Controls.Count > 0) SetControlsFromModel(ctrl, oldModel);
            string Prop = Regex.IsMatch(ctrl.Name, controlsPattern) ? Regex.Match(ctrl.Name, controlsPattern).Groups[proprtyName].Value : "";
            try
            {
                if (Dict.Keys.Contains(Prop))
                    switch (ctrl)
                    {
                        case ModdedControls.ModdedTextBox txtbx:
                            txtbx.Text = Dict[Prop].ToString();
                            break;
                        case Label lbl:
                            lbl.Text = Dict[Prop].ToString();
                            break;
                        case ComboBox cmbobx:
                            if (int.TryParse(Dict[Prop].ToString(), out ind))
                            {
                                if (cmbobx.ValueMember == "id") cmbobx.SelectedValue = (int)Dict[Prop];
                                else cmbobx.SelectedIndex = (int)Dict[Prop];
                            }
                            else
                            {
                                if (Dict[Prop] == null) break;
                                int indo = cmbobx.FindStringExact(Dict[Prop].GetType().IsEnum ? (Dict[Prop] as Enum).GetDisplayName() : Dict[Prop].ToString());
                                cmbobx.SelectedIndex = indo;
                                cmbobx.Text = Dict[Prop].GetType().IsEnum ? (Dict[Prop] as Enum).GetDisplayName() : Dict[Prop].ToString();
                            }
                            break;
                        case ObjectListView olv:
                            Update_OLV((dynamic)Dict[Prop], olv);
                            break;
                        case ListView lv:
                            Update_LV(Dict[Prop] as List<string>, lv);
                            break;
                        case CheckBox chkbx:
                            chkbx.Checked = Dict[Prop] is bool ? (bool)Dict[Prop] : Dict[Prop].ToString() == "1";
                            break;
                        case RadioButton rdobtn:
                            rdobtn.Checked = Dict[Prop] is bool ? (bool)Dict[Prop] : Dict[Prop].ToString() == "1";
                            break;
                        case DateTimePicker dtp:
                            if ((Dict[Prop] as DateTime?).HasValue) { dtp.Checked = true; dtp.Value = (Dict[Prop] as DateTime?).Value; }
                            else dtp.Checked = false;
                            break;
                        default:
                            break;
                    }
            }
            catch (Exception ex) { }
            finally { ctrl.Update(); }
        }

        public static bool GroupboxCheck(GroupBox grpbox, string Title, Color color)
        {
            if (grpbox == null) return true;
            if (HM_Manager.CheckIfContainEmptyEntries(grpbox) && (color == grpbox.ForeColor))
                return false;
            return HM_Manager.CheckGroupboxTitle(grpbox, Title, color);
        }

        public static void FinalSteps(GroupBox grpbox, Label MsgLabel, string selectMsg, bool byPass)
        {
            if (!byPass) if (grpbox != null) HM_Manager.Reset_Groupbox_Controls(grpbox);
           if (MsgLabel != null) HM_Manager.Success_addition(MsgLabel, selectMsg);
        }
    }
}
