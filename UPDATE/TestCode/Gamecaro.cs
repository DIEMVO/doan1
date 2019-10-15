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

			BanCo = new XuLyBanCo(pnlChessBoard, txbPlayerName, pctbMark);

			BanCo.VeBanCo();
			NhacNen.Play();

            socket = new SocketManager();
		}

		private void tmnote_Tick(object sender, EventArgs e)
		{
			NOTE.ForeColor = Color.FromArgb(Random.Next(0, 225), Random.Next(0, 225), Random.Next(0, 225));
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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnnewgame;
            XuLyBanCo.Chan = 0;
            XuLyBanCo.time = 30;
        }

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

        private void btnUndo_Click(object sender, EventArgs e)
        {
            XuLyBanCo.time = 30;
            if (BanCo.STACK.Count == 0)
                return;
            if (XuLyBanCo.win == 0)
                BanCo.Undo();
            else
                btnUndo.Enabled = false;
        }

        private void btnLAN_Click(object sender, EventArgs e)
        {
            socket.IP = txbIP.Text;

            if (!socket.ConnectServer())        //ko thể kết nối server 
            {
                socket.CreateServer();
            }
            else
            {
                Thread listenThread = new Thread(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(500);
                        try
                        {
                            Listen();
                            break;
                        }
                        catch
                        {

                        }
                    }
                });
                listenThread.IsBackground = true;
                listenThread.Start();

                socket.Send("Thông tin từ Client..");
            }
        }

        void Listen()
        {
            string data = (string)socket.Receive();

            MessageBox.Show(data);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            if (string.IsNullOrEmpty(txbIP.Text))
            {
                txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            if (BanCo.QUEUE.Count == 0)
                return;

            if (tmmophong.Enabled==true)
            {
                tmmophong.Enabled = false;
                btnQueue.Text = "Tiếp tục!";
            }
            else
            {
                tmmophong.Enabled = true;
                btnQueue.Text = "Tạm dừng!";
            }
        }
    }
}
;