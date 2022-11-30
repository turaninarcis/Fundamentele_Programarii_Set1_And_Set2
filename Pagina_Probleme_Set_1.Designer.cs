namespace Fundamentele_Programarii
{
    partial class Problema_Set_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Problema_Set_1));
            this.Enuntul_Problemei = new System.Windows.Forms.Label();
            this.Date_Intrare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Date_Iesire = new System.Windows.Forms.TextBox();
            this.Buton_Input = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Enuntul_Problemei
            // 
            this.Enuntul_Problemei.AutoSize = true;
            this.Enuntul_Problemei.BackColor = System.Drawing.Color.White;
            this.Enuntul_Problemei.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enuntul_Problemei.Location = new System.Drawing.Point(12, 9);
            this.Enuntul_Problemei.MaximumSize = new System.Drawing.Size(810, 0);
            this.Enuntul_Problemei.MinimumSize = new System.Drawing.Size(810, 100);
            this.Enuntul_Problemei.Name = "Enuntul_Problemei";
            this.Enuntul_Problemei.Size = new System.Drawing.Size(810, 100);
            this.Enuntul_Problemei.TabIndex = 0;
            this.Enuntul_Problemei.Text = resources.GetString("Enuntul_Problemei.Text");
            this.Enuntul_Problemei.Click += new System.EventHandler(this.Enuntul_Problemei_Click);
            // 
            // Date_Intrare
            // 
            this.Date_Intrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Intrare.Location = new System.Drawing.Point(12, 154);
            this.Date_Intrare.Name = "Date_Intrare";
            this.Date_Intrare.Size = new System.Drawing.Size(423, 26);
            this.Date_Intrare.TabIndex = 1;
            this.Date_Intrare.TextChanged += new System.EventHandler(this.Date_Intrare_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date de intrare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date de iesire";
            // 
            // Date_Iesire
            // 
            this.Date_Iesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Iesire.Location = new System.Drawing.Point(12, 288);
            this.Date_Iesire.MaximumSize = new System.Drawing.Size(419, 59);
            this.Date_Iesire.MinimumSize = new System.Drawing.Size(419, 59);
            this.Date_Iesire.Multiline = true;
            this.Date_Iesire.Name = "Date_Iesire";
            this.Date_Iesire.ReadOnly = true;
            this.Date_Iesire.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Date_Iesire.Size = new System.Drawing.Size(419, 59);
            this.Date_Iesire.TabIndex = 4;
            this.Date_Iesire.TextChanged += new System.EventHandler(this.Date_Iesire_TextChanged);
            // 
            // Buton_Input
            // 
            this.Buton_Input.Location = new System.Drawing.Point(12, 187);
            this.Buton_Input.Name = "Buton_Input";
            this.Buton_Input.Size = new System.Drawing.Size(75, 23);
            this.Buton_Input.TabIndex = 5;
            this.Buton_Input.Text = "Insert ";
            this.Buton_Input.UseVisualStyleBackColor = true;
            this.Buton_Input.Click += new System.EventHandler(this.Buton_Input_Click);
            // 
            // Problema_Set_1
            // 
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.Buton_Input);
            this.Controls.Add(this.Date_Iesire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date_Intrare);
            this.Controls.Add(this.Enuntul_Problemei);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Problema_Set_1";
            this.Load += new System.EventHandler(this.Problema_x_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnuntulProblemei;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_Date_Iesire;
        private System.Windows.Forms.Label Enuntul_Problemei;
        private System.Windows.Forms.TextBox Date_Intrare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Date_Iesire;
        private System.Windows.Forms.Button Buton_Input;
    }
}