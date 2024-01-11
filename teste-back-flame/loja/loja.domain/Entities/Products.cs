using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.domain.Entities
{
    [Table("Products")]
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(250)]
        public string name { get; set; } = string.Empty;

        [StringLength(400)]
        public string? description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal price { get; set; }
        public bool isBlocked { get; set; } = false;

        [Timestamp]
        public byte[]? timestamps { get; set; }       


    }
}
