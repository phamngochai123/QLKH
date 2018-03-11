namespace QLKH_v3.UI
{
    partial class ucQLLaiSuat
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
            this.panelBody = new DevExpress.XtraEditors.PanelControl();
            this.grcLaiSuat = new DevExpress.XtraGrid.GridControl();
            this.grvLaiSuat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelheader = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).BeginInit();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcLaiSuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLaiSuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelheader)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.grcLaiSuat);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 130);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(672, 226);
            this.panelBody.TabIndex = 3;
            // 
            // grcLaiSuat
            // 
            this.grcLaiSuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcLaiSuat.Location = new System.Drawing.Point(2, 2);
            this.grcLaiSuat.MainView = this.grvLaiSuat;
            this.grcLaiSuat.Name = "grcLaiSuat";
            this.grcLaiSuat.Size = new System.Drawing.Size(668, 222);
            this.grcLaiSuat.TabIndex = 0;
            this.grcLaiSuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvLaiSuat});
            // 
            // grvLaiSuat
            // 
            this.grvLaiSuat.GridControl = this.grcLaiSuat;
            this.grvLaiSuat.Name = "grvLaiSuat";
            // 
            // panelheader
            // 
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(672, 130);
            this.panelheader.TabIndex = 2;
            // 
            // ucQLLaiSuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelheader);
            this.Name = "ucQLLaiSuat";
            this.Size = new System.Drawing.Size(672, 356);
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).EndInit();
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcLaiSuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLaiSuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelheader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelBody;
        private DevExpress.XtraGrid.GridControl grcLaiSuat;
        private DevExpress.XtraGrid.Views.Grid.GridView grvLaiSuat;
        private DevExpress.XtraEditors.PanelControl panelheader;
    }
}
