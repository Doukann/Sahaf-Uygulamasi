namespace SahafUygulamasi
{
	partial class FormKategori
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
			btnKategoriEkle = new Button();
			btnKategoriSil = new Button();
			btnKategoriAra = new Button();
			txtKategoriAdi = new TextBox();
			lblKategoriAdi = new Label();
			txtKategoriID = new TextBox();
			lblKategoriID = new Label();
			btnKategoriListele = new Button();
			grdKategoriListe = new DataGridView();
			btnAnaSayfayaDon = new Button();
			((System.ComponentModel.ISupportInitialize)grdKategoriListe).BeginInit();
			SuspendLayout();
			// 
			// btnKategoriEkle
			// 
			btnKategoriEkle.Location = new Point(17, 139);
			btnKategoriEkle.Name = "btnKategoriEkle";
			btnKategoriEkle.Size = new Size(330, 55);
			btnKategoriEkle.TabIndex = 0;
			btnKategoriEkle.Text = "Kategori Ekle";
			btnKategoriEkle.UseVisualStyleBackColor = true;
			btnKategoriEkle.Click += btnKategoriEkle_Click;
			// 
			// btnKategoriSil
			// 
			btnKategoriSil.Location = new Point(17, 200);
			btnKategoriSil.Name = "btnKategoriSil";
			btnKategoriSil.Size = new Size(330, 55);
			btnKategoriSil.TabIndex = 0;
			btnKategoriSil.Text = "Kategori Sil";
			btnKategoriSil.UseVisualStyleBackColor = true;
			btnKategoriSil.Click += btnKategoriSil_Click;
			// 
			// btnKategoriAra
			// 
			btnKategoriAra.Location = new Point(17, 78);
			btnKategoriAra.Name = "btnKategoriAra";
			btnKategoriAra.Size = new Size(330, 55);
			btnKategoriAra.TabIndex = 0;
			btnKategoriAra.Text = "Kategori Ara";
			btnKategoriAra.UseVisualStyleBackColor = true;
			btnKategoriAra.Click += btnKategoriAra_Click;
			// 
			// txtKategoriAdi
			// 
			txtKategoriAdi.Location = new Point(129, 45);
			txtKategoriAdi.Name = "txtKategoriAdi";
			txtKategoriAdi.PlaceholderText = "Kategori Adı";
			txtKategoriAdi.Size = new Size(218, 27);
			txtKategoriAdi.TabIndex = 1;
			// 
			// lblKategoriAdi
			// 
			lblKategoriAdi.AutoSize = true;
			lblKategoriAdi.Location = new Point(17, 48);
			lblKategoriAdi.Name = "lblKategoriAdi";
			lblKategoriAdi.Size = new Size(100, 20);
			lblKategoriAdi.TabIndex = 2;
			lblKategoriAdi.Text = "Kategori Adı :";
			// 
			// txtKategoriID
			// 
			txtKategoriID.Location = new Point(129, 12);
			txtKategoriID.Name = "txtKategoriID";
			txtKategoriID.PlaceholderText = "Kategori ID";
			txtKategoriID.Size = new Size(218, 27);
			txtKategoriID.TabIndex = 1;
			// 
			// lblKategoriID
			// 
			lblKategoriID.AutoSize = true;
			lblKategoriID.Location = new Point(17, 15);
			lblKategoriID.Name = "lblKategoriID";
			lblKategoriID.Size = new Size(92, 20);
			lblKategoriID.TabIndex = 2;
			lblKategoriID.Text = "Kategori ID :";
			// 
			// btnKategoriListele
			// 
			btnKategoriListele.Location = new Point(17, 261);
			btnKategoriListele.Name = "btnKategoriListele";
			btnKategoriListele.Size = new Size(330, 55);
			btnKategoriListele.TabIndex = 0;
			btnKategoriListele.Text = "Listele";
			btnKategoriListele.UseVisualStyleBackColor = true;
			btnKategoriListele.Click += btnKategoriListele_Click;
			// 
			// grdKategoriListe
			// 
			grdKategoriListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			grdKategoriListe.Location = new Point(366, 12);
			grdKategoriListe.Name = "grdKategoriListe";
			grdKategoriListe.RowHeadersWidth = 51;
			grdKategoriListe.Size = new Size(324, 365);
			grdKategoriListe.TabIndex = 3;
			// 
			// btnAnaSayfayaDon
			// 
			btnAnaSayfayaDon.Location = new Point(17, 322);
			btnAnaSayfayaDon.Name = "btnAnaSayfayaDon";
			btnAnaSayfayaDon.Size = new Size(330, 55);
			btnAnaSayfayaDon.TabIndex = 0;
			btnAnaSayfayaDon.Text = "Ana Ekrana Dön";
			btnAnaSayfayaDon.UseVisualStyleBackColor = true;
			btnAnaSayfayaDon.Click += btnAnaSayfayaDon_Click;
			// 
			// FormKategori
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(702, 392);
			Controls.Add(grdKategoriListe);
			Controls.Add(lblKategoriID);
			Controls.Add(lblKategoriAdi);
			Controls.Add(txtKategoriID);
			Controls.Add(txtKategoriAdi);
			Controls.Add(btnAnaSayfayaDon);
			Controls.Add(btnKategoriListele);
			Controls.Add(btnKategoriSil);
			Controls.Add(btnKategoriAra);
			Controls.Add(btnKategoriEkle);
			Name = "FormKategori";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FormKategori";
			FormClosing += FormKategori_FormClosing;
			((System.ComponentModel.ISupportInitialize)grdKategoriListe).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnKategoriEkle;
		private Button btnKategoriSil;
		private Button btnKategoriAra;
		private TextBox txtKategoriAdi;
		private Label lblKategoriAdi;
		private TextBox txtKategoriID;
		private Label lblKategoriID;
		private Button btnKategoriListele;
		private DataGridView grdKategoriListe;
		private Button btnAnaSayfayaDon;
	}
}