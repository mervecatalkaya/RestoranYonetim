using DalLayer.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;

namespace DalLayer.Repositories.Concretes
{
    public class MasaRepository : JenerikRepo<Masa>, IMasaRepository
    {
        public MasaRepository(DbContext context) : base(context) { }

        public List<Masa> BosMasalariGetir()
        {
            // .AsNoTracking() ekledik
            return _tablo.AsNoTracking().Where(m => m.Durum == "Boş").ToList();
        }

        public Masa MasaNoIleGetir(string masaNo)
        {
            // .AsNoTracking() ekledik
            return _tablo.AsNoTracking().FirstOrDefault(m => m.MasaNo == masaNo);
        }

        public List<Masa> KonumaGoreGetir(string konum)
        {
            // .AsNoTracking() ekledik
            return _tablo.AsNoTracking().Where(m => m.Konum == konum).ToList();
        }
    }
}


