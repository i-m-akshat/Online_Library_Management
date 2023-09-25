using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BLL;
using Entity;

namespace Project1
{
  public partial class SignUp : System.Web.UI.Page
  {
    ////Connection string to sql 
    //string strcon = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        FillState();
      }
    }

    protected void btn_2_Login_Click(object sender, EventArgs e)
    {
      Response.Redirect("Login.aspx");
    }

    protected void ddl_State_SelectedIndexChanged(object sender, EventArgs e)
    {
      Bll_UserSignUp objbll_UserSignUp = new Bll_UserSignUp();
      //Ent_GetSignUpDetails ent_GetSignUpDetails = new Ent_GetSignUpDetails();
      if(ddl_State.SelectedValue == "0")
      {
        ddl_City.Enabled = false;
      }
      else
      {
        try
        {
          int StateId = Convert.ToInt32(ddl_State.SelectedValue);
          DataTable dt = new DataTable();
          dt = objbll_UserSignUp.BindCity(StateId);
          if (dt.Rows.Count>0)
          {
            ddl_City.Items.Clear();
            ddl_City.DataSource = dt;
            ddl_City.DataTextField = "CityName";
            ddl_City.DataValueField = "CityId";
            ddl_City.DataBind();
          }

        }
        catch (Exception ex)
        {
          throw;
        }
      }
    }

    protected void btn_2_signup_Click(object sender, EventArgs e)//SignUp button click backend
    {
      if (CheckUserSignUp())
      {
        Response.Write("<script>alert('Member already exist with this UserID. Please try other user id');</script>");
      }
      else
      {
        User_SignUp();
      }
      
    }
    public void FillState()
    {
      Bll_UserSignUp bll_UserSignUp = new Bll_UserSignUp();
      Ent_GetSignUpDetails ent_GetSignUpDetails = new Ent_GetSignUpDetails();
      DataTable dt = new DataTable();
      dt = bll_UserSignUp.BindState(ent_GetSignUpDetails);
      if (dt.Rows.Count > 0)
      {
        ddl_State.DataSource = dt;
        ddl_State.DataValueField = "StateId";
        ddl_State.DataTextField = "StateName";
        ddl_State.DataBind();
      }
    }
    bool CheckUserSignUp()
    {
      Ent_GetSignUpDetails objent_GetSignUpDetails = new Ent_GetSignUpDetails();
      Bll_UserSignUp objbll_UserSign = new Bll_UserSignUp();
      try
      {
        objent_GetSignUpDetails.UserId = txt_UserId.Text;
        DataTable dt = new DataTable();
        
        dt = objbll_UserSign.CheckUser(objent_GetSignUpDetails);
        if (dt.Rows.Count>0)
        {
          return true;
        }
        else
        {
          return false;
        }
      }
      catch (Exception)
      {

        throw;
      }
      
    }
    public void User_SignUp()
    {
      Ent_GetSignUpDetails objent_GetSignUpDetails = new Ent_GetSignUpDetails();
      Bll_UserSignUp bll_UserSignUp = new Bll_UserSignUp();
      try
      {
        objent_GetSignUpDetails.FullName = txt_FullName.Text as string;
        objent_GetSignUpDetails.DateOfBirth = Convert.ToDateTime(txt_Dob.Text.Trim());
        objent_GetSignUpDetails.EMail = txt_EMail.Text as string;
        objent_GetSignUpDetails.ContactNumber = txt_ContactNo.Text as string;
        objent_GetSignUpDetails.State = ddl_State.SelectedItem.ToString();
        objent_GetSignUpDetails.City = ddl_City.SelectedItem.ToString();
        objent_GetSignUpDetails.Pincode = txt_Pincode.Text as string;
        objent_GetSignUpDetails.FullAddress = txt_FullAddress.Text as string;
        objent_GetSignUpDetails.UserId = txt_UserId.Text as string;
        objent_GetSignUpDetails.Password = txt_Password.Text as string;
        objent_GetSignUpDetails.AccountStatus = "Pending" as string;
        int result = bll_UserSignUp.Register(objent_GetSignUpDetails);
        if (result != 0)
        {
          Response.Write("<script>alert('Sign Up is successfull Please proceed to Login');</script>");
          lblmsg.Text = "SignUp Successfull";
          lblmsg.ForeColor = System.Drawing.Color.Green;
          
        }
        else
        {
          lblmsg.Text = "Please check the entered details and try again";
          lblmsg.ForeColor = System.Drawing.Color.Red;
        }
      }
      catch (Exception ex)
      {
        Response.Write("<script> alert(' " + ex.Message + " '); </ script >");
        throw;
      }
    }
  }
}