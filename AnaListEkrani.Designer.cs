namespace Borsa_Takip_Uygulamasi_V2
{
    partial class AnaListEkrani
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_musterilistesi = new System.Windows.Forms.Button();
            this.btn_fiyatbilgileri = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoş Geldin,Analist İsmi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_fiyatbilgileri);
            this.groupBox1.Controls.Add(this.btn_musterilistesi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 283);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn_musterilistesi
            // 
            this.btn_musterilistesi.Location = new System.Drawing.Point(10, 92);
            this.btn_musterilistesi.Name = "btn_musterilistesi";
            this.btn_musterilistesi.Size = new System.Drawing.Size(257, 50);
            this.btn_musterilistesi.TabIndex = 1;
            this.btn_musterilistesi.Text = "Müşteri Listesi";
            this.btn_musterilistesi.UseVisualStyleBackColor = true;
            // 
            // btn_fiyatbilgileri
            // 
            this.btn_fiyatbilgileri.Location = new System.Drawing.Point(10, 161);
            this.btn_fiyatbilgileri.Name = "btn_fiyatbilgileri";
            this.btn_fiyatbilgileri.Size = new System.Drawing.Size(257, 50);
            this.btn_fiyatbilgileri.TabIndex = 2;
            this.btn_fiyatbilgileri.Text = "Fiyat Bilgileri";
            this.btn_fiyatbilgileri.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Müşteri İşlemleri";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AnaListEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 703);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AnaListEkrani";
            this.Text = "AnaListEkrani";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_musterilistesi;
        private System.Windows.Forms.Button btn_fiyatbilgileri;
        private System.Windows.Forms.Button button1;
    }
}