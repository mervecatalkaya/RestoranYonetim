using BllLayer.Services.UrunServis;
using DalLayer.Context;
using DalLayer.Repositories.Concretes;
using Models;
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
    public partial class FormUrunler : Form
    {
        private readonly IUrunServis _urunServis;
        public FormUrunler()
        {
            InitializeComponent();
            // Senin mimarine uygun nesne oluşturma (Dependency Injection yoksa bu yöntem kullanılır)
            var context = new RestoranDbContext();
            var repository = new UrunRepository(context);
            _urunServis = new UrunServis(repository);
        }
        private void FormUrunler_Load(object sender, EventArgs e)
        {
            Listele();
            // Kategori ComboBox'ını varsayılan değerlerle doldur
            cmbKategori.Items.AddRange(new string[] { "Yemek", "İçecek", "Tatlı", "Ara Sıcak" });
        }
        private void Listele()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _urunServis.TumUrunler();

                // Siparişler listesinin gridde görünmesini engelle (Navigation Property)
                if (dataGridView1.Columns["Siparisler"] != null)
                    dataGridView1.Columns["Siparisler"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message);
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                txtUrunID.Text = row.Cells["UrunID"].Value.ToString();
                txtUrunAdi.Text = row.Cells["UrunAdi"].Value.ToString();
                txtFiyat.Text = row.Cells["Fiyat"].Value.ToString();
                txtStok.Text = row.Cells["Stok"].Value.ToString();
                cmbKategori.SelectedItem = row.Cells["Kategori"].Value.ToString();
                chkDurum.Checked = (bool)row.Cells["Durum"].Value;
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var yeniUrun = new Urun
                {
                    UrunAdi = txtUrunAdi.Text,
                    Kategori = cmbKategori.SelectedItem?.ToString(),
                    Fiyat = decimal.Parse(txtFiyat.Text),
                    Stok = int.Parse(txtStok.Text),
                    Durum = chkDurum.Checked // bool değer
                };

                _urunServis.UrunEkle(yeniUrun);
                MessageBox.Show("Ürün başarıyla eklendi.");
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUrunID.Text)) return;

                int id = int.Parse(txtUrunID.Text);
                var onay = MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);

                if (onay == DialogResult.Yes)
                {
                    _urunServis.UrunSil(id);
                    Listele();
                    Temizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message);
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUrunID.Text))
                {
                    MessageBox.Show("Lütfen listeden bir ürün seçin.");
                    return;
                }

                var guncelUrun = new Urun
                {
                    UrunID = int.Parse(txtUrunID.Text),
                    UrunAdi = txtUrunAdi.Text,
                    Kategori = cmbKategori.SelectedItem?.ToString(),
                    Fiyat = decimal.Parse(txtFiyat.Text),
                    Stok = int.Parse(txtStok.Text),
                    Durum = chkDurum.Checked
                };

                _urunServis.UrunGuncelle(guncelUrun);
                MessageBox.Show("Ürün bilgileri güncellendi.");
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
            }
        }
        private void Temizle()
        {
            txtUrunID.Clear();
            txtUrunAdi.Clear();
            txtFiyat.Clear();
            txtStok.Clear();
            cmbKategori.SelectedIndex = -1;
            chkDurum.Checked = true;
        }

        private void btnTumunuListele_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
