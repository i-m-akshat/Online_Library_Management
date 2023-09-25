using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;
using Entity;

namespace Project1
{
  public partial class Books : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        BindGrid();
      }
      
    }
    private void BindGrid()                       //Method to bind the grid to details of book which are coming from data base
    {
      List<Ent_GetBookInventory> list_entgetBook = new List<Ent_GetBookInventory>();
      Bll_GetBookInventory bll_GetBook = new Bll_GetBookInventory();
      try
      {
        list_entgetBook = bll_GetBook.BindBook();
        if (list_entgetBook.Count > 0)
        {
          Grd_Books.DataSource = list_entgetBook;
          Grd_Books.DataBind();
        }
      }
      catch (Exception)
      {

        throw;
      }
    }

    protected void Grd_Books_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
      Grd_Books.PageIndex = e.NewPageIndex;
      BindGrid();
    }
  }
}