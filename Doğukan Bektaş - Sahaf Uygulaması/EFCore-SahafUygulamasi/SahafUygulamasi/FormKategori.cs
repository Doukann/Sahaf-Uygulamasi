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
using SahafUygulamasi.Models;
using SahafUygulamasi.Repositories;

namespace SahafUygulamasi
{
	public partial class FormKategori : Form
	{
		KategoriRepository kategoriRepository;
		public FormKategori()
		{
			InitializeComponent();
			kategoriRepository = new KategoriRepository();
		}

		/// <summary>
		/// Kategori ekleme butonuna tıklanıldığında, kategori eklemek için onay alır ve ekler.
		/// </summary>
		private void btnKategoriEkle_Click(object sender, EventArgs e)
		{
			var ekle = MessageBox.Show("Bu kategoriyi eklemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
			if (ekle == DialogResult.Yes)
			{
				Kategori kategori = new Kategori();
				kategori.KategoriAdi = txtKategoriAdi.Text;

				kategoriRepository.Ekle(kategori);
			}
			else
			{
				MessageBox.Show("Kategori Ekleme işlemi iptal edildi.", "Bildirim", MessageBoxButtons.OK);
			}
		}

		/// <summary>
		/// Kategori silme butonuna tıklanıldığında, kategoriyi silmek için onay alır ve siler.
		/// </summary>
		private void btnKategoriSil_Click(object sender, EventArgs e)
		{
			int silinecekKategori;
			if (int.TryParse(txtKategoriID.Text, out silinecekKategori))
			{
				Kategori kategori = kategoriRepository.Ara(silinecekKategori);
				if (kategori != null)
				{
					var sil = MessageBox.Show("Bu kategoriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
					if (sil == DialogResult.Yes)
					{
						kategori.KategoriID = Convert.ToInt32(txtKategoriID.Text);
						kategoriRepository.Sil(kategori.KategoriID);

						grdKategoriListe.DataSource = null;
						grdKategoriListe.DataSource = kategoriRepository.TumKategoriBilgileri();
					}
					else
					{
						MessageBox.Show("Kategori silme işlemi iptal edildi.", "Bildirim", MessageBoxButtons.OK);
						return;
					}
				}
				else
				{
					MessageBox.Show("Kategori ID bulunamadı.", "Bildirim", MessageBoxButtons.OK);
				}
			}
			else
			{
				MessageBox.Show("Lütfen ID numarası giriniz.", "Bildirim", MessageBoxButtons.OK);
			}
		}

		/// <summary>
		/// Kategori listeleme butonuna tıklanıldığında, tüm kategorileri listeleyen işlemi başlatır.
		/// </summary>
		private void btnKategoriListele_Click(object sender, EventArgs e)
		{
			grdKategoriListe.DataSource = null;
			grdKategoriListe.DataSource = kategoriRepository.TumKategoriBilgileri();
		}

		/// <summary>
		/// Kategori arama butonuna tıklanıldığında, verilen ID'ye göre kategoriyi arar.
		/// </summary>
		private void btnKategoriAra_Click(object sender, EventArgs e)
		{
			int aranacakKategori;
			if (int.TryParse(txtKategoriID.Text, out aranacakKategori))
			{
				Kategori kategori = kategoriRepository.Ara(aranacakKategori);
				if (kategori != null)
				{
					txtKategoriAdi.Text = kategori.KategoriAdi;
				}
				else
				{
					MessageBox.Show("Aranan kategori bulunamadı.", "Uyarı", MessageBoxButtons.OK);
				}
			}
			else
			{
				MessageBox.Show("Lütfen ID numarası giriniz!", "Uyarı", MessageBoxButtons.OK);
			}
		}

		/// <summary>
		/// Ana sayfaya dönüş butonuna tıklanıldığında, kullanıcıyı ana sayfaya yönlendirir.
		/// </summary>
		private void btnAnaSayfayaDon_Click(object sender, EventArgs e)
		{
			FormKullaniciEkrani formKullaniciEkrani = new FormKullaniciEkrani();
			//formKullaniciEkrani.Show();
			this.Close();
		}

		/// <summary>
		/// Form kapanırken uygulamanın sonlanmasını sağlar.
		/// </summary>
		private void FormKategori_FormClosing(object sender, FormClosingEventArgs e)
		{
			//Application.Exit();
		}
	}
}