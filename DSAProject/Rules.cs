using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSAProject
{
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
        }
        private void btn_got_it_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_got_it_MouseHover(object sender, EventArgs e)
        {
            btn_got_it.ForeColor = Color.Yellow;
        }

        private void btn_got_it_MouseLeave(object sender, EventArgs e)
        {
            btn_got_it.ForeColor = Color.White;
        }
    }
}
