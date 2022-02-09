using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DailyCompanionV2.Models;
using DailyCompanionV2.Utilities;

namespace DailyCompanionV2.User_Interfaces
{
    public partial class UsrCtrl_Todo
    {
        const string todoSideSuggested = "suggestedTODO";
        const string todoSideRequired = "requiredTODO";
        const string todoSideSimilar = "similarTODO";
        const string todoSidePrevious = "previousTODO";
        const string todoSideRecent = "recentTODO";
        private void PrepareSidePanel()
        {
            Side_Panel.Enabled = false;

            sidePanel_Treeview.Nodes.Clear();
            LoadTODORecentNode();
            LoadTODOSuggestedNode();
            LoadTODOPreviousNode();
            LoadTODOSimilarNode();
            LoadTODOReqNode();

            Side_Panel.Enabled = true;
        }
        private void LoadTODORecentNode()
        {
            int todoRecent_Count = int.Parse(System.Configuration.ConfigurationManager.AppSettings["recentTODOcount"].ToString());
            var todoRecent = Program.Todos_List.OrderByDescending(p => p.lst_updt).ThenBy(p => p.id).Take(todoRecent_Count).ToList();
            sidePanel_Treeview.Nodes.Add(todoSideRecent, $"تم إضافته مؤخرا (أقصى حد : {todoRecent_Count}) :");
            foreach (var recent in todoRecent)
                sidePanel_Treeview.Nodes[todoSideRecent].Nodes.Add(new TreeNode($"{recent.category} \n {recent.todo} :: ({recent.id}). تاريخ أخر تعديل : {recent.lst_updt.ToString("D")}") { Tag = recent.id });
        }
        private void LoadTODOSuggestedNode()
        {
            List<Todos> suggestedTODO = Program.Todos_List.Where(p => Math.Abs(DateTime.Now.TimeOfDay.Subtract(p.due_date.TimeOfDay).TotalMinutes) < 20).ToList();
            var suggestedTODOs = suggestedTODO.GroupBy(p => p.todo).OrderByDescending(p => p.Count()).ToList();
            sidePanel_Treeview.Nodes.Add(todoSideSuggested, $"مهام مقترحة ({suggestedTODOs.Count}) :");
            foreach (var suggestion in suggestedTODOs)
            {
                TreeNode[] todoSideSuggestedArray = suggestedTODO.Where(p => p.todo == suggestion.Key).OrderByDescending(p => p.id).ToList().Select(p => new TreeNode($"{p.id} :: {p.due_date.Date.ToShortDateString()}") { Tag = p.id }).ToArray();
                sidePanel_Treeview.Nodes[todoSideSuggested].Nodes.Add(new TreeNode($"{suggestion.Key} :: ({suggestion.Count()})", todoSideSuggestedArray) { Tag = suggestion.Key });
            }
        }
        private void LoadTODOPreviousNode()
        {
            string property = HM_Manager.Propertyfromcontrol(focusedTextbox);
            List<string> previousTODO = new List<string>();
            if (focusedTextbox != null) previousTODO = Program.Todos_List.Select(p => p.GetType().GetProperty(property).GetValue(p).ToString()).ToList();
            if (!sidePanel_Treeview.Nodes.ContainsKey(todoSidePrevious)) sidePanel_Treeview.Nodes.Add(todoSidePrevious, $"خيارات مقترحة ({previousTODO.Distinct().Count()}) :");
            else sidePanel_Treeview.Nodes[todoSidePrevious].Text = $"خيارات مقترحة ({previousTODO.Distinct().Count()}) :";
            sidePanel_Treeview.Nodes[todoSidePrevious].Nodes.Clear();
            foreach (var previous in previousTODO.Distinct())
                sidePanel_Treeview.Nodes[todoSidePrevious].Nodes.Add(new TreeNode($"{previous} : ({previousTODO.Count(p => p == previous)})") { Tag = previous });
        }
        private void LoadTODOSimilarNode()
        {//3 levels , parent node containg different properties, under each property possible values, under each value possible matches by ID
            string property = HM_Manager.Propertyfromcontrol(focusedTextbox);
            // getting similar todo list who share the focused textbox value
            List<Todos> similarTODO = new List<Todos>();
            if (focusedTextbox != null && focusedTextbox.SelectedItem != null)
                similarTODO = Program.Todos_List.Where(p => p.GetType().GetProperty(property).GetValue(p).ToString() == focusedTextbox.SelectedItem).ToList();
            if (!sidePanel_Treeview.Nodes.ContainsKey(todoSideSimilar))
                sidePanel_Treeview.Nodes.Add(todoSideSimilar, $"مهام شبيهة ({similarTODO.Count}) :");
            else sidePanel_Treeview.Nodes[todoSideSimilar].Text = $"مهام شبيهة ({similarTODO.Count}) :";
            sidePanel_Treeview.Nodes[todoSideSimilar].Nodes.Clear();

            // getting properities i need " can get it from model , but keeping it from gui is اهم بالنسبة لي
            Dictionary<string, List<string>> Properties = new Dictionary<string, List<string>>();
            foreach (ModdedControls.ModdedTextBox mdTxtbox in HM_Manager.GetAllControls(AddTodo_Groupbox, typeof(ModdedControls.ModdedTextBox)).Select(p => p as ModdedControls.ModdedTextBox))
            {
                string tempProp = HM_Manager.Propertyfromcontrol(mdTxtbox);
                if (tempProp == "id") continue;
                Properties.Add(tempProp, similarTODO.Select(sim => sim.GetType().GetProperty(tempProp).GetValue(sim).ToString()).ToList());
            }
            //getting the list of possible value for each property
            foreach (string _prop in Properties.Keys)
            {
                TreeNode[] todoSideSimilarPropVluArray = Properties[_prop].GroupBy(p => p)
                    .Select(valueG => new TreeNode($"{valueG.Key} :: ({valueG.Count()})",
                    similarTODO.Where(p => p.GetType().GetProperty(_prop).GetValue(p).ToString() == valueG.Key).OrderByDescending(p => p.id).Select(p => new TreeNode($"{p.id}") { Tag = p.id }).ToArray())//ids for todos with same value
                    { Tag = valueG.Key }).ToArray();
                sidePanel_Treeview.Nodes[todoSideSimilar].Nodes.Add(new TreeNode($"{_prop} :: ({Properties[_prop].Distinct().Count()})", todoSideSimilarPropVluArray) { Tag = _prop });
            }
        }
        private void LoadTODOReqNode()
        {
            List<Todos> reqTODO = Program.Todos_List.Where(p => !p.done_date.HasValue).ToList();
            sidePanel_Treeview.Nodes.Add(todoSideRequired, $"مهام مطلوبة ({reqTODO.Count}) :");
            foreach (var req in reqTODO)
                sidePanel_Treeview.Nodes[todoSideRequired].Nodes.Add(new TreeNode($"{req.category} \n {req.todo} :: ({req.id})") { Tag = req.id });
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
                    case todoSideSuggested:// اقتراحات بناء ع وقت اليوم
                        switch (selNode.Level)
                        {
                            case 1:
                                if (selNode.Tag is string)
                                    if (TODO_todo_Textbox.Values.Contains(selNode.Tag as string))
                                        TODO_todo_Textbox.SelectedItem = TODO_todo_Textbox.Text = selNode.Tag as string;
                                break;
                            case 2:
                                if (selNode.Tag is int?)
                                    Program.WorkingForm.Click_TODO(Enums.todoArgument.loadTodoItem, (selNode.Tag as int?).Value);
                                break;
                        }
                        break;
                    case todoSideRequired://المهام المطلوبة اللي لسا مخلصتش
                    case todoSideRecent:// اخر حاجات تم ادخالها
                        switch (selNode.Level)
                        {
                            case 1:
                                if (selNode.Tag is int?)
                                    Program.WorkingForm.Click_TODO(Enums.todoArgument.loadTodoItem, (selNode.Tag as int?).Value);
                                break;
                        }
                        break;
                    case todoSidePrevious:// كل الحاجات المحتملة لل فيلد ده 
                        switch (selNode.Level)
                        {
                            case 1:
                                if (selNode.Tag is string)
                                    if (focusedTextbox.Values.Contains(selNode.Tag as string))
                                        focusedTextbox.SelectedItem = focusedTextbox.Text = selNode.Tag as string;
                                break;
                        }
                        break;
                    case todoSideSimilar:// ده المفروض اني بشوف كل النسخ الممكنة ع حسب الفيلد برده اللي مختاره واعمل لست للحاجات اللي فيها فروق
                        switch (selNode.Level)
                        {
                            case 1:
                                break;
                            case 2:
                                if (selNode.Tag is string)
                                {
                                    var tempControl = HM_Manager.GetAllControls(AddTodo_Groupbox, typeof(ModdedControls.ModdedTextBox))
                                        .Where(p => HM_Manager.Propertyfromcontrol(p as ModdedControls.ModdedTextBox) == selNode.Parent.Tag as string)
                                        .FirstOrDefault();
                                    ModdedControls.ModdedTextBox propertyTxtbox = tempControl != null ? tempControl as ModdedControls.ModdedTextBox : null;
                                    if (propertyTxtbox != null)
                                        propertyTxtbox.SelectedItem = propertyTxtbox.Text = selNode.Tag as string;
                                }
                                break;
                            case 3:
                                if (selNode.Tag is int?)
                                    Program.WorkingForm.Click_TODO(Enums.todoArgument.loadTodoItem, (selNode.Tag as int?).Value);
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
