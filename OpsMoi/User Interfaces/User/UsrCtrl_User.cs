using System;
using System.Drawing;
using System.Windows.Forms;
using OpsMoi.User_Interfaces.User;
using System.Linq;
using OpsMoi.Utilities;

namespace OpsMoi.User_Interfaces
{
    public partial class UsrCtrl_User : UserControl
    {
        public UsrCtrl_User(string userName, string Category,string Branch, Color color = new Color())
        {
            create = true;
            InitializeByResolution();
            Program.WorkingForm.AcceptButton = Change_Password_Button;
            Program.WorkingForm.ActiveControl = null;
            User_Processor.InitializeNameBranchColor(this, color, userName, UserName_Label, Branch, UserBranch_Label, Category, User_Category_Label);
            create = false;
        }
        void InitializeByResolution()
        {
            switch (Program.currentResolution)
            {
                case Enums.Resolution.A_1920x1080:
                    InitializeComponent();
                    break;
                case Enums.Resolution.B_1366x768:
                    InitializeComponent1366x768();
                    break;
                case Enums.Resolution.C_1280x1040:
                    InitializeComponent1280x1040();
                    break;
            }
        }
        ~UsrCtrl_User() { if (Program.WorkingForm.AcceptButton == Change_Password_Button) Program.WorkingForm.AcceptButton = null; }
        
        bool create = false;
        
        private void Textbox_Enter(object sender, EventArgs e) { TextBox txtbx = sender as TextBox; if (txtbx.ForeColor != Color.Black) { txtbx.Text = ""; txtbx.ForeColor = Color.Black; txtbx.UseSystemPasswordChar = txtbx.Name.Contains("Password"); } }
        private void Textbox_Leave(object sender, EventArgs e) { TextBox txtbx = sender as TextBox; if (txtbx.Text == "") { txtbx.ForeColor = Color.Silver; txtbx.Text = txtbx.Tag.ToString(); txtbx.UseSystemPasswordChar = false; } }

        private void PasswordShow_Button(object sender, EventArgs e) => ((sender as ns1.BunifuImageButton).Tag as ModdedControls.ModdedTextBox).UseSystemPasswordChar = !((sender as ns1.BunifuImageButton).Tag as ModdedControls.ModdedTextBox).UseSystemPasswordChar;

        private void LogOutButton_Click(object sender, EventArgs e) => User_Processor.HandleLogOut();

        private void RENew_Password_Textbox_TextChanged(object sender, EventArgs e) => UnMatchedPassword_Label.Visible = (New_Password_Textbox.Text != "" && RENew_Password_Textbox.Text != New_Password_Textbox.Text);

        private void Change_Password_Button_Click(object sender, EventArgs e) => User_Processor.ChangePassword(Old_Password_Textbox.Text, New_Password_Textbox.Text, RENew_Password_Textbox.Text, UnMatchedPassword_Label);

        private void UsrCtrl_User_Leave(object sender, EventArgs e) {
            /*if (!(create || (Controls.OfType<Control>().Any(p => p.Focused)) || textboxes_Panel.Controls.OfType<Control>().Any(p => p.Focused)))  Program.WorkingForm.clickUser(); */}

        private void UsrCtrl_User_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Tab:
                    SelectNextControl(ActiveControl, true, true, true, true);
                    break;
            }
        }
    }
}
