namespace OpsMoi
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.Login_Button = new System.Windows.Forms.Button();
            this.ForgetPassword_Button = new System.Windows.Forms.Button();
            this.Login_Label = new System.Windows.Forms.Label();
            this.Login_Password_Textbox = new ModdedControls.ModdedTextBox();
            this.Resolution_Combobox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_Button
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Login_Button, 2);
            this.Login_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Login_Button.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Button.ForeColor = System.Drawing.Color.Black;
            this.Login_Button.Location = new System.Drawing.Point(475, 247);
            this.Login_Button.Margin = new System.Windows.Forms.Padding(3, 3, 80, 3);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(277, 55);
            this.Login_Button.TabIndex = 5;
            this.Login_Button.Text = "تسجيل الدخول";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // ForgetPassword_Button
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ForgetPassword_Button, 2);
            this.ForgetPassword_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.ForgetPassword_Button.Font = new System.Drawing.Font("El Messiri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetPassword_Button.ForeColor = System.Drawing.Color.DarkRed;
            this.ForgetPassword_Button.Location = new System.Drawing.Point(48, 247);
            this.ForgetPassword_Button.Margin = new System.Windows.Forms.Padding(3, 3, 80, 3);
            this.ForgetPassword_Button.Name = "ForgetPassword_Button";
            this.ForgetPassword_Button.Size = new System.Drawing.Size(288, 55);
            this.ForgetPassword_Button.TabIndex = 6;
            this.ForgetPassword_Button.TabStop = false;
            this.ForgetPassword_Button.Text = "نسيت كلمة المرور";
            this.ForgetPassword_Button.UseVisualStyleBackColor = true;
            this.ForgetPassword_Button.Click += new System.EventHandler(this.ForgetPassword_Button_Click);
            // 
            // Login_Label
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Login_Label, 4);
            this.Login_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_Label.Font = new System.Drawing.Font("El Messiri", 8.8F);
            this.Login_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.Login_Label.Location = new System.Drawing.Point(3, 369);
            this.Login_Label.Margin = new System.Windows.Forms.Padding(3);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Login_Label.Size = new System.Drawing.Size(826, 61);
            this.Login_Label.TabIndex = 44;
            this.Login_Label.Text = "تم إرسال كلمة مرور جديدة لبريدك الألكتروني! برجاء التحقق";
            this.Login_Label.UseMnemonic = false;
            this.Login_Label.Visible = false;
            // 
            // Login_Password_Textbox
            // 
            this.Login_Password_Textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_Password_Textbox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Password_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.Login_Password_Textbox.IsPasswordTextbox = true;
            this.Login_Password_Textbox.IsPlaceholder = true;
            this.Login_Password_Textbox.Location = new System.Drawing.Point(0, 0);
            this.Login_Password_Textbox.Margin = new System.Windows.Forms.Padding(20);
            this.Login_Password_Textbox.Name = "Login_Password_Textbox";
            this.Login_Password_Textbox.Placeholder = "ادخل كلمة المرور";
            this.Login_Password_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.Login_Password_Textbox.placeholderFont = null;
            this.Login_Password_Textbox.SelectedItem = null;
            this.Login_Password_Textbox.Size = new System.Drawing.Size(618, 39);
            this.Login_Password_Textbox.TabIndex = 2;
            this.Login_Password_Textbox.Tag = "";
            this.Login_Password_Textbox.Text = "ادخل كلمة المرور";
            this.Login_Password_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Login_Password_Textbox.Values = null;
            this.Login_Password_Textbox.Visible_Password_Button = true;
            // 
            // Resolution_Combobox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Resolution_Combobox, 2);
            this.Resolution_Combobox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Resolution_Combobox.Enabled = false;
            this.Resolution_Combobox.Font = new System.Drawing.Font("Alameen", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Resolution_Combobox.FormattingEnabled = true;
            this.Resolution_Combobox.Location = new System.Drawing.Point(211, 125);
            this.Resolution_Combobox.Name = "Resolution_Combobox";
            this.Resolution_Combobox.Size = new System.Drawing.Size(410, 36);
            this.Resolution_Combobox.TabIndex = 3;
            this.Resolution_Combobox.TabStop = false;
            this.Resolution_Combobox.SelectedIndexChanged += new System.EventHandler(this.Resolution_Combobox_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Login_Label, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.Resolution_Combobox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.ForgetPassword_Button, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Login_Button, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(832, 433);
            this.tableLayoutPanel1.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("ToyorAljanah", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(628, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 53);
            this.label2.TabIndex = 1;
            this.label2.Text = "كلمة المرور";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("ToyorAljanah", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(628, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 53);
            this.label3.TabIndex = 47;
            this.label3.Text = "دقة الشاشة";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.Login_Password_Textbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 48);
            this.panel1.TabIndex = 2;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(901, 481);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogInForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogInForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LogInForm_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ModdedControls.ModdedTextBox Login_Password_Textbox;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button ForgetPassword_Button;
        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.ComboBox Resolution_Combobox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}