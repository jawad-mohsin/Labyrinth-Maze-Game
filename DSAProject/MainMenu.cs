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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            DifficultyMenu difmen = new DifficultyMenu();
            difmen.StartPosition = FormStartPosition.CenterParent;
            this.Hide();
            difmen.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Quit quit = new Quit();
            quit.Show();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Rules instrcutions = new Rules();
            instrcutions.Show();
        }

        private void btn_start_MouseHover(object sender, EventArgs e)
        {
            btn_start.ForeColor = Color.Yellow;
        }

        private void btn_start_MouseLeave(object sender, EventArgs e)
        {
            btn_start.ForeColor = Color.White;
        }

        private void btn_quit_MouseHover(object sender, EventArgs e)
        {
            btn_quit.ForeColor = Color.Yellow;
        }

        private void btn_quit_MouseLeave(object sender, EventArgs e)
        {
            btn_quit.ForeColor = Color.White;
        }

        private void quit_btn_MouseHover(object sender, EventArgs e)
        {
            quit_btn.ForeColor = Color.Yellow;
        }

        private void quit_btn_MouseLeave(object sender, EventArgs e)
        {
            quit_btn.ForeColor = Color.White;
        }
    }
}
