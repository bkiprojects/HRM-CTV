///************************************************
/// Generated by: AnhHT
/// Date: 05/03/2014 03:38:55
/// Goal: Create User Service Class for GD_CHI_TIET_CHUC_VU
///************************************************
/// <summary>
/// Create User Service Class for GD_CHI_TIET_CHUC_VU
/// </summary>

using System;
using BKI_HRM.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_HRM.US{

public class US_GD_CHI_TIET_CHUC_VU : US_Object
{
	private const string c_TableName = "GD_CHI_TIET_CHUC_VU";
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

    public decimal dcID_CHUC_VU
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_CHUC_VU", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_CHUC_VU"] = value;
        }
    }

    public bool IsID_CHUC_VUNull()
    {
        return pm_objDR.IsNull("ID_CHUC_VU");
    }

    public void SetID_CHUC_VUNull()
    {
        pm_objDR["ID_CHUC_VU"] = System.Convert.DBNull;
    }

    public decimal dcID_DON_VI
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_DON_VI"] = value;
        }
    }

    public bool IsID_DON_VINull()
    {
        return pm_objDR.IsNull("ID_DON_VI");
    }

    public void SetID_DON_VINull()
    {
        pm_objDR["ID_DON_VI"] = System.Convert.DBNull;
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

    public decimal dcID_QUYET_DINH_MIEN_NHIEM
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_QUYET_DINH_MIEN_NHIEM", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_QUYET_DINH_MIEN_NHIEM"] = value;
        }
    }

    public bool IsID_QUYET_DINH_MIEN_NHIEMNull()
    {
        return pm_objDR.IsNull("ID_QUYET_DINH_MIEN_NHIEM");
    }

    public void SetID_QUYET_DINH_MIEN_NHIEMNull()
    {
        pm_objDR["ID_QUYET_DINH_MIEN_NHIEM"] = System.Convert.DBNull;
    }

    public decimal dcID_LOAI_CV
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_CV", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_LOAI_CV"] = value;
        }
    }

    public bool IsID_LOAI_CVNull()
    {
        return pm_objDR.IsNull("ID_LOAI_CV");
    }

    public void SetID_LOAI_CVNull()
    {
        pm_objDR["ID_LOAI_CV"] = System.Convert.DBNull;
    }

    public string strTRANG_THAI_CV
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TRANG_THAI_CV", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TRANG_THAI_CV"] = value;
        }
    }

    public bool IsTRANG_THAI_CVNull()
    {
        return pm_objDR.IsNull("TRANG_THAI_CV");
    }

    public void SetTRANG_THAI_CVNull()
    {
        pm_objDR["TRANG_THAI_CV"] = System.Convert.DBNull;
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

    public DateTime datNGAY_KET_THUC
    {
        get
        {
            return CNull.RowNVLDate(pm_objDR, "NGAY_KET_THUC", IPConstants.c_DefaultDate);
        }
        set
        {
            pm_objDR["NGAY_KET_THUC"] = value;
        }
    }

    public bool IsNGAY_KET_THUCNull()
    {
        return pm_objDR.IsNull("NGAY_KET_THUC");
    }

    public void SetNGAY_KET_THUCNull()
    {
        pm_objDR["NGAY_KET_THUC"] = System.Convert.DBNull;
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

    #endregion
    #region "Init Functions"
    public US_GD_CHI_TIET_CHUC_VU()
    {
        pm_objDS = new DS_GD_CHI_TIET_CHUC_VU();
        pm_strTableName = c_TableName;
        pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
    }

    public US_GD_CHI_TIET_CHUC_VU(DataRow i_objDR)
        : this()
    {
        this.DataRow2Me(i_objDR);
    }

    public US_GD_CHI_TIET_CHUC_VU(decimal i_dbID)
    {
        pm_objDS = new DS_GD_CHI_TIET_CHUC_VU();
        pm_strTableName = c_TableName;
        IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
        v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
        SqlCommand v_cmdSQL;
        v_cmdSQL = v_objMkCmd.getSelectCmd();
        this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
        pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
    }
    #endregion
	}
}
