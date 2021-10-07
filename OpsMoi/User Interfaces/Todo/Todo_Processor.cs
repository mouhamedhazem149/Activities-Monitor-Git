using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using OpsMoi.Models;
using OpsMoi.Utilities;

namespace OpsMoi.User_Interfaces
{
    public static class Todo_Processor
    {
        public static bool HandleTODO(Enums.genericHandle_Type handleType, GroupBox grpbox, string duefrom, string dueto, string todo, string category, DateTime startDate, DateTime dueDate,bool done_dateDone, DateTime donDate,DateTime addedDate,double duration, string notes,List<Checkpoint> chkList,Label MsgLabel, string Title, Color color, Todos oldModel ,bool byPass = false)
        {
            HM_Manager.Func tobeDone = null;
            int id = oldModel != null ? oldModel.id : 0;
            DateTime? doneDate;
            if (done_dateDone) doneDate = donDate;
            else doneDate = null;
            Todos _todoNew = new Todos() { id = id, duefrom = duefrom, dueto = dueto, todo = todo, category = category,start_date = startDate, due_date = dueDate, done_date = doneDate, duration = duration, notes = notes, added_date = addedDate,chkpoint_list = chkList };
            int _id = id;
            string SpecificMsg = "تمت العملية بنجاح";
            switch (handleType)
            {
                case Enums.genericHandle_Type.إضافة:
                    tobeDone = delegate ()
                    {
                        _todoNew.added_date = DateTime.Now;
                        _id = DBHelper.Insert_Database("todos", new List<string> { "category", "duefrom", "todo", "dueto", "duedate", "notes", "addeddate", "donedate", "duration","startdate","chklist" }, new List<Todos> { _todoNew }, HM_Manager.HandleHistory, new string[] { "المهام المطلوبة", "إضافة مهمة", "" });
                        SpecificMsg = $"تمت الإضافة بنجاح. كود المهمة : {_id}";
                    };
                    break;
                case Enums.genericHandle_Type.تعديل:
                    tobeDone = delegate ()
                    {
                        DBHelper.Update_Database("todos", new List<string> { "category", "duefrom", "todo", "dueto", "duedate", "donedate", "notes", "addeddate", "duration", "startdate", "chklist" }, new List<Todos> { _todoNew }, HM_Manager.HandleHistory, new string[] { "المهام المطلوبة", "تعديل البيانات", $"الكود الخاص بالمهمة: {_id}  المتعلقة ب: {dueto}" });
                        SpecificMsg = $"تم التعديل بنجاح. كود المهمة : {_id}";
                    };
                    break;
                case Enums.genericHandle_Type.حذف:
                    byPass = true;
                    tobeDone = delegate ()
                    {
                        if (MessageBox.Show($"سيتم حذف المهمة الخاصة ب : {oldModel.dueto}  تحت تصنيف : {oldModel.category}. هل أنت متأكد ؟", "تحذير", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            DBHelper.Delete_Database("todos", new List<Todos> { oldModel }, HM_Manager.HandleHistory, new string[] { "المهام المطلوبة", "حذف البيانات", $"الكود الخاص بالمهمة: {_id}  المتعلقة ب: {dueto}" });
                            SpecificMsg = $"تم التعديل بنجاح. كود المهمة : {_id}";
                        }
                    };
                    break;
                case Enums.genericHandle_Type.تحميل_البيانات:
                    byPass = true;
                    tobeDone = delegate () { HM_Manager.SetControlsFromModel(grpbox, oldModel); SpecificMsg = $"تم تحميل البيانات بنجاح. كود المهمة : {_id}"; };
                    break;
            }
            return HM_Manager.genericHandler(grpbox, Title, color, oldModel, MsgLabel, tobeDone, ref SpecificMsg, byPass);
        }
    }
}