namespace SahafUygulamasi
{
	partial class FormGiris
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
			btnGirisYap = new Button();
			txtSifre = new TextBox();
			txtKullaniciAdi = new TextBox();
			lblSifre = new Label();
			lblKullaniciAdi = new Label();
			SuspendLayout();
			// 
			// btnGirisYap
			// 
			btnGirisYap.BackColor = Color.LightSteelBlue;
			btnGirisYap.FlatStyle = FlatStyle.Popup;
			btnGirisYap.ForeColor = Color.Black;
			btnGirisYap.Location = new Point(90, 138);
			btnGirisYap.Name = "btnGirisYap";
			btnGirisYap.Size = new Size(230, 50);
			btnGirisYap.TabIndex = 7;
			btnGirisYap.Text = "Giriş Yap";
			btnGirisYap.UseVisualStyleBackColor = false;
			btnGirisYap.Click += btnGirisYap_Click;
			// 
			// txtSifre
			// 
			txtSifre.Location = new Point(195, 105);
			txtSifre.Name = "txtSifre";
			txtSifre.PasswordChar = '*';
			txtSifre.PlaceholderText = "Şifre";
			txtSifre.Size = new Size(125, 27);
			txtSifre.TabIndex = 5;
			txtSifre.Text = "Do_123";
			// 
			// txtKullaniciAdi
			// 
			txtKullaniciAdi.Location = new Point(195, 72);
			txtKullaniciAdi.Name = "txtKullaniciAdi";
			txtKullaniciAdi.PlaceholderText = "Kullanıcı Adı";
			txtKullaniciAdi.Size = new Size(125, 27);
			txtKullaniciAdi.TabIndex = 6;
			txtKullaniciAdi.Text = "Dodo";
			// 
			// lblSifre
			// 
			lblSifre.AutoSize = true;
			lblSifre.Location = new Point(90, 108);
			lblSifre.Name = "lblSifre";
			lblSifre.Size = new Size(46, 20);
			lblSifre.TabIndex = 3;
			lblSifre.Text = "Şifre :";
			// 
			// lblKullaniciAdi
			// 
			lblKullaniciAdi.AutoSize = true;
			lblKullaniciAdi.Location = new Point(90, 75);
			lblKullaniciAdi.Name = "lblKullaniciAdi";
			lblKullaniciAdi.Size = new Size(99, 20);
			lblKullaniciAdi.TabIndex = 4;
			lblKullaniciAdi.Text = "Kullanıcı Adı :";
			// 
			// FormGiris
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(402, 259);
			Controls.Add(btnGirisYap);
			Controls.Add(txtSifre);
			Controls.Add(txtKullaniciAdi);
			Controls.Add(lblSifre);
			Controls.Add(lblKullaniciAdi);
			Name = "FormGiris";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FormGiris";
			FormClosing += FormGiris_FormClosing;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnGirisYap;
		private TextBox txtSifre;
		private TextBox txtKullaniciAdi;
		private Label lblSifre;
		private Label lblKullaniciAdi;
	}
}