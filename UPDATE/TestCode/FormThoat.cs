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
	public partial class FormThoat : Form
	{
		public FormThoat()
		{
			InitializeComponent();
		}

        private void btnCo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormThoat_Load(object sender, EventArgs e)
        {

        }
    }
}
