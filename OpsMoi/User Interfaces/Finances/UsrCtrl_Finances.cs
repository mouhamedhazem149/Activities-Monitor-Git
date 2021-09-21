using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using OpsMoi.Models;
using OpsMoi.Utilities;
using ns1;
using System.Collections.Generic;
using OpsMoi.User_Interfaces.Settings;
using OpsMoi.User_Interfaces.Finance;

namespace OpsMoi
{
    public partial class UsrCtrl_Finances : UserControl, ICustomControl
    {
        public static string fncLoadArg = "LoadFinances";
        public UsrCtrl_Finances() => InitialLoad();
        public UsrCtrl_Finances(Enums.financeArgument LoadArg, int? e_ID)
        {
            InitialLoad();
            switch (LoadArg)
            {
                case Enums.financeArgument.loadFinanceItem:
                    if (e_ID.HasValue) FNC_id_Textbox.SelectedItem = FNC_id_Textbox.Text = e_ID.Value.ToString();
                    break;
                case Enums.financeArgument.showFinanceManager:
                    TileButton_Click(FNCManager_TileButton, EventArgs.Empty);
                    break;
                default:
                    break;
            }
        }
        void InitialLoad()
        {
            InitializeByResolution(); 
            HM_Manager.IControlInit(this, FNC_TabControl, TileButtons_Panel);
            FNC_type_Combobox.DataSource = Enum.GetValues(typeof(Enums.financeType));
        }
        public void Sync()
        {
            FNC_id_Textbox.Values = Program.Finances_List.Select(tdo => tdo.id.ToString()).ToArray();
            FNC_relatedentity_Textbox.Values = HM_Manager.commonEntities;
            FNC_category_Textbox.Values = HM_Manager.commonEntities;   
        }
        public void InitializeByResolution()
        {
            switch (Program.currentResolution)
            {
                case Enums.Resolution.A_1920x1080:
                    InitializeComponent();
                    break;
                    /*case Enums.Resolution.B_1366x768:
                        InitializeComponent1366x768();
                        break;
                    case Enums.Resolution.C_1280x1040:
                        InitializeComponent1280x1040();
                        break;*/
            }
        }
        public void SetButton_Tags()
        {
            Add_FNC_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.إضافة, Title = "إضافة عملية مالية", color = Enums.addColor };
            Modify_FNC_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.تعديل, Title = "تعديل عملية مالية", color = Enums.modColor };
            Del_FNC_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.حذف, Title = "تعديل عملية مالية", color = Enums.modColor };
        }
        /*
        private DateTime reqlist_From { get { return REQSearch_From_Datetimepicker.Value.Date; } }
        private DateTime reqlist_To { get { return REQSearch_To_Datetimepicker.Value.Date; } }
        private string reqlist_SearchTerm { get { return REQ_MTN_Search.Text; } }

        private DateTime searchlist_From { get { return SearchFromDateTimePicker.Value.Date; } }
        private DateTime searchlist_To { get { return SearchToDateTimePicker.Value.Date; } }
        private string searchlist_SearchTerm { get { return Searchterm_Textbox.Text; } }
        */
        private List<Control> editControls => new List<Control> { FNC_done_date_Adj_Label, FNC_done_date_Datetimepicker };
        
        private void FNC_Button_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                double tempDue = double.TryParse(FNC_due_Textbox.Text, out tempDue) ? double.Parse(FNC_due_Textbox.Text) : 0;
                double tempPaid = double.TryParse(FNC_paid_Textbox.Text, out tempPaid) ? double.Parse(FNC_paid_Textbox.Text) : 0;
                Finances_Processor.HandleFNC(((sender as Button).Tag as settingsButtonTag_Item?).Value.handleType, AddFinance_Groupbox
                    , FNC_relatedentity_Textbox.Text, (Enums.financeType)Enum.Parse(typeof(Enums.financeType), FNC_type_Combobox.Text), FNC_category_Textbox.Text, tempDue, tempPaid, FNC_due_date_Datetimepicker.Value, FNC_done_date_Datetimepicker, FNC_notes_Textbox.Text
                    , FNC_Label, ((sender as Button).Tag as settingsButtonTag_Item?).Value.Title, ((sender as Button).Tag as settingsButtonTag_Item?).Value.color
                    , Program.Finances_List.Where(item => item.id.ToString() == FNC_id_Textbox.Text).FirstOrDefault());
            }
            else
                Finances_Processor.HandleFNC(Enums.genericHandle_Type.تحميل_البيانات, AddFinance_Groupbox
                    , "", Enums.financeType.دخل, "", 0,0 ,DateTime.Now, null, "", FNC_Label, (Modify_FNC_Button.Tag as settingsButtonTag_Item?).Value.Title, (Modify_FNC_Button.Tag as settingsButtonTag_Item?).Value.color
                    , Program.Finances_List.Where(item => item.id.ToString() == FNC_id_Textbox.Text).FirstOrDefault());
            Sync();
        }

        private void TileButton_Click(object sender, EventArgs e) =>
           HM_Manager.TabButtonsClick(FNC_TabControl, TileButtons_Panel, sender as BunifuTileButton, SidePanel1);


        private void id_Textbox_TextChanged(object sender, EventArgs e) => HM_Manager.CheckTxtBoxInt(sender as TextBox, id_Label);

        private void FNC_id_Textbox_SelectedItemChanged(object sender, EventArgs e)
        {
            if (FNC_id_Textbox.Text != "")
                FNC_Button_Click("loadData", null);
        }

        private void AddFNC_Groupbox_ForeColorChanged(object sender, EventArgs e) { HM_Manager.Reset_Textbox_Controls(sender as GroupBox);/* editControls.ForEach(ctrl => ctrl.Visible = FNC_id_Textbox.Enabled = (sender as GroupBox).ForeColor == Enums.modColor);*/ }

        private void FNC_value_Textbox_TextChanged(object sender, EventArgs e) => HM_Manager.CheckTxtBoxDecimal(sender as ModdedControls.ModdedTextBox, FNC_Label);

    }
}
