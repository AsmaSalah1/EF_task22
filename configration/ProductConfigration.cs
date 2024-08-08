using EF_Task22.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task22.configration
{
    internal class ProductConfigration : IEntityTypeConfiguration<product>
    {
        public void Configure(EntityTypeBuilder<product> builder)
        {
            builder.Property(p => p.Name).HasColumnType("varchar(30)");

        }
    }
}
