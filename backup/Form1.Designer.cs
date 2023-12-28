namespace VTProje
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
            this.btn_Futbolcuİslem = new System.Windows.Forms.Button();
            this.btn_Takimİslem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Futbolcuİslem
            // 
            this.btn_Futbolcuİslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Futbolcuİslem.Location = new System.Drawing.Point(74, 153);
            this.btn_Futbolcuİslem.Name = "btn_Futbolcuİslem";
            this.btn_Futbolcuİslem.Size = new System.Drawing.Size(175, 116);
            this.btn_Futbolcuİslem.TabIndex = 0;
            this.btn_Futbolcuİslem.Text = "Futbolcu İşlemleri İçin Tıkla";
            this.btn_Futbolcuİslem.UseVisualStyleBackColor = true;
            this.btn_Futbolcuİslem.Click += new System.EventHandler(this.btn_Futbolcuİslem_Click);
            // 
            // btn_Takimİslem
            // 
            this.btn_Takimİslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Takimİslem.Location = new System.Drawing.Point(517, 153);
            this.btn_Takimİslem.Name = "btn_Takimİslem";
            this.btn_Takimİslem.Size = new System.Drawing.Size(175, 116);
            this.btn_Takimİslem.TabIndex = 0;
            this.btn_Takimİslem.Text = "Takım İşlemleri İçin Tıkla";
            this.btn_Takimİslem.UseVisualStyleBackColor = true;
            this.btn_Takimİslem.Click += new System.EventHandler(this.btn_Takimİslem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Takimİslem);
            this.Controls.Add(this.btn_Futbolcuİslem);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Futbolcuİslem;
        private System.Windows.Forms.Button btn_Takimİslem;
    }
}

