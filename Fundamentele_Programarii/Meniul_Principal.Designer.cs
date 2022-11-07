namespace Fundamentele_Programarii
{
    partial class Main_Page
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
            this.Setul1 = new System.Windows.Forms.Button();
            this.Setul2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Setul1
            // 
            this.Setul1.AutoSize = true;
            this.Setul1.BackColor = System.Drawing.Color.Gainsboro;
            this.Setul1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setul1.Location = new System.Drawing.Point(14, 101);
            this.Setul1.Margin = new System.Windows.Forms.Padding(5);
            this.Setul1.Name = "Setul1";
            this.Setul1.Size = new System.Drawing.Size(384, 242);
            this.Setul1.TabIndex = 0;
            this.Setul1.Text = "Setul 1";
            this.Setul1.UseVisualStyleBackColor = false;
            this.Setul1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Setul2
            // 
            this.Setul2.AutoSize = true;
            this.Setul2.BackColor = System.Drawing.Color.Gainsboro;
            this.Setul2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setul2.Location = new System.Drawing.Point(436, 101);
            this.Setul2.Margin = new System.Windows.Forms.Padding(5);
            this.Setul2.Name = "Setul2";
            this.Setul2.Size = new System.Drawing.Size(384, 242);
            this.Setul2.TabIndex = 1;
            this.Setul2.Text = "Setul 2";
            this.Setul2.UseVisualStyleBackColor = false;
            this.Setul2.Click += new System.EventHandler(this.Setul2_Click);
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.Setul2);
            this.Controls.Add(this.Setul1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main_Page";
            this.Text = "Fundamentele Programarii";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Setul1;
        private System.Windows.Forms.Button Setul2;
    }
}

