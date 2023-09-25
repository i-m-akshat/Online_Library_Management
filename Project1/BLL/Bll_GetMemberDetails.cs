using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DAL;
using Entity;

namespace BLL
{
  public class Bll_GetMemberDetails
  {
    Ent_GetMemberDetails objentGetMemeberDetails = new Ent_GetMemberDetails();
    DataAccessMethod objdal = new DataAccessMethod();
    public DataTable BindMember(Ent_GetMemberDetails ent_GetMemberDetails)
    {
      return objdal.SelectRecordByDatatable("usp_Show_Member", ent_GetMemberDetails);
    }
    public Ent_GetMemberDetails CheckMember(int MemberId)
    {
      Ent_GetMemberDetails ent_GetMemberDetails = new Ent_GetMemberDetails();
      using (SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_Check_Member", MemberId))
      {
        while (sdr.Read())
        {
          ent_GetMemberDetails.FullName = sdr["FullName"] as string;
          ent_GetMemberDetails.AccountStatus = sdr["AccountStatus"] as string;
          ent_GetMemberDetails.DateOfBirth = Convert.ToDateTime(sdr["DateOfBirth"]);
          ent_GetMemberDetails.ContactNumber = sdr["ContactNumber"] as string;
          ent_GetMemberDetails.EMail = sdr["EMail"] as string;
          ent_GetMemberDetails.State = sdr["State"] as string;
          ent_GetMemberDetails.City = sdr["City"] as string;
          ent_GetMemberDetails.Pincode = sdr["Pincode"] as string;
          ent_GetMemberDetails.FullAddress = sdr["FullAddress"] as string;
        }
        return ent_GetMemberDetails;
      }
    }
    public DataTable GrdCheckMember( Ent_GetMemberDetails ent_GetMemberDetails)
    {
      return objdal.SelectRecordByDatatable("usp_Check_Member", ent_GetMemberDetails.MemberID, ent_GetMemberDetails.FullName, ent_GetMemberDetails.AccountStatus, ent_GetMemberDetails.DateOfBirth, ent_GetMemberDetails.ContactNumber, ent_GetMemberDetails.EMail, ent_GetMemberDetails.State, ent_GetMemberDetails.City, ent_GetMemberDetails.Pincode, ent_GetMemberDetails.FullAddress);
    }
    public int DeleteRow(Ent_GetMemberDetails ent_GetMemberDetails)
    {
      return objdal.DeleteRecord("usp_Delete_Tbl_member", ent_GetMemberDetails.MemberID);
    }
    public int DeactivateStatus(Ent_GetMemberDetails ent_GetMemberDetails)
    {
      return objdal.UpdateRecord("usp_Deactivate_Member", ent_GetMemberDetails.MemberID);
    }
    public int PendingStatus(Ent_GetMemberDetails objent_GetMemberDetails)
    {
      return objdal.UpdateRecord("usp_Pending_Member", objent_GetMemberDetails.MemberID);
    }
    public int ActiveStatus(Ent_GetMemberDetails ent_GetMemberDetails)
    {
      return objdal.UpdateRecord("usp_Activate_Member", ent_GetMemberDetails.MemberID);
    }
  }
}
