using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SahafUygulamasi.Models.Configurations
{
	public class Yazar_CFG : IEntityTypeConfiguration<Yazar>
	{
		public void Configure(EntityTypeBuilder<Yazar> builder)
		{
			builder.Property(x => x.YazarAdiSoyadi)
				   .HasMaxLength(100)
				   .HasColumnType("varchar")
				   .IsRequired();

		}
	}
}
