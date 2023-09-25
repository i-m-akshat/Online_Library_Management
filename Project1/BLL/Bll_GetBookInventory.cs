using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Entity;
using DAL;

namespace BLL
{
  public class Bll_GetBookInventory
  {
    DataAccessMethod objdal = new DataAccessMethod();
    public DataTable FillAuthorName()
    {
      Bll_GetBookInventory bllBook = new Bll_GetBookInventory();
      Ent_GetBookInventory entBook = new Ent_GetBookInventory();
      try
      {
        return objdal.SelectRecordByDatatable("usp_SelectAuthorName_Author");
      }
      catch (Exception)
      {

        throw;
      }
    }
    public List<Ent_GetBookInventory> FillPublisher()
    {
      List<Ent_GetBookInventory> listent = new List<Ent_GetBookInventory>();
      try
      {
        using (SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_SelectPublisherName_Publisher"))
        {
          while (sdr.Read())
          {
            Ent_GetBookInventory objent = new Ent_GetBookInventory();
            objent.PublisherName = sdr["PublisherName"] as string;
            listent.Add(objent);
          }
          return listent;
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
    public Ent_GetBookInventory CheckBookId(string BookId)
    {
      using (SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_Check_Book", BookId))
      {
        Ent_GetBookInventory entBook = new Ent_GetBookInventory();
        while (sdr.Read())
        {
          entBook.BookName = sdr["BookName"] as string;
        }
        return entBook;
      }
    }
    //public SqlDataReader FillGenre()
    //{
    //  try
    //  {

    //    SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_Bind_Genre");
    //    return sdr;
    //  }
    //  catch (Exception)
    //  {

    //    throw;
    //  }
    //}
    public int InsertBookDetails(Ent_GetBookInventory ent_GetBook)
    {
      return objdal.InsertRecord("usp_Insert_Book", ent_GetBook.BookId, ent_GetBook.BookName, ent_GetBook.Genre, ent_GetBook.AuthorName, ent_GetBook.PublisherName, ent_GetBook.PublishDate, ent_GetBook.Language, ent_GetBook.Edition, ent_GetBook.BookCost, ent_GetBook.Pages, ent_GetBook.BookDescription, ent_GetBook.ActualStock, ent_GetBook.CurrentStock, ent_GetBook.BookURL, ent_GetBook.BookIssued);
    }
    public List<Ent_GetBookInventory> FillGenre()
    {
      List<Ent_GetBookInventory> listGenre = new List<Ent_GetBookInventory>();
      try
      {
        using (SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_Bind_Genre"))
        {
          while (sdr.Read())
          {
            Ent_GetBookInventory objent = new Ent_GetBookInventory();
            objent.Genre = sdr["Genre"] as string;
            listGenre.Add(objent);
          }
          return listGenre;
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
    public int DeleteBook(Ent_GetBookInventory entgetbook)
    {
      return objdal.DeleteRecord("usp_Delete_Books", entgetbook.BookId);
    }
    public int UpdateBook(Ent_GetBookInventory ent_GetBook)
    {
      try
      {
        return objdal.UpdateRecord("usp_Update_Books", ent_GetBook.BookId,ent_GetBook.BookName,ent_GetBook.Genre,ent_GetBook.AuthorName,ent_GetBook.PublisherName,ent_GetBook.PublishDate,ent_GetBook.Language,ent_GetBook.Edition,ent_GetBook.BookCost,ent_GetBook.Pages,ent_GetBook.BookDescription,ent_GetBook.ActualStock,ent_GetBook.CurrentStock,ent_GetBook.BookURL);
      }
      catch (Exception)
      {

        throw;
      }
    }
    public Ent_GetBookInventory SearchBookById(string BookId)
    {
      Ent_GetBookInventory EntGetBook = new Ent_GetBookInventory();
      try
      {
        using (SqlDataReader sdr= objdal.SelectRecordBydataReader("usp_Show_BooksById", BookId))
        {
          
          while (sdr.Read())
          {
            
            EntGetBook.BookId = sdr["BookId"] as string;
            EntGetBook.BookName = sdr["BookName"] as string;
            EntGetBook.Genre = sdr["Genre"] as string;
            EntGetBook.PublisherName = sdr["PublisherName"] as string;
            EntGetBook.PublishDate = Convert.ToDateTime(sdr["PublishDate"]);
            EntGetBook.AuthorName = sdr["AuthorName"] as string;
            EntGetBook.Language = sdr["Language"] as string;
            EntGetBook.Edition = sdr["Edition"] as string;
            EntGetBook.BookCost = sdr["BookCost"] as string;
            EntGetBook.Pages = sdr["NumberOfPages"] as string;
            EntGetBook.ActualStock = Convert.ToInt32(sdr["ActualStock"]);
            EntGetBook.CurrentStock = Convert.ToInt32(sdr["CurrentStock"]);
            EntGetBook.BookIssued = Convert.ToInt32(sdr["BookIssued"]);
            EntGetBook.BookDescription = sdr["BookDescription"] as string;
          }
        return EntGetBook;
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
    public List<Ent_GetBookInventory> BindBook()
    {
      using (SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_Bind_Books"))
      {
        List<Ent_GetBookInventory> List_entgetbook = new List<Ent_GetBookInventory>();
        while (sdr.Read())
        {
          Ent_GetBookInventory entgetbook = new Ent_GetBookInventory();
          entgetbook.BookId = sdr["BookId"] as string;
          entgetbook.BookName = sdr["BookName"] as string;
          entgetbook.Genre = sdr["Genre"] as string;
          entgetbook.AuthorName = sdr["AuthorName"] as string;
          entgetbook.PublisherName = sdr["PublisherName"] as string;
          entgetbook.PublishDate = Convert.ToDateTime(sdr["PublishDate"]);
          entgetbook.Language = sdr["Language"] as string;
          entgetbook.Edition = sdr["Edition"] as string;
          entgetbook.BookCost = sdr["BookCost"] as string;
          entgetbook.Pages = sdr["NumberOfPages"] as string;
          entgetbook.BookDescription = sdr["BookDescription"] as string;
          entgetbook.ActualStock = Convert.ToInt32(sdr["ActualStock"]);
          entgetbook.CurrentStock = Convert.ToInt32(sdr["CurrentStock"]);
          entgetbook.BookURL= sdr["BookImageLink"] as string;
          entgetbook.BookIssued = Convert.ToInt32(sdr["BookIssued"]);
          List_entgetbook.Add(entgetbook);
        }
        return List_entgetbook;
      }
    }
  }
}
