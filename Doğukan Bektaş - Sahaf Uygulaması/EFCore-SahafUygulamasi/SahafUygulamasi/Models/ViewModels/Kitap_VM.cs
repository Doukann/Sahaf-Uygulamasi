using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahafUygulamasi.Models.ViewModels
{
	public class Kitap_VM
	{
		public int KitapID { get; set; }
		public string KitapAdi { get; set; }
		public string KitapAciklamasi { get; set; }
		public decimal Fiyat { get; set; }
		public string KapakResmi { get; set; }

		public string YazarAdiSoyadi { get; set; }
		public string KategoriAdi { get; set; }
		public string KullaniciAdi { get; set; }
	}
}
