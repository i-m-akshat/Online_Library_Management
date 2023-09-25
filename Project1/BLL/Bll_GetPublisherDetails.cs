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
  public class Bll_GetPublisherDetails
  {
    DataAccessMethod objdal = new DataAccessMethod();
    public int InsertPublisher(Ent_GetPublisherDetails ent_GetPublisherDetails)
    {
      return objdal.InsertRecord("usp_Add_Publisher", ent_GetPublisherDetails.PublisherID, ent_GetPublisherDetails.PublisherName,ent_GetPublisherDetails.PublisherName);
    }
    public int UpdatePublisher(Ent_GetPublisherDetails ent_GetPublisherDetails)
    {
      return objdal.UpdateRecord("usp_Update_Publisher", ent_GetPublisherDetails.PublisherID, ent_GetPublisherDetails.PublisherName);
    }
    public int DeletePublisher(Ent_GetPublisherDetails ent_GetPublisherDetails)
    {
      return objdal.DeleteRecord("usp_Delete_Publisher", ent_GetPublisherDetails.PublisherID);
    }
    public DataTable CheckPublisher(Ent_GetPublisherDetails ent_GetPublisherDetails)
    {
      return objdal.SelectRecordByDatatable("usp_Check_PublisherByID", ent_GetPublisherDetails.PublisherID);
    }
    public List<Ent_GetPublisherDetails> SelectPublisher()
    {
      List<Ent_GetPublisherDetails> list = new List<Ent_GetPublisherDetails>();
      try
      {
        using(SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_Show_Publisher"))
        {
          while (sdr.Read())
          {
            Ent_GetPublisherDetails objent = new Ent_GetPublisherDetails();
            objent.PublisherID = sdr["PublisherID"] as string;
            objent.PublisherName = sdr["PublisherName"] as string;

            
            list.Add(objent);
          }
          return list;
        }
      }
      catch (Exception ex)
      {
        return new List<Ent_GetPublisherDetails>();
        throw;
      }
    }
    public Ent_GetPublisherDetails SelectPublisherByPublisherID(string PublisherID)
    {
      Ent_GetPublisherDetails objent = new Ent_GetPublisherDetails();
      using (SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_Show_PublisherByID", PublisherID))
      {
        while (sdr.Read())
        {
          objent.PublisherName = sdr["PublisherName"] as string;
        }
        return objent;
      }
    }
  }
}
