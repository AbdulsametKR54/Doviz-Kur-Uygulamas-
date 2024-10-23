using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Döviz_Kur_Ofisi
{
    public partial class FrmKayıtOl : Form
    {
        public FrmKayıtOl()
        {
            InitializeComponent();
        }

        SqlConnection bgl = new SqlConnection("Data Source=AbdulsametKR\\SQLEXPRESS;Initial Catalog=DovizKur;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        private void FrmKayıtOl_Load(object sender, EventArgs e)
        {

        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Kullanıcı (KullanıcıAd,AdSoyad,Sifre,Bakiye) values (@p1,@p2,@p3,@p4)", bgl);
            komut.Parameters.AddWithValue("@p1", txtKullanıcı.Text);
            komut.Parameters.AddWithValue("@p2", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtSifre.Text);
            komut.Parameters.AddWithValue("@p4", Convert.ToDouble(txtBakiye.Text));
            komut.ExecuteNonQuery();
            bgl.Close();
            this.Close();
        }
    }
}
