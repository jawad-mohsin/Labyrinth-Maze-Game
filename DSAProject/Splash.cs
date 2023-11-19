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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 2;
            if (panel2.Width == 120)
            {
                label1.Text = "Loading Mazes...";
            }
            if (panel2.Width == 220)
            {
                label1.Text = "Compiling Resources...";
            }
            if (panel2.Width == 320)
            {
                label1.Text = "Finishing...";
            }
            if (panel1.Width == panel2.Width)
            {
                timer1.Stop();
                MainMenu mainmenu = new MainMenu();
                this.Hide();
                mainmenu.Show();
            }
        }
    }
}
