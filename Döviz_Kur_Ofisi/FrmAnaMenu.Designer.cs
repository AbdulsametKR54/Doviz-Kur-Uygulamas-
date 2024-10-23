namespace Döviz_Kur_Ofisi
{
    partial class FrmAnaMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaMenu));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            lblDolarAlıs = new Label();
            lblDolarSatıs = new Label();
            groupBox2 = new GroupBox();
            lblEuroAlis = new Label();
            lblEuroSatis = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            btnHesapla = new Button();
            rBAlıs = new RadioButton();
            rBSatıs = new RadioButton();
            txtTutar = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label5 = new Label();
            txtMiktar = new TextBox();
            lblAlıs = new Label();
            cmbSecim = new ComboBox();
            lblSatıs = new Label();
            label8 = new Label();
            label9 = new Label();
            label4 = new Label();
            groupBox4 = new GroupBox();
            lblBakiye = new Label();
            label14 = new Label();
            pictureBox1 = new PictureBox();
            lblKullanıcı = new Label();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            groupBox5 = new GroupBox();
            btnCıkıs = new Button();
            btnVarlıklar = new Button();
            btnSatısYap = new Button();
            btnSatınAl = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(357, 9);
            label1.Name = "label1";
            label1.Size = new Size(225, 37);
            label1.TabIndex = 0;
            label1.Text = "Anlık Döviz Kuru";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(27, 40);
            label2.Name = "label2";
            label2.Size = new Size(154, 37);
            label2.TabIndex = 1;
            label2.Text = "Dolar Satış:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(38, 77);
            label3.Name = "label3";
            label3.Size = new Size(143, 37);
            label3.TabIndex = 2;
            label3.Text = "Dolar Alış:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(lblDolarAlıs);
            groupBox1.Controls.Add(lblDolarSatıs);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(357, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 132);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "USD $";
            // 
            // lblDolarAlıs
            // 
            lblDolarAlıs.AutoSize = true;
            lblDolarAlıs.BackColor = Color.Transparent;
            lblDolarAlıs.ForeColor = SystemColors.ButtonHighlight;
            lblDolarAlıs.Location = new Point(177, 77);
            lblDolarAlıs.Name = "lblDolarAlıs";
            lblDolarAlıs.Size = new Size(31, 37);
            lblDolarAlıs.TabIndex = 5;
            lblDolarAlıs.Text = "0";
            // 
            // lblDolarSatıs
            // 
            lblDolarSatıs.AutoSize = true;
            lblDolarSatıs.BackColor = Color.Transparent;
            lblDolarSatıs.ForeColor = SystemColors.ButtonHighlight;
            lblDolarSatıs.Location = new Point(178, 40);
            lblDolarSatıs.Name = "lblDolarSatıs";
            lblDolarSatıs.Size = new Size(31, 37);
            lblDolarSatıs.TabIndex = 4;
            lblDolarSatıs.Text = "0";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(lblEuroAlis);
            groupBox2.Controls.Add(lblEuroSatis);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(357, 187);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(344, 132);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "EURO €";
            // 
            // lblEuroAlis
            // 
            lblEuroAlis.AutoSize = true;
            lblEuroAlis.BackColor = Color.Transparent;
            lblEuroAlis.ForeColor = SystemColors.ButtonHighlight;
            lblEuroAlis.Location = new Point(177, 77);
            lblEuroAlis.Name = "lblEuroAlis";
            lblEuroAlis.Size = new Size(31, 37);
            lblEuroAlis.TabIndex = 5;
            lblEuroAlis.Text = "0";
            // 
            // lblEuroSatis
            // 
            lblEuroSatis.AutoSize = true;
            lblEuroSatis.BackColor = Color.Transparent;
            lblEuroSatis.ForeColor = SystemColors.ButtonHighlight;
            lblEuroSatis.Location = new Point(178, 40);
            lblEuroSatis.Name = "lblEuroSatis";
            lblEuroSatis.Size = new Size(31, 37);
            lblEuroSatis.TabIndex = 4;
            lblEuroSatis.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(27, 40);
            label6.Name = "label6";
            label6.Size = new Size(144, 37);
            label6.TabIndex = 1;
            label6.Text = "Euro Satış:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(27, 77);
            label7.Name = "label7";
            label7.Size = new Size(133, 37);
            label7.TabIndex = 2;
            label7.Text = "Euro Alış:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveCaption;
            groupBox3.Controls.Add(btnHesapla);
            groupBox3.Controls.Add(rBAlıs);
            groupBox3.Controls.Add(rBSatıs);
            groupBox3.Controls.Add(txtTutar);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtMiktar);
            groupBox3.Controls.Add(lblAlıs);
            groupBox3.Controls.Add(cmbSecim);
            groupBox3.Controls.Add(lblSatıs);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(735, 53);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(386, 335);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(192, 280);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(175, 42);
            btnHesapla.TabIndex = 16;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // rBAlıs
            // 
            rBAlıs.AutoSize = true;
            rBAlıs.ForeColor = SystemColors.ControlDarkDark;
            rBAlıs.Location = new Point(291, 75);
            rBAlıs.Name = "rBAlıs";
            rBAlıs.Size = new Size(85, 41);
            rBAlıs.TabIndex = 15;
            rBAlıs.TabStop = true;
            rBAlıs.Text = "Alış";
            rBAlıs.UseVisualStyleBackColor = true;
            rBAlıs.CheckedChanged += rBAlıs_CheckedChanged;
            // 
            // rBSatıs
            // 
            rBSatıs.AutoSize = true;
            rBSatıs.ForeColor = SystemColors.ControlDarkDark;
            rBSatıs.Location = new Point(291, 36);
            rBSatıs.Name = "rBSatıs";
            rBSatıs.Size = new Size(95, 41);
            rBSatıs.TabIndex = 14;
            rBSatıs.TabStop = true;
            rBSatıs.Text = "Satış";
            rBSatıs.UseVisualStyleBackColor = true;
            rBSatıs.CheckedChanged += rBSatıs_CheckedChanged;
            // 
            // txtTutar
            // 
            txtTutar.Enabled = false;
            txtTutar.Location = new Point(192, 230);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(175, 44);
            txtTutar.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(98, 230);
            label11.Name = "label11";
            label11.Size = new Size(88, 37);
            label11.TabIndex = 12;
            label11.Text = "Tutar:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(83, 180);
            label10.Name = "label10";
            label10.Size = new Size(103, 37);
            label10.TabIndex = 11;
            label10.Text = "Miktar:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(32, 129);
            label5.Name = "label5";
            label5.Size = new Size(158, 37);
            label5.TabIndex = 10;
            label5.Text = "Para Birimi:";
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(192, 180);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(175, 44);
            txtMiktar.TabIndex = 9;
            // 
            // lblAlıs
            // 
            lblAlıs.AutoSize = true;
            lblAlıs.BackColor = Color.Transparent;
            lblAlıs.ForeColor = SystemColors.ButtonHighlight;
            lblAlıs.Location = new Point(121, 81);
            lblAlıs.Name = "lblAlıs";
            lblAlıs.Size = new Size(31, 37);
            lblAlıs.TabIndex = 5;
            lblAlıs.Text = "0";
            lblAlıs.Click += lblAlıs_Click;
            // 
            // cmbSecim
            // 
            cmbSecim.FormattingEnabled = true;
            cmbSecim.Location = new Point(192, 129);
            cmbSecim.Name = "cmbSecim";
            cmbSecim.Size = new Size(175, 45);
            cmbSecim.TabIndex = 8;
            cmbSecim.SelectedIndexChanged += cmbSecim_SelectedIndexChanged;
            // 
            // lblSatıs
            // 
            lblSatıs.AutoSize = true;
            lblSatıs.BackColor = Color.Transparent;
            lblSatıs.ForeColor = SystemColors.ButtonHighlight;
            lblSatıs.Location = new Point(121, 44);
            lblSatıs.Name = "lblSatıs";
            lblSatıs.Size = new Size(31, 37);
            lblSatıs.TabIndex = 4;
            lblSatıs.Text = "0";
            lblSatıs.Click += lblSatıs_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(27, 40);
            label8.Name = "label8";
            label8.Size = new Size(88, 37);
            label8.TabIndex = 1;
            label8.Text = " Satış:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(44, 77);
            label9.Name = "label9";
            label9.Size = new Size(71, 37);
            label9.TabIndex = 2;
            label9.Text = "Alış:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gainsboro;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(735, 13);
            label4.Name = "label4";
            label4.Size = new Size(213, 37);
            label4.TabIndex = 8;
            label4.Text = "Özel Döviz Kuru";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.SeaGreen;
            groupBox4.Controls.Add(lblBakiye);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(pictureBox1);
            groupBox4.Controls.Add(lblKullanıcı);
            groupBox4.Controls.Add(label12);
            groupBox4.Location = new Point(12, 13);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(324, 111);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hesap:";
            // 
            // lblBakiye
            // 
            lblBakiye.AutoSize = true;
            lblBakiye.BackColor = Color.Transparent;
            lblBakiye.Font = new Font("Palatino Linotype", 12F, FontStyle.Italic);
            lblBakiye.ForeColor = SystemColors.ButtonHighlight;
            lblBakiye.Location = new Point(109, 76);
            lblBakiye.Name = "lblBakiye";
            lblBakiye.Size = new Size(22, 27);
            lblBakiye.TabIndex = 6;
            lblBakiye.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Palatino Linotype", 12F, FontStyle.Italic);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(30, 76);
            label14.Name = "label14";
            label14.Size = new Size(73, 27);
            label14.TabIndex = 5;
            label14.Text = "Bakiye:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(256, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblKullanıcı
            // 
            lblKullanıcı.AutoSize = true;
            lblKullanıcı.BackColor = Color.Transparent;
            lblKullanıcı.Font = new Font("Palatino Linotype", 12F, FontStyle.Italic);
            lblKullanıcı.ForeColor = SystemColors.ButtonHighlight;
            lblKullanıcı.Location = new Point(109, 36);
            lblKullanıcı.Name = "lblKullanıcı";
            lblKullanıcı.Size = new Size(22, 27);
            lblKullanıcı.TabIndex = 3;
            lblKullanıcı.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Palatino Linotype", 12F, FontStyle.Italic);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(8, 36);
            label12.Name = "label12";
            label12.Size = new Size(95, 27);
            label12.TabIndex = 2;
            label12.Text = "Kullanıcı:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(324, 317);
            dataGridView1.TabIndex = 7;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.ActiveCaption;
            groupBox5.Controls.Add(btnCıkıs);
            groupBox5.Controls.Add(btnVarlıklar);
            groupBox5.Controls.Add(btnSatısYap);
            groupBox5.Controls.Add(btnSatınAl);
            groupBox5.Location = new Point(357, 325);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(344, 132);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "Anlık İşlemler";
            // 
            // btnCıkıs
            // 
            btnCıkıs.Location = new Point(178, 80);
            btnCıkıs.Name = "btnCıkıs";
            btnCıkıs.Size = new Size(149, 42);
            btnCıkıs.TabIndex = 21;
            btnCıkıs.Text = "Çıkış Yap";
            btnCıkıs.UseVisualStyleBackColor = true;
            btnCıkıs.Click += btnCıkıs_Click;
            // 
            // btnVarlıklar
            // 
            btnVarlıklar.Location = new Point(7, 80);
            btnVarlıklar.Name = "btnVarlıklar";
            btnVarlıklar.Size = new Size(153, 42);
            btnVarlıklar.TabIndex = 20;
            btnVarlıklar.Text = "Varlıklar";
            btnVarlıklar.UseVisualStyleBackColor = true;
            btnVarlıklar.Click += btnVarlıklar_Click;
            // 
            // btnSatısYap
            // 
            btnSatısYap.Location = new Point(178, 36);
            btnSatısYap.Name = "btnSatısYap";
            btnSatısYap.Size = new Size(149, 42);
            btnSatısYap.TabIndex = 19;
            btnSatısYap.Text = "Satış Yap";
            btnSatısYap.UseVisualStyleBackColor = true;
            btnSatısYap.Click += btnSatısYap_Click;
            // 
            // btnSatınAl
            // 
            btnSatınAl.Location = new Point(7, 36);
            btnSatınAl.Name = "btnSatınAl";
            btnSatınAl.Size = new Size(153, 42);
            btnSatınAl.TabIndex = 18;
            btnSatınAl.Text = "Satın Al";
            btnSatınAl.UseVisualStyleBackColor = true;
            btnSatınAl.Click += btnSatınAl_Click;
            // 
            // FrmAnaMenu
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1139, 461);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(label4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Palatino Linotype", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "FrmAnaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Döviz Kur Uygulaması";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label lblDolarAlıs;
        private Label lblDolarSatıs;
        private GroupBox groupBox2;
        private Label lblEuroAlis;
        private Label lblEuroSatis;
        private Label label6;
        private Label label7;
        private GroupBox groupBox3;
        private Label lblAlıs;
        private Label lblSatıs;
        private Label label8;
        private Label label9;
        private ComboBox cmbSecim;
        private TextBox txtMiktar;
        private Label label4;
        private Label label10;
        private Label label5;
        private Label label11;
        private TextBox txtTutar;
        private RadioButton rBAlıs;
        private RadioButton rBSatıs;
        private Button btnHesapla;
        private GroupBox groupBox4;
        private Label lblKullanıcı;
        private Label label12;
        private PictureBox pictureBox1;
        private Label label14;
        private Label lblBakiye;
        private DataGridView dataGridView1;
        private GroupBox groupBox5;
        private Button btnSatınAl;
        private Button btnCıkıs;
        private Button btnVarlıklar;
        private Button btnSatısYap;
    }
}
