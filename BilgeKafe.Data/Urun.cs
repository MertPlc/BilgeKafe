using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKafe.Data
{
    [Table("Urunler")]
    public class Urun
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string UrunAd { get; set; }

        public decimal BirimFiyat { get; set; }

        public override string ToString()
        {
            return $"{UrunAd} - {BirimFiyat:n2}₺";
        }

        public virtual ICollection<SiparisDetay> SiparisDetaylar { get; set; }
    }
}
