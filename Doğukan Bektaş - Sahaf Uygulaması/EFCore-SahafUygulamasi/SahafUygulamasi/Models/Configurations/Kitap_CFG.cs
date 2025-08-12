using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SahafUygulamasi.Models.Configurations
{
	public class Kitap_CFG : IEntityTypeConfiguration<Kitap>
	{
		public void Configure(EntityTypeBuilder<Kitap> builder)
		{
			builder.Property(x => x.KitapAdi)
				   .HasMaxLength(100)
				   .HasColumnType("varchar")
				   .IsRequired();
			builder.Property(x => x.KitapAciklamasi)
				   .HasMaxLength(300)
				   .HasColumnType("varchar")
				   .IsRequired(false);
			builder.Property(x => x.Fiyat)
				   .HasMaxLength(50)
				   .HasColumnType("money")
				   .IsRequired();
			builder.Property(x => x.KapakResmi)
				   .HasMaxLength(50)
				   .HasColumnType("varchar")
				   .HasDefaultValue("resimYok.jpg");
		}
	}
}
