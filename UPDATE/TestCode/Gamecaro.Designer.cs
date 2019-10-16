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
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnhuongdan = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctbMark = new System.Windows.Forms.PictureBox();
            this.tmmophong = new System.Windows.Forms.Timer(this.components);
            this.btnChanhaidau = new System.Windows.Forms.Button();
            this.Tmthoigian = new System.Windows.Forms.Timer(this.components);
            this.btnluuvathoat = new System.Windows.Forms.Button();
            this.btntieptuc = new System.Windows.Forms.Button();
            this.btnLAN = new System.Windows.Forms.Button();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.tbthoigian = new System.Windows.Forms.TextBox();
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
            this.pnlChessBoard.Size = new System.Drawing.Size(705, 542);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // NOTE
            // 
            this.NOTE.AutoSize = true;
            this.NOTE.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOTE.Location = new System.Drawing.Point(877, 361);
            this.NOTE.Name = "NOTE";
            this.NOTE.Size = new System.Drawing.Size(145, 31);
            this.NOTE.TabIndex = 5;
            this.NOTE.Text = "Cờ Ca Rô";
            // 
            // txbPlayerName
            // 
            this.txbPlayerName.Enabled = false;
            this.txbPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbPlayerName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txbPlayerName.Location = new System.Drawing.Point(291, 561);
            this.txbPlayerName.Name = "txbPlayerName";
            this.txbPlayerName.Size = new System.Drawing.Size(191, 28);
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
            this.btnnewgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnnewgame.Location = new System.Drawing.Point(9, 519);
            this.btnnewgame.Margin = new System.Windows.Forms.Padding(2);
            this.btnnewgame.Name = "btnnewgame";
            this.btnnewgame.Size = new System.Drawing.Size(144, 32);
            this.btnnewgame.TabIndex = 8;
            this.btnnewgame.Text = "NEW GAME!";
            this.btnnewgame.UseVisualStyleBackColor = true;
            this.btnnewgame.Click += new System.EventHandler(this.btnnewgame_Click);
            // 
            // btnNhacNen
            // 
            this.btnNhacNen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhacNen.Location = new System.Drawing.Point(9, 360);
            this.btnNhacNen.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhacNen.Name = "btnNhacNen";
            this.btnNhacNen.Size = new System.Drawing.Size(144, 32);
            this.btnNhacNen.TabIndex = 10;
            this.btnNhacNen.Text = "Music ON";
            this.btnNhacNen.UseVisualStyleBackColor = true;
            this.btnNhacNen.Click += new System.EventHandler(this.btnNhacNen_Click);
            // 
            // tmluatchoi
            // 
            this.tmluatchoi.Tick += new System.EventHandler(this.tmluatchoi_Tick);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.Location = new System.Drawing.Point(9, 557);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(144, 32);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "THOÁT!";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Location = new System.Drawing.Point(11, 208);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(2);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(142, 36);
            this.btnUndo.TabIndex = 12;
            this.btnUndo.Text = "UnDo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueue.Location = new System.Drawing.Point(9, 257);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(144, 35);
            this.btnQueue.TabIndex = 13;
            this.btnQueue.Text = "Mô phỏng lại";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnhuongdan
            // 
            this.btnhuongdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuongdan.Location = new System.Drawing.Point(9, 407);
            this.btnhuongdan.Name = "btnhuongdan";
            this.btnhuongdan.Size = new System.Drawing.Size(144, 32);
            this.btnhuongdan.TabIndex = 14;
            this.btnhuongdan.Text = "Hướng dẫn";
            this.btnhuongdan.UseVisualStyleBackColor = true;
            this.btnhuongdan.Click += new System.EventHandler(this.btnhuongdan_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TestCode.Properties.Resources.Dr3amyOC;
            this.pictureBox2.Location = new System.Drawing.Point(10, 3);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 187);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestCode.Properties.Resources._1510631098_hibike__euphonium___reina_kousaka_chibi_gif_by_vforvu_d8zc77s;
            this.pictureBox1.Location = new System.Drawing.Point(874, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
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
            this.pctbMark.Location = new System.Drawing.Point(890, 208);
            this.pctbMark.Name = "pctbMark";
            this.pctbMark.Size = new System.Drawing.Size(122, 134);
            this.pctbMark.TabIndex = 2;
            this.pctbMark.TabStop = false;
            // 
            // tmmophong
            // 
            this.tmmophong.Interval = 1000;
            this.tmmophong.Tick += new System.EventHandler(this.tmmophong_Tick_1);
            // 
            // btnChanhaidau
            // 
            this.btnChanhaidau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChanhaidau.Location = new System.Drawing.Point(9, 309);
            this.btnChanhaidau.Name = "btnChanhaidau";
            this.btnChanhaidau.Size = new System.Drawing.Size(144, 34);
            this.btnChanhaidau.TabIndex = 15;
            this.btnChanhaidau.Text = "Chặn hai đầu";
            this.btnChanhaidau.UseVisualStyleBackColor = true;
            this.btnChanhaidau.Click += new System.EventHandler(this.btnChanhaidau_Click);
            // 
            // Tmthoigian
            // 
            this.Tmthoigian.Enabled = true;
            this.Tmthoigian.Interval = 1000;
            this.Tmthoigian.Tick += new System.EventHandler(this.Tmthoigian_Tick_1);
            // 
            // btnluuvathoat
            // 
            this.btnluuvathoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluuvathoat.Location = new System.Drawing.Point(9, 445);
            this.btnluuvathoat.Name = "btnluuvathoat";
            this.btnluuvathoat.Size = new System.Drawing.Size(144, 32);
            this.btnluuvathoat.TabIndex = 17;
            this.btnluuvathoat.Text = "Save and Exit";
            this.btnluuvathoat.UseVisualStyleBackColor = true;
            this.btnluuvathoat.Click += new System.EventHandler(this.btnluuvathoat_Click);
            // 
            // btntieptuc
            // 
            this.btntieptuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntieptuc.Location = new System.Drawing.Point(11, 483);
            this.btntieptuc.Name = "btntieptuc";
            this.btntieptuc.Size = new System.Drawing.Size(144, 31);
            this.btntieptuc.TabIndex = 18;
            this.btntieptuc.Text = "Game đã lưu";
            this.btntieptuc.UseVisualStyleBackColor = true;
            this.btntieptuc.Click += new System.EventHandler(this.btntieptuc_Click);
            // 
            // btnLAN
            // 
            this.btnLAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.btnLAN.Location = new System.Drawing.Point(1206, 617);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(197, 96);
=======
            this.btnLAN.Location = new System.Drawing.Point(899, 531);
            this.btnLAN.Margin = new System.Windows.Forms.Padding(2);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(113, 56);
>>>>>>> b7bb4f8037291f35b5558adbc737759631efcd55
            this.btnLAN.TabIndex = 19;
            this.btnLAN.Text = "Connect to LAN";
            this.btnLAN.UseVisualStyleBackColor = true;
            this.btnLAN.Click += new System.EventHandler(this.btnLAN_Click);
            // 
            // txbIP
            // 
            this.txbIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.txbIP.Location = new System.Drawing.Point(1206, 577);
=======
            this.txbIP.Location = new System.Drawing.Point(890, 466);
            this.txbIP.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> b7bb4f8037291f35b5558adbc737759631efcd55
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(122, 28);
            this.txbIP.TabIndex = 20;
            this.txbIP.Text = "127.0.0.1";
            // 
            // tbthoigian
            // 
            this.tbthoigian.Enabled = false;
            this.tbthoigian.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbthoigian.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tbthoigian.Location = new System.Drawing.Point(696, 559);
            this.tbthoigian.Name = "tbthoigian";
            this.tbthoigian.Size = new System.Drawing.Size(49, 28);
            this.tbthoigian.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1028, 583);
            this.Controls.Add(this.tbthoigian);
            this.Controls.Add(this.txbIP);
            this.Controls.Add(this.btnLAN);
            this.Controls.Add(this.btntieptuc);
            this.Controls.Add(this.btnluuvathoat);
            this.Controls.Add(this.btnChanhaidau);
            this.Controls.Add(this.btnhuongdan);
            this.Controls.Add(this.btnQueue);
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
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnhuongdan;
        private System.Windows.Forms.Timer tmmophong;
        private System.Windows.Forms.Button btnChanhaidau;
        private System.Windows.Forms.Timer Tmthoigian;
        private System.Windows.Forms.Button btnluuvathoat;
        private System.Windows.Forms.Button btntieptuc;
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.TextBox tbthoigian;
    }
}

