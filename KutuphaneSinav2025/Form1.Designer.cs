namespace KutuphaneSinav2025
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtKitapAdi = new TextBox();
            txtYazar = new TextBox();
            txtYayinevi = new TextBox();
            txtSayfaSayisi = new TextBox();
            btnEkle = new Button();
            dgvKitaplar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, 39);
            label1.Name = "label1";
            label1.Size = new Size(484, 41);
            label1.TabIndex = 0;
            label1.Text = "KÜTÜPHANE SINAV 2025";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 120);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Kitap adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 163);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 1;
            label3.Text = "Kitap yazarı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 209);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 1;
            label4.Text = "Yayınevi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 254);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 1;
            label5.Text = "Sayfa sayısı:";
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(181, 123);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(125, 27);
            txtKitapAdi.TabIndex = 2;
            // 
            // txtYazar
            // 
            txtYazar.Location = new Point(181, 163);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(125, 27);
            txtYazar.TabIndex = 2;
            // 
            // txtYayinevi
            // 
            txtYayinevi.Location = new Point(181, 202);
            txtYayinevi.Name = "txtYayinevi";
            txtYayinevi.Size = new Size(125, 27);
            txtYayinevi.TabIndex = 2;
            // 
            // txtSayfaSayisi
            // 
            txtSayfaSayisi.Location = new Point(181, 247);
            txtSayfaSayisi.Name = "txtSayfaSayisi";
            txtSayfaSayisi.Size = new Size(125, 27);
            txtSayfaSayisi.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(171, 300);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(145, 29);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Kütüphaneye Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvKitaplar
            // 
            dgvKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitaplar.Location = new Point(437, 120);
            dgvKitaplar.Name = "dgvKitaplar";
            dgvKitaplar.RowHeadersWidth = 51;
            dgvKitaplar.Size = new Size(300, 188);
            dgvKitaplar.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvKitaplar);
            Controls.Add(btnEkle);
            Controls.Add(txtSayfaSayisi);
            Controls.Add(txtYayinevi);
            Controls.Add(txtYazar);
            Controls.Add(txtKitapAdi);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtKitapAdi;
        private TextBox txtYazar;
        private TextBox txtYayinevi;
        private TextBox txtSayfaSayisi;
        private Button btnEkle;
        private DataGridView dgvKitaplar;
    }
}
