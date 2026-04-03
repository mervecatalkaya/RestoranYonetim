using Models;
using System;
using System.Collections.Generic;

namespace BllLayer.Services.UrunServis
{
    public interface IUrunServis
    {
        void UrunEkle(Urun urun);
        void UrunGuncelle(Urun urun);
        void UrunSil(int id);
        Urun UrunGetir(int id);
        List<Urun> TumUrunler();
        List<Urun> KategoriyeGoreGetir(string kategori);
        List<Urun> MevcutUrunler();
        List<Urun> FiyataGoreSirala();
    }
}