using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BllLayer.Services.MasaServis; // IMasaServis ve MasaServis için
using DalLayer.Context;            // RestoranDbContext için
using DalLayer.Repositories.Concretes; // MasaRepository için
using Models;                       // Masa sınıfı için
namespace PL_WindowsLayer
{
    public partial class FormMasalar : Form
    {
        private readonly IMasaServis _masaServis;
        public FormMasalar()
        {
            InitializeComponent();
            var context = new RestoranDbContext();
            var repository = new MasaRepository(context);
            _masaServis = new MasaServis(repository);
        }

        private void FormMasalar_Load(object sender, EventArgs e)
        {
            ComboIcerikleriniDoldur();
            Listele();
        }
        private void Listele()
        {
            try
            {
                dataGridView1.DataSource = null; // Grid'i temizle
                dataGridView1.DataSource = _masaServis.TumMasalar();

                // Opsiyonel: ID kolonunu gizlebilirsin
                if (dataGridView1.Columns["Siparisler"] != null)
                    dataGridView1.Columns["Siparisler"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message);
            }
        }
        private void Temizle()
        {
            txtMasaID.Clear();
            txtMasaNo.Clear();
            txtKapasıte.Clear();
            cmbKonum.SelectedIndex = -1;
            cmbDurum.SelectedIndex = -1;
        }
        private void ComboIcerikleriniDoldur()
        {
            // Konum ComboBox
            cmbKonum.Items.Clear();
            cmbKonum.Items.Add("İçeride");
            cmbKonum.Items.Add("Dışarıda");
            cmbKonum.Items.Add("Teras");

            // Durum ComboBox
            cmbDurum.Items.Clear();
            cmbDurum.Items.Add("Boş");
            cmbDurum.Items.Add("Dolu");
            cmbDurum.Items.Add("Rezerve");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMasaID.Text = row.Cells["MasaID"].Value.ToString();
                txtMasaNo.Text = row.Cells["MasaNo"].Value.ToString();
                txtKapasıte.Text = row.Cells["Kapasite"].Value.ToString();
                cmbKonum.SelectedItem = row.Cells["Konum"].Value.ToString();
                cmbDurum.SelectedItem = row.Cells["Durum"].Value.ToString();
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var yeniMasa = new Masa
                {
                    MasaNo = txtMasaNo.Text,
                    Kapasite = int.Parse(txtKapasıte.Text),
                    Konum = cmbKonum.SelectedItem?.ToString(),
                    Durum = cmbDurum.SelectedItem?.ToString() ?? "Boş"
                };

                _masaServis.MasaEkle(yeniMasa);
                MessageBox.Show("Masa başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMasaID.Text))
                {
                    MessageBox.Show("Lütfen güncellenecek masayı listeden seçin.");
                    return;
                }

                var guncellenecekMasa = new Masa
                {
                    MasaID = int.Parse(txtMasaID.Text),
                    MasaNo = txtMasaNo.Text,
                    Kapasite = int.Parse(txtKapasıte.Text),
                    Konum = cmbKonum.SelectedItem.ToString(),
                    Durum = cmbDurum.SelectedItem.ToString()
                };

                _masaServis.MasaGuncelle(guncellenecekMasa);
                MessageBox.Show("Masa güncellendi.");
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMasaID.Text)) return;

                int id = int.Parse(txtMasaID.Text);
                var sonuc = MessageBox.Show("Bu masayı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);

                if (sonuc == DialogResult.Yes)
                {
                    _masaServis.MasaSil(id);
                    Listele();
                    Temizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message);
            }
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }
        private void btnBosMasa_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _masaServis.BosMasalar();
        }

        private void btnDoluMasalar_Click(object sender, EventArgs e)
        {
            // BLL'de DoluMasalar yoksa TumMasalar üzerinden filtreleyip gösterebiliriz
            var tumu = _masaServis.TumMasalar();
            var dolular = tumu.FindAll(x => x.Durum == "Dolu");
            dataGridView1.DataSource = dolular;
        }
    }
}
