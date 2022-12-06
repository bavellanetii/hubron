using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(g => g.Grade).WithMany().HasForeignKey(p => p.GradeId);
            builder.HasOne(w => w.Warehouse).WithMany().HasForeignKey(w => w.WarehouseId);
            builder.HasOne(s => s.Status).WithMany().HasForeignKey(s => s.StatusId);
            builder.HasOne(l => l.LotNumber).WithMany().HasForeignKey(l => l.LotNumberId);
            builder.HasOne(p => p.Packaging).WithMany().HasForeignKey(p => p.PackagingId);
        }
    }
}