using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    public class SocketData
    {
        private int command;
        public int Command
        {
            get { return command; }
            set { command = value; }
        }
        private Point? point;
        public Point? Point
        {
            get { return point; }
            set { point = value; }
        }
        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public SocketData(int command,string message, Point? point = null)
        {
            this.Command = command;
            this.Point = point;
            this.Message = message;
        }
        public enum SocketCommand //ghi nhớ
        {
            SEND_POINT,
            NOTIFY,
            NEW_GAME,
            UNDO,
            QUIT

        }

    }
}
