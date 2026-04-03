using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace DalLayer.Repositories.Abstract
{
    public abstract class JenerikRepo<TEntity> : ICRUD<TEntity> where TEntity : class
    {
        protected DbContext _context;
        protected DbSet<TEntity> _tablo;

        public JenerikRepo(DbContext context)
        {
            _context = context;
            _tablo = _context.Set<TEntity>();
        }

        public void Ekle(TEntity entity)
        {
            _tablo.Add(entity);
            _context.SaveChanges();
        }

        public void Guncelle(TEntity entity)
        {
            // Veritabanı bağlamındaki (Context) takibi kontrol et
            var local = _context.Set<TEntity>().Local.FirstOrDefault(e => e.Equals(entity));

            if (local != null)
            {
                // Eğer aynı nesne zaten takip ediliyorsa, takibi bırak (Detach)
                _context.Entry(local).State = EntityState.Detached;
            }

            _tablo.Update(entity);
            _context.SaveChanges();
        }

        public void Sil(int id)
        {
            var entity = IdyeGoreGetir(id);
            if (entity != null)
            {
                _tablo.Remove(entity);
                _context.SaveChanges();
            }
        }

        public TEntity IdyeGoreGetir(int id)
        {
            // Önce nesneyi bulur (EF burada takibe başlar)
            var entity = _tablo.Find(id);

            if (entity != null)
            {
                // Bulunan nesneyi hafızadan (Change Tracker) hemen koparırız
                // Böylece güncelleme yaparken çakışma yaşanmaz
                _context.Entry(entity).State = EntityState.Detached;
            }

            return entity;
        }

        public List<TEntity> TumunuListele()
        {
            return _tablo.ToList();
        }
    }
}
