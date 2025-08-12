using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SahafUygulamasi.Models;
using SahafUygulamasi.Models.ViewModels;

namespace SahafUygulamasi.Repositories
{
	public class YazarRepository : BaseRepository<Yazar>
	{
		public List<Yazar_VM> TumYazarBilgileri()
		{
			return _context.Yazarlar.Select(x => new Yazar_VM
			{
				YazarID = x.YazarID,
				YazarAdiSoyadi = x.YazarAdiSoyadi
			}).ToList();
		}
	}
}
