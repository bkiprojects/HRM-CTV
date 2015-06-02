///************************************************
/// Generated by: HaiHD
/// Date: 03/06/2015 12:54:38
/// Goal: Create User Service Class for GD_TRANG_THAI_LAO_DONG_CTV
///************************************************
/// <summary>
/// Create User Service Class for GD_TRANG_THAI_LAO_DONG_CTV
/// </summary>

using System;
using BKI_HRM.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_HRM.US{

public class US_GD_TRANG_THAI_LAO_DONG_CTV : US_Object
{
	private const string c_TableName = "GD_TRANG_THAI_LAO_DONG_CTV";
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

	public bool IsIDNull()	{
		return pm_objDR.IsNull("ID");
	}

	public void SetIDNull() {
		pm_objDR["ID"] = System.Convert.DBNull;
	}

	public decimal dcID_CTV 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_CTV", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_CTV"] = value;
		}
	}

	public bool IsID_CTVNull()	{
		return pm_objDR.IsNull("ID_CTV");
	}

	public void SetID_CTVNull() {
		pm_objDR["ID_CTV"] = System.Convert.DBNull;
	}

	public decimal dcID_TRANG_THAI_LAO_DONG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_TRANG_THAI_LAO_DONG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_TRANG_THAI_LAO_DONG"] = value;
		}
	}

	public bool IsID_TRANG_THAI_LAO_DONGNull()	{
		return pm_objDR.IsNull("ID_TRANG_THAI_LAO_DONG");
	}

	public void SetID_TRANG_THAI_LAO_DONGNull() {
		pm_objDR["ID_TRANG_THAI_LAO_DONG"] = System.Convert.DBNull;
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

	public bool IsID_PHAP_NHANNull()	{
		return pm_objDR.IsNull("ID_PHAP_NHAN");
	}

	public void SetID_PHAP_NHANNull() {
		pm_objDR["ID_PHAP_NHAN"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_BAT_DAU_TTLD
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_BAT_DAU_TTLD", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_BAT_DAU_TTLD"] = value;
		}
	}

	public bool IsNGAY_BAT_DAU_TTLDNull()
	{
		return pm_objDR.IsNull("NGAY_BAT_DAU_TTLD");
	}

	public void SetNGAY_BAT_DAU_TTLDNull()
	{
		pm_objDR["NGAY_BAT_DAU_TTLD"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_KET_THUC_TTLD
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_KET_THUC_TTLD", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_KET_THUC_TTLD"] = value;
		}
	}

	public bool IsNGAY_KET_THUC_TTLDNull()
	{
		return pm_objDR.IsNull("NGAY_KET_THUC_TTLD");
	}

	public void SetNGAY_KET_THUC_TTLDNull()
	{
		pm_objDR["NGAY_KET_THUC_TTLD"] = System.Convert.DBNull;
	}

	public string strTRANG_THAI_HT_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TRANG_THAI_HT_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TRANG_THAI_HT_YN"] = value;
		}
	}

	public bool IsTRANG_THAI_HT_YNNull() 
	{
		return pm_objDR.IsNull("TRANG_THAI_HT_YN");
	}

	public void SetTRANG_THAI_HT_YNNull() {
		pm_objDR["TRANG_THAI_HT_YN"] = System.Convert.DBNull;
	}

	public string strTHOI_GIAN_LAM_VIEC 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "THOI_GIAN_LAM_VIEC", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["THOI_GIAN_LAM_VIEC"] = value;
		}
	}

	public bool IsTHOI_GIAN_LAM_VIECNull() 
	{
		return pm_objDR.IsNull("THOI_GIAN_LAM_VIEC");
	}

	public void SetTHOI_GIAN_LAM_VIECNull() {
		pm_objDR["THOI_GIAN_LAM_VIEC"] = System.Convert.DBNull;
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

	public void SetGHI_CHUNull() {
		pm_objDR["GHI_CHU"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_GD_TRANG_THAI_LAO_DONG_CTV() 
	{
		pm_objDS = new DS_GD_TRANG_THAI_LAO_DONG_CTV();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_GD_TRANG_THAI_LAO_DONG_CTV(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_GD_TRANG_THAI_LAO_DONG_CTV(decimal i_dbID) 
	{
		pm_objDS = new DS_GD_TRANG_THAI_LAO_DONG_CTV();
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