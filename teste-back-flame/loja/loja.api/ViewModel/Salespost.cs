using loja.domain.Entities.Enums;
using loja.domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace loja.api.ViewModel
{
    public class Salespost
    {

        public int ProdutoId { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PaymentMethod PaymentMethod { get; set; }
        public string BuyerFullName { get; set; }
        public string BuyerDocument { get; set; }
        public string DeliveryAddressState { get; set; }
        public string DeliveryAddressCity { get; set; } 
        public string DeliveryAddressComplement { get; set; }
        public string DeliveryAddressZipCode { get; set; }
        public decimal AmountPaid { get; set; }
    }

    
}
