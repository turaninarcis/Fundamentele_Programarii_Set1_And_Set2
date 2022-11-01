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
    public partial class Problema_x : Form
    {
        public Problema_x(int indexulButonului)
        {
            InitializeComponent();
            Enuntul_Problemei.Text = Setul_1.SelecteazaEnuntProblema(indexulButonului); ;
            ExecutareProblema(indexulButonului);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Problema_x_Load(object sender, EventArgs e)
        {

        }

        private void Date_Intrare_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date_Iesire_TextChanged(object sender, EventArgs e)
        {

        }




        private void ExecutareProblema(int index)
        {
            switch (index)
            {
                case 1:
                    {
                        P1();
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                case 5:
                    {
                        break;
                    }
                case 6:
                    {
                        break;
                    }
                case 7:
                    {
                        break;
                    }
                case 8:
                    {
                        break;
                    }
                case 9:
                    {
                        break;
                    }
                case 10:
                    {
                        break;
                    }
                case 11:
                    {
                        break;
                    }
                case 12:
                    {
                        break;
                    }
                case 13:
                    {
                        break;
                    }
                case 14:
                    {
                        break;
                    }
                case 15:
                    {
                        break;
                    }
                case 16:
                    {
                        break;
                    }
                case 17:
                    {
                        break;
                    }
                case 18:
                    {
                        break;
                    }
                case 19:
                    {
                        break;
                    }
                case 20:
                    {
                        break;
                    }
                case 21:
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void P1()
        {
            char[] despartitoare = { ' ', ';', ',' };
            
            string[] numere = Date_Intrare.Text.Split(despartitoare,StringSplitOptions.RemoveEmptyEntries);
            bool trysucceeded=false;
            while (trysucceeded==false)
            try
            {
              int a = int.Parse(numere[0]);
              int b = int.Parse(numere[1]);
              trysucceeded = true;
            }
            catch(Exception e)
            {
                Date_Iesire.Text = e.Message;
                trysucceeded = false;
            }
        }

        private void Buton_Input_Click(object sender, EventArgs e)
        {

        }
    }
}
