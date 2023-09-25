using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1.Admin
{
  public partial class Admin2 : System.Web.UI.MasterPage
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (Session["role"]==null)
      { 
        LinkButton1.Visible = false;
        LinkButton2.Visible = false;
        LinkButton3.Visible = false;
        LinkButton4.Visible = false;
        LinkButton5.Visible = false;
        Link_2_LogOut.Visible = false;
        Link2UserProfile.Visible = false;
        
      }
      else if (Session["role"].Equals("Admin"))
      {
        LinkButton1.Visible = true;
        LinkButton2.Visible = true;
        LinkButton3.Visible = true;
        LinkButton4.Visible = true;
        LinkButton5.Visible = true;
        Link2UserProfile.Visible = true;
        Link_2_LogOut.Visible = true;
        Link2UserProfile.Text = "Hello " + Session["FullName"].ToString();
        if(Session["role"].Equals(""))
        {
          Response.Redirect("AdminLogin.aspx");
        }
      }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
      Response.Redirect("AdminAuthorManagement.aspx");
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
      Response.Redirect("AdminBookInventory.aspx");
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
      Response.Redirect("AdminBookIssuing.aspx");
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
      Response.Redirect("AdminMembersManagement.aspx");
    }

    protected void LinkButton5_Click(object sender, EventArgs e)
    {
      Response.Redirect("AdminPublisherManagement.aspx");
    }

    protected void Link_2_LogOut_Click(object sender, EventArgs e)
    {
      Session.Abandon();
      Session.Clear();
      Response.Redirect("~/HomePage.aspx");
    }

    protected void link2Homepage_Click(object sender, EventArgs e)
    {
      Session.Abandon();
      Response.Redirect("/HomePage.aspx");
    }

   
  }
}