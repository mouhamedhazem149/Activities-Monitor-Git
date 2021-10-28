using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using ns1;

namespace OpsMoi.Utilities
{
    public static partial class HM_Manager
    {
        public static string dateNotFinished = "لم يتم الانتهاء بعد";
        public const int formWidth = 1920; public const int formHeight = 1080;
        public static void Update_OLV<T>(List<T> objects, ObjectListView Olv)
        {
            if (Olv.Objects != null && Olv.Objects.OfType<T>().Count() > 0) { Olv.SetObjects(null); }
            if (objects != null)
                Olv.Invoke((Action)delegate ()
                {
                    Olv.SetObjects(objects.Where(p => p != null));
                    Olv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                });
        }
        public static void Update_LV(List<string> items, ListView lv)
        {
            lv.Items.Clear();
            foreach (string item in items)
                lv.Items.Add(item);
        }
        public static void Update_Combobox<T>(ComboBox cmbobx, List<T> dataSource, string displayMember = "", string valueMember = "")
        {
            cmbobx.DataSource = null; cmbobx.Items.Clear(); cmbobx.DataSource = dataSource;
            if (displayMember != "") cmbobx.DisplayMember = displayMember;
            if (valueMember != "") cmbobx.ValueMember = valueMember;
        }

        public static void CheckTxtBoxInt(TextBox txtbox, Label lbl)
        {
            int value = 0;
            if (int.TryParse(txtbox.Text, out value) || txtbox.ForeColor == Color.Silver) lbl.Visible = false;
            else { Fail_addition(lbl, "تاكد من إدخال رقم مناسب "); txtbox.Text = ""; }
        }
        public static bool CheckTxtBoxDecimal(ModdedControls.ModdedTextBox txtbox, Label lbl)
        {
            decimal value = 0;
            if (decimal.TryParse(txtbox.Text, out value) || txtbox.IsPlaceholder) { lbl.Visible = false; return true; }
            else { Fail_addition(lbl, "تاكد من إدخال رقم مناسب "); txtbox.Text = ""; return false; }
        }

        public static bool CheckGroupboxTitle(GroupBox grpbox, string Title, Color color)
        {
            if (grpbox.Text != Title) { grpbox.Text = Title; grpbox.ForeColor = color; return false; }
            return true;
        }
        public static bool CheckIfContainEmptyEntries(GroupBox grpbx) => grpbx.Controls.OfType<ModdedControls.ModdedTextBox>()
            .Any(txtbx => txtbx.Visible && txtbx.Enabled && txtbx.Text.Length < 1);

        public static void Reset_Groupbox_Controls(Control groupbox)
        {
            foreach (Control ctrl in groupbox.Controls)
            {
                try
                {
                    if (ctrl is ModdedControls.ModdedTextBox && ctrl.Visible && ctrl.Enabled) { ctrl.Select(); (ctrl as ModdedControls.ModdedTextBox).Text = ""; (ctrl as ModdedControls.ModdedTextBox).SelectedItem = null; ctrl.Refresh(); }
                    else if (ctrl is ListView) (ctrl as ListView).Items.Clear();
                    else if (ctrl is ObjectListView) (ctrl as ObjectListView).SetObjects(null);
                }
                catch (Exception) { Console.WriteLine($"{ctrl.Name}"); }
            }
            groupbox.Focus();
        }

        public static void SetButtons_Color(Panel tileButtonPanel)
        {
            var _btns = tileButtonPanel.Controls.OfType<BunifuTileButton>().ToList();
            _btns.ForEach(btn => btn.color = ControlPaint.Dark(Program.WorkingForm.mainColor, 0.03F));
            _btns.ForEach(btn => btn.colorActive = Program.WorkingForm.secColor);
            tileButtonPanel.Controls.OfType<Panel>().ToList().ForEach(p => p.BackColor = Program.WorkingForm.secColor);
        }
        public static void ScaleFontforLabel(Label lab, string Text)
        {
            lab.Text = Text;
            SizeF extent = TextRenderer.MeasureText(lab.Text, lab.Font);
            float newSize = extent.Height == 0 || extent.Width == 0 ? 0.0005F : lab.Font.Size * Math.Min(lab.Width / extent.Width, lab.Height / extent.Height);
            lab.Font = new Font(lab.Font.FontFamily, newSize, lab.Font.Style);
        }
        public static void ScaleForResolution(Control parentControl, Func InitializeComponent, int customWidth, int customHeight)
        {
            InitializeComponent();
            ScaleControl(parentControl, customWidth, customHeight);
            foreach (Control ctrl in parentControl.Controls)
                ScaleControl(ctrl, customWidth, customHeight);
        }
        private static void ScaleControl(Control ctrl, int customWidth, int customHeight)
        {
            ctrl.ClientSize = new Size(ctrl.ClientSize.Width / formWidth * customWidth, ctrl.ClientSize.Height / formHeight * customHeight);
            ctrl.Location = new Point(ctrl.Location.X / formWidth * customWidth, ctrl.Location.Y / formHeight * customHeight);
            SizeF extent = TextRenderer.MeasureText(ctrl.Text, ctrl.Font);
            float newSize = extent.Height == 0 || extent.Width == 0 ? 0.0005F : ctrl.Font.Size * Math.Min(ctrl.Width / extent.Width, ctrl.Height / extent.Height);
            ctrl.Font = new Font(ctrl.Font.FontFamily, newSize, ctrl.Font.Style);
        }
        public static void IControlInit(Models.ICustomControl cusControl, TransparentTabControl tabCtrl, Panel tilePanel)
        {
            tabCtrl.MakeTransparent();
            cusControl.Set_Tags();
            SetButtons_Color(tilePanel);
            cusControl.Sync();
        }

        public static void TabButtonsClick(TabControl tabControl, Panel bunifuPanel, BunifuTileButton bunifuBtn, Panel sidePanel, Func afterDone = null)
        {
            if (bunifuBtn == null) return;
            sidePanel.Height = bunifuBtn.Height; sidePanel.Top = bunifuBtn.Top; bunifuPanel.Enabled = false; sidePanel.BringToFront();
            tabControl.SelectedTab = bunifuBtn.Tag as TabPage;
            bunifuPanel.Enabled = true;
            if (afterDone != null) afterDone();
        }

        public static void Copy(Control Src, Control To)
        {
            if (Src.GetType() != To.GetType()) return;
            ctrlCpy(Src, To);
            if (Src.Controls.Count > 0)
                foreach (Control ctrl in Src.Controls.OfType<Control>().OrderBy(ctr => ctr.TabIndex))
                {
                    if (ctrl.Name.Length == 0) continue;
                    Control toCtrl = To.Controls.Find(ctrl.Name, true).FirstOrDefault();
                    if (toCtrl == null) continue;
                    Copy(ctrl, toCtrl);
                }
        }
        private static void ctrlCpy(Control Src, Control To)
        {

            if (Src.GetType() != To.GetType()) return;
            else
            {
                switch (Src)
                {
                    case ModdedControls.ModdedTextBox txtbx:
                        (To as ModdedControls.ModdedTextBox).Text = txtbx.Text;
                        break;
                    case ObjectListView olv:
                        Update_OLV(olv.Objects != null ? olv.Objects.OfType<object>().ToList(): null, To as ObjectListView);
                        break;
                    case ListView lv:
                        Update_LV(lv.Items.Count > 0 ? lv.Items.OfType<string>().ToList(): new List<string>() {"" }, To as ListView);
                        break;
                    case CheckBox chkbx:
                        (To as CheckBox).Checked = chkbx.Checked;
                        break;
                    case RadioButton rdobtn:
                        (To as RadioButton).Checked = rdobtn.Checked;
                        break;
                    case DateTimePicker dtp:
                        (To as DateTimePicker).Checked = dtp.Checked;
                        (To as DateTimePicker).Value = dtp.Value;
                        break;
                    default:
                        To.Text = Src.Text;
                        break;
                }
            }
        }

        public static T CtrlVariableDuplicate<T>(T ctrl) where T :Control, new()
        {
            T store = Activator.CreateInstance(ctrl.GetType()) as T;
            store.Name = ctrl.Name;
            ctrlCpy(ctrl, store);
            if (ctrl.Controls.Count > 0)
                foreach (Control child in ctrl.Controls.OfType<Control>().OrderBy(ctr => ctr.TabIndex))
                    store.Controls.Add(CtrlVariableDuplicate(child));
            return store;
        }
    }
}