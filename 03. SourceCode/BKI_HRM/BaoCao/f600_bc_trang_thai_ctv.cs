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
            ngayKetThuc.GroupInterval = PivotGroupInterval.DateMonth;
           // ngayKetThuc.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            //ngayKetThuc.CellFormat.FormatString = "dd/MM/yyyy";

            //PivotGridField trangThaiHienTai = new PivotGridField("TRANG_THAI_HT_YN", PivotArea.RowArea);
            //trangThaiHienTai.Caption = "Trạng thái hiện tại";

            //PivotGridFieldBase.DefaultDateFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            //PivotGridFieldBase.DefaultDateFormat.FormatString = "dd/MM/yyyy";

            PivotGridFieldBase.DefaultDateFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            PivotGridFieldBase.DefaultDateFormat.FormatString = "dd/MM/yyyy";
            //pivotGridControl1.Fields.AddRange(new PivotGridField[] { tenPhapNhan, maCTV, hoDem, ten, trangThaiHienTai, trangThaiLaoDong, ngayBatDau, ngayKetThuc});
            pivotGridControl1.Fields.AddRange(new PivotGridField[] { tenPhapNhan, ngayBatDau, trangThaiLaoDong, ngayKetThuc});
            pivotGridControl1.OptionsView.ShowColumnTotals = false;
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

            pivotGridControl1.DataSource = m_ds.Tables[0];
        }
        private void set_initial_form_load() {
            m_dat_dau_thang.EditValue = DateTime.Parse("01/01/2014");
            m_dat_cuoi_thang.EditValue = DateTime.Parse("31/12/2014");
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
                
                throw v_e;
            }
        }
    }
}
