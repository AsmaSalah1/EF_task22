using EF_Task22.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task22.configration
{
    internal class OrderConfigration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            //builder.Property(p => p.CreatedAt).HasComputedColumnSql("GETDATE");
            builder.Property("Address").HasDefaultValue("Nablus");
            builder.Property(p => p.Address).HasColumnType("varchar(30)");


        }
    }
}
