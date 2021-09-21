namespace OpsMoi
{
    partial class FirstTime
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstTime));
            this.owner_Groupbox = new System.Windows.Forms.GroupBox();
            this.companywebpage_Textbox = new ModdedControls.ModdedTextBox();
            this.name_Textbox = new ModdedControls.ModdedTextBox();
            this.address_Textbox = new ModdedControls.ModdedTextBox();
            this.phonenumber_Textbox = new ModdedControls.ModdedTextBox();
            this.email_Textbox = new ModdedControls.ModdedTextBox();
            this.serial_Textbox = new ModdedControls.ModdedTextBox();
            this.user_Groupbox = new System.Windows.Forms.GroupBox();
            this.unmatched_Label = new System.Windows.Forms.Label();
            this.password_Textbox = new ModdedControls.ModdedTextBox();
            this.repassword_Textbox = new ModdedControls.ModdedTextBox();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Msg_Label = new System.Windows.Forms.Label();
            this.Ignitation_Progrssbar = new System.Windows.Forms.ProgressBar();
            this.owner_Groupbox.SuspendLayout();
            this.user_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // owner_Groupbox
            // 
            this.owner_Groupbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.owner_Groupbox.BackColor = System.Drawing.Color.Transparent;
            this.owner_Groupbox.Controls.Add(this.companywebpage_Textbox);
            this.owner_Groupbox.Controls.Add(this.name_Textbox);
            this.owner_Groupbox.Controls.Add(this.address_Textbox);
            this.owner_Groupbox.Controls.Add(this.phonenumber_Textbox);
            this.owner_Groupbox.Controls.Add(this.email_Textbox);
            this.owner_Groupbox.Controls.Add(this.serial_Textbox);
            this.owner_Groupbox.Font = new System.Drawing.Font("El Messiri SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owner_Groupbox.ForeColor = System.Drawing.Color.DarkRed;
            this.owner_Groupbox.Location = new System.Drawing.Point(586, 6);
            this.owner_Groupbox.Name = "owner_Groupbox";
            this.owner_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.owner_Groupbox.Size = new System.Drawing.Size(810, 402);
            this.owner_Groupbox.TabIndex = 100;
            this.owner_Groupbox.TabStop = false;
            this.owner_Groupbox.Text = "تسجيل البرنامج";
            // 
            // companywebpage_Textbox
            // 
            this.companywebpage_Textbox.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companywebpage_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.companywebpage_Textbox.IsPasswordTextbox = false;
            this.companywebpage_Textbox.IsPlaceholder = true;
            this.companywebpage_Textbox.Location = new System.Drawing.Point(17, 340);
            this.companywebpage_Textbox.Name = "companywebpage_Textbox";
            this.companywebpage_Textbox.Placeholder = "الموقع الإلكتروني";
            this.companywebpage_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.companywebpage_Textbox.placeholderFont = null;
            this.companywebpage_Textbox.SelectedItem = null;
            this.companywebpage_Textbox.Size = new System.Drawing.Size(780, 45);
            this.companywebpage_Textbox.TabIndex = 7;
            this.companywebpage_Textbox.Text = "الموقع الإلكتروني";
            this.companywebpage_Textbox.Values = null;
            this.companywebpage_Textbox.Visible_Password_Button = false;
            // 
            // name_Textbox
            // 
            this.name_Textbox.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.name_Textbox.IsPasswordTextbox = false;
            this.name_Textbox.IsPlaceholder = true;
            this.name_Textbox.Location = new System.Drawing.Point(17, 46);
            this.name_Textbox.Name = "name_Textbox";
            this.name_Textbox.Placeholder = "الاسم";
            this.name_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.name_Textbox.placeholderFont = null;
            this.name_Textbox.SelectedItem = null;
            this.name_Textbox.Size = new System.Drawing.Size(780, 45);
            this.name_Textbox.TabIndex = 1;
            this.name_Textbox.Text = "الاسم";
            this.name_Textbox.Values = null;
            this.name_Textbox.Visible_Password_Button = false;
            // 
            // address_Textbox
            // 
            this.address_Textbox.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.address_Textbox.IsPasswordTextbox = false;
            this.address_Textbox.IsPlaceholder = true;
            this.address_Textbox.Location = new System.Drawing.Point(17, 104);
            this.address_Textbox.Name = "address_Textbox";
            this.address_Textbox.Placeholder = "العنوان";
            this.address_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.address_Textbox.placeholderFont = null;
            this.address_Textbox.SelectedItem = null;
            this.address_Textbox.Size = new System.Drawing.Size(780, 45);
            this.address_Textbox.TabIndex = 2;
            this.address_Textbox.Text = "العنوان";
            this.address_Textbox.Values = null;
            this.address_Textbox.Visible_Password_Button = false;
            // 
            // phonenumber_Textbox
            // 
            this.phonenumber_Textbox.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumber_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.phonenumber_Textbox.IsPasswordTextbox = false;
            this.phonenumber_Textbox.IsPlaceholder = true;
            this.phonenumber_Textbox.Location = new System.Drawing.Point(17, 161);
            this.phonenumber_Textbox.Name = "phonenumber_Textbox";
            this.phonenumber_Textbox.Placeholder = "رقم الموبايل";
            this.phonenumber_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.phonenumber_Textbox.placeholderFont = null;
            this.phonenumber_Textbox.SelectedItem = null;
            this.phonenumber_Textbox.Size = new System.Drawing.Size(780, 45);
            this.phonenumber_Textbox.TabIndex = 3;
            this.phonenumber_Textbox.Text = "رقم الموبايل";
            this.phonenumber_Textbox.Values = null;
            this.phonenumber_Textbox.Visible_Password_Button = false;
            // 
            // email_Textbox
            // 
            this.email_Textbox.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.email_Textbox.IsPasswordTextbox = false;
            this.email_Textbox.IsPlaceholder = true;
            this.email_Textbox.Location = new System.Drawing.Point(17, 218);
            this.email_Textbox.Name = "email_Textbox";
            this.email_Textbox.Placeholder = "البريد الألكتروني";
            this.email_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.email_Textbox.placeholderFont = null;
            this.email_Textbox.SelectedItem = null;
            this.email_Textbox.Size = new System.Drawing.Size(780, 45);
            this.email_Textbox.TabIndex = 4;
            this.email_Textbox.Text = "البريد الألكتروني";
            this.email_Textbox.Values = null;
            this.email_Textbox.Visible_Password_Button = false;
            // 
            // serial_Textbox
            // 
            this.serial_Textbox.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serial_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.serial_Textbox.IsPasswordTextbox = false;
            this.serial_Textbox.IsPlaceholder = true;
            this.serial_Textbox.Location = new System.Drawing.Point(17, 275);
            this.serial_Textbox.Name = "serial_Textbox";
            this.serial_Textbox.Placeholder = "السيريال الخاص بالبرنامج";
            this.serial_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.serial_Textbox.placeholderFont = null;
            this.serial_Textbox.SelectedItem = null;
            this.serial_Textbox.Size = new System.Drawing.Size(780, 45);
            this.serial_Textbox.TabIndex = 5;
            this.serial_Textbox.Text = "السيريال الخاص بالبرنامج";
            this.serial_Textbox.Values = null;
            this.serial_Textbox.Visible_Password_Button = false;
            this.serial_Textbox.Leave += new System.EventHandler(this.serial_Textbox_Leave);
            // 
            // user_Groupbox
            // 
            this.user_Groupbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.user_Groupbox.BackColor = System.Drawing.Color.Transparent;
            this.user_Groupbox.Controls.Add(this.unmatched_Label);
            this.user_Groupbox.Controls.Add(this.password_Textbox);
            this.user_Groupbox.Controls.Add(this.repassword_Textbox);
            this.user_Groupbox.Font = new System.Drawing.Font("El Messiri SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_Groupbox.ForeColor = System.Drawing.Color.DarkRed;
            this.user_Groupbox.Location = new System.Drawing.Point(5, 6);
            this.user_Groupbox.Name = "user_Groupbox";
            this.user_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.user_Groupbox.Size = new System.Drawing.Size(575, 194);
            this.user_Groupbox.TabIndex = 200;
            this.user_Groupbox.TabStop = false;
            this.user_Groupbox.Text = "تسجيل المستخدم";
            // 
            // unmatched_Label
            // 
            this.unmatched_Label.BackColor = System.Drawing.Color.Transparent;
            this.unmatched_Label.Font = new System.Drawing.Font("El Messiri", 11.8F);
            this.unmatched_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.unmatched_Label.Location = new System.Drawing.Point(7, 150);
            this.unmatched_Label.Name = "unmatched_Label";
            this.unmatched_Label.Size = new System.Drawing.Size(557, 31);
            this.unmatched_Label.TabIndex = 44;
            this.unmatched_Label.Text = "كلمة المرور غير متطابقة";
            this.unmatched_Label.Visible = false;
            // 
            // password_Textbox
            // 
            this.password_Textbox.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.password_Textbox.IsPasswordTextbox = true;
            this.password_Textbox.IsPlaceholder = true;
            this.password_Textbox.Location = new System.Drawing.Point(7, 46);
            this.password_Textbox.Name = "password_Textbox";
            this.password_Textbox.Placeholder = "كلمة المرور العامة";
            this.password_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.password_Textbox.placeholderFont = null;
            this.password_Textbox.SelectedItem = null;
            this.password_Textbox.Size = new System.Drawing.Size(562, 45);
            this.password_Textbox.TabIndex = 7;
            this.password_Textbox.Text = "كلمة المرور العامة";
            this.password_Textbox.Values = null;
            this.password_Textbox.Visible_Password_Button = true;
            // 
            // repassword_Textbox
            // 
            this.repassword_Textbox.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repassword_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.repassword_Textbox.IsPasswordTextbox = true;
            this.repassword_Textbox.IsPlaceholder = true;
            this.repassword_Textbox.Location = new System.Drawing.Point(7, 101);
            this.repassword_Textbox.Name = "repassword_Textbox";
            this.repassword_Textbox.Placeholder = "تأكيد كلمة المرور";
            this.repassword_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.repassword_Textbox.placeholderFont = null;
            this.repassword_Textbox.SelectedItem = null;
            this.repassword_Textbox.Size = new System.Drawing.Size(562, 45);
            this.repassword_Textbox.TabIndex = 8;
            this.repassword_Textbox.Text = "تأكيد كلمة المرور";
            this.repassword_Textbox.Values = null;
            this.repassword_Textbox.Visible_Password_Button = true;
            this.repassword_Textbox.TextChanged += new System.EventHandler(this.repassword_Textbox_TextChanged);
            this.repassword_Textbox.Leave += new System.EventHandler(this.repassword_Textbox_Leave);
            // 
            // Start_Button
            // 
            this.Start_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Start_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Start_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_Button.Font = new System.Drawing.Font("El Messiri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Button.ForeColor = System.Drawing.Color.Black;
            this.Start_Button.Location = new System.Drawing.Point(103, 484);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(279, 60);
            this.Start_Button.TabIndex = 14;
            this.Start_Button.Text = "ابـــــــدأ";
            this.Start_Button.UseVisualStyleBackColor = false;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Msg_Label
            // 
            this.Msg_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Msg_Label.BackColor = System.Drawing.Color.Transparent;
            this.Msg_Label.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msg_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.Msg_Label.Location = new System.Drawing.Point(443, 459);
            this.Msg_Label.Name = "Msg_Label";
            this.Msg_Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Msg_Label.Size = new System.Drawing.Size(867, 35);
            this.Msg_Label.TabIndex = 20;
            this.Msg_Label.Text = "Msg_Label";
            this.Msg_Label.Visible = false;
            // 
            // Ignitation_Progrssbar
            // 
            this.Ignitation_Progrssbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ignitation_Progrssbar.Location = new System.Drawing.Point(658, 498);
            this.Ignitation_Progrssbar.Name = "Ignitation_Progrssbar";
            this.Ignitation_Progrssbar.Size = new System.Drawing.Size(645, 23);
            this.Ignitation_Progrssbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Ignitation_Progrssbar.TabIndex = 14;
            this.Ignitation_Progrssbar.Visible = false;
            // 
            // FirstTime
            // 
            this.AcceptButton = this.Start_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1401, 556);
            this.Controls.Add(this.Ignitation_Progrssbar);
            this.Controls.Add(this.Msg_Label);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.user_Groupbox);
            this.Controls.Add(this.owner_Groupbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1109, 603);
            this.Name = "FirstTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التسجيل لأول مرة";
            this.owner_Groupbox.ResumeLayout(false);
            this.owner_Groupbox.PerformLayout();
            this.user_Groupbox.ResumeLayout(false);
            this.user_Groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ModdedControls.ModdedTextBox name_Textbox;
        private ModdedControls.ModdedTextBox address_Textbox;
        private ModdedControls.ModdedTextBox phonenumber_Textbox;
        private ModdedControls.ModdedTextBox email_Textbox;
        private ModdedControls.ModdedTextBox serial_Textbox;
        private ModdedControls.ModdedTextBox password_Textbox;
        private ModdedControls.ModdedTextBox repassword_Textbox;
        private System.Windows.Forms.GroupBox owner_Groupbox;
        private System.Windows.Forms.GroupBox user_Groupbox;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Label Msg_Label;
        private System.Windows.Forms.Label unmatched_Label;
        private System.Windows.Forms.ProgressBar Ignitation_Progrssbar;
        private ModdedControls.ModdedTextBox companywebpage_Textbox;
    }
}