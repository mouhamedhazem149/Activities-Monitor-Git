
namespace DailyCompanionV2.User_Interfaces
{
    partial class UsrCtrl_Notification
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
            this.components = new System.ComponentModel.Container();
            this.notification_MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Notification_Panel = new System.Windows.Forms.Panel();
            this.Notif_Done_Button = new System.Windows.Forms.Button();
            this.Notification_Label = new System.Windows.Forms.Label();
            this.notifications_Treeview = new System.Windows.Forms.TreeView();
            this.notification_MenuStrip.SuspendLayout();
            this.Notification_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // notification_MenuStrip
            // 
            this.notification_MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.notification_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.notification_MenuStrip.Name = "shortcut_MenuStrip";
            this.notification_MenuStrip.Size = new System.Drawing.Size(105, 28);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // Notification_Panel
            // 
            this.Notification_Panel.ContextMenuStrip = this.notification_MenuStrip;
            this.Notification_Panel.Controls.Add(this.Notif_Done_Button);
            this.Notification_Panel.Controls.Add(this.Notification_Label);
            this.Notification_Panel.Controls.Add(this.notifications_Treeview);
            this.Notification_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Notification_Panel.Location = new System.Drawing.Point(0, 0);
            this.Notification_Panel.Name = "Notification_Panel";
            this.Notification_Panel.Size = new System.Drawing.Size(550, 380);
            this.Notification_Panel.TabIndex = 89;
            // 
            // Notif_Done_Button
            // 
            this.Notif_Done_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Notif_Done_Button.Font = new System.Drawing.Font("Cairo", 8F);
            this.Notif_Done_Button.Location = new System.Drawing.Point(5, 351);
            this.Notif_Done_Button.Name = "Notif_Done_Button";
            this.Notif_Done_Button.Size = new System.Drawing.Size(127, 29);
            this.Notif_Done_Button.TabIndex = 4;
            this.Notif_Done_Button.Text = "تم";
            this.Notif_Done_Button.UseVisualStyleBackColor = true;
            this.Notif_Done_Button.Click += new System.EventHandler(this.Notif_Done_Button_Click);
            // 
            // Notification_Label
            // 
            this.Notification_Label.Font = new System.Drawing.Font("Cairo SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notification_Label.Location = new System.Drawing.Point(246, 351);
            this.Notification_Label.Name = "Notification_Label";
            this.Notification_Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Notification_Label.Size = new System.Drawing.Size(304, 29);
            this.Notification_Label.TabIndex = 3;
            this.Notification_Label.Text = "label1";
            this.Notification_Label.Visible = false;
            // 
            // notifications_Treeview
            // 
            this.notifications_Treeview.Dock = System.Windows.Forms.DockStyle.Top;
            this.notifications_Treeview.Font = new System.Drawing.Font("Cairo SemiBold", 9.8F, System.Drawing.FontStyle.Bold);
            this.notifications_Treeview.ForeColor = System.Drawing.Color.Black;
            this.notifications_Treeview.Location = new System.Drawing.Point(0, 0);
            this.notifications_Treeview.Name = "notifications_Treeview";
            this.notifications_Treeview.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.notifications_Treeview.RightToLeftLayout = true;
            this.notifications_Treeview.ShowNodeToolTips = true;
            this.notifications_Treeview.Size = new System.Drawing.Size(550, 351);
            this.notifications_Treeview.TabIndex = 1;
            // 
            // UsrCtrl_Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.Notification_Panel);
            this.Name = "UsrCtrl_Notification";
            this.Size = new System.Drawing.Size(550, 380);
            this.notification_MenuStrip.ResumeLayout(false);
            this.Notification_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip notification_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Panel Notification_Panel;
        private System.Windows.Forms.TreeView notifications_Treeview;
        private System.Windows.Forms.Button Notif_Done_Button;
        private System.Windows.Forms.Label Notification_Label;
    }
}
