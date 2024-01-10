using loja.data.Models;
using loja.data.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.data.Configuration
{
    public class SalesConfiguration : IEntityTypeConfiguration<Sales>
    {
        public void Configure(EntityTypeBuilder<Sales> builder)
        {
           builder.Property(s => s.PaymentMethod).HasConversion(
                p => p.ToString(),
                p => (PaymentMethod)Enum.Parse(typeof(PaymentMethod), p));
            
           builder.Property(s => s.PaymentStatus).HasConversion(
                p => p.ToString(),
                p => (PaymentStatus)Enum.Parse(typeof(PaymentStatus), p));

            builder.Property(s => s.Status).HasConversion(
               p => p.ToString(),
               p => (Status)Enum.Parse(typeof(Status), p));
        }
    }
}
