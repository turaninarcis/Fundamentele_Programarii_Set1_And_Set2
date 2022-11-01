using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentele_Programarii
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenSet1();
        }

        private void Setul2_Click(object sender, EventArgs e)
        {

        }



        private void OpenSet1()
        {

            Setul_1 setul1 = new Setul_1();
            setul1.ShowDialog();

        }


    }
}
