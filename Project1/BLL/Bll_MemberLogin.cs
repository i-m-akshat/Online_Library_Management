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
  public class Bll_MemberLogin
  {
    DataAccessMethod objDAL = new DataAccessMethod();
    public Ent_GetLoginDetails MemberLogin(string userid, string password)
    {
      Ent_GetLoginDetails entdetail = new Ent_GetLoginDetails();
      try
      {
        using (SqlDataReader sdr = objDAL.SelectRecordBydataReader("usp_User_Login", userid, password))
        {
          while (sdr.Read())
          {
            entdetail.FullName = sdr["FullName"].ToString();
            entdetail.MemberId = Convert.ToInt32(sdr["MemberId"].ToString());
          }
          return entdetail;
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
  }
}
