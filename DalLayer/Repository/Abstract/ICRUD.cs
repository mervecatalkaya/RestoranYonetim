using System.Collections.Generic;

namespace DalLayer.Repositories.Abstract
{
    public interface ICRUD<TEntity> where TEntity : class
    {
        void Ekle(TEntity entity);
        void Guncelle(TEntity entity);
        void Sil(int id);
        TEntity IdyeGoreGetir(int id);
        List<TEntity> TumunuListele();
    }
}