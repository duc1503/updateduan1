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
    public class PhongConfiguration : IEntityTypeConfiguration<Phong>
    {
        public void Configure(EntityTypeBuilder<Phong> builder)
        {
            builder.ToTable("Phong");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.MaPhong).HasColumnName("MaPhong").HasColumnType("nvarchar(10)").IsRequired();
            builder.HasIndex(p => p.MaPhong).IsUnique();//Set Mã là duy nhất
            builder.Property(p => p.TinhTrang).HasColumnName("TinhTrang").HasColumnType("int").IsRequired();
            builder.HasOne(p => p.LoaiPhong).WithMany().HasForeignKey(p => p.IDLoaiPhong);
            
        }
    }
}
