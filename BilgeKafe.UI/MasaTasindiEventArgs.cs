using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKafe.UI
{
    public class MasaTasindiEventArgs : EventArgs
    {
        public int EskiMasaNo { get; set; }
        public int YeniMasaNo { get; set; }
    }
}
