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
  public class Bll_GetAdminDetails
  {
    DataAccessMethod objdal = new DataAccessMethod();
    public Ent_GetAdminDetails GetAdminDetails(string Username,string Password)
    {
      Ent_GetAdminDetails ent_GetAdminDetails = new Ent_GetAdminDetails();
      try
      {
        using (SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_AdminLogin",Username,Password))
        {
          while (sdr.Read())
          {
            ent_GetAdminDetails.FullName = sdr["FullName"].ToString();
            ent_GetAdminDetails.AdminID = Convert.ToInt32(sdr["AdminID"].ToString());
          }
          return ent_GetAdminDetails;
        }

      }
      catch (Exception ex)
      {

        throw;
      }

    }
  }
}
