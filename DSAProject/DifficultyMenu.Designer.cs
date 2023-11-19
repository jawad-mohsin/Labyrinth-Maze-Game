
namespace DSAProject
{
    partial class DifficultyMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DifficultyMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_easy = new System.Windows.Forms.Label();
            this.btn_medium = new System.Windows.Forms.Label();
            this.btn_hard = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(218, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "CHOOSE DIFFICULTY LEVEL";
            // 
            // btn_easy
            // 
            this.btn_easy.AutoSize = true;
            this.btn_easy.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_easy.Location = new System.Drawing.Point(323, 189);
            this.btn_easy.Name = "btn_easy";
            this.btn_easy.Size = new System.Drawing.Size(117, 30);
            this.btn_easy.TabIndex = 5;
            this.btn_easy.Text = "1.      EASY";
            this.btn_easy.Click += new System.EventHandler(this.btn_easy_Click);
            this.btn_easy.MouseLeave += new System.EventHandler(this.btn_easy_MouseLeave);
            this.btn_easy.MouseHover += new System.EventHandler(this.btn_easy_MouseHover);
            // 
            // btn_medium
            // 
            this.btn_medium.AutoSize = true;
            this.btn_medium.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_medium.Location = new System.Drawing.Point(323, 237);
            this.btn_medium.Name = "btn_medium";
            this.btn_medium.Size = new System.Drawing.Size(158, 30);
            this.btn_medium.TabIndex = 6;
            this.btn_medium.Text = "2.      MEDIUM";
            this.btn_medium.Click += new System.EventHandler(this.btn_medium_Click);
            this.btn_medium.MouseLeave += new System.EventHandler(this.btn_medium_MouseLeave);
            this.btn_medium.MouseHover += new System.EventHandler(this.btn_medium_MouseHover);
            // 
            // btn_hard
            // 
            this.btn_hard.AutoSize = true;
            this.btn_hard.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hard.Location = new System.Drawing.Point(323, 283);
            this.btn_hard.Name = "btn_hard";
            this.btn_hard.Size = new System.Drawing.Size(129, 30);
            this.btn_hard.TabIndex = 7;
            this.btn_hard.Text = "3.      HARD";
            this.btn_hard.Click += new System.EventHandler(this.btn_hard_Click);
            this.btn_hard.MouseLeave += new System.EventHandler(this.btn_hard_MouseLeave);
            this.btn_hard.MouseHover += new System.EventHandler(this.btn_hard_MouseHover);
            // 
            // btn_return
            // 
            this.btn_return.AutoSize = true;
            this.btn_return.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Location = new System.Drawing.Point(346, 350);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(106, 30);
            this.btn_return.TabIndex = 8;
            this.btn_return.Text = "RETURN";
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            this.btn_return.MouseLeave += new System.EventHandler(this.btn_return_MouseLeave);
            this.btn_return.MouseHover += new System.EventHandler(this.btn_return_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(197, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 79);
            this.label2.TabIndex = 9;
            this.label2.Text = "LABYRINTH";
            // 
            // DifficultyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(796, 446);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_hard);
            this.Controls.Add(this.btn_medium);
            this.Controls.Add(this.btn_easy);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "DifficultyMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Labyrinth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btn_easy;
        private System.Windows.Forms.Label btn_medium;
        private System.Windows.Forms.Label btn_hard;
        private System.Windows.Forms.Label btn_return;
        private System.Windows.Forms.Label label2;
    }
}