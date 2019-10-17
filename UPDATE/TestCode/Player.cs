using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro
{
	public class Player
	{
		private string name;    // Tên người chơi
        private Image mark;     //Ký hiệu: X or O
        private SoundPlayer AmThanh; //chèn âm thanh

        public string Name	
		{
			get { return name; }
			set { name = value; }
		}

		public Image Mark
		{
			get { return mark; }
			set { mark = value; }
		}

		public SoundPlayer AmThanh1 { get => AmThanh; set => AmThanh = value; }

		public Player(string name, Image mark, SoundPlayer amthanh)		//Hàm khởi tạo 1 player
		{
			this.Name = name;
			this.Mark = mark; //ký hiệu
			this.AmThanh = amthanh;
		}
	}
}
