using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SahafUygulamasi.Models.Configurations
{
	public class Kategori_CFG : IEntityTypeConfiguration<Kategori>
	{
		public void Configure(EntityTypeBuilder<Kategori> builder)
		{
			builder.Property(x => x.KategoriAdi)
				   .HasMaxLength(50)
				   .HasColumnType("varchar")
				   .IsRequired();
			builder.HasData(new Kategori { KategoriID = 1, KategoriAdi = "Roman" },
							new Kategori { KategoriID = 2, KategoriAdi = "Hikaye" },
							new Kategori { KategoriID = 3, KategoriAdi = "Şiir" },
							new Kategori { KategoriID = 4, KategoriAdi = "Deneme" },
							new Kategori { KategoriID = 5, KategoriAdi = "Sanat" },
							new Kategori { KategoriID = 6, KategoriAdi = "Çocuk Kitapları" }
		    				);
		}
	}
}
