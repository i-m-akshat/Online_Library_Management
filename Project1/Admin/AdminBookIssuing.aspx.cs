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
  public partial class AdminBookIssuing : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        BindGrid();
      }
    }





    protected void btn_2_Search_Click(object sender, EventArgs e)//search button click event
    {
      Bll_BookIssuing objbll = new Bll_BookIssuing();
      Ent_BookIssuing objent = new Ent_BookIssuing();
      try
      {
        if (CheckUserAndBookExist())
        {

          string BookId = txt_BookId.Text.ToString();
          int MemberId = Convert.ToInt32(txt_MemberID.Text);
          objent = objbll.FillData(MemberId, BookId);
          if (objent.BookName != null)
          {
            txt_MemberName.Text = objent.MemberName as string;
            txt_BookName.Text = objent.BookName as string;
          }


        }
        else
        {
          Response.Write("<script>alert('Member And Book By this Id doesn't exist')</script>");
          txt_BookId.Text = null;
          txt_MemberID.Text = null;
          txt_BookName.Text = null;
          txt_MemberName.Text = null;
          txt_IssueDate.Text = null;
          txt_DueDate.Text = null;
        }

      }
      catch (Exception)
      {

        throw;
      }
    }





    public void BindGrid()//method to bind the grid 
    {
      List<Ent_BookIssuing> listent = new List<Ent_BookIssuing>();
      Bll_BookIssuing objbll = new Bll_BookIssuing();
      try
      {
        listent = objbll.BindGrid();
        if (listent.Count > 0)
        {
          Grd_Issue.GridLines = GridLines.Both;
          Grd_Issue.DataSource = listent;
          Grd_Issue.DataBind();
        }
      }
      catch (Exception ex)
      {

        throw;
      }
    }





    public bool CheckUserAndBookExist()//method to check if member and book by that id already exist or not
    {
      Ent_BookIssuing ListentIssue = new Ent_BookIssuing();
      Bll_BookIssuing bllIssue = new Bll_BookIssuing();
      try
      {
        int MemberId = Convert.ToInt32(txt_MemberID.Text);
        string BookId = txt_BookId.Text.ToString();
        ListentIssue = bllIssue.FillData(MemberId, BookId);
        if (ListentIssue.MemberName != null)
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




    public bool CheckIssuedBook()//method to check if book has been issued already or not 
    {
      Ent_BookIssuing ListentIssue = new Ent_BookIssuing();
      Bll_BookIssuing bllIssue = new Bll_BookIssuing();
      try
      {
        int MemberId = Convert.ToInt32(txt_MemberID.Text);
        string BookId = txt_BookId.Text.ToString();
        ListentIssue = bllIssue.CheckIssuedBook(BookId,MemberId);
        if (ListentIssue.MemberName != null)
        {
          return true;
        }
        else
        {
          return false;
        }
      }
      catch (Exception ex)
      {

        throw;
      }
    }





    protected void btn_Issue_Click(object sender, EventArgs e) //issue button click event
    {
      Ent_BookIssuing entIssue = new Ent_BookIssuing();
      Bll_BookIssuing bllIssue = new Bll_BookIssuing();
      try
      {
        if (CheckIssuedBook())
        {
          Response.Write("<script>alert('This Member already has this book')</script>");

        }
        else
        {
          entIssue.MemberId = Convert.ToInt32(txt_MemberID.Text);
          entIssue.BookId = txt_BookId.Text.ToString();
          entIssue.MemberName = txt_MemberName.Text.ToString();
          entIssue.BookName = txt_BookName.Text.ToString();
          entIssue.IssueDate = Convert.ToDateTime(txt_IssueDate.Text);
          entIssue.DueDate = Convert.ToDateTime(txt_DueDate.Text);
          int res = bllIssue.IssueBook(entIssue);
          if (res != 0)
          {
            Response.Write("<script>alert('Book issued to designated Member')</script>");
            BindGrid();
            txt_BookId.Text = null;
            txt_MemberID.Text = null;
            txt_BookName.Text = null;
            txt_MemberName.Text = null;
            txt_IssueDate.Text = null;
            txt_DueDate.Text = null;
          }
          else
          {
            Response.Write("<script>alert('Something went wrong')</script>");
            txt_BookId.Text = null;
            txt_MemberID.Text = null;
            txt_BookName.Text = null;
            txt_MemberName.Text = null;
            txt_IssueDate.Text = null;
            txt_DueDate.Text = null;
          }
          
        }
      }
      catch (Exception ex)
      {

        throw;
      }
    }






    protected void btn_Return_Click(object sender, EventArgs e)
    {
      Ent_BookIssuing objent = new Ent_BookIssuing();
      Bll_BookIssuing objbll = new Bll_BookIssuing();
      try
      {
        if (CheckIssuedBook())
        {
          objent.BookId = txt_BookId.Text.ToString();
          objent.MemberId = Convert.ToInt32(txt_MemberID.Text);
          int del = objbll.ReturnBook(objent);
          if (del != 0)
          {
            Response.Write("<script>alert('Book has now returned to the inventory')</script>");
            BindGrid();
            txt_BookId.Text = null;
            txt_MemberID.Text = null;
            txt_BookName.Text = null;
            txt_MemberName.Text = null;
            txt_IssueDate.Text = null;
            txt_DueDate.Text = null;
          }
          else
          {
            Response.Write("<script>alert('something went wrong')</script>");
            
            txt_BookId.Text = null;
            txt_MemberID.Text = null;
            txt_BookName.Text = null;
            txt_MemberName.Text = null;
            txt_IssueDate.Text = null;
            txt_DueDate.Text = null;
          }
          
        }
        else
        {
          Response.Write("<script>alert('entry does not exist')</script>");
        }
      }
      catch (Exception ex)
      {

        throw;
      }
    }

    protected void Grd_Issue_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
      Grd_Issue.PageIndex = e.NewPageIndex;
      BindGrid();
    }

    protected void Grd_Issue_RowDataBound(object sender, GridViewRowEventArgs e)
    {
      try
      {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
          //check your condition here 
          Label lblDueDate = (Label)e.Row.FindControl("lblDueDate");

          DateTime dt = Convert.ToDateTime(lblDueDate.Text);
          DateTime Today = DateTime.Today;
          if (Today > dt)
          {
            e.Row.BackColor = System.Drawing.Color.Red;
            e.Row.ForeColor = System.Drawing.Color.White;
          }
         
        }
      }
      catch (Exception ex)
      {

        throw;
      }
    }
  }
}