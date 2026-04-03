using Models;
using System;
using System.Collections.Generic;

namespace BllLayer.Services.SiparisServis
{
    public interface ISiparisServis
    {
        void SiparisEkle(Siparis siparis);
        void SiparisGuncelle(Siparis siparis);
        void SiparisSil(int id);
        Siparis SiparisGetir(int id);
        List<Siparis> TumSiparisler();
        List<Siparis> MasayaGoreSiparisler(int masaId);
        List<Siparis> AktifSiparisler();
        List<Siparis> TariheGoreSiparisler(DateTime tarih);
        decimal GunlukCiro(DateTime tarih);
        void SiparisDurumGuncelle(int siparisId, string durum);
    }
}
