using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SahafUygulamasi.Utilities;

namespace SahafUygulamasi.Models.Configurations
{
	public class Kullanici_CFG : IEntityTypeConfiguration<Kullanici>
	{
		public void Configure(EntityTypeBuilder<Kullanici> builder)
		{
			builder.Property(x => x.KullaniciAdi)
				   .HasMaxLength(20)
				   .HasColumnType("varchar")
				   .IsRequired();
			builder.Property(x => x.Sifre)
				   .HasMaxLength(100)
				   .HasColumnType("varchar")
				   .IsRequired();

			builder.HasData(new Kullanici { KullaniciID = 1, KullaniciAdi = "Dodo", Sifre=Hasher.Md5Hash("Do_123")});
		}
	}
}
