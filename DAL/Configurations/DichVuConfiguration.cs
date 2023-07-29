using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class DichVuConfiguration : IEntityTypeConfiguration<DichVu>
    {
        public void Configure(EntityTypeBuilder<DichVu> builder)
        {
            builder.ToTable("DichVu");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.MaDichVu).HasColumnName("MaDichVu").HasColumnType("nvarchar(10)").IsRequired();
            builder.HasIndex(p => p.MaDichVu).IsUnique().IsUnique();//Set Mã là duy nhất
            builder.Property(p => p.TenDichVu).HasColumnName("TenDichVu").HasColumnType("nvarchar(20)").IsRequired();
            builder.Property(p => p.Gia).HasColumnName("Gia ").HasColumnType("int").IsRequired();

            builder.HasOne(p => p.LoaiDichVu).WithMany().HasForeignKey(p => p.IDLoaiDichVu);
        }
    }
}
