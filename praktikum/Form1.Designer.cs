namespace praktikum
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnubah = new System.Windows.Forms.Button();
            this.btnhps = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.txtnamabrng = new System.Windows.Forms.TextBox();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.txtbarang = new System.Windows.Forms.TextBox();
            this.txtsatuan = new System.Windows.Forms.TextBox();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.btnbersih = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbatas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(344, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 290);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnubah
            // 
            this.btnubah.Location = new System.Drawing.Point(636, 360);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(109, 32);
            this.btnubah.TabIndex = 1;
            this.btnubah.Text = "Ubah";
            this.btnubah.UseVisualStyleBackColor = true;
            this.btnubah.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnhps
            // 
            this.btnhps.Location = new System.Drawing.Point(760, 360);
            this.btnhps.Name = "btnhps";
            this.btnhps.Size = new System.Drawing.Size(110, 32);
            this.btnhps.TabIndex = 2;
            this.btnhps.Text = "Hapus";
            this.btnhps.UseVisualStyleBackColor = true;
            this.btnhps.Click += new System.EventHandler(this.btnhps_Click);
            // 
            // btnsimpan
            // 
            this.btnsimpan.Location = new System.Drawing.Point(365, 362);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(117, 32);
            this.btnsimpan.TabIndex = 3;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = true;
            this.btnsimpan.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtnamabrng
            // 
            this.txtnamabrng.Location = new System.Drawing.Point(44, 128);
            this.txtnamabrng.Multiline = true;
            this.txtnamabrng.Name = "txtnamabrng";
            this.txtnamabrng.Size = new System.Drawing.Size(217, 25);
            this.txtnamabrng.TabIndex = 4;
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(44, 173);
            this.txtstok.Multiline = true;
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(217, 25);
            this.txtstok.TabIndex = 5;
            this.txtstok.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtbarang
            // 
            this.txtbarang.Location = new System.Drawing.Point(44, 64);
            this.txtbarang.Multiline = true;
            this.txtbarang.Name = "txtbarang";
            this.txtbarang.Size = new System.Drawing.Size(217, 25);
            this.txtbarang.TabIndex = 10;
            // 
            // txtsatuan
            // 
            this.txtsatuan.Location = new System.Drawing.Point(44, 225);
            this.txtsatuan.Multiline = true;
            this.txtsatuan.Name = "txtsatuan";
            this.txtsatuan.Size = new System.Drawing.Size(217, 25);
            this.txtsatuan.TabIndex = 11;
            // 
            // txtharga
            // 
            this.txtharga.Location = new System.Drawing.Point(44, 269);
            this.txtharga.Multiline = true;
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(217, 25);
            this.txtharga.TabIndex = 12;
            // 
            // btnbersih
            // 
            this.btnbersih.Location = new System.Drawing.Point(497, 360);
            this.btnbersih.Name = "btnbersih";
            this.btnbersih.Size = new System.Drawing.Size(120, 34);
            this.btnbersih.TabIndex = 14;
            this.btnbersih.Text = "Bersihkan";
            this.btnbersih.UseVisualStyleBackColor = true;
            this.btnbersih.Click += new System.EventHandler(this.btnbersih_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Kode Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Stok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Satuan";
            // 
            // txtbatas
            // 
            this.txtbatas.Location = new System.Drawing.Point(44, 314);
            this.txtbatas.Multiline = true;
            this.txtbatas.Name = "txtbatas";
            this.txtbatas.Size = new System.Drawing.Size(217, 25);
            this.txtbatas.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Harga Satuan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Batas min";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Vitamin",
            "Obat",
            "Herbal Sehat"});
            this.comboBox1.Location = new System.Drawing.Point(44, 360);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Kategori";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 422);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbatas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbersih);
            this.Controls.Add(this.txtharga);
            this.Controls.Add(this.txtsatuan);
            this.Controls.Add(this.txtbarang);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.txtnamabrng);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.btnhps);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btnhps;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.TextBox txtnamabrng;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.TextBox txtbarang;
        private System.Windows.Forms.TextBox txtsatuan;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.Button btnbersih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbatas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
    }
}

