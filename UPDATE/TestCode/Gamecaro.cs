using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCode;
using static TestCode.SocketData;

namespace GameCaro
{
	public partial class Form1 : Form
	{
		XuLyBanCo BanCo;

        Random Random = new Random();

        private int sound = 0;

        SocketManager socket;

        public Form1()
		{
			InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;
			
            BanCo = new XuLyBanCo(pnlChessBoard, txbPlayerName, pctbMark);

			BanCo.VeBanCo();
			NhacNen.Play();

            socket = new SocketManager();
        }

		private void tmnote_Tick(object sender, EventArgs e)
		{
			NOTE.ForeColor = Color.FromArgb(Random.Next(0, 225), Random.Next(0, 225), Random.Next(0, 225));
		}

		private void btnnewgame_Click(object sender, EventArgs e)
		{
            dem = 0;
            BanCo.Newgame();
            socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
            btnUndo.Enabled = true;
            XuLyBanCo.win = 0;
            tmmophong.Enabled = false;
            btnQueue.Text = "Mô phỏng lại";
            Tmthoigian.Enabled = true;
            XuLyBanCo.time = 30;
            btntieptuc.Enabled = true;
        }

        private string nhac = "Music ON";
		private SoundPlayer NhacNen = new SoundPlayer(@"NhacNen.wav");

		private void btnNhacNen_Click(object sender, EventArgs e)
		{
			if (sound == 1)
			{
				NhacNen.Play();
				sound = 0;
				btnNhacNen.Text = nhac;
			}
			else
			{
				NhacNen.Stop();
				sound = 1;
				btnNhacNen.Text = "Music OFF";
			}
		}

		private void btnthoat_Click(object sender, EventArgs e)
		{
           FormThoat f = new FormThoat();
            f.Show();
		}

        public void btnUndo_Click(object sender, EventArgs e)
        {
            XuLyBanCo.time = 30;
            if (BanCo.STACK.Count == 0)
                return;
            if (XuLyBanCo.win == 0)
                BanCo.Undo();
            else
                btnUndo.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnnewgame;
            XuLyBanCo.Chan = 0;
            XuLyBanCo.time = 30;
        }

        int dem = 0;
        private void Queue_Click(object sender, EventArgs e)
        {
            if (BanCo.QUEUE.Count == 0)
                return;

            if (tmmophong.Enabled == true)
            {
                tmmophong.Enabled = false;
                btnQueue.Text = "Tiếp Tục!";
            }
            else
            {
                tmmophong.Enabled = true;
                btnQueue.Text = "Tạm Dừng!";
            }
        }

        private void btnhuongdan_Click(object sender, EventArgs e)
        {
            FormHuongDan f = new FormHuongDan();
            f.Show();
        }

        private void tmmophong_Tick(object sender, EventArgs e)
        {
            if (BanCo.QUEUE.Count == 0)
                return;
            if (dem == 0 && XuLyBanCo.win == 1)
            {
                BanCo.Xoabanco();
                dem = 1;
            }
            if (XuLyBanCo.win == 1)
            {
                BanCo.MoPhong();
            }
        }

        private void btnChanhaidau_Click(object sender, EventArgs e)
        {
            if (XuLyBanCo.Chan == 0)
            {
                XuLyBanCo.Chan = 1;
                MessageBox.Show("Đã áp dụng luật chặn hai đầu!");
                btnChanhaidau.Text = "Hủy luật chặn!";
            }
            else
            {
                XuLyBanCo.Chan = 0;
                MessageBox.Show("Đã Hủy luật chặn hai đầu!");
                btnChanhaidau.Text = "Chặn hai đầu!";
            }
        }

        private void Tmthoigian_Tick(object sender, EventArgs e)
        {
            XuLyBanCo.time--;
            this.tbxthoigian.Text = XuLyBanCo.time.ToString();

            if (XuLyBanCo.win == 1)
                Tmthoigian.Enabled = false;

            if (XuLyBanCo.time == 0)
            {
                Tmthoigian.Enabled = false;
                pnlChessBoard.Enabled = false;
                BanCo.LuuVanCo();
                XuLyBanCo.win = 1;
                socket.Send(new SocketData((int)SocketCommand.TIME_OUT, "", new Point()));
                FormChienThang f1 = new FormChienThang();
                f1.Show();
            }
        }

        private void btnluuvathoat_Click(object sender, EventArgs e)
        {
            BanCo.LuuVanCo();
            StreamWriter write = new StreamWriter("save.txt",false);
            write.WriteLine(XuLyBanCo.N1);
            write.WriteLine(XuLyBanCo.N2);
            write.WriteLine(XuLyBanCo.nguoichoihientai);
            write.WriteLine(BanCo.QUEUE.Count());


            Point p0 = new Point(0, 0);
            int kt = 0;
            while (BanCo.QUEUE.Count != 0)
            {
                Point P = BanCo.QUEUE.Dequeue();
                if (p0 == P)
                    kt = 1;
                write.WriteLine(P.X);
                write.WriteLine(P.Y);
            }
            write.WriteLine(kt);
            write.Close();
            Tmthoigian.Enabled = false;

            MessageBox.Show("Đã lưu ván cờ!", "Thông báo!");
            Application.Exit();
        }

        private void btntieptuc_Click(object sender, EventArgs e)
        {
            BanCo.Xoabanco();
            int x, y;
            StreamReader read;
            try
            {
                read = new StreamReader("save.txt"); 
            }
            catch (Exception)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo!");
                return;
            }

            XuLyBanCo.N1 = read.ReadLine();
            XuLyBanCo.N2 = read.ReadLine();
            XuLyBanCo.nguoichoihientai = Convert.ToInt32(read.ReadLine());
            int sl = Convert.ToInt32(read.ReadLine());
            BanCo.UpdateName();
            if (XuLyBanCo.nguoichoihientai == 1)
                XuLyBanCo.nguoichoihientai = 0;
            string line ;
            int i = 0;
            while (i != sl)
            {
                i++;
                line = read.ReadLine();
                x = Convert.ToInt32(line);
                line = read.ReadLine();
                y = Convert.ToInt32(line);

                Point P = new Point(x, y);
                BanCo.QUEUE.Enqueue(P);
                BanCo.STACK.Push(P);
            }
            int kt = Convert.ToInt32(read.ReadLine());
            if (kt == 1)
                BanCo.QUEUE.Dequeue();
            try
            {
                while (BanCo.QUEUE.Count() != 0)
                {
                    BanCo.MoPhong();
                }
            }
            catch (Exception)
            { };
            btntieptuc.Enabled = false;
        }

        private void btnLAN_Click(object sender, EventArgs e)
        {
            socket.IP = txbIP.Text;

            if (!socket.ConnectServer())
            {
                socket.isServer = true;
                pnlChessBoard.Enabled = true;
                socket.CreateServer();
            }
            else
            {
                socket.isServer = false;
                pnlChessBoard.Enabled = false;
                Listen();
            }
        }

        void Listen()
        {
            Thread listenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Receive();
                    ProcessData(data);
                }
                catch (Exception e)
                {

                }

            });
            listenThread.IsBackground = true;
            listenThread.Start();

        }
        private void ProcessData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.NOTIFY:
                    MessageBox.Show(data.Message);
                    break;
                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        BanCo.Newgame();
                        pnlChessBoard.Enabled = false;
                    }));
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        prcbCoolDown.Value = 0;
                        pnlChessBoard.Enabled = true;
                        Tmthoigian.Start();
                        BanCo.OtherPlayerMark(data.Point);

                    }));
                    break;
                case (int)SocketCommand.UNDO:
                    MessageBox.Show(data.Message);
                    break;
                case (int)SocketCommand.END_GAME:
                    MessageBox.Show("Đã có 5 quân cờ trên cùng 1 hàng");
                    break;
                case (int)SocketCommand.TIME_OUT:
                    MessageBox.Show("Đã hết thời gian");
                    break;
                case (int)SocketCommand.QUIT:
                    MessageBox.Show("Người chơi đã thoát!");
                    Tmthoigian.Stop();
                    break;
                default:
                    break;
            }
            Listen();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            if (string.IsNullOrEmpty(txbIP.Text))
            {
                txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }
        void ChessBoard_PlayerMarked(object sender, ButtonClickEvent e)
        {
            Tmthoigian.Start();

            pnlChessBoard.Enabled = false;

            prcbCoolDown.Value = 0;
            socket.Send(new SocketData((int)SocketCommand.SEND_POINT,"",e.ClickedPoint ));

            Listen();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn thoát không?", "Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                }
                catch { }
            }
        }
    }
}
;