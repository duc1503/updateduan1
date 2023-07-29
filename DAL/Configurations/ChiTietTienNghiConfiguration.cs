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
    internal class ChiTietTienNghiConfiguration : IEntityTypeConfiguration<ChiTietTienNghi>
    {
        public void Configure(EntityTypeBuilder<ChiTietTienNghi> builder)
        {
            builder.ToTable("ChiTietTienNghi");
            builder.HasKey(p => p.ID);
            builder.Property(p => p.MaCTTienNghi).HasColumnName("MaCTTienNghi")
                .HasColumnType("nvarchar(10)").IsRequired();
            builder.HasIndex(p => p.MaCTTienNghi).IsUnique();//Set Mã là duy nhất
            builder.Property(p => p.TenCTTienNghi).HasColumnName("TenCTTienNghi")
                .HasColumnType("nvarchar(20)").IsRequired();
            //FK
            builder.HasOne(p => p.LoaiTienNghi).WithMany()
                .HasForeignKey(p => p.IDLoaiTienNghi);
            builder.HasOne(p => p.Phong).WithMany()
                .HasForeignKey(p => p.IdPhong);
        }
    }
}
