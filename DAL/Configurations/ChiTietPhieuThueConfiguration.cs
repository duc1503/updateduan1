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
    public class ChiTietPhieuThueConfiguration : IEntityTypeConfiguration<ChiTietPhieuThue>
    {
        public void Configure(EntityTypeBuilder<ChiTietPhieuThue> builder)
        {
            builder.ToTable("CTPhieuThue");
            builder.HasKey(p => p.ID);
            builder.Property(p => p.NgayBatDau).HasColumnName("NgayBatDau").HasColumnType("datetime").IsRequired();
            builder.Property(p => p.NgayKetThuc).HasColumnName("NgayKetThuc").HasColumnType("datetime").IsRequired();
           // builder.Property(p => p.MaCTPT).HasColumnName("MaCTPT").HasColumnType("nvarchar(10)").IsRequired();
            
            builder.HasOne(p => p.PhieuThue).WithMany().HasForeignKey(p => p.IdPhieuThue);
            builder.HasOne(p => p.Phong).WithMany().HasForeignKey(p => p.IdPhong);
        }
    }
}
