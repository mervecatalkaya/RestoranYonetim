using Models;
using System;
using System.Collections.Generic;

namespace DalLayer.Repositories.Abstract
{
    public interface ISiparisRepository : ICRUD<Siparis>
    {
        List<Siparis> MasayaGoreSiparisler(int masaID);
        List<Siparis> AktifSiparisler();
        List<Siparis> TariheGoreSiparisler(DateTime tarih);
        decimal GunlukCiro(DateTime tarih);
    }
}