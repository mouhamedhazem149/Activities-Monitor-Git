
namespace OpsMoi.User_Interfaces.Invoices
{
    partial class UsrCtrl_Invoice
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Invoices_Objectlistview = new BrightIdeasSoftware.ObjectListView();
            this.indexColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.nameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.addressColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.phonenumberColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.dateColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.categoryColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.serialColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.modelColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.InvoiceCount_Button = new System.Windows.Forms.Button();
            this.Invoice_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Invoices_Objectlistview)).BeginInit();
            this.SuspendLayout();
            // 
            // Invoices_Objectlistview
            // 
            this.Invoices_Objectlistview.AllColumns.Add(this.indexColumn);
            this.Invoices_Objectlistview.AllColumns.Add(this.nameColumn);
            this.Invoices_Objectlistview.AllColumns.Add(this.addressColumn);
            this.Invoices_Objectlistview.AllColumns.Add(this.phonenumberColumn);
            this.Invoices_Objectlistview.AllColumns.Add(this.dateColumn);
            this.Invoices_Objectlistview.AllColumns.Add(this.categoryColumn);
            this.Invoices_Objectlistview.AllColumns.Add(this.serialColumn);
            this.Invoices_Objectlistview.AllColumns.Add(this.modelColumn);
            this.Invoices_Objectlistview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Invoices_Objectlistview.CellEditUseWholeCell = false;
            this.Invoices_Objectlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.indexColumn,
            this.nameColumn,
            this.addressColumn,
            this.phonenumberColumn,
            this.dateColumn,
            this.categoryColumn,
            this.serialColumn,
            this.modelColumn});
            this.Invoices_Objectlistview.Cursor = System.Windows.Forms.Cursors.Default;
            this.Invoices_Objectlistview.Font = new System.Drawing.Font("El Messiri", 6.8F);
            this.Invoices_Objectlistview.FullRowSelect = true;
            this.Invoices_Objectlistview.HideSelection = false;
            this.Invoices_Objectlistview.Location = new System.Drawing.Point(3, 4);
            this.Invoices_Objectlistview.Name = "Invoices_Objectlistview";
            this.Invoices_Objectlistview.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Invoices_Objectlistview.RightToLeftLayout = true;
            this.Invoices_Objectlistview.Size = new System.Drawing.Size(544, 191);
            this.Invoices_Objectlistview.TabIndex = 0;
            this.Invoices_Objectlistview.UseCompatibleStateImageBehavior = false;
            this.Invoices_Objectlistview.View = System.Windows.Forms.View.Details;
            this.Invoices_Objectlistview.DoubleClick += new System.EventHandler(this.Invoices_Objectlistview_DoubleClick);
            // 
            // indexColumn
            // 
            this.indexColumn.AspectName = "index";
            this.indexColumn.MinimumWidth = 65;
            this.indexColumn.Text = "رقم الفاتورة";
            this.indexColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.indexColumn.Width = 70;
            // 
            // nameColumn
            // 
            this.nameColumn.AspectName = "clientName";
            this.nameColumn.MinimumWidth = 120;
            this.nameColumn.Text = "اسم العميل";
            this.nameColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameColumn.Width = 120;
            // 
            // addressColumn
            // 
            this.addressColumn.AspectName = "address";
            this.addressColumn.MinimumWidth = 100;
            this.addressColumn.Text = "العنوان";
            this.addressColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addressColumn.Width = 100;
            // 
            // phonenumberColumn
            // 
            this.phonenumberColumn.AspectName = "phonenumber";
            this.phonenumberColumn.MinimumWidth = 80;
            this.phonenumberColumn.Text = "رقم الموبايل";
            this.phonenumberColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phonenumberColumn.Width = 80;
            // 
            // dateColumn
            // 
            this.dateColumn.AspectName = "date";
            this.dateColumn.AspectToStringFormat = "{0:dddd, dd-MMMM-yyyy}";
            this.dateColumn.MinimumWidth = 100;
            this.dateColumn.Text = "التاريخ";
            this.dateColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateColumn.Width = 100;
            // 
            // categoryColumn
            // 
            this.categoryColumn.AspectName = "category";
            this.categoryColumn.MinimumWidth = 80;
            this.categoryColumn.Text = "التصنيف";
            this.categoryColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.categoryColumn.Width = 80;
            // 
            // serialColumn
            // 
            this.serialColumn.AspectName = "unitSerial";
            this.serialColumn.MinimumWidth = 100;
            this.serialColumn.Text = "السيريال";
            this.serialColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.serialColumn.Width = 100;
            // 
            // modelColumn
            // 
            this.modelColumn.AspectName = "unitModel";
            this.modelColumn.MinimumWidth = 80;
            this.modelColumn.Text = "الموديل";
            this.modelColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.modelColumn.Width = 80;
            // 
            // InvoiceCount_Button
            // 
            this.InvoiceCount_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InvoiceCount_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.InvoiceCount_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InvoiceCount_Button.Font = new System.Drawing.Font("El Messiri", 8.8F);
            this.InvoiceCount_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.InvoiceCount_Button.Location = new System.Drawing.Point(5, 199);
            this.InvoiceCount_Button.Name = "InvoiceCount_Button";
            this.InvoiceCount_Button.Size = new System.Drawing.Size(91, 30);
            this.InvoiceCount_Button.TabIndex = 448;
            this.InvoiceCount_Button.Text = "طباعة";
            this.InvoiceCount_Button.UseVisualStyleBackColor = false;
            this.InvoiceCount_Button.Click += new System.EventHandler(this.InvoiceCount_Button_Click);
            // 
            // Invoice_Label
            // 
            this.Invoice_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Invoice_Label.Font = new System.Drawing.Font("El Messiri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invoice_Label.ForeColor = System.Drawing.Color.Maroon;
            this.Invoice_Label.Location = new System.Drawing.Point(112, 202);
            this.Invoice_Label.Name = "Invoice_Label";
            this.Invoice_Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Invoice_Label.Size = new System.Drawing.Size(428, 23);
            this.Invoice_Label.TabIndex = 449;
            this.Invoice_Label.Text = "label1";
            this.Invoice_Label.Visible = false;
            // 
            // UsrCtrl_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Invoice_Label);
            this.Controls.Add(this.InvoiceCount_Button);
            this.Controls.Add(this.Invoices_Objectlistview);
            this.Name = "UsrCtrl_Invoice";
            this.Size = new System.Drawing.Size(550, 234);
            ((System.ComponentModel.ISupportInitialize)(this.Invoices_Objectlistview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView Invoices_Objectlistview;
        private System.Windows.Forms.Button InvoiceCount_Button;
        private BrightIdeasSoftware.OLVColumn indexColumn;
        private BrightIdeasSoftware.OLVColumn nameColumn;
        private BrightIdeasSoftware.OLVColumn addressColumn;
        private BrightIdeasSoftware.OLVColumn phonenumberColumn;
        private BrightIdeasSoftware.OLVColumn dateColumn;
        private BrightIdeasSoftware.OLVColumn categoryColumn;
        private BrightIdeasSoftware.OLVColumn serialColumn;
        private BrightIdeasSoftware.OLVColumn modelColumn;
        private System.Windows.Forms.Label Invoice_Label;
    }
}
