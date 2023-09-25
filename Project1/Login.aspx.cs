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
  public partial class Login : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_2_signup_Click(object sender, EventArgs e)
    {
      Response.Redirect("SignUp.aspx",false);
    }

    protected void btn_2_Login_Click(object sender, EventArgs e)
    {
      Bll_MemberLogin objbll_MemberLogin = new Bll_MemberLogin();
      Ent_GetLoginDetails objent_GetLoginDetails = new Ent_GetLoginDetails();
      try
      {
        //objent_GetLoginDetails.UserId = txt_UserId.Text.ToString();
        string userid = txt_UserId.Text.ToString();
        string password = txt_Password.Text.ToString();
        //objent_GetLoginDetails.Password = txt_Password.Text.ToString();
        objent_GetLoginDetails = objbll_MemberLogin.MemberLogin(userid, password);
        if (objent_GetLoginDetails.MemberId > 0)
        {
          Session["FullName"] = objent_GetLoginDetails.FullName;
          Session["MemberId"] = objent_GetLoginDetails.MemberId;
          Session["Password"] = objent_GetLoginDetails.Password;
          Session["role"] = "User";
          Response.Write("<script async >alert('Login Successfull')</script>");
          Response.Redirect("UserProfilePage.aspx", false);
        }
        else
        {

          Response.Write("<script>alert('Please Check the entered Details and try Again')</script>");
        }
      }
      catch (Exception ex)
      {
        Response.Write("<script>alert('" + ex.Message + "')</script>");

      }
    }
  }
}