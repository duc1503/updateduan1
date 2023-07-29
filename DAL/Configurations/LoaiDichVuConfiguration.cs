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
    public class LoaiDichVuConfiguration : IEntityTypeConfiguration<LoaiDichVu>
    {
        public void Configure(EntityTypeBuilder<LoaiDichVu> builder)
        {
            builder.ToTable("LoaiDichVu");
            builder.HasKey(p => p.ID);
            builder.Property(p => p.MaLoaiDichVu).HasColumnName("MaLoaiDichVu").HasColumnType("nvarchar(10)").IsRequired();
            builder.HasIndex(p => p.MaLoaiDichVu).IsUnique();//Set Mã là duy nhất
            builder.Property(p => p.TenLoaiDichVu).HasColumnName("TenLoaiDichVu").HasColumnType("nvarchar(20)").IsRequired();
        }
    }
}
