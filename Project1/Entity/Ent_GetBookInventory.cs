using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public class Ent_GetBookInventory
  {
    public string BookURL { get; set; }
    public string BookId { get; set; }
    public string BookName { get; set; }
    public string PublisherName { get; set; }
    public string AuthorName { get; set; }
    public string Language { get; set; }
    public DateTime PublishDate { get; set; }
    public string Genre { get; set; }
    public string Edition { get; set; }
    public string BookCost { get; set; }
    public string Pages { get; set; }
    public int ActualStock { get; set; }
    public int CurrentStock { get; set; }
    public int BookIssued { get; set; }
    public string BookDescription { get; set; }
    public int GenreID { get; set; }
  }
}
