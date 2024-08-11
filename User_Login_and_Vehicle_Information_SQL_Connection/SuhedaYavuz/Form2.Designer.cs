namespace SuhedaYavuz
{
    partial class Form2
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
            dataGridView1 = new DataGridView();
            btnKaydet = new Button();
            btnGoruntule = new Button();
            txtaracsatisdurumu = new TextBox();
            txtaracmaliyettutari = new TextBox();
            txtaracuretimbitistarihi = new TextBox();
            txtaracuretimbaslangictarihi = new TextBox();
            txtaracmodeli = new TextBox();
            txtaracmarkasi = new TextBox();
            txtaracturu = new TextBox();
            btnDüzenle = new Button();
            txtaracid = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSil = new Button();
            label8 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(407, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1062, 330);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(186, 407);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(108, 39);
            btnKaydet.TabIndex = 17;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGoruntule
            // 
            btnGoruntule.Location = new Point(61, 407);
            btnGoruntule.Name = "btnGoruntule";
            btnGoruntule.Size = new Size(100, 39);
            btnGoruntule.TabIndex = 16;
            btnGoruntule.Text = "Görüntüle";
            btnGoruntule.UseVisualStyleBackColor = true;
            btnGoruntule.Click += btnGoruntule_Click;
            // 
            // txtaracsatisdurumu
            // 
            txtaracsatisdurumu.Location = new Point(232, 329);
            txtaracsatisdurumu.Name = "txtaracsatisdurumu";
            txtaracsatisdurumu.Size = new Size(125, 27);
            txtaracsatisdurumu.TabIndex = 15;
            // 
            // txtaracmaliyettutari
            // 
            txtaracmaliyettutari.Location = new Point(232, 287);
            txtaracmaliyettutari.Name = "txtaracmaliyettutari";
            txtaracmaliyettutari.Size = new Size(125, 27);
            txtaracmaliyettutari.TabIndex = 14;
            // 
            // txtaracuretimbitistarihi
            // 
            txtaracuretimbitistarihi.Location = new Point(232, 246);
            txtaracuretimbitistarihi.Name = "txtaracuretimbitistarihi";
            txtaracuretimbitistarihi.Size = new Size(125, 27);
            txtaracuretimbitistarihi.TabIndex = 13;
            // 
            // txtaracuretimbaslangictarihi
            // 
            txtaracuretimbaslangictarihi.Location = new Point(232, 204);
            txtaracuretimbaslangictarihi.Name = "txtaracuretimbaslangictarihi";
            txtaracuretimbaslangictarihi.Size = new Size(125, 27);
            txtaracuretimbaslangictarihi.TabIndex = 12;
            // 
            // txtaracmodeli
            // 
            txtaracmodeli.Location = new Point(232, 160);
            txtaracmodeli.Name = "txtaracmodeli";
            txtaracmodeli.Size = new Size(125, 27);
            txtaracmodeli.TabIndex = 11;
            // 
            // txtaracmarkasi
            // 
            txtaracmarkasi.Location = new Point(232, 117);
            txtaracmarkasi.Name = "txtaracmarkasi";
            txtaracmarkasi.Size = new Size(125, 27);
            txtaracmarkasi.TabIndex = 10;
            // 
            // txtaracturu
            // 
            txtaracturu.Location = new Point(232, 73);
            txtaracturu.Name = "txtaracturu";
            txtaracturu.Size = new Size(125, 27);
            txtaracturu.TabIndex = 9;
            // 
            // btnDüzenle
            // 
            btnDüzenle.Location = new Point(942, 419);
            btnDüzenle.Name = "btnDüzenle";
            btnDüzenle.Size = new Size(93, 39);
            btnDüzenle.TabIndex = 11;
            btnDüzenle.Text = "Düzenle";
            btnDüzenle.UseVisualStyleBackColor = true;
            btnDüzenle.Click += btnDüzenle_Click;
            // 
            // txtaracid
            // 
            txtaracid.Location = new Point(232, 33);
            txtaracid.Name = "txtaracid";
            txtaracid.Size = new Size(125, 27);
            txtaracid.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 290);
            label7.Name = "label7";
            label7.Size = new Size(134, 20);
            label7.TabIndex = 6;
            label7.Text = "Araç Maliyet Tutarı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 249);
            label6.Name = "label6";
            label6.Size = new Size(159, 20);
            label6.TabIndex = 5;
            label6.Text = "Araç Üretim Bitiş Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 207);
            label5.Name = "label5";
            label5.Size = new Size(194, 20);
            label5.TabIndex = 4;
            label5.Text = "Araç Üretim Başlangıç Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 163);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 3;
            label4.Text = "Araç Modeli";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 120);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 2;
            label3.Text = "Araç Markası";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 76);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Araç Türü";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Araç ID";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(753, 419);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(88, 39);
            btnSil.TabIndex = 10;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 332);
            label8.Name = "label8";
            label8.Size = new Size(131, 20);
            label8.TabIndex = 7;
            label8.Text = "Araç Satış Durumu";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(btnGoruntule);
            groupBox1.Controls.Add(txtaracsatisdurumu);
            groupBox1.Controls.Add(txtaracmaliyettutari);
            groupBox1.Controls.Add(txtaracuretimbitistarihi);
            groupBox1.Controls.Add(txtaracuretimbaslangictarihi);
            groupBox1.Controls.Add(txtaracmodeli);
            groupBox1.Controls.Add(txtaracmarkasi);
            groupBox1.Controls.Add(txtaracturu);
            groupBox1.Controls.Add(txtaracid);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 464);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Araç Bilgileri";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1523, 493);
            Controls.Add(dataGridView1);
            Controls.Add(btnDüzenle);
            Controls.Add(btnSil);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Araç Bilgi Ekranı";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnKaydet;
        private Button btnGoruntule;
        private TextBox txtaracsatisdurumu;
        private TextBox txtaracmaliyettutari;
        private TextBox txtaracuretimbitistarihi;
        private TextBox txtaracuretimbaslangictarihi;
        private TextBox txtaracmodeli;
        private TextBox txtaracmarkasi;
        private TextBox txtaracturu;
        private Button btnDüzenle;
        private TextBox txtaracid;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSil;
        private Label label8;
        private GroupBox groupBox1;
    }
}