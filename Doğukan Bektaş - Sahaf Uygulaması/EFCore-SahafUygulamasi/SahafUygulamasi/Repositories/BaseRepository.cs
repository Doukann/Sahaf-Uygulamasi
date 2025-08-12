using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SahafUygulamasi.Data;
using SahafUygulamasi.Interfaces;

namespace SahafUygulamasi.Repositories
{
	public abstract class BaseRepository<TEntity> : ICRUD<TEntity> where TEntity : class
	{
		protected SahafDBContext _context;
		protected DbSet<TEntity> _table;

        protected BaseRepository()
        {
			_context = new SahafDBContext();
			_table = _context.Set<TEntity>();
		}
        public TEntity Ara(int id)
		{
			if(_table.Find(id) != null)
			{
				TEntity entity = _table.Find(id);
				_context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
				return entity;
			}
			return null;
		}

		public void Ekle(TEntity entity)
		{
			_table.Add(entity);
			_context.SaveChanges();
		}

		public void Guncelle(TEntity entity)
		{
			_table.Update(entity);
			_context.SaveChanges();
		}

		public List<TEntity> Listele()
		{
			return _table.ToList();
		}

		public void Sil(int id)
		{
			_table.Remove(Ara(id));
			_context.SaveChanges();
		}
	}
}
