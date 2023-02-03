namespace Borsa_Takip_Uygulamasi_V2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_eposta = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_girisyap = new System.Windows.Forms.Button();
            this.ll_analistgirisi = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sifreSifirla = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_directMusteri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_eposta
            // 
            this.txt_eposta.Location = new System.Drawing.Point(98, 54);
            this.txt_eposta.Name = "txt_eposta";
            this.txt_eposta.Size = new System.Drawing.Size(201, 26);
            this.txt_eposta.TabIndex = 0;
            this.txt_eposta.Text = "Email/MusteriNumarası";
            this.txt_eposta.MouseLeave += new System.EventHandler(this.txt_eposta_MouseLeave);
            this.txt_eposta.MouseHover += new System.EventHandler(this.txt_eposta_MouseHover);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(98, 98);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(201, 26);
            this.txt_sifre.TabIndex = 1;
            this.txt_sifre.Text = "Şifre";
            this.txt_sifre.MouseLeave += new System.EventHandler(this.txt_sifre_MouseLeave);
            this.txt_sifre.MouseHover += new System.EventHandler(this.txt_sifre_MouseHover);
            // 
            // btn_girisyap
            // 
            this.btn_girisyap.Location = new System.Drawing.Point(57, 166);
            this.btn_girisyap.Name = "btn_girisyap";
            this.btn_girisyap.Size = new System.Drawing.Size(129, 36);
            this.btn_girisyap.TabIndex = 2;
            this.btn_girisyap.Text = "Giriş Yap";
            this.btn_girisyap.UseVisualStyleBackColor = true;
            this.btn_girisyap.Click += new System.EventHandler(this.btn_girisyap_Click);
            // 
            // ll_analistgirisi
            // 
            this.ll_analistgirisi.AutoSize = true;
            this.ll_analistgirisi.Location = new System.Drawing.Point(354, 13);
            this.ll_analistgirisi.Name = "ll_analistgirisi";
            this.ll_analistgirisi.Size = new System.Drawing.Size(110, 20);
            this.ll_analistgirisi.TabIndex = 3;
            this.ll_analistgirisi.TabStop = true;
            this.ll_analistgirisi.Text = "Analist Girişi";
            this.ll_analistgirisi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_analistgirisi_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(290, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "==>";
            // 
            // btn_sifreSifirla
            // 
            this.btn_sifreSifirla.Location = new System.Drawing.Point(192, 166);
            this.btn_sifreSifirla.Name = "btn_sifreSifirla";
            this.btn_sifreSifirla.Size = new System.Drawing.Size(129, 36);
            this.btn_sifreSifirla.TabIndex = 7;
            this.btn_sifreSifirla.Text = "Şifre Sıfırla";
            this.btn_sifreSifirla.UseVisualStyleBackColor = true;
            this.btn_sifreSifirla.Click += new System.EventHandler(this.btn_sifreSifirla_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.Location = new System.Drawing.Point(12, 1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(69, 32);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_directMusteri
            // 
            this.btn_directMusteri.Location = new System.Drawing.Point(358, 72);
            this.btn_directMusteri.Name = "btn_directMusteri";
            this.btn_directMusteri.Size = new System.Drawing.Size(82, 38);
            this.btn_directMusteri.TabIndex = 9;
            this.btn_directMusteri.Text = "giriş yap şifresiz vs.";
            this.btn_directMusteri.UseVisualStyleBackColor = true;
            this.btn_directMusteri.Click += new System.EventHandler(this.btn_directMusteri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 225);
            this.Controls.Add(this.btn_directMusteri);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_sifreSifirla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ll_analistgirisi);
            this.Controls.Add(this.btn_girisyap);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_eposta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_eposta;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_girisyap;
        private System.Windows.Forms.LinkLabel ll_analistgirisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sifreSifirla;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_directMusteri;
    }
}

