using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SahafUygulamasi.Models;
using SahafUygulamasi.Models.ViewModels;

namespace SahafUygulamasi.Repositories
{
	public class KategoriRepository : BaseRepository<Kategori>
	{
		public List<Kategori_VM> TumKategoriBilgileri()
		{
			return _context.Kategoriler.Select(x => new Kategori_VM
			{
				KategoriID = x.KategoriID,
				KategoriAdi = x.KategoriAdi,
			}).ToList();
		}
	}
}
