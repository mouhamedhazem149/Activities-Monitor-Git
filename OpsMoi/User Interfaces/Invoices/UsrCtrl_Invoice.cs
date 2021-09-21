using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OpsMoi.User_Interfaces.Invoices
{
    public partial class UsrCtrl_Invoice : UserControl
    {
        public UsrCtrl_Invoice(System.Drawing.Color color)
        {
            InitializeComponent();
            this.BackColor = ControlPaint.Light(color, .2f);
            LoadInvoices();
            LinkPermissionsControls(Program.user);
        }

        void LinkPermissionsControls(Models.Employee user)
        {
            user.permissions_List.Where(p => p.Name == Models.tabs.invoice).First().
                optionPermissionStructs.Where(opt => opt.Name == Models.tabsOptionsHelper.Invoice_Print).First().
                control = new List<Control> { InvoiceCount_Button };
            Utilities.HM_Manager.PrepareControlSecurity(Program.user);
        }

        private void LoadInvoices() => Utilities.HM_Manager.Update_OLV(Program.WorkingForm.getInvoice, Invoices_Objectlistview);
        private void InvoiceCount_Button_Click(object sender, EventArgs e) { Program.WorkingForm.Invoice_Issue(Invoice_Label); LoadInvoices(); }

        private void Invoices_Objectlistview_DoubleClick(object sender, EventArgs e) { Program.WorkingForm.RemoveInvoice(((Models.Invoice)Invoices_Objectlistview.SelectedObject).index); LoadInvoices(); }
    }
}
