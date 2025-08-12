using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SahafUygulamasi.Models;
using SahafUygulamasi.Models.ViewModels;

namespace SahafUygulamasi.Repositories
{
	public class KitapRepository : BaseRepository<Kitap>
	{
		public List<Kitap_VM> TumKitapBilgileri()
		{
			return _context.Kitaplar.Select(x => new Kitap_VM
			{
				KitapID = x.KitapID,
				KitapAdi = x.KitapAdi,
				KitapAciklamasi = x.KitapAciklamasi,
				Fiyat = x.Fiyat,
				KapakResmi = x.KapakResmi,
				KategoriAdi = x.Kategori.KategoriAdi,
				YazarAdiSoyadi = x.Yazar.YazarAdiSoyadi,
				KullaniciAdi = x.Kullanici.KullaniciAdi

			}).ToList();
		}
	}
}
