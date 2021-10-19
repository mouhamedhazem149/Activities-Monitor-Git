using System;
using System.Linq;
using System.Windows.Forms;
using ns1;
using OpsMoi.Models;
using OpsMoi.User_Interfaces.Settings;
using OpsMoi.Utilities;

namespace OpsMoi.User_Interfaces
{
    public partial class UsrCtrl_Settings : UserControl, ICustomControl
    {
        public UsrCtrl_Settings() => InitialLoad();
        public UsrCtrl_Settings(Enums.settingsArgument Arg, string MethodArg)
        {
            InitialLoad();
            switch (Arg)
            {
                case Enums.settingsArgument.openWalletManager:
                    TileButtons_Click(Finances_TileButton, EventArgs.Empty);
                    Wallet_name_Textbox.SelectedItem = Wallet_name_Textbox.Text = MethodArg;
                    break;
                case Enums.settingsArgument.none:
                    break;
                default:
                    break;
            }
        }
        void InitialLoad()
        {
            InitializeByResolution();
            HM_Manager.IControlInit(this, Settings_Tabcontnol, TileButtons_Panel);
        }
        public void Set_Tags()
        {
            Add_Wallet_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.إضافة, Title = "إضافة محافظ", color = Enums.addColor };
            Modify_Wallet_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.تعديل, Title = "تعديل محافظ", color = Enums.modColor };
            Del_Wallet_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.حذف, Title = "تعديل محافظ", color = Enums.modColor };
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

        private Wallet activeWallet = null;
        // // // // // // // TEXTBOXES SECTION // // // // // // //
        private void TODO_id_Textbox_TextChanged(object sender, EventArgs e) => HM_Manager.CheckTxtBoxDecimal(sender as ModdedControls.ModdedTextBox, Wallet_Label);
        private void Wallet_name_Textbox_SelectedItemChanged(object sender, EventArgs e) { if (Wallet_name_Textbox.Text != "") Wallet_Button_Click("loadData", null); }
        // // // // // // // RADIOBUTTONS SECTION // // // // // // //
        private void Radiobutton_ChangeColor(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked && (sender as RadioButton).Focused)
            {
                Program.WorkingForm.Change_Color((sender as RadioButton).BackColor, (sender as RadioButton).ForeColor);
                HM_Manager.SetButtons_Color(TileButtons_Panel);
            }
        }
        // // // // // // // BUTTONS SECTION // // // // // // //
        private void Wallet_Button_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                decimal credit = decimal.TryParse(Wallet_credit_Textbox.Text, out credit) ? decimal.Parse(Wallet_credit_Textbox.Text) : 0;
                Settings_Processor.HandleWallet(((sender as Button).Tag as settingsButtonTag_Item?).Value.handleType, Wallets_Groupbox
                    , Wallet_name_Textbox.Text, credit, Wallet_Label, ((sender as Button).Tag as settingsButtonTag_Item?).Value.Title, ((sender as Button).Tag as settingsButtonTag_Item?).Value.color
                    , activeWallet);
                activeWallet = null;
            }
            else
            {
                Settings_Processor.HandleWallet(Enums.genericHandle_Type.تحميل_البيانات, Wallets_Groupbox
                    , "", 0, Wallet_Label, (Modify_Wallet_Button.Tag as settingsButtonTag_Item?).Value.Title, (Modify_Wallet_Button.Tag as settingsButtonTag_Item?).Value.color
                    , Program.Wallets_List.Where(item => item.name == Wallet_name_Textbox.Text).FirstOrDefault());
                activeWallet = Program.Wallets_List.Where(item => item.name == Wallet_name_Textbox.Text).FirstOrDefault();
            }
            Sync();
        }

        private void TileButtons_Click(object sender, EventArgs e) =>
            HM_Manager.TabButtonsClick(Settings_Tabcontnol, TileButtons_Panel, sender as BunifuTileButton, SidePanel1);
        // // // // // // // COMBOBOXES SECTION // // // // // // //
        public void Sync()
        {
            Wallet_name_Textbox.Values = Program.Wallets_List.Select(p => p.name).ToArray();
        }

        private void PickColor_Button_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Program.WorkingForm.Change_Color(colorDialog1.Color, ControlPaint.Light(colorDialog1.Color, 0.42F));
                HM_Manager.SetButtons_Color(TileButtons_Panel);
            }
        }

        private void Backup_Button_Click(object sender, EventArgs e) => BackupHelperManager.BackUp(Restore_Label);
        private void Restore_Button_Click(object sender, EventArgs e) => BackupHelperManager.Restore(Restore_Label);

    }
}
