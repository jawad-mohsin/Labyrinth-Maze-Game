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
    public partial class Quit : Form
    {
        public Quit()
        {
            InitializeComponent();
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_yes_MouseHover(object sender, EventArgs e)
        {
            btn_yes.ForeColor = Color.Yellow;
        }

        private void btn_yes_MouseLeave(object sender, EventArgs e)
        {
            btn_yes.ForeColor = Color.White;
        }

        private void btn_no_MouseHover(object sender, EventArgs e)
        {
            btn_no.ForeColor = Color.Yellow;
        }

        private void btn_no_MouseLeave(object sender, EventArgs e)
        {
            btn_no.ForeColor = Color.White;
        }
    }
}
