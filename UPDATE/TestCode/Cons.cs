using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro
{
	// KHởi tạo các hằng số
	public class Cons
	{
		public static int ChieuRongbtn = 30;		//Chiều cao, chiều dài của một button (một ô)
		public static int ChieuCaobtn = 30;

		public static int ChieuRongBC = 25;		// Số ô ngang
		public static int ChieuCaoBC = 19;		// Số ô dọc

        public static int Sumbtn = ChieuCaoBC * (ChieuRongBC - 1);  //Tổng số ô

        public static int COOL_DOWN_INTERVAL = 1000;
	}
}
