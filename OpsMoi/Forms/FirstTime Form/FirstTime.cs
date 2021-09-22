using System;
using System.Windows.Forms;
using OpsMoi.Forms.FirstTime_Form;

namespace OpsMoi
{
    public partial class FirstTime : Form
    {
        public FirstTime()
        {
            SplashForm.SplashFunc(InitializeComponent);
            password_Textbox.Select(); repassword_Textbox.Select(); Msg_Label.Select();
            this.BringToFront();
        }

        private void serial_Textbox_Leave(object sender, EventArgs e) => FirstTime_Handler.CheckSerial(sender as ModdedControls.ModdedTextBox, Msg_Label, Start_Button);

        private void Start_Button_Click(object sender, EventArgs e) =>
        FirstTime_Handler.Ignite(false, name_Textbox.Text, address_Textbox.Text, phonenumber_Textbox.Text, email_Textbox.Text, owner_Groupbox,
            password_Textbox.Text, serial_Textbox.Text, companywebpage_Textbox.Text, user_Groupbox, Msg_Label, Ignitation_Progrssbar, this);
        
        private void repassword_Textbox_TextChanged(object sender, EventArgs e) =>
            unmatched_Label.Visible = (password_Textbox.Text != "" && repassword_Textbox.Text != password_Textbox.Text);
        private void repassword_Textbox_Leave(object sender, EventArgs e)
        { if (password_Textbox.Text != repassword_Textbox.Text) repassword_Textbox.Text = ""; }

    }
}
