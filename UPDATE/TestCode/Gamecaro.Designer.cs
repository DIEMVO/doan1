namespace GameCaro
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
            this.components = new System.ComponentModel.Container();
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.NOTE = new System.Windows.Forms.Label();
            this.txbPlayerName = new System.Windows.Forms.TextBox();
            this.tmnote = new System.Windows.Forms.Timer(this.components);
            this.btnnewgame = new System.Windows.Forms.Button();
            this.btnNhacNen = new System.Windows.Forms.Button();
            this.tmluatchoi = new System.Windows.Forms.Timer(this.components);
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnhuongdan = new System.Windows.Forms.Button();
            this.tmmophong = new System.Windows.Forms.Timer(this.components);
            this.btnChanhaidau = new System.Windows.Forms.Button();
            this.Tmthoigian = new System.Windows.Forms.Timer(this.components);
            this.txbIP = new System.Windows.Forms.TextBox();
            this.btnLAN = new System.Windows.Forms.Button();
            this.pcbCoolDown = new System.Windows.Forms.ProgressBar();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctbMark = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChessBoard.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pnlChessBoard.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.pnlChessBoard.Location = new System.Drawing.Point(164, 2);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(722, 578);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // NOTE
            // 
            this.NOTE.AutoSize = true;
            this.NOTE.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOTE.Location = new System.Drawing.Point(908, 353);
            this.NOTE.Name = "NOTE";
            this.NOTE.Size = new System.Drawing.Size(145, 31);
            this.NOTE.TabIndex = 5;
            this.NOTE.Text = "Cờ Ca Rô";
            // 
            // txbPlayerName
            // 
            this.txbPlayerName.Enabled = false;
            this.txbPlayerName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbPlayerName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txbPlayerName.Location = new System.Drawing.Point(272, 592);
            this.txbPlayerName.Name = "txbPlayerName";
            this.txbPlayerName.Size = new System.Drawing.Size(191, 35);
            this.txbPlayerName.TabIndex = 0;
            // 
            // tmnote
            // 
            this.tmnote.Enabled = true;
            this.tmnote.Interval = 200;
            this.tmnote.Tick += new System.EventHandler(this.tmnote_Tick);
            // 
            // btnnewgame
            // 
            this.btnnewgame.BackColor = System.Drawing.Color.PeachPuff;
            this.btnnewgame.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnnewgame.Location = new System.Drawing.Point(11, 548);
            this.btnnewgame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnnewgame.Name = "btnnewgame";
            this.btnnewgame.Size = new System.Drawing.Size(144, 34);
            this.btnnewgame.TabIndex = 8;
            this.btnnewgame.Text = "NEW GAME";
            this.btnnewgame.UseVisualStyleBackColor = false;
            this.btnnewgame.Click += new System.EventHandler(this.btnnewgame_Click);
            // 
            // btnNhacNen
            // 
            this.btnNhacNen.BackColor = System.Drawing.Color.PeachPuff;
            this.btnNhacNen.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhacNen.Location = new System.Drawing.Point(11, 505);
            this.btnNhacNen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNhacNen.Name = "btnNhacNen";
            this.btnNhacNen.Size = new System.Drawing.Size(144, 32);
            this.btnNhacNen.TabIndex = 10;
            this.btnNhacNen.Text = "Music ON";
            this.btnNhacNen.UseVisualStyleBackColor = false;
            this.btnNhacNen.Click += new System.EventHandler(this.btnNhacNen_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.PeachPuff;
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.Location = new System.Drawing.Point(11, 592);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(144, 33);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "THOÁT";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.PeachPuff;
            this.btnUndo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Location = new System.Drawing.Point(11, 239);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(144, 30);
            this.btnUndo.TabIndex = 12;
            this.btnUndo.Text = "UNDO";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnhuongdan
            // 
            this.btnhuongdan.BackColor = System.Drawing.Color.PeachPuff;
            this.btnhuongdan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuongdan.Location = new System.Drawing.Point(902, 581);
            this.btnhuongdan.Name = "btnhuongdan";
            this.btnhuongdan.Size = new System.Drawing.Size(147, 45);
            this.btnhuongdan.TabIndex = 14;
            this.btnhuongdan.Text = "Hướng dẫn";
            this.btnhuongdan.UseVisualStyleBackColor = false;
            this.btnhuongdan.Click += new System.EventHandler(this.btnhuongdan_Click);
            // 
            // tmmophong
            // 
            this.tmmophong.Interval = 1000;
            // 
            // btnChanhaidau
            // 
            this.btnChanhaidau.BackColor = System.Drawing.Color.PeachPuff;
            this.btnChanhaidau.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChanhaidau.Location = new System.Drawing.Point(11, 284);
            this.btnChanhaidau.Name = "btnChanhaidau";
            this.btnChanhaidau.Size = new System.Drawing.Size(144, 33);
            this.btnChanhaidau.TabIndex = 15;
            this.btnChanhaidau.Text = "Chặn hai đầu";
            this.btnChanhaidau.UseVisualStyleBackColor = false;
            this.btnChanhaidau.Click += new System.EventHandler(this.btnChanhaidau_Click);
            // 
            // Tmthoigian
            // 
            this.Tmthoigian.Enabled = true;
            this.Tmthoigian.Interval = 1000;
            this.Tmthoigian.Tick += new System.EventHandler(this.Tmthoigian_Tick);
            // 
            // txbIP
            // 
            this.txbIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIP.Location = new System.Drawing.Point(902, 433);
            this.txbIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(149, 28);
            this.txbIP.TabIndex = 19;
            this.txbIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLAN
            // 
            this.btnLAN.BackColor = System.Drawing.Color.PeachPuff;
            this.btnLAN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLAN.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLAN.Location = new System.Drawing.Point(902, 475);
            this.btnLAN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(148, 72);
            this.btnLAN.TabIndex = 20;
            this.btnLAN.Text = "Connect to LAN";
            this.btnLAN.UseVisualStyleBackColor = false;
            this.btnLAN.Click += new System.EventHandler(this.btnLAN_Click);
            // 
            // pcbCoolDown
            // 
            this.pcbCoolDown.Location = new System.Drawing.Point(598, 592);
            this.pcbCoolDown.Name = "pcbCoolDown";
            this.pcbCoolDown.Size = new System.Drawing.Size(184, 33);
            this.pcbCoolDown.TabIndex = 21;
            this.pcbCoolDown.Click += new System.EventHandler(this.pcbCoolDown_Click);
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TestCode.Properties.Resources.giphy;
            this.pictureBox2.Location = new System.Drawing.Point(9, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 187);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestCode.Properties.Resources.giphy__1_;
            this.pictureBox1.Location = new System.Drawing.Point(902, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pctbMark
            // 
            this.pctbMark.BackColor = System.Drawing.SystemColors.Control;
            this.pctbMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctbMark.Location = new System.Drawing.Point(908, 210);
            this.pctbMark.Name = "pctbMark";
            this.pctbMark.Size = new System.Drawing.Size(134, 126);
            this.pctbMark.TabIndex = 2;
            this.pctbMark.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.pcbCoolDown);
            this.Controls.Add(this.btnLAN);
            this.Controls.Add(this.txbIP);
            this.Controls.Add(this.btnChanhaidau);
            this.Controls.Add(this.btnhuongdan);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnNhacNen);
            this.Controls.Add(this.btnnewgame);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pctbMark);
            this.Controls.Add(this.NOTE);
            this.Controls.Add(this.txbPlayerName);
            this.Controls.Add(this.pnlChessBoard);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Game Caro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlChessBoard;
		private System.Windows.Forms.PictureBox pctbMark;
		private System.Windows.Forms.TextBox txbPlayerName;
		private System.Windows.Forms.Label NOTE;
		private System.Windows.Forms.Timer tmnote;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btnnewgame;
		private System.Windows.Forms.Button btnNhacNen;
		private System.Windows.Forms.Timer tmluatchoi;
		private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnhuongdan;
        private System.Windows.Forms.Timer tmmophong;
        private System.Windows.Forms.Button btnChanhaidau;
        private System.Windows.Forms.Timer Tmthoigian;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.ProgressBar pcbCoolDown;
        private System.Windows.Forms.Timer tmCoolDown;
    }
}

