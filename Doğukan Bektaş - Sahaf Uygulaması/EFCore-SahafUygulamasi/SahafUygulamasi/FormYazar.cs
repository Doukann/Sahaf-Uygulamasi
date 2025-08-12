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
	public partial class FormYazar : Form
	{
		YazarRepository yazarRepository;
		public FormYazar()
		{
			InitializeComponent();
			yazarRepository = new YazarRepository();
		}


		/// <summary>
		/// Form kapanırken uygulamanın sonlanmasını sağlar.
		/// </summary>
		private void FormYazar_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		/// <summary>
		/// Yazar ekleme butonuna tıklanıldığında, yazar eklemek için onay alır ve ekler.
		/// </summary>
		private void btnYazarEkle_Click(object sender, EventArgs e)
		{
			var ekle = MessageBox.Show("Yazar eklemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
			if (ekle == DialogResult.Yes)
			{
				Yazar yazar = new Yazar();
				yazar.YazarAdiSoyadi = txtYazarAdiSoyadi.Text;

				yazarRepository.Ekle(yazar);
			}
			else
			{
				MessageBox.Show("Yazar Ekleme işlemi iptal edildi.", "Bildirim", MessageBoxButtons.OK);
			}
		}

		/// <summary>
		/// Yazar silme butonuna tıklanıldığında, verilen ID'ye göre yazarı silmek için onay alır ve siler.
		/// </summary>
		private void btnYazarSil_Click(object sender, EventArgs e)
		{
			int silinecekYazar;
			if (int.TryParse(txtYazarID.Text, out silinecekYazar))
			{
				Yazar yazar = yazarRepository.Ara(silinecekYazar);
				if (yazar != null)
				{
					var sil = MessageBox.Show("Bu yazarı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
					if (sil == DialogResult.Yes)
					{
						yazar.YazarID = Convert.ToInt32(txtYazarID.Text);
						yazarRepository.Sil(yazar.YazarID);

						grdYazarListe.DataSource = null;
						grdYazarListe.DataSource = yazarRepository.TumYazarBilgileri();
					}
					else
					{
						MessageBox.Show("Yazar silme işlemi iptal edildi.", "Bildirim", MessageBoxButtons.OK);
						return;
					}
				}
				else
				{
					MessageBox.Show("Yazar ID bulunamadı.", "Bildirim", MessageBoxButtons.OK);
				}
			}
			else
			{
				MessageBox.Show("Lütfen ID numarası giriniz.", "Bildirim", MessageBoxButtons.OK);
			}
		}

		/// <summary>
		/// Yazar arama butonuna tıklanıldığında, verilen ID'ye göre yazarı arar ve bilgilerini ekrana getirir.
		/// </summary>
		private void btnYazarAra_Click(object sender, EventArgs e)
		{
			int aranacakYazar;
			if (int.TryParse(txtYazarID.Text, out aranacakYazar))
			{
				Yazar yazar = yazarRepository.Ara(aranacakYazar);
				if (yazar != null)
				{
					txtYazarAdiSoyadi.Text = yazar.YazarAdiSoyadi;
				}
				else
				{
					MessageBox.Show("Aranan yazar bulunamadı.", "Uyarı", MessageBoxButtons.OK);
				}
			}
			else
			{
				MessageBox.Show("Lütfen ID numarası giriniz!", "Uyarı", MessageBoxButtons.OK);
			}
		}

		/// <summary>
		/// Yazar listeleme butonuna tıklanıldığında, tüm yazarları listeleyen işlemi başlatır.
		/// </summary>
		private void btnYazarListele_Click(object sender, EventArgs e)
		{
			grdYazarListe.DataSource = null;
			grdYazarListe.DataSource = yazarRepository.TumYazarBilgileri();
		}

		/// <summary>
		/// Ana sayfaya dönüş butonuna tıklanıldığında, kullanıcıyı ana sayfaya yönlendirir.
		/// </summary>
		private void btnAnaEkranaDon_Click(object sender, EventArgs e)
		{
			FormKullaniciEkrani formKullaniciEkrani = new FormKullaniciEkrani();
			formKullaniciEkrani.Show();
			this.Hide();
		}
	}
}