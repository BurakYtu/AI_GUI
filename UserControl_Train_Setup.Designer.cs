namespace Leila_GUI
{
    partial class UserControl_Train_Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Train_Setup));
            this.btn_add_relax = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_mission = new System.Windows.Forms.RichTextBox();
            this.btn_sub_relax = new System.Windows.Forms.Button();
            this.btn_relax = new System.Windows.Forms.Button();
            this.btn_add_right = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_sub_right = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add_left = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_sub_left = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add_not = new System.Windows.Forms.Button();
            this.btn_not = new System.Windows.Forms.Button();
            this.btn_sub_not = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_deletelast = new System.Windows.Forms.Button();
            this.btn_delete_all = new System.Windows.Forms.Button();
            this.rb_airplane = new System.Windows.Forms.RadioButton();
            this.rb_horizon = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_add_relax
            // 
            this.btn_add_relax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add_relax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add_relax.BackgroundImage")));
            this.btn_add_relax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_add_relax.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_add_relax.FlatAppearance.BorderSize = 0;
            this.btn_add_relax.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_add_relax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_add_relax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_add_relax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_relax.Location = new System.Drawing.Point(130, 100);
            this.btn_add_relax.Margin = new System.Windows.Forms.Padding(0);
            this.btn_add_relax.Name = "btn_add_relax";
            this.btn_add_relax.Size = new System.Drawing.Size(50, 50);
            this.btn_add_relax.TabIndex = 0;
            this.btn_add_relax.UseVisualStyleBackColor = true;
            this.btn_add_relax.Click += new System.EventHandler(this.btn_add_relax_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Relaxed";
            // 
            // richTextBox_mission
            // 
            this.richTextBox_mission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox_mission.Location = new System.Drawing.Point(411, 78);
            this.richTextBox_mission.Name = "richTextBox_mission";
            this.richTextBox_mission.ReadOnly = true;
            this.richTextBox_mission.Size = new System.Drawing.Size(188, 253);
            this.richTextBox_mission.TabIndex = 2;
            this.richTextBox_mission.Text = "";
            // 
            // btn_sub_relax
            // 
            this.btn_sub_relax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sub_relax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sub_relax.BackgroundImage")));
            this.btn_sub_relax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sub_relax.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_sub_relax.FlatAppearance.BorderSize = 0;
            this.btn_sub_relax.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_sub_relax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_sub_relax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_sub_relax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sub_relax.Location = new System.Drawing.Point(196, 100);
            this.btn_sub_relax.Margin = new System.Windows.Forms.Padding(0);
            this.btn_sub_relax.Name = "btn_sub_relax";
            this.btn_sub_relax.Size = new System.Drawing.Size(50, 50);
            this.btn_sub_relax.TabIndex = 0;
            this.btn_sub_relax.UseVisualStyleBackColor = true;
            this.btn_sub_relax.Click += new System.EventHandler(this.btn_sub_relax_Click);
            // 
            // btn_relax
            // 
            this.btn_relax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_relax.FlatAppearance.BorderSize = 0;
            this.btn_relax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_relax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_relax.Location = new System.Drawing.Point(130, 160);
            this.btn_relax.Margin = new System.Windows.Forms.Padding(0);
            this.btn_relax.Name = "btn_relax";
            this.btn_relax.Size = new System.Drawing.Size(116, 38);
            this.btn_relax.TabIndex = 0;
            this.btn_relax.Text = "add 0 second";
            this.btn_relax.UseVisualStyleBackColor = true;
            this.btn_relax.Click += new System.EventHandler(this.btn_relax_Click);
            // 
            // btn_add_right
            // 
            this.btn_add_right.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add_right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add_right.BackgroundImage")));
            this.btn_add_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_add_right.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_add_right.FlatAppearance.BorderSize = 0;
            this.btn_add_right.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_add_right.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_add_right.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_add_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_right.Location = new System.Drawing.Point(270, 100);
            this.btn_add_right.Margin = new System.Windows.Forms.Padding(0);
            this.btn_add_right.Name = "btn_add_right";
            this.btn_add_right.Size = new System.Drawing.Size(50, 50);
            this.btn_add_right.TabIndex = 0;
            this.btn_add_right.UseVisualStyleBackColor = true;
            this.btn_add_right.Click += new System.EventHandler(this.btn_add_right_Click);
            // 
            // btn_right
            // 
            this.btn_right.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_right.FlatAppearance.BorderSize = 0;
            this.btn_right.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_right.Location = new System.Drawing.Point(270, 160);
            this.btn_right.Margin = new System.Windows.Forms.Padding(0);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(116, 38);
            this.btn_right.TabIndex = 0;
            this.btn_right.Text = "add 0 second";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_sub_right
            // 
            this.btn_sub_right.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sub_right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sub_right.BackgroundImage")));
            this.btn_sub_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sub_right.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_sub_right.FlatAppearance.BorderSize = 0;
            this.btn_sub_right.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_sub_right.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_sub_right.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_sub_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sub_right.Location = new System.Drawing.Point(336, 100);
            this.btn_sub_right.Margin = new System.Windows.Forms.Padding(0);
            this.btn_sub_right.Name = "btn_sub_right";
            this.btn_sub_right.Size = new System.Drawing.Size(50, 50);
            this.btn_sub_right.TabIndex = 0;
            this.btn_sub_right.UseVisualStyleBackColor = true;
            this.btn_sub_right.Click += new System.EventHandler(this.btn_sub_right_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Right";
            // 
            // btn_add_left
            // 
            this.btn_add_left.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add_left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add_left.BackgroundImage")));
            this.btn_add_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_add_left.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_add_left.FlatAppearance.BorderSize = 0;
            this.btn_add_left.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_add_left.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_add_left.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_add_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_left.Location = new System.Drawing.Point(130, 233);
            this.btn_add_left.Margin = new System.Windows.Forms.Padding(0);
            this.btn_add_left.Name = "btn_add_left";
            this.btn_add_left.Size = new System.Drawing.Size(50, 50);
            this.btn_add_left.TabIndex = 0;
            this.btn_add_left.UseVisualStyleBackColor = true;
            this.btn_add_left.Click += new System.EventHandler(this.btn_add_left_Click);
            // 
            // btn_left
            // 
            this.btn_left.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_left.FlatAppearance.BorderSize = 0;
            this.btn_left.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_left.Location = new System.Drawing.Point(130, 293);
            this.btn_left.Margin = new System.Windows.Forms.Padding(0);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(116, 38);
            this.btn_left.TabIndex = 0;
            this.btn_left.Text = "add 0 second";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_sub_left
            // 
            this.btn_sub_left.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sub_left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sub_left.BackgroundImage")));
            this.btn_sub_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sub_left.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_sub_left.FlatAppearance.BorderSize = 0;
            this.btn_sub_left.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_sub_left.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_sub_left.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_sub_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sub_left.Location = new System.Drawing.Point(196, 233);
            this.btn_sub_left.Margin = new System.Windows.Forms.Padding(0);
            this.btn_sub_left.Name = "btn_sub_left";
            this.btn_sub_left.Size = new System.Drawing.Size(50, 50);
            this.btn_sub_left.TabIndex = 0;
            this.btn_sub_left.UseVisualStyleBackColor = true;
            this.btn_sub_left.Click += new System.EventHandler(this.btn_sub_left_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Left";
            // 
            // btn_add_not
            // 
            this.btn_add_not.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add_not.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add_not.BackgroundImage")));
            this.btn_add_not.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_add_not.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_add_not.FlatAppearance.BorderSize = 0;
            this.btn_add_not.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_add_not.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_add_not.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_add_not.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_not.Location = new System.Drawing.Point(270, 233);
            this.btn_add_not.Margin = new System.Windows.Forms.Padding(0);
            this.btn_add_not.Name = "btn_add_not";
            this.btn_add_not.Size = new System.Drawing.Size(50, 50);
            this.btn_add_not.TabIndex = 0;
            this.btn_add_not.UseVisualStyleBackColor = true;
            this.btn_add_not.Click += new System.EventHandler(this.btn_add_not_Click);
            // 
            // btn_not
            // 
            this.btn_not.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_not.FlatAppearance.BorderSize = 0;
            this.btn_not.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_not.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_not.Location = new System.Drawing.Point(270, 293);
            this.btn_not.Margin = new System.Windows.Forms.Padding(0);
            this.btn_not.Name = "btn_not";
            this.btn_not.Size = new System.Drawing.Size(116, 38);
            this.btn_not.TabIndex = 0;
            this.btn_not.Text = "add 0 second";
            this.btn_not.UseVisualStyleBackColor = true;
            this.btn_not.Click += new System.EventHandler(this.btn_not_Click);
            // 
            // btn_sub_not
            // 
            this.btn_sub_not.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sub_not.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sub_not.BackgroundImage")));
            this.btn_sub_not.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sub_not.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_sub_not.FlatAppearance.BorderSize = 0;
            this.btn_sub_not.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_sub_not.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_sub_not.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_sub_not.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sub_not.Location = new System.Drawing.Point(336, 233);
            this.btn_sub_not.Margin = new System.Windows.Forms.Padding(0);
            this.btn_sub_not.Name = "btn_sub_not";
            this.btn_sub_not.Size = new System.Drawing.Size(50, 50);
            this.btn_sub_not.TabIndex = 0;
            this.btn_sub_not.UseVisualStyleBackColor = true;
            this.btn_sub_not.Click += new System.EventHandler(this.btn_sub_not_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nothing";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(130, 348);
            this.btn_save.Margin = new System.Windows.Forms.Padding(0);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(56, 38);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_start
            // 
            this.btn_start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Location = new System.Drawing.Point(411, 348);
            this.btn_start.Margin = new System.Windows.Forms.Padding(0);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(188, 38);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_deletelast
            // 
            this.btn_deletelast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_deletelast.FlatAppearance.BorderSize = 0;
            this.btn_deletelast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_deletelast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletelast.Location = new System.Drawing.Point(286, 348);
            this.btn_deletelast.Margin = new System.Windows.Forms.Padding(0);
            this.btn_deletelast.Name = "btn_deletelast";
            this.btn_deletelast.Size = new System.Drawing.Size(100, 38);
            this.btn_deletelast.TabIndex = 0;
            this.btn_deletelast.Text = "Delete Last";
            this.btn_deletelast.UseVisualStyleBackColor = true;
            this.btn_deletelast.Click += new System.EventHandler(this.btn_deletelast_Click);
            // 
            // btn_delete_all
            // 
            this.btn_delete_all.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete_all.FlatAppearance.BorderSize = 0;
            this.btn_delete_all.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_delete_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_all.Location = new System.Drawing.Point(186, 348);
            this.btn_delete_all.Margin = new System.Windows.Forms.Padding(0);
            this.btn_delete_all.Name = "btn_delete_all";
            this.btn_delete_all.Size = new System.Drawing.Size(100, 38);
            this.btn_delete_all.TabIndex = 0;
            this.btn_delete_all.Text = "Delete All";
            this.btn_delete_all.UseVisualStyleBackColor = true;
            this.btn_delete_all.Click += new System.EventHandler(this.btn_delete_all_Click);
            // 
            // rb_airplane
            // 
            this.rb_airplane.AutoSize = true;
            this.rb_airplane.Checked = true;
            this.rb_airplane.Location = new System.Drawing.Point(621, 78);
            this.rb_airplane.Name = "rb_airplane";
            this.rb_airplane.Size = new System.Drawing.Size(67, 17);
            this.rb_airplane.TabIndex = 3;
            this.rb_airplane.TabStop = true;
            this.rb_airplane.Text = "Air Plane";
            this.rb_airplane.UseVisualStyleBackColor = true;
            // 
            // rb_horizon
            // 
            this.rb_horizon.AutoSize = true;
            this.rb_horizon.Location = new System.Drawing.Point(621, 101);
            this.rb_horizon.Name = "rb_horizon";
            this.rb_horizon.Size = new System.Drawing.Size(100, 17);
            this.rb_horizon.TabIndex = 3;
            this.rb_horizon.Text = "Artificial Horizon";
            this.rb_horizon.UseVisualStyleBackColor = true;
            // 
            // UserControl_Train_Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rb_horizon);
            this.Controls.Add(this.rb_airplane);
            this.Controls.Add(this.richTextBox_mission);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sub_not);
            this.Controls.Add(this.btn_not);
            this.Controls.Add(this.btn_sub_left);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_sub_right);
            this.Controls.Add(this.btn_add_not);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_delete_all);
            this.Controls.Add(this.btn_deletelast);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_add_left);
            this.Controls.Add(this.btn_sub_relax);
            this.Controls.Add(this.btn_add_right);
            this.Controls.Add(this.btn_relax);
            this.Controls.Add(this.btn_add_relax);
            this.Name = "UserControl_Train_Setup";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.UserControl_Train_Setup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_relax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_mission;
        private System.Windows.Forms.Button btn_sub_relax;
        private System.Windows.Forms.Button btn_relax;
        private System.Windows.Forms.Button btn_add_right;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_sub_right;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add_left;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_sub_left;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add_not;
        private System.Windows.Forms.Button btn_not;
        private System.Windows.Forms.Button btn_sub_not;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_deletelast;
        private System.Windows.Forms.Button btn_delete_all;
        public System.Windows.Forms.RadioButton rb_airplane;
        public System.Windows.Forms.RadioButton rb_horizon;
    }
}
