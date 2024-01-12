using loja.domain.Entities.Enums;
using loja.domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace loja.api.ViewModel
{
    public class Salesput
    {

        public int Id { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public Status Status { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
 
        public string BuyerFullName { get; set; }
     
        public string BuyerDocument { get; set; }
     
        public string DeliveryAddressState { get; set; }
        public string DeliveryAddressCity { get; set; }
        public string DeliveryAddressComplement { get; set; }
        public string DeliveryAddressZipCode { get; set; } = string.Empty;
      
    }
}
