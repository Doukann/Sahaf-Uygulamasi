using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SahafUygulamasi.Models;
using SahafUygulamasi.Repositories;

namespace SahafUygulamasi
{
	public partial class FormKullanici : Form
	{
		KullaniciRepository kullaniciRepository;
		public FormKullanici()
		{
			InitializeComponent();
			kullaniciRepository = new KullaniciRepository();
		}

		/// <summary>
		/// Form kapanırken uygulamanın sonlanmasını sağlar.
		/// </summary>
		private void FormKullanici_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		/// <summary>
		/// Kullanıcı ekleme butonuna tıklanıldığında, kullanıcıyı eklemek için onay alır ve ekler.
		/// </summary>
		private void btnKullaniciEkle_Click(object sender, EventArgs e)
		{
			var ekle = MessageBox.Show("Kullanıcı eklemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
			if (ekle == DialogResult.Yes)
			{
				Kullanici kullanici = new Kullanici();
				kullanici.KullaniciAdi = txtKullaniciAdi.Text;

				kullaniciRepository.Ekle(kullanici);
			}
			else
			{
				MessageBox.Show("Kullanıcı Ekleme işlemi iptal edildi.", "Bildirim", MessageBoxButtons.OK);
			}
		}

		/// <summary>
		/// Kullanıcı silme butonuna tıklanıldığında, kullanıcıyı silmek için onay alır ve siler.
		/// </summary>
		private void btnKullaniciSil_Click(object sender, EventArgs e)
		{
			int silinecekKullanici;
			if (int.TryParse(txtKullaniciID.Text, out silinecekKullanici))
			{
				Kullanici kullanici = kullaniciRepository.Ara(silinecekKullanici);
				if (kullanici != null)
				{
					var sil = MessageBox.Show("Bu kullanıcıyı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
					if (sil == DialogResult.Yes)
					{
						kullanici.KullaniciID = Convert.ToInt32(txtKullaniciID.Text);
						kullaniciRepository.Sil(kullanici.KullaniciID);

						grdKullaniciListe.DataSource = null;
						grdKullaniciListe.DataSource = kullaniciRepository.TumKullaniciBilgileri();
					}
					else
					{
						MessageBox.Show("Kullanıcı silme işlemi iptal edildi.", "Bildirim", MessageBoxButtons.OK);
						return;
					}
				}
				else
				{
					MessageBox.Show("Kullanıcı ID bulunamadı.", "Bildirim", MessageBoxButtons.OK);
				}
			}
			else
			{
				MessageBox.Show("Lütfen ID numarası giriniz.", "Bildirim", MessageBoxButtons.OK);
			}
		}

		/// <summary>
		/// Kullanıcı listeleme butonuna tıklanıldığında, tüm kullanıcıları listeleyen işlemi başlatır.
		/// </summary>
		private void btnKullaniciListele_Click(object sender, EventArgs e)
		{
			grdKullaniciListe.DataSource = null;
			grdKullaniciListe.DataSource = kullaniciRepository.TumKullaniciBilgileri();
		}

		/// <summary>
		/// Kullanıcı arama butonuna tıklanıldığında, verilen ID'ye göre kullanıcıyı arar.
		/// </summary>
		private void btnKullaniciAra_Click(object sender, EventArgs e)
		{
			int aranacakKullanici;
			if (int.TryParse(txtKullaniciID.Text, out aranacakKullanici))
			{
				Kullanici kullanici = kullaniciRepository.Ara(aranacakKullanici);
				if (kullanici != null)
				{
					txtKullaniciAdi.Text = kullanici.KullaniciAdi;
				}
				else
				{
					MessageBox.Show("Aranan kullanıcı bulunamadı.", "Uyarı", MessageBoxButtons.OK);
				}
			}
			else
			{
				MessageBox.Show("Lütfen ID numarası giriniz!", "Uyarı", MessageBoxButtons.OK);
			}
		}

		/// <summary>
		/// Kullanıcı güncelleme butonuna tıklanıldığında, verilen ID'ye göre kullanıcıyı günceller.
		/// </summary>
		private void btnKullaniciGuncelle_Click(object sender, EventArgs e)
		{
			int guncelleKullanici;
			if (int.TryParse(txtKullaniciID.Text, out guncelleKullanici))
			{
				Kullanici kullanici = kullaniciRepository.Ara(guncelleKullanici);
				if (kullanici != null)
				{
					var mesaj = MessageBox.Show("Bu kullanıcıyı güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
					if (mesaj == DialogResult.Yes)
					{
						kullanici.KullaniciAdi = txtKullaniciAdi.Text;
						kullanici.Sifre = txtKullaniciSifre.Text;

						grdKullaniciListe.DataSource = kullaniciRepository.TumKullaniciBilgileri();
					}
					else
					{
						MessageBox.Show("Güncelleme işlemi iptal edildi.", "Bildirim", MessageBoxButtons.OK);
					}
				}
				else
				{
					MessageBox.Show("Kullanıcı ID bulunamadı.", "Bildirim", MessageBoxButtons.OK)
;
				}
			}
			else
			{
				MessageBox.Show("Lütfen ID numarası giriniz.", "Bildirim", MessageBoxButtons.OK);
			}

		}

		/// <summary>
		/// Ana ekran butonuna tıklanıldığında yapılacak işlemleri başlatır. 
		/// </summary>
		private void btnAnaEkranaDon_Click(object sender, EventArgs e)
		{
			FormKullaniciEkrani formKullaniciEkrani = new FormKullaniciEkrani();
			formKullaniciEkrani.Show();
			this.Hide();
		}
	}
}