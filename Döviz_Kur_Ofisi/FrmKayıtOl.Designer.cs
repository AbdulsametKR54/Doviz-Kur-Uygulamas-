namespace Döviz_Kur_Ofisi
{
    partial class FrmKayıtOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKayıtOl));
            label1 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            txtBakiye = new TextBox();
            label5 = new Label();
            txtAdSoyad = new TextBox();
            label4 = new Label();
            btnKayıtOl = new Button();
            txtSifre = new TextBox();
            txtKullanıcı = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(118, 25);
            label1.Name = "label1";
            label1.Size = new Size(157, 37);
            label1.TabIndex = 3;
            label1.Text = "Hesap Kayıt";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SeaGreen;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtBakiye);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnKayıtOl);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Controls.Add(txtKullanıcı);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(28, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 303);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giriş";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.ForeColor = SystemColors.ControlDark;
            label6.Location = new Point(330, 190);
            label6.Name = "label6";
            label6.Size = new Size(50, 37);
            label6.TabIndex = 11;
            label6.Text = "TL";
            // 
            // txtBakiye
            // 
            txtBakiye.Location = new Point(191, 187);
            txtBakiye.Name = "txtBakiye";
            txtBakiye.Size = new Size(189, 44);
            txtBakiye.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 187);
            label5.Name = "label5";
            label5.Size = new Size(98, 37);
            label5.TabIndex = 10;
            label5.Text = "Bakiye:";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(191, 87);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(189, 44);
            txtAdSoyad.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 90);
            label4.Name = "label4";
            label4.Size = new Size(135, 37);
            label4.TabIndex = 8;
            label4.Text = "Ad-Soyad:";
            // 
            // btnKayıtOl
            // 
            btnKayıtOl.BackgroundImageLayout = ImageLayout.Zoom;
            btnKayıtOl.Cursor = Cursors.Hand;
            btnKayıtOl.Location = new Point(214, 241);
            btnKayıtOl.Name = "btnKayıtOl";
            btnKayıtOl.Size = new Size(166, 45);
            btnKayıtOl.TabIndex = 7;
            btnKayıtOl.Text = "Kayıt Ol";
            btnKayıtOl.UseVisualStyleBackColor = true;
            btnKayıtOl.Click += btnKayıtOl_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(191, 137);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(189, 44);
            txtSifre.TabIndex = 4;
            // 
            // txtKullanıcı
            // 
            txtKullanıcı.Location = new Point(191, 37);
            txtKullanıcı.Name = "txtKullanıcı";
            txtKullanıcı.Size = new Size(189, 44);
            txtKullanıcı.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 134);
            label3.Name = "label3";
            label3.Size = new Size(78, 37);
            label3.TabIndex = 1;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 40);
            label2.Name = "label2";
            label2.Size = new Size(179, 37);
            label2.TabIndex = 0;
            label2.Text = "Kullanıcı Adı:";
            // 
            // FrmKayıtOl
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(498, 439);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Palatino Linotype", 16.2F, FontStyle.Italic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "FrmKayıtOl";
            Text = "FrmKayıtOl";
            Load += FrmKayıtOl_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnKayıtOl;
        private TextBox txtSifre;
        private TextBox txtKullanıcı;
        private Label label3;
        private Label label2;
        private TextBox txtAdSoyad;
        private Label label4;
        private TextBox txtBakiye;
        private Label label5;
        private Label label6;
    }
}