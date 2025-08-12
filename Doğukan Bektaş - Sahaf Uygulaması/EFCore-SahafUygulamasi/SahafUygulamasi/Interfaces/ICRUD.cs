using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahafUygulamasi.Interfaces
{
	public interface ICRUD<TEntity> where TEntity : class
	{
		void Ekle(TEntity entity);
		void Guncelle(TEntity entity);
		void Sil(int id);
		List<TEntity> Listele();
		TEntity Ara(int id);
	}
}
