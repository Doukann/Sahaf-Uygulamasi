using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahafUygulamasi.Models
{
	public class Yazar
	{
        public int YazarID { get; set; }
        public string YazarAdiSoyadi { get; set; }
        
        //Navigation Property
        public ICollection<Kitap> Kitaplar { get; set; }
    }
}
