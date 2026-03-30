namespace NewsWebsite_and_RSS
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
            this.lBoxHaber = new System.Windows.Forms.ListBox();
            this.linkLabelHaber = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lBoxHaber
            // 
            this.lBoxHaber.FormattingEnabled = true;
            this.lBoxHaber.Location = new System.Drawing.Point(12, 31);
            this.lBoxHaber.Name = "lBoxHaber";
            this.lBoxHaber.Size = new System.Drawing.Size(776, 355);
            this.lBoxHaber.TabIndex = 0;
            this.lBoxHaber.SelectedIndexChanged += new System.EventHandler(this.lBoxHaber_SelectedIndexChanged);
            // 
            // linkLabelHaber
            // 
            this.linkLabelHaber.AutoSize = true;
            this.linkLabelHaber.Location = new System.Drawing.Point(12, 415);
            this.linkLabelHaber.Name = "linkLabelHaber";
            this.linkLabelHaber.Size = new System.Drawing.Size(0, 13);
            this.linkLabelHaber.TabIndex = 1;
            this.linkLabelHaber.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHaber_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelHaber);
            this.Controls.Add(this.lBoxHaber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxHaber;
        private System.Windows.Forms.LinkLabel linkLabelHaber;
    }
}

