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
 public class Ent_BookIssuing
  {
    public int MemberId { get; set; }
    public string BookId { get; set; }
    public string MemberName { get; set; }
    public string BookName { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime DueDate { get; set; }
  }
}
