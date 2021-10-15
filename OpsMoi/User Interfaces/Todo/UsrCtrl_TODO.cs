using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ns1;
using OpsMoi.Models;
using OpsMoi.User_Interfaces.Reports;
using OpsMoi.User_Interfaces.Settings;
using OpsMoi.Utilities;

namespace OpsMoi.User_Interfaces
{
    public partial class UsrCtrl_Todo : UserControl,ICustomControl
    {
        public UsrCtrl_Todo() => InitialLoad();
        public UsrCtrl_Todo(Enums.todoArgument Arg, int? e_ID)
        {
            InitialLoad();
            switch (Arg)
            {
                case Enums.todoArgument.loadTodoItem:
                    if (e_ID.HasValue) TODO_id_Textbox.SelectedItem = TODO_id_Textbox.Text = e_ID.Value.ToString();
                    break;
                case Enums.todoArgument.showTodoManager:
                    TileButton_Click(TODOmanage_TileButton, EventArgs.Empty);
                    break;
                default:
                    break;
            }
        }
        void InitialLoad()
        {
            InitializeByResolution();
            HM_Manager.IControlInit(this, todos_Tabcontrol, TileButtons_Panel);
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
            Modify_TODO_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.تعديل, Title = "تعديل مهام", color = Enums.modColor };
            Del_TODO_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.حذف, Title = "تعديل مهام", color = Enums.modColor };

            finalTODO_Column.GroupKeyGetter = delegate (object rowObject)
            {
                if (((Todos)rowObject).done_date.HasValue)
                    return DateTime.Parse(((Todos)rowObject).done_date.Value.ToString("d"));
                else return DateTime.MaxValue;
            };
            finalTODO_Column.GroupKeyToTitleConverter = delegate (object groupKey) { return ((DateTime)groupKey).ToString("dddd, dd MMMM,yyyy", System.Globalization.CultureInfo.GetCultureInfo("ar-EG")); };
        }
        
        public DateTime req_From { get { return TODO_From_Datetimepicker.Value; } }
        public DateTime req_To { get { return TODO_To_Datetimepicker.Value; } }
        public DateTime timeline_From { get { return Timeline_From_DateTimePicker.Value; } }
        public DateTime timeline_To { get { return Timeline_To_DateTimePicker.Value; } }


        private List<Control> editControls { get { return new List<Control> { TODO_due_date_Datetimepicker,TODO_due_date_Adj_Label,TODO_done_date_Datetimepicker,TODO_done_date_Adj_Label,TODO_duration_Textbox,TODO_duration_Adj_Label,TODO_duration_value_Label }; } }

        public void Sync()
        {
            TODO_id_Textbox.Values = Program.Todos_List.Select(tdo => tdo.id.ToString()).ToArray();
            TODO_category_Textbox.Values = HM_Manager.commonCategories;
            TODO_todo_Textbox.Values = HM_Manager.commonTodos;
            TODO_duefrom_Textbox.Values = TODO_dueto_Textbox.Values = HM_Manager.commonEntities;
        }
        private void LoadReqTODOs(DateTime From, DateTime To)
        {
            if (To < From) return;
            HM_Manager.Update_OLV(Reports_Processor.TodosList(From, To).Where(p => p.done_date.HasValue == false).ToList(), reqTODO_Objectlistview);
        }
        private void UsrCtrl_customerservice_Enter(object sender, EventArgs e) => Program.WorkingForm.AcceptButton = null;

        private void TileButton_Click(object sender, EventArgs e) =>
           HM_Manager.TabButtonsClick(todos_Tabcontrol, TileButtons_Panel, sender as BunifuTileButton, SidePanel1);

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
                    , "", "", "", "", DateTime.Now, DateTime.Now, false, DateTime.Now, DateTime.Now, 0, "", new List<Checkpoint>(), AddTODO_Label, (Modify_TODO_Button.Tag as settingsButtonTag_Item?).Value.Title, (Modify_TODO_Button.Tag as settingsButtonTag_Item?).Value.color
                    , Program.Todos_List.Where(item => item.id.ToString() == TODO_id_Textbox.Text).FirstOrDefault());
            Sync();
        }

        private void TODO_duration_Textbox_TextChanged(object sender, EventArgs e)
        {
            double minutes = double.TryParse(TODO_duration_Textbox.Text, out minutes) ? double.Parse(TODO_duration_Textbox.Text): 0;
            if (HM_Manager.CheckTxtBoxDecimal(TODO_duration_Textbox, TODO_duration_value_Label))
                HM_Manager.Success_addition(TODO_duration_value_Label, HM_Manager.MinutesToDuration(minutes));
        }

        private void AddMaintenance_Groupbox_ForeColorChanged(object sender, EventArgs e) { HM_Manager.Reset_Textbox_Controls(sender as GroupBox); TODO_id_Textbox.Enabled = (sender as GroupBox).ForeColor == Enums.modColor;/*editControls.ForEach(ctrl => ctrl.Visible = TODO_id_Textbox.Enabled = (sender as GroupBox).ForeColor == Enums.modColor);*/ }

        private void TODO_id_Textbox_SelectedItemChanged(object sender, EventArgs e)
        {
            if (TODO_id_Textbox.Text != "")
                TODO_Button_Click("loadData", null);
        }
        private void TODO_id_Textbox_TextChanged(object sender, EventArgs e) => HM_Manager.CheckTxtBoxInt(sender as ModdedControls.ModdedTextBox, id_Label);

        private void TODO_SearchButton_Click(object sender, EventArgs e) => LoadReqTODOs(req_From, req_To);

        private void todos_Tabcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (todos_Tabcontrol.SelectedTab == TODO_reqTab) LoadReqTODOs(req_From, req_To);
        }

        private void reqTODO_Objectlistview_DoubleClick(object sender, EventArgs e) => Program.WorkingForm.Click_TODO(Enums.todoArgument.loadTodoItem, (reqTODO_Objectlistview.SelectedObject as Todos).id);

        private void reqTODO_Objectlistview_AboutToCreateGroups(object sender, BrightIdeasSoftware.CreateGroupsEventArgs e)
        {
            foreach (BrightIdeasSoftware.OLVGroup group in e.Groups)
            {
                int count = group.Items.Count;
                string tempHeader = group.Header == null ? "" : group.Header;
                group.Header = string.Format($"{tempHeader} :: عدد المهام المطلوبة : {count}");
                group.Tag = count;
            }
            if (e.Parameters.PrimarySortOrder == SortOrder.Descending) e.Groups = e.Groups.OrderByDescending(p => (p.Tag as int?).Value).ToList();
            else e.Groups = e.Groups.OrderBy(p => (p.Tag as int?).Value).ToList();
        }

        private void reqTODO_Objectlistview_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e) => e.Item.BackColor = Color.Pink;

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
            List<Checkpoint> temp_Checks = Todos_chkpoint_list_Objectlistview.Objects != null ? Todos_chkpoint_list_Objectlistview.Objects.OfType<Checkpoint>().ToList(): new List<Checkpoint>();
            temp_Checks.Add(new Checkpoint()
            {
                index = temp_Checks.Count > 0 ? temp_Checks.Select(p => p.index).Max() + 1 : 1,
                Chk_Date = TODO_done_date_Datetimepicker.Checked ? TODO_start_date_Datetimepicker.Value : DateTime.Now
            });
            HM_Manager.Update_OLV(temp_Checks, Todos_chkpoint_list_Objectlistview);
        }

        private void TODO_Datetimepicker_ValueChanged(object sender, EventArgs e)
        {
            if (TODO_done_date_Datetimepicker.Checked && TODO_done_date_Datetimepicker.Value > TODO_start_date_Datetimepicker.Value) 
                TODO_duration_Textbox.Text = TODO_done_date_Datetimepicker.Value.Subtract(TODO_start_date_Datetimepicker.Value).TotalMinutes.ToString();
            if (TODO_done_date_Datetimepicker.Checked && Todos_chkpoint_list_Objectlistview.Objects != null && Todos_chkpoint_list_Objectlistview.Objects.OfType<Checkpoint>().Any(chk => chk.Chk_Date > TODO_done_date_Datetimepicker.Value))
            {
                HM_Manager.Fail_addition(AddTODO_Label, "لا يمكن أن يكون تاريخ النقطة الفاصلة أكبر من تاريخ الإنهاء");
                TODO_done_date_Datetimepicker.Value = Todos_chkpoint_list_Objectlistview.Objects.OfType<Checkpoint>().Max(p => p.Chk_Date);
            }
            else HM_Manager.Success_addition(AddTODO_Label, "");
        }

        private void Todos_chkpoint_list_Objectlistview_SelectionChanged(object sender, EventArgs e) => TODOs_DelChkPnt_Button.Enabled = Todos_chkpoint_list_Objectlistview.SelectedObjects != null;

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

        private void Timeline_Button_Click(object sender, EventArgs e)
        {
            List<Timeline> timeLines = new List<Timeline>();
            int totalCount = 0; double totalDuration = 0;
            Todo_Timeline_Control.Entrys.Clear();
            Todo_Timeline_Control.Visible = false;
            foreach (var todo in Reports_Processor.TodosList(timeline_From, timeline_To))
            {
                if (todo.done_date.HasValue) Todo_Timeline_Control.Entrys.Add(new MaterialWinforms.Controls.MaterialTimeLineEntry() { Title = todo.todo, AdditionalInfo = todo.category, Time = todo.done_date.Value, UserName = todo.dueto, Text = "" });
                else Todo_Timeline_Control.Entrys.Add(new MaterialWinforms.Controls.MaterialTimeLineEntry() { Title = todo.todo, AdditionalInfo = todo.category, Time = todo.due_date, UserName = todo.dueto, Text = "غير مكتملة" });
                totalCount += 1; totalDuration += todo.duration;
                if (todo.chkpoint_list != null && todo.chkpoint_list.Count > 0)
                    foreach (Checkpoint chk in todo.chkpoint_list)
                    {
                        totalCount += 1; Todo_Timeline_Control.Entrys.Add(new MaterialWinforms.Controls.MaterialTimeLineEntry() { Title = todo.todo, AdditionalInfo = todo.category, Time = chk.Chk_Date, UserName = todo.dueto, Text = chk.ChkName });
                    }
                /* if (todo.done_date.HasValue) timeLines.Add(new Timeline() { Category = todo.category, Title = todo.todo, date = todo.done_date.Value, Mission = "", DueTo = todo.dueto });
                 else timeLines.Add(new Timeline() { Category = todo.category, Title = todo.todo, date = todo.due_date, Mission = "غير مكتملة", DueTo = todo.dueto });
                 if (todo.chkpoint_list != null && todo.chkpoint_list.Count > 0)
                     foreach (Checkpoint chk in todo.chkpoint_list)
                         timeLines.Add(new Timeline() { Category = todo.category, Title = todo.todo, date = chk.Chk_Date, Mission = chk.ChkName, DueTo = todo.dueto });*/
            }
            Todo_Timeline_Control.SkinManager.ColorScheme = new MaterialWinforms.ColorScheme(MaterialWinforms.Primary.Amber500, MaterialWinforms.Primary.Amber700, MaterialWinforms.Primary.Amber100, MaterialWinforms.Accent.Amber200, MaterialWinforms.TextShade.WHITE);
            Todo_Timeline_Control.Visible = true;
            HM_Manager.Success_addition(Comment_Label, $"إجمالي عدد المهام {totalCount} بإجمالي فترة زمنية: {totalDuration}");
        }
    }
}
