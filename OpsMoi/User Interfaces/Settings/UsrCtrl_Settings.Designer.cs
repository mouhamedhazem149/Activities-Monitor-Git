using OpsMoi.User_Interfaces.Settings;
using OpsMoi.Utilities;
using ModdedControls;

namespace OpsMoi.User_Interfaces
{
    partial class UsrCtrl_Settings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
      
        private void InitializeComponent()
         {
            this.GeneralSettings_Groupbox = new System.Windows.Forms.GroupBox();
            this.PickColor_Button = new System.Windows.Forms.Button();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.Settings_Label = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Settings_Tabcontnol = new TransparentTabControl();
            this.General_Tabpage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Restore_Label = new System.Windows.Forms.Label();
            this.Backup_Button = new System.Windows.Forms.Button();
            this.Restore_Button = new System.Windows.Forms.Button();
            this.HR_Tabpage = new System.Windows.Forms.TabPage();
            this.Login_Tabpage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.STNG_PasswordChange_Button = new System.Windows.Forms.Button();
            this.Old_Password_Textbox = new ModdedControls.ModdedTextBox();
            this.ChangePassword_Label = new System.Windows.Forms.Label();
            this.RENew_Password_Textbox = new ModdedControls.ModdedTextBox();
            this.New_Password_Textbox = new ModdedControls.ModdedTextBox();
            this.FNC_Tabpage = new System.Windows.Forms.TabPage();
            this.Wallets_Groupbox = new System.Windows.Forms.GroupBox();
            this.Wallet_credit_Textbox = new ModdedControls.ModdedTextBox();
            this.Wallet_credit_Adj_Label = new System.Windows.Forms.Label();
            this.Wallet_name_Adj_Label = new System.Windows.Forms.Label();
            this.Modify_Wallet_Button = new System.Windows.Forms.Button();
            this.Del_Wallet_Button = new System.Windows.Forms.Button();
            this.Wallet_Label = new System.Windows.Forms.Label();
            this.Add_Wallet_Button = new System.Windows.Forms.Button();
            this.Wallet_name_Textbox = new ModdedControls.ModdedTextBox();
            this.TileButtons_Panel = new System.Windows.Forms.Panel();
            this.SidePanel1 = new System.Windows.Forms.Panel();
            this.General_TileButton = new ns1.BunifuTileButton();
            this.LoginTilebutton = new ns1.BunifuTileButton();
            this.Finances_TileButton = new ns1.BunifuTileButton();
            this.HR_TileButton = new ns1.BunifuTileButton();
            this.GeneralSettings_Groupbox.SuspendLayout();
            this.Settings_Tabcontnol.SuspendLayout();
            this.General_Tabpage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Login_Tabpage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.FNC_Tabpage.SuspendLayout();
            this.Wallets_Groupbox.SuspendLayout();
            this.TileButtons_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralSettings_Groupbox
            // 
            this.GeneralSettings_Groupbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GeneralSettings_Groupbox.Controls.Add(this.PickColor_Button);
            this.GeneralSettings_Groupbox.Controls.Add(this.radioButton8);
            this.GeneralSettings_Groupbox.Controls.Add(this.radioButton7);
            this.GeneralSettings_Groupbox.Controls.Add(this.radioButton6);
            this.GeneralSettings_Groupbox.Controls.Add(this.radioButton5);
            this.GeneralSettings_Groupbox.Controls.Add(this.Settings_Label);
            this.GeneralSettings_Groupbox.Controls.Add(this.radioButton1);
            this.GeneralSettings_Groupbox.Controls.Add(this.radioButton4);
            this.GeneralSettings_Groupbox.Controls.Add(this.radioButton2);
            this.GeneralSettings_Groupbox.Controls.Add(this.radioButton3);
            this.GeneralSettings_Groupbox.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneralSettings_Groupbox.ForeColor = System.Drawing.Color.DarkRed;
            this.GeneralSettings_Groupbox.Location = new System.Drawing.Point(366, 12);
            this.GeneralSettings_Groupbox.Name = "GeneralSettings_Groupbox";
            this.GeneralSettings_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GeneralSettings_Groupbox.Size = new System.Drawing.Size(1262, 147);
            this.GeneralSettings_Groupbox.TabIndex = 4;
            this.GeneralSettings_Groupbox.TabStop = false;
            this.GeneralSettings_Groupbox.Text = "إعدادات البرنامج";
            // 
            // PickColor_Button
            // 
            this.PickColor_Button.Location = new System.Drawing.Point(704, 29);
            this.PickColor_Button.Name = "PickColor_Button";
            this.PickColor_Button.Size = new System.Drawing.Size(242, 46);
            this.PickColor_Button.TabIndex = 9;
            this.PickColor_Button.Text = "اختار لون أخر";
            this.PickColor_Button.UseVisualStyleBackColor = true;
            this.PickColor_Button.Click += new System.EventHandler(this.PickColor_Button_Click);
            // 
            // radioButton8
            // 
            this.radioButton8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton8.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radioButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radioButton8.Location = new System.Drawing.Point(194, 87);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(149, 47);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.TabStop = true;
            this.radioButton8.UseVisualStyleBackColor = false;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.Radiobutton_ChangeColor);
            // 
            // radioButton7
            // 
            this.radioButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton7.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioButton7.Location = new System.Drawing.Point(345, 87);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(149, 47);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.TabStop = true;
            this.radioButton7.UseVisualStyleBackColor = false;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.Radiobutton_ChangeColor);
            // 
            // radioButton6
            // 
            this.radioButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton6.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton6.AutoSize = true;
            this.radioButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.radioButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.radioButton6.Location = new System.Drawing.Point(58, 87);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(107, 47);
            this.radioButton6.TabIndex = 8;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "افتراضي";
            this.radioButton6.UseVisualStyleBackColor = false;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.Radiobutton_ChangeColor);
            // 
            // radioButton5
            // 
            this.radioButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton5.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton5.BackColor = System.Drawing.Color.Navy;
            this.radioButton5.ForeColor = System.Drawing.Color.Navy;
            this.radioButton5.Location = new System.Drawing.Point(496, 87);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(149, 47);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = false;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.Radiobutton_ChangeColor);
            // 
            // Settings_Label
            // 
            this.Settings_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Settings_Label.AutoSize = true;
            this.Settings_Label.ForeColor = System.Drawing.Color.Black;
            this.Settings_Label.Location = new System.Drawing.Point(959, 35);
            this.Settings_Label.Name = "Settings_Label";
            this.Settings_Label.Size = new System.Drawing.Size(259, 37);
            this.Settings_Label.TabIndex = 4;
            this.Settings_Label.Text = "اختر الباقة اللونية للبرنامج";
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.BackColor = System.Drawing.Color.Teal;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Teal;
            this.radioButton1.Location = new System.Drawing.Point(647, 87);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(149, 47);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.Radiobutton_ChangeColor);
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton4.BackColor = System.Drawing.Color.Green;
            this.radioButton4.ForeColor = System.Drawing.Color.SpringGreen;
            this.radioButton4.Location = new System.Drawing.Point(1099, 87);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(149, 47);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = false;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.Radiobutton_ChangeColor);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.BackColor = System.Drawing.Color.RoyalBlue;
            this.radioButton2.ForeColor = System.Drawing.Color.Firebrick;
            this.radioButton2.Location = new System.Drawing.Point(798, 87);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(149, 47);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.Radiobutton_ChangeColor);
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.BackColor = System.Drawing.Color.DimGray;
            this.radioButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButton3.Location = new System.Drawing.Point(949, 87);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(149, 47);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.Radiobutton_ChangeColor);
            // 
            // Settings_Tabcontnol
            // 
            this.Settings_Tabcontnol.Controls.Add(this.General_Tabpage);
            this.Settings_Tabcontnol.Controls.Add(this.HR_Tabpage);
            this.Settings_Tabcontnol.Controls.Add(this.Login_Tabpage);
            this.Settings_Tabcontnol.Controls.Add(this.FNC_Tabpage);
            this.Settings_Tabcontnol.ItemSize = new System.Drawing.Size(0, 1);
            this.Settings_Tabcontnol.Location = new System.Drawing.Point(147, 1);
            this.Settings_Tabcontnol.Name = "Settings_Tabcontnol";
            this.Settings_Tabcontnol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Settings_Tabcontnol.SelectedIndex = 0;
            this.Settings_Tabcontnol.Size = new System.Drawing.Size(1715, 909);
            this.Settings_Tabcontnol.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Settings_Tabcontnol.TabIndex = 61;
            // 
            // General_Tabpage
            // 
            this.General_Tabpage.Controls.Add(this.groupBox2);
            this.General_Tabpage.Controls.Add(this.GeneralSettings_Groupbox);
            this.General_Tabpage.Location = new System.Drawing.Point(4, 5);
            this.General_Tabpage.Name = "General_Tabpage";
            this.General_Tabpage.Size = new System.Drawing.Size(1707, 900);
            this.General_Tabpage.TabIndex = 2;
            this.General_Tabpage.Text = "إعدادات عامة";
            this.General_Tabpage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.Restore_Label);
            this.groupBox2.Controls.Add(this.Backup_Button);
            this.groupBox2.Controls.Add(this.Restore_Button);
            this.groupBox2.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(366, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1262, 236);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "قاعدة البيانات";
            // 
            // Restore_Label
            // 
            this.Restore_Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Restore_Label.Font = new System.Drawing.Font("El Messiri", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restore_Label.Location = new System.Drawing.Point(8, 107);
            this.Restore_Label.Name = "Restore_Label";
            this.Restore_Label.Size = new System.Drawing.Size(1245, 122);
            this.Restore_Label.TabIndex = 54;
            this.Restore_Label.Text = "الرقم القومي يتكون من أرقام فقط!";
            this.Restore_Label.Visible = false;
            // 
            // Backup_Button
            // 
            this.Backup_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Backup_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Backup_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backup_Button.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backup_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Backup_Button.Location = new System.Drawing.Point(881, 55);
            this.Backup_Button.Name = "Backup_Button";
            this.Backup_Button.Size = new System.Drawing.Size(367, 44);
            this.Backup_Button.TabIndex = 52;
            this.Backup_Button.Text = "نسخ احتياطي لقاعدة البيانات";
            this.Backup_Button.UseVisualStyleBackColor = false;
            this.Backup_Button.Click += new System.EventHandler(this.Backup_Button_Click);
            // 
            // Restore_Button
            // 
            this.Restore_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Restore_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Restore_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restore_Button.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restore_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Restore_Button.Location = new System.Drawing.Point(200, 55);
            this.Restore_Button.Name = "Restore_Button";
            this.Restore_Button.Size = new System.Drawing.Size(507, 44);
            this.Restore_Button.TabIndex = 53;
            this.Restore_Button.Text = "تطبيق نسخة احتياطية لقاعدة البيانات";
            this.Restore_Button.UseVisualStyleBackColor = false;
            this.Restore_Button.Click += new System.EventHandler(this.Restore_Button_Click);
            // 
            // HR_Tabpage
            // 
            this.HR_Tabpage.Location = new System.Drawing.Point(4, 5);
            this.HR_Tabpage.Name = "HR_Tabpage";
            this.HR_Tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.HR_Tabpage.Size = new System.Drawing.Size(1707, 900);
            this.HR_Tabpage.TabIndex = 0;
            this.HR_Tabpage.Text = "موارد بشرية";
            this.HR_Tabpage.UseVisualStyleBackColor = true;
            // 
            // Login_Tabpage
            // 
            this.Login_Tabpage.Controls.Add(this.groupBox1);
            this.Login_Tabpage.Location = new System.Drawing.Point(4, 5);
            this.Login_Tabpage.Name = "Login_Tabpage";
            this.Login_Tabpage.Size = new System.Drawing.Size(1707, 900);
            this.Login_Tabpage.TabIndex = 3;
            this.Login_Tabpage.Text = "صلاحيات المستخدمين";
            this.Login_Tabpage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.STNG_PasswordChange_Button);
            this.groupBox1.Controls.Add(this.Old_Password_Textbox);
            this.groupBox1.Controls.Add(this.ChangePassword_Label);
            this.groupBox1.Controls.Add(this.RENew_Password_Textbox);
            this.groupBox1.Controls.Add(this.New_Password_Textbox);
            this.groupBox1.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1262, 306);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "إعدادات الدخول";
            // 
            // STNG_PasswordChange_Button
            // 
            this.STNG_PasswordChange_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.STNG_PasswordChange_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.STNG_PasswordChange_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.STNG_PasswordChange_Button.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STNG_PasswordChange_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.STNG_PasswordChange_Button.Location = new System.Drawing.Point(8, 164);
            this.STNG_PasswordChange_Button.Name = "STNG_PasswordChange_Button";
            this.STNG_PasswordChange_Button.Size = new System.Drawing.Size(367, 44);
            this.STNG_PasswordChange_Button.TabIndex = 64;
            this.STNG_PasswordChange_Button.Text = "تغيير كلمة المرور";
            this.STNG_PasswordChange_Button.UseVisualStyleBackColor = false;
            // 
            // Old_Password_Textbox
            // 
            this.Old_Password_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Old_Password_Textbox.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.Old_Password_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.Old_Password_Textbox.IsPasswordTextbox = true;
            this.Old_Password_Textbox.IsPlaceholder = true;
            this.Old_Password_Textbox.Location = new System.Drawing.Point(8, 37);
            this.Old_Password_Textbox.Name = "Old_Password_Textbox";
            this.Old_Password_Textbox.Placeholder = "ادخل كلمة المرور القديمة";
            this.Old_Password_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.Old_Password_Textbox.placeholderFont = null;
            this.Old_Password_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Old_Password_Textbox.SelectedItem = null;
            this.Old_Password_Textbox.Size = new System.Drawing.Size(1241, 34);
            this.Old_Password_Textbox.TabIndex = 1;
            this.Old_Password_Textbox.Tag = "";
            this.Old_Password_Textbox.Text = "ادخل كلمة المرور القديمة";
            this.Old_Password_Textbox.Values = null;
            this.Old_Password_Textbox.Visible_Password_Button = true;
            // 
            // ChangePassword_Label
            // 
            this.ChangePassword_Label.Font = new System.Drawing.Font("El Messiri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ChangePassword_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.ChangePassword_Label.Location = new System.Drawing.Point(6, 239);
            this.ChangePassword_Label.Name = "ChangePassword_Label";
            this.ChangePassword_Label.Size = new System.Drawing.Size(1248, 60);
            this.ChangePassword_Label.TabIndex = 63;
            this.ChangePassword_Label.Text = "كلمة المرور غير مطابقة";
            this.ChangePassword_Label.Visible = false;
            // 
            // RENew_Password_Textbox
            // 
            this.RENew_Password_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RENew_Password_Textbox.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.RENew_Password_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.RENew_Password_Textbox.IsPasswordTextbox = true;
            this.RENew_Password_Textbox.IsPlaceholder = true;
            this.RENew_Password_Textbox.Location = new System.Drawing.Point(8, 123);
            this.RENew_Password_Textbox.Name = "RENew_Password_Textbox";
            this.RENew_Password_Textbox.Placeholder = "ادخل كلمة المرور الجديدة مرة أخري";
            this.RENew_Password_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.RENew_Password_Textbox.placeholderFont = null;
            this.RENew_Password_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RENew_Password_Textbox.SelectedItem = null;
            this.RENew_Password_Textbox.Size = new System.Drawing.Size(1241, 34);
            this.RENew_Password_Textbox.TabIndex = 3;
            this.RENew_Password_Textbox.Tag = "";
            this.RENew_Password_Textbox.Text = "ادخل كلمة المرور الجديدة مرة أخري";
            this.RENew_Password_Textbox.Values = null;
            this.RENew_Password_Textbox.Visible_Password_Button = true;
            // 
            // New_Password_Textbox
            // 
            this.New_Password_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.New_Password_Textbox.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.New_Password_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.New_Password_Textbox.IsPasswordTextbox = true;
            this.New_Password_Textbox.IsPlaceholder = true;
            this.New_Password_Textbox.Location = new System.Drawing.Point(8, 83);
            this.New_Password_Textbox.Name = "New_Password_Textbox";
            this.New_Password_Textbox.Placeholder = "ادخل كلمة المرور الجديدة";
            this.New_Password_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.New_Password_Textbox.placeholderFont = null;
            this.New_Password_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.New_Password_Textbox.SelectedItem = null;
            this.New_Password_Textbox.Size = new System.Drawing.Size(1242, 34);
            this.New_Password_Textbox.TabIndex = 2;
            this.New_Password_Textbox.Tag = "";
            this.New_Password_Textbox.Text = "ادخل كلمة المرور الجديدة";
            this.New_Password_Textbox.Values = null;
            this.New_Password_Textbox.Visible_Password_Button = true;
            // 
            // FNC_Tabpage
            // 
            this.FNC_Tabpage.Controls.Add(this.Wallets_Groupbox);
            this.FNC_Tabpage.Location = new System.Drawing.Point(4, 5);
            this.FNC_Tabpage.Name = "FNC_Tabpage";
            this.FNC_Tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.FNC_Tabpage.Size = new System.Drawing.Size(1707, 900);
            this.FNC_Tabpage.TabIndex = 1;
            this.FNC_Tabpage.Text = "محافظ";
            this.FNC_Tabpage.UseVisualStyleBackColor = true;
            // 
            // Wallets_Groupbox
            // 
            this.Wallets_Groupbox.Controls.Add(this.Wallet_credit_Textbox);
            this.Wallets_Groupbox.Controls.Add(this.Wallet_credit_Adj_Label);
            this.Wallets_Groupbox.Controls.Add(this.Wallet_name_Adj_Label);
            this.Wallets_Groupbox.Controls.Add(this.Modify_Wallet_Button);
            this.Wallets_Groupbox.Controls.Add(this.Del_Wallet_Button);
            this.Wallets_Groupbox.Controls.Add(this.Wallet_Label);
            this.Wallets_Groupbox.Controls.Add(this.Add_Wallet_Button);
            this.Wallets_Groupbox.Controls.Add(this.Wallet_name_Textbox);
            this.Wallets_Groupbox.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wallets_Groupbox.ForeColor = System.Drawing.Color.DarkRed;
            this.Wallets_Groupbox.Location = new System.Drawing.Point(7, 9);
            this.Wallets_Groupbox.Name = "Wallets_Groupbox";
            this.Wallets_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Wallets_Groupbox.Size = new System.Drawing.Size(1566, 256);
            this.Wallets_Groupbox.TabIndex = 2;
            this.Wallets_Groupbox.TabStop = false;
            this.Wallets_Groupbox.Tag = this.Add_Wallet_Button;
            this.Wallets_Groupbox.Text = "إضافة محافظ";
            // 
            // Wallet_credit_Textbox
            // 
            this.Wallet_credit_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Wallet_credit_Textbox.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.Wallet_credit_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.Wallet_credit_Textbox.IsPasswordTextbox = false;
            this.Wallet_credit_Textbox.IsPlaceholder = true;
            this.Wallet_credit_Textbox.Location = new System.Drawing.Point(285, 84);
            this.Wallet_credit_Textbox.Name = "Wallet_credit_Textbox";
            this.Wallet_credit_Textbox.Placeholder = "الرصيد";
            this.Wallet_credit_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.Wallet_credit_Textbox.placeholderFont = null;
            this.Wallet_credit_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Wallet_credit_Textbox.SelectedItem = null;
            this.Wallet_credit_Textbox.Size = new System.Drawing.Size(1148, 38);
            this.Wallet_credit_Textbox.TabIndex = 74;
            this.Wallet_credit_Textbox.Tag = "";
            this.Wallet_credit_Textbox.Text = "الرصيد";
            this.Wallet_credit_Textbox.Values = null;
            this.Wallet_credit_Textbox.Visible_Password_Button = false;
            this.Wallet_credit_Textbox.TextChanged += new System.EventHandler(this.TODO_id_Textbox_TextChanged);
            // 
            // Wallet_credit_Adj_Label
            // 
            this.Wallet_credit_Adj_Label.AutoSize = true;
            this.Wallet_credit_Adj_Label.Font = new System.Drawing.Font("A Nasr", 12F);
            this.Wallet_credit_Adj_Label.Location = new System.Drawing.Point(1464, 91);
            this.Wallet_credit_Adj_Label.Name = "Wallet_credit_Adj_Label";
            this.Wallet_credit_Adj_Label.Size = new System.Drawing.Size(49, 27);
            this.Wallet_credit_Adj_Label.TabIndex = 61;
            this.Wallet_credit_Adj_Label.Text = "الرصيد";
            // 
            // Wallet_name_Adj_Label
            // 
            this.Wallet_name_Adj_Label.AutoSize = true;
            this.Wallet_name_Adj_Label.Font = new System.Drawing.Font("A Nasr", 12F);
            this.Wallet_name_Adj_Label.Location = new System.Drawing.Point(1447, 39);
            this.Wallet_name_Adj_Label.Name = "Wallet_name_Adj_Label";
            this.Wallet_name_Adj_Label.Size = new System.Drawing.Size(91, 27);
            this.Wallet_name_Adj_Label.TabIndex = 60;
            this.Wallet_name_Adj_Label.Text = "اسم المحفظة";
            // 
            // Modify_Wallet_Button
            // 
            this.Modify_Wallet_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Modify_Wallet_Button.FlatAppearance.BorderSize = 0;
            this.Modify_Wallet_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modify_Wallet_Button.Font = new System.Drawing.Font("El Messiri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modify_Wallet_Button.ForeColor = System.Drawing.Color.Black;
            this.Modify_Wallet_Button.Location = new System.Drawing.Point(784, 189);
            this.Modify_Wallet_Button.Name = "Modify_Wallet_Button";
            this.Modify_Wallet_Button.Size = new System.Drawing.Size(259, 53);
            this.Modify_Wallet_Button.TabIndex = 55;
            this.Modify_Wallet_Button.Text = "تعديل محافظ";
            this.Modify_Wallet_Button.UseVisualStyleBackColor = false;
            this.Modify_Wallet_Button.Click += new System.EventHandler(this.Wallet_Button_Click);
            // 
            // Del_Wallet_Button
            // 
            this.Del_Wallet_Button.BackColor = System.Drawing.Color.DarkRed;
            this.Del_Wallet_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del_Wallet_Button.Font = new System.Drawing.Font("El Messiri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del_Wallet_Button.ForeColor = System.Drawing.Color.Black;
            this.Del_Wallet_Button.Location = new System.Drawing.Point(414, 196);
            this.Del_Wallet_Button.Name = "Del_Wallet_Button";
            this.Del_Wallet_Button.Size = new System.Drawing.Size(221, 38);
            this.Del_Wallet_Button.TabIndex = 54;
            this.Del_Wallet_Button.Text = "حذف محافظ";
            this.Del_Wallet_Button.UseVisualStyleBackColor = false;
            this.Del_Wallet_Button.Click += new System.EventHandler(this.Wallet_Button_Click);
            // 
            // Wallet_Label
            // 
            this.Wallet_Label.Font = new System.Drawing.Font("El Messiri", 11.8F);
            this.Wallet_Label.Location = new System.Drawing.Point(28, 143);
            this.Wallet_Label.Name = "Wallet_Label";
            this.Wallet_Label.Size = new System.Drawing.Size(1515, 41);
            this.Wallet_Label.TabIndex = 41;
            this.Wallet_Label.Text = "اختر نوع الصيانة";
            this.Wallet_Label.Visible = false;
            // 
            // Add_Wallet_Button
            // 
            this.Add_Wallet_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Add_Wallet_Button.FlatAppearance.BorderSize = 0;
            this.Add_Wallet_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Wallet_Button.Font = new System.Drawing.Font("El Messiri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Wallet_Button.ForeColor = System.Drawing.Color.Black;
            this.Add_Wallet_Button.Location = new System.Drawing.Point(28, 189);
            this.Add_Wallet_Button.Name = "Add_Wallet_Button";
            this.Add_Wallet_Button.Size = new System.Drawing.Size(259, 53);
            this.Add_Wallet_Button.TabIndex = 35;
            this.Add_Wallet_Button.Text = "إضافة محافظ";
            this.Add_Wallet_Button.UseVisualStyleBackColor = false;
            this.Add_Wallet_Button.Click += new System.EventHandler(this.Wallet_Button_Click);
            // 
            // Wallet_name_Textbox
            // 
            this.Wallet_name_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Wallet_name_Textbox.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.Wallet_name_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.Wallet_name_Textbox.IsPasswordTextbox = false;
            this.Wallet_name_Textbox.IsPlaceholder = true;
            this.Wallet_name_Textbox.Location = new System.Drawing.Point(285, 32);
            this.Wallet_name_Textbox.Name = "Wallet_name_Textbox";
            this.Wallet_name_Textbox.Placeholder = "اسم المحفظة";
            this.Wallet_name_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.Wallet_name_Textbox.placeholderFont = null;
            this.Wallet_name_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Wallet_name_Textbox.SelectedItem = null;
            this.Wallet_name_Textbox.Size = new System.Drawing.Size(1148, 38);
            this.Wallet_name_Textbox.TabIndex = 1;
            this.Wallet_name_Textbox.Tag = "";
            this.Wallet_name_Textbox.Text = "اسم المحفظة";
            this.Wallet_name_Textbox.Values = null;
            this.Wallet_name_Textbox.Visible_Password_Button = false;
            this.Wallet_name_Textbox.SelectedItemChanged += new System.EventHandler<System.EventArgs>(this.Wallet_name_Textbox_SelectedItemChanged);
            // 
            // TileButtons_Panel
            // 
            this.TileButtons_Panel.Controls.Add(this.SidePanel1);
            this.TileButtons_Panel.Controls.Add(this.General_TileButton);
            this.TileButtons_Panel.Controls.Add(this.LoginTilebutton);
            this.TileButtons_Panel.Controls.Add(this.Finances_TileButton);
            this.TileButtons_Panel.Controls.Add(this.HR_TileButton);
            this.TileButtons_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TileButtons_Panel.Location = new System.Drawing.Point(0, 0);
            this.TileButtons_Panel.Name = "TileButtons_Panel";
            this.TileButtons_Panel.Size = new System.Drawing.Size(146, 950);
            this.TileButtons_Panel.TabIndex = 62;
            // 
            // SidePanel1
            // 
            this.SidePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.SidePanel1.Location = new System.Drawing.Point(0, 0);
            this.SidePanel1.Name = "SidePanel1";
            this.SidePanel1.Size = new System.Drawing.Size(12, 237);
            this.SidePanel1.TabIndex = 46;
            // 
            // General_TileButton
            // 
            this.General_TileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.General_TileButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.General_TileButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.General_TileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.General_TileButton.Font = new System.Drawing.Font("A Nasr", 15F);
            this.General_TileButton.ForeColor = System.Drawing.Color.Black;
            this.General_TileButton.Image = null;
            this.General_TileButton.ImagePosition = 0;
            this.General_TileButton.ImageZoom = 0;
            this.General_TileButton.LabelPosition = 135;
            this.General_TileButton.LabelText = "إعدادات عامة";
            this.General_TileButton.Location = new System.Drawing.Point(0, 0);
            this.General_TileButton.Margin = new System.Windows.Forms.Padding(49, 57, 49, 57);
            this.General_TileButton.Name = "General_TileButton";
            this.General_TileButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.General_TileButton.Size = new System.Drawing.Size(146, 238);
            this.General_TileButton.TabIndex = 47;
            this.General_TileButton.Tag = this.General_Tabpage;
            this.General_TileButton.Click += new System.EventHandler(this.TileButtons_Click);
            // 
            // LoginTilebutton
            // 
            this.LoginTilebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.LoginTilebutton.color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.LoginTilebutton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.LoginTilebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginTilebutton.Font = new System.Drawing.Font("A Nasr", 18.5F);
            this.LoginTilebutton.ForeColor = System.Drawing.Color.Black;
            this.LoginTilebutton.Image = null;
            this.LoginTilebutton.ImagePosition = 0;
            this.LoginTilebutton.ImageZoom = 0;
            this.LoginTilebutton.LabelPosition = 135;
            this.LoginTilebutton.LabelText = "إعدادات الدخول";
            this.LoginTilebutton.Location = new System.Drawing.Point(0, 238);
            this.LoginTilebutton.Margin = new System.Windows.Forms.Padding(8);
            this.LoginTilebutton.Name = "LoginTilebutton";
            this.LoginTilebutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoginTilebutton.Size = new System.Drawing.Size(146, 238);
            this.LoginTilebutton.TabIndex = 49;
            this.LoginTilebutton.Tag = this.Login_Tabpage;
            this.LoginTilebutton.Click += new System.EventHandler(this.TileButtons_Click);
            // 
            // Finances_TileButton
            // 
            this.Finances_TileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Finances_TileButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Finances_TileButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.Finances_TileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Finances_TileButton.Font = new System.Drawing.Font("A Nasr", 20F);
            this.Finances_TileButton.ForeColor = System.Drawing.Color.Black;
            this.Finances_TileButton.Image = null;
            this.Finances_TileButton.ImagePosition = 0;
            this.Finances_TileButton.ImageZoom = 0;
            this.Finances_TileButton.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Finances_TileButton.LabelPosition = 135;
            this.Finances_TileButton.LabelText = "محافظ";
            this.Finances_TileButton.Location = new System.Drawing.Point(0, 474);
            this.Finances_TileButton.Margin = new System.Windows.Forms.Padding(6);
            this.Finances_TileButton.Name = "Finances_TileButton";
            this.Finances_TileButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Finances_TileButton.Size = new System.Drawing.Size(146, 237);
            this.Finances_TileButton.TabIndex = 48;
            this.Finances_TileButton.Tag = this.FNC_Tabpage;
            this.Finances_TileButton.Click += new System.EventHandler(this.TileButtons_Click);
            // 
            // HR_TileButton
            // 
            this.HR_TileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.HR_TileButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.HR_TileButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.HR_TileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HR_TileButton.Font = new System.Drawing.Font("A Nasr", 15F);
            this.HR_TileButton.ForeColor = System.Drawing.Color.Black;
            this.HR_TileButton.Image = null;
            this.HR_TileButton.ImagePosition = 0;
            this.HR_TileButton.ImageZoom = 0;
            this.HR_TileButton.LabelPosition = 135;
            this.HR_TileButton.LabelText = "موارد بشرية";
            this.HR_TileButton.Location = new System.Drawing.Point(0, 713);
            this.HR_TileButton.Margin = new System.Windows.Forms.Padding(5);
            this.HR_TileButton.Name = "HR_TileButton";
            this.HR_TileButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HR_TileButton.Size = new System.Drawing.Size(146, 237);
            this.HR_TileButton.TabIndex = 45;
            this.HR_TileButton.Tag = this.HR_Tabpage;
            this.HR_TileButton.Visible = false;
            this.HR_TileButton.Click += new System.EventHandler(this.TileButtons_Click);
            // 
            // UsrCtrl_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TileButtons_Panel);
            this.Controls.Add(this.Settings_Tabcontnol);
            this.Name = "UsrCtrl_Settings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1926, 950);
            this.GeneralSettings_Groupbox.ResumeLayout(false);
            this.GeneralSettings_Groupbox.PerformLayout();
            this.Settings_Tabcontnol.ResumeLayout(false);
            this.General_Tabpage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.Login_Tabpage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.FNC_Tabpage.ResumeLayout(false);
            this.Wallets_Groupbox.ResumeLayout(false);
            this.Wallets_Groupbox.PerformLayout();
            this.TileButtons_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

         }

        #endregion
        private System.Windows.Forms.GroupBox GeneralSettings_Groupbox;
        private System.Windows.Forms.Label Settings_Label;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Button PickColor_Button;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private TransparentTabControl Settings_Tabcontnol;
        private System.Windows.Forms.TabPage HR_Tabpage;
        private System.Windows.Forms.TabPage FNC_Tabpage;
        private System.Windows.Forms.TabPage General_Tabpage;
        private System.Windows.Forms.TabPage Login_Tabpage;
        private System.Windows.Forms.Panel TileButtons_Panel;
        private ns1.BunifuTileButton LoginTilebutton;
        private ns1.BunifuTileButton Finances_TileButton;
        private ns1.BunifuTileButton General_TileButton;
        private System.Windows.Forms.Panel SidePanel1;
        private ns1.BunifuTileButton HR_TileButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Backup_Button;
        private System.Windows.Forms.Button Restore_Button;
        private System.Windows.Forms.Label Restore_Label;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private ModdedTextBox moddedTextBox1;
        private ModdedTextBox moddedTextBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button STNG_PasswordChange_Button;
        private ModdedTextBox Old_Password_Textbox;
        private System.Windows.Forms.Label ChangePassword_Label;
        private ModdedTextBox RENew_Password_Textbox;
        private ModdedTextBox New_Password_Textbox;
        private System.Windows.Forms.GroupBox Wallets_Groupbox;
        private ModdedTextBox Wallet_credit_Textbox;
        private System.Windows.Forms.Label Wallet_credit_Adj_Label;
        private System.Windows.Forms.Label Wallet_name_Adj_Label;
        private System.Windows.Forms.Button Modify_Wallet_Button;
        private System.Windows.Forms.Button Del_Wallet_Button;
        private System.Windows.Forms.Label Wallet_Label;
        private System.Windows.Forms.Button Add_Wallet_Button;
        private ModdedTextBox Wallet_name_Textbox;
    }
}
