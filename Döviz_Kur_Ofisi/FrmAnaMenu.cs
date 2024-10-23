using Microsoft.Data.SqlClient;
using System.Data;
using System.Xml;

namespace Döviz_Kur_Ofisi
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu(string Kullanıcı, string adSoyad, float para2)
        {
            InitializeComponent();
            name = adSoyad;
            bakiye = para2;
            kullanıcı = Kullanıcı;
        }
        string kullanıcı;
        string name;
        float bakiye;
        SqlConnection bgl = new SqlConnection("Data Source=AbdulsametKR\\SQLEXPRESS;Initial Catalog=DovizKur;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        float? bakiyem;
        string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
        private void Form1_Load(object sender, EventArgs e)
        {
            lblKullanıcı.Text = name;
            lblBakiye.Text = bakiye + " TL";
            var xmldosya = new XmlDocument();
            xmldosya.Load(today);

            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lblDolarAlıs.Text = dolaralis + " TL";

            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lblDolarSatıs.Text = dolarsatis + " TL";

            string euroalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lblEuroAlis.Text = euroalis + " TL";

            string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lblEuroSatis.Text = eurosatis + " TL";

            XmlNodeList secim = xmldosya.SelectNodes("Tarih_Date/Currency[number(@CrossOrder) <= 11 and (@CrossOrder>0 or @Kod!='XDR')]/@Kod");
            foreach (XmlNode node in secim)
            {
                cmbSecim.Items.Add(node.InnerText); // Isim düğümünün metin değerini ComboBox'a ekler
            }
            dataGridView1.Visible = false;
        }

        private void cmbSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            var xmldosya = new XmlDocument();
            xmldosya.Load(today);


            string secimGroup = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='" + cmbSecim.Text + "']/Isim").InnerXml;
            groupBox3.Text = secimGroup;

            string secimOzelAlıs = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='" + cmbSecim.Text + "']/BanknoteBuying").InnerXml;
            if (secimOzelAlıs != null)
            {
                lblAlıs.Text = secimOzelAlıs;
                lblAlıs.Text = lblAlıs.Text.Replace(".", ",");
            }
            else
            {
                lblAlıs.Text = "Döviz bulunamadı.";
            }

            string secimOzelSatıs = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='" + cmbSecim.Text + "']/BanknoteSelling").InnerXml;
            if (secimOzelSatıs != null)
            {
                lblSatıs.Text = secimOzelSatıs;
                lblSatıs.Text = lblSatıs.Text.Replace(".", ",");
            }
            else
            {
                lblSatıs.Text = "Döviz bulunamadı.";
            }
            txtTutar.Clear();
            rBAlıs.Checked = false;
            rBSatıs.Checked = false;
        }

        double para;
        private void rBSatıs_CheckedChanged(object sender, EventArgs e)
        {
            if (rBSatıs.Checked)
            {
                para = Convert.ToDouble(lblSatıs.Text);
            }
        }

        private void rBAlıs_CheckedChanged(object sender, EventArgs e)
        {
            if (rBAlıs.Checked)
            {
                para = Convert.ToDouble(lblAlıs.Text);
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double TutarPara = Convert.ToDouble(txtMiktar.Text);
            txtTutar.Text = Convert.ToString(TutarPara * para);
        }

        private void lblSatıs_Click(object sender, EventArgs e)
        {
            lblSatıs.Text = lblSatıs.Text.Replace(".", ",");
        }

        private void lblAlıs_Click(object sender, EventArgs e)
        {
            lblAlıs.Text = lblAlıs.Text.Replace(".", ",");
        }

        private void btnSatınAl_Click(object sender, EventArgs e)
        {
            string tempTutar = txtTutar.Text;
            UpdateVarlık(true);
            //tempTutar = tempTutar.Replace(",", ".");
            if (islemYapıldı)
            {
                if (Convert.ToDouble(bakiye) > Convert.ToDouble(tempTutar))
                {
                    bakiye -= Convert.ToSingle(txtTutar.Text);
                    lblBakiye.Text = bakiye.ToString("F3");
                    UpdateBakiye();
                    TableCode();
                }
                else
                {
                    MessageBox.Show("Yetersiz Bakiye!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            islemYapıldı = false;
        }
        private void btnSatısYap_Click(object sender, EventArgs e)
        {
            UpdateVarlık(false);
            if (islemYapıldı)
            {
                string tempTutar = txtTutar.Text;
                bakiye += Convert.ToSingle(txtTutar.Text);
                lblBakiye.Text = bakiye.ToString("F3");
                UpdateBakiye();
                TableCode();
            }
            islemYapıldı = false;
        }
        void UpdateBakiye()
        {
            //Satın Alma İşlemi sonrası Bakiye Güncelleme
            bgl.Open();
            SqlCommand komut2 = new SqlCommand("Update Tbl_Kullanıcı set Bakiye=@p1 where KullanıcıAd=@p2", bgl);
            komut2.Parameters.AddWithValue("@p2", kullanıcı);
            komut2.Parameters.AddWithValue("@p1", Convert.ToSingle((lblBakiye.Text)));
            int rowAffect = komut2.ExecuteNonQuery();
            if (rowAffect > 0)
            {
                MessageBox.Show("İşlem kaydı başarıyla yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("İşlem kaydı yapılamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.Close();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVarlıklar_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            TableCode();
        }

        bool mevcut = false;
        int tempMiktar = 0;
        bool islemYapıldı = false;
        public void UpdateVarlık(bool alım)
        {
            //Varlık tablosuna ekleme mi yapılacağını yoksa silme mi yapılacağını ayıt etmek için 'alım' oluşturuldu
            bgl.Open();
            if(alım)
            {
                SqlCommand komut = new SqlCommand("Select * From Tbl_Varlık where Sahip=@p1", bgl);
                komut.Parameters.AddWithValue("@p1", kullanıcı);
                SqlDataReader dr= komut.ExecuteReader();
                while (dr.Read())
                {
                    if (cmbSecim.Text == dr[1].ToString())
                    {
                        tempMiktar = Convert.ToInt32(dr[2]);
                        mevcut = true;
                    }
                }
                dr.Close();
                if (mevcut)
                {
                    SqlCommand komut2 = new SqlCommand("Update Tbl_Varlık set Miktar=@p1 where Sahip=@p2 and Kod=@p3", bgl);
                    komut2.Parameters.AddWithValue("@p1", Convert.ToInt32(txtMiktar.Text) + tempMiktar);
                    komut2.Parameters.AddWithValue("@p2", kullanıcı);
                    komut2.Parameters.AddWithValue("@p3", cmbSecim.Text);
                    komut2.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand komutEkle = new SqlCommand("Insert into Tbl_Varlık (Sahip,Kod,Miktar) values (@l1,@l2,@l3)", bgl);
                    komutEkle.Parameters.AddWithValue("@l1", kullanıcı);
                    komutEkle.Parameters.AddWithValue("@l2", cmbSecim.Text);
                    komutEkle.Parameters.AddWithValue("@l3", Convert.ToInt32(txtMiktar.Text));
                    komutEkle.ExecuteNonQuery();
                }
                islemYapıldı = true;
            }
            else
            {   //Kontrol ekle miktardan azsa direkt sil diğer türlü güncelle
                SqlCommand komut = new SqlCommand("Select * From Tbl_Varlık where Sahip=@p1", bgl);
                komut.Parameters.AddWithValue("@p1", kullanıcı);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    if (cmbSecim.Text == dr[1].ToString())
                    {
                        tempMiktar = Convert.ToInt32(dr[2]);
                    }
                }
                dr.Close();
                if (tempMiktar == Convert.ToInt32(txtMiktar.Text))
                {
                    SqlCommand komutSil = new SqlCommand("Delete From Tbl_Varlık where Sahip=@k1 and Kod=@k2", bgl);
                    komutSil.Parameters.AddWithValue("@k1", kullanıcı);
                    komutSil.Parameters.AddWithValue("@k2", cmbSecim.Text);
                    komutSil.ExecuteNonQuery();
                    islemYapıldı = true;
                }
                else if (tempMiktar > Convert.ToInt32(txtMiktar.Text))
                {
                    SqlCommand komut2 = new SqlCommand("Update Tbl_Varlık set Miktar=@p1 where Sahip=@p2 and Kod=@p3", bgl);
                    komut2.Parameters.AddWithValue("@p1", tempMiktar - Convert.ToInt32(txtMiktar.Text));
                    komut2.Parameters.AddWithValue("@p2", kullanıcı);
                    komut2.Parameters.AddWithValue("@p3", cmbSecim.Text);
                    komut2.ExecuteNonQuery();
                    islemYapıldı = true;
                }
                else
                {
                    MessageBox.Show("Bakiye Yetersiz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    islemYapıldı = false;
                }
            }
            bgl.Close();
        }
        private void TableCode()
        {
            DataTable dt=new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Varlık where Sahip='" + kullanıcı + "'", bgl);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
