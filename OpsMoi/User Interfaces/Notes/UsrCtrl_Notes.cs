using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using ns1;
using OpsMoi.Models;
using OpsMoi.User_Interfaces.Notes;
using OpsMoi.User_Interfaces.Settings;
using OpsMoi.Utilities;

namespace OpsMoi.User_Interfaces
{
    public partial class UsrCtrl_Notes : UserControl, ICustomControl
    {
        public static string strgLoadArg = "LoadStorage";
        public UsrCtrl_Notes() => InitialLoad();
        public UsrCtrl_Notes(Enums.noteArgument LoadArg, string MethodArg)
        {
            InitialLoad();
            switch (LoadArg)
            {
                case Enums.noteArgument.showNoteManager:
                    if (MethodArg != null) NOT_title_Textbox.SelectedItem = NOT_title_Textbox.Text = MethodArg;
                    break;
                case Enums.noteArgument.loadNoteItem:
                    TileButton_Click(NotesManager_TileButton, EventArgs.Empty);
                    break;
                default:
                    break;
            }
        }
        void InitialLoad()
        {
            InitializeByResolution();
            HM_Manager.IControlInit(this, storage_Tabcontrol, TileButtons_Panel);
        }
        public void Sync() { NOT_title_Textbox.Values = Notes_Processor.titlesList; }
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
            Add_NOT_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.إضافة, Title = "إضافة ملاحظات", color = Enums.addColor };
            Modify_NOT_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.تعديل, Title = "تعديل ملاحظات", color = Enums.modColor };
            Del_NOT_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.حذف, Title = "تعديل ملاحظات", color = Enums.modColor };

            Note_Groupbox.ContextMenuStrip = Tabcontrol_contextMenuStrip;
        }

        private void NOTE_Button_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Notes_Processor.Handle_Note(((sender as Button).Tag as settingsButtonTag_Item?).Value.handleType, Note_Groupbox
                    , NOT_title_Textbox.Text, NOT_strNote_Textbox.Text, Not_Label, ((sender as Button).Tag as settingsButtonTag_Item?).Value.Title, ((sender as Button).Tag as settingsButtonTag_Item?).Value.color
                    , Program.Notes_List.Where(item => item.title == NOT_title_Textbox.Text).FirstOrDefault());
            }
            else
                Notes_Processor.Handle_Note(Enums.genericHandle_Type.تحميل_البيانات, Note_Groupbox
                    , "", "", Not_Label, (Modify_NOT_Button.Tag as settingsButtonTag_Item?).Value.Title, (Modify_NOT_Button.Tag as settingsButtonTag_Item?).Value.color
                    , Program.Notes_List.Where(item => item.title == NOT_title_Textbox.Text).FirstOrDefault());
            Sync();
        }

        private void TileButton_Click(object sender, EventArgs e) =>
           HM_Manager.TabButtonsClick(storage_Tabcontrol, TileButtons_Panel, sender as BunifuTileButton, SidePanel1);

        private void Encrypt_Button_Click(object sender, EventArgs e)
        {
        GETKEY:
            string tempKey = Interaction.InputBox("أدخل كلمة المرور لتشفير الملحوظات من 32-20 رقم (لا تستخدم مسافات) 'الأحرف العربية تحسب برقمين'", "إخطار");
            byte[] Key = Encoding.UTF8.GetBytes(tempKey);
            if (Key.Length < 20 || Key.Length > 32) goto GETKEY;
            NOT_strNote_Textbox.Text = $@"{Convert.ToBase64String(HM_Manager.topEncrypt($@"{NOT_strNote_Textbox.Text}", new Tuple<byte[], byte[]>(Key, Key.Reverse().ToArray()), Not_Label))}";
        }

        private void Decrypt_Button_Click(object sender, EventArgs e)
        {
        GETKEY:
            string tempKey = Interaction.InputBox("أدخل كلمة المرور لفك تشفير الملحوظات من 32-20 رقم (لا تستخدم مسافات) 'الأحرف العربية تحسب برقمين'", "إخطار");
            byte[] Key = Encoding.UTF8.GetBytes(tempKey); /*Encoding.UTF8.GetBytes(tempKey);*/
            if (Key.Length < 20 || Key.Length > 32) goto GETKEY;
            NOT_strNote_Textbox.Text = $@"{HM_Manager.Decrypt(Convert.FromBase64String($@"{NOT_strNote_Textbox.Text}"), new Tuple<byte[], byte[]>(Key, Key.Reverse().ToArray()), Not_Label)}";
        }

        private void NOT_title_Textbox_SelectedItemChanged(object sender, EventArgs e)
        {
            if (NOT_title_Textbox.Text != "")
                NOTE_Button_Click("loadData", null);
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
    }
}
