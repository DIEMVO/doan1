using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    public class PlayInfo
    {
        private Point point;

        public Point Point
        { 
            get => point;
            set => point = value;
        }

        private int nguoichoihientai;

        public int Nguoichoihientai 
        { 
            get => nguoichoihientai; 
            set => nguoichoihientai = value; 
        }

        public PlayInfo(Point point, int nguoichoihientai)
        {
            this.Point = point;
            this.nguoichoihientai = nguoichoihientai;
        }
    }
}
