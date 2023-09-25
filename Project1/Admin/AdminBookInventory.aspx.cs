using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using BLL;
using Entity;

namespace Project1.Admin
{
  public partial class AdminBookInventory : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        FillAuthor();// calling the method to fill author in dropdown list
        FillPublisher();// calling the method to fill Publisher in dropdown list
        FillGenre();// calling the method to fill genre in list box
        BindGrid();//calling the method on pageload to fill the Grid 
      }
    }



    protected void btn_Add_Click(object sender, EventArgs e) //event to add the book
    {
      if (txt_BookID.Text != null)
      {
        if (CheckBook())
        {
          Response.Write("<script>alert('Book already exist by this ID please try again with different id')</script>");
          txt_BookID.Text = null;
        }
        else
        {
          Ent_GetBookInventory entBookInt = new Ent_GetBookInventory();
          Bll_GetBookInventory bllBookInt = new Bll_GetBookInventory();
          try
          {
            entBookInt.BookId = txt_BookID.Text.ToString();
            entBookInt.BookName = txt_BookName.Text.ToString();
            entBookInt.Genre = AddGenre();
            entBookInt.AuthorName = ddl_AuthorName.SelectedItem.ToString();
            entBookInt.PublisherName = ddl_PublisherName.SelectedItem.ToString();
            entBookInt.PublishDate =Convert.ToDateTime(txt_PublishDate.Text);
            entBookInt.Language = ddl_Language.SelectedItem.ToString();
            entBookInt.Edition = txt_Edition.Text.ToString();
            entBookInt.BookCost = txt_BookCost.Text.ToString();
            entBookInt.Pages = txt_Pages.Text.ToString();
            entBookInt.BookDescription = txt_BookDescription.Text.ToString();
            entBookInt.ActualStock = Convert.ToInt32(txt_ActualStock.Text);
            entBookInt.CurrentStock = Convert.ToInt32(txt_ActualStock.Text);
            entBookInt.BookURL = SaveBook(FileUpload1);
            entBookInt.BookIssued = 0;
            int res = bllBookInt.InsertBookDetails(entBookInt);
            if (res != 0)
            {
              Response.Write("<script>alert('Book Details Saved')</script>");
              txt_BookID.Text = null;
              txt_BookName.Text = null;
              txt_Edition.Text = null;
              txt_BookCost.Text = null;
              txt_Pages.Text = null;
              txt_BookDescription.Text = null;
              txt_ActualStock.Text = null;
              txt_CurrentStock.Text = null;
              txt_BookIssued.Text = null;
              BindGrid();
              
            }
            else
            {
              Response.Write("<script>alert('something went wrong')</script>");
              txt_BookID.Text = null;
              txt_BookName.Text = null;
              txt_Edition.Text = null;
              txt_BookCost.Text = null;
              txt_Pages.Text = null;
              txt_BookDescription.Text = null;
              txt_ActualStock.Text = null;
              txt_CurrentStock.Text = null;
              txt_BookIssued.Text = null;
            }
          }
          catch (Exception)
          {

            throw;
          }
        }
      }
      else
      {
        Response.Write("<script>alert('Please enter the book ID')</script>");
      }
     
    }






    protected void btn_Update_Click(object sender, EventArgs e) //event to update the book
    {
      Ent_GetBookInventory entgetbook = new Ent_GetBookInventory();
      Bll_GetBookInventory bllgetbook = new Bll_GetBookInventory();
      try
      {
        entgetbook.BookId = txt_BookID.Text.ToString();
        entgetbook.BookName = txt_BookName.Text.ToString();
        entgetbook.Genre = AddGenre();
        entgetbook.AuthorName = ddl_AuthorName.SelectedItem.ToString();
        entgetbook.PublisherName = ddl_PublisherName.SelectedItem.ToString();
        entgetbook.PublishDate = Convert.ToDateTime(txt_PublishDate.Text);
        entgetbook.Language = ddl_Language.SelectedItem.ToString();
        entgetbook.Edition = txt_Edition.Text.ToString();
        entgetbook.BookCost = txt_BookCost.Text.ToString();
        entgetbook.Pages = txt_Pages.Text.ToString();
        entgetbook.BookDescription = txt_BookDescription.Text.ToString();
        if (txt_ActualStock.Text != "")
        {
          entgetbook.ActualStock = Convert.ToInt32(txt_ActualStock.Text);
        }
        if (txt_CurrentStock.Text != "")
        {
          entgetbook.CurrentStock = Convert.ToInt32(txt_CurrentStock.Text);
        }

        

        entgetbook.BookURL = SaveBook(FileUpload1);
        
        
        int upd = bllgetbook.UpdateBook(entgetbook);
        if (upd != 0)
        {
          Response.Write("<script>alert('Updated Successfully')</script>");
          txt_BookID.Text = null;
          txt_BookName.Text = null;
          txt_Edition.Text = null;
          txt_BookCost.Text = null;
          txt_Pages.Text = null;
          txt_BookDescription.Text = null;
          txt_ActualStock.Text = null;
          txt_CurrentStock.Text = null;
          txt_BookIssued.Text = null;
          BindGrid();
        }
        else
        {
          Response.Write("<script>alert('Something went wrong')</script>");
          txt_BookID.Text = null;
          txt_BookName.Text = null;
          txt_Edition.Text = null;
          txt_BookCost.Text = null;
          txt_Pages.Text = null;
          txt_BookDescription.Text = null;
          txt_ActualStock.Text = null;
          txt_CurrentStock.Text = null;
          txt_BookIssued.Text = null;
        }
      }
      catch (Exception)
      {

        throw;
      }
    }






    protected void btn_Delete_Click(object sender, EventArgs e)   //event to delete the book
    {
      Ent_GetBookInventory entgetbook = new Ent_GetBookInventory();
      Bll_GetBookInventory bllgetbook = new Bll_GetBookInventory();
      try
      {
        entgetbook.BookId = txt_BookID.Text;
        int del = bllgetbook.DeleteBook(entgetbook);
        if (del != 0)
        {
          Response.Write("<script>alert('Book Deleted Successfully')</script>");
          txt_BookID.Text = null;
          txt_BookName.Text = null;
          txt_Edition.Text = null;
          txt_BookCost.Text = null;
          txt_Pages.Text = null;
          txt_BookDescription.Text = null;
          txt_ActualStock.Text = null;
          txt_CurrentStock.Text = null;
          txt_BookIssued.Text = null;
          BindGrid();
        }
        else
        {
          Response.Write("<script>alert('Something went wrong')</script>");
          txt_BookID.Text = null;
          txt_BookName.Text = null;
          txt_Edition.Text = null;
          txt_BookCost.Text = null;
          txt_Pages.Text = null;
          txt_BookDescription.Text = null;
          txt_ActualStock.Text = null;
          txt_CurrentStock.Text = null;
          txt_BookIssued.Text = null;
        }
      }
      catch (Exception)
      {

        throw;
      }
    }






    protected void btn_SearchId_Click(object sender, EventArgs e )//it searches for the member id and when it founds the data of that book id it will fill the deatails of books on that particular book id in the textboxes 
    {
      Ent_GetBookInventory entgetBook = new Ent_GetBookInventory();
      Bll_GetBookInventory bllgetBook = new Bll_GetBookInventory();
      try
      {
        string BookId = txt_BookID.Text.ToString();
        entgetBook = bllgetBook.SearchBookById(BookId);
        if (entgetBook.BookId!=null)
        {
          txt_BookName.Text = entgetBook.BookName.ToString();
          txt_Edition.Text = entgetBook.Edition.ToString();
          txt_BookCost.Text = entgetBook.BookCost.ToString();
          txt_Pages.Text = entgetBook.Pages.ToString();
          txt_PublishDate.Text = entgetBook.PublishDate.ToString("yyyy-MM-dd");
          txt_BookDescription.Text = entgetBook.BookDescription.ToString();
          txt_ActualStock.Text = entgetBook.ActualStock.ToString();
          txt_CurrentStock.Text = entgetBook.CurrentStock.ToString();
          txt_BookIssued.Text = entgetBook.BookIssued.ToString();
          ddl_AuthorName.SelectedItem.Text = entgetBook.AuthorName.ToString();
          ddl_PublisherName.SelectedItem.Text = entgetBook.PublisherName.ToString();
          ddl_Language.SelectedItem.Text = entgetBook.Language.ToString();
          
          string selectedCars = entgetBook.Genre.ToString(); 
          string[] selectedCarsArray = selectedCars.Split(',');
          foreach (string s in selectedCarsArray)
          {
            foreach (ListItem item in List_Genre.Items)
            {
              if (s == item.Value)
              {
                item.Selected = true;
              }
            }
          }
          BindGrid();
          
        }
        else
        {
          Response.Write("<script>alert(Record Not available)</script>");
          txt_BookID.Text = null;
          txt_BookName.Text = null;
          txt_Edition.Text = null;
          txt_BookCost.Text = null;
          txt_Pages.Text = null;
          txt_BookDescription.Text = null;
          txt_ActualStock.Text = null;
          txt_CurrentStock.Text = null;
          txt_BookIssued.Text = null;
          
        }
      }
      catch (Exception)
      {

        throw;
      }
    }





    private void FillAuthor()                           //Method to fill the dropdown list of author 
    {
      Bll_GetBookInventory bll_GetBook = new Bll_GetBookInventory();
      Ent_GetBookInventory entBook = new Ent_GetBookInventory();
      try
      {
        DataTable dt = new DataTable();
        dt = bll_GetBook.FillAuthorName();
        if (dt.Rows.Count>0)
        {
          ddl_AuthorName.DataSource = dt;
          ddl_AuthorName.DataTextField = "AuthorName";
          ddl_AuthorName.DataBind();
        }
        ddl_AuthorName.Items.Insert(0, new ListItem("Please select the author"));
      }
      catch (Exception)
      {

        throw;
      }
    }



    private void FillPublisher()                            //fills the publisher dropdown list
    {
      List<Ent_GetBookInventory> listPublisher = new List<Ent_GetBookInventory>();
      Bll_GetBookInventory objbll = new Bll_GetBookInventory();
      try
      {
        listPublisher = objbll.FillPublisher();
        if (listPublisher.Count > 0)
        { 
          ddl_PublisherName.DataSource = listPublisher;
          ddl_PublisherName.DataTextField = "PublisherName";
          ddl_PublisherName.DataBind();
        }
        ddl_PublisherName.Items.Insert(0, new ListItem("Please select the publisher"));
      }
      catch (Exception)
      {

        throw;
      }
    }





    //public void FillGenre()//fills the list box of genre 
    //{
    //  Bll_GetBookInventory objbll = new Bll_GetBookInventory();
    //  Ent_GetBookInventory objent = new Ent_GetBookInventory();
    //  try
    //  {
        
    //    SqlDataReader sdr  = objbll.FillGenre();
    //    if (sdr.HasRows)
    //    {
    //      List_Genre.DataSource = sdr;
    //      List_Genre.DataTextField = "Genre";
    //      List_Genre.DataBind();
    //    }
    //  }
    //  catch (Exception)
    //  {

    //    throw;
    //  }
    //}






    public bool CheckBook() //Check if the book id entered by user already exist or not
    {
      Bll_GetBookInventory bllBook = new Bll_GetBookInventory();
      Ent_GetBookInventory entBook = new Ent_GetBookInventory();
      try
      {
        string BookId = txt_BookID.Text;
        entBook = bllBook.CheckBookId(BookId);
        if( entBook.BookId != null)
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





    public string AddGenre() //method that combines the genre which is selected from listbox and seperate them with coma and return it to the add event to save it which is selected from listbox
    {
      Bll_GetBookInventory bllBook = new Bll_GetBookInventory();
      Ent_GetBookInventory entBook = new Ent_GetBookInventory();
      try
      {
        List_Genre.SelectionMode = ListSelectionMode.Multiple;
        string Genre = "";
        foreach(int i in List_Genre.GetSelectedIndices())
        {
          Genre = Genre + List_Genre.Items[i] + ",";
        }//genre = Adventure,self;-------- this is how it will show like 
        Genre = Genre.Remove(Genre.Length - 1);
        return Genre;
      }
      catch (Exception ex)
      {

        throw;
      }
    }





    public string SaveBook(FileUpload BookUpload) //method to save the url of book's image and store it in the upload folder of the project
    {
      string BookName;
      if (BookUpload.HasFile)
      {
        string FileName = txt_BookName.Text;
        FileName = FileName.Replace(" ", "").Replace("&", "").Replace("?", "").Replace("/", "").Replace("'\'", "").Replace("@", "").Replace("_", "").Replace("-", "").ToString();
        BookName = FileName + "_" + DateTime.Now.ToString("yyyyMMddHHmmtt");
        string BookExtension = Path.GetExtension(BookUpload.FileName);
        BookName = BookName + BookExtension;
        string BookUrl = "~/Upload/Books/" + BookName;
        BookUpload.SaveAs(Server.MapPath("~/Upload/Books/" + BookName));


        return BookUrl;
      }
      else
      {
        BookName = "";

      }
      return BookName;
    }





    private void FillGenre()                     // method that fills the list box of genre by binding it from database
    {
      Bll_GetBookInventory objbll = new Bll_GetBookInventory();
      List<Ent_GetBookInventory> objent = new List<Ent_GetBookInventory>();
      try
      {
        objent = objbll.FillGenre();
        if (objent.Count>0)
        {
          List_Genre.DataSource = objent;
          List_Genre.DataTextField = "Genre";
          List_Genre.DataBind();
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
    

    private void BindGrid()                       //Method to bind the grid to details of book which are coming from data base
    {
      List<Ent_GetBookInventory> list_entgetBook = new List<Ent_GetBookInventory>();
      Bll_GetBookInventory bll_GetBook = new Bll_GetBookInventory();
      try
      {
        list_entgetBook = bll_GetBook.BindBook();
        if (list_entgetBook.Count>0)
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
