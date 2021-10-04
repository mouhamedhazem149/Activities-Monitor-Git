using ModdedControls;

namespace OpsMoi.User_Interfaces
{
    partial class UsrCtrl_Notes
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
            this.storage_Tabcontrol = new TransparentTabControl();
            this.add_Tabpage = new System.Windows.Forms.TabPage();
            this.Note_Groupbox = new System.Windows.Forms.GroupBox();
            this.Decrypt_Button = new System.Windows.Forms.Button();
            this.Encrypt_Button = new System.Windows.Forms.Button();
            this.Not_Label = new System.Windows.Forms.Label();
            this.NOT_title_Adj_Label = new System.Windows.Forms.Label();
            this.WH_c_price_Adj_Label = new System.Windows.Forms.Label();
            this.Modify_NOT_Button = new System.Windows.Forms.Button();
            this.Del_NOT_Button = new System.Windows.Forms.Button();
            this.Add_NOT_Button = new System.Windows.Forms.Button();
            this.NOT_strNote_Textbox = new ModdedControls.ModdedTextBox();
            this.NOT_title_Textbox = new ModdedControls.ModdedTextBox();
            this.available_Tabpage = new System.Windows.Forms.TabPage();
            this.prices_Tabpage = new System.Windows.Forms.TabPage();
            this.TileButtons_Panel = new System.Windows.Forms.Panel();
            this.WH_Search_TileButton = new ns1.BunifuTileButton();
            this.WH_pricelist_TileButton = new ns1.BunifuTileButton();
            this.SidePanel1 = new System.Windows.Forms.Panel();
            this.NotesManager_TileButton = new ns1.BunifuTileButton();
            this.storage_Tabcontrol.SuspendLayout();
            this.add_Tabpage.SuspendLayout();
            this.Note_Groupbox.SuspendLayout();
            this.TileButtons_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // storage_Tabcontrol
            // 
            this.storage_Tabcontrol.Controls.Add(this.add_Tabpage);
            this.storage_Tabcontrol.Controls.Add(this.available_Tabpage);
            this.storage_Tabcontrol.Controls.Add(this.prices_Tabpage);
            this.storage_Tabcontrol.ItemSize = new System.Drawing.Size(0, 1);
            this.storage_Tabcontrol.Location = new System.Drawing.Point(195, 3);
            this.storage_Tabcontrol.Multiline = true;
            this.storage_Tabcontrol.Name = "storage_Tabcontrol";
            this.storage_Tabcontrol.SelectedIndex = 0;
            this.storage_Tabcontrol.Size = new System.Drawing.Size(1572, 915);
            this.storage_Tabcontrol.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.storage_Tabcontrol.TabIndex = 4;
            // 
            // add_Tabpage
            // 
            this.add_Tabpage.Controls.Add(this.Note_Groupbox);
            this.add_Tabpage.Location = new System.Drawing.Point(4, 5);
            this.add_Tabpage.Name = "add_Tabpage";
            this.add_Tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.add_Tabpage.Size = new System.Drawing.Size(1564, 906);
            this.add_Tabpage.TabIndex = 0;
            this.add_Tabpage.Text = "إضافة / تعديل الأجهزة";
            this.add_Tabpage.UseVisualStyleBackColor = true;
            // 
            // Note_Groupbox
            // 
            this.Note_Groupbox.Controls.Add(this.Decrypt_Button);
            this.Note_Groupbox.Controls.Add(this.Encrypt_Button);
            this.Note_Groupbox.Controls.Add(this.Not_Label);
            this.Note_Groupbox.Controls.Add(this.NOT_title_Adj_Label);
            this.Note_Groupbox.Controls.Add(this.WH_c_price_Adj_Label);
            this.Note_Groupbox.Controls.Add(this.Modify_NOT_Button);
            this.Note_Groupbox.Controls.Add(this.Del_NOT_Button);
            this.Note_Groupbox.Controls.Add(this.Add_NOT_Button);
            this.Note_Groupbox.Controls.Add(this.NOT_strNote_Textbox);
            this.Note_Groupbox.Controls.Add(this.NOT_title_Textbox);
            this.Note_Groupbox.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note_Groupbox.ForeColor = System.Drawing.Color.DarkRed;
            this.Note_Groupbox.Location = new System.Drawing.Point(2, 8);
            this.Note_Groupbox.Name = "Note_Groupbox";
            this.Note_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Note_Groupbox.Size = new System.Drawing.Size(1555, 875);
            this.Note_Groupbox.TabIndex = 2;
            this.Note_Groupbox.TabStop = false;
            this.Note_Groupbox.Text = "إضافة ملاحظات";
            // 
            // Decrypt_Button
            // 
            this.Decrypt_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.Decrypt_Button.FlatAppearance.BorderSize = 0;
            this.Decrypt_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decrypt_Button.Font = new System.Drawing.Font("El Messiri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrypt_Button.ForeColor = System.Drawing.Color.Black;
            this.Decrypt_Button.Location = new System.Drawing.Point(862, 670);
            this.Decrypt_Button.Name = "Decrypt_Button";
            this.Decrypt_Button.Size = new System.Drawing.Size(300, 52);
            this.Decrypt_Button.TabIndex = 64;
            this.Decrypt_Button.Text = "فك تشفير";
            this.Decrypt_Button.UseVisualStyleBackColor = false;
            this.Decrypt_Button.Click += new System.EventHandler(this.Decrypt_Button_Click);
            // 
            // Encrypt_Button
            // 
            this.Encrypt_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.Encrypt_Button.FlatAppearance.BorderSize = 0;
            this.Encrypt_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Encrypt_Button.Font = new System.Drawing.Font("El Messiri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encrypt_Button.ForeColor = System.Drawing.Color.Black;
            this.Encrypt_Button.Location = new System.Drawing.Point(1176, 670);
            this.Encrypt_Button.Name = "Encrypt_Button";
            this.Encrypt_Button.Size = new System.Drawing.Size(300, 52);
            this.Encrypt_Button.TabIndex = 63;
            this.Encrypt_Button.Text = "تشفير";
            this.Encrypt_Button.UseVisualStyleBackColor = false;
            this.Encrypt_Button.Click += new System.EventHandler(this.Encrypt_Button_Click);
            // 
            // Not_Label
            // 
            this.Not_Label.Font = new System.Drawing.Font("El Messiri", 10.8F);
            this.Not_Label.Location = new System.Drawing.Point(43, 730);
            this.Not_Label.Name = "Not_Label";
            this.Not_Label.Size = new System.Drawing.Size(1430, 67);
            this.Not_Label.TabIndex = 62;
            this.Not_Label.Text = "العدد يجب ان يكون رقم صحيح";
            this.Not_Label.Visible = false;
            // 
            // NOT_title_Adj_Label
            // 
            this.NOT_title_Adj_Label.AutoSize = true;
            this.NOT_title_Adj_Label.Font = new System.Drawing.Font("El Messiri", 10.8F);
            this.NOT_title_Adj_Label.Location = new System.Drawing.Point(1413, 50);
            this.NOT_title_Adj_Label.Name = "NOT_title_Adj_Label";
            this.NOT_title_Adj_Label.Size = new System.Drawing.Size(68, 29);
            this.NOT_title_Adj_Label.TabIndex = 60;
            this.NOT_title_Adj_Label.Text = "العنوان";
            // 
            // WH_c_price_Adj_Label
            // 
            this.WH_c_price_Adj_Label.AutoSize = true;
            this.WH_c_price_Adj_Label.Font = new System.Drawing.Font("El Messiri", 10.8F);
            this.WH_c_price_Adj_Label.Location = new System.Drawing.Point(1378, 108);
            this.WH_c_price_Adj_Label.Name = "WH_c_price_Adj_Label";
            this.WH_c_price_Adj_Label.Size = new System.Drawing.Size(0, 29);
            this.WH_c_price_Adj_Label.TabIndex = 59;
            // 
            // Modify_NOT_Button
            // 
            this.Modify_NOT_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Modify_NOT_Button.FlatAppearance.BorderSize = 0;
            this.Modify_NOT_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modify_NOT_Button.Font = new System.Drawing.Font("El Messiri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modify_NOT_Button.ForeColor = System.Drawing.Color.Black;
            this.Modify_NOT_Button.Location = new System.Drawing.Point(787, 805);
            this.Modify_NOT_Button.Name = "Modify_NOT_Button";
            this.Modify_NOT_Button.Size = new System.Drawing.Size(259, 53);
            this.Modify_NOT_Button.TabIndex = 58;
            this.Modify_NOT_Button.Text = "تعديل الملاحظات";
            this.Modify_NOT_Button.UseVisualStyleBackColor = false;
            this.Modify_NOT_Button.Click += new System.EventHandler(this.NOTE_Button_Click);
            // 
            // Del_NOT_Button
            // 
            this.Del_NOT_Button.BackColor = System.Drawing.Color.DarkRed;
            this.Del_NOT_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del_NOT_Button.Font = new System.Drawing.Font("El Messiri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del_NOT_Button.ForeColor = System.Drawing.Color.Black;
            this.Del_NOT_Button.Location = new System.Drawing.Point(417, 812);
            this.Del_NOT_Button.Name = "Del_NOT_Button";
            this.Del_NOT_Button.Size = new System.Drawing.Size(221, 38);
            this.Del_NOT_Button.TabIndex = 57;
            this.Del_NOT_Button.Text = "حذف الملاحظة";
            this.Del_NOT_Button.UseVisualStyleBackColor = false;
            this.Del_NOT_Button.Click += new System.EventHandler(this.NOTE_Button_Click);
            // 
            // Add_NOT_Button
            // 
            this.Add_NOT_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Add_NOT_Button.FlatAppearance.BorderSize = 0;
            this.Add_NOT_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_NOT_Button.Font = new System.Drawing.Font("El Messiri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_NOT_Button.ForeColor = System.Drawing.Color.Black;
            this.Add_NOT_Button.Location = new System.Drawing.Point(31, 805);
            this.Add_NOT_Button.Name = "Add_NOT_Button";
            this.Add_NOT_Button.Size = new System.Drawing.Size(259, 53);
            this.Add_NOT_Button.TabIndex = 56;
            this.Add_NOT_Button.Text = "إضافة الملاحظات";
            this.Add_NOT_Button.UseVisualStyleBackColor = false;
            this.Add_NOT_Button.Click += new System.EventHandler(this.NOTE_Button_Click);
            // 
            // NOT_strNote_Textbox
            // 
            this.NOT_strNote_Textbox.Font = new System.Drawing.Font("El Messiri", 12.8F);
            this.NOT_strNote_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.NOT_strNote_Textbox.IsPasswordTextbox = false;
            this.NOT_strNote_Textbox.IsPlaceholder = true;
            this.NOT_strNote_Textbox.Location = new System.Drawing.Point(31, 91);
            this.NOT_strNote_Textbox.Multiline = true;
            this.NOT_strNote_Textbox.Name = "NOT_strNote_Textbox";
            this.NOT_strNote_Textbox.Placeholder = "الملاحظات";
            this.NOT_strNote_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.NOT_strNote_Textbox.placeholderFont = null;
            this.NOT_strNote_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NOT_strNote_Textbox.SelectedItem = null;
            this.NOT_strNote_Textbox.Size = new System.Drawing.Size(1443, 577);
            this.NOT_strNote_Textbox.TabIndex = 5;
            this.NOT_strNote_Textbox.Tag = "";
            this.NOT_strNote_Textbox.Text = "الملاحظات";
            this.NOT_strNote_Textbox.Values = null;
            this.NOT_strNote_Textbox.Visible_Password_Button = false;
            // 
            // NOT_title_Textbox
            // 
            this.NOT_title_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.NOT_title_Textbox.IsPasswordTextbox = false;
            this.NOT_title_Textbox.IsPlaceholder = true;
            this.NOT_title_Textbox.Location = new System.Drawing.Point(31, 42);
            this.NOT_title_Textbox.Name = "NOT_title_Textbox";
            this.NOT_title_Textbox.Placeholder = "العنوان";
            this.NOT_title_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.NOT_title_Textbox.placeholderFont = null;
            this.NOT_title_Textbox.SelectedItem = null;
            this.NOT_title_Textbox.Size = new System.Drawing.Size(1376, 43);
            this.NOT_title_Textbox.TabIndex = 3;
            this.NOT_title_Textbox.Text = "العنوان";
            this.NOT_title_Textbox.Values = null;
            this.NOT_title_Textbox.Visible_Password_Button = false;
            this.NOT_title_Textbox.SelectedItemChanged += new System.EventHandler<System.EventArgs>(this.NOT_title_Textbox_SelectedItemChanged);
            // 
            // available_Tabpage
            // 
            this.available_Tabpage.Location = new System.Drawing.Point(4, 5);
            this.available_Tabpage.Name = "available_Tabpage";
            this.available_Tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.available_Tabpage.Size = new System.Drawing.Size(1564, 906);
            this.available_Tabpage.TabIndex = 1;
            this.available_Tabpage.Text = "جرد / الأجهزة المتاحة";
            this.available_Tabpage.UseVisualStyleBackColor = true;
            // 
            // prices_Tabpage
            // 
            this.prices_Tabpage.Location = new System.Drawing.Point(4, 5);
            this.prices_Tabpage.Name = "prices_Tabpage";
            this.prices_Tabpage.Size = new System.Drawing.Size(1564, 906);
            this.prices_Tabpage.TabIndex = 2;
            this.prices_Tabpage.Text = "قائمة الأسعار";
            this.prices_Tabpage.UseVisualStyleBackColor = true;
            // 
            // TileButtons_Panel
            // 
            this.TileButtons_Panel.Controls.Add(this.WH_Search_TileButton);
            this.TileButtons_Panel.Controls.Add(this.WH_pricelist_TileButton);
            this.TileButtons_Panel.Controls.Add(this.SidePanel1);
            this.TileButtons_Panel.Controls.Add(this.NotesManager_TileButton);
            this.TileButtons_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TileButtons_Panel.Location = new System.Drawing.Point(0, 0);
            this.TileButtons_Panel.Name = "TileButtons_Panel";
            this.TileButtons_Panel.Size = new System.Drawing.Size(192, 950);
            this.TileButtons_Panel.TabIndex = 52;
            // 
            // WH_Search_TileButton
            // 
            this.WH_Search_TileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.WH_Search_TileButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.WH_Search_TileButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.WH_Search_TileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WH_Search_TileButton.Font = new System.Drawing.Font("A Nasr", 30F);
            this.WH_Search_TileButton.ForeColor = System.Drawing.Color.Black;
            this.WH_Search_TileButton.Image = null;
            this.WH_Search_TileButton.ImagePosition = 0;
            this.WH_Search_TileButton.ImageZoom = 0;
            this.WH_Search_TileButton.LabelPosition = 195;
            this.WH_Search_TileButton.LabelText = "بحث";
            this.WH_Search_TileButton.Location = new System.Drawing.Point(2, 318);
            this.WH_Search_TileButton.Margin = new System.Windows.Forms.Padding(7);
            this.WH_Search_TileButton.Name = "WH_Search_TileButton";
            this.WH_Search_TileButton.Size = new System.Drawing.Size(189, 316);
            this.WH_Search_TileButton.TabIndex = 48;
            this.WH_Search_TileButton.Tag = this.available_Tabpage;
            this.WH_Search_TileButton.Visible = false;
            this.WH_Search_TileButton.Click += new System.EventHandler(this.TileButton_Click);
            // 
            // WH_pricelist_TileButton
            // 
            this.WH_pricelist_TileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.WH_pricelist_TileButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.WH_pricelist_TileButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.WH_pricelist_TileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WH_pricelist_TileButton.Font = new System.Drawing.Font("A Nasr", 28.8F);
            this.WH_pricelist_TileButton.ForeColor = System.Drawing.Color.Black;
            this.WH_pricelist_TileButton.Image = null;
            this.WH_pricelist_TileButton.ImagePosition = 0;
            this.WH_pricelist_TileButton.ImageZoom = 0;
            this.WH_pricelist_TileButton.LabelPosition = 230;
            this.WH_pricelist_TileButton.LabelText = "قائمة الأسعار";
            this.WH_pricelist_TileButton.Location = new System.Drawing.Point(1, 634);
            this.WH_pricelist_TileButton.Margin = new System.Windows.Forms.Padding(56, 65, 56, 65);
            this.WH_pricelist_TileButton.Name = "WH_pricelist_TileButton";
            this.WH_pricelist_TileButton.Size = new System.Drawing.Size(191, 316);
            this.WH_pricelist_TileButton.TabIndex = 47;
            this.WH_pricelist_TileButton.Tag = this.prices_Tabpage;
            this.WH_pricelist_TileButton.Visible = false;
            this.WH_pricelist_TileButton.Click += new System.EventHandler(this.TileButton_Click);
            // 
            // SidePanel1
            // 
            this.SidePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.SidePanel1.Location = new System.Drawing.Point(0, 0);
            this.SidePanel1.Name = "SidePanel1";
            this.SidePanel1.Size = new System.Drawing.Size(12, 317);
            this.SidePanel1.TabIndex = 46;
            // 
            // NotesManager_TileButton
            // 
            this.NotesManager_TileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.NotesManager_TileButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.NotesManager_TileButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.NotesManager_TileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotesManager_TileButton.Font = new System.Drawing.Font("A Nasr", 26F);
            this.NotesManager_TileButton.ForeColor = System.Drawing.Color.Black;
            this.NotesManager_TileButton.Image = null;
            this.NotesManager_TileButton.ImagePosition = 0;
            this.NotesManager_TileButton.ImageZoom = 0;
            this.NotesManager_TileButton.LabelPosition = 240;
            this.NotesManager_TileButton.LabelText = "إدارة الملاحظات";
            this.NotesManager_TileButton.Location = new System.Drawing.Point(1, 1);
            this.NotesManager_TileButton.Margin = new System.Windows.Forms.Padding(6);
            this.NotesManager_TileButton.Name = "NotesManager_TileButton";
            this.NotesManager_TileButton.Size = new System.Drawing.Size(191, 317);
            this.NotesManager_TileButton.TabIndex = 45;
            this.NotesManager_TileButton.Tag = this.add_Tabpage;
            this.NotesManager_TileButton.Click += new System.EventHandler(this.TileButton_Click);
            // 
            // UsrCtrl_Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TileButtons_Panel);
            this.Controls.Add(this.storage_Tabcontrol);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UsrCtrl_Notes";
            this.Size = new System.Drawing.Size(1926, 950);
            this.storage_Tabcontrol.ResumeLayout(false);
            this.add_Tabpage.ResumeLayout(false);
            this.Note_Groupbox.ResumeLayout(false);
            this.Note_Groupbox.PerformLayout();
            this.TileButtons_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Note_Groupbox;
        private ModdedControls.ModdedTextBox NOT_title_Textbox;
        private ModdedControls.ModdedTextBox NOT_strNote_Textbox;
        private TransparentTabControl storage_Tabcontrol;
        private System.Windows.Forms.TabPage add_Tabpage;
        private System.Windows.Forms.TabPage available_Tabpage;
        private System.Windows.Forms.TabPage prices_Tabpage;
        private System.Windows.Forms.Label NOT_title_Adj_Label;
        private System.Windows.Forms.Label WH_c_price_Adj_Label;
        private System.Windows.Forms.Button Modify_NOT_Button;
        private System.Windows.Forms.Button Del_NOT_Button;
        private System.Windows.Forms.Button Add_NOT_Button;
        private System.Windows.Forms.Label Not_Label;
        private System.Windows.Forms.Panel TileButtons_Panel;
        private ns1.BunifuTileButton WH_Search_TileButton;
        private ns1.BunifuTileButton WH_pricelist_TileButton;
        private System.Windows.Forms.Panel SidePanel1;
        private ns1.BunifuTileButton NotesManager_TileButton;
        private System.Windows.Forms.Button Decrypt_Button;
        private System.Windows.Forms.Button Encrypt_Button;
    }
}
