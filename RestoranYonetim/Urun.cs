using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    public class Urun
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public string Kategori { get; set; }   // "Yemek", "İçecek", "Tatlı"
        public decimal Fiyat { get; set; }
        public int Stok { get; set; }
        public bool Durum { get; set; }        // true: Mevcut, false: Tükendi

        // Navigation Property
        public virtual ICollection<Siparis> Siparisler { get; set; }

        public Urun()
        {
            Durum = true;
            Siparisler = new List<Siparis>();
        }
    }
}