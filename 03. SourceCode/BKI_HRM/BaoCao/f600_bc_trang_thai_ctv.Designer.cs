namespace BKI_HRM.BaoCao {
    partial class f600_bc_trang_thai_ctv {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_dat_cuoi_thang = new DevExpress.XtraEditors.DateEdit();
            this.m_dat_dau_thang = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_cuoi_thang.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_cuoi_thang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_dau_thang.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_dau_thang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 94);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(770, 387);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.CellDoubleClick += new DevExpress.XtraPivotGrid.PivotCellEventHandler(this.pivotGridControl1_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 481);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_dat_cuoi_thang);
            this.panel2.Controls.Add(this.m_dat_dau_thang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 94);
            this.panel2.TabIndex = 1;
            // 
            // m_dat_cuoi_thang
            // 
            this.m_dat_cuoi_thang.EditValue = null;
            this.m_dat_cuoi_thang.Location = new System.Drawing.Point(313, 22);
            this.m_dat_cuoi_thang.Name = "m_dat_cuoi_thang";
            this.m_dat_cuoi_thang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_cuoi_thang.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_cuoi_thang.Size = new System.Drawing.Size(136, 20);
            this.m_dat_cuoi_thang.TabIndex = 0;
            // 
            // m_dat_dau_thang
            // 
            this.m_dat_dau_thang.EditValue = null;
            this.m_dat_dau_thang.Location = new System.Drawing.Point(114, 22);
            this.m_dat_dau_thang.Name = "m_dat_dau_thang";
            this.m_dat_dau_thang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_dau_thang.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_dau_thang.Size = new System.Drawing.Size(127, 20);
            this.m_dat_dau_thang.TabIndex = 0;
            // 
            // f600_bc_trang_thai_ctv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 481);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f600_bc_trang_thai_ctv";
            this.Text = "F600 - Báo cáo TTLĐ theo CTV";
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_cuoi_thang.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_cuoi_thang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_dau_thang.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_dau_thang.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.DateEdit m_dat_cuoi_thang;
        private DevExpress.XtraEditors.DateEdit m_dat_dau_thang;
    }
}