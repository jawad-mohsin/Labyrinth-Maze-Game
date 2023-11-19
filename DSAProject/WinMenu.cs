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
    public partial class WinMenu : Form
    {
        public WinMenu()
        {
            InitializeComponent();
        }

        private void btn_nextmap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mainmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Quit exit = new Quit();
            exit.ShowDialog();
        }

        private void btn_nextmap_MouseHover(object sender, EventArgs e)
        {
            btn_nextmap.ForeColor = Color.Yellow;
        }

        private void btn_nextmap_MouseLeave(object sender, EventArgs e)
        {
            btn_nextmap.ForeColor = Color.White;
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
