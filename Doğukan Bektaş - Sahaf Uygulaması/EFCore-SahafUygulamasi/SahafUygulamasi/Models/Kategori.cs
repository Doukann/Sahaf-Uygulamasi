using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahafUygulamasi.Models
{
	public class Kategori
	{
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }

        //Navigation Property
        public ICollection<Kitap> Kitaplar { get; set; }
    }
}
