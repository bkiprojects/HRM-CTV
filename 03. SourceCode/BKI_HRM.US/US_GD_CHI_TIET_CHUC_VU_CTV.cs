///************************************************
/// Generated by: HaiHD
/// Date: 03/06/2015 12:54:20
/// Goal: Create User Service Class for GD_CHI_TIET_CHUC_VU_CTV
///************************************************
/// <summary>
/// Create User Service Class for GD_CHI_TIET_CHUC_VU_CTV
/// </summary>

using System;
using BKI_HRM.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_HRM.US{

public class US_GD_CHI_TIET_CHUC_VU_CTV : US_Object
{
	private const string c_TableName = "GD_CHI_TIET_CHUC_VU_CTV";
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

	public bool IsID_CHUC_VUNull()	{
		return pm_objDR.IsNull("ID_CHUC_VU");
	}

	public void SetID_CHUC_VUNull() {
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

	public bool IsID_DON_VINull()	{
		return pm_objDR.IsNull("ID_DON_VI");
	}

	public void SetID_DON_VINull() {
		pm_objDR["ID_DON_VI"] = System.Convert.DBNull;
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

	public string strTRANG_THAI_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TRANG_THAI_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TRANG_THAI_YN"] = value;
		}
	}

	public bool IsTRANG_THAI_YNNull() 
	{
		return pm_objDR.IsNull("TRANG_THAI_YN");
	}

	public void SetTRANG_THAI_YNNull() {
		pm_objDR["TRANG_THAI_YN"] = System.Convert.DBNull;
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

	public string strPHAN_TRAM_THAM_GIA 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "PHAN_TRAM_THAM_GIA", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["PHAN_TRAM_THAM_GIA"] = value;
		}
	}

	public bool IsPHAN_TRAM_THAM_GIANull() 
	{
		return pm_objDR.IsNull("PHAN_TRAM_THAM_GIA");
	}

	public void SetPHAN_TRAM_THAM_GIANull() {
		pm_objDR["PHAN_TRAM_THAM_GIA"] = System.Convert.DBNull;
	}

	public string strKIEM_NHIEM_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "KIEM_NHIEM_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["KIEM_NHIEM_YN"] = value;
		}
	}

	public bool IsKIEM_NHIEM_YNNull() 
	{
		return pm_objDR.IsNull("KIEM_NHIEM_YN");
	}

	public void SetKIEM_NHIEM_YNNull() {
		pm_objDR["KIEM_NHIEM_YN"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_GD_CHI_TIET_CHUC_VU_CTV() 
	{
		pm_objDS = new DS_GD_CHI_TIET_CHUC_VU_CTV();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_GD_CHI_TIET_CHUC_VU_CTV(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_GD_CHI_TIET_CHUC_VU_CTV(decimal i_dbID) 
	{
		pm_objDS = new DS_GD_CHI_TIET_CHUC_VU_CTV();
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
