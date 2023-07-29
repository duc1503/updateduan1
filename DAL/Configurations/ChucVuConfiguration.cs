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
    internal class ChucVuConfiguration : IEntityTypeConfiguration<ChucVu>
    {
        public void Configure(EntityTypeBuilder<ChucVu> builder)
        {
            builder.ToTable("ChucVu");  // Dat ten bang
            builder.HasKey(x => x.ID);  // set PK
            // Cau hinh cac cot
            builder.Property(p => p.MaCV).HasColumnName("MaCV").HasColumnType("nvarchar(10)").IsRequired();
            builder.HasIndex(p => p.MaCV).IsUnique();//Set Mã là duy nhất
            builder.Property(p => p.TenCV).HasColumnName("TenCV").HasColumnType("nvarchar(50)").IsRequired();
          

        }
    }
}
