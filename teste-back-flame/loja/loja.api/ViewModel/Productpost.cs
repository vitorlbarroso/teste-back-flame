using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace loja.api.ViewModel
{
    public class Productpost
    {
       public string name { get; set; } 

        public string? description { get; set; }

        public decimal price { get; set; }
  
    }
}
