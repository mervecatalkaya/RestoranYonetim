using DalLayer.Repositories.Abstract;
using Models;
using System;
using System.Collections.Generic;

namespace BllLayer.Services.UrunServis
{
    public class UrunServis : IUrunServis
    {
        private readonly IUrunRepository _urunRepository;

        public UrunServis(IUrunRepository urunRepository)
        {
            _urunRepository = urunRepository;
        }

        public void UrunEkle(Urun urun)
        {
            if (urun == null)
                throw new ArgumentNullException("Ürün bilgisi boş olamaz.");

            if (string.IsNullOrWhiteSpace(urun.UrunAdi))
                throw new ArgumentException("Ürün adı boş olamaz.");

            if (urun.Fiyat <= 0)
                throw new ArgumentException("Ürün fiyatı sıfırdan büyük olmalıdır.");

            if (string.IsNullOrWhiteSpace(urun.Kategori))
                throw new ArgumentException("Kategori bilgisi boş olamaz.");

            _urunRepository.Ekle(urun);
        }

        public void UrunGuncelle(Urun urun)
        {
            if (urun == null)
                throw new ArgumentNullException("Ürün bilgisi boş olamaz.");

            if (string.IsNullOrWhiteSpace(urun.UrunAdi))
                throw new ArgumentException("Ürün adı boş olamaz.");

            if (urun.Fiyat <= 0)
                throw new ArgumentException("Ürün fiyatı sıfırdan büyük olmalıdır.");

            var mevcutUrun = _urunRepository.IdyeGoreGetir(urun.UrunID);
            if (mevcutUrun == null)
                throw new Exception("Ürün bulunamadı.");

            _urunRepository.Guncelle(urun);
        }

        public void UrunSil(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz ürün ID.");

            var urun = _urunRepository.IdyeGoreGetir(id);
            if (urun == null)
                throw new Exception("Ürün bulunamadı.");

            _urunRepository.Sil(id);
        }

        public Urun UrunGetir(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz ürün ID.");

            return _urunRepository.IdyeGoreGetir(id);
        }

        public List<Urun> TumUrunler()
        {
            return _urunRepository.TumunuListele();
        }

        public List<Urun> KategoriyeGoreGetir(string kategori)
        {
            if (string.IsNullOrWhiteSpace(kategori))
                throw new ArgumentException("Kategori bilgisi boş olamaz.");

            return _urunRepository.KategoriyeGoreGetir(kategori);
        }

        public List<Urun> MevcutUrunler()
        {
            return _urunRepository.MevcutUrunler();
        }

        public List<Urun> FiyataGoreSirala()
        {
            return _urunRepository.FiyataGoreSirala();
        }
    }
}