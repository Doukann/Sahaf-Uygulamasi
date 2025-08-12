using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SahafUygulamasi;
using SahafUygulamasi.Data;
using SahafUygulamasi.Models;
using SahafUygulamasi.Repositories;
using SahafUygulamasi.Utilities;

namespace SahafUygulamasi
{
	public partial class FormKullaniciEkrani : Form
	{
		public FormKullaniciEkrani()
		{
			InitializeComponent();
		}

		Kullanici girisYapanKullanici;
		public FormKullaniciEkrani(Kullanici kullanici)
		{
			InitializeComponent();
			girisYapanKullanici = kullanici;

		}
		SahafDBContext sahafDBContext = new SahafDBContext();
		KitapRepository kitapRepository = new KitapRepository();
		KategoriRepository kategoriRepository = new KategoriRepository();
		YazarRepository yazarRepository = new YazarRepository();

		/// <summary>
		/// Form yüklendiğinde çalıştırılır. Kullanıcı adı ve kitap listelerini yükler.
		/// </summary>
		private void FormKullaniciEkrani_Load(object sender, EventArgs e)
		{
			//MessageBox.Show("Hoşgeldiniz!" + girisYapanKullanici.KullaniciAdi);
			txtKullaniciIsmi.Text = girisYapanKullanici.KullaniciAdi;

			KategoriListele();
			YazarListele();
			grdListe.DataSource = kitapRepository.TumKitapBilgileri();

		}

		/// <summary>
		/// Kullanıcı kitap eklemek istediğinde çağrılır. Kitap verilerini alır ve veritabanına ekler.
		/// </summary>
		private void btnEkle_Click(object sender, EventArgs e)
		{
			var ekle = MessageBox.Show("Bu kitabı eklemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
			if (ekle == DialogResult.Yes)
			{
				Kitap kitap = new Kitap();
				kitap.KitapAdi = txtKitapAdi.Text;
				kitap.KitapAciklamasi = txtAciklama.Text;
				kitap.Fiyat = decimal.Parse(txtFiyat.Text);
				kitap.KapakResmi = pbxKapakResmi.ImageLocation;
				kitap.KategoriID = (int)cmbKategori.SelectedValue;
				kitap.YazarID = (int)cmbYazarAdiSoyadi.SelectedValue;

				int kullaniciID = girisYapanKullanici.KullaniciID;
				kitap.KullaniciID = kullaniciID;

				kitapRepository.Ekle(kitap);

			}
			else
			{
				MessageBox.Show("Kitap ekleme başarısız!", "Bildirim", MessageBoxButtons.OK);
			}
		}

		/// <summary>
		/// Kategorileri combobox'ta listeleyen metot.
		/// </summary>
		private void KategoriListele()
		{
			cmbKategori.DataSource = kategoriRepository.TumKategoriBilgileri();
			cmbKategori.DisplayMember = "KategoriAdi";
			cmbKategori.ValueMember = "KategoriID";
		}

		/// <summary>
		/// Yazarları combobox'ta listeleyen metot.
		/// </summary>
		private void YazarListele()
		{
			cmbYazarAdiSoyadi.DataSource = yazarRepository.TumYazarBilgileri();
			cmbYazarAdiSoyadi.DisplayMember = "YazarAdiSoyadi";
			cmbYazarAdiSoyadi.ValueMember = "YazarID";
		}

		/// <summary>
		/// Form kapandığında uygulamayı sonlandıran metot.
		/// </summary>
		private void FormKullaniciEkrani_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		/// <summary>
		/// Kapak resmi yükleme butonuna tıklandığında çağrılır ve kullanıcıdan resim seçmesini sağlar.
		/// </summary>
		private void btnResimYukle_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			pbxKapakResmi.ImageLocation = openFileDialog1.FileName;
		}

		/// <summary>
		/// Kitap listesine tıklandığında, veritabanından kitapları tekrar yükler.
		/// </summary>
		private void grdListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			grdListe.DataSource = kitapRepository.Listele();
		}


		/// <summary>
		/// Kitap silme butonuna tıklandığında çağrılır. Kullanıcıdan onay alır ve kitabı siler.
		/// </summary>
		private void btnSil_Click(object sender, EventArgs e)
		{
			var bilgi = MessageBox.Show("Bu kitabı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
			if (bilgi == DialogResult.Yes)
			{
				Kitap kitap = new Kitap();
				kitap.KitapID = Convert.ToInt32(txtKitapID.Text);

				kitapRepository.Sil(kitap.KitapID);
				grdListe.DataSource = kitapRepository.TumKitapBilgileri();
			}
			else
			{
				MessageBox.Show("Silme işlemi iptal edildi.", "Bildirim", MessageBoxButtons.OK);
				return;
			}
		}

		/// <summary>
		/// Kitap güncelleme butonuna tıklandığında çağrılır. Kullanıcıdan onay alır ve kitabı günceller.
		/// </summary>
		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			int guncelleKitap;
			if (int.TryParse(txtKitapID.Text, out guncelleKitap))
			{
				Kitap kitap = kitapRepository.Ara(guncelleKitap);
				if (kitap != null)
				{
					var mesaj = MessageBox.Show("Bu kitabı güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
					if (mesaj == DialogResult.Yes)
					{
						kitap.KitapAdi = txtKitapAdi.Text;
						kitap.KitapAciklamasi = txtAciklama.Text;
						kitap.Fiyat = decimal.Parse(txtFiyat.Text);
						kitap.KapakResmi = pbxKapakResmi.ImageLocation;
						kitap.KategoriID = (int)cmbKategori.SelectedValue;
						kitap.YazarID = (int)cmbYazarAdiSoyadi.SelectedValue;
						kitapRepository.Guncelle(kitap);

						grdListe.DataSource = kitapRepository.TumKitapBilgileri();
					}
					else
					{
						MessageBox.Show("Güncelleme işlemi iptal edildi.", "Bildirim", MessageBoxButtons.OK);
					}
				}
				else
				{
					MessageBox.Show("Kitap ID bulunamadı.", "Bildirim", MessageBoxButtons.OK)
;
				}
			}
			else
			{
				MessageBox.Show("Lütfen ID numarası giriniz.", "Bildirim", MessageBoxButtons.OK);
			}

		}

		/// <summary>
		/// Kitap arama butonuna tıklandığında çağrılır. Kullanıcıya aradıkları kitabı gösterir.
		/// </summary>
		private void btnAra_Click(object sender, EventArgs e)
		{
			int aranacakKitap;
			if (int.TryParse(txtKitapID.Text, out aranacakKitap))
			{
				Kitap kitap = kitapRepository.Ara(aranacakKitap);
				if (kitap != null)
				{
					txtKitapAdi.Text = kitap.KitapAdi;
					txtAciklama.Text = kitap.KitapAciklamasi;
					txtFiyat.Text = kitap.Fiyat.ToString();
					pbxKapakResmi.ImageLocation = kitap.KapakResmi;
					cmbKategori.SelectedValue = kitap.KategoriID;
					cmbYazarAdiSoyadi.SelectedValue = kitap.YazarID;
				}
				else
				{
					MessageBox.Show("Aranan kitap bulunamadı.", "Uyarı", MessageBoxButtons.OK);
				}
			}
			else
			{
				MessageBox.Show("Lütfen ID numarası giriniz!", "Uyarı", MessageBoxButtons.OK);
			}
		}


		/// <summary>
		/// Kitapları listeleyen buton metodu.
		/// </summary>
		private void btnListele_Click(object sender, EventArgs e)
		{
			grdListe.DataSource = null;
			grdListe.DataSource = kitapRepository.TumKitapBilgileri();
		}


		/// <summary>
		/// Kategoriler sayfasını açar.
		/// </summary>
		private void btnKategoriler_Click(object sender, EventArgs e)
		{
			FormKategori formKategori = new FormKategori();
			formKategori.ShowDialog();
			//this.Hide();
		}

		/// <summary>
		/// Kullanıcılar sayfasını açar.
		/// </summary>
		private void btnKullanicilar_Click(object sender, EventArgs e)
		{
			FormKullanici formKullanici = new FormKullanici();
			formKullanici.Show();
			this.Hide();
		}

		/// <summary>
		/// Yazarlar sayfasını açar ve yeni yazar ekler.
		/// </summary>
		private void btnYazarlar_Click(object sender, EventArgs e)
		{
			Yazar yazar = new Yazar { YazarAdiSoyadi = cmbYazarAdiSoyadi.Text };
			yazarRepository.Ekle(yazar);


			FormYazar formYazar = new FormYazar();
			formYazar.Show();
			this.Hide();

		}

		/// <summary>
		/// Raporlar sayfasını açar.
		/// </summary>
		private void btnRaporlar_Click(object sender, EventArgs e)
		{
			FormRapor formRapor = new FormRapor();
			formRapor.Show();
			this.Hide();
		}
	}
}