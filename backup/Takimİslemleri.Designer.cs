namespace VTProje
{
    partial class Takimİslemleri
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
            this.btn_takimyazdir = new System.Windows.Forms.Button();
            this.lbl_takimid = new System.Windows.Forms.Label();
            this.txt_takimid = new System.Windows.Forms.TextBox();
            this.lbl_takimad = new System.Windows.Forms.Label();
            this.txt_takimad = new System.Windows.Forms.TextBox();
            this.lbl_stadyumlar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_ligler = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn_takimekle = new System.Windows.Forms.Button();
            this.btntakimsil = new System.Windows.Forms.Button();
            this.btn_takimguncelle = new System.Windows.Forms.Button();
            this.btn_takimara = new System.Windows.Forms.Button();
            this.btn_menuyegel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(641, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_takimyazdir
            // 
            this.btn_takimyazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_takimyazdir.Location = new System.Drawing.Point(1055, 302);
            this.btn_takimyazdir.Name = "btn_takimyazdir";
            this.btn_takimyazdir.Size = new System.Drawing.Size(109, 67);
            this.btn_takimyazdir.TabIndex = 7;
            this.btn_takimyazdir.Text = "YAZDIR";
            this.btn_takimyazdir.UseVisualStyleBackColor = true;
            this.btn_takimyazdir.Click += new System.EventHandler(this.btn_takimyazdir_Click);
            // 
            // lbl_takimid
            // 
            this.lbl_takimid.AutoSize = true;
            this.lbl_takimid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_takimid.Location = new System.Drawing.Point(678, 56);
            this.lbl_takimid.Name = "lbl_takimid";
            this.lbl_takimid.Size = new System.Drawing.Size(105, 25);
            this.lbl_takimid.TabIndex = 0;
            this.lbl_takimid.Text = "Takım İD:";
            // 
            // txt_takimid
            // 
            this.txt_takimid.Location = new System.Drawing.Point(841, 56);
            this.txt_takimid.Name = "txt_takimid";
            this.txt_takimid.Size = new System.Drawing.Size(100, 22);
            this.txt_takimid.TabIndex = 0;
            // 
            // lbl_takimad
            // 
            this.lbl_takimad.AutoSize = true;
            this.lbl_takimad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_takimad.Location = new System.Drawing.Point(678, 94);
            this.lbl_takimad.Name = "lbl_takimad";
            this.lbl_takimad.Size = new System.Drawing.Size(111, 25);
            this.lbl_takimad.TabIndex = 0;
            this.lbl_takimad.Text = "Takım Ad:";
            // 
            // txt_takimad
            // 
            this.txt_takimad.Location = new System.Drawing.Point(841, 94);
            this.txt_takimad.Name = "txt_takimad";
            this.txt_takimad.Size = new System.Drawing.Size(100, 22);
            this.txt_takimad.TabIndex = 1;
            // 
            // lbl_stadyumlar
            // 
            this.lbl_stadyumlar.AutoSize = true;
            this.lbl_stadyumlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_stadyumlar.Location = new System.Drawing.Point(678, 143);
            this.lbl_stadyumlar.Name = "lbl_stadyumlar";
            this.lbl_stadyumlar.Size = new System.Drawing.Size(128, 25);
            this.lbl_stadyumlar.TabIndex = 0;
            this.lbl_stadyumlar.Text = "Stadyumlar:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(841, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // lbl_ligler
            // 
            this.lbl_ligler.AutoSize = true;
            this.lbl_ligler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ligler.Location = new System.Drawing.Point(678, 201);
            this.lbl_ligler.Name = "lbl_ligler";
            this.lbl_ligler.Size = new System.Drawing.Size(72, 25);
            this.lbl_ligler.TabIndex = 0;
            this.lbl_ligler.Text = "Ligler:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(841, 204);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // btn_takimekle
            // 
            this.btn_takimekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_takimekle.Location = new System.Drawing.Point(674, 302);
            this.btn_takimekle.Name = "btn_takimekle";
            this.btn_takimekle.Size = new System.Drawing.Size(109, 67);
            this.btn_takimekle.TabIndex = 4;
            this.btn_takimekle.Text = "EKLE";
            this.btn_takimekle.UseVisualStyleBackColor = true;
            this.btn_takimekle.Click += new System.EventHandler(this.btn_takimekle_Click);
            // 
            // btntakimsil
            // 
            this.btntakimsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntakimsil.Location = new System.Drawing.Point(792, 302);
            this.btntakimsil.Name = "btntakimsil";
            this.btntakimsil.Size = new System.Drawing.Size(109, 67);
            this.btntakimsil.TabIndex = 5;
            this.btntakimsil.Text = "SİL";
            this.btntakimsil.UseVisualStyleBackColor = true;
            this.btntakimsil.Click += new System.EventHandler(this.btntakimsil_Click);
            // 
            // btn_takimguncelle
            // 
            this.btn_takimguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_takimguncelle.Location = new System.Drawing.Point(916, 302);
            this.btn_takimguncelle.Name = "btn_takimguncelle";
            this.btn_takimguncelle.Size = new System.Drawing.Size(124, 67);
            this.btn_takimguncelle.TabIndex = 6;
            this.btn_takimguncelle.Text = "GÜNCELLE";
            this.btn_takimguncelle.UseVisualStyleBackColor = true;
            this.btn_takimguncelle.Click += new System.EventHandler(this.btn_takimguncelle_Click);
            // 
            // btn_takimara
            // 
            this.btn_takimara.Location = new System.Drawing.Point(885, 260);
            this.btn_takimara.Name = "btn_takimara";
            this.btn_takimara.Size = new System.Drawing.Size(109, 23);
            this.btn_takimara.TabIndex = 8;
            this.btn_takimara.Text = "TAKIM ARA";
            this.btn_takimara.UseVisualStyleBackColor = true;
            this.btn_takimara.Click += new System.EventHandler(this.btn_takimara_Click);
            // 
            // btn_menuyegel
            // 
            this.btn_menuyegel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_menuyegel.Location = new System.Drawing.Point(12, 1);
            this.btn_menuyegel.Name = "btn_menuyegel";
            this.btn_menuyegel.Size = new System.Drawing.Size(75, 39);
            this.btn_menuyegel.TabIndex = 9;
            this.btn_menuyegel.Text = "geri";
            this.btn_menuyegel.UseVisualStyleBackColor = false;
            this.btn_menuyegel.Click += new System.EventHandler(this.btn_menuyegel_Click);
            // 
            // Takimİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1174, 412);
            this.Controls.Add(this.btn_menuyegel);
            this.Controls.Add(this.btn_takimara);
            this.Controls.Add(this.btn_takimguncelle);
            this.Controls.Add(this.btntakimsil);
            this.Controls.Add(this.btn_takimekle);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_takimad);
            this.Controls.Add(this.txt_takimid);
            this.Controls.Add(this.lbl_ligler);
            this.Controls.Add(this.lbl_stadyumlar);
            this.Controls.Add(this.lbl_takimad);
            this.Controls.Add(this.lbl_takimid);
            this.Controls.Add(this.btn_takimyazdir);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Takimİslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Takimİslemleri";
            this.Load += new System.EventHandler(this.Takimİslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_takimyazdir;
        private System.Windows.Forms.Label lbl_takimid;
        private System.Windows.Forms.TextBox txt_takimid;
        private System.Windows.Forms.Label lbl_takimad;
        private System.Windows.Forms.TextBox txt_takimad;
        private System.Windows.Forms.Label lbl_stadyumlar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_ligler;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btn_takimekle;
        private System.Windows.Forms.Button btntakimsil;
        private System.Windows.Forms.Button btn_takimguncelle;
        private System.Windows.Forms.Button btn_takimara;
        private System.Windows.Forms.Button btn_menuyegel;
    }
}