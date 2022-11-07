using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstatePlace.Data.Entities
{
  public class Product
  {
    public int Id { get; set; }
    public string Category { get; set; }
    public string Size { get; set; }
    public decimal Price { get; set; }
    public string Town { get; set; }
    public string Street { get; set; }
    public string PostCode { get; set; }
    public string Neighborhood { get; set; }
    public string Description { get; set; }
    public DateTime DateOfBuild { get; set; }
    public DateTime DateUntilPriceIsValid { get; set; }
    public string TypeOfBuild { get; set; }
  }
}
