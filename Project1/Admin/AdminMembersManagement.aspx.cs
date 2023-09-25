using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Entity;
using BLL;

namespace Project1.Admin
{
  public partial class AdminMembersManagement : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        BindMember();
      }
    }

    protected void btn_deactivate_Click(object sender, EventArgs e)
    {
      Ent_GetMemberDetails objent_GetMemberDetails = new Ent_GetMemberDetails();
      Bll_GetMemberDetails objbll_GetMemberDetailsDetails = new Bll_GetMemberDetails();
      try
      {
        objent_GetMemberDetails.MemberID = Convert.ToInt32(txt_MemberId.Text);
        int Deact = objbll_GetMemberDetailsDetails.DeactivateStatus(objent_GetMemberDetails);
        if (Deact != 0)
        {
          Response.Write("<script>alert('Account Deactivated')</script>");
          txt_AccountStatus.Text = null;
          txt_MemberId.Text = null;
          txt_FullName.Text = null;
          txt_FullAddress.Text = null;
          txt_DOB.Text = null;
          txt_ContactNo.Text = null;
          txt_EMail.Text = null;
          txt_State.Text = null;
          txt_City.Text = null;
          txt_Pincode.Text = null;
          BindMember();
        }
      }
      catch (Exception)
      {

        throw;
      }
    }

    protected void btn_Pending_Click(object sender, EventArgs e)
    {
      Ent_GetMemberDetails objent_GetMemberDetails = new Ent_GetMemberDetails();
      Bll_GetMemberDetails objbll_GetMemberDetails = new Bll_GetMemberDetails();
      try
      {
        objent_GetMemberDetails.MemberID = Convert.ToInt32(txt_MemberId.Text);
        int Pending = objbll_GetMemberDetails.PendingStatus(objent_GetMemberDetails);
        if (Pending != 0)
        {
          Response.Write("<script>alert('Account Status Changed to Pending')</script>");
          txt_AccountStatus.Text = null;
          txt_MemberId.Text = null;
          txt_FullName.Text = null;
          txt_FullAddress.Text = null;
          txt_DOB.Text = null;
          txt_ContactNo.Text = null;
          txt_EMail.Text = null;
          txt_State.Text = null;
          txt_City.Text = null;
          txt_Pincode.Text = null;
          BindMember();
        }
      }
      catch (Exception)
      {

        throw;
      }
    }

    protected void btn_Active_Click(object sender, EventArgs e)
    {
      Ent_GetMemberDetails objent = new Ent_GetMemberDetails();
      Bll_GetMemberDetails objbll = new Bll_GetMemberDetails();
      try
      {
        objent.MemberID = Convert.ToInt32(txt_MemberId.Text);
        int Act = objbll.ActiveStatus(objent);
        if (Act != 0)
        {
          Response.Write("<script>alert('Account Status Changed To Active')</script>");
          txt_AccountStatus.Text = null;
          txt_MemberId.Text = null;
          txt_FullName.Text = null;
          txt_FullAddress.Text = null;
          txt_DOB.Text = null;
          txt_ContactNo.Text = null;
          txt_EMail.Text = null;
          txt_State.Text = null;
          txt_City.Text = null;
          txt_Pincode.Text = null;
          BindMember();

        }
      }
      catch (Exception)
      {

        throw;
      }
    }

    protected void btn_SearchId_Click(object sender, EventArgs e)
    {
      Ent_GetMemberDetails objentGetMemberDetails = new Ent_GetMemberDetails();
      Bll_GetMemberDetails objbllGetMemberDetails = new Bll_GetMemberDetails();
      try
      {
        if(txt_MemberId.Text.Equals(""))
        {
          Response.Write("<script>alert('MemberID cannot be Empty')</script>");
        }
        else
        {
          objentGetMemberDetails.MemberID = Convert.ToInt32(txt_MemberId.Text.ToString());
          DataTable dt = new DataTable();
          dt = objbllGetMemberDetails.GrdCheckMember(objentGetMemberDetails);
          if (dt.Rows.Count > 0)
          {
            Grd_Member.DataSource = dt;
            Grd_Member.DataBind();
            txt_FullName.Text = dt.Rows[0][0].ToString();
            txt_AccountStatus.Text = dt.Rows[0][10].ToString();
            txt_DOB.Text = Convert.ToString(dt.Rows[0][1].ToString());
            txt_ContactNo.Text = dt.Rows[0][2].ToString();
            txt_EMail.Text = dt.Rows[0][3].ToString();
            txt_State.Text = dt.Rows[0][4].ToString();
            txt_City.Text = dt.Rows[0][5].ToString();
            txt_Pincode.Text = dt.Rows[0][6].ToString();
            txt_FullAddress.Text = dt.Rows[0][7].ToString();
          }
          else
          {
            Response.Write("<script>alert('MemberID cannot be Found')</script>");
          }
        
        }
      }
      catch (Exception)
      {

        throw;
      }
    }

    protected void btn_DeleteMember_Click(object sender, EventArgs e)
    {
      Ent_GetMemberDetails objent = new Ent_GetMemberDetails();
      Bll_GetMemberDetails objbll = new Bll_GetMemberDetails();
      try
      {
        objent.MemberID = Convert.ToInt32(txt_MemberId.Text);
        int del = objbll.DeleteRow(objent);
        if (del != 0)
        {
          Response.Write("<script>alert('Member permanently deleted')</script>");
          txt_AccountStatus.Text = null;
          txt_MemberId.Text = null;
          txt_FullName.Text = null;
          txt_FullAddress.Text = null;
          txt_DOB.Text = null;
          txt_ContactNo.Text = null;
          txt_EMail.Text = null;
          txt_State.Text = null;
          txt_City.Text = null;
          txt_Pincode.Text = null;
          BindMember();

        }
      }
      catch (Exception)
      {

        throw;
      }
    }
    public void BindMember()
    {
      Ent_GetMemberDetails ent_GetMemberDetails = new Ent_GetMemberDetails();
      Bll_GetMemberDetails bll_GetMemberDetails = new Bll_GetMemberDetails();
      try
      {
        DataTable dt = new DataTable();
        dt = bll_GetMemberDetails.BindMember(ent_GetMemberDetails);
        if (dt.Rows.Count > 0)
        {
          Grd_Member.DataSource = dt;
          Grd_Member.DataBind();
          Grd_Member.HeaderRow.TableSection = TableRowSection.TableHeader;

        }
        else
        {
          Response.Write("<script>alert('Something went wrong.Please try Again')</script>");
        }

      }
      catch (Exception)
      {

        throw;
      }
    }
  }
}
  