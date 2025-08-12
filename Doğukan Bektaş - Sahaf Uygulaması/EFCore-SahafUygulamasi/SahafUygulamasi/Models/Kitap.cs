using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahafUygulamasi.Models
{
	public class Kitap
	{
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public string KitapAciklamasi { get; set; }
        public decimal Fiyat { get; set; }
        public string KapakResmi { get; set; }

        public int YazarID { get; set; }
        public int KategoriID { get; set; }
        public int KullaniciID { get; set; }

        //Navigation Properties
        public Yazar? Yazar { get; set; }
        public Kategori? Kategori { get; set; }
        public Kullanici? Kullanici { get; set; }

    }
}
