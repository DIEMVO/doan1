using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
	//Hàm xử lý bàn cờ caro
	public class XuLyBanCo
	{
		// Properties
		public Panel banco;	//Khai báo Panel bàn cờ

        public MyTack<Point> STACK;      //Ngăn xếp lưu trữ các vị trí đã đánh để Undo

        public MyTack<Point> Stack2;     //dùng để clear bàn cờ

        public Queue<Point> QUEUE;      //Hàng đợi lưu trữ lại các vị trí đã đánh để mô phỏng lại ván cờ

        private List<Player> nguoichoi;     //Khai báo một danh sách người chơi

        public static int nguoichoihientai;          //Biến ghi nhớ người chơi hiện tại 
                                               //( curentPlayer = 0 : là người chơi thứ nhất, = 1 : người chơi thứ 2)
        private TextBox tennguoichoi;           //Chứa đựng tên người chơi, đổi theo currentPlayer

        private PictureBox kyhieunguoichoi;     //Ký hiệu để biết đến lượt ai đánh

        private List<List<Button>> matrix;  //Khai báo ra 2 List lồng nhau, để chứa dữ liệu cho các button cho dễ xử lý (tương tự Như trên Matrix)

        public static int win;  //Biến kiểm tra kết thúc game hay chưa

        public static int Chan;

        public static int Demnuoc = 0;

        public static int time;

        public static string N1;

        public static string N2;
        public Panel BanCo              
		{
			get { return banco; }
			set { banco = value; }
		}

		public List<Player> NguoiChoi
		{
			get { return nguoichoi; }
			set { nguoichoi = value; }
		}

		public int NguoiChoiHienTai
		{
			get { return nguoichoihientai; }
			set { nguoichoihientai = value; }
		}

		public TextBox TenNguoiChoi
		{
			get { return tennguoichoi; }
			set { tennguoichoi = value; }
		}

		public PictureBox KyHieuNguoiChoi
		{
			get { return kyhieunguoichoi; }
			set { kyhieunguoichoi = value; }
		}

		public List<List<Button>> Matrix
		{
			get { return matrix; }
			set { matrix = value; }
		}

		////////////////////////////

		//Xử lý, khởi tạo
		private SoundPlayer Amthanh1 = new SoundPlayer(@"Sound1.wav");
		private SoundPlayer Amthanh2 = new SoundPlayer(@"Sound2.wav");
        private Button sender;

        public XuLyBanCo(Panel banco, TextBox tennguoichoi, PictureBox kyhieu)
		{
			this.BanCo = banco;
			this.TenNguoiChoi = tennguoichoi;
			this.KyHieuNguoiChoi = kyhieu;

			this.NguoiChoi = new List<Player>()
			{
				new Player("First Player", Image.FromFile("X.jpg"),Amthanh1),
				new Player("Second Player", Image.FromFile("O.jpg"),Amthanh2)
			};

            //Khởi Tạo stack, queue
            STACK = new MyTack<Point>();

            QUEUE = new Queue<Point>();

            Stack2 = new MyTack<Point>();

            //Lấy thông tin tên người chơi từ formNhapThongTin
            FormNhapthongTin f = new FormNhapthongTin();

            //Nếu không nhập tên thì sẽ không cập nhật tên người chơi
            if (f.Name11 != "" && f.Name21 != "")  
            {
                nguoichoi[0].Name = f.Name11;
                nguoichoi[1].Name = f.Name21;
            }

            N1 = nguoichoi[0].Name;
            N2 = nguoichoi[1].Name;
            NguoiChoiHienTai = 0;	 //Mặc định người thứ nhất đi trước ( X đi trước )

			DoiNguoiChoi();		//Để picture Mark hiện ảnh và cho biết ai đi trước.
		}

		/////////////////////

		public void VeBanCo()
		{
			Matrix = new List<List<Button>>();		//Khởi tạo 2 list lồng nhau

			Button ButtonCu = new Button()
			{
				Width = 0, Location = new Point(0, 0)   //Khởi tạo nút đầu làm mốc
			};	
			
			//Sử dụng hai vòng lặp lồng nhau để tạo ra bàn cờ, mỗi ô đánh là một button
			for (int i = 0; i < Cons.ChieuCaoBC; i++)	//Đi hết hàng
			{
				Matrix.Add(new List<Button>());		//Tạo ra một list mới để lưu lại

				for (int j = 0; j < Cons.ChieuRongBC; j++)	//Đi hết cột
				{
                    Button btn = new Button()
                    {
                        Width = Cons.ChieuRongbtn,      //Tạo ra các nút có chiều rộng là cons.ChieuRongbtn, chiều cao là cons.ChieuCaobtn
                        Height = Cons.ChieuCaobtn,

                        //Tạo nên button tiếp theo dựa vào ButtonCu
                        Location = new Point(ButtonCu.Location.X + ButtonCu.Width, ButtonCu.Location.Y),

                        //Định dạng lại ảnh cho vừa với PictureBox
                        BackgroundImageLayout = ImageLayout.Stretch,	

						Tag = i.ToString()			//Lưu lại hàng của button
					};

					btn.Click += btn_Click;		//Tạo event Click

					//Thêm button vào panel bàn cờ.
					BanCo.Controls.Add(btn);

                    Matrix[i].Add(btn);	//Add button vào hàng thứ i của Matrix
					ButtonCu = btn;	//gán Button mới được tạo thành button cũ để tạo ra các button tiếp theo 
				}
				//Hết một hàng, khởi tạo lại hàng mới
				ButtonCu.Location = new Point(0, ButtonCu.Location.Y + Cons.ChieuCaobtn);
				ButtonCu.Width = 0;
				ButtonCu.Height = 0;
			}
		}

        void btn_Click(object sender, EventArgs e)		//Event click cho button
		{

            win = 0;  
			Button btn = sender as Button;		//Ép kiểu lại với button

			if (btn.BackgroundImage != null)	//Kiểm tra xem button này đã được Click chưa
				return;		//đã được đánh, không được đánh lên nửa

            Demnuoc++;

            time = 30;

            if (Demnuoc == Cons.Sumbtn)
                MessageBox.Show("Bất phân thắng bại!!!", "Hòa");

			// Đổi background button theo người đánh
			Mark(btn);

            STACK.Push(LayViTri(btn));      //Add vi tri nut vua nhan vao Stack

            Stack2.Push(LayViTri(btn));

			//Đổi người
			DoiNguoiChoi();

            if (playerMarked != null)
                playerMarked(this, new ButtonClickEvent(LayViTri(btn)));

			if (isEndGame(btn))  //Đã có người thắng 
			{

                BanCo.Enabled = false;      //Vô hiệu hóa bàn cờ

                win = 1;      //Đã kết thúc

                LuuVanCo();

                //Hiện Form chiến thắng
				FormChienThang f = new FormChienThang();
				f.Show();
			}

		}

        public void OtherPlayerMark(Point point)
        {

            win = 0;

            Button btn = Matrix[point.Y][point.X];

            if (btn.BackgroundImage != null)    //Kiểm tra xem button này đã được Click chưa
                return;		//đã được đánh, không được đánh lên nửa

            Demnuoc++;

            time = 30;

            banco.Enabled = true;

            if (Demnuoc == Cons.Sumbtn)
                MessageBox.Show("Bất phân thắng bại!!!", "Hòa");

            // Đổi background button theo người đánh
            Mark(btn);

            STACK.Push(LayViTri(btn));      //Add vi tri nut vua nhan vao Stack

            Stack2.Push(LayViTri(btn));

            //Đổi người
            DoiNguoiChoi();

            if (isEndGame(btn))  //Đã có người thắng 
            {

                BanCo.Enabled = false;      //Vô hiệu hóa bàn cờ

                win = 1;      //Đã kết thúc

                LuuVanCo();

                //Hiện Form chiến thắng
                FormChienThang f = new FormChienThang();
                f.Show();
            }
        }
        private event EventHandler<ButtonClickEvent> playerMarked;
        public event EventHandler<ButtonClickEvent> PlayerMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }

        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }
        //Hàm Undo 
        public void Undo()
        {
            Point vitri = STACK.Pop();      // lấy vị trí button

            Button btn = matrix[vitri.Y][vitri.X];

            btn.BackgroundImage = null;     //Đặt xóa ô đã đánh

            //Đổi ngưởi 
            if (nguoichoihientai == 0)
            {
                NguoiChoiHienTai = 1;
            }
            else
                NguoiChoiHienTai = 0;
            DoiNguoiChoi();
        }

        public void LuuVanCo()
        {
            Stack<Point> st = new Stack<Point>();
            while (STACK.Count != 0)
            {
                st.Push(STACK.Pop());
            }

            while (st.Count != 0)
            {
                QUEUE.Enqueue(st.Pop());
            }
        }

        //Hàm mô phỏng lại ván cờ
        public void MoPhong()
        {
            Point vitri = QUEUE.Dequeue();
            Stack2.Push(vitri);
            Button btn = matrix[vitri.Y][vitri.X];
            btn.BackgroundImage = nguoichoi[NguoiChoiHienTai].Mark;
            if (nguoichoihientai == 0)
            {
                NguoiChoiHienTai = 1;
            }
            else
                NguoiChoiHienTai = 0;
            DoiNguoiChoi();
        }

        public void Newgame()
        {
            Xoabanco();
            banco.Enabled = true;
            //Đặt lại Queue, Stack
            QUEUE.Clear();
            STACK.Clear();
        }

        public void UpdateName()
        {
            this.nguoichoi[0].Name = N1;
            this.nguoichoi[1].Name = N2;
        }

        //Clear bàn cờ
        public void Xoabanco()
        {
            while (Stack2.Count != 0)
            {
                Point vitri = Stack2.Pop();
                Button btn = matrix[vitri.Y][vitri.X];
                btn.BackgroundImage = null;
            }
        }

        //Kiểm tra có người thắng chưa
        //Đúng 1 trong 4 điều kiện hàng 5 thỳ kết thúc game

        public bool isEndGame(Button btn)
		{
			return (ktHangNgang(btn) || ktHangDoc(btn) || ktCheoChinh(btn) || ktCheoPhu(btn));
		}

		private Point LayViTri(Button btn)		//Lấy tọa độ của button ra
		{
			int vertical = Convert.ToInt32(btn.Tag);	//Chuyển Tag về int, lưu lại vị trí hàng của button

			int horizontal = Matrix[vertical].IndexOf(btn);	//lưu lại vị trí cột của button

			Point point = new Point(horizontal, vertical);

			return point;
		}

        private void Mark(Button btn)
        {
            btn.BackgroundImage = NguoiChoi[NguoiChoiHienTai].Mark;     //Đổi ký hiệu X O theo người chơi hiện tại.

            if (NguoiChoiHienTai == 1)      //Sau mỗi lần đánh, đổi người chơi.
            {
                Amthanh1.Play();
                NguoiChoiHienTai = 0;
            }
            else
            {
                NguoiChoiHienTai = 1;
                Amthanh2.Play();
            }
        }

        private void DoiNguoiChoi()		///Hàm đổi người chơi
		{
            TenNguoiChoi.Text = NguoiChoi[NguoiChoiHienTai].Name;       //Đổi tên và ký hiệu dựa trên current player

            KyHieuNguoiChoi.Image = NguoiChoi[NguoiChoiHienTai].Mark;
        }


        private bool ktHangNgang(Button btn)
        {
            Point point = LayViTri(btn);
            int trai, phai;
            int T, P;
            trai = phai = point.X;

            //Chạy qua trái
            while (trai >= 0 && Matrix[point.Y][trai].BackgroundImage == btn.BackgroundImage)
                trai--;

            if (trai < 0 || matrix[point.Y][trai].BackgroundImage == null)
                T = 1;
            else
                T = 0;
            //Chạy qua phải
            while (phai < Cons.ChieuRongBC && Matrix[point.Y][phai].BackgroundImage == btn.BackgroundImage)
                phai++;
            if (phai >= Cons.ChieuRongBC || matrix[point.Y][phai].BackgroundImage == null)
                P = 1;
            else P = 0;
            if (Chan == 0)
                T = P = 1;
            if (phai - trai - 1 == 5 && (T == 1 || P == 1))
                return true;
            return false;
        }
        private bool ktHangDoc(Button btn)
        {
            Point point = LayViTri(btn);
            int T, D;
            int len, xuong;
            len = xuong = point.Y;

            //Chạy lên trên
            while (len >= 0 && matrix[len][point.X].BackgroundImage == btn.BackgroundImage)
                len--;
            if (len < 0 || matrix[len][point.X].BackgroundImage == null)
                T = 1;
            else
                T = 0;

            //Chạy Xuống dưới
            while (xuong < Cons.ChieuCaoBC && matrix[xuong][point.X].BackgroundImage == btn.BackgroundImage)
                xuong++;
            if (xuong >= Cons.ChieuCaoBC || matrix[xuong][point.X].BackgroundImage == null)
                D = 1;
            else D = 0;

            if (Chan == 0)
                T = D = 1;

            if (xuong - len - 1 == 5 && (T == 1 || D == 1))
                return true;
            return false;
        }
        private bool ktCheoChinh(Button btn)
        {
            Point point = LayViTri(btn);
            int T, D;
            int len, xuong, trai, phai;
            len = xuong = point.Y;
            trai = phai = point.X;

            //Chạy xéo lên
            while (trai >= 0 && len >= 0 && matrix[len][trai].BackgroundImage == btn.BackgroundImage)
            {
                trai--;
                len--;
            }

            if (len < 0 || trai < 0)
                T = 1;
            else if (matrix[len][trai].BackgroundImage == null)
                T = 1;
            else
                T = 0;

            //Chay xéo xuống
            while (phai < Cons.ChieuRongBC && xuong < Cons.ChieuCaoBC &&
                matrix[xuong][phai].BackgroundImage == btn.BackgroundImage)
            {
                phai++;
                xuong++;
            }
            if (phai >= Cons.ChieuRongBC || xuong >= Cons.ChieuCaoBC || matrix[xuong][phai].BackgroundImage == null)
                D = 1;
            else
                D = 0;

            if (Chan == 0)
                T = D = 1;

            if (phai - trai - 1 == 5 && (T == 1 || D == 1))
                return true;
            return false;
        }
        private bool ktCheoPhu(Button btn)
        {
            Point point = LayViTri(btn);
            int T, D;
            int len, xuong, trai, phai;
            len = xuong = point.Y;
            trai = phai = point.X;

            //Chạy xéo lên
            while (phai >= 0 && len >= 0 && matrix[len][phai].BackgroundImage == btn.BackgroundImage)
            {
                phai++;
                len--;
            }

            if (phai >= Cons.ChieuRongBC || len < 0)
                T = 1;
            else if (matrix[len][phai].BackgroundImage == null)
                T = 1;
            else
                T = 0;

            //Chay xéo xuống
            while (trai >= 0 && xuong < Cons.ChieuCaoBC &&
                matrix[xuong][trai].BackgroundImage == btn.BackgroundImage)
            {
                trai--;
                xuong++;
            }

            if (trai < 0 || xuong >= Cons.ChieuCaoBC)
                D = 1;
            else if (matrix[xuong][trai].BackgroundImage == null)
                D = 1;
            else
                D = 0;

            if (Chan == 0)
                T = D = 1;

            if (phai - trai - 1 == 5 && (T == 1 || D == 1))
                return true;
            return false;
        }

    }
    public class ButtonClickEvent:EventArgs
    {
        private Point clickedPoint;
        public Point ClickedPoint
        {
            get { return clickedPoint; }
            set { clickedPoint = value; }
        }
        public ButtonClickEvent(Point point)
        {
            this.ClickedPoint = point;
        }
    }
}
