namespace SahafUygulamasi
{
	partial class FormRapor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnTumKitaplarinListesi = new Button();
			grdRaporListe = new DataGridView();
			btnEnpahali10Kitap = new Button();
			label1 = new Label();
			txtKullaniciID = new TextBox();
			btnkullaniciIDyeGoreListele = new Button();
			label2 = new Label();
			txtKategoriAdi = new TextBox();
			btnKategoriKitaplari = new Button();
			label3 = new Label();
			btnYazarinKitaplari = new Button();
			txtYazarAdi = new TextBox();
			btnAnaEkranaDon = new Button();
			((System.ComponentModel.ISupportInitialize)grdRaporListe).BeginInit();
			SuspendLayout();
			// 
			// btnTumKitaplarinListesi
			// 
			btnTumKitaplarinListesi.Location = new Point(217, 310);
			btnTumKitaplarinListesi.Name = "btnTumKitaplarinListesi";
			btnTumKitaplarinListesi.Size = new Size(142, 52);
			btnTumKitaplarinListesi.TabIndex = 0;
			btnTumKitaplarinListesi.Text = "Tüm Kitapların Listesi";
			btnTumKitaplarinListesi.UseVisualStyleBackColor = true;
			btnTumKitaplarinListesi.Click += btnTumKitaplarinListesi_Click;
			// 
			// grdRaporListe
			// 
			grdRaporListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			grdRaporListe.Location = new Point(369, 12);
			grdRaporListe.Name = "grdRaporListe";
			grdRaporListe.RowHeadersWidth = 51;
			grdRaporListe.Size = new Size(444, 426);
			grdRaporListe.TabIndex = 1;
			grdRaporListe.CellContentClick += grdRaporListe_CellContentClick;
			// 
			// btnEnpahali10Kitap
			// 
			btnEnpahali10Kitap.Location = new Point(12, 310);
			btnEnpahali10Kitap.Name = "btnEnpahali10Kitap";
			btnEnpahali10Kitap.Size = new Size(142, 52);
			btnEnpahali10Kitap.TabIndex = 2;
			btnEnpahali10Kitap.Text = "En Pahalı 10 Kitabın Listesi";
			btnEnpahali10Kitap.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 12);
			label1.Name = "label1";
			label1.Size = new Size(347, 20);
			label1.TabIndex = 3;
			label1.Text = "Bir kullanıcı tarafından girilen tüm kitapların listesi :";
			// 
			// txtKullaniciID
			// 
			txtKullaniciID.Location = new Point(12, 44);
			txtKullaniciID.Name = "txtKullaniciID";
			txtKullaniciID.PlaceholderText = "Kullanıcı ID";
			txtKullaniciID.Size = new Size(142, 27);
			txtKullaniciID.TabIndex = 4;
			// 
			// btnkullaniciIDyeGoreListele
			// 
			btnkullaniciIDyeGoreListele.Location = new Point(217, 43);
			btnkullaniciIDyeGoreListele.Name = "btnkullaniciIDyeGoreListele";
			btnkullaniciIDyeGoreListele.Size = new Size(142, 29);
			btnkullaniciIDyeGoreListele.TabIndex = 5;
			btnkullaniciIDyeGoreListele.Text = "Kullanıcı Kitapları";
			btnkullaniciIDyeGoreListele.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 100);
			label2.Name = "label2";
			label2.Size = new Size(246, 20);
			label2.TabIndex = 6;
			label2.Text = "Bir kategoriye ait olan tüm kitaplar :";
			// 
			// txtKategoriAdi
			// 
			txtKategoriAdi.Location = new Point(12, 134);
			txtKategoriAdi.Name = "txtKategoriAdi";
			txtKategoriAdi.Size = new Size(142, 27);
			txtKategoriAdi.TabIndex = 7;
			// 
			// btnKategoriKitaplari
			// 
			btnKategoriKitaplari.Location = new Point(217, 134);
			btnKategoriKitaplari.Name = "btnKategoriKitaplari";
			btnKategoriKitaplari.Size = new Size(142, 29);
			btnKategoriKitaplari.TabIndex = 8;
			btnKategoriKitaplari.Text = "Kategori Kitapları";
			btnKategoriKitaplari.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(8, 198);
			label3.Name = "label3";
			label3.Size = new Size(193, 20);
			label3.TabIndex = 9;
			label3.Text = "Bir yazara ait olan kitaplar : ";
			// 
			// btnYazarinKitaplari
			// 
			btnYazarinKitaplari.Location = new Point(217, 237);
			btnYazarinKitaplari.Name = "btnYazarinKitaplari";
			btnYazarinKitaplari.Size = new Size(142, 29);
			btnYazarinKitaplari.TabIndex = 10;
			btnYazarinKitaplari.Text = "Yazarın Kitapları";
			btnYazarinKitaplari.UseVisualStyleBackColor = true;
			// 
			// txtYazarAdi
			// 
			txtYazarAdi.Location = new Point(8, 237);
			txtYazarAdi.Name = "txtYazarAdi";
			txtYazarAdi.PlaceholderText = "Yazar Adı";
			txtYazarAdi.Size = new Size(142, 27);
			txtYazarAdi.TabIndex = 11;
			// 
			// btnAnaEkranaDon
			// 
			btnAnaEkranaDon.Location = new Point(12, 388);
			btnAnaEkranaDon.Name = "btnAnaEkranaDon";
			btnAnaEkranaDon.Size = new Size(347, 50);
			btnAnaEkranaDon.TabIndex = 12;
			btnAnaEkranaDon.Text = "Ana Ekrana Dön";
			btnAnaEkranaDon.UseVisualStyleBackColor = true;
			btnAnaEkranaDon.Click += btnAnaEkranaDon_Click;
			// 
			// FormRapor
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(825, 450);
			Controls.Add(btnAnaEkranaDon);
			Controls.Add(txtYazarAdi);
			Controls.Add(btnYazarinKitaplari);
			Controls.Add(label3);
			Controls.Add(btnKategoriKitaplari);
			Controls.Add(txtKategoriAdi);
			Controls.Add(label2);
			Controls.Add(btnkullaniciIDyeGoreListele);
			Controls.Add(txtKullaniciID);
			Controls.Add(label1);
			Controls.Add(btnEnpahali10Kitap);
			Controls.Add(grdRaporListe);
			Controls.Add(btnTumKitaplarinListesi);
			Name = "FormRapor";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FormRapor";
			FormClosing += FormRapor_FormClosing;
			Load += FormRapor_Load;
			((System.ComponentModel.ISupportInitialize)grdRaporListe).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnTumKitaplarinListesi;
		private DataGridView grdRaporListe;
		private Button btnEnpahali10Kitap;
		private Label label1;
		private TextBox txtKullaniciID;
		private Button btnkullaniciIDyeGoreListele;
		private Label label2;
		private TextBox txtKategoriAdi;
		private Button btnKategoriKitaplari;
		private Label label3;
		private Button btnYazarinKitaplari;
		private TextBox txtYazarAdi;
		private Button btnAnaEkranaDon;
	}
}