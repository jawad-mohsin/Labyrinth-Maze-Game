
namespace DSAProject
{
    partial class Quit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quit));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_yes = new System.Windows.Forms.Label();
            this.btn_no = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARE YOU SURE?";
            // 
            // btn_yes
            // 
            this.btn_yes.AutoSize = true;
            this.btn_yes.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yes.ForeColor = System.Drawing.Color.White;
            this.btn_yes.Location = new System.Drawing.Point(83, 64);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(55, 30);
            this.btn_yes.TabIndex = 1;
            this.btn_yes.Text = "YES";
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            this.btn_yes.MouseLeave += new System.EventHandler(this.btn_yes_MouseLeave);
            this.btn_yes.MouseHover += new System.EventHandler(this.btn_yes_MouseHover);
            // 
            // btn_no
            // 
            this.btn_no.AutoSize = true;
            this.btn_no.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_no.ForeColor = System.Drawing.Color.White;
            this.btn_no.Location = new System.Drawing.Point(220, 64);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(45, 30);
            this.btn_no.TabIndex = 2;
            this.btn_no.Text = "NO";
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            this.btn_no.MouseLeave += new System.EventHandler(this.btn_no_MouseLeave);
            this.btn_no.MouseHover += new System.EventHandler(this.btn_no_MouseHover);
            // 
            // Quit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(381, 116);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Quit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btn_yes;
        private System.Windows.Forms.Label btn_no;
    }
}