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
  public partial class AdminPublisherManagement : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        BindPublisher();
      }
    }
    private void BindPublisher()
    {
      List<Ent_GetPublisherDetails> list = new List<Ent_GetPublisherDetails>();
      Bll_GetPublisherDetails objbll = new Bll_GetPublisherDetails();
      try
      {
        list = objbll.SelectPublisher();
        if (list.Count > 0)
        {
          Grd_Publisher.DataSource = list;
          Grd_Publisher.DataBind();
        }
      }
      catch (Exception ex)
      {

        throw;
      }
    }

    protected void btn_Search_Click(object sender, EventArgs e)
    {
      Ent_GetPublisherDetails ent_GetPublisherDetails = new Ent_GetPublisherDetails();
      Bll_GetPublisherDetails bll_GetPublisherDetails = new Bll_GetPublisherDetails();
      try
      {
        string PublisherID = txt_PublisherID.Text;
        ent_GetPublisherDetails = bll_GetPublisherDetails.SelectPublisherByPublisherID(PublisherID);
        if (ent_GetPublisherDetails.PublisherName!=null)
        {
          txt_PublisherName.Text = ent_GetPublisherDetails.PublisherName;
          BindPublisher();
        }
        else if(ent_GetPublisherDetails.PublisherName==null)
        {
          txt_PublisherID.Text = null;
          txt_PublisherName.Text = null;
          Response.Write("<script>alert('Data not Found')</script>");
        }
      }
      catch (Exception)
      {

        throw;
      }
    }

    protected void btn_Add_Click(object sender, EventArgs e)
    {
      Ent_GetPublisherDetails ent_GetPublisherDetails = new Ent_GetPublisherDetails();
      Bll_GetPublisherDetails bll_GetPublisherDetails = new Bll_GetPublisherDetails();
      try
      {
        if (CheckPublisher())
        {
          Response.Write("<script>alert('Publisher ID already exist please try  another id')</script>");
          txt_PublisherID.Text = null;
          txt_PublisherName.Text = null;
        }
        else
        {
          ent_GetPublisherDetails.PublisherID = txt_PublisherID.Text.ToString();
          ent_GetPublisherDetails.PublisherName = txt_PublisherName.Text.ToString();
          int Add = bll_GetPublisherDetails.InsertPublisher(ent_GetPublisherDetails);
          if (Add != 0)
          {
            Response.Write("<script>alert('publisher is successfully Added');</script>");
            BindPublisher();
            txt_PublisherID.Text = null;
            txt_PublisherName.Text = null;
          }
          else
          {
            Response.Write("<script>alert('Please try again');</script>");
            BindPublisher();
            txt_PublisherID.Text = null;
            txt_PublisherName.Text = null;
          }
        }
       
      }
      catch (Exception)
      {

        throw;
      }
    }

    protected void btn_Update_Click(object sender, EventArgs e)
    {
      Ent_GetPublisherDetails ent_GetPublisherDetails = new Ent_GetPublisherDetails();
      Bll_GetPublisherDetails bll_GetPublisherDetails = new Bll_GetPublisherDetails();
      try
      {
        ent_GetPublisherDetails.PublisherID = txt_PublisherID.Text.ToString();
        ent_GetPublisherDetails.PublisherName = txt_PublisherName.Text.ToString();
        int upd = bll_GetPublisherDetails.UpdatePublisher(ent_GetPublisherDetails);
        if (upd != 0)
        {
          Response.Write("<script>alert('publisher is successfully updated');</script>");
          BindPublisher();
          txt_PublisherID.Text = null;
          txt_PublisherName.Text = null;
        }
        else
        {
          Response.Write("<script>alert('Please try again');</script>");
          BindPublisher();
          txt_PublisherID.Text = null;
          txt_PublisherName.Text = null;
        }
      }
      catch (Exception)
      {

        throw;
      }
    }

    protected void btn_Delete_Click(object sender, EventArgs e)
    {
      Ent_GetPublisherDetails ent_GetPublisherDetails = new Ent_GetPublisherDetails();
      Bll_GetPublisherDetails bll_GetPublisherDetails = new Bll_GetPublisherDetails();
      try
      {
        ent_GetPublisherDetails.PublisherID = txt_PublisherID.Text.ToString();
        int del = bll_GetPublisherDetails.DeletePublisher(ent_GetPublisherDetails);
        if (del != 0)
        {
          Response.Write("<script>alert('publisher is successfully Deleted');</script>");
          BindPublisher();
          txt_PublisherID.Text = null;
          txt_PublisherName.Text = null;
        }
        else
        {
          Response.Write("<script>alert('Please try again');</script>");
          BindPublisher();
          txt_PublisherID.Text = null;
          txt_PublisherName.Text = null;
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
    private bool CheckPublisher()
    {
      Ent_GetPublisherDetails ent_GetPublisherDetails = new Ent_GetPublisherDetails();
      Bll_GetPublisherDetails bll_GetPublisherDetails = new Bll_GetPublisherDetails();
      try
      {
        ent_GetPublisherDetails.PublisherID = txt_PublisherID.Text.ToString();
        DataTable dt = new DataTable();
        dt = bll_GetPublisherDetails.CheckPublisher(ent_GetPublisherDetails);
        if (dt.Rows.Count > 0)
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

    protected void Grd_Publisher_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
      Grd_Publisher.PageIndex = e.NewPageIndex;
      BindPublisher();
    }
  }
}