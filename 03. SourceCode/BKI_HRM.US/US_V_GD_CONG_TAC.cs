///************************************************
/// Generated by: AnhHT
/// Date: 18/05/2014 09:49:52
/// Goal: Create User Service Class for V_GD_CONG_TAC
///************************************************
/// <summary>
/// Create User Service Class for V_GD_CONG_TAC
/// </summary>

using System;
using BKI_HRM.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_HRM.US
{

    public class US_V_GD_CONG_TAC : US_Object
    {
        private const string c_TableName = "V_GD_CONG_TAC";

        #region "Public Properties"
        public decimal dcID
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID"] = value;
            }
        }

        public bool IsIDNull()
        {
            return pm_objDR.IsNull("ID");
        }

        public void SetIDNull()
        {
            pm_objDR["ID"] = System.Convert.DBNull;
        }

        public decimal dcID_NHAN_SU
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NHAN_SU", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NHAN_SU"] = value;
            }
        }

        public bool IsID_NHAN_SUNull()
        {
            return pm_objDR.IsNull("ID_NHAN_SU");
        }

        public void SetID_NHAN_SUNull()
        {
            pm_objDR["ID_NHAN_SU"] = System.Convert.DBNull;
        }

        public string strMA_NV
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_NV", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_NV"] = value;
            }
        }

        public bool IsMA_NVNull()
        {
            return pm_objDR.IsNull("MA_NV");
        }

        public void SetMA_NVNull()
        {
            pm_objDR["MA_NV"] = System.Convert.DBNull;
        }

        public string strHO_DEM
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "HO_DEM", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["HO_DEM"] = value;
            }
        }

        public bool IsHO_DEMNull()
        {
            return pm_objDR.IsNull("HO_DEM");
        }

        public void SetHO_DEMNull()
        {
            pm_objDR["HO_DEM"] = System.Convert.DBNull;
        }

        public string strTEN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN"] = value;
            }
        }

        public bool IsTENNull()
        {
            return pm_objDR.IsNull("TEN");
        }

        public void SetTENNull()
        {
            pm_objDR["TEN"] = System.Convert.DBNull;
        }

        public decimal dcID_QUYET_DINH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_QUYET_DINH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_QUYET_DINH"] = value;
            }
        }

        public bool IsID_QUYET_DINHNull()
        {
            return pm_objDR.IsNull("ID_QUYET_DINH");
        }

        public void SetID_QUYET_DINHNull()
        {
            pm_objDR["ID_QUYET_DINH"] = System.Convert.DBNull;
        }

        public string strMA_QUYET_DINH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_QUYET_DINH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_QUYET_DINH"] = value;
            }
        }

        public bool IsMA_QUYET_DINHNull()
        {
            return pm_objDR.IsNull("MA_QUYET_DINH");
        }

        public void SetMA_QUYET_DINHNull()
        {
            pm_objDR["MA_QUYET_DINH"] = System.Convert.DBNull;
        }

        public decimal dcID_LOAI_QD
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_QD", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_LOAI_QD"] = value;
            }
        }

        public bool IsID_LOAI_QDNull()
        {
            return pm_objDR.IsNull("ID_LOAI_QD");
        }

        public void SetID_LOAI_QDNull()
        {
            pm_objDR["ID_LOAI_QD"] = System.Convert.DBNull;
        }

        public string strLOAI_QD
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "LOAI_QD", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["LOAI_QD"] = value;
            }
        }

        public bool IsLOAI_QDNull()
        {
            return pm_objDR.IsNull("LOAI_QD");
        }

        public void SetLOAI_QDNull()
        {
            pm_objDR["LOAI_QD"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_CO_HIEU_LUC
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_CO_HIEU_LUC", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_CO_HIEU_LUC"] = value;
            }
        }

        public bool IsNGAY_CO_HIEU_LUCNull()
        {
            return pm_objDR.IsNull("NGAY_CO_HIEU_LUC");
        }

        public void SetNGAY_CO_HIEU_LUCNull()
        {
            pm_objDR["NGAY_CO_HIEU_LUC"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_KY
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_KY", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_KY"] = value;
            }
        }

        public bool IsNGAY_KYNull()
        {
            return pm_objDR.IsNull("NGAY_KY");
        }

        public void SetNGAY_KYNull()
        {
            pm_objDR["NGAY_KY"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_HET_HIEU_LUC
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_HET_HIEU_LUC", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_HET_HIEU_LUC"] = value;
            }
        }

        public bool IsNGAY_HET_HIEU_LUCNull()
        {
            return pm_objDR.IsNull("NGAY_HET_HIEU_LUC");
        }

        public void SetNGAY_HET_HIEU_LUCNull()
        {
            pm_objDR["NGAY_HET_HIEU_LUC"] = System.Convert.DBNull;
        }

        public string strNOI_DUNG
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NOI_DUNG", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NOI_DUNG"] = value;
            }
        }

        public bool IsNOI_DUNGNull()
        {
            return pm_objDR.IsNull("NOI_DUNG");
        }

        public void SetNOI_DUNGNull()
        {
            pm_objDR["NOI_DUNG"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_DI
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_DI", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_DI"] = value;
            }
        }

        public bool IsNGAY_DINull()
        {
            return pm_objDR.IsNull("NGAY_DI");
        }

        public void SetNGAY_DINull()
        {
            pm_objDR["NGAY_DI"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_VE
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_VE", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_VE"] = value;
            }
        }

        public bool IsNGAY_VENull()
        {
            return pm_objDR.IsNull("NGAY_VE");
        }

        public void SetNGAY_VENull()
        {
            pm_objDR["NGAY_VE"] = System.Convert.DBNull;
        }

        public string strDIA_DIEM
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DIA_DIEM", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DIA_DIEM"] = value;
            }
        }

        public bool IsDIA_DIEMNull()
        {
            return pm_objDR.IsNull("DIA_DIEM");
        }

        public void SetDIA_DIEMNull()
        {
            pm_objDR["DIA_DIEM"] = System.Convert.DBNull;
        }

        public string strMO_TA_CONG_VIEC
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MO_TA_CONG_VIEC", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MO_TA_CONG_VIEC"] = value;
            }
        }

        public bool IsMO_TA_CONG_VIECNull()
        {
            return pm_objDR.IsNull("MO_TA_CONG_VIEC");
        }

        public void SetMO_TA_CONG_VIECNull()
        {
            pm_objDR["MO_TA_CONG_VIEC"] = System.Convert.DBNull;
        }

        public string strLUA_CHON
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "LUA_CHON", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["LUA_CHON"] = value;
            }
        }

        public bool IsLUA_CHONNull()
        {
            return pm_objDR.IsNull("LUA_CHON");
        }

        public void SetLUA_CHONNull()
        {
            pm_objDR["LUA_CHON"] = System.Convert.DBNull;
        }

        public string strLINK
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "LINK", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["LINK"] = value;
            }
        }

        public bool IsLINKNull()
        {
            return pm_objDR.IsNull("LINK");
        }

        public void SetLINKNull()
        {
            pm_objDR["LINK"] = System.Convert.DBNull;
        }

        public decimal dcID_PHAP_NHAN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_PHAP_NHAN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_PHAP_NHAN"] = value;
            }
        }

        public bool IsID_PHAP_NHANNull()
        {
            return pm_objDR.IsNull("ID_PHAP_NHAN");
        }

        public void SetID_PHAP_NHANNull()
        {
            pm_objDR["ID_PHAP_NHAN"] = System.Convert.DBNull;
        }

        public string strMA_PHAP_NHAN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_PHAP_NHAN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_PHAP_NHAN"] = value;
            }
        }

        public bool IsMA_PHAP_NHANNull()
        {
            return pm_objDR.IsNull("MA_PHAP_NHAN");
        }

        public void SetMA_PHAP_NHANNull()
        {
            pm_objDR["MA_PHAP_NHAN"] = System.Convert.DBNull;
        }

        public string strTEN_PHAP_NHAN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_PHAP_NHAN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_PHAP_NHAN"] = value;
            }
        }

        public bool IsTEN_PHAP_NHANNull()
        {
            return pm_objDR.IsNull("TEN_PHAP_NHAN");
        }

        public void SetTEN_PHAP_NHANNull()
        {
            pm_objDR["TEN_PHAP_NHAN"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_V_GD_CONG_TAC()
        {
            pm_objDS = new DS_V_GD_CONG_TAC();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_V_GD_CONG_TAC(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_V_GD_CONG_TAC(decimal i_dbID)
        {
            pm_objDS = new DS_V_GD_CONG_TAC();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion

        public void FillDatasetSearch(DS_V_GD_CONG_TAC op_ds
            , string ip_str_search
            , DateTime ip_dat_tu_ngay
            , DateTime ip_dat_den_ngay,
            decimal ip_dc_tim_kiem_theo,
            decimal ip_dc_id_phap_nhan)
        {
            CStoredProc v_store = new CStoredProc("pr_V_GD_CONG_TAC_search");
            v_store.addNVarcharInputParam("@ip_str_search", ip_str_search);
            v_store.addDatetimeInputParam("@tu_ngay", ip_dat_tu_ngay);
            v_store.addDatetimeInputParam("@den_ngay", ip_dat_den_ngay);
            v_store.addDecimalInputParam("@tim_kiem_theo_ngay", ip_dc_tim_kiem_theo);
            v_store.addDecimalInputParam("@id_phap_nhan", ip_dc_id_phap_nhan);
            v_store.fillDataSetByCommand(this, op_ds);
        }

        public void FillDatasetSearchByIdQuyetDinh(DS_V_GD_CONG_TAC op_ds
            , decimal ip_dc_id_quyet_dinh)
        {
            CStoredProc v_store = new CStoredProc("pr_V_GD_CONG_TAC_Select_by_ID_QUYET_DINH");
            v_store.addDecimalInputParam("@ID_QUYET_DINH", ip_dc_id_quyet_dinh);
            v_store.fillDataSetByCommand(this, op_ds);
        }
    }
}
