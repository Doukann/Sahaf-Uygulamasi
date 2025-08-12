using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SahafUygulamasi.Models;

namespace SahafUygulamasi.Data
{
	public class SahafDBContext : DbContext
	{
		public DbSet<Kitap> Kitaplar { get; set; }
		public DbSet<Yazar> Yazarlar { get; set; }
		public DbSet<Kategori> Kategoriler { get; set; }
		public DbSet<Kullanici> Kullanicilar { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);

			optionsBuilder.UseSqlServer("Data source=.;Initial catalog=EFCoreProject_SahafDB;uid=sa; pwd=123;trust server certificate=true");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
	}
}
