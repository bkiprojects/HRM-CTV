using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_HRM.DS;
using BKI_HRM.US;
using IP.Core.IPUserService;
using IP.Core.IPCommon;

using DevExpress.LookAndFeel;
using DevExpress.XtraPivotGrid;
namespace BKI_HRM.BaoCao {
    public partial class f600_bc_trang_thai_ctv : Form {
        public f600_bc_trang_thai_ctv() {
            InitializeComponent();
            format_controls();
        }

    ///Public Method
    ///


    ///Member
    ///
        DataSet m_ds = new DataSet();

    ///Private Method
    ///
        private void format_controls() {
            set_define_events();
        }


        private void init_pivot_table() {
            //PivotGridField maCTV = new PivotGridField("MA_CTV", PivotArea.RowArea);
            //maCTV.Caption = "Mã CTV";

            //PivotGridField hoDem = new PivotGridField("HO_DEM", PivotArea.RowArea);
            //hoDem.Caption = "Họ tên";

            //PivotGridField ten = new PivotGridField("TEN", PivotArea.RowArea);
            //ten.Caption = "Tên";

            PivotGridField  trangThaiLaoDong= new PivotGridField("TRANG_THAI_LAO_DONG", PivotArea.ColumnArea);
            trangThaiLaoDong.Caption = "Trạng thái LĐ";

            PivotGridField  tenPhapNhan= new PivotGridField("TEN_PHAP_NHAN", PivotArea.RowArea);
            tenPhapNhan.Caption = "Pháp nhân";

            PivotGridField  ngayBatDau = new PivotGridField("NGAY_BAT_DAU_TTLD", PivotArea.ColumnArea);
            ngayBatDau.Caption = "Ngày bắt đầu";
            ngayBatDau.GroupInterval = PivotGroupInterval.DateMonth;
            //ngayBatDau.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            //ngayBatDau.CellFormat.FormatString = "dd/MM/yyyy";

            PivotGridField ngayKetThuc = new PivotGridField("NGAY_KET_THUC_TTLD", PivotArea.DataArea);
            ngayKetThuc.Caption = "Ngày kết thúc";
            ngayKetThuc.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;

            PivotGridField thangBD = new PivotGridField("THANG_BD", PivotArea.ColumnArea);
            thangBD.Caption = "Tháng";

            //ngayKetThuc.GroupInterval = PivotGroupInterval.DateMonth;
           // ngayKetThuc.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            //ngayKetThuc.CellFormat.FormatString = "dd/MM/yyyy";

            //PivotGridField trangThaiHienTai = new PivotGridField("TRANG_THAI_HT_YN", PivotArea.RowArea);
            //trangThaiHienTai.Caption = "Trạng thái hiện tại";

            //PivotGridFieldBase.DefaultDateFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            //PivotGridFieldBase.DefaultDateFormat.FormatString = "dd/MM/yyyy";

            PivotGridFieldBase.DefaultDateFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            PivotGridFieldBase.DefaultDateFormat.FormatString = "dd/MM/yyyy";
            //pivotGridControl1.Fields.AddRange(new PivotGridField[] { tenPhapNhan, maCTV, hoDem, ten, trangThaiHienTai, trangThaiLaoDong, ngayBatDau, ngayKetThuc});
            pivotGridControl1.Fields.AddRange(new PivotGridField[] { tenPhapNhan, thangBD,trangThaiLaoDong, ngayKetThuc});
            pivotGridControl1.OptionsView.ShowColumnTotals = false;
        }


        private void add_column(DataTable v_dt) {
            DateTime BEGIN = m_dat_dau_thang.DateTime.Date;
            DateTime END = m_dat_cuoi_thang.DateTime.Date;
            
            foreach(DataRow v_dr in v_dt.Rows) {
                if(v_dr["NGAY_BAT_DAU_TTLD"] != null && v_dr["NGAY_KET_THUC_TTLD"] != null) {
                    DateTime i_dat_from = DateTime.Parse(v_dr["NGAY_BAT_DAU_TTLD"].ToString());
                    DateTime i_dat_to = DateTime.Parse(v_dr["NGAY_KET_THUC_TTLD"].ToString());

                    if(i_dat_from >= BEGIN && i_dat_from <= END) {
                        if(i_dat_from < i_dat_to) {
                            int khoangCach = 0;
                            if(i_dat_to <= END) {
                                khoangCach = (i_dat_to.Year - i_dat_from.Year) * 12 + i_dat_to.Month - i_dat_from.Month;
                            }
                            else {
                                khoangCach = (END.Year - i_dat_from.Year) * 12 + END.Month - i_dat_from.Month;
                            }
                            for(int i = 1; i <= khoangCach; i++) {
                                DataRow v_dr_insert = v_dr;
                                v_dr_insert["THANG_BD"] = i_dat_from.Month + i;

                                m_ds.Tables[0].ImportRow(v_dr_insert);
                            }
                        }
                    }
                    else if(i_dat_from <= BEGIN && (i_dat_to >= BEGIN && i_dat_to <= END)) {
                        if(i_dat_from < i_dat_to) {
                            int khoangCach = 0;

                            khoangCach = (i_dat_to.Year - BEGIN.Year) * 12 + i_dat_to.Month - BEGIN.Month;

                            for(int i = 1; i <= khoangCach; i++) {
                                DataRow v_dr_insert = v_dr;
                                v_dr_insert["THANG_BD"] = i_dat_from.Month + i;

                                m_ds.Tables[0].ImportRow(v_dr_insert);
                            }
                        }
                    }
                }
            }
        }
        private void load_data_to_grid() {
            m_ds.Clear();
            m_ds.EnforceConstraints = false;
            m_ds.Tables.Add();
            US_DM_CTV v_us = new US_DM_CTV();
            CStoredProc v_csp = new CStoredProc("pr_f600_du_lieu_trang_thai_ctv");
            v_csp.addDatetimeInputParam("@ip_dat_dau_thang", m_dat_dau_thang.EditValue);
            v_csp.addDatetimeInputParam("@ip_dat_cuoi_thang", m_dat_cuoi_thang.EditValue);
            v_csp.fillDataSetByCommand(v_us, m_ds);

            DataTable v_dt = m_ds.Tables[0].Clone();
            foreach(DataRow item in m_ds.Tables[0].Rows) {
                v_dt.ImportRow(item);
            }
            add_column(v_dt);

            pivotGridControl1.DataSource = m_ds.Tables[0];
        }
        private void set_initial_form_load() {
            m_dat_dau_thang.EditValue = DateTime.Parse("01/01/2013");
            m_dat_cuoi_thang.EditValue = DateTime.Parse("31/12/2013");
            init_pivot_table();
            load_data_to_grid();
        }

    ///Event
    ///
        private void set_define_events() {
            this.Load += f600_bc_trang_thai_ctv_Load;

        }

        void f600_bc_trang_thai_ctv_Load(object sender, EventArgs e) {
            try {
                set_initial_form_load();
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void pivotGridControl1_CellDoubleClick(object sender, PivotCellEventArgs e) {
            try {
                f600_de v_frm = new f600_de();
                v_frm.gridControl1.DataSource = e.CreateDrillDownDataSource();
                v_frm.ShowDialog();
                v_frm.Dispose();
            }
            catch(Exception v_e) {
                
                throw v_e;
            }
        }
    }
}
