
namespace DSAProject
{
    partial class WinMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinMenu));
            this.label2 = new System.Windows.Forms.Label();
            this.btn_nextmap = new System.Windows.Forms.Label();
            this.btn_mainmenu = new System.Windows.Forms.Label();
            this.btn_quit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(66, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "YOU WON..!";
            // 
            // btn_nextmap
            // 
            this.btn_nextmap.AutoSize = true;
            this.btn_nextmap.BackColor = System.Drawing.Color.Transparent;
            this.btn_nextmap.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nextmap.ForeColor = System.Drawing.Color.White;
            this.btn_nextmap.Location = new System.Drawing.Point(116, 174);
            this.btn_nextmap.Name = "btn_nextmap";
            this.btn_nextmap.Size = new System.Drawing.Size(132, 30);
            this.btn_nextmap.TabIndex = 7;
            this.btn_nextmap.Text = "NEXT MAP";
            this.btn_nextmap.Click += new System.EventHandler(this.btn_nextmap_Click);
            this.btn_nextmap.MouseLeave += new System.EventHandler(this.btn_nextmap_MouseLeave);
            this.btn_nextmap.MouseHover += new System.EventHandler(this.btn_nextmap_MouseHover);
            // 
            // btn_mainmenu
            // 
            this.btn_mainmenu.AutoSize = true;
            this.btn_mainmenu.BackColor = System.Drawing.Color.Transparent;
            this.btn_mainmenu.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainmenu.ForeColor = System.Drawing.Color.White;
            this.btn_mainmenu.Location = new System.Drawing.Point(110, 232);
            this.btn_mainmenu.Name = "btn_mainmenu";
            this.btn_mainmenu.Size = new System.Drawing.Size(138, 30);
            this.btn_mainmenu.TabIndex = 8;
            this.btn_mainmenu.Text = "MAINMENU";
            this.btn_mainmenu.Click += new System.EventHandler(this.btn_mainmenu_Click);
            this.btn_mainmenu.MouseLeave += new System.EventHandler(this.btn_mainmenu_MouseLeave);
            this.btn_mainmenu.MouseHover += new System.EventHandler(this.btn_mainmenu_MouseHover);
            // 
            // btn_quit
            // 
            this.btn_quit.AutoSize = true;
            this.btn_quit.BackColor = System.Drawing.Color.Transparent;
            this.btn_quit.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.ForeColor = System.Drawing.Color.White;
            this.btn_quit.Location = new System.Drawing.Point(142, 287);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(71, 30);
            this.btn_quit.TabIndex = 9;
            this.btn_quit.Text = "QUIT";
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            this.btn_quit.MouseLeave += new System.EventHandler(this.btn_quit_MouseLeave);
            this.btn_quit.MouseHover += new System.EventHandler(this.btn_quit_MouseHover);
            // 
            // WinMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(368, 402);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_mainmenu);
            this.Controls.Add(this.btn_nextmap);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WinMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Labyrinth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btn_nextmap;
        private System.Windows.Forms.Label btn_mainmenu;
        private System.Windows.Forms.Label btn_quit;
    }
}