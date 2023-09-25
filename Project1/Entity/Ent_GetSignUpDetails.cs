using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public class Ent_GetSignUpDetails
  {
    public string FullName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string ContactNumber { get; set; }
    public string EMail { get; set; }
    public string State { get; set; }
    public string City { get; set; }
    public string Pincode { get; set; }
    public string FullAddress { get; set; }
    public string UserId { get; set; }
    public string Password { get; set; }
    public string AccountStatus { get; set; }
    public int MemberId { get; set; }
    public int StateId { get; set; }
    public int CityId { get; set; }
  }
}
