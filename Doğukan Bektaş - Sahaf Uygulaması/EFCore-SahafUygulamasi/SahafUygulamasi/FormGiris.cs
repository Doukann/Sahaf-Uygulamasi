using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SahafUygulamasi.Data;
using SahafUygulamasi.Models;
using SahafUygulamasi.Utilities;

namespace SahafUygulamasi
{
	public partial class FormGiris : Form
	{
		public FormGiris()
		{
			InitializeComponent();
		}
		SahafDBContext sahafDBContext = new SahafDBContext();

		/// <summary>
		/// Giriş butonuna tıklanıldığında, kullanıcı adı ve şifre kontrolü yapılır.
		/// </summary>
		private void btnGirisYap_Click(object sender, EventArgs e)
		{
			string kullaniciAdi = txtKullaniciAdi.Text;
			string sifre = Hasher.Md5Hash(txtSifre.Text);

			Kullanici kullanici = sahafDBContext.Kullanicilar.Where(x => x.KullaniciAdi == kullaniciAdi && x.Sifre == sifre).SingleOrDefault();

			if (kullanici != null)
			{
				MessageBox.Show("Kayıtlı Kullanıcı :" + kullanici.KullaniciAdi + "\nGiriş yapılıyor...");
				FormKullaniciEkrani formKullaniciEkrani = new FormKullaniciEkrani(kullanici);
				formKullaniciEkrani.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!!!");
			}
		}

		/// <summary>
		/// Form kapanırken uygulamanın sonlanmasını sağlar.
		/// </summary>
		private void FormGiris_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
