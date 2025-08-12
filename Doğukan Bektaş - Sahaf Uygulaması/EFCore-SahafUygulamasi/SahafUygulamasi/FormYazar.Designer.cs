namespace SahafUygulamasi
{
	partial class FormYazar
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
			grdYazarListe = new DataGridView();
			lblYazarID = new Label();
			lblYazarAdiSoyadi = new Label();
			txtYazarID = new TextBox();
			txtYazarAdiSoyadi = new TextBox();
			btnYazarListele = new Button();
			btnYazarSil = new Button();
			btnYazarAra = new Button();
			btnYazarEkle = new Button();
			btnAnaEkranaDon = new Button();
			((System.ComponentModel.ISupportInitialize)grdYazarListe).BeginInit();
			SuspendLayout();
			// 
			// grdYazarListe
			// 
			grdYazarListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			grdYazarListe.Location = new Point(417, 12);
			grdYazarListe.Name = "grdYazarListe";
			grdYazarListe.RowHeadersWidth = 51;
			grdYazarListe.Size = new Size(371, 394);
			grdYazarListe.TabIndex = 12;
			// 
			// lblYazarID
			// 
			lblYazarID.AutoSize = true;
			lblYazarID.Location = new Point(12, 21);
			lblYazarID.Name = "lblYazarID";
			lblYazarID.Size = new Size(70, 20);
			lblYazarID.TabIndex = 10;
			lblYazarID.Text = "Yazar ID :";
			// 
			// lblYazarAdiSoyadi
			// 
			lblYazarAdiSoyadi.AutoSize = true;
			lblYazarAdiSoyadi.Location = new Point(12, 72);
			lblYazarAdiSoyadi.Name = "lblYazarAdiSoyadi";
			lblYazarAdiSoyadi.Size = new Size(127, 20);
			lblYazarAdiSoyadi.TabIndex = 11;
			lblYazarAdiSoyadi.Text = "Yazar Adı Soyadı :";
			// 
			// txtYazarID
			// 
			txtYazarID.Location = new Point(145, 21);
			txtYazarID.Name = "txtYazarID";
			txtYazarID.PlaceholderText = "Yazar ID";
			txtYazarID.Size = new Size(236, 27);
			txtYazarID.TabIndex = 8;
			// 
			// txtYazarAdiSoyadi
			// 
			txtYazarAdiSoyadi.Location = new Point(145, 69);
			txtYazarAdiSoyadi.Name = "txtYazarAdiSoyadi";
			txtYazarAdiSoyadi.PlaceholderText = "Yazar Adı Soyadı";
			txtYazarAdiSoyadi.Size = new Size(236, 27);
			txtYazarAdiSoyadi.TabIndex = 9;
			// 
			// btnYazarListele
			// 
			btnYazarListele.Location = new Point(12, 288);
			btnYazarListele.Name = "btnYazarListele";
			btnYazarListele.Size = new Size(369, 56);
			btnYazarListele.TabIndex = 4;
			btnYazarListele.Text = "Listele";
			btnYazarListele.UseVisualStyleBackColor = true;
			btnYazarListele.Click += btnYazarListele_Click;
			// 
			// btnYazarSil
			// 
			btnYazarSil.Location = new Point(12, 226);
			btnYazarSil.Name = "btnYazarSil";
			btnYazarSil.Size = new Size(369, 56);
			btnYazarSil.TabIndex = 5;
			btnYazarSil.Text = "Yazar Sil";
			btnYazarSil.UseVisualStyleBackColor = true;
			btnYazarSil.Click += btnYazarSil_Click;
			// 
			// btnYazarAra
			// 
			btnYazarAra.Location = new Point(12, 102);
			btnYazarAra.Name = "btnYazarAra";
			btnYazarAra.Size = new Size(369, 56);
			btnYazarAra.TabIndex = 6;
			btnYazarAra.Text = "Yazar Ara";
			btnYazarAra.UseVisualStyleBackColor = true;
			btnYazarAra.Click += btnYazarAra_Click;
			// 
			// btnYazarEkle
			// 
			btnYazarEkle.Location = new Point(12, 164);
			btnYazarEkle.Name = "btnYazarEkle";
			btnYazarEkle.Size = new Size(369, 56);
			btnYazarEkle.TabIndex = 7;
			btnYazarEkle.Text = "Yazar Ekle";
			btnYazarEkle.UseVisualStyleBackColor = true;
			btnYazarEkle.Click += btnYazarEkle_Click;
			// 
			// btnAnaEkranaDon
			// 
			btnAnaEkranaDon.Location = new Point(12, 350);
			btnAnaEkranaDon.Name = "btnAnaEkranaDon";
			btnAnaEkranaDon.Size = new Size(369, 56);
			btnAnaEkranaDon.TabIndex = 14;
			btnAnaEkranaDon.Text = "Ana Ekrana Dön";
			btnAnaEkranaDon.UseVisualStyleBackColor = true;
			btnAnaEkranaDon.Click += btnAnaEkranaDon_Click;
			// 
			// FormYazar
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 418);
			Controls.Add(btnAnaEkranaDon);
			Controls.Add(grdYazarListe);
			Controls.Add(lblYazarID);
			Controls.Add(lblYazarAdiSoyadi);
			Controls.Add(txtYazarID);
			Controls.Add(txtYazarAdiSoyadi);
			Controls.Add(btnYazarListele);
			Controls.Add(btnYazarSil);
			Controls.Add(btnYazarAra);
			Controls.Add(btnYazarEkle);
			Name = "FormYazar";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FormYazar";
			FormClosing += FormYazar_FormClosing;
			((System.ComponentModel.ISupportInitialize)grdYazarListe).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView grdYazarListe;
		private Label lblYazarID;
		private Label lblYazarAdiSoyadi;
		private TextBox txtYazarID;
		private TextBox txtYazarAdiSoyadi;
		private Button btnYazarListele;
		private Button btnYazarSil;
		private Button btnYazarAra;
		private Button btnYazarEkle;
		private Button btnAnaEkranaDon;
	}
}