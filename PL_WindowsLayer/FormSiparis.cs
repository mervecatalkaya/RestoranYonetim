using BllLayer.Services.MasaServis;
using BllLayer.Services.SiparisServis;
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
    public partial class FormSiparis : Form
    {
        private readonly ISiparisServis _siparisServis;
        private readonly IMasaServis _masaServis;
        private readonly IUrunServis _urunServis;
        public FormSiparis()
        {
            InitializeComponent();
            // Senin katmanlı yapına uygun bağlantılar
            var context = new RestoranDbContext();
            var masaRepo = new MasaRepository(context);
            var urunRepo = new UrunRepository(context);
            var siparisRepo = new SiparisRepository(context);

            _masaServis = new MasaServis(masaRepo);
            _urunServis = new UrunServis(urunRepo);
            // SiparisServis, hem masa hem ürün hem sipariş reposuna ihtiyaç duyar
            _siparisServis = new SiparisServis(siparisRepo, masaRepo, urunRepo);
        }
       
        private void VerileriYukle()
        {
            try
            {
                // Masaları doldur (MasaNo göster, MasaID sakla)
                cmbMasalar.DataSource = _masaServis.TumMasalar();
                cmbMasalar.DisplayMember = "MasaNo";
                cmbMasalar.ValueMember = "MasaID";

                // Sadece mevcut ürünleri doldur
                cmbUrunler.DataSource = _urunServis.MevcutUrunler();
                cmbUrunler.DisplayMember = "UrunAdi";
                cmbUrunler.ValueMember = "UrunID";

                cmbMasalar.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yükleme hatası: " + ex.Message);
            }
        }
        private void HesaplaGenelToplam()
        {
            decimal toplam = 0;
            foreach (DataGridViewRow row in dgvSiparisler.Rows)
            {
                if (row.Cells["ToplamTutar"].Value != null)
                {
                    toplam += Convert.ToDecimal(row.Cells["ToplamTutar"].Value);
                }
            }
            // Label'da gösteriyoruz (Para formatında)
            lblGenelToplam.Text = toplam.ToString("C2");
        }
        private void Listele(int masaId)
        {
            dgvSiparisler.DataSource = null;

            // 1. Veritabanından masanın tüm siparişlerini al
            var tumListe = _siparisServis.MasayaGoreSiparisler(masaId);

            // 2. Sadece durumu "Ödendi" OLMAYANLARI filtrele
            // Bu sayede ödeme yapıldıktan sonra bu liste boş gelecektir.
            var aktifSiparisler = tumListe.Where(s => s.Durum != "Ödendi").ToList();

            dgvSiparisler.DataSource = aktifSiparisler;

            // Gereksiz kolonları gizle
            if (dgvSiparisler.Columns["Masa"] != null) dgvSiparisler.Columns["Masa"].Visible = false;
            if (dgvSiparisler.Columns["Urun"] != null) dgvSiparisler.Columns["Urun"].Visible = false;
            if (dgvSiparisler.Columns["MasaID"] != null) dgvSiparisler.Columns["MasaID"].Visible = false;
            if (dgvSiparisler.Columns["UrunID"] != null) dgvSiparisler.Columns["UrunID"].Visible = false;
            if (dgvSiparisler.Columns["SiparisID"] != null) dgvSiparisler.Columns["SiparisID"].Visible = false;

            // 3. Liste boş olduğunda bu metod otomatik olarak ₺0,00 hesaplayacaktır
            HesaplaGenelToplam();
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMasalar.SelectedValue == null || cmbUrunler.SelectedValue == null) return;

                var yeniSiparis = new Siparis
                {
                    MasaID = (int)cmbMasalar.SelectedValue,
                    UrunID = (int)cmbUrunler.SelectedValue,
                    Adet = (int)numericUpAdet.Value, // NumericUpDown kullandığını varsaydım
                    SiparisTarihi = DateTime.Now
                };

                // BLL katmanında tutar hesaplanır, stok düşülür ve masa dolu yapılır
                _siparisServis.SiparisEkle(yeniSiparis);

                MessageBox.Show("Sipariş başarıyla eklendi.");
                Listele(yeniSiparis.MasaID);
                numericUpAdet.Value = 1; // Adedi varsayılana çek
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void cmbMasalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMasalar.SelectedValue is int masaId)
            {
                Listele(masaId);
            }
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (cmbMasalar.SelectedValue is int masaId)
                {
                    var siparisler = _siparisServis.MasayaGoreSiparisler(masaId);
                    foreach (var item in siparisler)
                    {
                        _siparisServis.SiparisDurumGuncelle(item.SiparisID, "Ödendi");
                    }

                    MessageBox.Show("Ödeme alındı. Masa boşaltıldı.");

                    // KRİTİK DÜZELTME: 
                    // 1. Grid'i boşalt
                    dgvSiparisler.DataSource = null;

                    // 2. Toplam tutarı manuel olarak sıfırla
                    lblGenelToplam.Text = 0.ToString("C2");

                    // 3. Masaları tekrar yükle (Masa durumu "Boş" olduğu için listede güncellensin)
                    VerileriYukle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        

        private void btnIptal_Click(object sender, EventArgs e)
        {
            if (dgvSiparisler.CurrentRow != null)
            {
                // 2. Seçili satırdaki SiparisID'yi al
                int id = (int)dgvSiparisler.CurrentRow.Cells["SiparisID"].Value;

                // 3. Servis katmanından silme metodunu çağır
                // Bu metot arka planda stoğu iade eder
                _siparisServis.SiparisSil(id);

                MessageBox.Show("Sipariş silindi ve stok iade edildi.");

                // 4. Listeyi ve o meşhur "400 TL" yazan toplam tutarı tazele
                Listele((int)cmbMasalar.SelectedValue);
            }
        }

        private void dgvSiparisler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvSiparisler.Rows[e.RowIndex];
                // Seçilen satırdaki verileri kontrollere taşıyoruz
                cmbUrunler.SelectedValue = row.Cells["UrunID"].Value;
                numericUpAdet.Value = Convert.ToInt32(row.Cells["Adet"].Value);
                
            }
        }

        private void FormSiparis_Load_1(object sender, EventArgs e)
        {
            VerileriYukle();
        }
    }
}
