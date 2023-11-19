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
    public partial class Labyrinth : Form
    {
        private int points = 0;
        private Button pointercheck;
        private A_star.Astar astar;
        private Color forcolcheck;
        private int saverng = 0;
        public Labyrinth(int level, int rng)
        {
            InitializeComponent();
            forcolcheck = button58.BackColor;
            astar = new A_star.Astar(level, rng);
            saverng = rng;
            MapInit(buttons());
            Rules rulemen = new Rules();
            rulemen.ShowDialog();
        }


        public void MapInit(Button[,] buttons)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (astar.IsAWall(i, j) == true)
                    {
                        buttons[i, j].BackColor = Color.Black;
                        buttons[i, j].Enabled = false;
                    }
                }
            }
            points = 0;
            SetStart();
            SetFinish();
            Pointer(astar.startCell.row, astar.startCell.col);
        }
        public void PathPoints()
        {
            points++;
            UpdateDisplay();
        }
        public void UpdateDisplay()
        {
            lbl_moves.Text = (" " + points);
        }
        public void ConnectCheck(int row, int col)
        {
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1; j++)
                {
                    if (i >= 0 && i < 8 && j >= 0 && j < 8)
                    {
                        if (buttons()[i, j] == pointercheck)
                        {
                            CheckedAct(row, col);
                            return;
                        }
                    }
                }
            }
        }
        public void CheckedAct(int row, int col)
        {
            buttons()[row, col].BackColor = Color.Green;
            Pointer(row, col);
            PathPoints();
            if (Complete()) WinCheck();
            Retry(row, col);
        }

        public bool FailCheck(int row, int col)
        {
            bool flag = false;
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1; j++)
                {
                    if (i >= 0 && i < 8 && j >= 0 && j < 8)
                    {
                        if (buttons()[i, j].BackColor != forcolcheck) flag = true;
                        if (flag == true) flag = false;
                        else return false;
                    }
                }
            }
            return true;
        }
        public void SetStart()
        {
            buttons()[astar.startCell.row, astar.startCell.col].BackColor = Color.Red;
            buttons()[astar.startCell.row, astar.startCell.col].Enabled = false;
        }
        public void ResetMap()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    buttons()[i, j].Enabled = true;
                    if (buttons()[i, j].BackColor == Color.Green)
                    {
                        buttons()[i, j].BackColor = forcolcheck;
                    }
                }
            }
            MapInit(buttons());
            UpdateDisplay();
        }
        public void ResetWalls()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (astar.IsAWall(i, j) == true)
                    {
                        buttons()[i, j].BackColor = forcolcheck;
                        buttons()[i, j].Enabled = true;
                    }
                }
            }
        }
        public void Retry(int row, int col)
        {
            if (FailCheck(row, col) || Complete() && WinCheck() == false)
            {
                ShowRetryDialog();
                ResetMap();
            }
        }
        public void ShowRetryDialog()
        {
            RetryMenu retmen = new RetryMenu();
            retmen.StartPosition = FormStartPosition.CenterParent;
            retmen.ShowDialog();
        }
        public void ShowWinDialog()
        {
            int rng;
            while (true)
            {
                Random rando = new Random();
                rng = rando.Next(1, 4);
                if (rng != saverng)
                {
                    break;
                }
            }
            WinMenu winmen = new WinMenu();
            winmen.StartPosition = FormStartPosition.CenterParent;
            winmen.ShowDialog();
            int level = astar.level;
            ResetMap();
            ResetWalls();
            astar = new A_star.Astar(level, rng);
            MapInit(buttons());
        }
        public void SetFinish()
        {
            buttons()[astar.finishCell.row, astar.finishCell.col].BackColor = Color.Red;
        }

        public bool Complete()
        {
            if (buttons()[astar.finishCell.row, astar.finishCell.col].BackColor == Color.Green)
            {
                Finished();
                return true;
            }
            return false;
        }
        public void Finished()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    buttons()[i, j].Enabled = false;
                }
            }
        }

        public bool WinCheck()
        {
            if ((points + 1) == astar.path.Count)
            {
                ShowWinDialog();
                return true;
            }
            return false;
        }

        public void Pointer(int row, int col)
        {
            pointercheck = buttons()[row, col];
        }

        public void CheckStarted(int row, int col)
        {
            if (btn_start.Enabled == false && buttons()[row, col].BackColor != Color.Green)
            {
                ConnectCheck(row, col);
            }
        }

        public Button[,] buttons()
        {
            Button[,] buttons = new Button[8, 8];
            buttons[0, 0] = button1; buttons[0, 1] = button2; buttons[0, 2] = button3; buttons[0, 3] = button4; buttons[0, 4] = button5; buttons[0, 5] = button6; buttons[0, 6] = button7; buttons[0, 7] = button8;
            buttons[1, 0] = button16; buttons[1, 1] = button15; buttons[1, 2] = button14; buttons[1, 3] = button13; buttons[1, 4] = button12; buttons[1, 5] = button11; buttons[1, 6] = button10; buttons[1, 7] = button9;
            buttons[2, 0] = button24; buttons[2, 1] = button23; buttons[2, 2] = button22; buttons[2, 3] = button21; buttons[2, 4] = button20; buttons[2, 5] = button19; buttons[2, 6] = button18; buttons[2, 7] = button17;
            buttons[3, 0] = button32; buttons[3, 1] = button31; buttons[3, 2] = button30; buttons[3, 3] = button29; buttons[3, 4] = button28; buttons[3, 5] = button27; buttons[3, 6] = button26; buttons[3, 7] = button25;
            buttons[4, 0] = button40; buttons[4, 1] = button39; buttons[4, 2] = button38; buttons[4, 3] = button37; buttons[4, 4] = button36; buttons[4, 5] = button35; buttons[4, 6] = button34; buttons[4, 7] = button33;
            buttons[5, 0] = button48; buttons[5, 1] = button47; buttons[5, 2] = button46; buttons[5, 3] = button45; buttons[5, 4] = button44; buttons[5, 5] = button43; buttons[5, 6] = button42; buttons[5, 7] = button41;
            buttons[6, 0] = button56; buttons[6, 1] = button55; buttons[6, 2] = button54; buttons[6, 3] = button53; buttons[6, 4] = button52; buttons[6, 5] = button51; buttons[6, 6] = button50; buttons[6, 7] = button49;
            buttons[7, 0] = button64; buttons[7, 1] = button63; buttons[7, 2] = button62; buttons[7, 3] = button61; buttons[7, 4] = button60; buttons[7, 5] = button59; buttons[7, 6] = button58; buttons[7, 7] = button57;
            return buttons;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckStarted(0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckStarted(0, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckStarted(0, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckStarted(0, 3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CheckStarted(0, 4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CheckStarted(0, 5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CheckStarted(0, 6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CheckStarted(0, 7);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            CheckStarted(1, 0);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            CheckStarted(1, 1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            CheckStarted(1, 2);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CheckStarted(1, 3);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CheckStarted(1, 4);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CheckStarted(1, 5);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CheckStarted(1, 6);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CheckStarted(1, 7);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            CheckStarted(2, 0);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            CheckStarted(2, 1);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            CheckStarted(2, 2);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            CheckStarted(2, 3);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            CheckStarted(2, 4);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            CheckStarted(2, 5);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            CheckStarted(2, 6);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            CheckStarted(2, 7);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            CheckStarted(3, 0);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            CheckStarted(3, 1);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            CheckStarted(3, 2);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            CheckStarted(3, 3);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            CheckStarted(3, 4);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            CheckStarted(3, 5);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            CheckStarted(3, 6);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            CheckStarted(3, 7);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            CheckStarted(4, 0);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            CheckStarted(4, 1);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            CheckStarted(4, 2);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            CheckStarted(4, 3);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            CheckStarted(4, 4);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            CheckStarted(4, 5);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            CheckStarted(4, 6);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            CheckStarted(4, 7);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            CheckStarted(5, 0);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            CheckStarted(5, 1);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            CheckStarted(5, 2);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            CheckStarted(5, 3);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            CheckStarted(5, 4);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            CheckStarted(5, 5);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            CheckStarted(5, 6);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            CheckStarted(5, 7);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            CheckStarted(6, 0);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            CheckStarted(6, 1);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            CheckStarted(6, 2);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            CheckStarted(6, 3);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            CheckStarted(6, 4);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            CheckStarted(6, 5);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            CheckStarted(6, 6);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            CheckStarted(6, 7);
        }

        private void button64_Click(object sender, EventArgs e)
        {
            CheckStarted(7, 0);
        }

        private void button63_Click(object sender, EventArgs e)
        {
            CheckStarted(7, 1);
        }

        private void button62_Click(object sender, EventArgs e)
        {
            CheckStarted(7, 2);
        }

        private void button61_Click(object sender, EventArgs e)
        {
            CheckStarted(7, 3);
        }

        private void button60_Click(object sender, EventArgs e)
        {
            CheckStarted(7, 4);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            CheckStarted(7, 5);
        }

        private void button58_Click(object sender, EventArgs e)
        {
            CheckStarted(7, 6);
        }

        private void button57_Click(object sender, EventArgs e)
        {
            CheckStarted(7, 7);
        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (points == 0 || WinCheck() || Complete())
            {
                MainMenu manmen = new MainMenu();
                this.Hide();
                manmen.ShowDialog();
                this.Close();
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button71_Click(object sender, EventArgs e)
        {
            ResetMap();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            lbl_status.Text = "Game in Progress";
            btn_start.Enabled = false;
            btn_start.BackColor = Color.White;
            btn_start.FlatStyle = FlatStyle.Flat;
            UpdateDisplay();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Quit exit = new Quit();
            exit.ShowDialog();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ResetMap();
        }

        private void btn_mainmenu_Click(object sender, EventArgs e)
        {
            if (points == 0 || WinCheck() || Complete())
            {
                MainMenu menu = new MainMenu();
                this.Hide();
                menu.ShowDialog();
                this.Close();
            }
        }

        private void Labyrinth_Load(object sender, EventArgs e)
        {

        }

        private void btn_start_MouseHover(object sender, EventArgs e)
        {
            btn_start.ForeColor = Color.Yellow;
        }

        private void btn_start_MouseLeave(object sender, EventArgs e)
        {
            btn_start.ForeColor = Color.White;
        }

        private void btn_reset_MouseHover(object sender, EventArgs e)
        {
            btn_reset.ForeColor = Color.Yellow;
        }

        private void btn_reset_MouseLeave(object sender, EventArgs e)
        {
            btn_reset.ForeColor = Color.White;
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
