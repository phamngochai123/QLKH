namespace QLKH_v3.UI
{
    partial class ucQLKhachHang
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
            this.grcKhachHang = new DevExpress.XtraGrid.GridControl();
            this.grvKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelBody = new DevExpress.XtraEditors.PanelControl();
            this.panelheader = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_add_customer = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete_customer = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit_customer = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grcKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).BeginInit();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelheader)).BeginInit();
            this.panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grcKhachHang
            // 
            this.grcKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcKhachHang.Location = new System.Drawing.Point(2, 2);
            this.grcKhachHang.MainView = this.grvKhachHang;
            this.grcKhachHang.Name = "grcKhachHang";
            this.grcKhachHang.Size = new System.Drawing.Size(718, 211);
            this.grcKhachHang.TabIndex = 0;
            this.grcKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvKhachHang});
            // 
            // grvKhachHang
            // 
            this.grvKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.grvKhachHang.GridControl = this.grcKhachHang;
            this.grvKhachHang.Name = "grvKhachHang";
            this.grvKhachHang.OptionsFind.AlwaysVisible = true;
            this.grvKhachHang.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvKhachHang_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Xóa";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Họ tên";
            this.gridColumn2.FieldName = "FullName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "CMND";
            this.gridColumn3.FieldName = "IdCard";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số điện thoại";
            this.gridColumn4.FieldName = "PhoneNumber";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Số gia đình";
            this.gridColumn5.FieldName = "FamilyPhoneNumber";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Số tiền vay";
            this.gridColumn6.FieldName = "Money";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.grcKhachHang);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 203);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(722, 215);
            this.panelBody.TabIndex = 5;
            // 
            // panelheader
            // 
            this.panelheader.Controls.Add(this.groupControl1);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(722, 203);
            this.panelheader.TabIndex = 4;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btn_add_customer);
            this.groupControl1.Controls.Add(this.btn_delete_customer);
            this.groupControl1.Controls.Add(this.btn_edit_customer);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(2, 118);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(718, 83);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Chức năng";
            // 
            // btn_add_customer
            // 
            this.btn_add_customer.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_customer.Appearance.Options.UseFont = true;
            this.btn_add_customer.Location = new System.Drawing.Point(12, 32);
            this.btn_add_customer.Name = "btn_add_customer";
            this.btn_add_customer.Size = new System.Drawing.Size(118, 30);
            this.btn_add_customer.TabIndex = 4;
            this.btn_add_customer.Text = "Thêm khách hàng";
            // 
            // btn_delete_customer
            // 
            this.btn_delete_customer.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_customer.Appearance.Options.UseFont = true;
            this.btn_delete_customer.Location = new System.Drawing.Point(311, 32);
            this.btn_delete_customer.Name = "btn_delete_customer";
            this.btn_delete_customer.Size = new System.Drawing.Size(118, 30);
            this.btn_delete_customer.TabIndex = 6;
            this.btn_delete_customer.Text = "Xóa khách hàng";
            // 
            // btn_edit_customer
            // 
            this.btn_edit_customer.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_customer.Appearance.Options.UseFont = true;
            this.btn_edit_customer.Location = new System.Drawing.Point(161, 32);
            this.btn_edit_customer.Name = "btn_edit_customer";
            this.btn_edit_customer.Size = new System.Drawing.Size(118, 30);
            this.btn_edit_customer.TabIndex = 5;
            this.btn_edit_customer.Text = "Sửa khách hàng";
            // 
            // ucQLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelheader);
            this.Name = "ucQLKhachHang";
            this.Size = new System.Drawing.Size(722, 418);
            ((System.ComponentModel.ISupportInitialize)(this.grcKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).EndInit();
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelheader)).EndInit();
            this.panelheader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView grvKhachHang;
        private DevExpress.XtraEditors.PanelControl panelBody;
        private DevExpress.XtraEditors.PanelControl panelheader;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_add_customer;
        private DevExpress.XtraEditors.SimpleButton btn_delete_customer;
        private DevExpress.XtraEditors.SimpleButton btn_edit_customer;
    }
}
