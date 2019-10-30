namespace GameCaro
{
    partial class FormChienThang
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
            this.components = new System.ComponentModel.Container();
            this.lbwin = new System.Windows.Forms.Label();
            this.tmchuchay = new System.Windows.Forms.Timer(this.components);
            this.lbchienthang = new System.Windows.Forms.Label();
            this.tmdoimau = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tbxname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbwin
            // 
            this.lbwin.AutoSize = true;
            this.lbwin.BackColor = System.Drawing.Color.Transparent;
            this.lbwin.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbwin.Location = new System.Drawing.Point(61, 334);
            this.lbwin.Name = "lbwin";
            this.lbwin.Size = new System.Drawing.Size(349, 33);
            this.lbwin.TabIndex = 1;
            this.lbwin.Text = "THẮNG BẠI TẠI KỸ NĂNG!";
            this.lbwin.Click += new System.EventHandler(this.lbwin_Click);
            // 
            // tmchuchay
            // 
            this.tmchuchay.Enabled = true;
            this.tmchuchay.Tick += new System.EventHandler(this.tmchuchay_Tick);
            // 
            // lbchienthang
            // 
            this.lbchienthang.AutoSize = true;
            this.lbchienthang.BackColor = System.Drawing.Color.Transparent;
            this.lbchienthang.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbchienthang.Location = new System.Drawing.Point(75, 11);
            this.lbchienthang.Name = "lbchienthang";
            this.lbchienthang.Size = new System.Drawing.Size(487, 68);
            this.lbchienthang.TabIndex = 2;
            this.lbchienthang.Text = "CHIẾN THẮNG!!!";
            // 
            // tmdoimau
            // 
            this.tmdoimau.Enabled = true;
            this.tmdoimau.Tick += new System.EventHandler(this.tmdoimau_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(228, 250);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 69);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK Chiến Tiếp!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxname
            // 
            this.tbxname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxname.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tbxname.Location = new System.Drawing.Point(228, 188);
            this.tbxname.Margin = new System.Windows.Forms.Padding(4);
            this.tbxname.Name = "tbxname";
            this.tbxname.Size = new System.Drawing.Size(286, 38);
            this.tbxname.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Winner...";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::TestCode.Properties.Resources.bf0d85d3e1bee380ee95b950e34955ae;
            this.pictureBox2.Location = new System.Drawing.Point(540, 81);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TestCode.Properties.Resources.AW439657_14;
            this.pictureBox1.Location = new System.Drawing.Point(31, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormChienThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TestCode.Properties.Resources._10730;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxname);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbchienthang);
            this.Controls.Add(this.lbwin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormChienThang";
            this.Text = "CHIẾN THẮNG!";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbwin;
        private System.Windows.Forms.Timer tmchuchay;
        private System.Windows.Forms.Label lbchienthang;
        private System.Windows.Forms.Timer tmdoimau;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbxname;
        private System.Windows.Forms.Label label1;
    }
}