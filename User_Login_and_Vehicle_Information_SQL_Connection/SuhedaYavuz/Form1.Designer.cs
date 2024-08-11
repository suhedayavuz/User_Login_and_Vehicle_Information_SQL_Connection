namespace SuhedaYavuz
{
    partial class Form1
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
            txtParola = new TextBox();
            txtKullaniciAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnGiriş = new Button();
            SuspendLayout();
            // 
            // txtParola
            // 
            txtParola.Location = new Point(242, 141);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(125, 27);
            txtParola.TabIndex = 9;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(242, 55);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(125, 27);
            txtKullaniciAdi.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 129);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 7;
            label2.Text = "Parola";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 58);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 6;
            label1.Text = "Kullanıcı Adı";
            // 
            // btnGiriş
            // 
            btnGiriş.Location = new Point(162, 282);
            btnGiriş.Name = "btnGiriş";
            btnGiriş.Size = new Size(122, 45);
            btnGiriş.TabIndex = 5;
            btnGiriş.Text = "Giriş";
            btnGiriş.UseVisualStyleBackColor = true;
            btnGiriş.Click += btnGiriş_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 375);
            Controls.Add(txtParola);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGiriş);
            Name = "Form1";
            Text = "Giriş Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtParola;
        private TextBox txtKullaniciAdi;
        private Label label2;
        private Label label1;
        private Button btnGiriş;
    }
}