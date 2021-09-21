using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Airconditioning.Models
{
    public enum PermissionState
    {
        [Display(Name = "يعمل")]
        يعمل,
        [Display(Name = "ظاهر لكن لا يعمل")]
        لايعمل_ظاهر,
        [Display(Name = "غير ظاهر")]
        غير_ظاهر
    }
    public enum tabs
    {
        [Display(Name = "لوحة المعلومات والتحكم")]
        dashboard,
        [Display(Name = "خدمة العملاء")]
        customerservice,
        [Display(Name = "الصيانة وأوامر الشغل الأخرى")]
        maintenance,
        [Display(Name = "المخازن")]
        warehouse,
        [Display(Name = "التقارير")]
        reports,
        [Display(Name = "الإعدادات")]
        settings,
        [Display(Name = "تبويب الفواتير")]
        invoice
    }
    public static class tabsOptionsHelper
    {
        public static int permsCount = 53;

        public static string values_Seprator = ",";
        public static string dashboardView = "عرض لوحة البيانات والتحكم";
        public static string dashboardHistoryView = "عرض تاريخ العمليات للمستخدمين";

        public static string CS_Client_Tab = "تبويب خدمة العملاء";
        public static string CS_Client_Add = "إضافة عميل";
        public static string CS_Client_Edit = "تعديل عميل";
        public static string CS_Client_View = "عرض عميل";
        public static string CS_Client_Delete = "حذف عميل";
        public static string CS_Installment_Tab = "تبويب الأقساط";
        public static string CS_Installment_Inscribe = "تسجيل أقساط";
        public static string CS_Installment_View = "عرض أقساط";
        public static string CS_Bill_Tab = "تبويب الفواتير";
        public static string CS_Bill_Add = "إضافة فواتير";
        public static string CS_Bill_Edit = "تعديل فواتير";
        public static string CS_Bill_Delete = "حذف فواتير";
        public static string CS_Bill_View = "عرض فواتير";

        public static string WH_main_Tab = "تبويب المخزن";
        public static string WH_warehouse_Add = "إضافة للمخزن";
        public static string WH_warehouse_Edit = "تعديل المخازن";
        public static string WH_warehouse_Delete = "حذف المخازن";
        public static string WH_Search = "تبويب بحث في المخازن ";
        public static string WH_pricelist = "تبويب قائمة الأسعار";

        public static string MTN_Main_Tab = "تبويب إضافة/تعديل الصيانات وأوامر الشغل الأخرى";
        public static string MTN_Main_Add = "إضافة صيانات أو أوامر شغل أخرى";
        public static string MTN_Main_Edit = "تعديل صيانات أو أوامر شغل أخرى";
        public static string MTN_Main_Delete = "حذف صيانات أو أوامر شغل أخرى";
        public static string MTN_Search = "تبويب بحث عن صيانات أو أوامر شغل أخرى";
        public static string MTN_Required = "تبويب صيانات أو أوامر شغل أخرى مطلوبة";

        public static string Reports_Clients = "تبويب تقارير العملاء";
        public static string Reports_Finances = "تبويب تقارير مالية";
        public static string Reports_Storages = "تبويب تقارير المخازن";
        public static string Reports_HRs = "تبويب تقارير الموارد البشرية";

        public static string Settings_HR_Tab = "تبويب الموارد البشرية";
        public static string Settings_HR_Add = "إضافة موارد بشرية";
        public static string Settings_HR_Edit = "تعديل موارد بشرية";
        public static string Settings_HR_Delete = "حذف موارد بشرية";
        public static string Settings_Permission_Edit = "تبويب صلاحيات المستخدمين";
        public static string Settings_Storage_Tab = "تبويب إعدادات المخازن";
        public static string Settings_Storage_Add = "إعدادات المخازن: إضافة مخازن/أجهزة";
        public static string Settings_Storage_Edit = "إعدادات المخازن: تعديل مخازن/أجهزة";
        public static string Settings_Storage_Delete = "إعدادات المخازن: حذف مخازن/أجهزة";
        public static string Settings_Storage_SetPriceList = "إعدادات المخازن: تطبيق قائمة الأسعار";
        public static string Settings_Storage_GetPriceList = "إعدادات المخازن: حفظ قائمة الأسعار ";
        public static string Settings_General_Tab = "تبويب الإعدادات العامة";
        public static string Settings_General_Colortheme = "تعديل الألوان الخاصة بالبرنامج";
        public static string Settings_General_Backup = "نسخ احتياطي";
        public static string Settings_General_Recovery = "استرجاع البيانات من نسخة احتياطية";

        public static string Invoice_Print = "إصدار وطباعة فواتير العملاء";
    }
    public static class permissionsHelper
    {
        public static List<tabPermissionStruct> preparePermissionList()
        {
            List<tabPermissionStruct> permissionslist_Temp = new List<tabPermissionStruct>();
            permissionslist_Temp.Add(new tabPermissionStruct()
            {
                Name = tabs.dashboard,
                optionPermissionStructs = new List<optionPermissionStruct>(){
                        new optionPermissionStruct() { Name = tabsOptionsHelper.dashboardView },
                        new optionPermissionStruct() { Name =tabsOptionsHelper.dashboardHistoryView } }
            });
            permissionslist_Temp.Add(new tabPermissionStruct()
            {
                Name = tabs.customerservice,
                optionPermissionStructs = new List<optionPermissionStruct>(){
                        new optionPermissionStruct() { Name = tabsOptionsHelper.CS_Client_Tab ,
                            optionPermissionStructs = new List<optionPermissionStruct>(){
                                new optionPermissionStruct() { Name = tabsOptionsHelper.CS_Client_Add },
                                new optionPermissionStruct() { Name =tabsOptionsHelper.CS_Client_View },
                                new optionPermissionStruct() { Name = tabsOptionsHelper.CS_Client_Edit },
                                new optionPermissionStruct() { Name =tabsOptionsHelper.CS_Client_Delete } } },
                        new optionPermissionStruct() { Name = tabsOptionsHelper.CS_Installment_Tab ,
                            optionPermissionStructs = new List<optionPermissionStruct>(){
                                new optionPermissionStruct() { Name = tabsOptionsHelper.CS_Installment_Inscribe },
                                new optionPermissionStruct() { Name =tabsOptionsHelper.CS_Installment_View } } },//
                        new optionPermissionStruct() { Name = tabsOptionsHelper.CS_Bill_Tab ,
                            optionPermissionStructs = new List<optionPermissionStruct>(){
                                new optionPermissionStruct() { Name = tabsOptionsHelper.CS_Bill_Add },
                                new optionPermissionStruct() { Name =tabsOptionsHelper.CS_Bill_View },
                                new optionPermissionStruct() { Name = tabsOptionsHelper.CS_Bill_Edit },
                                new optionPermissionStruct() { Name =tabsOptionsHelper.CS_Bill_Delete } } }
                }
            });
            permissionslist_Temp.Add(new tabPermissionStruct()
            {
                Name = tabs.maintenance,
                optionPermissionStructs = new List<optionPermissionStruct>(){
                         new optionPermissionStruct() { Name = tabsOptionsHelper.MTN_Main_Tab ,
                            optionPermissionStructs = new List<optionPermissionStruct>(){
                                new optionPermissionStruct() { Name = tabsOptionsHelper.MTN_Main_Add },
                                new optionPermissionStruct() { Name =tabsOptionsHelper.MTN_Main_Edit },
                                new optionPermissionStruct() { Name = tabsOptionsHelper.MTN_Main_Delete } } },
                        new optionPermissionStruct() { Name =tabsOptionsHelper.MTN_Search },
                        new optionPermissionStruct() { Name = tabsOptionsHelper.MTN_Required } }//
            });
            permissionslist_Temp.Add(new tabPermissionStruct()
            {
                Name = tabs.warehouse,
                optionPermissionStructs = new List<optionPermissionStruct>(){
                        new optionPermissionStruct() { Name = tabsOptionsHelper.WH_main_Tab ,
                            optionPermissionStructs = new List<optionPermissionStruct>(){
                                new optionPermissionStruct() { Name = tabsOptionsHelper.WH_warehouse_Add },
                                new optionPermissionStruct() { Name =tabsOptionsHelper.WH_warehouse_Edit },
                                new optionPermissionStruct() { Name = tabsOptionsHelper.WH_warehouse_Delete } } },
                        new optionPermissionStruct() { Name =tabsOptionsHelper.WH_Search },
                        new optionPermissionStruct() { Name = tabsOptionsHelper.WH_pricelist } }//
            });
            permissionslist_Temp.Add(new tabPermissionStruct()
            {
                Name = tabs.reports,
                optionPermissionStructs = new List<optionPermissionStruct>(){
                        new optionPermissionStruct() { Name = tabsOptionsHelper.Reports_Clients },
                        new optionPermissionStruct() { Name =tabsOptionsHelper.Reports_Finances },
                        new optionPermissionStruct() { Name = tabsOptionsHelper.Reports_Storages },
                        new optionPermissionStruct() { Name =tabsOptionsHelper.Reports_HRs } }
            });
            permissionslist_Temp.Add(new tabPermissionStruct()
            {
                Name = tabs.settings,
                optionPermissionStructs = new List<optionPermissionStruct>(){
                        new optionPermissionStruct() { Name = tabsOptionsHelper.Settings_HR_Tab ,
                            optionPermissionStructs = new List<optionPermissionStruct>(){
                                new optionPermissionStruct() { Name = tabsOptionsHelper.Settings_HR_Add },
                                new optionPermissionStruct() { Name =tabsOptionsHelper.Settings_HR_Edit },
                                new optionPermissionStruct() { Name = tabsOptionsHelper.Settings_HR_Delete } } },
                        new optionPermissionStruct() { Name =tabsOptionsHelper.Settings_Permission_Edit },
                        new optionPermissionStruct() { Name = tabsOptionsHelper.Settings_Storage_Tab ,
                            optionPermissionStructs = new List<optionPermissionStruct>(){
                                new optionPermissionStruct() { Name = tabsOptionsHelper.Settings_Storage_Add },
                                new optionPermissionStruct() { Name =tabsOptionsHelper.Settings_Storage_Edit },
                                new optionPermissionStruct() { Name = tabsOptionsHelper.Settings_Storage_Delete },
                                new optionPermissionStruct() { Name =tabsOptionsHelper.Settings_Storage_GetPriceList },
                                new optionPermissionStruct() { Name = tabsOptionsHelper.Settings_Storage_SetPriceList } } },
                        new optionPermissionStruct() { Name = tabsOptionsHelper.Settings_General_Tab ,
                            optionPermissionStructs = new List<optionPermissionStruct>(){
                                new optionPermissionStruct() { Name =tabsOptionsHelper.Settings_General_Colortheme },
                                new optionPermissionStruct() { Name = tabsOptionsHelper.Settings_General_Backup },
                                new optionPermissionStruct() { Name =tabsOptionsHelper.Settings_General_Recovery } } } }
            });
            permissionslist_Temp.Add(new tabPermissionStruct()
            {
                Name = tabs.invoice,
                optionPermissionStructs = new List<optionPermissionStruct>(){
                                new optionPermissionStruct() { Name =tabsOptionsHelper.Invoice_Print } }
            });
            return permissionslist_Temp;
        }
    }
    ///
    /// <summary>
    /// 6 tabs 
    /// dashboard: 2 tabs View some data, history
    /// customer Service: 3 tabs Clients: Add,View,Edit,Delete    Installment:Inscribe,ViewClient, ViewInstallment    Bills:Add,Edit,Delete,Listview
    /// Warehouse: Add ,edit,delete    ,search       ,pricelist
    /// MTN:Add,Edit,Delete         Required            Search
    /// Reports:4  tabs for clients,finances,storage,HR
    /// Settings:HR,add,edit,delete         Permission      Storage:add,edit,delete,    apply price list, dump pricelist        General: colortheme, backup and recovery
    /// </summary>
    /// 
}
