using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_WindowsLayer
{
    public partial class FormAnaSayfa : Form
    {
        public FormAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnMasalar_Click(object sender, EventArgs e)
        {
            // Masa yönetim formunu açar
            FormMasalar frm = new FormMasalar();
            frm.Show(); // .ShowDialog() dersen ana sayfa kilitlenir, .Show() dersen her iki form da açık kalabilir.
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            // Ürün yönetim formunu açar
            FormUrunler frm = new FormUrunler();
            frm.Show();
        }

        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            // Sipariş ekranını açar
            FormSiparis frm = new FormSiparis();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamayı tamamen kapatır
        }
    }
}
