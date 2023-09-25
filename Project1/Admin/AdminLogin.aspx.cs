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

namespace Project1.Admin
{
  public partial class AdminLogin : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_2_Login_Click(object sender, EventArgs e)
    {
      Bll_GetAdminDetails objbll_GetAdminDetails = new Bll_GetAdminDetails();
      Ent_GetAdminDetails objent_GetAdminDetails = new Ent_GetAdminDetails();
      try
      {
        string Username = txt_Username.Text.ToString();
        string Password = txt_Password.Text.ToString();
        objent_GetAdminDetails = objbll_GetAdminDetails.GetAdminDetails(Username, Password);       
        if (objent_GetAdminDetails.AdminID>0)
        {
          Session["AdminID"] = objent_GetAdminDetails.AdminID;
          Session["FullName"] = objent_GetAdminDetails.FullName;
          Session["Username"] = objent_GetAdminDetails.Username;
          Session["Password"] = objent_GetAdminDetails.Password;
          Session["role"] = "Admin";
          Response.Write("<script async >alert('Login Successfull')</script>");
          Response.Redirect("AdminDashboard.aspx");
        }
        else
        {
          Response.Write("<script async>alert('Please check your details and try again')</script>");
        }
      }
      catch (Exception ex)
      {

        throw;
      }
    }
  }
}