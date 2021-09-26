using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using OpsMoi.Utilities;

namespace OpsMoi.User_Interfaces.Notes
{
    public static class Notes_Processor
    {
        public static string[] titlesList => Program.Notes_List.Select(not => not.title).ToArray();

        public static bool Handle_Note(Enums.genericHandle_Type handleType, GroupBox grpbox, string title, string note,Label MsgLabel, string Title, Color color, Models.Notes oldModel)
        {
            HM_Manager.Func tobeDone = null;
            int id = oldModel != null ? oldModel.id : 0;
            int _id = id;
            Models.Notes _noteNew = new Models.Notes() {id = _id, title = title, strNote = note };
            string SpecificMsg = "تمت العملية بنجاح"; bool byPass = false;
            switch (handleType)
            {
                case Enums.genericHandle_Type.إضافة:
                    tobeDone = delegate ()
                    {
                        DBHelper.Insert_Database("notes", new List<string> { "title", "note" }, new List<Models.Notes> { _noteNew }, HM_Manager.HandleHistory, new string[] { "الملاحظات", "إضافة ملاحظة", "" });
                        SpecificMsg = $"تمت الإضافة بنجاح. عنوان الملاحظة: {_noteNew.title}";
                    };
                    break;
                case Enums.genericHandle_Type.تعديل:
                    tobeDone = delegate ()
                    {
                        DBHelper.Update_Database("notes", new List<string> { "title", "note" }, new List<Models.Notes> { _noteNew }, HM_Manager.HandleHistory, new string[] { "الملاحظات", "تعديل ملاحظات", $"العنوان الخاص بالمهمة: {_noteNew.title}" });
                        SpecificMsg = $"تم التعديل بنجاح. عنوان الملاحظة: {_noteNew.title}";
                    };
                    break;
                case Enums.genericHandle_Type.حذف:
                    byPass = true;
                    tobeDone = delegate ()
                    {
                        if (MessageBox.Show($"سيتم حذف الملاحظة المعنونة ب : {oldModel.title}. هل أنت متأكد ؟", "تحذير", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            DBHelper.Delete_Database("todos", new List<Models.Notes> { oldModel }, HM_Manager.HandleHistory, new string[] { "الملاحظات", "تعديل ملاحظات", $"العنوان الخاص بالمهمة: {oldModel.title}" });
                            SpecificMsg = $"تم التعديل بنجاح. عنوان الملاحظة: {oldModel.title}";
                        }
                    };
                    break;
                case Enums.genericHandle_Type.تحميل_البيانات:
                    byPass = true;
                    tobeDone = delegate () { HM_Manager.SetControlsFromModel(grpbox, oldModel); SpecificMsg = $"تم تحميل البيانات بنجاح. عنوان الملاحظة: {oldModel.title}"; };
                    break;
            }
            return HM_Manager.genericHandler(grpbox, Title, color, oldModel, MsgLabel, tobeDone, ref SpecificMsg, byPass);
        }
    }
}
