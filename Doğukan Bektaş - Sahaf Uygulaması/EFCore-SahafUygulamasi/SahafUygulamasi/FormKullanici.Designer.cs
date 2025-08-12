namespace SahafUygulamasi
{
	partial class FormKullanici
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
			grdKullaniciListe = new DataGridView();
			lblKullaniciID = new Label();
			lblKullanıcıAdi = new Label();
			txtKullaniciID = new TextBox();
			txtKullaniciAdi = new TextBox();
			btnKullaniciListele = new Button();
			btnKullaniciSil = new Button();
			btnKullaniciAra = new Button();
			btnKullaniciEkle = new Button();
			btnAnaEkranaDon = new Button();
			txtKullaniciSifre = new TextBox();
			lblKullaniciSifre = new Label();
			btnKullaniciGuncelle = new Button();
			((System.ComponentModel.ISupportInitialize)grdKullaniciListe).BeginInit();
			SuspendLayout();
			// 
			// grdKullaniciListe
			// 
			grdKullaniciListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			grdKullaniciListe.Location = new Point(417, 12);
			grdKullaniciListe.Name = "grdKullaniciListe";
			grdKullaniciListe.RowHeadersWidth = 51;
			grdKullaniciListe.Size = new Size(371, 408);
			grdKullaniciListe.TabIndex = 21;
			// 
			// lblKullaniciID
			// 
			lblKullaniciID.AutoSize = true;
			lblKullaniciID.Location = new Point(12, 21);
			lblKullaniciID.Name = "lblKullaniciID";
			lblKullaniciID.Size = new Size(91, 20);
			lblKullaniciID.TabIndex = 19;
			lblKullaniciID.Text = "Kullanici ID :";
			// 
			// lblKullanıcıAdi
			// 
			lblKullanıcıAdi.AutoSize = true;
			lblKullanıcıAdi.Location = new Point(12, 57);
			lblKullanıcıAdi.Name = "lblKullanıcıAdi";
			lblKullanıcıAdi.Size = new Size(99, 20);
			lblKullanıcıAdi.TabIndex = 20;
			lblKullanıcıAdi.Text = "Kullanici Adi :";
			// 
			// txtKullaniciID
			// 
			txtKullaniciID.Location = new Point(145, 21);
			txtKullaniciID.Name = "txtKullaniciID";
			txtKullaniciID.PlaceholderText = "Kullanıcı ID";
			txtKullaniciID.Size = new Size(236, 27);
			txtKullaniciID.TabIndex = 17;
			// 
			// txtKullaniciAdi
			// 
			txtKullaniciAdi.Location = new Point(145, 54);
			txtKullaniciAdi.Name = "txtKullaniciAdi";
			txtKullaniciAdi.PlaceholderText = "Kullanıcı Adı";
			txtKullaniciAdi.Size = new Size(236, 27);
			txtKullaniciAdi.TabIndex = 18;
			// 
			// btnKullaniciListele
			// 
			btnKullaniciListele.Location = new Point(12, 324);
			btnKullaniciListele.Name = "btnKullaniciListele";
			btnKullaniciListele.Size = new Size(369, 45);
			btnKullaniciListele.TabIndex = 13;
			btnKullaniciListele.Text = "Kullanıcı Listele";
			btnKullaniciListele.UseVisualStyleBackColor = true;
			btnKullaniciListele.Click += btnKullaniciListele_Click;
			// 
			// btnKullaniciSil
			// 
			btnKullaniciSil.Location = new Point(12, 222);
			btnKullaniciSil.Name = "btnKullaniciSil";
			btnKullaniciSil.Size = new Size(369, 45);
			btnKullaniciSil.TabIndex = 14;
			btnKullaniciSil.Text = "Kullanıcı Sil";
			btnKullaniciSil.UseVisualStyleBackColor = true;
			btnKullaniciSil.Click += btnKullaniciSil_Click;
			// 
			// btnKullaniciAra
			// 
			btnKullaniciAra.Location = new Point(12, 120);
			btnKullaniciAra.Name = "btnKullaniciAra";
			btnKullaniciAra.Size = new Size(369, 45);
			btnKullaniciAra.TabIndex = 15;
			btnKullaniciAra.Text = "Kullanıcı Ara";
			btnKullaniciAra.UseVisualStyleBackColor = true;
			btnKullaniciAra.Click += btnKullaniciAra_Click;
			// 
			// btnKullaniciEkle
			// 
			btnKullaniciEkle.Location = new Point(12, 171);
			btnKullaniciEkle.Name = "btnKullaniciEkle";
			btnKullaniciEkle.Size = new Size(369, 45);
			btnKullaniciEkle.TabIndex = 16;
			btnKullaniciEkle.Text = "Kullanıcı Ekle";
			btnKullaniciEkle.UseVisualStyleBackColor = true;
			btnKullaniciEkle.Click += btnKullaniciEkle_Click;
			// 
			// btnAnaEkranaDon
			// 
			btnAnaEkranaDon.Location = new Point(12, 375);
			btnAnaEkranaDon.Name = "btnAnaEkranaDon";
			btnAnaEkranaDon.Size = new Size(369, 45);
			btnAnaEkranaDon.TabIndex = 13;
			btnAnaEkranaDon.Text = "Ana Ekrana Dön";
			btnAnaEkranaDon.UseVisualStyleBackColor = true;
			btnAnaEkranaDon.Click += btnAnaEkranaDon_Click;
			// 
			// txtKullaniciSifre
			// 
			txtKullaniciSifre.Location = new Point(145, 87);
			txtKullaniciSifre.Name = "txtKullaniciSifre";
			txtKullaniciSifre.PasswordChar = '*';
			txtKullaniciSifre.PlaceholderText = "Şifre";
			txtKullaniciSifre.Size = new Size(236, 27);
			txtKullaniciSifre.TabIndex = 18;
			// 
			// lblKullaniciSifre
			// 
			lblKullaniciSifre.AutoSize = true;
			lblKullaniciSifre.Location = new Point(12, 90);
			lblKullaniciSifre.Name = "lblKullaniciSifre";
			lblKullaniciSifre.Size = new Size(46, 20);
			lblKullaniciSifre.TabIndex = 20;
			lblKullaniciSifre.Text = "Şifre :";
			// 
			// btnKullaniciGuncelle
			// 
			btnKullaniciGuncelle.Location = new Point(12, 273);
			btnKullaniciGuncelle.Name = "btnKullaniciGuncelle";
			btnKullaniciGuncelle.Size = new Size(369, 45);
			btnKullaniciGuncelle.TabIndex = 22;
			btnKullaniciGuncelle.Text = "Kullanıcı Adı ve Şifre Güncelle";
			btnKullaniciGuncelle.UseVisualStyleBackColor = true;
			btnKullaniciGuncelle.Click += btnKullaniciGuncelle_Click;
			// 
			// FormKullanici
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 432);
			Controls.Add(btnKullaniciGuncelle);
			Controls.Add(grdKullaniciListe);
			Controls.Add(lblKullaniciID);
			Controls.Add(lblKullaniciSifre);
			Controls.Add(lblKullanıcıAdi);
			Controls.Add(txtKullaniciID);
			Controls.Add(txtKullaniciSifre);
			Controls.Add(txtKullaniciAdi);
			Controls.Add(btnAnaEkranaDon);
			Controls.Add(btnKullaniciListele);
			Controls.Add(btnKullaniciSil);
			Controls.Add(btnKullaniciAra);
			Controls.Add(btnKullaniciEkle);
			Name = "FormKullanici";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FormKullanici";
			FormClosing += FormKullanici_FormClosing;
			((System.ComponentModel.ISupportInitialize)grdKullaniciListe).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView grdKullaniciListe;
		private Label lblKullaniciID;
		private Label lblKullanıcıAdi;
		private TextBox txtKullaniciID;
		private TextBox txtKullaniciAdi;
		private Button btnKullaniciListele;
		private Button btnKullaniciSil;
		private Button btnKullaniciAra;
		private Button btnKullaniciEkle;
		private Button btnAnaEkranaDon;
		private TextBox txtKullaniciSifre;
		private Label lblKullaniciSifre;
		private Button btnKullaniciGuncelle;
	}
}