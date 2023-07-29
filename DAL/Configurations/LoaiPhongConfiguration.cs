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
    public class LoaiPhongConfiguration : IEntityTypeConfiguration<LoaiPhong>
    {
        public void Configure(EntityTypeBuilder<LoaiPhong> builder)
        {
            builder.ToTable("LoaiPhong");
            builder.HasKey(p => p.ID);
            builder.Property(p => p.MaLoaiPhong).HasColumnName("MaLoaiPhong").HasColumnType("nvarchar(10)").IsRequired();
            builder.HasIndex(p => p.MaLoaiPhong).IsUnique();//Set Mã là duy nhất
            builder.Property(p => p.TenLoaiPhong).HasColumnName("TenLoaiPhong").HasColumnType("nvarchar(20)").IsRequired();
            builder.Property(p => p.SoGiuong).HasColumnName("SoGiuong").HasColumnType("int").IsRequired();
            builder.Property(p => p.GiaNgay).HasColumnName("GiayNgay").HasColumnType("int").IsRequired();
        }
    }
}
