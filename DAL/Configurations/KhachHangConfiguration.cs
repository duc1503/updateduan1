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
    public class KhachHangConfiguration : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.ToTable("KhachHang");
            builder.HasKey(p => p.ID);
            builder.Property(p => p.MaKH).HasColumnName("MaKH").HasColumnType("nvarchar(10)").IsRequired();
            builder.HasIndex(p => p.MaKH).IsUnique();//Set Mã là duy nhất
            builder.Property(p => p.HovaTen).HasColumnName("HoTen").HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(p => p.CCCD).HasColumnName("CCCD").HasColumnType("nvarchar(12)").IsRequired();
            builder.Property(p => p.SDT).HasColumnName("SDT").HasColumnType("nvarchar(12)").IsRequired();
            builder.Property(p => p.DiaChi).HasColumnName("DiaChi").HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(p => p.GioiTinh).HasColumnName("GioiTinh").HasColumnType("int").IsRequired();
            builder.Property(p => p.QuocTich).HasColumnName("QuocTich").HasColumnType("nvarchar(20)").IsRequired();
        }
    }
}
