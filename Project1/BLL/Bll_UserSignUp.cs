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
  public class Bll_UserSignUp
  {
    DataAccessMethod objDAL = new DataAccessMethod();
    public int Register(Ent_GetSignUpDetails objent_GetSignUpDetails)
    {
      try
      {
        return objDAL.InsertRecord("usp_User_SignUp", objent_GetSignUpDetails.FullName, objent_GetSignUpDetails.DateOfBirth, objent_GetSignUpDetails.EMail, objent_GetSignUpDetails.ContactNumber, objent_GetSignUpDetails.State, objent_GetSignUpDetails.City, objent_GetSignUpDetails.Pincode, objent_GetSignUpDetails.FullAddress, objent_GetSignUpDetails.UserId, objent_GetSignUpDetails.Password,objent_GetSignUpDetails.AccountStatus);
      }
      catch (Exception)
      {

        throw;
      }
    }
    public DataTable BindState(Ent_GetSignUpDetails ent_GetSignUpDetails)
    {
      try
      {
        return objDAL.SelectRecordByDatatable("usp_OnlineLibraryManagement_State", ent_GetSignUpDetails.State, ent_GetSignUpDetails.StateId);
      }
      catch (Exception)
      {

        throw;
      }
    }
    public DataTable BindCity(int StateId)
    {
      try
      {
        return objDAL.SelectRecordByDatatable("usp_OnlineLibraryManagement_City", StateId);
      }
      catch (Exception)
      {

        throw;
      }
    }
    public DataTable CheckUser(Ent_GetSignUpDetails ent_GetSignUpDetails)
    {
      return objDAL.SelectRecordByDatatable("usp_Check_SignUp", ent_GetSignUpDetails.UserId);
    }
  }
}
