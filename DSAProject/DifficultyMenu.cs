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
    public partial class DifficultyMenu : Form
    {
        public DifficultyMenu()
        {
            InitializeComponent();
        }
        public void CallLabyrinth(int level)
        {

            Random rando = new Random();
            int rng = rando.Next(1, 4);
            Labyrinth gamlab = new Labyrinth(level, rng);
            gamlab.StartPosition = FormStartPosition.CenterParent;
            this.Hide();
            gamlab.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CallLabyrinth(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CallLabyrinth(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CallLabyrinth(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu manmen = new MainMenu();
            this.Hide();
            manmen.ShowDialog();
            this.Close();
        }

        private void btn_easy_Click(object sender, EventArgs e)
        {
           CallLabyrinth(1);
        }

        private void btn_medium_Click(object sender, EventArgs e)
        {
            CallLabyrinth(2);
        }

        private void btn_hard_Click(object sender, EventArgs e)
        {
            CallLabyrinth(3);
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }

        private void btn_return_MouseHover(object sender, EventArgs e)
        {
            btn_return.ForeColor = Color.Yellow;
        }

        private void btn_return_MouseLeave(object sender, EventArgs e)
        {
            btn_return.ForeColor = Color.White;
        }

        private void btn_hard_MouseHover(object sender, EventArgs e)
        {
            btn_hard.ForeColor = Color.Yellow;
        }

        private void btn_hard_MouseLeave(object sender, EventArgs e)
        {
            btn_hard.ForeColor = Color.White;
        }

        private void btn_easy_MouseHover(object sender, EventArgs e)
        {
            btn_easy.ForeColor = Color.Yellow;
        }

        private void btn_easy_MouseLeave(object sender, EventArgs e)
        {
            btn_easy.ForeColor = Color.White;
        }

        private void btn_medium_MouseHover(object sender, EventArgs e)
        {
            btn_medium.ForeColor = Color.Yellow;
        }

        private void btn_medium_MouseLeave(object sender, EventArgs e)
        {
            btn_medium.ForeColor = Color.White;
        }
    }
}
