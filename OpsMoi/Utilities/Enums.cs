using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace OpsMoi.Utilities
{
    public struct EnumStruct
    {
        public string displayName { get; set; }
        public string realName { get; set; }
    }
    public static class Enums
    {
        public static System.Drawing.Color addColor = System.Drawing.Color.DarkRed;
        public static System.Drawing.Color modColor = System.Drawing.Color.Blue;
        
        public enum financeType
        {
            دخل,
            مدفوعات
        }

        #region General
        public enum Resolution
        {
            [Display(Name = "1920 x 1080")]
            A_1920x1080,
            [Display(Name = "1366 x 768")]
            B_1366x768,
            [Display(Name = "1280 x 1040")]
            C_1280x1040
        }
        #endregion
       
        #region UserControls
        public enum todoArgument
        {
            none,
            showTodoManager,
            loadTodoItem,
        }
        public enum noteArgument
        {
            none,
            showNoteManager,
            loadNoteItem
        }
        public enum financeArgument
        {
            none,
            showFinanceManager,
            loadFinanceItem
        }
        #endregion
       
        #region Settings
        public enum User_Category
        {
            مدير_البرنامج,
            مسؤول,
            موظف
        }
        public enum employeeType
        {
            فني,
            مستخدم,
            تصنيف_آخر
        }
        public enum genericHandle_Type
        {
            إضافة,
            تعديل,
            حذف,
            تحميل_البيانات
        }
        #endregion
        
        #region Reports
        public enum Span
        {
            سنوي,
            شهري,
            يومي
        }
        public enum clientType
        {
            عملاء_تركيب,
            عملاء_صيانة
        }
        public enum report_tabState
        {
            مهام,
            مالية,
            ملاحظات,
        }
        #endregion
        
        #region ClientHandle
        public enum installmentState
        {
            مدفوع,
            مستحق,
            منتظر
        }
        public enum clientHandle_Type
        {
            تعديل,
            إضافة
        }
        public enum clientpayment_Status
        {
            منتهي,
            غير_منتهي
        }
        public enum installmentsHandle_Type
        {
            تسجيل,
            عرض
        }
        #endregion
        
        #region Models
        #region User_ENUMS
        public enum Permission_Level
        {
            مدير_البرنامج,
            مسؤول,
            موظف
        }
        #endregion
        #region Branch_ENUMS
        public enum Branch_type
        {
            مخزن,
            مبيعات,
            مخزن_مبيعات,
        }
        #endregion
        #region Client_ENUMS
        public enum Payment_type
        {
            كاش,
            قسط
        }
        #endregion
        #region Maintenance_ENUMS
        public enum Maintenance_clientType
        {
            عميل_جديد,
            عميل_حالي
        }
        public enum Maintenance_type
        {
            صيانة_دورية,
            مشكلة,
            أمر_شغل_آخر
        }
        public enum Maintenance_Status
        {
            منتظر,
            تم
        }
        #endregion
        #endregion

        public static string GetDisplayName(this System.Enum enumValue)
        {
            string displayName;
            displayName = enumValue.GetType()
                .GetMember(enumValue.ToString())
                .FirstOrDefault()
                .GetCustomAttribute<DisplayAttribute>()?
                .GetName();
            if (string.IsNullOrEmpty(displayName))
            {
                displayName = enumValue.ToString();
            }
            return displayName;
        }
        public static T GetValueFromName<T>(string name)
        {
            var type = typeof(T);
            if (!type.IsEnum) throw new InvalidOperationException();

            foreach (var field in type.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field,
                    typeof(DisplayAttribute)) as DisplayAttribute;
                if (attribute != null)
                {
                    if (attribute.Name == name)
                    {
                        return (T)field.GetValue(null);
                    }
                }
                else
                {
                    if (field.Name == name)
                        return (T)field.GetValue(null);
                }
            }

            throw new ArgumentOutOfRangeException("name");
        }
    }
}
