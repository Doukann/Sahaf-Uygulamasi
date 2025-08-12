using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahafUygulamasi.Models
{
	public class Kullanici
	{
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

		//Navigation Property
		public ICollection<Kitap> Kitaplar { get; set; }
	}
}
