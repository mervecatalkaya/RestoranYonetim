using DalLayer.Repositories.Abstract;
using Models;
using System;
using System.Collections.Generic;

namespace BllLayer.Services.MasaServis
{
    public class MasaServis : IMasaServis
    {
        private readonly IMasaRepository _masaRepository;

        public MasaServis(IMasaRepository masaRepository)
        {
            _masaRepository = masaRepository;
        }

        public void MasaEkle(Masa masa)
        {
            if (masa == null)
                throw new ArgumentNullException("Masa bilgisi boş olamaz.");

            if (string.IsNullOrWhiteSpace(masa.MasaNo))
                throw new ArgumentException("Masa numarası boş olamaz.");

            if (masa.Kapasite <= 0)
                throw new ArgumentException("Kapasite sıfırdan büyük olmalıdır.");

            // Aynı masa numarası var mı kontrol et
            var mevcutMasa = _masaRepository.MasaNoIleGetir(masa.MasaNo);
            if (mevcutMasa != null)
                throw new Exception("Bu masa numarası zaten kullanılıyor.");

            _masaRepository.Ekle(masa);
        }

        public void MasaGuncelle(Masa masa)
        {
            if (masa == null)
                throw new ArgumentNullException("Masa bilgisi boş olamaz.");

            // Kontrol yaparken takip etmeyen (NoTracking) bir metod kullanmalısın
            var mevcutMasa = _masaRepository.IdyeGoreGetir(masa.MasaID);
            if (mevcutMasa == null)
                throw new Exception("Masa bulunamadı.");

            // Eğer hata devam ederse, JenerikRepo'daki Guncelle metodunu 
            // önceki mesajda verdiğim "Detach" yöntemiyle güncellemelisin.
            _masaRepository.Guncelle(masa);
        }

        public void MasaSil(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz masa ID.");

            var masa = _masaRepository.IdyeGoreGetir(id);
            if (masa == null)
                throw new Exception("Masa bulunamadı.");

            _masaRepository.Sil(id);
        }

        public Masa MasaGetir(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz masa ID.");

            return _masaRepository.IdyeGoreGetir(id);
        }

        public List<Masa> TumMasalar()
        {
            return _masaRepository.TumunuListele();
        }

        public List<Masa> BosMasalar()
        {
            return _masaRepository.BosMasalariGetir();
        }

        public Masa MasaNoIleGetir(string masaNo)
        {
            if (string.IsNullOrWhiteSpace(masaNo))
                throw new ArgumentException("Masa numarası boş olamaz.");

            return _masaRepository.MasaNoIleGetir(masaNo);
        }

        public List<Masa> KonumaGoreGetir(string konum)
        {
            if (string.IsNullOrWhiteSpace(konum))
                throw new ArgumentException("Konum bilgisi boş olamaz.");

            return _masaRepository.KonumaGoreGetir(konum);
        }
    }
}
