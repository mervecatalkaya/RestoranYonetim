
using System;
using System.Collections.Generic;

namespace Models
{
    public class Masa
    {
        public int MasaID { get; set; }
        public string MasaNo { get; set; }
        public int Kapasite { get; set; }
        public string Konum { get; set; }      // "İçeride" veya "Dışarıda"
        public string Durum { get; set; }      // "Boş", "Dolu", "Rezerve"

        // Navigation Property
        public virtual ICollection<Siparis> Siparisler { get; set; }

        public Masa()
        {
            Durum = "Boş";
            Siparisler = new List<Siparis>();
        }
    }
}