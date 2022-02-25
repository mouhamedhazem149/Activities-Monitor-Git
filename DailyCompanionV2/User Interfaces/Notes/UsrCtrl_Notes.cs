using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using DailyCompanionV2.Models;
using DailyCompanionV2.User_Interfaces.Notes;
using DailyCompanionV2.User_Interfaces.Settings;
using DailyCompanionV2.Utilities;

namespace DailyCompanionV2.User_Interfaces
{
    public partial class UsrCtrl_Notes : UserControl, ICustomControl
    {
        public UsrCtrl_Notes() => InitialLoad();
        public UsrCtrl_Notes(Enums.noteArgument LoadArg, string MethodArg)
        {
            InitialLoad();
            switch (LoadArg)
            {
                case Enums.noteArgument.showNoteManager:
                    if (MethodArg != null)
                    {
                        State = Enums.usrctrlState.mod;
                        NOT_title_Textbox.SelectedItem = NOT_title_Textbox.Text = MethodArg;
                    }
                    break;
                case Enums.noteArgument.loadNoteItem:
                    State = Enums.usrctrlState.add;
                    break;
                default:
                    break;
            }
        }
        public UsrCtrl_Notes(Enums.noteArgument LoadArg, int MethodArg)
        {
            InitialLoad();
            switch (LoadArg)
            {
                case Enums.noteArgument.showNoteManager:
                    {
                        State = Enums.usrctrlState.mod;
                        NOT_title_Textbox.SelectedItem = NOT_title_Textbox.Text = Program.Notes_List.Where(p => p.id == MethodArg).FirstOrDefault().title;
                    }
                    break;
                case Enums.noteArgument.loadNoteItem:
                    State = Enums.usrctrlState.add;
                    break;
                default:
                    break;
            }
        }
        void InitialLoad()
        {
            InitializeByResolution();
            UsrCtrl_TgleBtn.BackColor = Program.WorkingForm.secColor;
            HM_Manager.IControlInit(this, null, Side_Panel);
        }
        public void Sync() { NOT_title_Textbox.Values = Notes_Processor.titlesList; PrepareSidePanel(); }
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
            //Modify_NOT_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.تعديل, Title = "تعديل ملاحظات", color = Enums.modColor };
            Del_NOT_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.حذف, Title = "تعديل ملاحظات", color = Enums.modColor };

            Note_Groupbox.ContextMenuStrip = Tabcontrol_contextMenuStrip;
        }
        private Enums.usrctrlState _state = Enums.usrctrlState.add;
        public Enums.usrctrlState State
        {
            get => _state;
            set
            {
                switch (value)
                {
                    case Enums.usrctrlState.mod:
                        {
                            Note_Groupbox.ForeColor = Add_NOT_Button.ForeColor = Enums.modColor;
                            Note_Groupbox.Text = Add_NOT_Button.Text = "تعديل ملاحظات";
                            UsrCtrl_TgleBtn.Checked = Del_NOT_Button.Visible = true;
                            Add_NOT_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.تعديل, Title = "تعديل ملاحظات", color = Enums.modColor };
                            break;
                        }
                    case Enums.usrctrlState.add:
                        {
                            Note_Groupbox.ForeColor = Add_NOT_Button.ForeColor = Enums.addColor;
                            Note_Groupbox.Text = Add_NOT_Button.Text = "إضافة ملاحظات";
                            UsrCtrl_TgleBtn.Checked = Del_NOT_Button.Visible = false;
                            Add_NOT_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.إضافة, Title = "إضافة ملاحظات", color = Enums.addColor };
                            break;
                        }
                }
                _state = value;
            }
        }
        private void NOTE_Button_Click(object sender, EventArgs e)
        {
            if (sender is Button || sender is ns1.BunifuImageButton)
            {
                Notes_Processor.Handle_Note(((sender as Control).Tag as settingsButtonTag_Item?).Value.handleType, Note_Groupbox
                    , NOT_title_Textbox.Text, NOT_strNote_Textbox.Text, Not_Label, ((sender as Control).Tag as settingsButtonTag_Item?).Value.Title, ((sender as Control).Tag as settingsButtonTag_Item?).Value.color
                    , Program.Notes_List.Where(item => item.title == NOT_title_Textbox.Text).FirstOrDefault());
            }
            else
                Notes_Processor.Handle_Note(Enums.genericHandle_Type.تحميل_البيانات, Note_Groupbox
                    , "", "", Not_Label, (Del_NOT_Button.Tag as settingsButtonTag_Item?).Value.Title, (Del_NOT_Button.Tag as settingsButtonTag_Item?).Value.color
                    , Program.Notes_List.Where(item => item.title == NOT_title_Textbox.Text).FirstOrDefault());
            Sync();
        }
        private void Encrypt_Button_Click(object sender, EventArgs e)
        {
        GETKEY:
            string tempKey = Interaction.InputBox("أدخل كلمة المرور لتشفير الملحوظات من 32-20 رقم (لا تستخدم مسافات) 'الأحرف العربية تحسب برقمين'", "إخطار");
            byte[] Key = Encoding.UTF8.GetBytes(tempKey);
            if (Key.Length < 20 || Key.Length > 32)
                if ((MessageBox.Show("المفتاح غير صالح. هل تريد المحاولة مرة أخرى","إخطار",MessageBoxButtons.YesNo,MessageBoxIcon.Question)) == DialogResult.Yes) goto GETKEY;
            else { HM_Manager.Fail_addition(Not_Label, "فشل التشفير"); return; }
            NOT_strNote_Textbox.Text = $@"{Convert.ToBase64String(HM_Manager.topEncrypt($@"{NOT_strNote_Textbox.Text}", new Tuple<byte[], byte[]>(Key, Key.Reverse().ToArray()), Not_Label))}";
        }

        private void Decrypt_Button_Click(object sender, EventArgs e)
        {
        GETKEY:
            string tempKey = Interaction.InputBox("أدخل كلمة المرور لفك تشفير الملحوظات من 32-20 رقم (لا تستخدم مسافات) 'الأحرف العربية تحسب برقمين'", "إخطار");
            byte[] Key = Encoding.UTF8.GetBytes(tempKey); /*Encoding.UTF8.GetBytes(tempKey);*/
            if (Key.Length < 20 || Key.Length > 32) if ((MessageBox.Show("المفتاح غير صالح. هل تريد المحاولة مرة أخرى", "إخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes) 
                    goto GETKEY;
                else { HM_Manager.Fail_addition(Not_Label, "فشل التشفير"); return; }
            NOT_strNote_Textbox.Text = $@"{HM_Manager.Decrypt(Convert.FromBase64String($@"{NOT_strNote_Textbox.Text}"), new Tuple<byte[], byte[]>(Key, Key.Reverse().ToArray()), Not_Label)}";
        }

        private void NOT_title_Textbox_SelectedItemChanged(object sender, EventArgs e)
        {
            if (NOT_title_Textbox.Text != "")
            { State = Enums.usrctrlState.mod; NOTE_Button_Click("loadData", null); }
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

        private void UsrCtrl_TgleBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (HM_Manager.CheckIfContainWrittenEntries(Note_Groupbox))
                if (MessageBox.Show("هل تريد حذف المدخلات الحالية ؟", "إخطار تغيير حالة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    HM_Manager.Reset_Groupbox_Controls(Note_Groupbox);
            if (UsrCtrl_TgleBtn.Checked) State = Enums.usrctrlState.mod;
            else State = Enums.usrctrlState.add;
        }
    }
}
