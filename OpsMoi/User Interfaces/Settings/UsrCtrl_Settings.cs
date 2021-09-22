using System;
using System.Windows.Forms;
using ns1;
using OpsMoi.Models;
using OpsMoi.Utilities;

namespace OpsMoi.User_Interfaces
{
    public partial class UsrCtrl_Settings : UserControl, ICustomControl
    {
        public UsrCtrl_Settings() => InitialLoad();
        public UsrCtrl_Settings(string LoadArg, string MethodArg)
        {
            InitialLoad();
            /*if (LoadArg == showEmplyeeArg)
                this.LoadEmployee(MethodArg);*/
        }
        void InitialLoad()
        {
            InitializeByResolution();
            HM_Manager.IControlInit(this, Settings_Tabcontnol, TileButtons_Panel);
        }
        public void Set_Tags() { }
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
        // // // // // // // TEXTBOXES SECTION // // // // // // //

        // // // // // // // RADIOBUTTONS SECTION // // // // // // //
        private void Radiobutton_ChangeColor(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                Program.WorkingForm.Change_Color((sender as RadioButton).BackColor, (sender as RadioButton).ForeColor);
                HM_Manager.SetButtons_Color(TileButtons_Panel);
            }
        }
        // // // // // // // BUTTONS SECTION // // // // // // //

        private void TileButtons_Click(object sender, EventArgs e) =>
            HM_Manager.TabButtonsClick(Settings_Tabcontnol, TileButtons_Panel, sender as BunifuTileButton, SidePanel1);
        // // // // // // // COMBOBOXES SECTION // // // // // // //
        public void Sync()
        {

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

        private void RENew_Password_Textbox_TextChanged(object sender, EventArgs e) => ChangePassword_Label.Visible = (New_Password_Textbox.Text != "" && RENew_Password_Textbox.Text != New_Password_Textbox.Text);

        private void STNG_PasswordChange_Button_Click(object sender, EventArgs e) => Settings.Settings_Processor.ChangePassword(Old_Password_Textbox.Text, New_Password_Textbox.Text, RENew_Password_Textbox.Text, ChangePassword_Label);
    }
}
