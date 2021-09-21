using OpsMoi.Utilities;
using System.Drawing;
using System.Windows.Forms;

namespace OpsMoi.User_Interfaces.User
{
    public static class User_Processor
    {
        public static void InitializeNameBranchColor(UsrCtrl_User userCtrl, Color color, string userName, Label usernameLabel, string branchName, Label branchnameLabel,string Category,Label catLabel)
        {
            userCtrl.BackColor = ControlPaint.Light(color, .2f);

            usernameLabel.Text = userName; usernameLabel.Location = new Point(395 - usernameLabel.Size.Width, usernameLabel.Location.Y);
            branchnameLabel.Text = branchName; branchnameLabel.Location = new Point(395 - branchnameLabel.Size.Width, branchnameLabel.Location.Y);
            catLabel.Text = Category;
            foreach (Control cont in userCtrl.Controls)
                cont.BringToFront();
        }

        public static void HandleLogOut()
        {
            Program.WorkingForm.Dispose();
            HM_Manager.HandleHistory(new string[] { "المستخدمين", "تسجيل خروج", $"اسم المستخدم: {Program.mainSettings.name}" });
            LogInForm MainForm = new LogInForm();
            MainForm.ShowDialog();
        }

        public static void ChangePassword(string OldPassword,string NewPassword,string RNewPassword,Label MsgLabel)
        {
           
        }
    }
}
