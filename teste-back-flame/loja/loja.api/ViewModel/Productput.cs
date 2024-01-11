using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace loja.api.ViewModel
{
    public class Productput
    {
      
        public int id { get; set; }      
        public string name { get; set; }     
        public string? description { get; set; }     
        public decimal price { get; set; }
        public bool isBlocked { get; set; }    
        public byte[]? timestamps { get; set; }

    }
}
