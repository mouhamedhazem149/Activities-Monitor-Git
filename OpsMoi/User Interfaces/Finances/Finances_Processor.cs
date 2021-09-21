using OpsMoi.Models;
using OpsMoi.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OpsMoi.User_Interfaces.Finance
{
    public static partial class Finances_Processor
    {
        public static bool HandleFNC(Enums.genericHandle_Type handleType, GroupBox grpbox, string relatedentity, Enums.financeType type, string category, double due,double paid ,DateTime due_date, DateTimePicker done_datePicker, string notes,Label MsgLabel, string Title, Color color, Finances oldModel)
        {
            HM_Manager.Func tobeDone = null;
            DateTime? done_date;
            if (done_datePicker != null && done_datePicker.Checked) done_date = done_datePicker.Value;
            else done_date = null;
            int id = oldModel != null ? oldModel.id : 0;
            Finances _fncNew = new Finances() { id = id, relatedentity = relatedentity,type = type,category= category,due = due,paid = paid,due_date = due_date,done_date = done_date, notes = notes };
            int _id = id;
            string SpecificMsg = "تمت العملية بنجاح"; bool byPass = false;
            switch (handleType)
            {
                case Enums.genericHandle_Type.إضافة:
                    tobeDone = delegate ()
                    {
                        _id = DBHelper.Insert_Database("finances", new List<string> { "relatedentity", "type", "category", "due","paid" ,"duedate", "notes", "donedate" }, new List<Finances> { _fncNew }, HM_Manager.HandleHistory, new string[] { "العمليات المالية", "إضافة مهمة", "" });
                        SpecificMsg = $"تمت الإضافة بنجاح. كود العملية المالية : {_id}";
                    };
                    break;
                case Enums.genericHandle_Type.تعديل:
                    tobeDone = delegate ()
                    {
                        DBHelper.Update_Database("finances", new List<string> { "relatedentity", "type", "category", "due", "paid", "duedate", "notes" , "donedate" }, new List<Finances> { _fncNew }, HM_Manager.HandleHistory, new string[] { "العمليات المالية", "تعديل البيانات", $"الكود الخاص بالعملية: {_id}  المتعلقة ب: {relatedentity}" });
                        SpecificMsg = $"تم التعديل بنجاح. كود العملية المالية : {_id}";
                    };
                    break;
                case Enums.genericHandle_Type.حذف:
                    byPass = true;
                    tobeDone = delegate ()
                    {
                        if (MessageBox.Show($"سيتم حذف العملية المالية الخاصة ب : {oldModel.relatedentity}  تحت تصنيف : {oldModel.category}. هل أنت متأكد ؟", "تحذير", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            DBHelper.Delete_Database("finances", new List<Finances> { oldModel }, HM_Manager.HandleHistory, new string[] { "العمليات المالية", "حذف البيانات", $"الكود الخاص بالعملية: {_id}  المتعلقة ب: {relatedentity}" });
                            SpecificMsg = $"تم التعديل بنجاح. كود العملية المالية : {_id}";
                        }
                    };
                    break;
                case Enums.genericHandle_Type.تحميل_البيانات:
                    byPass = true;
                    tobeDone = delegate () { HM_Manager.SetControlsFromModel(grpbox, oldModel); SpecificMsg = $"تم تحميل البيانات بنجاح. كود العملية : {_id}"; };
                    break;
            }
            return HM_Manager.genericHandler(grpbox, Title, color, oldModel, MsgLabel, tobeDone, ref SpecificMsg, byPass);
        }
    }
}
