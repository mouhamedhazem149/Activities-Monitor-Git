using DailyCompanionV2.Models;
using DailyCompanionV2.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DailyCompanionV2.User_Interfaces
{
    partial class UsrCtrl_Notification : UserControl
    {
        const string requiredNotification = "requireNotify";
        const string upcomingNotification = "upcomingNotify";
        public UsrCtrl_Notification(System.Drawing.Color color)
        {
            InitializeComponent();
            this.BackColor = notifications_Treeview.BackColor = ControlPaint.Light(color, .2f);
            Sync();
        }
        public void Sync()
        {
            LoadTreeView();
        }
        private void LoadTreeView()
        {//2 trees , one for required not done with their req date, one for upcoming with their next dates
            notifications_Treeview.Nodes.Clear();

            var RequiredNotify = Program.Notifications_List.Where(p => !p.done).ToList();
            notifications_Treeview.Nodes.Add(requiredNotification,"التنبيهات المطلوبة");
            foreach (Notification notify in RequiredNotify)
            {
                notifications_Treeview.Nodes[requiredNotification].Nodes.Add(new TreeNode($"{notify.title} :: اخر تاريخ للتنبيه : {notify.lastDate.ToString("g")}")
                {
                    Tag = notify,
                    ToolTipText =
                    $"{notify.category} " +
                    $"\n {notify.title} {notify.description} " +
                    $"\n بداية التنبيه : {notify.notif_Date} " +
                    $"\n {notify.frequency.GetDisplayName()} {notify.freqDInt} " +
                    $"\n {notify.repeat.GetDisplayName()} {notify.repeatInt} " +
                    $"\n آخر تاريخ تنبيه :: {notify.lastDate} " +
                    $"\n تاريخ التنبيه القادم :: {notify.STRnextDate}"
                });
            }

            var UpcomingNotify = Program.Notifications_List.Where(p => !p.completed && p.done);
            notifications_Treeview.Nodes.Add(upcomingNotification, "التنبيهات القادمة");
            foreach (Notification notify in UpcomingNotify)
            {
                var tempLast = notify.done_date.HasValue ? $"اخر تاريخ للتنبيه : {notify.done_date.Value.ToString("g")}" : "لم يتم الإنهاء من قبل";
                notifications_Treeview.Nodes[upcomingNotification].Nodes.Add(new TreeNode($"{notify.title} :: {tempLast}")
                {
                    Tag = notify,
                    ToolTipText =
                    $"{notify.category} " +
                    $"\n {notify.title} {notify.description} " +
                    $"\n بداية التنبيه : {notify.notif_Date} " +
                    $"\n {notify.frequency.GetDisplayName()} {notify.freqDInt} " +
                    $"\n {notify.repeat.GetDisplayName()} {notify.repeatInt} " +
                    $"\n آخر تاريخ تنبيه :: {notify.lastDate} " +
                    $"\n تاريخ التنبيه القادم :: {notify.STRnextDate}"
                });
            }
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e) =>
           Program.WorkingForm.Click_Settings(Utilities.Enums.settingsState.notification);


        private void Notif_Done_Button_Click(object sender, EventArgs e)
        {
            if (notifications_Treeview.SelectedNode != null)
            {
                var selNode = notifications_Treeview.SelectedNode;
                try
                {
                    Notification notify = (Notification)selNode.Tag;
                    Settings.Settings_Processor.HandleNotification(Enums.genericHandle_Type.تعديل, null, notify.title, notify.description, notify.category, notify.notif_Date, notify.frequency, notify.freqDInt, notify.repeat, notify.repeatInt, DateTime.Now
                        , Notification_Label, "", System.Drawing.Color.White, notify, true);
                    HM_Manager.Success_addition(Notification_Label, "تم إنهاء التنبيه بنجاح");
                }
                catch (Exception ex) { HM_Manager.Fail_addition(Notification_Label, "برجاء التاكد من بيانات التنبيه"); }
            }
            Sync();
            Program.WorkingForm.Notify_Sync();
        }
    }
}
