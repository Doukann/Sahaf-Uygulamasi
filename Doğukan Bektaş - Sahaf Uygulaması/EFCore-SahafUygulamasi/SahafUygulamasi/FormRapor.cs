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
	public partial class FormRapor : Form
	{
		KitapRepository kitapRepository;
		public FormRapor()
		{
			InitializeComponent();
			kitapRepository = new KitapRepository();
		}

		private void FormRapor_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void FormRapor_Load(object sender, EventArgs e)
		{

		}

		private void btnTumKitaplarinListesi_Click(object sender, EventArgs e)
		{
			
		}

		private void grdRaporListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			grdRaporListe.DataSource = null;
			grdRaporListe.DataSource = kitapRepository.TumKitapBilgileri();
		}

		private void btnAnaEkranaDon_Click(object sender, EventArgs e)
		{
			FormKullaniciEkrani formKullaniciEkrani = new FormKullaniciEkrani();
			formKullaniciEkrani.Show();
			this.Hide();
		}
	}
}

