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
            BanCo.EndedGame += ChessBoard_Endedgame;
            BanCo.PlayerMarked += ChessBoard_PlayerMarked;

            Tmthoigian.Interval = Cons.COOL_DOWN_INTERVAL;

            socket = new SocketManager();

            NewGame();

        }

        void NewGame()
        {
            Tmthoigian.Stop();
            btnUndo.Enabled = true;
            BanCo.VeBanCo();
            NhacNen.Play();
        }

        void EndGame()
        {
            Tmthoigian.Stop();
            pnlChessBoard.Enabled = false;
            btnUndo.Enabled = false;
        }

        private void tmnote_Tick(object sender, EventArgs e)
		{
			NOTE.ForeColor = Color.FromArgb(Random.Next(0, 225), Random.Next(0, 225), Random.Next(0, 225));
		}

		private void btnnewgame_Click(object sender, EventArgs e)
		{
            dem = 0;
            NewGame();
            socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
            XuLyBanCo.win = 0;
            tmmophong.Enabled = false;
            Tmthoigian.Enabled = true;
            XuLyBanCo.time = 30;
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
            Undo();
        }

        void Undo()
        {
            BanCo.Undo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnnewgame;
            XuLyBanCo.Chan = 0;
            XuLyBanCo.time = 30;
        }

        int dem = 0;

        private void btnhuongdan_Click(object sender, EventArgs e)
        {
            FormHuongDan f = new FormHuongDan();
            f.Show();
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
                //BanCo.LuuVanCo();
                XuLyBanCo.win = 1;
                socket.Send(new SocketData((int)SocketCommand.TIME_OUT, "", new Point()));
                FormChienThang f1 = new FormChienThang();
                f1.Show();
            }
        }

        private void btnluuvathoat_Click(object sender, EventArgs e)
        {
            //BanCo.LuuVanCo();
            StreamWriter write = new StreamWriter("save.txt",false);
            write.WriteLine(XuLyBanCo.N1);
            write.WriteLine(XuLyBanCo.N2);
            write.WriteLine(XuLyBanCo.nguoichoihientai);
            //write.WriteLine(BanCo.QUEUE.Count());


            //Point p0 = new Point(0, 0);
            //int kt = 0;
            //while (BanCo.QUEUE.Count != 0)
            //{
            //    Point P = BanCo.QUEUE.Dequeue();
            //    if (p0 == P)
            //        kt = 1;
            //    write.WriteLine(P.X);
            //    write.WriteLine(P.Y);
            //}
            //write.WriteLine(kt);
            //write.Close();
            Tmthoigian.Enabled = false;

            MessageBox.Show("Đã lưu ván cờ!", "Thông báo!");
            Application.Exit();
        }

        void ChessBoard_PlayerMarked(object sender, ButtonClickEvent e)
        {
            Tmthoigian.Start();

            pnlChessBoard.Enabled = false;

            socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickedPoint));
            btnUndo.Enabled = false;

            Listen();
        }
        void ChessBoard_Endedgame(object sender, EventArgs e)
        {
            EndGame();
            socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
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
                        NewGame();
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