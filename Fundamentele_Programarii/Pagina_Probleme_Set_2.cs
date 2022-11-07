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
    public partial class Pagina_Probleme_Set_2 : Form
    {
        public Pagina_Probleme_Set_2(int indexulButonului)
        {
            InitializeComponent();
            Enuntul_Problemei.Text = Setul_2.SelecteazaEnuntProblema(indexulButonului);
        }



        private void ExecutareProblema(int index)
        {
            switch (index)
            {
                case 1:
                    {
                        //P1();
                        break;
                    }
                case 2:
                    {
                        //P2();
                        break;
                    }
                case 3:
                    {
                        //P3();
                        break;
                    }
                case 4:
                    {
                        //P4();
                        break;
                    }
                case 5:
                    {
                        //P5();
                        break;
                    }
                case 6:
                    {
                        //P6();
                        break;
                    }
                case 7:
                    {
                        //P7();
                        break;
                    }
                case 8:
                    {
                        //P8();
                        break;
                    }
                case 9:
                    {
                        //P9();
                        break;
                    }
                case 10:
                    {
                        //P10();
                        break;
                    }
                case 11:
                    {
                        //P11();
                        break;
                    }
                case 12:
                    {
                        //P12();
                        break;
                    }
                case 13:
                    {
                        //P13();
                        break;
                    }
                case 14:
                    {
                        //P14();
                        break;
                    }
                case 15:
                    {
                        //P15();
                        break;
                    }
                case 16:
                    {
                        //P16();
                        break;
                    }
                case 17:
                    {
                        //P17();
                        break;
                    }

                default:
                    {
                        break;
                    }
            }
        }

        private void Buton_Input_Click(object sender, EventArgs e)
        {
            ExecutareProblema(Setul_2.ReturnIndexOfClickedButton());
        }

        private void P1()
        {
            int nrPare = 0;
            int n;
        }
        #region unusedMethods
        private void Pagina_Probleme_Set_2_Load(object sender, EventArgs e)
        {

        }

        private void Date_Iesire_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
