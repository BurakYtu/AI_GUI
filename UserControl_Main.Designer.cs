namespace Leila_GUI
{
    partial class UserControl_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Main));
            this.btn_test = new System.Windows.Forms.Button();
            this.btn_train = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_test
            // 
            this.btn_test.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_test.BackgroundImage")));
            this.btn_test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_test.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_test.FlatAppearance.BorderSize = 0;
            this.btn_test.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btn_test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_test.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_test.Location = new System.Drawing.Point(400, 180);
            this.btn_test.Margin = new System.Windows.Forms.Padding(0);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(280, 90);
            this.btn_test.TabIndex = 0;
            this.btn_test.Text = "Test";
            this.btn_test.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // btn_train
            // 
            this.btn_train.BackColor = System.Drawing.Color.White;
            this.btn_train.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_train.BackgroundImage")));
            this.btn_train.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_train.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_train.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_train.FlatAppearance.BorderSize = 0;
            this.btn_train.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_train.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_train.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_train.Location = new System.Drawing.Point(120, 180);
            this.btn_train.Margin = new System.Windows.Forms.Padding(0);
            this.btn_train.Name = "btn_train";
            this.btn_train.Size = new System.Drawing.Size(280, 90);
            this.btn_train.TabIndex = 0;
            this.btn_train.Text = "Train";
            this.btn_train.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_train.UseVisualStyleBackColor = false;
            this.btn_train.Click += new System.EventHandler(this.btn_train_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btn_train, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_test, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // UserControl_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "UserControl_Main";
            this.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Button btn_train;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
