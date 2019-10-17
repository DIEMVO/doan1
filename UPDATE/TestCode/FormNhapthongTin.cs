using GameCaro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GameCaro
{
    public partial class FormNhapthongTin : Form
    {
        public static string name1;
        public static string name2;

        public string Name11 { get => name1; set => name1 = value; }
        public  string Name21 { get => name2; set => name2 = value; }

        public FormNhapthongTin()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Name11 = Name1.Text;
            Name21 = Name2.Text;

            Form1 f = new Form1();
            f.Show();
        }

        private void FormNhapthongTin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.Name1;
        }

    }
}
