namespace KasirToko
{
    partial class Transaksi
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
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelHargaProduk = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.labelStokProduk = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelNamaProduk = new System.Windows.Forms.Label();
            this.btnCari = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKodeProduk = new System.Windows.Forms.TextBox();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbDiskon = new System.Windows.Forms.TextBox();
            this.btnAddDiskon = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.labelTotalBayar = new System.Windows.Forms.Label();
            this.btnSimpanTransaksi = new System.Windows.Forms.Button();
            this.btnClearProduk = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(554, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(431, 312);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(899, 621);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 37);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Keluar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearProduk);
            this.groupBox1.Controls.Add(this.tbQty);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.labelHargaProduk);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.labelStokProduk);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.labelNamaProduk);
            this.groupBox1.Controls.Add(this.btnCari);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbKodeProduk);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 312);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produk";
            // 
            // tbQty
            // 
            this.tbQty.Location = new System.Drawing.Point(193, 213);
            this.tbQty.MaxLength = 50;
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(81, 26);
            this.tbQty.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Beli";
            // 
            // labelHargaProduk
            // 
            this.labelHargaProduk.AutoSize = true;
            this.labelHargaProduk.Location = new System.Drawing.Point(189, 170);
            this.labelHargaProduk.Name = "labelHargaProduk";
            this.labelHargaProduk.Size = new System.Drawing.Size(18, 20);
            this.labelHargaProduk.TabIndex = 15;
            this.labelHargaProduk.Text = "0";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(389, 256);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 37);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labelStokProduk
            // 
            this.labelStokProduk.AutoSize = true;
            this.labelStokProduk.Location = new System.Drawing.Point(189, 137);
            this.labelStokProduk.Name = "labelStokProduk";
            this.labelStokProduk.Size = new System.Drawing.Size(18, 20);
            this.labelStokProduk.TabIndex = 14;
            this.labelStokProduk.Text = "0";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(244, 256);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 37);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(100, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 37);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Stok";
            // 
            // labelNamaProduk
            // 
            this.labelNamaProduk.AutoSize = true;
            this.labelNamaProduk.Location = new System.Drawing.Point(189, 95);
            this.labelNamaProduk.Name = "labelNamaProduk";
            this.labelNamaProduk.Size = new System.Drawing.Size(131, 20);
            this.labelNamaProduk.TabIndex = 12;
            this.labelNamaProduk.Text = "Tidak ada produk";
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(421, 47);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(94, 37);
            this.btnCari.TabIndex = 11;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Harga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode";
            // 
            // tbKodeProduk
            // 
            this.tbKodeProduk.Location = new System.Drawing.Point(193, 52);
            this.tbKodeProduk.MaxLength = 50;
            this.tbKodeProduk.Name = "tbKodeProduk";
            this.tbKodeProduk.Size = new System.Drawing.Size(222, 26);
            this.tbKodeProduk.TabIndex = 0;
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Location = new System.Drawing.Point(691, 342);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(18, 20);
            this.labelSubTotal.TabIndex = 19;
            this.labelSubTotal.Text = "0";
            this.labelSubTotal.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sub Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(691, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(550, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Diskon";
            // 
            // tbDiskon
            // 
            this.tbDiskon.Location = new System.Drawing.Point(695, 376);
            this.tbDiskon.MaxLength = 50;
            this.tbDiskon.Name = "tbDiskon";
            this.tbDiskon.Size = new System.Drawing.Size(146, 26);
            this.tbDiskon.TabIndex = 18;
            // 
            // btnAddDiskon
            // 
            this.btnAddDiskon.Location = new System.Drawing.Point(858, 371);
            this.btnAddDiskon.Name = "btnAddDiskon";
            this.btnAddDiskon.Size = new System.Drawing.Size(127, 37);
            this.btnAddDiskon.TabIndex = 18;
            this.btnAddDiskon.Text = "Tambahkan";
            this.btnAddDiskon.UseVisualStyleBackColor = true;
            this.btnAddDiskon.Click += new System.EventHandler(this.btnAddDiskon_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(550, 473);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 29);
            this.label11.TabIndex = 23;
            this.label11.Text = "Total Bayar";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalBayar
            // 
            this.labelTotalBayar.AutoSize = true;
            this.labelTotalBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBayar.Location = new System.Drawing.Point(550, 515);
            this.labelTotalBayar.Name = "labelTotalBayar";
            this.labelTotalBayar.Size = new System.Drawing.Size(27, 29);
            this.labelTotalBayar.TabIndex = 24;
            this.labelTotalBayar.Text = "0";
            this.labelTotalBayar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSimpanTransaksi
            // 
            this.btnSimpanTransaksi.Location = new System.Drawing.Point(542, 589);
            this.btnSimpanTransaksi.Name = "btnSimpanTransaksi";
            this.btnSimpanTransaksi.Size = new System.Drawing.Size(351, 69);
            this.btnSimpanTransaksi.TabIndex = 25;
            this.btnSimpanTransaksi.Text = "Simpan";
            this.btnSimpanTransaksi.UseVisualStyleBackColor = true;
            this.btnSimpanTransaksi.Click += new System.EventHandler(this.btnSimpanTransaksi_Click);
            // 
            // btnClearProduk
            // 
            this.btnClearProduk.Location = new System.Drawing.Point(6, 256);
            this.btnClearProduk.Name = "btnClearProduk";
            this.btnClearProduk.Size = new System.Drawing.Size(88, 37);
            this.btnClearProduk.TabIndex = 18;
            this.btnClearProduk.Text = "Clear";
            this.btnClearProduk.UseVisualStyleBackColor = true;
            this.btnClearProduk.Click += new System.EventHandler(this.btnClearProduk_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(542, 557);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(351, 26);
            this.dateTimePicker.TabIndex = 26;
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 689);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnSimpanTransaksi);
            this.Controls.Add(this.labelTotalBayar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAddDiskon);
            this.Controls.Add(this.tbDiskon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelSubTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Name = "Transaksi";
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKodeProduk;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelNamaProduk;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelHargaProduk;
        private System.Windows.Forms.Label labelStokProduk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbDiskon;
        private System.Windows.Forms.Button btnAddDiskon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelTotalBayar;
        private System.Windows.Forms.Button btnSimpanTransaksi;
        private System.Windows.Forms.Button btnClearProduk;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}