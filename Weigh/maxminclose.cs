using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weigh1;

namespace Weigh
{
    public partial class maxminclose : UserControl
    {
        public maxminclose()
        {
            InitializeComponent();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Text = "退出";
        }

        private void maxminclose_Load(object sender, EventArgs e)
        {
            button2.Text = Token.nickname;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Text = Token.nickname;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Close();
        }
    }
}
