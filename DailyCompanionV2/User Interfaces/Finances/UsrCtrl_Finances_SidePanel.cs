using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DailyCompanionV2.Models;
using DailyCompanionV2.User_Interfaces.Finance;
using DailyCompanionV2.User_Interfaces.Settings;
using DailyCompanionV2.Utilities;

namespace DailyCompanionV2
{
    public partial class UsrCtrl_Finances
    {
        const string fncSideSuggested = "suggestedFNC";
        const string fncSideRequired = "requiredFNC";
        const string fncSideSimilar = "similarFNC";
        const string fncSidePrevious = "previousFNC";
        const string fncSideRecent = "recentFNC";
        private void PrepareSidePanel()
        {
            Side_Panel.Enabled = false;

            sidePanel_Treeview.Nodes.Clear();
            LoadFNCRecentNode();
            LoadFNCSuggestedNode();
            LoadFNCPreviousNode();
            LoadFNCSimilarNode();
            LoadFNCReqNode();

            Side_Panel.Enabled = true;
        }
        private void LoadFNCRecentNode()
        {
            int fncRecent_Count = int.Parse(System.Configuration.ConfigurationManager.AppSettings["recentFNCcount"].ToString());
            var fncRecent = Program.Finances_List.OrderByDescending(p => p.lst_updt).ThenBy(p => p.id).Take(fncRecent_Count).ToList();
            sidePanel_Treeview.Nodes.Add(fncSideRecent, $"تم إضافته مؤخرا (أقصى حد : {fncRecent_Count}) :");
            foreach (var recent in fncRecent)
                sidePanel_Treeview.Nodes[fncSideRecent].Nodes.Add(new TreeNode($"{recent.category} \n {recent.paid}/{recent.due} إلى {recent.relatedentity} :: ({recent.id}). تاريخ أخر تعديل : {recent.lst_updt.ToString("D")}") { Tag = recent.id });
        }
        private void LoadFNCSuggestedNode()
        {
            List<Finances> suggestedFNC = Program.Finances_List.Where(p => Math.Abs(DateTime.Now.TimeOfDay.Subtract(p.due_date.TimeOfDay).TotalMinutes) < 20).ToList();
            var suggestedFNCs = suggestedFNC.GroupBy(p => p.relatedentity).OrderByDescending(p => p.Count()).ToList();
            sidePanel_Treeview.Nodes.Add(fncSideSuggested, $"مدفوعات مقترحة ({suggestedFNCs.Count}) :");
            foreach (var suggestion in suggestedFNCs)
            {
                TreeNode[] fncSideSuggestedArray = suggestedFNC.Where(p => p.relatedentity == suggestion.Key).OrderByDescending(p => p.id).ToList().Select(p => new TreeNode($"{p.id} :: {p.due_date.Date.ToShortDateString()}") { Tag = p.id }).ToArray();
                sidePanel_Treeview.Nodes[fncSideSuggested].Nodes.Add(new TreeNode($"{suggestion.Key} :: ({suggestion.Count()})", fncSideSuggestedArray) { Tag = suggestion.Key });
            }
        }
        private void LoadFNCPreviousNode()
        {
            string property = HM_Manager.Propertyfromcontrol(focusedTextbox);
            List<string> previousFNC = new List<string>();
            if (focusedTextbox != null) previousFNC = Program.Finances_List.Select(p => p.GetType().GetProperty(property).GetValue(p).ToString()).ToList();
            if (!sidePanel_Treeview.Nodes.ContainsKey(fncSidePrevious)) sidePanel_Treeview.Nodes.Add(fncSidePrevious, $"خيارات مقترحة ({previousFNC.Distinct().Count()}) :");
            else sidePanel_Treeview.Nodes[fncSidePrevious].Text = $"خيارات مقترحة ({previousFNC.Distinct().Count()}) :";
            sidePanel_Treeview.Nodes[fncSidePrevious].Nodes.Clear();
            foreach (var previous in previousFNC.Distinct())
                sidePanel_Treeview.Nodes[fncSidePrevious].Nodes.Add(new TreeNode($"{previous} : ({previousFNC.Count(p => p == previous)})") { Tag = previous });
        }
        private void LoadFNCSimilarNode()
        {//3 levels , parent node containg different properties, under each property possible values, under each value possible matches by ID
            string property = HM_Manager.Propertyfromcontrol(focusedTextbox);
            // getting similar todo list who share the focused textbox value
            List<Finances> similarFNC = new List<Finances>();
            if (focusedTextbox != null && focusedTextbox.SelectedItem != null)
                similarFNC = Program.Finances_List.Where(p => p.GetType().GetProperty(property).GetValue(p).ToString() == focusedTextbox.SelectedItem).ToList();
            if (!sidePanel_Treeview.Nodes.ContainsKey(fncSideSimilar))
                sidePanel_Treeview.Nodes.Add(fncSideSimilar, $"مهام مالية شبيهة ({similarFNC.Count}) :");
            else sidePanel_Treeview.Nodes[fncSideSimilar].Text = $"مهام مالية شبيهة ({similarFNC.Count}) :";
            sidePanel_Treeview.Nodes[fncSideSimilar].Nodes.Clear();

            // getting properities i need " can get it from model , but keeping it from gui is اهم بالنسبة لي
            Dictionary<string, List<string>> Properties = new Dictionary<string, List<string>>();
            foreach (ModdedControls.ModdedTextBox mdTxtbox in HM_Manager.GetAllControls(AddFinance_Groupbox, typeof(ModdedControls.ModdedTextBox)).Select(p => p as ModdedControls.ModdedTextBox))
            {
                string tempProp = HM_Manager.Propertyfromcontrol(mdTxtbox);
                if (tempProp == "id") continue;
                Properties.Add(tempProp, similarFNC.Select(sim => sim.GetType().GetProperty(tempProp).GetValue(sim).ToString()).ToList());
            }
            //getting the list of possible value for each property
            foreach (string _prop in Properties.Keys)
            {
                TreeNode[] todoSideSimilarPropVluArray = Properties[_prop].GroupBy(p => p)
                    .Select(valueG => new TreeNode($"{valueG.Key} :: ({valueG.Count()})",
                    similarFNC.Where(p => p.GetType().GetProperty(_prop).GetValue(p).ToString() == valueG.Key).OrderByDescending(p => p.id).Select(p => new TreeNode($"{p.id}") { Tag = p.id }).ToArray())//ids for todos with same value
                    { Tag = valueG.Key }).ToArray();
                sidePanel_Treeview.Nodes[fncSideSimilar].Nodes.Add(new TreeNode($"{_prop} :: ({Properties[_prop].Distinct().Count()})", todoSideSimilarPropVluArray) { Tag = _prop });
            }
        }
        private void LoadFNCReqNode()
        {
            List<Finances> reqFNC = Program.Finances_List.Where(p => !p.done_date.HasValue).ToList();
            sidePanel_Treeview.Nodes.Add(fncSideRequired, $"مهام مطلوبة ({reqFNC.Count}) :");
            foreach (var req in reqFNC)
                sidePanel_Treeview.Nodes[fncSideRequired].Nodes.Add(new TreeNode($"{req.category} \n {req.due} إلى {req.relatedentity} :: ({req.id})") { Tag = req.id });
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
                    case fncSideSuggested:// اقتراحات بناء ع وقت اليوم
                        switch (selNode.Level)
                        {
                            case 1:
                                if (selNode.Tag is string)
                                    if (FNC_relatedentity_Textbox.Values.Contains(selNode.Tag as string))
                                        FNC_relatedentity_Textbox.SelectedItem = FNC_relatedentity_Textbox.Text = selNode.Tag as string;
                                break;
                            case 2:
                                if (selNode.Tag is int?)
                                    Program.WorkingForm.Click_FNC(Enums.financeArgument.loadFinanceItem, (selNode.Tag as int?).Value);
                                break;
                        }
                        break;
                    case fncSideRequired://المهام المطلوبة اللي لسا مخلصتش
                    case fncSideRecent:// اخر حاجات تم ادخالها
                        switch (selNode.Level)
                        {
                            case 1:
                                if (selNode.Tag is int?)
                                    Program.WorkingForm.Click_FNC(Enums.financeArgument.loadFinanceItem, (selNode.Tag as int?).Value);
                                break;
                        }
                        break;
                    case fncSidePrevious:// كل الحاجات المحتملة لل فيلد ده 
                        switch (selNode.Level)
                        {
                            case 1:
                                if (selNode.Tag is string)
                                    if (focusedTextbox.Values.Contains(selNode.Tag as string))
                                        focusedTextbox.SelectedItem = focusedTextbox.Text = selNode.Tag as string;
                                break;
                        }
                        break;
                    case fncSideSimilar:// ده المفروض اني بشوف كل النسخ الممكنة ع حسب الفيلد برده اللي مختاره واعمل لست للحاجات اللي فيها فروق
                        switch (selNode.Level)
                        {
                            case 1:
                                break;
                            case 2:
                                if (selNode.Tag is string)
                                {
                                    var tempControl = HM_Manager.GetAllControls(AddFinance_Groupbox, typeof(ModdedControls.ModdedTextBox))
                                        .Where(p => HM_Manager.Propertyfromcontrol(p as ModdedControls.ModdedTextBox) == selNode.Parent.Tag as string)
                                        .FirstOrDefault();
                                    ModdedControls.ModdedTextBox propertyTxtbox = tempControl != null ? tempControl as ModdedControls.ModdedTextBox : null;
                                    if (propertyTxtbox != null)
                                        propertyTxtbox.SelectedItem = propertyTxtbox.Text = selNode.Tag as string;
                                }
                                break;
                            case 3:
                                if (selNode.Tag is int?)
                                    Program.WorkingForm.Click_FNC(Enums.financeArgument.loadFinanceItem, (selNode.Tag as int?).Value);
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
