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
    public class LoaiTienNghiConfiguration : IEntityTypeConfiguration<LoaiTienNghi>
    {
        public void Configure(EntityTypeBuilder<LoaiTienNghi> builder)
        {
            builder.ToTable("LoaiTienNghi");
            builder.HasKey(p => p.ID);
            builder.Property(p => p.MaLoaiTienNghi).HasColumnName("MaLoaiTienNghi")
                .HasColumnType("nvarchar(10)").IsRequired();
            builder.HasIndex(p => p.MaLoaiTienNghi).IsUnique();//Set Mã là duy nhất
            builder.Property(p => p.TenLoaiTienNghi).HasColumnName("TenLoaiTienNghi")
                .HasColumnType("nvarchar(20)").IsRequired();
        }
    }
}
