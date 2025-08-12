namespace SahafUygulamasi
{
	partial class FormKullaniciEkrani
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
			lblKullaniciAdi = new Label();
			label3 = new Label();
			lblKitapAdi = new Label();
			lblKitapAciklamasi = new Label();
			lblFiyat = new Label();
			lblkategoriAdi = new Label();
			lblYazarAdiSoyadi = new Label();
			pbxKapakResmi = new PictureBox();
			openFileDialog1 = new OpenFileDialog();
			txtKitapID = new TextBox();
			txtKitapAdi = new TextBox();
			txtFiyat = new TextBox();
			txtAciklama = new TextBox();
			txtKullaniciIsmi = new TextBox();
			grdListe = new DataGridView();
			btnResimYukle = new Button();
			btnEkle = new Button();
			btnSil = new Button();
			btnGuncelle = new Button();
			btnAra = new Button();
			btnListele = new Button();
			lblKitapKapakResmi = new Label();
			cmbKategori = new ComboBox();
			cmbYazarAdiSoyadi = new ComboBox();
			btnKategoriler = new Button();
			btnYazarlar = new Button();
			btnKullanicilar = new Button();
			btnRaporlar = new Button();
			((System.ComponentModel.ISupportInitialize)pbxKapakResmi).BeginInit();
			((System.ComponentModel.ISupportInitialize)grdListe).BeginInit();
			SuspendLayout();
			// 
			// lblKullaniciAdi
			// 
			lblKullaniciAdi.AutoSize = true;
			lblKullaniciAdi.Location = new Point(406, 15);
			lblKullaniciAdi.Name = "lblKullaniciAdi";
			lblKullaniciAdi.Size = new Size(153, 20);
			lblKullaniciAdi.TabIndex = 0;
			lblKullaniciAdi.Text = "Ekleyen Kullanıcı Adı :";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(145, 15);
			label3.Name = "label3";
			label3.Size = new Size(70, 20);
			label3.TabIndex = 0;
			label3.Text = "Kitap ID :";
			// 
			// lblKitapAdi
			// 
			lblKitapAdi.AutoSize = true;
			lblKitapAdi.Location = new Point(145, 48);
			lblKitapAdi.Name = "lblKitapAdi";
			lblKitapAdi.Size = new Size(78, 20);
			lblKitapAdi.TabIndex = 0;
			lblKitapAdi.Text = "Kitap Adı :";
			// 
			// lblKitapAciklamasi
			// 
			lblKitapAciklamasi.AutoSize = true;
			lblKitapAciklamasi.Location = new Point(145, 115);
			lblKitapAciklamasi.Name = "lblKitapAciklamasi";
			lblKitapAciklamasi.Size = new Size(77, 20);
			lblKitapAciklamasi.TabIndex = 0;
			lblKitapAciklamasi.Text = "Açıklama :";
			// 
			// lblFiyat
			// 
			lblFiyat.AutoSize = true;
			lblFiyat.Location = new Point(145, 81);
			lblFiyat.Name = "lblFiyat";
			lblFiyat.Size = new Size(47, 20);
			lblFiyat.TabIndex = 0;
			lblFiyat.Text = "Fiyat :";
			// 
			// lblkategoriAdi
			// 
			lblkategoriAdi.AutoSize = true;
			lblkategoriAdi.Location = new Point(405, 48);
			lblkategoriAdi.Name = "lblkategoriAdi";
			lblkategoriAdi.Size = new Size(100, 20);
			lblkategoriAdi.TabIndex = 0;
			lblkategoriAdi.Text = "Kategori Adı :";
			// 
			// lblYazarAdiSoyadi
			// 
			lblYazarAdiSoyadi.AutoSize = true;
			lblYazarAdiSoyadi.Location = new Point(405, 81);
			lblYazarAdiSoyadi.Name = "lblYazarAdiSoyadi";
			lblYazarAdiSoyadi.Size = new Size(127, 20);
			lblYazarAdiSoyadi.TabIndex = 0;
			lblYazarAdiSoyadi.Text = "Yazar Adı Soyadı :";
			// 
			// pbxKapakResmi
			// 
			pbxKapakResmi.Location = new Point(12, 38);
			pbxKapakResmi.Name = "pbxKapakResmi";
			pbxKapakResmi.Size = new Size(125, 125);
			pbxKapakResmi.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxKapakResmi.TabIndex = 1;
			pbxKapakResmi.TabStop = false;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// txtKitapID
			// 
			txtKitapID.Location = new Point(244, 12);
			txtKitapID.Name = "txtKitapID";
			txtKitapID.Size = new Size(155, 27);
			txtKitapID.TabIndex = 2;
			// 
			// txtKitapAdi
			// 
			txtKitapAdi.Location = new Point(244, 45);
			txtKitapAdi.Name = "txtKitapAdi";
			txtKitapAdi.Size = new Size(155, 27);
			txtKitapAdi.TabIndex = 2;
			// 
			// txtFiyat
			// 
			txtFiyat.Location = new Point(244, 78);
			txtFiyat.Name = "txtFiyat";
			txtFiyat.Size = new Size(155, 27);
			txtFiyat.TabIndex = 2;
			// 
			// txtAciklama
			// 
			txtAciklama.Location = new Point(244, 112);
			txtAciklama.Multiline = true;
			txtAciklama.Name = "txtAciklama";
			txtAciklama.Size = new Size(155, 89);
			txtAciklama.TabIndex = 2;
			// 
			// txtKullaniciIsmi
			// 
			txtKullaniciIsmi.Location = new Point(565, 12);
			txtKullaniciIsmi.Name = "txtKullaniciIsmi";
			txtKullaniciIsmi.ReadOnly = true;
			txtKullaniciIsmi.Size = new Size(137, 27);
			txtKullaniciIsmi.TabIndex = 2;
			// 
			// grdListe
			// 
			grdListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			grdListe.Location = new Point(12, 207);
			grdListe.Name = "grdListe";
			grdListe.RowHeadersWidth = 51;
			grdListe.Size = new Size(821, 287);
			grdListe.TabIndex = 3;
			grdListe.CellContentClick += grdListe_CellContentClick;
			// 
			// btnResimYukle
			// 
			btnResimYukle.Location = new Point(12, 169);
			btnResimYukle.Name = "btnResimYukle";
			btnResimYukle.Size = new Size(125, 32);
			btnResimYukle.TabIndex = 4;
			btnResimYukle.Text = "Resim Yükle";
			btnResimYukle.UseVisualStyleBackColor = true;
			btnResimYukle.Click += btnResimYukle_Click;
			// 
			// btnEkle
			// 
			btnEkle.Location = new Point(708, 21);
			btnEkle.Name = "btnEkle";
			btnEkle.Size = new Size(125, 31);
			btnEkle.TabIndex = 5;
			btnEkle.Text = "Ekle";
			btnEkle.UseVisualStyleBackColor = true;
			btnEkle.Click += btnEkle_Click;
			// 
			// btnSil
			// 
			btnSil.Location = new Point(708, 58);
			btnSil.Name = "btnSil";
			btnSil.Size = new Size(125, 31);
			btnSil.TabIndex = 5;
			btnSil.Text = "Sil";
			btnSil.UseVisualStyleBackColor = true;
			btnSil.Click += btnSil_Click;
			// 
			// btnGuncelle
			// 
			btnGuncelle.Location = new Point(708, 95);
			btnGuncelle.Name = "btnGuncelle";
			btnGuncelle.Size = new Size(125, 31);
			btnGuncelle.TabIndex = 5;
			btnGuncelle.Text = "Güncelle";
			btnGuncelle.UseVisualStyleBackColor = true;
			btnGuncelle.Click += btnGuncelle_Click;
			// 
			// btnAra
			// 
			btnAra.Location = new Point(708, 132);
			btnAra.Name = "btnAra";
			btnAra.Size = new Size(125, 31);
			btnAra.TabIndex = 5;
			btnAra.Text = "ID Ara";
			btnAra.UseVisualStyleBackColor = true;
			btnAra.Click += btnAra_Click;
			// 
			// btnListele
			// 
			btnListele.Location = new Point(708, 170);
			btnListele.Name = "btnListele";
			btnListele.Size = new Size(125, 31);
			btnListele.TabIndex = 5;
			btnListele.Text = "Listele";
			btnListele.UseVisualStyleBackColor = true;
			btnListele.Click += btnListele_Click;
			// 
			// lblKitapKapakResmi
			// 
			lblKitapKapakResmi.AutoSize = true;
			lblKitapKapakResmi.Location = new Point(12, 11);
			lblKitapKapakResmi.Name = "lblKitapKapakResmi";
			lblKitapKapakResmi.Size = new Size(101, 20);
			lblKitapKapakResmi.TabIndex = 6;
			lblKitapKapakResmi.Text = "Kapak Resmi :";
			// 
			// cmbKategori
			// 
			cmbKategori.FormattingEnabled = true;
			cmbKategori.Location = new Point(565, 45);
			cmbKategori.Name = "cmbKategori";
			cmbKategori.Size = new Size(137, 28);
			cmbKategori.TabIndex = 7;
			// 
			// cmbYazarAdiSoyadi
			// 
			cmbYazarAdiSoyadi.FormattingEnabled = true;
			cmbYazarAdiSoyadi.Location = new Point(565, 78);
			cmbYazarAdiSoyadi.Name = "cmbYazarAdiSoyadi";
			cmbYazarAdiSoyadi.Size = new Size(137, 28);
			cmbYazarAdiSoyadi.TabIndex = 7;
			// 
			// btnKategoriler
			// 
			btnKategoriler.Location = new Point(405, 117);
			btnKategoriler.Name = "btnKategoriler";
			btnKategoriler.Size = new Size(137, 39);
			btnKategoriler.TabIndex = 8;
			btnKategoriler.Text = "Kategoriler";
			btnKategoriler.UseVisualStyleBackColor = true;
			btnKategoriler.Click += btnKategoriler_Click;
			// 
			// btnYazarlar
			// 
			btnYazarlar.Location = new Point(565, 160);
			btnYazarlar.Name = "btnYazarlar";
			btnYazarlar.Size = new Size(137, 41);
			btnYazarlar.TabIndex = 8;
			btnYazarlar.Text = "Yazarlar";
			btnYazarlar.UseVisualStyleBackColor = true;
			btnYazarlar.Click += btnYazarlar_Click;
			// 
			// btnKullanicilar
			// 
			btnKullanicilar.Location = new Point(405, 160);
			btnKullanicilar.Name = "btnKullanicilar";
			btnKullanicilar.Size = new Size(137, 41);
			btnKullanicilar.TabIndex = 8;
			btnKullanicilar.Text = "Kullanıcılar";
			btnKullanicilar.UseVisualStyleBackColor = true;
			btnKullanicilar.Click += btnKullanicilar_Click;
			// 
			// btnRaporlar
			// 
			btnRaporlar.Location = new Point(565, 117);
			btnRaporlar.Name = "btnRaporlar";
			btnRaporlar.Size = new Size(137, 39);
			btnRaporlar.TabIndex = 9;
			btnRaporlar.Text = "Raporlar";
			btnRaporlar.UseVisualStyleBackColor = true;
			btnRaporlar.Click += btnRaporlar_Click;
			// 
			// FormKullaniciEkrani
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(843, 506);
			Controls.Add(btnRaporlar);
			Controls.Add(btnKullanicilar);
			Controls.Add(btnYazarlar);
			Controls.Add(btnKategoriler);
			Controls.Add(cmbYazarAdiSoyadi);
			Controls.Add(cmbKategori);
			Controls.Add(lblKitapKapakResmi);
			Controls.Add(btnListele);
			Controls.Add(btnAra);
			Controls.Add(btnGuncelle);
			Controls.Add(btnSil);
			Controls.Add(btnEkle);
			Controls.Add(btnResimYukle);
			Controls.Add(grdListe);
			Controls.Add(txtAciklama);
			Controls.Add(txtFiyat);
			Controls.Add(txtKullaniciIsmi);
			Controls.Add(txtKitapAdi);
			Controls.Add(txtKitapID);
			Controls.Add(pbxKapakResmi);
			Controls.Add(lblFiyat);
			Controls.Add(lblKitapAciklamasi);
			Controls.Add(lblKitapAdi);
			Controls.Add(label3);
			Controls.Add(lblYazarAdiSoyadi);
			Controls.Add(lblkategoriAdi);
			Controls.Add(lblKullaniciAdi);
			Name = "FormKullaniciEkrani";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FormKullaniciEkrani";
			FormClosed += FormKullaniciEkrani_FormClosed;
			Load += FormKullaniciEkrani_Load;
			((System.ComponentModel.ISupportInitialize)pbxKapakResmi).EndInit();
			((System.ComponentModel.ISupportInitialize)grdListe).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label lblKullaniciAdi;
		private Label label3;
		private Label lblKitapAdi;
		private Label lblKitapAciklamasi;
		private Label lblFiyat;
		private Label lblkategoriAdi;
		private Label lblYazarAdiSoyadi;
		private PictureBox pbxKapakResmi;
		private OpenFileDialog openFileDialog1;
		private TextBox txtKitapID;
		private TextBox txtKitapAdi;
		private TextBox txtFiyat;
		private TextBox txtAciklama;
		private TextBox txtKullaniciIsmi;
		private DataGridView grdListe;
		private Button btnResimYukle;
		private Button btnEkle;
		private Button btnSil;
		private Button btnGuncelle;
		private Button btnAra;
		private Button btnListele;
		private Label lblKitapKapakResmi;
		private ComboBox cmbKategori;
		private ComboBox cmbYazarAdiSoyadi;
		private Button btnKategoriler;
		private Button btnYazarlar;
		private Button btnKullanicilar;
		private Button btnRaporlar;
	}
}