namespace Ali_Alper_Doğan
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtForma = new System.Windows.Forms.TextBox();
            this.TxtBilet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbnkalanbilet = new System.Windows.Forms.Label();
            this.lbnkalanforma = new System.Windows.Forms.Label();
            this.lbnbilet = new System.Windows.Forms.Label();
            this.lbnforma = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbnsatılanbiletsayısı = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbnsatılanformasayısı = new System.Windows.Forms.Label();
            this.lbnkasa = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbkategori = new System.Windows.Forms.ComboBox();
            this.lblFormattr = new System.Windows.Forms.Label();
            this.comboSecim = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(89, 495);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fiyat Listesi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(14, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "(3)Numaralı 30 tl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "(2)Maraton 20 tl";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "(1)Kale Arkası 10 tl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forma 54 tl";
            // 
            // TxtForma
            // 
            this.TxtForma.Location = new System.Drawing.Point(627, 329);
            this.TxtForma.Name = "TxtForma";
            this.TxtForma.Size = new System.Drawing.Size(100, 28);
            this.TxtForma.TabIndex = 1;
            // 
            // TxtBilet
            // 
            this.TxtBilet.Location = new System.Drawing.Point(871, 329);
            this.TxtBilet.Name = "TxtBilet";
            this.TxtBilet.Size = new System.Drawing.Size(100, 28);
            this.TxtBilet.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Forma Adet :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(775, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bilet Adet :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Harlow Solid Italic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(586, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(535, 35);
            this.label8.TabIndex = 9;
            this.label8.Text = "Şampiyonluk Bekliyor Bu Şehrin Çocukları";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lbnkalanbilet);
            this.groupBox2.Controls.Add(this.lbnkalanforma);
            this.groupBox2.Controls.Add(this.lbnbilet);
            this.groupBox2.Controls.Add(this.lbnforma);
            this.groupBox2.Location = new System.Drawing.Point(471, 495);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 202);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilet Forma Stok Bilgisi";
            // 
            // lbnkalanbilet
            // 
            this.lbnkalanbilet.AutoSize = true;
            this.lbnkalanbilet.Location = new System.Drawing.Point(117, 79);
            this.lbnkalanbilet.Name = "lbnkalanbilet";
            this.lbnkalanbilet.Size = new System.Drawing.Size(54, 20);
            this.lbnkalanbilet.TabIndex = 5;
            this.lbnkalanbilet.Text = "20000";
            // 
            // lbnkalanforma
            // 
            this.lbnkalanforma.AutoSize = true;
            this.lbnkalanforma.Location = new System.Drawing.Point(117, 45);
            this.lbnkalanforma.Name = "lbnkalanforma";
            this.lbnkalanforma.Size = new System.Drawing.Size(54, 20);
            this.lbnkalanforma.TabIndex = 4;
            this.lbnkalanforma.Text = "10000";
            // 
            // lbnbilet
            // 
            this.lbnbilet.AutoSize = true;
            this.lbnbilet.Location = new System.Drawing.Point(27, 79);
            this.lbnbilet.Name = "lbnbilet";
            this.lbnbilet.Size = new System.Drawing.Size(84, 20);
            this.lbnbilet.TabIndex = 3;
            this.lbnbilet.Text = "Bilet Adet:";
            // 
            // lbnforma
            // 
            this.lbnforma.AutoSize = true;
            this.lbnforma.Location = new System.Drawing.Point(13, 45);
            this.lbnforma.Name = "lbnforma";
            this.lbnforma.Size = new System.Drawing.Size(98, 20);
            this.lbnforma.TabIndex = 0;
            this.lbnforma.Text = "Forma Adet:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.comboBox1.Location = new System.Drawing.Point(627, 228);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 28);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Text = "S";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(523, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Beden:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.lbnsatılanbiletsayısı);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lbnsatılanformasayısı);
            this.groupBox3.Controls.Add(this.lbnkasa);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(855, 495);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 202);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kasa";
            // 
            // lbnsatılanbiletsayısı
            // 
            this.lbnsatılanbiletsayısı.AutoSize = true;
            this.lbnsatılanbiletsayısı.Location = new System.Drawing.Point(138, 117);
            this.lbnsatılanbiletsayısı.Name = "lbnsatılanbiletsayısı";
            this.lbnsatılanbiletsayısı.Size = new System.Drawing.Size(18, 20);
            this.lbnsatılanbiletsayısı.TabIndex = 18;
            this.lbnsatılanbiletsayısı.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Kaç Bilet Satıldı:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbnsatılanformasayısı
            // 
            this.lbnsatılanformasayısı.AutoSize = true;
            this.lbnsatılanformasayısı.Location = new System.Drawing.Point(152, 74);
            this.lbnsatılanformasayısı.Name = "lbnsatılanformasayısı";
            this.lbnsatılanformasayısı.Size = new System.Drawing.Size(18, 20);
            this.lbnsatılanformasayısı.TabIndex = 4;
            this.lbnsatılanformasayısı.Text = "0";
            this.lbnsatılanformasayısı.Click += new System.EventHandler(this.lbntoplamkâr_Click);
            // 
            // lbnkasa
            // 
            this.lbnkasa.AutoSize = true;
            this.lbnkasa.Location = new System.Drawing.Point(58, 35);
            this.lbnkasa.Name = "lbnkasa";
            this.lbnkasa.Size = new System.Drawing.Size(64, 20);
            this.lbnkasa.TabIndex = 3;
            this.lbnkasa.Text = "00.00 tl";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Kaç Forma Satıldı:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Kasa:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1174, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 53);
            this.button2.TabIndex = 17;
            this.button2.Text = "Satın Al";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(775, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Kategori:";
            // 
            // cmbkategori
            // 
            this.cmbkategori.FormattingEnabled = true;
            this.cmbkategori.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbkategori.Location = new System.Drawing.Point(871, 223);
            this.cmbkategori.Name = "cmbkategori";
            this.cmbkategori.Size = new System.Drawing.Size(100, 28);
            this.cmbkategori.TabIndex = 19;
            this.cmbkategori.Text = "1";
            // 
            // lblFormattr
            // 
            this.lblFormattr.AutoSize = true;
            this.lblFormattr.Location = new System.Drawing.Point(1033, 332);
            this.lblFormattr.Name = "lblFormattr";
            this.lblFormattr.Size = new System.Drawing.Size(68, 20);
            this.lblFormattr.TabIndex = 20;
            this.lblFormattr.Text = "FİYAT=";
            // 
            // comboSecim
            // 
            this.comboSecim.FormattingEnabled = true;
            this.comboSecim.Items.AddRange(new object[] {
            "Sadece Forma",
            "Sadece Bilet",
            "Her Ikisi"});
            this.comboSecim.Location = new System.Drawing.Point(1174, 228);
            this.comboSecim.Name = "comboSecim";
            this.comboSecim.Size = new System.Drawing.Size(130, 28);
            this.comboSecim.TabIndex = 21;
            this.comboSecim.Text = "Her Ikisi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1107, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1033, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Alisveris Türü:\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1316, 709);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboSecim);
            this.Controls.Add(this.lblFormattr);
            this.Controls.Add(this.cmbkategori);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtBilet);
            this.Controls.Add(this.TxtForma);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Sakarya Spor Forma Bilet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtForma;
        private System.Windows.Forms.TextBox TxtBilet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbnbilet;
        private System.Windows.Forms.Label lbnforma;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbnkasa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbnkalanbilet;
        private System.Windows.Forms.Label lbnkalanforma;
        private System.Windows.Forms.Label lbnsatılanformasayısı;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbnsatılanbiletsayısı;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbkategori;
        private System.Windows.Forms.Label lblFormattr;
        private System.Windows.Forms.ComboBox comboSecim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
    }
}

