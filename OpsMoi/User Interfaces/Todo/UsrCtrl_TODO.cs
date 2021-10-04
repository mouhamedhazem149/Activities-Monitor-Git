using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ns1;
using OpsMoi.Models;
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
        private int tempBill_ID = -1;
        public void Set_Tags()
        {
            Add_TODO_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.إضافة, Title = "إضافة مهام", color = Enums.addColor };
            Modify_TODO_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.تعديل, Title = "تعديل مهام", color = Enums.modColor };
            Del_TODO_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.حذف, Title = "تعديل مهام", color = Enums.modColor };
        }
        private List<Control> editControls { get { return new List<Control> { TODO_due_date_Datetimepicker,TODO_due_date_Adj_Label,TODO_done_date_Datetimepicker,TODO_done_date_Adj_Label,TODO_duration_Textbox,TODO_duration_Adj_Label,TODO_duration_value_Label }; } }

        public void Sync()
        {
            TODO_id_Textbox.Values = Program.Todos_List.Select(tdo => tdo.id.ToString()).ToArray();
            TODO_category_Textbox.Values = HM_Manager.commonCategories;
            TODO_todo_Textbox.Values = HM_Manager.commonTodos;
            TODO_duefrom_Textbox.Values = TODO_dueto_Textbox.Values = HM_Manager.commonEntities;
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
                    , TODO_duefrom_Textbox.Text, TODO_dueto_Textbox.Text, TODO_todo_Textbox.Text, TODO_category_Textbox.Text, TODO_due_date_Datetimepicker.Value, TODO_done_date_Datetimepicker.Checked, TODO_done_date_Datetimepicker.Value, old != null ? old.added_date : DateTime.Now, tempDuration, TODO_notes_Textbox.Text
                    , AddTODO_Label, ((sender as Button).Tag as settingsButtonTag_Item?).Value.Title, ((sender as Button).Tag as settingsButtonTag_Item?).Value.color
                    , old);
            }
            else
                Todo_Processor.HandleTODO(Enums.genericHandle_Type.تحميل_البيانات, AddTodo_Groupbox
                    , "", "", "", "", DateTime.Now, false, DateTime.Now, DateTime.Now, 0, "", AddTODO_Label, (Modify_TODO_Button.Tag as settingsButtonTag_Item?).Value.Title, (Modify_TODO_Button.Tag as settingsButtonTag_Item?).Value.color
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
    }
}
