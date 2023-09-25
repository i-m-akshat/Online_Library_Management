using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;
using DAL;

namespace BLL
{
 public class BllAuthorDetails
  {
   
    DataAccessMethod objdal = new DataAccessMethod();
    public DataTable GetAuthor(EntAuthorDetails objentAuthorDetails)
    {
      return objdal.SelectRecordByDatatable("usp_Show_Author", objentAuthorDetails.AuthorID,objentAuthorDetails.AuthorName);
    }
    public int AuthorAdd(EntAuthorDetails objentAuthorDetails)
    {
      return objdal.InsertRecord("usp_Add_Author", objentAuthorDetails.AuthorID,objentAuthorDetails.AuthorName);
    }
    public int AuthorUpdate(EntAuthorDetails objentAuthorDetails)
    {
      return objdal.UpdateRecord("usp_Update_Author", objentAuthorDetails.AuthorID, objentAuthorDetails.AuthorName);
    }
    public int AuthorDelete(EntAuthorDetails objentAuthorDetails)
    {
      return objdal.DeleteRecord("usp_Delete_Author", objentAuthorDetails.AuthorID, objentAuthorDetails.AuthorName);
    }
    public DataTable CheckAuthor(EntAuthorDetails entAuthorDetails)
    {
      return (objdal.SelectRecordByDatatable("usp_Check_Author", entAuthorDetails.AuthorID));
    }
  }
}
