using BilgeKafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeKafe.UI
{
    public partial class GecmisSiparislerForm : Form
    {
        private readonly KafeVeri db;

        public GecmisSiparislerForm(KafeVeri db)
        {
            InitializeComponent();
            dgvSiparisler.AutoGenerateColumns = false;
            dgvSiparisDetaylari.AutoGenerateColumns = false;
            dgvSiparisler.DataSource = db.GecmisSiparisler;
        }

        private void dgvSiparisler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSiparisler.SelectedRows.Count == 0)
            {
                dgvSiparisDetaylari.DataSource = null;
            }
            else
            {
                DataGridViewRow satir = dgvSiparisler.SelectedRows[0];
                Siparis siparis = (Siparis)satir.DataBoundItem;  // DataBoundItem: herbir siparisin herbir satırını esitliyor. Satıra baglı veri oğesi
                dgvSiparisDetaylari.DataSource = siparis.SiparisDetaylar;
            }
        }
    }
}
