///************************************************
/// Generated by: AnhLT
/// Date: 17/03/2014 05:47:44
/// Goal: Create Form for GD_QUA_TRINH_CONG_TAC
///************************************************


using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;
using IP.Core.IPExcelReport;

using BKI_HRM.US;
using BKI_HRM.DS;
using BKI_HRM.DS.CDBNames;

using C1.Win.C1FlexGrid;

namespace BKI_HRM
{



	public class f404_GD_QUA_TRINH_CONG_TAC : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private TextBox m_txt_tim_kiem;
        private CheckBox m_ckb_chucvu;
        private CheckBox m_ckb_capbac;
        private CheckBox m_ckb_duan;
        private Label label1;
        internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
        private GroupBox groupBox1;
        private RadioButton m_rdb_nhom;
        private RadioButton m_rdb_ko_nhom;
        private CheckBox m_ckb_congtac;
        private Label label2;
        private DateTimePicker m_dtp_den_ngay;
        private Label m_lbl_thoidiem;
        private DateTimePicker m_dtp_tu_ngay;
        private Label m_lbl_phim_tat;
        private Panel panel1;
        private C1FlexGrid m_fg;
		private System.ComponentModel.IContainer components;

		public f404_GD_QUA_TRINH_CONG_TAC()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			format_controls();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f404_GD_QUA_TRINH_CONG_TAC));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_lbl_phim_tat = new System.Windows.Forms.Label();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.m_ckb_chucvu = new System.Windows.Forms.CheckBox();
            this.m_ckb_capbac = new System.Windows.Forms.CheckBox();
            this.m_ckb_duan = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_rdb_nhom = new System.Windows.Forms.RadioButton();
            this.m_rdb_ko_nhom = new System.Windows.Forms.RadioButton();
            this.m_ckb_congtac = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_dtp_den_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_lbl_thoidiem = new System.Windows.Forms.Label();
            this.m_dtp_tu_ngay = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_lbl_phim_tat);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xuat_excel);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 586);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(1268, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_lbl_phim_tat
            // 
            this.m_lbl_phim_tat.AutoSize = true;
            this.m_lbl_phim_tat.Location = new System.Drawing.Point(156, 12);
            this.m_lbl_phim_tat.Name = "m_lbl_phim_tat";
            this.m_lbl_phim_tat.Size = new System.Drawing.Size(206, 13);
            this.m_lbl_phim_tat.TabIndex = 1001;
            this.m_lbl_phim_tat.Text = "Phím tắt: F6_Mở rộng-Thu gọn danh sách";
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_xuat_excel.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_xuat_excel.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xuat_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.m_cmd_xuat_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_xuat_excel.ImageIndex = 19;
            this.m_cmd_xuat_excel.ImageList = this.ImageList;
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(93, 28);
            this.m_cmd_xuat_excel.TabIndex = 6;
            this.m_cmd_xuat_excel.Text = "Xuất Excel";
            this.m_cmd_xuat_excel.Click += new System.EventHandler(this.m_cmd_xuat_excel_Click);
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(1176, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 7;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_txt_tim_kiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(218, 17);
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(437, 20);
            this.m_txt_tim_kiem.TabIndex = 1;
            this.m_txt_tim_kiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.m_txt_tim_kiem_MouseClick);
            this.m_txt_tim_kiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_txt_tim_kiem_KeyDown);
            this.m_txt_tim_kiem.Leave += new System.EventHandler(this.m_txt_tim_kiem_Leave);
            // 
            // m_ckb_chucvu
            // 
            this.m_ckb_chucvu.AutoSize = true;
            this.m_ckb_chucvu.Checked = true;
            this.m_ckb_chucvu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_ckb_chucvu.Location = new System.Drawing.Point(270, 43);
            this.m_ckb_chucvu.Name = "m_ckb_chucvu";
            this.m_ckb_chucvu.Size = new System.Drawing.Size(66, 17);
            this.m_ckb_chucvu.TabIndex = 3;
            this.m_ckb_chucvu.Text = "Chức vụ";
            this.m_ckb_chucvu.UseVisualStyleBackColor = true;
            this.m_ckb_chucvu.Visible = false;
            this.m_ckb_chucvu.CheckedChanged += new System.EventHandler(this.m_ckb_chucvu_CheckedChanged);
            // 
            // m_ckb_capbac
            // 
            this.m_ckb_capbac.AutoSize = true;
            this.m_ckb_capbac.Checked = true;
            this.m_ckb_capbac.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_ckb_capbac.Location = new System.Drawing.Point(566, 44);
            this.m_ckb_capbac.Name = "m_ckb_capbac";
            this.m_ckb_capbac.Size = new System.Drawing.Size(66, 17);
            this.m_ckb_capbac.TabIndex = 4;
            this.m_ckb_capbac.Text = "Cấp bậc";
            this.m_ckb_capbac.UseVisualStyleBackColor = true;
            this.m_ckb_capbac.Visible = false;
            this.m_ckb_capbac.CheckedChanged += new System.EventHandler(this.m_ckb_capbac_CheckedChanged);
            // 
            // m_ckb_duan
            // 
            this.m_ckb_duan.AutoSize = true;
            this.m_ckb_duan.Checked = true;
            this.m_ckb_duan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_ckb_duan.Location = new System.Drawing.Point(342, 43);
            this.m_ckb_duan.Name = "m_ckb_duan";
            this.m_ckb_duan.Size = new System.Drawing.Size(55, 17);
            this.m_ckb_duan.TabIndex = 5;
            this.m_ckb_duan.Text = "Dự án";
            this.m_ckb_duan.UseVisualStyleBackColor = true;
            this.m_ckb_duan.Visible = false;
            this.m_ckb_duan.CheckedChanged += new System.EventHandler(this.m_ckb_duan_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Hiển thị:";
            this.label1.Visible = false;
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(661, 12);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 2;
            this.m_cmd_search.Text = "Tìm kiếm";
            this.m_cmd_search.Click += new System.EventHandler(this.m_cmd_search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_rdb_nhom);
            this.groupBox1.Controls.Add(this.m_rdb_ko_nhom);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 65);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị:";
            // 
            // m_rdb_nhom
            // 
            this.m_rdb_nhom.AutoSize = true;
            this.m_rdb_nhom.Location = new System.Drawing.Point(21, 44);
            this.m_rdb_nhom.Name = "m_rdb_nhom";
            this.m_rdb_nhom.Size = new System.Drawing.Size(118, 17);
            this.m_rdb_nhom.TabIndex = 1;
            this.m_rdb_nhom.Text = "Nhóm theo mã CTV";
            this.m_rdb_nhom.UseVisualStyleBackColor = true;
            this.m_rdb_nhom.CheckedChanged += new System.EventHandler(this.m_rdb_nhom_CheckedChanged);
            // 
            // m_rdb_ko_nhom
            // 
            this.m_rdb_ko_nhom.AutoSize = true;
            this.m_rdb_ko_nhom.Checked = true;
            this.m_rdb_ko_nhom.Location = new System.Drawing.Point(21, 20);
            this.m_rdb_ko_nhom.Name = "m_rdb_ko_nhom";
            this.m_rdb_ko_nhom.Size = new System.Drawing.Size(85, 17);
            this.m_rdb_ko_nhom.TabIndex = 0;
            this.m_rdb_ko_nhom.TabStop = true;
            this.m_rdb_ko_nhom.Text = "Không nhóm";
            this.m_rdb_ko_nhom.UseVisualStyleBackColor = true;
            // 
            // m_ckb_congtac
            // 
            this.m_ckb_congtac.AutoSize = true;
            this.m_ckb_congtac.Checked = true;
            this.m_ckb_congtac.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_ckb_congtac.Location = new System.Drawing.Point(403, 43);
            this.m_ckb_congtac.Name = "m_ckb_congtac";
            this.m_ckb_congtac.Size = new System.Drawing.Size(69, 17);
            this.m_ckb_congtac.TabIndex = 41;
            this.m_ckb_congtac.Text = "Công tác";
            this.m_ckb_congtac.UseVisualStyleBackColor = true;
            this.m_ckb_congtac.Visible = false;
            this.m_ckb_congtac.CheckedChanged += new System.EventHandler(this.m_ckb_congtac_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(775, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Đến ngày:";
            // 
            // m_dtp_den_ngay
            // 
            this.m_dtp_den_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dtp_den_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtp_den_ngay.Location = new System.Drawing.Point(837, 38);
            this.m_dtp_den_ngay.Name = "m_dtp_den_ngay";
            this.m_dtp_den_ngay.Size = new System.Drawing.Size(126, 20);
            this.m_dtp_den_ngay.TabIndex = 44;
            this.m_dtp_den_ngay.ValueChanged += new System.EventHandler(this.m_dtp_den_ngay_ValueChanged);
            // 
            // m_lbl_thoidiem
            // 
            this.m_lbl_thoidiem.AutoSize = true;
            this.m_lbl_thoidiem.Location = new System.Drawing.Point(782, 17);
            this.m_lbl_thoidiem.Name = "m_lbl_thoidiem";
            this.m_lbl_thoidiem.Size = new System.Drawing.Size(49, 13);
            this.m_lbl_thoidiem.TabIndex = 43;
            this.m_lbl_thoidiem.Text = "Từ ngày:";
            // 
            // m_dtp_tu_ngay
            // 
            this.m_dtp_tu_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dtp_tu_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtp_tu_ngay.Location = new System.Drawing.Point(837, 12);
            this.m_dtp_tu_ngay.Name = "m_dtp_tu_ngay";
            this.m_dtp_tu_ngay.Size = new System.Drawing.Size(126, 20);
            this.m_dtp_tu_ngay.TabIndex = 42;
            this.m_dtp_tu_ngay.Value = new System.DateTime(2009, 1, 1, 17, 21, 0, 0);
            this.m_dtp_tu_ngay.ValueChanged += new System.EventHandler(this.m_dtp_tu_ngay_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.m_txt_tim_kiem);
            this.panel1.Controls.Add(this.m_dtp_den_ngay);
            this.panel1.Controls.Add(this.m_ckb_chucvu);
            this.panel1.Controls.Add(this.m_lbl_thoidiem);
            this.panel1.Controls.Add(this.m_ckb_capbac);
            this.panel1.Controls.Add(this.m_dtp_tu_ngay);
            this.panel1.Controls.Add(this.m_ckb_duan);
            this.panel1.Controls.Add(this.m_ckb_congtac);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1268, 83);
            this.panel1.TabIndex = 46;
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 83);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(1268, 503);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 47;
            // 
            // f404_GD_QUA_TRINH_CONG_TAC
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.m_cmd_exit;
            this.ClientSize = new System.Drawing.Size(1268, 622);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "f404_GD_QUA_TRINH_CONG_TAC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F404 - Báo cáo quá trình công tác";
            this.Load += new System.EventHandler(this.f404_GD_QUA_TRINH_CONG_TAC_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.m_pnl_out_place_dm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region Public Interface
		public void display(){			
			this.ShowDialog();
		}
        public delegate void close_tab(bool ip_y_n);
        public close_tab close_tab_B;

		#endregion

		#region Data Structure
        private enum e_col_Number
        {
            DEN_NGAY = 5
,
            MA_NV = 1
                ,
            TY_LE_THAM_GIA = 9
                ,
            HO_DEM = 2
                ,
            VAI_TRO = 8
                ,
            TEN = 3
                ,
            TU_NGAY = 4
                ,
            LAM_GI = 6
                ,
            LOAI_QD = 11
                ,
            MA_QUYET_DINH = 10
                ,
            MA_QUYET_DINH_MIEN_NHIEM = 12
                , O_DAU = 7

        }
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_GD_QUA_TRINH_CONG_TAC m_ds = new DS_GD_QUA_TRINH_CONG_TAC();
		US_GD_QUA_TRINH_CONG_TAC m_us = new US_GD_QUA_TRINH_CONG_TAC();
        string m_str_lua_chon = "ABCD";
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201());
			CControlFormat.setC1FlexFormat(m_fg);
			CGridUtils.AddSave_Excel_Handlers(m_fg);
            			CGridUtils.AddSearch_Handlers(m_fg);
                        m_fg.Tree.Column = (int)e_col_Number.MA_NV;
                        m_fg.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.SimpleLeaf;
			set_define_events();
			this.KeyPreview = true;
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
            m_txt_tim_kiem.Text = "";
			load_data_2_grid();
            m_txt_tim_kiem.Text = "Nhập mã cộng tác viên, họ đệm, tên";
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
            v_htb.Add(GD_QUA_TRINH_CONG_TAC.DEN_NGAY, e_col_Number.DEN_NGAY);
            v_htb.Add(GD_QUA_TRINH_CONG_TAC.MA_NV, e_col_Number.MA_NV);
            v_htb.Add(GD_QUA_TRINH_CONG_TAC.TY_LE_THAM_GIA, e_col_Number.TY_LE_THAM_GIA);
            v_htb.Add(GD_QUA_TRINH_CONG_TAC.HO_DEM, e_col_Number.HO_DEM);
            v_htb.Add(GD_QUA_TRINH_CONG_TAC.VAI_TRO, e_col_Number.VAI_TRO);
            v_htb.Add(GD_QUA_TRINH_CONG_TAC.TEN, e_col_Number.TEN);
            v_htb.Add(GD_QUA_TRINH_CONG_TAC.TU_NGAY, e_col_Number.TU_NGAY);
            v_htb.Add(GD_QUA_TRINH_CONG_TAC.LAM_GI, e_col_Number.LAM_GI);
            v_htb.Add(GD_QUA_TRINH_CONG_TAC.LOAI_QD, e_col_Number.LOAI_QD);
            v_htb.Add(GD_QUA_TRINH_CONG_TAC.MA_QUYET_DINH, e_col_Number.MA_QUYET_DINH);
            v_htb.Add(GD_QUA_TRINH_CONG_TAC.MA_QUYET_DINH_MIEN_NHIEM, e_col_Number.MA_QUYET_DINH_MIEN_NHIEM);
            v_htb.Add(GD_QUA_TRINH_CONG_TAC.O_DAU, e_col_Number.O_DAU);
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.GD_QUA_TRINH_CONG_TAC.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_GD_QUA_TRINH_CONG_TAC();			
			m_us.FillDatasetByProc(m_ds,m_txt_tim_kiem.Text.Trim(), m_str_lua_chon, m_dtp_tu_ngay.Value, m_dtp_den_ngay.Value, CAppContext_201.getCurrentIDPhapnhan());
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            if (m_rdb_nhom.Checked == true)
            {
                m_fg.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count
                  , 0
                  , (int)e_col_Number.MA_NV
                  , (int)e_col_Number.HO_DEM
                  , "{0}"
                  );
            }
			m_fg.Redraw = true;
		}
		private void grid2us_object(US_GD_QUA_TRINH_CONG_TAC i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_GD_QUA_TRINH_CONG_TAC i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}
        
		private void view_gd_qua_trinh_cong_tac(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			grid2us_object(m_us, m_fg.Row);
		//	f404_GD_QUA_TRINH_CONG_TAC_DE v_fDE = new f404_GD_QUA_TRINH_CONG_TAC_DE();			
		//	v_fDE.display(m_us);
		}
        private void what_is_checked()
        {
            /*if ((m_ckb_chucvu.Checked) && (m_ckb_capbac.Checked) && (m_ckb_duan.Checked))
                m_str_lua_chon = "D";
            else if ((m_ckb_chucvu.Checked) && (m_ckb_capbac.Checked))
                m_str_lua_chon = "B";
            else if ((m_ckb_chucvu.Checked) && (m_ckb_duan.Checked))
                m_str_lua_chon = "A";
            else if ((m_ckb_capbac.Checked) && (m_ckb_duan.Checked))
                m_str_lua_chon = "C";
            else if ((m_ckb_chucvu.Checked))
                m_str_lua_chon = "ABD";
            else if ((m_ckb_capbac.Checked))
                m_str_lua_chon = "BCD";
            else
                m_str_lua_chon = "CAD"*/
            m_str_lua_chon = "";
            if (m_ckb_chucvu.Checked)
                m_str_lua_chon = String.Concat(m_str_lua_chon,"A");
            /*if (m_ckb_capbac.Checked)
                m_str_lua_chon = String.Concat(m_str_lua_chon, "B");*/
            if (m_ckb_duan.Checked)
                m_str_lua_chon = String.Concat(m_str_lua_chon, "C");
            if (m_ckb_congtac.Checked)
                m_str_lua_chon = String.Concat(m_str_lua_chon, "D");

        }
        private void load_custom_source_2_m_txt_tim_kiem()
        {
            //m_v_us.FillDataset(m_v_ds);
            int count = m_ds.Tables["GD_QUA_TRINH_CONG_TAC"].Rows.Count;
            AutoCompleteStringCollection v_acsc_search = new AutoCompleteStringCollection();
            foreach (DataRow dr in m_ds.GD_QUA_TRINH_CONG_TAC)
            {
                v_acsc_search.Add(dr[GD_QUA_TRINH_CONG_TAC.MA_NV].ToString());
                v_acsc_search.Add(dr[GD_QUA_TRINH_CONG_TAC.TEN].ToString());
                v_acsc_search.Add(dr[GD_QUA_TRINH_CONG_TAC.HO_DEM].ToString());
                v_acsc_search.Add(dr[GD_QUA_TRINH_CONG_TAC.HO_DEM].ToString() + " " + dr[GD_QUA_TRINH_CONG_TAC.TEN].ToString());

            }
            m_txt_tim_kiem.AutoCompleteCustomSource = v_acsc_search;
        }
        private void export_2_excel()
        {
            CExcelReport v_obj_excel_rpt = new CExcelReport("f404_qua_trinh_cong_tac.xlsx", 3, 1);
            v_obj_excel_rpt.FindAndReplace(false);
            v_obj_excel_rpt.Export2ExcelWithoutFixedRows(m_fg, 1, m_fg.Cols.Count - 1, true);
        }

		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
		}
        
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f404_GD_QUA_TRINH_CONG_TAC_Load(object sender, System.EventArgs e) {
			try{
				set_initial_form_load();
                load_custom_source_2_m_txt_tim_kiem();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		
		}

		private void m_cmd_exit_Click(object sender, EventArgs e) {
			try{
                close_tab_B(true);

			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_view_Click(object sender, EventArgs e) {
			try{
				view_gd_qua_trinh_cong_tac();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}
        
        private void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_tim_kiem.Text.Trim() == "Nhập mã cộng tác viên, họ đệm, tên")
                {
                    m_txt_tim_kiem.Text = "";
                    what_is_checked();
                    load_data_2_grid();
                    m_txt_tim_kiem.Text = "Nhập mã cộng tác viên, họ đệm, tên";
                }
                else
                {
                    what_is_checked();
                    load_data_2_grid();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_ckb_chucvu_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                {
                    if (m_txt_tim_kiem.Text.Trim() == "Nhập mã cộng tác viên, họ đệm, tên")
                    {
                        m_txt_tim_kiem.Text = "";
                        what_is_checked();
                        load_data_2_grid();
                        m_txt_tim_kiem.Text = "Nhập mã cộng tác viên, họ đệm, tên";
                    }
                    else
                    {
                        what_is_checked();
                        load_data_2_grid();
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_ckb_capbac_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                {
                    if (m_txt_tim_kiem.Text.Trim() == "Nhập mã cộng tác viên, họ đệm, tên")
                    {
                        m_txt_tim_kiem.Text = "";
                        what_is_checked();
                        load_data_2_grid();
                        m_txt_tim_kiem.Text = "Nhập mã cộng tác viên, họ đệm, tên";
                    }
                    else
                    {
                        what_is_checked();
                        load_data_2_grid();
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_ckb_duan_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                {
                    if (m_txt_tim_kiem.Text.Trim() == "Nhập mã cộng tác viên, họ đệm, tên")
                    {
                        m_txt_tim_kiem.Text = "";
                        what_is_checked();
                        load_data_2_grid();
                        m_txt_tim_kiem.Text = "Nhập mã cộng tác viên, họ đệm, tên";
                    }
                    else
                    {
                        what_is_checked();
                        load_data_2_grid();
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_tim_kiem_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    load_data_2_grid();

                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_txt_tim_kiem_MouseClick(object sender, MouseEventArgs e)
        {
            m_txt_tim_kiem.Text = "";
        }

        private void m_txt_tim_kiem_Leave(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_tim_kiem.Text.Trim() == "")
                    m_txt_tim_kiem.Text = "Nhập mã cộng tác viên, họ đệm, tên";
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                export_2_excel();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_rdb_nhom_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_tim_kiem.Text.Trim() == "Nhập mã cộng tác viên, họ đệm, tên")
                {
                    m_txt_tim_kiem.Text = "";
                    what_is_checked();
                    load_data_2_grid();
                    m_txt_tim_kiem.Text = "Nhập mã cộng tác viên, họ đệm, tên";
                }
                else
                {
                    what_is_checked();
                    load_data_2_grid();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_ckb_congtac_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                {
                    if (m_txt_tim_kiem.Text.Trim() == "Nhập mã cộng tác viên, họ đệm, tên")
                    {
                        m_txt_tim_kiem.Text = "";
                        what_is_checked();
                        load_data_2_grid();
                        m_txt_tim_kiem.Text = "Nhập mã cộng tác viên, họ đệm, tên";
                    }
                    else
                    {
                        what_is_checked();
                        load_data_2_grid();
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_dtp_tu_ngay_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                {
                    if (m_txt_tim_kiem.Text.Trim() == "Nhập mã cộng tác viên, họ đệm, tên")
                    {
                        m_txt_tim_kiem.Text = "";
                        what_is_checked();
                        load_data_2_grid();
                        m_txt_tim_kiem.Text = "Nhập mã cộng tác viên, họ đệm, tên";
                    }
                    else
                    {
                        what_is_checked();
                        load_data_2_grid();
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_dtp_den_ngay_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                {
                    if (m_txt_tim_kiem.Text.Trim() == "Nhập mã cộng tác viên, họ đệm, tên")
                    {
                        m_txt_tim_kiem.Text = "";
                        what_is_checked();
                        load_data_2_grid();
                        m_txt_tim_kiem.Text = "Nhập mã cộng tác viên, họ đệm, tên";
                    }
                    else
                    {
                        what_is_checked();
                        load_data_2_grid();
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

     
	}
}

