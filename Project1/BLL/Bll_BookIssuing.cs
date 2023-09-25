using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DAL;
using Entity;

namespace BLL
{
  public class Bll_BookIssuing
  {
    DataAccessMethod objdal = new DataAccessMethod();
    public Ent_BookIssuing FillData(int MemberId,string BookId) //to fill the textboxes of member name and bookname
    {
      Ent_BookIssuing entBookIssue = new Ent_BookIssuing();
      using (SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_SelectMemberBook_BookIssuing", MemberId, BookId))
      {
        while (sdr.Read())
        {
          entBookIssue.MemberName = sdr["MemberName"] as string;
          entBookIssue.BookName = sdr["BookName"] as string;
        }
        return entBookIssue;
      }
    }


    public int IssueBook(Ent_BookIssuing ent_BookIssuing)//to issue the book
    {
      return objdal.InsertRecord("usp_Insert_BookIssuing", ent_BookIssuing.MemberId, ent_BookIssuing.BookId, ent_BookIssuing.MemberName, ent_BookIssuing.BookName, ent_BookIssuing.IssueDate, ent_BookIssuing.DueDate);
    }






    public int ReturnBook(Ent_BookIssuing ent_BookIssuing)
    {
      return objdal.DeleteRecord("usp_Return_BookIssuing", ent_BookIssuing.MemberId, ent_BookIssuing.BookId, ent_BookIssuing.MemberName, ent_BookIssuing.BookName, ent_BookIssuing.IssueDate, ent_BookIssuing.DueDate);
    }
  


    public List<Ent_BookIssuing> BindGrid()
    {
      List<Ent_BookIssuing> listent = new List<Ent_BookIssuing>();
      using (SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_Bind_BookIssueDetails"))
      {
        while (sdr.Read())
        {
          Ent_BookIssuing entIssue = new Ent_BookIssuing();
          entIssue.BookId = sdr["BookId"] as string;
          entIssue.BookName = sdr["BookName"] as string;
          entIssue.MemberId = Convert.ToInt32(sdr["MemberId"]);
          entIssue.MemberName = sdr["MemberName"] as string;
          entIssue.IssueDate = Convert.ToDateTime(sdr["IssueDate"]);
          entIssue.DueDate = Convert.ToDateTime(sdr["DueDate"]);
          listent.Add(entIssue);
        }
        return listent;
      }
    }//to bind the grid 




    public Ent_BookIssuing CheckIssuedBook(string BookId,int MemberId )//to check if book has been issued already to that particular member or not
    {
      Ent_BookIssuing entBookIssue = new Ent_BookIssuing();
      using (SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_check_issueBook", BookId,MemberId))
      {
        while (sdr.Read())
        {
          entBookIssue.MemberName = sdr["MemberName"] as string;
          entBookIssue.BookName = sdr["BookName"] as string;
        }
        return entBookIssue;
      }
    }
  }
}
