
namespace DSAProject
{
    partial class RetryMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetryMenu));
            this.btn_quit = new System.Windows.Forms.Label();
            this.btn_mainmenu = new System.Windows.Forms.Label();
            this.btn_retry = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_quit
            // 
            this.btn_quit.AutoSize = true;
            this.btn_quit.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.ForeColor = System.Drawing.Color.White;
            this.btn_quit.Location = new System.Drawing.Point(146, 291);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(71, 30);
            this.btn_quit.TabIndex = 13;
            this.btn_quit.Text = "QUIT";
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            this.btn_quit.MouseLeave += new System.EventHandler(this.btn_quit_MouseLeave);
            this.btn_quit.MouseHover += new System.EventHandler(this.btn_quit_MouseHover);
            // 
            // btn_mainmenu
            // 
            this.btn_mainmenu.AutoSize = true;
            this.btn_mainmenu.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainmenu.ForeColor = System.Drawing.Color.White;
            this.btn_mainmenu.Location = new System.Drawing.Point(115, 240);
            this.btn_mainmenu.Name = "btn_mainmenu";
            this.btn_mainmenu.Size = new System.Drawing.Size(138, 30);
            this.btn_mainmenu.TabIndex = 12;
            this.btn_mainmenu.Text = "MAINMENU";
            this.btn_mainmenu.Click += new System.EventHandler(this.btn_mainmenu_Click);
            this.btn_mainmenu.MouseLeave += new System.EventHandler(this.btn_mainmenu_MouseLeave);
            this.btn_mainmenu.MouseHover += new System.EventHandler(this.btn_mainmenu_MouseHover);
            // 
            // btn_retry
            // 
            this.btn_retry.AutoSize = true;
            this.btn_retry.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retry.ForeColor = System.Drawing.Color.White;
            this.btn_retry.Location = new System.Drawing.Point(137, 184);
            this.btn_retry.Name = "btn_retry";
            this.btn_retry.Size = new System.Drawing.Size(91, 30);
            this.btn_retry.TabIndex = 11;
            this.btn_retry.Text = "RETRY";
            this.btn_retry.Click += new System.EventHandler(this.btn_retry_Click);
            this.btn_retry.MouseLeave += new System.EventHandler(this.btn_retry_MouseLeave);
            this.btn_retry.MouseHover += new System.EventHandler(this.btn_retry_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(54, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 46);
            this.label2.TabIndex = 14;
            this.label2.Text = "YOU LOOSE..!";
            // 
            // RetryMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(372, 406);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_mainmenu);
            this.Controls.Add(this.btn_retry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RetryMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Labyrinth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label btn_quit;
        private System.Windows.Forms.Label btn_mainmenu;
        private System.Windows.Forms.Label btn_retry;
        private System.Windows.Forms.Label label2;
    }
}