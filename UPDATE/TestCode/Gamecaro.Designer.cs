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
            this.pcbCountDown = new System.Windows.Forms.ProgressBar();
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
            this.pnlChessBoard.Location = new System.Drawing.Point(219, 2);
            this.pnlChessBoard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(963, 711);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // NOTE
            // 
            this.NOTE.AutoSize = true;
            this.NOTE.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOTE.Location = new System.Drawing.Point(1216, 424);
            this.NOTE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NOTE.Name = "NOTE";
            this.NOTE.Size = new System.Drawing.Size(177, 38);
            this.NOTE.TabIndex = 5;
            this.NOTE.Text = "Cờ Ca Rô";
            // 
            // txbPlayerName
            // 
            this.txbPlayerName.Enabled = false;
            this.txbPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbPlayerName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txbPlayerName.Location = new System.Drawing.Point(396, 732);
            this.txbPlayerName.Margin = new System.Windows.Forms.Padding(4);
            this.txbPlayerName.Name = "txbPlayerName";
            this.txbPlayerName.Size = new System.Drawing.Size(253, 34);
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
            this.btnnewgame.Location = new System.Drawing.Point(12, 688);
            this.btnnewgame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnewgame.Name = "btnnewgame";
            this.btnnewgame.Size = new System.Drawing.Size(192, 40);
            this.btnnewgame.TabIndex = 8;
            this.btnnewgame.Text = "NEW GAME!";
            this.btnnewgame.UseVisualStyleBackColor = true;
            // 
            // btnNhacNen
            // 
            this.btnNhacNen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhacNen.Location = new System.Drawing.Point(12, 443);
            this.btnNhacNen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhacNen.Name = "btnNhacNen";
            this.btnNhacNen.Size = new System.Drawing.Size(192, 39);
            this.btnNhacNen.TabIndex = 10;
            this.btnNhacNen.Text = "Music ON";
            this.btnNhacNen.UseVisualStyleBackColor = true;
            this.btnNhacNen.Click += new System.EventHandler(this.btnNhacNen_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.Location = new System.Drawing.Point(12, 732);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(192, 40);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "THOÁT!";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Location = new System.Drawing.Point(15, 256);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(189, 44);
            this.btnUndo.TabIndex = 12;
            this.btnUndo.Text = "UnDo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueue.Location = new System.Drawing.Point(12, 316);
            this.btnQueue.Margin = new System.Windows.Forms.Padding(4);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(192, 43);
            this.btnQueue.TabIndex = 13;
            this.btnQueue.Text = "Mô phỏng lại";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnhuongdan
            // 
            this.btnhuongdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuongdan.Location = new System.Drawing.Point(12, 501);
            this.btnhuongdan.Margin = new System.Windows.Forms.Padding(4);
            this.btnhuongdan.Name = "btnhuongdan";
            this.btnhuongdan.Size = new System.Drawing.Size(192, 39);
            this.btnhuongdan.TabIndex = 14;
            this.btnhuongdan.Text = "Hướng dẫn";
            this.btnhuongdan.UseVisualStyleBackColor = true;
            this.btnhuongdan.Click += new System.EventHandler(this.btnhuongdan_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TestCode.Properties.Resources.Dr3amyOC;
            this.pictureBox2.Location = new System.Drawing.Point(13, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 230);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestCode.Properties.Resources._1510631098_hibike__euphonium___reina_kousaka_chibi_gif_by_vforvu_d8zc77s;
            this.pictureBox1.Location = new System.Drawing.Point(1206, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pctbMark
            // 
            this.pctbMark.BackColor = System.Drawing.SystemColors.Control;
            this.pctbMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctbMark.Location = new System.Drawing.Point(1225, 256);
            this.pctbMark.Margin = new System.Windows.Forms.Padding(4);
            this.pctbMark.Name = "pctbMark";
            this.pctbMark.Size = new System.Drawing.Size(163, 165);
            this.pctbMark.TabIndex = 2;
            this.pctbMark.TabStop = false;
            // 
            // tmmophong
            // 
            this.tmmophong.Interval = 1000;
            // 
            // btnChanhaidau
            // 
            this.btnChanhaidau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChanhaidau.Location = new System.Drawing.Point(12, 380);
            this.btnChanhaidau.Margin = new System.Windows.Forms.Padding(4);
            this.btnChanhaidau.Name = "btnChanhaidau";
            this.btnChanhaidau.Size = new System.Drawing.Size(192, 42);
            this.btnChanhaidau.TabIndex = 15;
            this.btnChanhaidau.Text = "Chặn hai đầu";
            this.btnChanhaidau.UseVisualStyleBackColor = true;
            this.btnChanhaidau.Click += new System.EventHandler(this.btnChanhaidau_Click);
            // 
            // Tmthoigian
            // 
            this.Tmthoigian.Enabled = true;
            this.Tmthoigian.Interval = 1000;
            // 
            // btnluuvathoat
            // 
            this.btnluuvathoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluuvathoat.Location = new System.Drawing.Point(12, 597);
            this.btnluuvathoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnluuvathoat.Name = "btnluuvathoat";
            this.btnluuvathoat.Size = new System.Drawing.Size(192, 39);
            this.btnluuvathoat.TabIndex = 17;
            this.btnluuvathoat.Text = "Save and Exit";
            this.btnluuvathoat.UseVisualStyleBackColor = true;
            // 
            // btntieptuc
            // 
            this.btntieptuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntieptuc.Location = new System.Drawing.Point(12, 644);
            this.btntieptuc.Margin = new System.Windows.Forms.Padding(4);
            this.btntieptuc.Name = "btntieptuc";
            this.btntieptuc.Size = new System.Drawing.Size(192, 38);
            this.btntieptuc.TabIndex = 18;
            this.btntieptuc.Text = "Game đã lưu";
            this.btntieptuc.UseVisualStyleBackColor = true;
            // 
            // btnLAN
            // 
            this.btnLAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLAN.Location = new System.Drawing.Point(1206, 617);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(197, 96);
            this.btnLAN.TabIndex = 19;
            this.btnLAN.Text = "Connect to LAN";
            this.btnLAN.UseVisualStyleBackColor = true;
            this.btnLAN.Click += new System.EventHandler(this.btnLAN_Click);
            // 
            // txbIP
            // 
            this.txbIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIP.Location = new System.Drawing.Point(1206, 577);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(196, 34);
            this.txbIP.TabIndex = 20;
            this.txbIP.Text = "127.0.0.1";
            // 
            // pcbCountDown
            // 
            this.pcbCountDown.Location = new System.Drawing.Point(748, 732);
            this.pcbCountDown.Name = "pcbCountDown";
            this.pcbCountDown.Size = new System.Drawing.Size(253, 34);
            this.pcbCountDown.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1428, 786);
            this.Controls.Add(this.pcbCountDown);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ProgressBar pcbCountDown;
    }
}

