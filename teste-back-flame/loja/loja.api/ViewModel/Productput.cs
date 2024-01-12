using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace loja.api.ViewModel
{
    public class Productput
    {
      
        public int Id { get; set; }      
        public string Name { get; set; }     
        public string? Description { get; set; }     
        public decimal Price { get; set; }
        public bool IsBlocked { get; set; }    
        
   

    }
}
