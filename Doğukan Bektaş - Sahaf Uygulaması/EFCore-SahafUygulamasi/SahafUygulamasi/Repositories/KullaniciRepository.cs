using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SahafUygulamasi.Models;
using SahafUygulamasi.Models.ViewModels;

namespace SahafUygulamasi.Repositories
{
	public class KullaniciRepository : BaseRepository<Kullanici>
	{
		public List<Kullanici_VM> TumKullaniciBilgileri()
		{
			return _context.Kullanicilar.Select(x => new Kullanici_VM
			{
				KullaniciID = x.KullaniciID,
				KullaniciAdi = x.KullaniciAdi,
				Sifre = x.Sifre
			}).ToList();
		}
	}
}
