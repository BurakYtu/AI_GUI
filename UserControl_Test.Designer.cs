namespace Leila_GUI
{
    partial class UserControl_Test
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_begin = new System.Windows.Forms.Button();
            this.richTextBox_udprecieve = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_begin
            // 
            this.btn_begin.Location = new System.Drawing.Point(89, 74);
            this.btn_begin.Name = "btn_begin";
            this.btn_begin.Size = new System.Drawing.Size(75, 23);
            this.btn_begin.TabIndex = 0;
            this.btn_begin.Text = "begin";
            this.btn_begin.UseVisualStyleBackColor = true;
            this.btn_begin.Click += new System.EventHandler(this.btn_begin_Click);
            // 
            // richTextBox_udprecieve
            // 
            this.richTextBox_udprecieve.Location = new System.Drawing.Point(263, 74);
            this.richTextBox_udprecieve.Name = "richTextBox_udprecieve";
            this.richTextBox_udprecieve.Size = new System.Drawing.Size(337, 271);
            this.richTextBox_udprecieve.TabIndex = 1;
            this.richTextBox_udprecieve.Text = "";
            // 
            // UserControl_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox_udprecieve);
            this.Controls.Add(this.btn_begin);
            this.Name = "UserControl_Test";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_begin;
        private System.Windows.Forms.RichTextBox richTextBox_udprecieve;
    }
}
