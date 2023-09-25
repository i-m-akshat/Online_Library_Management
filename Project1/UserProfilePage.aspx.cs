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
  public partial class WebForm2 : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (Session["FullName"].ToString() == "" || Session["FullName"].ToString() == null)
      {
        Response.Write("<script>alert('Session expired. Please Login Again')</script>");
        Response.Redirect("Login.aspx");
      }
      else
      {
        if (!IsPostBack)
        {
          BindDetails();
          BindBookDetails();
        }
      }

    }

    protected void Back2Home_Click(object sender, EventArgs e)
    {
      Response.Redirect("Homepage.aspx");
    }

    protected void btn_Update_Click(object sender, EventArgs e)
    {
      string Password = "";
      if (txt_NewPassword.Text.Trim() == null || txt_NewPassword.Text.Trim() == "")
      {
        Password = txt_OldPassword.Text.Trim().ToString();
      }
      else
      {
        Password = txt_NewPassword.Text.Trim().ToString();
      }
      Ent_UserProfile objent = new Ent_UserProfile();
      Bll_UserProfile objbll = new Bll_UserProfile();
      try
      {
        objent.FullName = txt_FullName.Text.ToString();
        objent.DateOfBirth = Convert.ToDateTime(txt_DOB.Text);
        objent.FullAddress = txt_FullAddress.Text.ToString();
        objent.Password = Password;
        objent.MemberId = Convert.ToInt32(Session["MemberId"]);
        int upd = objbll.UpdateProfile(objent);
        if (upd != 0)
        {
          Response.Write("<script>alert('Record Updated Successfully')</script>");
          BindDetails();
          txt_NewPassword.Text = null;
        }
        else
        {
          Response.Write("<script>alert('Soemthing Went Wrong.Please try Again')</script>");
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
    public void BindDetails()
    {
      Ent_UserProfile objent = new Ent_UserProfile();
      Bll_UserProfile objbll = new Bll_UserProfile();
      try
      {
        int MemberId = Convert.ToInt32(Session["MemberId"]);
        objent = objbll.BindTextBox(MemberId);
        if (MemberId != 0)
        {
          txt_DOB.Text = objent.DateOfBirth.ToString("yyyy-MM-dd");
          txt_FullName.Text = objent.FullName.ToString();
          txt_FullAddress.Text = objent.FullAddress.ToString();
          txt_City.Text = objent.City.ToString();
          txt_State.Text = objent.State.ToString();
          txt_EMail.Text = objent.EMail.ToString();
          txt_UserId.Text = objent.UserId.ToString();
          txt_OldPassword.Text = objent.Password.ToString();
          lblAccount.Text = objent.AccountStatus.ToString();
          if (lblAccount.Text == "Active")
          {
            lblAccount.Attributes.Add("Class", "badge rounded-pill bg-success");
          }
          else if (lblAccount.Text == "Pending")
          {
            lblAccount.Attributes.Add("Class", "badge rounded-pill bg-warning");
          }
          else if (lblAccount.Text == "Deactivated")
          {
            lblAccount.Attributes.Add("Class", "badge rounded-pill bg-danger");
          }
          
        }
      }
      catch (Exception ex)
      {

        throw;
      }
    }




    /*-----It's the code in which i cant find any logic to apply in this code------*/



    //List<Ent_UserProfile> listent = new List<Ent_UserProfile>();
    //Bll_UserProfile objbll = new Bll_UserProfile();
    //try
    //{
    //  Ent_UserProfile objent = new Ent_UserProfile();
    //  int MemberId = Convert.ToInt32(Session["MemberId"]);
    //  listent = objbll.BindTextBox(MemberId);
    //  if (listent.Count > 0)
    //  {
    //    txt_FullName.Text = objent.FullName.ToString();
    //    txt_FullAddress.Text = objent.FullAddress.ToString();
    //    txt_City.Text = objent.City.ToString(); 
    //    txt_State.Text = objent.State.ToString();
    //    txt_EMail.Text = objent.EMail.ToString();
    //    txt_UserId.Text = objent.UserId.ToString();
    //    txt_OldPassword.Text = objent.Password.ToString();
    //  }
    //  else
    //  {
    //    Response.Write("<script>alert('Please check your credentials and try again')</script>");
    //  }
    //}
    //catch (Exception)
    //{

    //  throw;
    //}


    /*--------------------------------------------------------------------------------------------------*/




    public void BindBookDetails()
    {
      List<Ent_UserProfile> listent = new List<Ent_UserProfile>();
      Bll_UserProfile objbll = new Bll_UserProfile();
      try
      {
        int MemberId = Convert.ToInt32(Session["MemberId"]);
        listent = objbll.BindGrid(MemberId);
        if (listent.Count > 0)
        {
          Grid_User.DataSource = listent;
          Grid_User.DataBind();
        }
      }
      catch (Exception)
      {

        throw;
      }
    }

    protected void Grid_User_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
      Grid_User.PageIndex = e.NewPageIndex;
      BindBookDetails();
    }

    protected void Grid_User_RowDataBound(object sender, GridViewRowEventArgs e)
    {
      try
      {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
          Label lbl_Due = (Label)e.Row.FindControl("lbl_Due");
          DateTime dt = Convert.ToDateTime(lbl_Due.Text);
          DateTime today = DateTime.Today;
          if (dt < today)
          {
            e.Row.BackColor = System.Drawing.Color.Red;
            e.Row.ForeColor = System.Drawing.Color.White;
           
          }
        }
      }
      catch (Exception)
      {

        throw;
      }
    }




  }
}