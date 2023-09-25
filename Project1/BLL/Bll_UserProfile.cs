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
  public class Bll_UserProfile
  {
    DataAccessMethod objdal = new DataAccessMethod();
    public Ent_UserProfile BindTextBox(int MemberId)
    {
      
      try
      {
        using (SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_Bind_MemberDetails", MemberId))
        {
          Ent_UserProfile objent = new Ent_UserProfile();
          while (sdr.Read())
          {
            objent.FullName = sdr["FullName"] as string;
            objent.DateOfBirth = Convert.ToDateTime(sdr["DateOfBirth"]);
            objent.EMail = sdr["EMail"] as string;
            objent.FullAddress = sdr["FullAddress"] as string;
            objent.State = sdr["State"] as string;
            objent.City = sdr["City"] as string;
            objent.AccountStatus = sdr["AccountStatus"] as string;
            objent.UserId = sdr["UserId"] as string;
            objent.Password = sdr["Password"] as string;
            
          }
          return objent;
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
    public List<Ent_UserProfile> BindGrid(int MemberId)
    {
      List<Ent_UserProfile> listent = new List<Ent_UserProfile>();
      try
      {
        using(SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_Bind_MemberIssued", MemberId))
        {
          while (sdr.Read())
          {
            Ent_UserProfile objent = new Ent_UserProfile();
            objent.MemberId = Convert.ToInt32(sdr["MemberId"]);
            objent.FullName = sdr["MemberName"] as string;
            objent.BookId = sdr["BookId"] as string;
            objent.BookName = sdr["BookName"] as string;
            objent.IssueDate = Convert.ToDateTime(sdr["IssueDate"]);
            objent.DueDate = Convert.ToDateTime(sdr["DueDate"]);
            listent.Add(objent);
          }
          return listent;
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
    public int UpdateProfile(Ent_UserProfile ent_User)
    {
      try
      {
        return objdal.UpdateRecord("usp_Update_Member", ent_User.FullName, ent_User.DateOfBirth, ent_User.FullAddress, ent_User.Password, ent_User.MemberId);
      }
      catch (Exception ex)
      {

        throw;
      }
    }
  }
}
