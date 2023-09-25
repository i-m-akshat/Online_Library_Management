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
  public partial class AdminAuthorManagement1 : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        ShowAuthor();
      }
      
    }

    protected void btn_Add_Click(object sender, EventArgs e)//for adding the author id and author name 
    {
      if (CheckAuthor())
      {
        Response.Write("<script>alert('Author ID already exist please try  another id')</script>");
        txt_AuthorID.Text = null;
        txt_AuthorName.Text = null;
      }
      else
      {
        BllAuthorDetails objbllAuthorDetails = new BllAuthorDetails();
        EntAuthorDetails objentAuthorDetails = new EntAuthorDetails();
        try
        {
          objentAuthorDetails.AuthorID = txt_AuthorID.Text.ToString();
          objentAuthorDetails.AuthorName = txt_AuthorName.Text.ToString();
          int result = objbllAuthorDetails.AuthorAdd(objentAuthorDetails);
          if (result != 0)
          {
            Response.Write("<script>alert('Author is successfully Added');</script>");
            ShowAuthor();
            txt_AuthorID.Text = null;
            txt_AuthorName.Text = null;
          }
          else
          {
            Response.Write("<script>alert('Something goes wrong please try again later')</script>");
            txt_AuthorID.Text = null;
            txt_AuthorName.Text = null;
          }
        }
        catch (Exception)
        {

          throw;
        }
      }
      
    }

    protected void btn_Update_Click(object sender, EventArgs e)//for updating the author name
    {

      BllAuthorDetails objBllAuthorDetails = new BllAuthorDetails();
      EntAuthorDetails objEntAuthorDetails = new EntAuthorDetails();
      try
      {
        objEntAuthorDetails.AuthorID = txt_AuthorID.Text.ToString();
        objEntAuthorDetails.AuthorName = txt_AuthorName.Text.ToString();
        int result = objBllAuthorDetails.AuthorUpdate(objEntAuthorDetails);
        if (result != 0)
        { 
          ShowAuthor();
          Response.Write("<script>alert('Author is successfully Updated');</script>");
          txt_AuthorID.Text = null;
          txt_AuthorName.Text = null;
        }
        else
        {
          Response.Write("<script>alert('Something went wrong please try again later');</script>");
          txt_AuthorID.Text = null;
          txt_AuthorName.Text = null;
          ShowAuthor();
        }
      }
      catch (Exception)
      {

        throw;
      }
    }

    protected void btn_Delete_Click(object sender, EventArgs e)
    {
      BllAuthorDetails objbllAuthorDetails = new BllAuthorDetails();
      EntAuthorDetails objentAuthorDetails = new EntAuthorDetails();
      try
      {
        objentAuthorDetails.AuthorID = txt_AuthorID.Text.ToString();
        objentAuthorDetails.AuthorName = txt_AuthorName.Text.ToString();
        int res = objbllAuthorDetails.AuthorDelete(objentAuthorDetails);
        if (res != 0)
        {
          Response.Write("<script>alert('Author Deleted successfully')</script>");
          txt_AuthorID.Text = null;
          txt_AuthorName.Text = null;
          ShowAuthor();
        }
        else
        {
          Response.Write("<script>alert('Something went wrong')</script>");
        }
      }
      catch (Exception)
      {

        throw;
      }
    }

    protected void btn_2_Go_Click(object sender, EventArgs e)
    {
      BllAuthorDetails objbllAuthorDetails = new BllAuthorDetails();
      EntAuthorDetails objentAuthorDetails = new EntAuthorDetails();
      try
      {
        objentAuthorDetails.AuthorID = txt_AuthorID.Text;
        DataTable dt = new DataTable();
        dt = objbllAuthorDetails.CheckAuthor(objentAuthorDetails);
        if (dt.Rows.Count > 0)
        {
          Grd_Author.DataSource = dt;
          Grd_Author.DataBind();
          txt_AuthorID.Text =objentAuthorDetails.AuthorID;
          txt_AuthorName.Text = dt.Rows[0][1].ToString();
        }
        else
        {
          Response.Write("<script>alert('Data not Found')</script>");
          txt_AuthorID.Text = null;
          txt_AuthorName.Text = null;
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
    public void ShowAuthor()
    {
      BllAuthorDetails objbllAuthorDetails = new BllAuthorDetails();
      EntAuthorDetails objentAuthorDetails = new EntAuthorDetails();
      DataTable dt = new DataTable();
      dt = objbllAuthorDetails.GetAuthor(objentAuthorDetails);
      if (dt.Rows.Count > 0)
      {
        Grd_Author.DataSource = dt;
        Grd_Author.DataBind();
        Grd_Author.UseAccessibleHeader = true;
        Grd_Author.HeaderRow.TableSection = TableRowSection.TableHeader; //this will add the thead element 
      }
    }
    public bool CheckAuthor()
    {
      EntAuthorDetails objentAuthorDetails = new EntAuthorDetails();
      BllAuthorDetails objBllAuthorDetails = new BllAuthorDetails();
      try
      {
        objentAuthorDetails.AuthorID = txt_AuthorID.Text;
        DataTable dt = new DataTable();
        dt = objBllAuthorDetails.CheckAuthor(objentAuthorDetails);
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

  
  }
}