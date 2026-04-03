using DalLayer.Repositories.Abstract;
using Models;
using System;
using System.Collections.Generic;

namespace BllLayer.Services.SiparisServis
{
    public class SiparisServis : ISiparisServis
    {
        private readonly ISiparisRepository _siparisRepository;
        private readonly IMasaRepository _masaRepository;
        private readonly IUrunRepository _urunRepository;

        public SiparisServis(ISiparisRepository siparisRepository,
                            IMasaRepository masaRepository,
                            IUrunRepository urunRepository)
        {
            _siparisRepository = siparisRepository;
            _masaRepository = masaRepository;
            _urunRepository = urunRepository;
        }

        public void SiparisEkle(Siparis siparis)
        {
            if (siparis == null)
                throw new ArgumentNullException("Sipariş bilgisi boş olamaz.");

            if (siparis.Adet <= 0)
                throw new ArgumentException("Sipariş adedi sıfırdan büyük olmalıdır.");

            // Masa kontrolü
            var masa = _masaRepository.IdyeGoreGetir(siparis.MasaID);
            if (masa == null)
                throw new Exception("Masa bulunamadı.");

            // Ürün kontrolü
            var urun = _urunRepository.IdyeGoreGetir(siparis.UrunID);
            if (urun == null)
                throw new Exception("Ürün bulunamadı.");

            if (!urun.Durum)
                throw new Exception("Bu ürün şu anda satışta değil.");

            if (urun.Stok < siparis.Adet)
                throw new Exception("Yetersiz stok.");

            // Toplam tutar hesaplama
            siparis.ToplamTutar = urun.Fiyat * siparis.Adet;
            siparis.SiparisTarihi = DateTime.Now;
            siparis.Durum = "Hazırlanıyor";

            // Masayı dolu yap
            if (masa.Durum == "Boş")
            {
                masa.Durum = "Dolu";
                _masaRepository.Guncelle(masa);
            }

            // Stok düş
            urun.Stok -= siparis.Adet;
            _urunRepository.Guncelle(urun);

            _siparisRepository.Ekle(siparis);
        }

        public void SiparisGuncelle(Siparis siparis)
        {
            if (siparis == null)
                throw new ArgumentNullException("Sipariş bilgisi boş olamaz.");

            var mevcutSiparis = _siparisRepository.IdyeGoreGetir(siparis.SiparisID);
            if (mevcutSiparis == null)
                throw new Exception("Sipariş bulunamadı.");

            // Ürün fiyatını yeniden hesapla
            var urun = _urunRepository.IdyeGoreGetir(siparis.UrunID);
            if (urun != null)
            {
                siparis.ToplamTutar = urun.Fiyat * siparis.Adet;
            }

            _siparisRepository.Guncelle(siparis);
        }

        public void SiparisSil(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz sipariş ID.");

            var siparis = _siparisRepository.IdyeGoreGetir(id);
            if (siparis == null)
                throw new Exception("Sipariş bulunamadı.");

            // Stok iade et
            var urun = _urunRepository.IdyeGoreGetir(siparis.UrunID);
            if (urun != null)
            {
                urun.Stok += siparis.Adet;
                _urunRepository.Guncelle(urun);
            }

            _siparisRepository.Sil(id);
        }

        public Siparis SiparisGetir(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz sipariş ID.");

            return _siparisRepository.IdyeGoreGetir(id);
        }

        public List<Siparis> TumSiparisler()
        {
            return _siparisRepository.TumunuListele();
        }

        public List<Siparis> MasayaGoreSiparisler(int masaId)
        {
            if (masaId <= 0)
                throw new ArgumentException("Geçersiz masa ID.");

            return _siparisRepository.MasayaGoreSiparisler(masaId);
        }

        public List<Siparis> AktifSiparisler()
        {
            return _siparisRepository.AktifSiparisler();
        }

        public List<Siparis> TariheGoreSiparisler(DateTime tarih)
        {
            return _siparisRepository.TariheGoreSiparisler(tarih);
        }

        public decimal GunlukCiro(DateTime tarih)
        {
            return _siparisRepository.GunlukCiro(tarih);
        }

        public void SiparisDurumGuncelle(int siparisId, string durum)
        {
            if (siparisId <= 0)
                throw new ArgumentException("Geçersiz sipariş ID.");

            if (string.IsNullOrWhiteSpace(durum))
                throw new ArgumentException("Durum bilgisi boş olamaz.");

            var siparis = _siparisRepository.IdyeGoreGetir(siparisId);
            if (siparis == null)
                throw new Exception("Sipariş bulunamadı.");

            siparis.Durum = durum;
            _siparisRepository.Guncelle(siparis);

            // Eğer sipariş tamamlandı ise masa durumunu kontrol et
            if (durum == "Tamamlandı" || durum == "Ödendi")
            {
                var masadakiAktifSiparisler = _siparisRepository.MasayaGoreSiparisler(siparis.MasaID)
                    .FindAll(s => s.Durum == "Hazırlanıyor");

                if (masadakiAktifSiparisler.Count == 0)
                {
                    var masa = _masaRepository.IdyeGoreGetir(siparis.MasaID);
                    if (masa != null)
                    {
                        masa.Durum = "Boş";
                        _masaRepository.Guncelle(masa);
                    }
                }
            }
        }
    }
}