using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DailyCompanionV2.Models;
using DailyCompanionV2.User_Interfaces.Settings;
using DailyCompanionV2.Utilities;

namespace DailyCompanionV2.User_Interfaces
{
    public partial class UsrCtrl_Todo : UserControl, ICustomControl
    {
        public UsrCtrl_Todo() => InitialLoad();
        public UsrCtrl_Todo(Enums.todoArgument Arg,int? e_ID)
        {
            InitialLoad();
            switch (Arg)
            {
                case Enums.todoArgument.loadTodoItem:
                    if (e_ID.HasValue)
                        Set_ID(e_ID.Value); 
                    break;
                case Enums.todoArgument.showTodoManager:
                    State = Enums.usrctrlState.add; 
                    break;
                default:
                    break;
            }
        }
        public void Set_ID(int e_ID)
        {
            State = Enums.usrctrlState.mod;
            TODO_id_Textbox.SelectedItem = TODO_id_Textbox.Text = e_ID.ToString();
        }
        public void Set_State(Enums.usrctrlState Arg) => State = Arg;
        void InitialLoad()
        {
            InitializeByResolution();
            UsrCtrl_TgleBtn.BackColor = Program.WorkingForm.secColor;
            aux_TablePanel.BackColor = Program.WorkingForm.mainColor;
            HM_Manager.IControlInit(this, null, Side_Panel);
        }
        public void InitializeByResolution()
        {
            switch (Program.currentResolution)
            {
                case Enums.Resolution.A_1920x1080:
                    InitializeComponent();
                    break;
            }
        }
        public void Set_Tags()
        {
            Add_TODO_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.إضافة, Title = "إضافة مهام", color = Enums.addColor };
            Del_TODO_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.حذف, Title = "تعديل مهام", color = Enums.modColor };

            AddTodo_Groupbox.ContextMenuStrip = Tabcontrol_contextMenuStrip;

            finalTODO_Column.GroupKeyGetter = delegate (object rowObject)
            {
                if (((Todos)rowObject).done_date.HasValue)
                    return DateTime.Parse(((Todos)rowObject).done_date.Value.ToString("d"));
                else return DateTime.MaxValue;
            };
            finalTODO_Column.GroupKeyToTitleConverter = delegate (object groupKey) { return ((DateTime)groupKey).ToString("dddd, dd MMMM,yyyy", System.Globalization.CultureInfo.GetCultureInfo("ar-EG")); };
        }

        private ModdedControls.ModdedTextBox focusedTextbox = null;
        public void Sync()
        {
            TODO_id_Textbox.Values = Program.Todos_List.Select(tdo => tdo.id.ToString()).ToArray();
            TODO_category_Textbox.Values = HM_Manager.commonCategories;
            TODO_todo_Textbox.Values = HM_Manager.commonTodos;
            TODO_duefrom_Textbox.Values = TODO_dueto_Textbox.Values = HM_Manager.commonEntities;
            PrepareSidePanel();
        }
        private Enums.usrctrlState _state = Enums.usrctrlState.add;
        public Enums.usrctrlState State
        {
            get => _state;
            set
            {
                switch (value)
                {
                    case Enums.usrctrlState.mod:
                        {
                            AddTodo_Groupbox.ForeColor = Add_TODO_Button.ForeColor = Enums.modColor;
                            AddTodo_Groupbox.Text = Add_TODO_Button.Text = "تعديل مهام";
                            UsrCtrl_TgleBtn.Checked = Del_TODO_Button.Visible = TODO_id_Textbox.Visible = true;
                            Add_TODO_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.تعديل, Title = "تعديل مهام", color = Enums.modColor };
                            break;
                        }
                    case Enums.usrctrlState.add:
                        {
                            AddTodo_Groupbox.ForeColor = Add_TODO_Button.ForeColor = Enums.addColor;
                            AddTodo_Groupbox.Text = Add_TODO_Button.Text = "إضافة مهام";
                            UsrCtrl_TgleBtn.Checked = Del_TODO_Button.Visible = TODO_id_Textbox.Visible = id_Label.Visible = false;
                            Add_TODO_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.إضافة, Title = "إضافة مهام", color = Enums.addColor };
                            break;
                        }
                }
                Aux_state = Enums.todoAuxState.none;
                _state = value;
            }
        }
        private void TODO_Button_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                double tempDuration = double.TryParse(TODO_duration_Textbox.Text, out tempDuration) ? double.Parse(TODO_duration_Textbox.Text) : 0;
                Todos old = Program.Todos_List.Where(item => item.id.ToString() == TODO_id_Textbox.Text).FirstOrDefault();
                Todo_Processor.HandleTODO(((sender as Button).Tag as settingsButtonTag_Item?).Value.handleType, AddTodo_Groupbox
                    , TODO_duefrom_Textbox.Text, TODO_dueto_Textbox.Text, TODO_todo_Textbox.Text, TODO_category_Textbox.Text, TODO_start_date_Datetimepicker.Value, TODO_due_date_Datetimepicker.Value, TODO_done_date_Datetimepicker.Checked, TODO_done_date_Datetimepicker.Value, old != null ? old.added_date : DateTime.Now, tempDuration, TODO_notes_Textbox.Text, Todos_chkpoint_list_Objectlistview.Objects != null ? Todos_chkpoint_list_Objectlistview.Objects.OfType<Checkpoint>().ToList() : new List<Checkpoint>()
                    , AddTODO_Label, ((sender as Button).Tag as settingsButtonTag_Item?).Value.Title, ((sender as Button).Tag as settingsButtonTag_Item?).Value.color
                    , old);
            }
            else
                Todo_Processor.HandleTODO(Enums.genericHandle_Type.تحميل_البيانات, AddTodo_Groupbox
                    , "", "", "", "", DateTime.Now, DateTime.Now, false, DateTime.Now, DateTime.Now, 0, "", new List<Checkpoint>(), AddTODO_Label, (Del_TODO_Button.Tag as settingsButtonTag_Item?).Value.Title, (Del_TODO_Button.Tag as settingsButtonTag_Item?).Value.color
                    , Program.Todos_List.Where(item => item.id.ToString() == TODO_id_Textbox.Text).FirstOrDefault());
            Sync();
        }
        private void TODO_duration_Textbox_TextChanged(object sender, EventArgs e)
        {
            double minutes = double.TryParse(TODO_duration_Textbox.Text, out minutes) ? double.Parse(TODO_duration_Textbox.Text) : 0;
            if (HM_Manager.CheckTxtBoxDecimal(TODO_duration_Textbox, TODO_duration_value_Label))
                HM_Manager.Success_addition(TODO_duration_value_Label, HM_Manager.MinutesToDuration(minutes));
        }
        private void TODO_id_Textbox_SelectedItemChanged(object sender, EventArgs e)
        {
            if (TODO_id_Textbox.Text != "")
                TODO_Button_Click("loadData", null);
        }
        private void TODO_id_Textbox_TextChanged(object sender, EventArgs e) => HM_Manager.CheckTxtBoxInt(sender as ModdedControls.ModdedTextBox, id_Label);
        private void Todos_chkpoint_list_Objectlistview_CellEditStarting(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (e.Column.Tag != null)
                switch (e.Column.Tag.ToString())
                {
                    case "date":
                        DateTimePicker dtpThis = new DateTimePicker()
                        {
                            Bounds = e.CellBounds,
                            Value = DateTime.Parse(e.Value.ToString()),
                            Checked = true,
                            CustomFormat = "dddd, dd-MMMM-yyyy -- hh:mm tt",
                            Format = DateTimePickerFormat.Custom,
                            ShowUpDown = true
                        };
                        e.Control = dtpThis;
                        break;
                }
        }
        private void TODOs_AddChkPnt_Button_Click(object sender, EventArgs e)
        {
            Checkpoint toAdd = new Checkpoint();
            if (Todos_chkpoint_list_Objectlistview.Objects != null && Todos_chkpoint_list_Objectlistview.Objects.OfType<Checkpoint>().Count() > 0)
                if (Todos_chkpoint_list_Objectlistview.SelectedObjects != null && Todos_chkpoint_list_Objectlistview.SelectedObjects.Count > 0)
                {
                    toAdd.index = Todos_chkpoint_list_Objectlistview.SelectedObjects.OfType<Checkpoint>().Select(p => p.index).Max() + 1;
                    Todos_chkpoint_list_Objectlistview.Objects.OfType<Checkpoint>().Where(p => p.index >= toAdd.index).ToList()
                            .ForEach(nextItem => { nextItem.index += 1; Todos_chkpoint_list_Objectlistview.UpdateObject(nextItem); });
                }
                else
                    toAdd.index = Todos_chkpoint_list_Objectlistview.Objects.OfType<Checkpoint>().Select(p => p.index).Max() + 1;
            else
                toAdd.index = 1;

            toAdd.Chk_Date = TODO_done_date_Datetimepicker.Checked ? TODO_start_date_Datetimepicker.Value : DateTime.Now;

            Todos_chkpoint_list_Objectlistview.AddObject(toAdd);
        }
        private void TODO_Datetimepicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime donDate = TODO_done_date_Datetimepicker.Value; DateTime starDate = TODO_start_date_Datetimepicker.Value;
            if (TODO_done_date_Datetimepicker.Checked && donDate > starDate)
                TODO_duration_Textbox.Text = Math.Ceiling(new DateTime(donDate.Year,donDate.Month,donDate.Day,donDate.Hour,donDate.Minute,1).Subtract(new DateTime(starDate.Year, starDate.Month, starDate.Day, starDate.Hour, starDate.Minute, 1)).TotalMinutes).ToString();
            if (TODO_done_date_Datetimepicker.Checked && Todos_chkpoint_list_Objectlistview.Objects != null && Todos_chkpoint_list_Objectlistview.Objects.OfType<Checkpoint>().Any(chk => chk.Chk_Date > donDate))
            {
                HM_Manager.Fail_addition(AddTODO_Label, "لا يمكن أن يكون تاريخ النقطة الفاصلة أكبر من تاريخ الإنهاء");
                TODO_done_date_Datetimepicker.Value = Todos_chkpoint_list_Objectlistview.Objects.OfType<Checkpoint>().Max(p => p.Chk_Date);
            }
            else HM_Manager.Success_addition(AddTODO_Label, "");
        }
        private void Todos_chkpoint_list_Objectlistview_SelectionChanged(object sender, EventArgs e) => TODOs_DelChkPnt_Button.Enabled = Todos_chkpoint_list_Objectlistview.SelectedObjects != null && Todos_chkpoint_list_Objectlistview.SelectedObjects.Count > 0;

        private void TODOs_DelChkPnt_Button_Click(object sender, EventArgs e)
        {
            HM_Manager.Update_OLV
                (Todos_chkpoint_list_Objectlistview.Objects.OfType<Checkpoint>().Where(chkpnt => !Todos_chkpoint_list_Objectlistview.SelectedObjects.Contains(chkpnt)).ToList()
                , Todos_chkpoint_list_Objectlistview);
        }
        private void Todos_chkpoint_list_Objectlistview_CellEditFinishing(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (TODO_done_date_Datetimepicker.Checked && e.NewValue is DateTime? && (e.NewValue as DateTime?).Value > TODO_done_date_Datetimepicker.Value)
            {
                HM_Manager.Fail_addition(AddTODO_Label, "لا يمكن أن يكون تاريخ النقطة الفاصلة أكبر من تاريخ الإنهاء");
                e.NewValue = TODO_done_date_Datetimepicker.Value;
            }
            else HM_Manager.Success_addition(AddTODO_Label, "");
        }
        private void pasteToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                if (Program.WorkingForm.clippedControl != null) HM_Manager.Copy(Program.WorkingForm.clippedControl, Tabcontrol_contextMenuStrip.SourceControl);
        }
        private void copyToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            { Program.WorkingForm.clippedControl = Tabcontrol_contextMenuStrip.SourceControl; pasteToolStripMenuItem.Enabled = true; }
        }
        private void TODO_Textbox_cmnFlr_SelectedItemChanged(object sender, EventArgs e)
        {
            if ((sender as ModdedControls.ModdedTextBox).SelectedItem != "")
            {
                HM_Manager.SetControlsFromModel(AddTodo_Groupbox, HM_Manager.commonFiller(Program.Todos_List.Where(p => p.GetType().GetProperty(HM_Manager.Propertyfromcontrol(sender as ModdedControls.ModdedTextBox)).GetValue(p).ToString() == (sender as ModdedControls.ModdedTextBox).SelectedItem).ToList()));
                LoadTODOSimilarNode();
            }
        }
        private void Todos_chkpoint_list_Objectlistview_ItemsChanged(object sender, BrightIdeasSoftware.ItemsChangedEventArgs e) => TODOs_DelChkPnt_Button.Enabled = (Todos_chkpoint_list_Objectlistview.Items.Count > 0 && Todos_chkpoint_list_Objectlistview.SelectedObjects != null && Todos_chkpoint_list_Objectlistview.SelectedObjects.Count > 0);

        private void UsrCtrl_TgleBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (HM_Manager.CheckIfContainWrittenEntries(AddTodo_Groupbox) || (Todos_chkpoint_list_Objectlistview.Objects != null && Todos_chkpoint_list_Objectlistview.Objects.OfType<Checkpoint>().Count() > 0))
                if (MessageBox.Show("هل تريد حذف المدخلات الحالية ؟", "إخطار تغيير حالة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    HM_Manager.Reset_Groupbox_Controls(AddTodo_Groupbox);
            if (UsrCtrl_TgleBtn.Checked) State = Enums.usrctrlState.mod;
            else State = Enums.usrctrlState.add;
        }
        private void TODO_Textbox_Enter(object sender, EventArgs e)
        {
            if (sender is ModdedControls.ModdedTextBox && (sender as Control).Focused)
            {
                focusedTextbox = sender as ModdedControls.ModdedTextBox;
                LoadTODOPreviousNode();
                if (focusedTextbox.SelectedItem == focusedTextbox.Text && focusedTextbox.SelectedItem != null) LoadTODOSimilarNode();
            }
            
        }

        private void nowStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                (DTPicker_contextMenuStrip.SourceControl as DateTimePicker).Value = DateTime.Now;
        }
    }
}
