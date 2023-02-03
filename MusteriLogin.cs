using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borsa_Takip_Uygulamasi_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_eposta_MouseHover(object sender, EventArgs e)
        {
            if (txt_eposta.Text== "Email/MusteriNumarası")
            {
            txt_eposta.Text = " ";
            }
            
        }

        private void txt_sifre_MouseHover(object sender, EventArgs e)
        {
            if (txt_sifre.Text== "Şifre")
            { 
                txt_sifre.Text = " ";
            }
            
            
        }

        private void txt_eposta_MouseLeave(object sender, EventArgs e)
        {
            if (txt_eposta.Text==" ")
            {
                txt_eposta.Text = "Email/MusteriNumarası";
            }
        }

        private void txt_sifre_MouseLeave(object sender, EventArgs e)
        {
            if (txt_sifre.Text==" ")
            {
                txt_sifre.Text = "Şifre";
            }
        }

        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_sifreSifirla_Click(object sender, EventArgs e)
        {

        }

        private void btn_directMusteri_Click(object sender, EventArgs e)
        {
            MusteriEkran musteriEkran=new MusteriEkran();
            musteriEkran.ShowDialog(); 
        }

        private void ll_analistgirisi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AnaListEkrani analistEkrani=new AnaListEkrani();
            analistEkrani.ShowDialog();

        }
    }
}
