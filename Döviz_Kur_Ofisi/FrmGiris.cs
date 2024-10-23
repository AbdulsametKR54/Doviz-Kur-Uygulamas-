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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FrmGiris));
            groupBox1 = new GroupBox();
            linkLabel1 = new LinkLabel();
            checkBox1 = new CheckBox();
            btnGiris = new Button();
            txtSifre = new TextBox();
            txtKullanıcı = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SeaGreen;
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(btnGiris);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Controls.Add(txtKullanıcı);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(40, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(536, 262);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giriş";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Red;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Palatino Linotype", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            linkLabel1.Location = new Point(122, 180);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(86, 27);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Kayıt Ol";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Palatino Linotype", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            checkBox1.Location = new Point(382, 124);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(148, 31);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Şifreyi Göster";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnGiris
            // 
            btnGiris.BackgroundImageLayout = ImageLayout.Zoom;
            btnGiris.Cursor = Cursors.Hand;
            btnGiris.Location = new Point(214, 168);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(166, 45);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(191, 118);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(189, 44);
            txtSifre.TabIndex = 3;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // txtKullanıcı
            // 
            txtKullanıcı.Location = new Point(191, 63);
            txtKullanıcı.Name = "txtKullanıcı";
            txtKullanıcı.Size = new Size(189, 44);
            txtKullanıcı.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 118);
            label3.Name = "label3";
            label3.Size = new Size(78, 37);
            label3.TabIndex = 1;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 66);
            label2.Name = "label2";
            label2.Size = new Size(179, 37);
            label2.TabIndex = 0;
            label2.Text = "Kullanıcı Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(231, 19);
            label1.Name = "label1";
            label1.Size = new Size(152, 37);
            label1.TabIndex = 1;
            label1.Text = "Hesap Giriş";
            // 
            // FrmGiris
            // 
            AcceptButton = btnGiris;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(605, 365);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Font = new Font("Palatino Linotype", 16.2F, FontStyle.Italic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Döviz Kur Uygulaması";
            Load += FrmGiris_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSifre;
        private TextBox txtKullanıcı;
        private Button btnGiris;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        SqlConnection bgl = new SqlConnection("Data Source=AbdulsametKR\\SQLEXPRESS;Initial Catalog=DovizKur;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                txtSifre.UseSystemPasswordChar = true;
                checkBox1.Text = "Şifreyi Göster";
            }
            else
            {
                txtSifre.UseSystemPasswordChar = false;
                checkBox1.Text = "Şifreyi Gizle";
            }
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Kullanıcı where KullanıcıAd=@p1 and Sifre=@p2", bgl);
            komut.Parameters.AddWithValue("@p1", txtKullanıcı.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form frm = new FrmAnaMenu(dr[0].ToString(),dr[1].ToString(), Convert.ToSingle(dr[3]));
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bgl.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new FrmKayıtOl();
            frm.Show();
        }
    }
}
