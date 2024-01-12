using loja.domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace loja.domain.Entities
{
    [Table("Sales")]
    public  class Sales
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ProdutoId { get; set; }
        public virtual Products Produto { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PurchaseCode { get; set; }

        public PaymentMethod PaymentMethod { get; set; }
        public Status Status { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        [StringLength(250)]
        public string BuyerFullName { get; set; } =  string.Empty;
        [StringLength(350)]
        public string BuyerDocument { get; set; } = string.Empty;
        [StringLength(50)]
        public string DeliveryAddressState { get; set; } =  string.Empty;
        [StringLength(150)]
        public string DeliveryAddressCity { get; set; } =  string.Empty;
        [StringLength(150)]
        public string DeliveryAddressComplement { get; set; } = string.Empty;
        [StringLength(150)]
        public string DeliveryAddressZipCode { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal AmountPaid { get ; set; }
     
    }
}
