namespace Fundamentele_Programarii
{
    partial class Pagina_Probleme_Set_2
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
            this.Enuntul_Problemei = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Date_Intrare = new System.Windows.Forms.TextBox();
            this.Buton_Input = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Date_Iesire = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Enuntul_Problemei
            // 
            this.Enuntul_Problemei.AutoSize = true;
            this.Enuntul_Problemei.BackColor = System.Drawing.Color.White;
            this.Enuntul_Problemei.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Enuntul_Problemei.Location = new System.Drawing.Point(12, 9);
            this.Enuntul_Problemei.MinimumSize = new System.Drawing.Size(810, 100);
            this.Enuntul_Problemei.Name = "Enuntul_Problemei";
            this.Enuntul_Problemei.Size = new System.Drawing.Size(810, 100);
            this.Enuntul_Problemei.TabIndex = 0;
            this.Enuntul_Problemei.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date de intrare";
            // 
            // Date_Intrare
            // 
            this.Date_Intrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Intrare.Location = new System.Drawing.Point(12, 154);
            this.Date_Intrare.Name = "Date_Intrare";
            this.Date_Intrare.Size = new System.Drawing.Size(423, 26);
            this.Date_Intrare.TabIndex = 2;
            // 
            // Buton_Input
            // 
            this.Buton_Input.Location = new System.Drawing.Point(12, 186);
            this.Buton_Input.Name = "Buton_Input";
            this.Buton_Input.Size = new System.Drawing.Size(75, 23);
            this.Buton_Input.TabIndex = 3;
            this.Buton_Input.Text = "Insert";
            this.Buton_Input.UseVisualStyleBackColor = true;
            this.Buton_Input.Click += new System.EventHandler(this.Buton_Input_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date de iesire";
            // 
            // Date_Iesire
            // 
            this.Date_Iesire.Location = new System.Drawing.Point(12, 289);
            this.Date_Iesire.MaximumSize = new System.Drawing.Size(419, 59);
            this.Date_Iesire.MinimumSize = new System.Drawing.Size(419, 59);
            this.Date_Iesire.Name = "Date_Iesire";
            this.Date_Iesire.Size = new System.Drawing.Size(419, 59);
            this.Date_Iesire.TabIndex = 5;
            this.Date_Iesire.TextChanged += new System.EventHandler(this.Date_Iesire_TextChanged);
            // 
            // Pagina_Probleme_Set_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.Date_Iesire);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buton_Input);
            this.Controls.Add(this.Date_Intrare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Enuntul_Problemei);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Pagina_Probleme_Set_2";
            this.Load += new System.EventHandler(this.Pagina_Probleme_Set_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Enuntul_Problemei;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Date_Intrare;
        private System.Windows.Forms.Button Buton_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Date_Iesire;
    }
}