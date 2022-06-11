using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PazzoCafe
{
    public class musteri
    {
        public Guid ID { get; set; }
        public string AdSoy { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string Tel { get; set; }

        public override string ToString()
        {
            return "{AdSoy}";
        }
    }
    public class urun
    {
        public Guid ID { get; set; }
        public string UrunAd { get; set; }
        public int Maas { get; set; }

        public override string ToString()
        {
            return "{UrunAd}";
        }
    }
    public class calisanlar
    {
        public Guid ID { get; set; }
        public string AdSoy { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }

        public override string ToString()
        {
            return "{AdSoy}";
        }

        
    }
    public class siparis
    {
        public Guid ID { get; set; }
        public Guid musteriID { get; set; }
        public Guid urunID { get; set; }
        public Guid calisanlarID { get; set; }
        public int adet { get; set; }
        public int tutar { get; set; }
    }
}
