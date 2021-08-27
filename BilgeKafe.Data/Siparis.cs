using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKafe.Data
{
    public class Siparis
    {
        public int MasaNo { get; set; }

        public SiparisDurum Durum { get; set; }

        public decimal OdenenTutar { get; set; }

        public DateTime? AcilisZamani { get; set; } = DateTime.Now;
        //yukardaki eşit tanımının aynısı
        //public Siparis()
        //{
        //    AcilisZamani = DateTime.Now;
        //}

        public DateTime? KapanisZamani { get; set; }

        public List<SiparisDetay> SiparisDetaylar { get; set; }

        public string ToplamTutarTL { get; }

        public decimal ToplamTutar()
        {
            //decimal toplam = 0;
            //foreach (SiparisDetay detay in SiparisDetaylar)
            //{
            //    toplam += detay.Tutar();
            //}

            //return toplam;

            return SiparisDetaylar.Sum(x => x.Tutar());  //yukardakının aynısı
        }
    }
}
