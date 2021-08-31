using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKafe.Data
{
    public class KafeVeri
    {
        public int MasaAdet { get; set; } = 20;

        public List<Urun> Urunler { get; set; } = new List<Urun>();

        public List<Siparis> AktifSiparisler { get; set; } = new List<Siparis>();   //null baslamaması ıcın

        public List<Siparis> GecmisSiparisler { get; set; } = new List<Siparis>();
    }
}
