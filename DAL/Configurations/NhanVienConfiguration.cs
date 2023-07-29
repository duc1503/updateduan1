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
    internal class NhanVienConfiguration : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");  // Dat ten bang
            builder.HasKey(x => x.ID);  // set PK
            // Cau hinh cac cot
            builder.Property(p => p.MaNV).HasColumnName("MaNV")
                .HasColumnType("nvarchar(10)").IsRequired();
            builder.HasIndex(p => p.MaNV).IsUnique();//Set Mã là duy nhất
            builder.Property(p => p.TenNV).HasColumnName("TenNV")
                .HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(p => p.NgaySinh).HasColumnName("NgaySinh")
                .HasColumnType("datetime").IsRequired();
            builder.Property(p => p.GioiTinh).HasColumnName("GioiTinh")
                .HasColumnType("int").IsRequired();
            builder.Property(p => p.DiaChi).HasColumnName("DiaChi")
                .HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(p => p.SDT).HasColumnName("SDT")
                .HasColumnType("nvarchar(12)").IsRequired();
            builder.Property(p => p.CCCD).HasColumnName("CCCD")
                .HasColumnType("nvarchar(12)").IsRequired();
            builder.Property(p => p.Luong).HasColumnName("Luong")
                .HasColumnType("int").IsRequired();

            builder.Property(p => p.IDCv).HasColumnName("IDCv")
                .IsRequired();

            // set FK
            builder.HasOne(p => p.ChucVu)
                .WithMany().HasForeignKey(p => p.IDCv);


        }
    }
}
