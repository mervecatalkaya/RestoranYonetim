using Models;
using System;
using System.Collections.Generic;

namespace BllLayer.Services.MasaServis
{
    public interface IMasaServis
    {
        void MasaEkle(Masa masa);
        void MasaGuncelle(Masa masa);
        void MasaSil(int id);
        Masa MasaGetir(int id);
        List<Masa> TumMasalar();
        List<Masa> BosMasalar();
        Masa MasaNoIleGetir(string masaNo);
        List<Masa> KonumaGoreGetir(string konum);
    }
}