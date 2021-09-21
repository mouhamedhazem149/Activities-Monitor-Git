using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OpsMoi.Forms;
using OpsMoi.Utilities;

namespace OpsMoi
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            Resolution_Combobox_ItemsLoad();
            this.AcceptButton = Login_Button;
        }
        private void Resolution_Combobox_ItemsLoad() 
        {
            string toSelect = Program.currentResolution.GetDisplayName();
            HM_Manager.Update_Combobox(Resolution_Combobox, LoginForm_Handler.resolution_Combobox_Items, "displayName", "realName");
            Resolution_Combobox.Text = toSelect;
        }
        // // // // // // // BUTTONS // // // // // // //
        private void showpassword_ImageButton_Click(object sender, EventArgs e) => Login_Password_Textbox.UseSystemPasswordChar = !Login_Password_Textbox.UseSystemPasswordChar;

        private async void ForgetPassword_Button_Click(object sender, EventArgs e) => await LoginForm_Handler.ForgetPassword_Handle(Login_Label);

        private void Login_Button_Click(object sender, EventArgs e) =>  LoginForm_Handler.loginAttempt_Handle(this, Login_Password_Textbox.Text, Login_Label);

        private void Resolution_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string real = ((EnumStruct)Resolution_Combobox.SelectedItem).realName;
            HM_Manager.UpdateConfiguration(new List<Tuple<string, string>> { new Tuple<string, string>("Resolution", real) });
            Program.currentResolution = (Enums.Resolution)Enum.Parse(typeof(Enums.Resolution), real);
        }

        private void LogInForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Tab:
                    SelectNextControl(ActiveControl, true, true, true, true);
                    break;
            }
        }

        private void LogInForm_FormClosed(object sender, FormClosedEventArgs e) => Environment.Exit(0);
    }
}
