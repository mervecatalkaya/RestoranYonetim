// SiparisRepository.cs
using DalLayer.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DalLayer.Repositories.Concretes
{
    public class SiparisRepository : JenerikRepo<Siparis>, ISiparisRepository
    {
        public SiparisRepository(DbContext context) : base(context)
        {
        }

        // Özel metodlar
        public List<Siparis> MasayaGoreSiparisler(int masaID)
        {
            return _tablo
                .Include(s => s.Masa)
                .Include(s => s.Urun)
                .Where(s => s.MasaID == masaID)
                .ToList();
        }

        public List<Siparis> AktifSiparisler()
        {
            return _tablo
                .Include(s => s.Masa)
                .Include(s => s.Urun)
                .Where(s => s.Durum == "Hazırlanıyor")
                .ToList();
        }

        public List<Siparis> TariheGoreSiparisler(DateTime tarih)
        {
            return _tablo
                .Where(s => s.SiparisTarihi.Date == tarih.Date)
                .ToList();
        }

        public decimal GunlukCiro(DateTime tarih)
        {
            return _tablo
                .Where(s => s.SiparisTarihi.Date == tarih.Date)
                .Sum(s => s.ToplamTutar);
        }
    }
}