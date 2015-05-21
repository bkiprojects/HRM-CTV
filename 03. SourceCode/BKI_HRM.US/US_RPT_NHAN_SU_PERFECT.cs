///************************************************
/// Generated by: DucVT
/// Date: 26/11/2014 12:22:04
/// Goal: Create User Service Class for RPT_NHAN_SU_PERFECT
///************************************************
/// <summary>
/// Create User Service Class for RPT_NHAN_SU_PERFECT
/// </summary>

using System;
using BKI_HRM.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_HRM.US
{

    public class US_RPT_NHAN_SU_PERFECT : US_Object
    {
        private const string c_TableName = "RPT_NHAN_SU_PERFECT";
        #region "Public Properties"
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

        public string strDON_VI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DON_VI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DON_VI"] = value;
            }
        }

        public bool IsDON_VINull()
        {
            return pm_objDR.IsNull("DON_VI");
        }

        public void SetDON_VINull()
        {
            pm_objDR["DON_VI"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_SINH
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_SINH", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_SINH"] = value;
            }
        }

        public bool IsNGAY_SINHNull()
        {
            return pm_objDR.IsNull("NGAY_SINH");
        }

        public void SetNGAY_SINHNull()
        {
            pm_objDR["NGAY_SINH"] = System.Convert.DBNull;
        }

        public string strNOI_SINH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NOI_SINH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NOI_SINH"] = value;
            }
        }

        public bool IsNOI_SINHNull()
        {
            return pm_objDR.IsNull("NOI_SINH");
        }

        public void SetNOI_SINHNull()
        {
            pm_objDR["NOI_SINH"] = System.Convert.DBNull;
        }

        public string strGIOI_TINH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "GIOI_TINH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["GIOI_TINH"] = value;
            }
        }

        public bool IsGIOI_TINHNull()
        {
            return pm_objDR.IsNull("GIOI_TINH");
        }

        public void SetGIOI_TINHNull()
        {
            pm_objDR["GIOI_TINH"] = System.Convert.DBNull;
        }

        public string strDI_DONG
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DI_DONG", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DI_DONG"] = value;
            }
        }

        public bool IsDI_DONGNull()
        {
            return pm_objDR.IsNull("DI_DONG");
        }

        public void SetDI_DONGNull()
        {
            pm_objDR["DI_DONG"] = System.Convert.DBNull;
        }

        public string strHO_KHAU
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "HO_KHAU", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["HO_KHAU"] = value;
            }
        }

        public bool IsHO_KHAUNull()
        {
            return pm_objDR.IsNull("HO_KHAU");
        }

        public void SetHO_KHAUNull()
        {
            pm_objDR["HO_KHAU"] = System.Convert.DBNull;
        }

        public string strCHO_O
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "CHO_O", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["CHO_O"] = value;
            }
        }

        public bool IsCHO_ONull()
        {
            return pm_objDR.IsNull("CHO_O");
        }

        public void SetCHO_ONull()
        {
            pm_objDR["CHO_O"] = System.Convert.DBNull;
        }

        public string strMA_CV
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_CV", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_CV"] = value;
            }
        }

        public bool IsMA_CVNull()
        {
            return pm_objDR.IsNull("MA_CV");
        }

        public void SetMA_CVNull()
        {
            pm_objDR["MA_CV"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_BAT_DAU
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_BAT_DAU", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_BAT_DAU"] = value;
            }
        }

        public bool IsNGAY_BAT_DAUNull()
        {
            return pm_objDR.IsNull("NGAY_BAT_DAU");
        }

        public void SetNGAY_BAT_DAUNull()
        {
            pm_objDR["NGAY_BAT_DAU"] = System.Convert.DBNull;
        }

        public string strCMND
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "CMND", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["CMND"] = value;
            }
        }

        public bool IsCMNDNull()
        {
            return pm_objDR.IsNull("CMND");
        }

        public void SetCMNDNull()
        {
            pm_objDR["CMND"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_CAP_CMND
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_CAP_CMND", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_CAP_CMND"] = value;
            }
        }

        public bool IsNGAY_CAP_CMNDNull()
        {
            return pm_objDR.IsNull("NGAY_CAP_CMND");
        }

        public void SetNGAY_CAP_CMNDNull()
        {
            pm_objDR["NGAY_CAP_CMND"] = System.Convert.DBNull;
        }

        public string strNOI_CAP_CMND
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NOI_CAP_CMND", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NOI_CAP_CMND"] = value;
            }
        }

        public bool IsNOI_CAP_CMNDNull()
        {
            return pm_objDR.IsNull("NOI_CAP_CMND");
        }

        public void SetNOI_CAP_CMNDNull()
        {
            pm_objDR["NOI_CAP_CMND"] = System.Convert.DBNull;
        }

        public string strEMAIL_CA_NHAN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "EMAIL_CA_NHAN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["EMAIL_CA_NHAN"] = value;
            }
        }

        public bool IsEMAIL_CA_NHANNull()
        {
            return pm_objDR.IsNull("EMAIL_CA_NHAN");
        }

        public void SetEMAIL_CA_NHANNull()
        {
            pm_objDR["EMAIL_CA_NHAN"] = System.Convert.DBNull;
        }

        public string strDT_NHA
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DT_NHA", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DT_NHA"] = value;
            }
        }

        public bool IsDT_NHANull()
        {
            return pm_objDR.IsNull("DT_NHA");
        }

        public void SetDT_NHANull()
        {
            pm_objDR["DT_NHA"] = System.Convert.DBNull;
        }

        public string strTINH_TRANG_SUC_KHOE
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TINH_TRANG_SUC_KHOE", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TINH_TRANG_SUC_KHOE"] = value;
            }
        }

        public bool IsTINH_TRANG_SUC_KHOENull()
        {
            return pm_objDR.IsNull("TINH_TRANG_SUC_KHOE");
        }

        public void SetTINH_TRANG_SUC_KHOENull()
        {
            pm_objDR["TINH_TRANG_SUC_KHOE"] = System.Convert.DBNull;
        }

        public string strSO_TAI_KHOAN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SO_TAI_KHOAN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SO_TAI_KHOAN"] = value;
            }
        }

        public bool IsSO_TAI_KHOANNull()
        {
            return pm_objDR.IsNull("SO_TAI_KHOAN");
        }

        public void SetSO_TAI_KHOANNull()
        {
            pm_objDR["SO_TAI_KHOAN"] = System.Convert.DBNull;
        }

        public string strCHI_NHANH_NGANHANG
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "CHI_NHANH_NGANHANG", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["CHI_NHANH_NGANHANG"] = value;
            }
        }

        public bool IsCHI_NHANH_NGANHANGNull()
        {
            return pm_objDR.IsNull("CHI_NHANH_NGANHANG");
        }

        public void SetCHI_NHANH_NGANHANGNull()
        {
            pm_objDR["CHI_NHANH_NGANHANG"] = System.Convert.DBNull;
        }

        public string strMA_SO_THUE
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_SO_THUE", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_SO_THUE"] = value;
            }
        }

        public bool IsMA_SO_THUENull()
        {
            return pm_objDR.IsNull("MA_SO_THUE");
        }

        public void SetMA_SO_THUENull()
        {
            pm_objDR["MA_SO_THUE"] = System.Convert.DBNull;
        }

        public string strSO_SO_BHXH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SO_SO_BHXH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SO_SO_BHXH"] = value;
            }
        }

        public bool IsSO_SO_BHXHNull()
        {
            return pm_objDR.IsNull("SO_SO_BHXH");
        }

        public void SetSO_SO_BHXHNull()
        {
            pm_objDR["SO_SO_BHXH"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_CAP_SO_BHXH
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_CAP_SO_BHXH", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_CAP_SO_BHXH"] = value;
            }
        }

        public bool IsNGAY_CAP_SO_BHXHNull()
        {
            return pm_objDR.IsNull("NGAY_CAP_SO_BHXH");
        }

        public void SetNGAY_CAP_SO_BHXHNull()
        {
            pm_objDR["NGAY_CAP_SO_BHXH"] = System.Convert.DBNull;
        }

        public string strSO_THE_BHYT
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SO_THE_BHYT", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SO_THE_BHYT"] = value;
            }
        }

        public bool IsSO_THE_BHYTNull()
        {
            return pm_objDR.IsNull("SO_THE_BHYT");
        }

        public void SetSO_THE_BHYTNull()
        {
            pm_objDR["SO_THE_BHYT"] = System.Convert.DBNull;
        }

        public string strMA_CHAM_CONG
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_CHAM_CONG", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_CHAM_CONG"] = value;
            }
        }

        public bool IsMA_CHAM_CONGNull()
        {
            return pm_objDR.IsNull("MA_CHAM_CONG");
        }

        public void SetMA_CHAM_CONGNull()
        {
            pm_objDR["MA_CHAM_CONG"] = System.Convert.DBNull;
        }

        public decimal dcLUONG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "LUONG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["LUONG"] = value;
            }
        }

        public bool IsLUONGNull()
        {
            return pm_objDR.IsNull("LUONG");
        }

        public void SetLUONGNull()
        {
            pm_objDR["LUONG"] = System.Convert.DBNull;
        }

        public string strLUONG_DONG_BHXH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "LUONG_DONG_BHXH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["LUONG_DONG_BHXH"] = value;
            }
        }

        public bool IsLUONG_DONG_BHXHNull()
        {
            return pm_objDR.IsNull("LUONG_DONG_BHXH");
        }

        public void SetLUONG_DONG_BHXHNull()
        {
            pm_objDR["LUONG_DONG_BHXH"] = System.Convert.DBNull;
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

        public string strMA_HOP_DONG
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_HOP_DONG", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_HOP_DONG"] = value;
            }
        }

        public bool IsMA_HOP_DONGNull()
        {
            return pm_objDR.IsNull("MA_HOP_DONG");
        }

        public void SetMA_HOP_DONGNull()
        {
            pm_objDR["MA_HOP_DONG"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_KY_HOP_DONG
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_KY_HOP_DONG", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_KY_HOP_DONG"] = value;
            }
        }

        public bool IsNGAY_KY_HOP_DONGNull()
        {
            return pm_objDR.IsNull("NGAY_KY_HOP_DONG");
        }

        public void SetNGAY_KY_HOP_DONGNull()
        {
            pm_objDR["NGAY_KY_HOP_DONG"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_BAT_DAU_HOP_DONG
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_BAT_DAU_HOP_DONG", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_BAT_DAU_HOP_DONG"] = value;
            }
        }

        public bool IsNGAY_BAT_DAU_HOP_DONGNull()
        {
            return pm_objDR.IsNull("NGAY_BAT_DAU_HOP_DONG");
        }

        public void SetNGAY_BAT_DAU_HOP_DONGNull()
        {
            pm_objDR["NGAY_BAT_DAU_HOP_DONG"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_KET_THUC_HOP_DONG
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_KET_THUC_HOP_DONG", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_KET_THUC_HOP_DONG"] = value;
            }
        }

        public bool IsNGAY_KET_THUC_HOP_DONGNull()
        {
            return pm_objDR.IsNull("NGAY_KET_THUC_HOP_DONG");
        }

        public void SetNGAY_KET_THUC_HOP_DONGNull()
        {
            pm_objDR["NGAY_KET_THUC_HOP_DONG"] = System.Convert.DBNull;
        }

        public string strQUOC_TICH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "QUOC_TICH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["QUOC_TICH"] = value;
            }
        }

        public bool IsQUOC_TICHNull()
        {
            return pm_objDR.IsNull("QUOC_TICH");
        }

        public void SetQUOC_TICHNull()
        {
            pm_objDR["QUOC_TICH"] = System.Convert.DBNull;
        }

        public string strDAN_TOC
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DAN_TOC", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DAN_TOC"] = value;
            }
        }

        public bool IsDAN_TOCNull()
        {
            return pm_objDR.IsNull("DAN_TOC");
        }

        public void SetDAN_TOCNull()
        {
            pm_objDR["DAN_TOC"] = System.Convert.DBNull;
        }

        public string strTON_GIAO
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TON_GIAO", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TON_GIAO"] = value;
            }
        }

        public bool IsTON_GIAONull()
        {
            return pm_objDR.IsNull("TON_GIAO");
        }

        public void SetTON_GIAONull()
        {
            pm_objDR["TON_GIAO"] = System.Convert.DBNull;
        }

        public string strTRINH_DO
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TRINH_DO", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TRINH_DO"] = value;
            }
        }

        public bool IsTRINH_DONull()
        {
            return pm_objDR.IsNull("TRINH_DO");
        }

        public void SetTRINH_DONull()
        {
            pm_objDR["TRINH_DO"] = System.Convert.DBNull;
        }

        public string strNGOAI_NGU
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NGOAI_NGU", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NGOAI_NGU"] = value;
            }
        }

        public bool IsNGOAI_NGUNull()
        {
            return pm_objDR.IsNull("NGOAI_NGU");
        }

        public void SetNGOAI_NGUNull()
        {
            pm_objDR["NGOAI_NGU"] = System.Convert.DBNull;
        }

        public string strTIN_HOC
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TIN_HOC", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TIN_HOC"] = value;
            }
        }

        public bool IsTIN_HOCNull()
        {
            return pm_objDR.IsNull("TIN_HOC");
        }

        public void SetTIN_HOCNull()
        {
            pm_objDR["TIN_HOC"] = System.Convert.DBNull;
        }

        public string strCHUYEN_NGANH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "CHUYEN_NGANH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["CHUYEN_NGANH"] = value;
            }
        }

        public bool IsCHUYEN_NGANHNull()
        {
            return pm_objDR.IsNull("CHUYEN_NGANH");
        }

        public void SetCHUYEN_NGANHNull()
        {
            pm_objDR["CHUYEN_NGANH"] = System.Convert.DBNull;
        }

        public string strNOI_DAO_TAO
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NOI_DAO_TAO", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NOI_DAO_TAO"] = value;
            }
        }

        public bool IsNOI_DAO_TAONull()
        {
            return pm_objDR.IsNull("NOI_DAO_TAO");
        }

        public void SetNOI_DAO_TAONull()
        {
            pm_objDR["NOI_DAO_TAO"] = System.Convert.DBNull;
        }

        public string strSKYPE
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SKYPE", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SKYPE"] = value;
            }
        }

        public bool IsSKYPENull()
        {
            return pm_objDR.IsNull("SKYPE");
        }

        public void SetSKYPENull()
        {
            pm_objDR["SKYPE"] = System.Convert.DBNull;
        }

        public string strYAHOO
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "YAHOO", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["YAHOO"] = value;
            }
        }

        public bool IsYAHOONull()
        {
            return pm_objDR.IsNull("YAHOO");
        }

        public void SetYAHOONull()
        {
            pm_objDR["YAHOO"] = System.Convert.DBNull;
        }

        public string strFACEBOOK
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "FACEBOOK", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["FACEBOOK"] = value;
            }
        }

        public bool IsFACEBOOKNull()
        {
            return pm_objDR.IsNull("FACEBOOK");
        }

        public void SetFACEBOOKNull()
        {
            pm_objDR["FACEBOOK"] = System.Convert.DBNull;
        }

        public string strTRANG_THAI_LAM_VIEC
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TRANG_THAI_LAM_VIEC", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TRANG_THAI_LAM_VIEC"] = value;
            }
        }

        public bool IsTRANG_THAI_LAM_VIECNull()
        {
            return pm_objDR.IsNull("TRANG_THAI_LAM_VIEC");
        }

        public void SetTRANG_THAI_LAM_VIECNull()
        {
            pm_objDR["TRANG_THAI_LAM_VIEC"] = System.Convert.DBNull;
        }

        public string strGHI_CHU
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "GHI_CHU", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["GHI_CHU"] = value;
            }
        }

        public bool IsGHI_CHUNull()
        {
            return pm_objDR.IsNull("GHI_CHU");
        }

        public void SetGHI_CHUNull()
        {
            pm_objDR["GHI_CHU"] = System.Convert.DBNull;
        }

        public string strCAP
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "CAP", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["CAP"] = value;
            }
        }

        public bool IsCAPNull()
        {
            return pm_objDR.IsNull("CAP");
        }

        public void SetCAPNull()
        {
            pm_objDR["CAP"] = System.Convert.DBNull;
        }

        public string strBAC
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "BAC", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["BAC"] = value;
            }
        }

        public bool IsBACNull()
        {
            return pm_objDR.IsNull("BAC");
        }

        public void SetBACNull()
        {
            pm_objDR["BAC"] = System.Convert.DBNull;
        }

        public string strBO_PHAN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "BO_PHAN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["BO_PHAN"] = value;
            }
        }

        public bool IsBO_PHANNull()
        {
            return pm_objDR.IsNull("BO_PHAN");
        }

        public void SetBO_PHANNull()
        {
            pm_objDR["BO_PHAN"] = System.Convert.DBNull;
        }

        public string strDU_AN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "DU_AN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["DU_AN"] = value;
            }
        }

        public bool IsDU_ANNull()
        {
            return pm_objDR.IsNull("DU_AN");
        }

        public void SetDU_ANNull()
        {
            pm_objDR["DU_AN"] = System.Convert.DBNull;
        }

        public decimal dcTY_LE_THAM_GIA
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TY_LE_THAM_GIA", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TY_LE_THAM_GIA"] = value;
            }
        }

        public bool IsTY_LE_THAM_GIANull()
        {
            return pm_objDR.IsNull("TY_LE_THAM_GIA");
        }

        public void SetTY_LE_THAM_GIANull()
        {
            pm_objDR["TY_LE_THAM_GIA"] = System.Convert.DBNull;
        }

        public string strCHINH_THUC
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "CHINH_THUC", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["CHINH_THUC"] = value;
            }
        }

        public bool IsCHINH_THUCNull()
        {
            return pm_objDR.IsNull("CHINH_THUC");
        }

        public void SetCHINH_THUCNull()
        {
            pm_objDR["CHINH_THUC"] = System.Convert.DBNull;
        }

        public string strTRANG_THAI_PHU
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TRANG_THAI_PHU", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TRANG_THAI_PHU"] = value;
            }
        }

        public bool IsTRANG_THAI_PHUNull()
        {
            return pm_objDR.IsNull("TRANG_THAI_PHU");
        }

        public void SetTRANG_THAI_PHUNull()
        {
            pm_objDR["TRANG_THAI_PHU"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_RPT_NHAN_SU_PERFECT()
        {
            pm_objDS = new DS_RPT_NHAN_SU_PERFECT();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_RPT_NHAN_SU_PERFECT(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_RPT_NHAN_SU_PERFECT(decimal i_dbID)
        {
            pm_objDS = new DS_RPT_NHAN_SU_PERFECT();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion


        public void FillDataset(DS_RPT_NHAN_SU_PERFECT op_ds, decimal ip_id_phap_nhan, DateTime ip_thoi_diem)
        {
            CStoredProc v_sp = new CStoredProc("pr_RPT_NHAN_SU_PERFECT_FillData");
            v_sp.addDecimalInputParam("@ip_id_phap_nhan", ip_id_phap_nhan);
            v_sp.addDatetimeInputParam("@ip_thoi_diem", ip_thoi_diem);
            v_sp.fillDataSetByCommand(this, op_ds);
        }
    }
}
