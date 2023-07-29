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
    public class TaiKhoanConfiguration : IEntityTypeConfiguration<TaiKhoan>
    {
        public void Configure(EntityTypeBuilder<TaiKhoan> builder)
        {
            builder.ToTable("TaiKhoan");
            builder.HasKey(x => x.ID);
            builder.Property(p => p.TenTaiKhoan).HasColumnName("TenTaiKhoan")
                .HasColumnType("nvarchar(20)").IsRequired();
            builder.HasIndex(p => p.TenTaiKhoan).IsUnique();//Set Mã là duy nhất
            builder.Property(p => p.MatKhau).HasColumnName("MatKhau")
              .HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(p => p.CapDoQuyen).HasColumnName("CapDoQuyen")
              .HasColumnType("int").IsRequired();

            //FK
            builder.HasOne(p => p.NhanVien).WithOne(p => p.TaiKhoan).HasForeignKey<TaiKhoan>(p => p.IDNv);
        }
    }
}
