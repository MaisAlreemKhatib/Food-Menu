namespace Yemek_Menusu
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
            lblKategori = new Label();
            comboBox1 = new ComboBox();
            lblAdi = new Label();
            txtAdi = new TextBox();
            lblCins = new Label();
            txtCins = new TextBox();
            lblFiyat = new Label();
            txtFiyat = new TextBox();
            lblKdv = new Label();
            txtKdv = new TextBox();
            lblKalori = new Label();
            txtKalori = new TextBox();
            btnEkle = new Button();
            btnSil = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            txtToplamFiyat = new TextBox();
            SuspendLayout();
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(81, 31);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(80, 20);
            lblKategori.TabIndex = 0;
            lblKategori.Text = "Seçenekler";
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(196, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(175, 28);
            comboBox1.TabIndex = 1;
            // 
            // lblAdi
            // 
            lblAdi.AutoSize = true;
            lblAdi.Location = new Point(81, 79);
            lblAdi.Name = "lblAdi";
            lblAdi.Size = new Size(32, 20);
            lblAdi.TabIndex = 2;
            lblAdi.Text = "Adı";
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(196, 79);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(125, 27);
            txtAdi.TabIndex = 3;
            // 
            // lblCins
            // 
            lblCins.AutoSize = true;
            lblCins.Location = new Point(81, 129);
            lblCins.Name = "lblCins";
            lblCins.Size = new Size(36, 20);
            lblCins.TabIndex = 4;
            lblCins.Text = "Cins";
            // 
            // txtCins
            // 
            txtCins.Location = new Point(196, 126);
            txtCins.Name = "txtCins";
            txtCins.Size = new Size(125, 27);
            txtCins.TabIndex = 5;
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.Location = new Point(81, 180);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(40, 20);
            lblFiyat.TabIndex = 6;
            lblFiyat.Text = "Fiyat";
            lblFiyat.Click += label1_Click;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(196, 177);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(125, 27);
            txtFiyat.TabIndex = 7;
            // 
            // lblKdv
            // 
            lblKdv.AutoSize = true;
            lblKdv.Location = new Point(84, 234);
            lblKdv.Name = "lblKdv";
            lblKdv.Size = new Size(42, 20);
            lblKdv.TabIndex = 8;
            lblKdv.Text = "KDV ";
            // 
            // txtKdv
            // 
            txtKdv.Location = new Point(196, 231);
            txtKdv.Name = "txtKdv";
            txtKdv.Size = new Size(125, 27);
            txtKdv.TabIndex = 9;
            // 
            // lblKalori
            // 
            lblKalori.AutoSize = true;
            lblKalori.Location = new Point(84, 279);
            lblKalori.Name = "lblKalori";
            lblKalori.Size = new Size(48, 20);
            lblKalori.TabIndex = 10;
            lblKalori.Text = "Kalori";
            // 
            // txtKalori
            // 
            txtKalori.Location = new Point(196, 276);
            txtKalori.Name = "txtKalori";
            txtKalori.Size = new Size(125, 27);
            txtKalori.TabIndex = 11;
            // 
            // btnEkle
            // 
            btnEkle.ForeColor = Color.Black;
            btnEkle.Location = new Point(476, 340);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 12;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.ForeColor = Color.Black;
            btnSil.Location = new Point(576, 340);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 13;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Plum;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(476, 28);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(438, 264);
            listBox1.TabIndex = 15;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(476, 310);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 16;
            label1.Text = "Toplam fiyat :";
            // 
            // txtToplamFiyat
            // 
            txtToplamFiyat.BackColor = Color.FloralWhite;
            txtToplamFiyat.Location = new Point(576, 307);
            txtToplamFiyat.Name = "txtToplamFiyat";
            txtToplamFiyat.ReadOnly = true;
            txtToplamFiyat.Size = new Size(94, 27);
            txtToplamFiyat.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(926, 450);
            Controls.Add(txtToplamFiyat);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(txtKalori);
            Controls.Add(lblKalori);
            Controls.Add(txtKdv);
            Controls.Add(lblKdv);
            Controls.Add(txtFiyat);
            Controls.Add(lblFiyat);
            Controls.Add(txtCins);
            Controls.Add(lblCins);
            Controls.Add(txtAdi);
            Controls.Add(lblAdi);
            Controls.Add(comboBox1);
            Controls.Add(lblKategori);
            ForeColor = Color.Transparent;
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKategori;
        private ComboBox comboBox1;
        private Label lblAdi;
        private TextBox txtAdi;
        private Label lblCins;
        private TextBox txtCins;
        private Label lblFiyat;
        private TextBox txtFiyat;
        private Label lblKdv;
        private TextBox txtKdv;
        private Label lblKalori;
        private TextBox txtKalori;
        private Button btnEkle;
        private Button btnSil;
        private ListBox listBox1;
        private Label label1;
        private TextBox txtToplamFiyat;
    }
}
