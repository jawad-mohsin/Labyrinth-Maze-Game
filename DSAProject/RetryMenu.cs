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
    public partial class RetryMenu : Form
    {
        public RetryMenu()
        {
            InitializeComponent();
        }

        private void btn_mainmenu_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Hide();
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Quit exit = new Quit();
            exit.ShowDialog();
        }

        private void btn_retry_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_retry_MouseHover(object sender, EventArgs e)
        {
            btn_retry.ForeColor = Color.Yellow;
        }

        private void btn_retry_MouseLeave(object sender, EventArgs e)
        {
            btn_retry.ForeColor = Color.White;
        }

        private void btn_mainmenu_MouseHover(object sender, EventArgs e)
        {
            btn_mainmenu.ForeColor = Color.Yellow;
        }

        private void btn_mainmenu_MouseLeave(object sender, EventArgs e)
        {
            btn_mainmenu.ForeColor = Color.White;
        }

        private void btn_quit_MouseHover(object sender, EventArgs e)
        {
            btn_quit.ForeColor = Color.Yellow;
        }

        private void btn_quit_MouseLeave(object sender, EventArgs e)
        {
            btn_quit.ForeColor = Color.White;
        }
    }
}
