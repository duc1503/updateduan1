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
    public class HoaDonChiTietConfiguration : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.ToTable("HoaDonChiTiet");
            builder.HasKey(p => new { p.IdHoaDon, p.IdDichVu});
            builder.Property(p => p.SoLuong).HasColumnName("SoLuong").HasColumnType("int").IsRequired();
            builder.Property(p => p.DonGia).HasColumnName("DonGia").HasColumnType("int").IsRequired();

            builder.HasOne(p => p.HoaDon).WithMany().HasForeignKey(p => p.IdHoaDon);
            builder.HasOne(p => p.DichVu).WithMany().HasForeignKey(p => p.IdDichVu);
        }
    }
}
