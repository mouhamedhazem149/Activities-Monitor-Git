using System;
using System.Linq;
using System.Windows.Forms;
using DailyCompanionV2.Utilities;
using System.Collections.Generic;

namespace DailyCompanionV2.User_Interfaces
{
    public partial class UsrCtrl_Notes
    {
        const string notSidePrevious = "previousNOT";
        const string notSideRecent = "recentNOT";
        private void PrepareSidePanel()
        {
            Side_Panel.Enabled = false;

            sidePanel_Treeview.Nodes.Clear();
            LoadNOTRecentNode();
            LoadNOTPreviousNode();

            Side_Panel.Enabled = true;
        }
        private void LoadNOTRecentNode()
        {
            int notRecent_Count = int.Parse(System.Configuration.ConfigurationManager.AppSettings["recentNOTEcount"].ToString());
            var notRecent = Program.Notes_List.OrderByDescending(p => p.lst_updt).ThenBy(p => p.id).Take(notRecent_Count).ToList();
            sidePanel_Treeview.Nodes.Add(notSideRecent, $"تم إضافته مؤخرا (أقصى حد : {notRecent_Count}) :");
            foreach (var recent in notRecent)
                sidePanel_Treeview.Nodes[notSideRecent].Nodes.Add(new TreeNode($"{recent.title}. تاريخ أخر تعديل : {recent.lst_updt.ToString("D")}") { Tag = recent.id });
        }
        private void LoadNOTPreviousNode()
        {
            string property = HM_Manager.Propertyfromcontrol(NOT_title_Textbox);
            List<string> previousNOT = new List<string>();
            previousNOT = Program.Notes_List.Select(p => p.GetType().GetProperty(property).GetValue(p).ToString()).ToList();
            if (!sidePanel_Treeview.Nodes.ContainsKey(notSidePrevious)) sidePanel_Treeview.Nodes.Add(notSidePrevious, $"خيارات مقترحة ({previousNOT.Distinct().Count()}) :");
            else sidePanel_Treeview.Nodes[notSidePrevious].Text = $"خيارات مقترحة ({previousNOT.Distinct().Count()}) :";
            sidePanel_Treeview.Nodes[notSidePrevious].Nodes.Clear();
            foreach (var previous in previousNOT.Distinct())
                sidePanel_Treeview.Nodes[notSidePrevious].Nodes.Add(new TreeNode($"{previous} : ({previousNOT.Count(p => p == previous)})") { Tag = previous });
        }
        private void sidePanel_Treeview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!(sender is TreeView)) return;
            var selNode = (sender as TreeView).SelectedNode;
            if (selNode != null && (sender as TreeView).GetNodeAt(e.Location) == selNode)
            {
                TreeNode parent = selNode;
                while (parent.Level != 0)
                    parent = parent.Parent;
                switch (parent.Name)
                {
                    case notSideRecent:// اخر حاجات تم ادخالها
                        switch (selNode.Level)
                        {
                            case 1:
                                if (selNode.Tag is int?)
                                    Program.WorkingForm.Click_Note(Enums.noteArgument.loadNoteItem, (selNode.Tag as int?).Value);
                                break;
                        }
                        break;
                    case notSidePrevious:// كل الحاجات المحتملة لل فيلد ده 
                        switch (selNode.Level)
                        {
                            case 1:
                                if (selNode.Tag is string)
                                    if (NOT_title_Textbox.Values.Contains(selNode.Tag as string))
                                        NOT_title_Textbox.SelectedItem = NOT_title_Textbox.Text = selNode.Tag as string;
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine($"WARNING :: Unhandled todo tree itme {selNode.Parent.Name}");
                        break;
                }
            }
        }
    }
}
