using System;

namespace Models
{
    public class Siparis
    {
        public int SiparisID { get; set; }
        public int MasaID { get; set; }
        public int UrunID { get; set; }
        public int Adet { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public decimal ToplamTutar { get; set; }
        public string Durum { get; set; }      // "Hazırlanıyor", "Teslim Edildi"

        // Navigation Properties
        public virtual Masa Masa { get; set; }
        public virtual Urun Urun { get; set; }

        public Siparis()
        {
            SiparisTarihi = DateTime.Now;
            Durum = "Hazırlanıyor";
        }
    }
}