using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Project1
{
  public partial class Project1 : System.Web.UI.MasterPage
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (Session["role"] == null)
      {
        LinkButton3.Visible=true;
        LinkButton4.Visible = false;
        LinkButton5.Visible = false;
        LinkButton6.Visible = false;
        LinkButton7.Visible = false;
        LinkButton8.Visible = false;
        
        //Response.Redirect("HomePage.aspx");
      }
      else if (Session["role"].Equals("User"))
      {
        LinkButton3.Visible = false;
        LinkButton4.Visible = false;
        LinkButton5.Visible = false;
        LinkButton6.Visible = false;
        LinkButton7.Visible = false;
        LinkButton8.Visible = false;
        Link_2_LogOut.Visible = true;
        Link_2_Login.Visible = false;
        Link2UserProfile.Visible = true;
        Link2UserProfile.Text = "Hello " + Session["FullName"].ToString();
       }
    }

    protected void Link_2_Login_Click(object sender, EventArgs e)
    {
      Response.Redirect("Login.aspx");
    }

    protected void Link_2_LogOut_Click(object sender, EventArgs e)
    {
      Session.Abandon();
      Session.Clear();
      Response.Redirect("HomePage.aspx");
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
      Response.Redirect("Admin/AdminLogin.aspx");
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
      Response.Redirect("AdminAuthorManagement.aspx");
    }

    protected void LinkButton5_Click(object sender, EventArgs e)
    {
      Response.Redirect("AdminPublisherManagement.aspx");
    }

    protected void LinkButton7_Click(object sender, EventArgs e)
    {
      Response.Redirect("AdminBookIssuing.aspx");
    }

    protected void LinkButton8_Click(object sender, EventArgs e)
    {
      Response.Redirect("AdminMemberManagement.aspx");
    }

    protected void LinkButton6_Click(object sender, EventArgs e)
    {
      Response.Redirect("AdminBookInventory.aspx");
    }

    protected void Link2UserProfile_Click(object sender, EventArgs e)
    {
      Response.Redirect("UserProfilePage.aspx");
    }
  }
}