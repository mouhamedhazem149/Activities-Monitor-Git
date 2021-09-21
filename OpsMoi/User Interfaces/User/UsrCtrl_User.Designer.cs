namespace OpsMoi.User_Interfaces
{
    partial class UsrCtrl_User
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
        private void InitializeComponent()
        {
            this.bunifuImageButton7 = new ns1.BunifuImageButton();
            this.Change_Password_Button = new System.Windows.Forms.Button();
            this.User_Category_Label = new System.Windows.Forms.Label();
            this.UserBranch_Label = new System.Windows.Forms.Label();
            this.UserName_Label = new System.Windows.Forms.Label();
            this.UnMatchedPassword_Label = new System.Windows.Forms.Label();
            this.textboxes_Panel = new System.Windows.Forms.Panel();
            this.Old_Password_Textbox = new ModdedControls.ModdedTextBox();
            this.New_Password_Textbox = new ModdedControls.ModdedTextBox();
            this.RENew_Password_Textbox = new ModdedControls.ModdedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).BeginInit();
            this.textboxes_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuImageButton7
            // 
            this.bunifuImageButton7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton7.Image = global::OpsMoi.Properties.Resources.logout;
            this.bunifuImageButton7.ImageActive = null;
            this.bunifuImageButton7.Location = new System.Drawing.Point(6, 7);
            this.bunifuImageButton7.Name = "bunifuImageButton7";
            this.bunifuImageButton7.Size = new System.Drawing.Size(50, 50);
            this.bunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton7.TabIndex = 60;
            this.bunifuImageButton7.TabStop = false;
            this.bunifuImageButton7.Zoom = 10;
            this.bunifuImageButton7.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // Change_Password_Button
            // 
            this.Change_Password_Button.BackColor = System.Drawing.Color.DarkRed;
            this.Change_Password_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Change_Password_Button.FlatAppearance.BorderSize = 0;
            this.Change_Password_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change_Password_Button.Font = new System.Drawing.Font("El Messiri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_Password_Button.ForeColor = System.Drawing.Color.Black;
            this.Change_Password_Button.Location = new System.Drawing.Point(5, 181);
            this.Change_Password_Button.Name = "Change_Password_Button";
            this.Change_Password_Button.Size = new System.Drawing.Size(138, 45);
            this.Change_Password_Button.TabIndex = 4;
            this.Change_Password_Button.Text = "تغيير كلمة المرور";
            this.Change_Password_Button.UseVisualStyleBackColor = false;
            this.Change_Password_Button.Click += new System.EventHandler(this.Change_Password_Button_Click);
            this.Change_Password_Button.Leave += new System.EventHandler(this.UsrCtrl_User_Leave);
            // 
            // User_Category_Label
            // 
            this.User_Category_Label.AutoSize = true;
            this.User_Category_Label.Font = new System.Drawing.Font("El Messiri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Category_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.User_Category_Label.Location = new System.Drawing.Point(63, 6);
            this.User_Category_Label.Name = "User_Category_Label";
            this.User_Category_Label.Size = new System.Drawing.Size(170, 31);
            this.User_Category_Label.TabIndex = 52;
            this.User_Category_Label.Text = "صلاحيات المستخدم";
            this.User_Category_Label.Leave += new System.EventHandler(this.UsrCtrl_User_Leave);
            // 
            // UserBranch_Label
            // 
            this.UserBranch_Label.AutoSize = true;
            this.UserBranch_Label.Font = new System.Drawing.Font("Alameen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UserBranch_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.UserBranch_Label.Location = new System.Drawing.Point(200, 40);
            this.UserBranch_Label.Name = "UserBranch_Label";
            this.UserBranch_Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UserBranch_Label.Size = new System.Drawing.Size(199, 22);
            this.UserBranch_Label.TabIndex = 51;
            this.UserBranch_Label.Text = "دمياط القديمة - الأعصر الأولي";
            this.UserBranch_Label.Leave += new System.EventHandler(this.UsrCtrl_User_Leave);
            // 
            // UserName_Label
            // 
            this.UserName_Label.AutoSize = true;
            this.UserName_Label.Font = new System.Drawing.Font("El Messiri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_Label.Location = new System.Drawing.Point(241, 7);
            this.UserName_Label.Name = "UserName_Label";
            this.UserName_Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UserName_Label.Size = new System.Drawing.Size(158, 31);
            this.UserName_Label.TabIndex = 50;
            this.UserName_Label.Text = "محمد حازم حلمي  ";
            this.UserName_Label.Leave += new System.EventHandler(this.UsrCtrl_User_Leave);
            // 
            // UnMatchedPassword_Label
            // 
            this.UnMatchedPassword_Label.AutoSize = true;
            this.UnMatchedPassword_Label.Font = new System.Drawing.Font("El Messiri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UnMatchedPassword_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.UnMatchedPassword_Label.Location = new System.Drawing.Point(191, 183);
            this.UnMatchedPassword_Label.Name = "UnMatchedPassword_Label";
            this.UnMatchedPassword_Label.Size = new System.Drawing.Size(206, 31);
            this.UnMatchedPassword_Label.TabIndex = 61;
            this.UnMatchedPassword_Label.Text = "كلمة المرور غير مطابقة";
            this.UnMatchedPassword_Label.Visible = false;
            this.UnMatchedPassword_Label.Leave += new System.EventHandler(this.UsrCtrl_User_Leave);
            // 
            // textboxes_Panel
            // 
            this.textboxes_Panel.Controls.Add(this.Old_Password_Textbox);
            this.textboxes_Panel.Controls.Add(this.New_Password_Textbox);
            this.textboxes_Panel.Controls.Add(this.RENew_Password_Textbox);
            this.textboxes_Panel.Location = new System.Drawing.Point(4, 65);
            this.textboxes_Panel.Name = "textboxes_Panel";
            this.textboxes_Panel.Size = new System.Drawing.Size(398, 115);
            this.textboxes_Panel.TabIndex = 62;
            this.textboxes_Panel.Leave += new System.EventHandler(this.UsrCtrl_User_Leave);
            // 
            // Old_Password_Textbox
            // 
            this.Old_Password_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Old_Password_Textbox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Old_Password_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.Old_Password_Textbox.IsPasswordTextbox = true;
            this.Old_Password_Textbox.IsPlaceholder = true;
            this.Old_Password_Textbox.Location = new System.Drawing.Point(4, 9);
            this.Old_Password_Textbox.Name = "Old_Password_Textbox";
            this.Old_Password_Textbox.Placeholder = "ادخل كلمة المرور القديمة";
            this.Old_Password_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.Old_Password_Textbox.placeholderFont = null;
            this.Old_Password_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Old_Password_Textbox.SelectedItem = null;
            this.Old_Password_Textbox.Size = new System.Drawing.Size(388, 28);
            this.Old_Password_Textbox.TabIndex = 1;
            this.Old_Password_Textbox.Tag = "";
            this.Old_Password_Textbox.Text = "ادخل كلمة المرور القديمة";
            this.Old_Password_Textbox.Values = null;
            this.Old_Password_Textbox.Visible_Password_Button = true;
            this.Old_Password_Textbox.Leave += new System.EventHandler(this.UsrCtrl_User_Leave);
            // 
            // New_Password_Textbox
            // 
            this.New_Password_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.New_Password_Textbox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Password_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.New_Password_Textbox.IsPasswordTextbox = true;
            this.New_Password_Textbox.IsPlaceholder = true;
            this.New_Password_Textbox.Location = new System.Drawing.Point(4, 45);
            this.New_Password_Textbox.Name = "New_Password_Textbox";
            this.New_Password_Textbox.Placeholder = "ادخل كلمة المرور الجديدة";
            this.New_Password_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.New_Password_Textbox.placeholderFont = null;
            this.New_Password_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.New_Password_Textbox.SelectedItem = null;
            this.New_Password_Textbox.Size = new System.Drawing.Size(389, 28);
            this.New_Password_Textbox.TabIndex = 2;
            this.New_Password_Textbox.Tag = "";
            this.New_Password_Textbox.Text = "ادخل كلمة المرور الجديدة";
            this.New_Password_Textbox.Values = null;
            this.New_Password_Textbox.Visible_Password_Button = true;
            this.New_Password_Textbox.TextChanged += new System.EventHandler(this.RENew_Password_Textbox_TextChanged);
            this.New_Password_Textbox.Leave += new System.EventHandler(this.UsrCtrl_User_Leave);
            // 
            // RENew_Password_Textbox
            // 
            this.RENew_Password_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RENew_Password_Textbox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RENew_Password_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.RENew_Password_Textbox.IsPasswordTextbox = true;
            this.RENew_Password_Textbox.IsPlaceholder = true;
            this.RENew_Password_Textbox.Location = new System.Drawing.Point(4, 76);
            this.RENew_Password_Textbox.Name = "RENew_Password_Textbox";
            this.RENew_Password_Textbox.Placeholder = "ادخل كلمة المرور الجديدة مرة أخري";
            this.RENew_Password_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.RENew_Password_Textbox.placeholderFont = null;
            this.RENew_Password_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RENew_Password_Textbox.SelectedItem = null;
            this.RENew_Password_Textbox.Size = new System.Drawing.Size(388, 28);
            this.RENew_Password_Textbox.TabIndex = 3;
            this.RENew_Password_Textbox.Tag = "";
            this.RENew_Password_Textbox.Text = "ادخل كلمة المرور الجديدة مرة أخري";
            this.RENew_Password_Textbox.Values = null;
            this.RENew_Password_Textbox.Visible_Password_Button = true;
            this.RENew_Password_Textbox.TextChanged += new System.EventHandler(this.RENew_Password_Textbox_TextChanged);
            this.RENew_Password_Textbox.Leave += new System.EventHandler(this.UsrCtrl_User_Leave);
            // 
            // UsrCtrl_User
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.Controls.Add(this.textboxes_Panel);
            this.Controls.Add(this.UnMatchedPassword_Label);
            this.Controls.Add(this.bunifuImageButton7);
            this.Controls.Add(this.Change_Password_Button);
            this.Controls.Add(this.User_Category_Label);
            this.Controls.Add(this.UserBranch_Label);
            this.Controls.Add(this.UserName_Label);
            this.Name = "UsrCtrl_User";
            this.Size = new System.Drawing.Size(405, 234);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsrCtrl_User_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).EndInit();
            this.textboxes_Panel.ResumeLayout(false);
            this.textboxes_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuImageButton bunifuImageButton7;
        private System.Windows.Forms.Button Change_Password_Button;
        private System.Windows.Forms.Label User_Category_Label;
        private System.Windows.Forms.Label UserBranch_Label;
        private System.Windows.Forms.Label UserName_Label;
        private System.Windows.Forms.Label UnMatchedPassword_Label;
        private ModdedControls.ModdedTextBox RENew_Password_Textbox;
        private ModdedControls.ModdedTextBox New_Password_Textbox;
        private ModdedControls.ModdedTextBox Old_Password_Textbox;
        private System.Windows.Forms.Panel textboxes_Panel;
    }
}
