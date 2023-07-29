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
    public class PhieuThueConfiguration : IEntityTypeConfiguration<PhieuThue>
    {
        public void Configure(EntityTypeBuilder<PhieuThue> builder)
        {
            builder.ToTable("PhieuThue");
            builder.HasKey(p => p.ID);
            builder.Property(p => p.NgayLapPhieu).HasColumnName("NgayLapPhieu").HasColumnType("datetime").IsRequired();
            builder.Property(p => p.MaPhieuThue).HasColumnName("MaPhieuThue").HasColumnType("int").IsRequired();
            
            builder.HasOne(p => p.KhachHang).WithMany().HasForeignKey(p => p.IdKH);
            builder.HasOne(p => p.NhanVien).WithMany().HasForeignKey(p => p.IdNV);
        }
    }
}
