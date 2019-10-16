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
           //lan
            socket = new SocketManager();
		}

		private void tmnote_Tick(object sender, EventArgs e)
		{
			NOTE.ForeColor = Color.FromArgb(Random.Next(0, 225), Random.Next(0, 225), Random.Next(0, 225));
		}

        private string nhac = "Music ON";
		private SoundPlayer NhacNen = new SoundPlayer(@"NhacNen.wav");
        private int dem;

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
        private void Tmthoigian_Tick(object sender, EventArgs e)
        {

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

        private void pcbCountDown_Click(object sender, EventArgs e)
        {

        }
        private void tmmophong_Tick(object sender, EventArgs e)
        {
            
        }
        
        private void btnnewgame_Click(object sender, EventArgs e)
        {
            dem = 0;
            BanCo.Newgame();
            btnUndo.Enabled = true;
            XuLyBanCo.win = 0;
            tmmophong.Enabled = false;
            btnQueue.Text = "Mô phỏng lại";
            Tmthoigian.Enabled = true;
            XuLyBanCo.time = 30;
            btntieptuc.Enabled = true;
        }

        private void btnluuvathoat_Click(object sender, EventArgs e)
        {
            BanCo.LuuVanCo();
            StreamWriter write = new StreamWriter("save.txt", false);
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
            BanCo.XoaBanCo();
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
            string line;
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

        private void tmluatchoi_Tick(object sender, EventArgs e)
        {

        }

        private void tmmophong_Tick_1(object sender, EventArgs e)
        {
            if (BanCo.QUEUE.Count == 0)
                return;
            if (dem == 0 && XuLyBanCo.win == 1)
            {
                BanCo.XoaBanCo();
                dem = 1;
            }
            if (XuLyBanCo.win == 1)
            {
                BanCo.MoPhong();
            }
        }

        private void Tmthoigian_Tick_1(object sender, EventArgs e)
        {
            XuLyBanCo.time--;
            this.tbthoigian.Text = XuLyBanCo.time.ToString();

            if (XuLyBanCo.win == 1)
                Tmthoigian.Enabled = false;

            if (XuLyBanCo.time == 0)
            {
                Tmthoigian.Enabled = false;
                pnlChessBoard.Enabled = false;
                BanCo.LuuVanCo();
                XuLyBanCo.win = 1;
                FormChienThang f1 = new FormChienThang();
                f1.Show();
            }
        }
    }
}
;