using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Entity
{
  public class Ent_UserProfile
  {
    public string FullName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string EMail { get; set; }
    public string FullAddress { get; set; }
    public string State { get; set; }
    public string City { get; set; }
    public string UserId { get; set; }
    public string Password { get; set; }
    public string NewPassword { get; set; }
    public string AccountStatus { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime DueDate { get; set; }
    public int MemberId { get; set; }
   public string BookId { get; set; }
    public string BookName { get; set; }

  }
}
