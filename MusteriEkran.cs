using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Borsa_Takip_Uygulamasi_V2
{   
    public partial class MusteriEkran : Form //Hisse ID,Hisse İsim,Hisse Maliyet,Hisse Lot,Hisse Kar/ZararTL,Hisse %Kar/Zarar,Anlık Toplam,Hisse Satış Fiyatı,Hisse Satış Kar/Zarar,Hisse,Hisse Tam İsim,Notlar
    {
        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-16VPERV;Initial Catalog=BorsaTakipSistemiV2;Integrated Security=True");
        public MusteriEkran()
        {
            InitializeComponent();
        }

        private void MusteriEkran_Load(object sender, EventArgs e)
        {
            //SqlCommand komut = new SqlCommand("Select * FROM Tbl_islemler",baglanti);
            //SqlDataAdapter da = new SqlDataAdapter(komut);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            

          
           

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {

        }
    }
}
