// ============================================

// UrunRepository.cs
using DalLayer.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace DalLayer.Repositories.Concretes
{
    public class UrunRepository : JenerikRepo<Urun>, IUrunRepository
    {
        public UrunRepository(DbContext context) : base(context)
        {
        }

        // Özel metodlar
        public List<Urun> KategoriyeGoreGetir(string kategori)
        {
            return _tablo.Where(u => u.Kategori == kategori).ToList();
        }

        public List<Urun> MevcutUrunler()
        {
            return _tablo.Where(u => u.Durum == true && u.Stok > 0).ToList();
        }

        public List<Urun> FiyataGoreSirala()
        {
            return _tablo.OrderBy(u => u.Fiyat).ToList();
        }
    }
}
