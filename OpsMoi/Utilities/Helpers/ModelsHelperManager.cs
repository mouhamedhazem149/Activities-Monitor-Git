using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace OpsMoi.Utilities
{
    public static partial class HM_Manager
    {
        public delegate void Func();
        const string proprtyName = "propertyName"; 
        public static string controlsPattern = $@"^[a-zA-Z]+_(?<{proprtyName}>[\w]+)_[a-zA-Z]+$";
        
        public static bool genericHandler(GroupBox grpbox, string Title, Color color, object oldModel, Label MsgLabel, Func tobeDone, ref string specificMsg, bool bypassCheck = false)
        {
            specificMsg = specificMsg == "" ? "تمت العملية بنجاح" : specificMsg;
            try
            {
                if (GroupboxCheck(grpbox, Title, color) || bypassCheck)
                {
                    tobeDone();
                    FinalSteps(grpbox, MsgLabel, specificMsg, bypassCheck); return true;
                }
                else { Reset_Textbox_Controls(grpbox); /*if (oldModel != null) SetControlsFromModel(grpbox, oldModel);*/ }
            }
            catch (Exception) { Fail_addition(MsgLabel); }
            return false;
        }
        
        public static void SetControlsFromModel(Control grpbox, object oldModel)
        {
            var objectDict = GetObjectAsDictionary(oldModel);
            grpbox.Controls.OfType<CheckBox>().ToList().ForEach(ctrl => HandleControl(ctrl, oldModel, objectDict));
            grpbox.Controls.OfType<RadioButton>().ToList().ForEach(ctrl => HandleControl(ctrl, oldModel, objectDict));
            grpbox.Controls.OfType<ComboBox>().ToList().ForEach(ctrl => HandleControl(ctrl, oldModel, objectDict));
            foreach (Control ctrl in grpbox.Controls)
                HandleControl(ctrl, oldModel, objectDict);
        }
        private static void HandleControl(Control ctrl, object oldModel, Dictionary<string, object> Dict)
        {
            int ind = 0;
            if (ctrl.Controls.Count > 0) SetControlsFromModel(ctrl, oldModel);
            string Prop = Regex.IsMatch(ctrl.Name, controlsPattern) ? Regex.Match(ctrl.Name, controlsPattern).Groups[proprtyName].Value : "";
            if (Dict.Keys.Contains(Prop) && ctrl.Visible)
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
                            int indo = cmbobx.FindStringExact(Dict[Prop].ToString());
                            cmbobx.SelectedIndex = indo;
                            cmbobx.Text = Dict[Prop].ToString();
                        }
                        break;
                    case ObjectListView olv:
                        Update_OLV((dynamic)Dict[Prop], olv);
                        break;
                    case ListView lv:
                        Update_LV(Dict[Prop] as List<string>, lv);
                        break;
                    case CheckBox chkbx:
                        chkbx.Checked = Dict[Prop].ToString() == "1";
                        break;
                    case RadioButton rdobtn:
                        rdobtn.Checked = Dict[Prop].ToString() == "1";
                        break;
                    case DateTimePicker dtp:
                        if ((Dict[Prop] as DateTime?).HasValue) { dtp.Checked = true; dtp.Value = (Dict[Prop] as DateTime?).Value; }
                        else dtp.Checked = false;
                        break;
                    default:
                        break;
                        /*if (ctrl is ModdedControls.ModdedTextBox)
                            (ctrl as ModdedControls.ModdedTextBox).Text = Dict[Prop].ToString();
                        else if (ctrl is Label)
                            ctrl.Text = Dict[Prop].ToString();
                        else if (ctrl is ComboBox)
                            if (int.TryParse(Dict[Prop].ToString(), out ind))
                            {
                                if ((ctrl as ComboBox).ValueMember == "id") (ctrl as ComboBox).SelectedValue = (int)Dict[Prop];
                                else (ctrl as ComboBox).SelectedIndex = (int)Dict[Prop];
                            }
                            else
                            {
                                int indo = (ctrl as ComboBox).FindStringExact(Dict[Prop].ToString());
                                (ctrl as ComboBox).SelectedIndex = indo;
                                (ctrl as ComboBox).Text = Dict[Prop].ToString();
                            }
                        else if (ctrl is ObjectListView)
                            HM_Manager.Update_OLV((dynamic)Dict[Prop], ctrl as ObjectListView);
                        else if (ctrl is ListView)
                        { (ctrl as ListView).Items.Clear(); foreach (string item in Dict[Prop] as List<string>) (ctrl as ListView).Items.Add(item); }
                        else if (ctrl is CheckBox)
                            (ctrl as CheckBox).Checked = Dict[Prop].ToString() == "1";
                        else if (ctrl is RadioButton)
                            (ctrl as RadioButton).Checked = Dict[Prop].ToString() == "1";
                        else if (ctrl is DateTimePicker)
                            (ctrl as DateTimePicker).Value = (Dict[Prop] as DateTime?).Value;*/
                }
            ctrl.Update();
        }

        public static bool GroupboxCheck(GroupBox grpbox, string Title, Color color)
        {
            if (HM_Manager.CheckIfContainEmptyEntries(grpbox) && (color == grpbox.ForeColor))
                return false;
            return HM_Manager.CheckGroupboxTitle(grpbox, Title, color);
        }

        public static void FinalSteps(GroupBox grpbox, Label MsgLabel, string selectMsg, bool byPass)
        {
            if (!byPass) HM_Manager.Reset_Textbox_Controls(grpbox);
            HM_Manager.Success_addition(MsgLabel, selectMsg);
        }
    }
}
