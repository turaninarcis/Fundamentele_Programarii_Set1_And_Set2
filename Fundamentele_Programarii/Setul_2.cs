using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentele_Programarii
{
    public partial class Setul_2 : Form
    {

        private static int index;
        public Setul_2()
        {
            InitializeComponent();
            AdaugaButoaneInPanou();
        }





        private void AdaugaButoaneInPanou()
        {

            for (int i = 1; i <= 17; i++)
            {
                int a = i;
                Button b = new Button();

                b.Text = "Problema " + i;
                b.TabIndex = i;
                System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
                ToolTip1.SetToolTip(b, SelecteazaEnuntProblema(i));
                b.Click += new EventHandler(OnButtonPress);
                b.Width = 200;
                b.Height = 100;
                flowLayoutPanel1.Controls.Add(b);
            }
            flowLayoutPanel1.AutoScroll = true;
        }

        public static string SelecteazaEnuntProblema(int i)
        {
            switch (i)
            {
                case 1:
                    return "Se da o secventa de n numere. Sa se determine cate din ele sunt pare. \r\n";
                case 2:
                    return "Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. ";
                case 3:
                    return "Calculati suma si produsul numerelor de la 1 la n. ";
                case 4:
                    return "Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a." +
                        "\r\nSe considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. ";
                case 5: return "Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa.\r\nSe considera ca primul element din secventa este pe pozitia 0. ";
                case 6:
                    return "Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. \r\n";
                case 7:
                    return "Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. ";
                case 8:
                    return "Determianti al n-lea numar din sirul lui Fibonacci.\n\rSirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2).\n\rExemplu: 0, 1, 1, 2, 3, 5, 8 ...";
                case 9:
                    return "Sa se determine daca o secventa de n numere este monotona.\n\rSecventa monotona = secventa monoton crescatoare sau monoton descrescatoare. ";
                case 10:
                    return "Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. ";
                case 11:
                    return "Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. ";
                case 12:
                    return "Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere.\n\rConsiderati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.\n\rDe ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. ";
                case 13:
                    return "O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul).\n\rDeterminati daca o secventa de n numere este o secventa crescatoare rotita. .";
                case 14:
                    return "O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive.\n\rDeterminati daca o secventa de n numere este o secventa monotona rotita.";
                case 15:
                    return "O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator.\n\rDe ex. 1,2,2,3,5,4,4,3 este o secventa bitonica.\n\rSe da o secventa de n numere. Sa se determine daca este bitonica. ";
                case 16:
                    return "O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul).\n\rSe da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. ";
                case 17:
                    return "Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa.\n\rDeterminati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor.\n\rDe exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. ";
                default:
                    return "Error, problem not implemented";

            }
        }

        private void OnButtonPress(object sender, System.EventArgs e)
        {
            Button button = sender as Button;
            index = button.TabIndex;
            Pagina_Probleme_Set_2 paginaProblema = new Pagina_Probleme_Set_2(index);
            paginaProblema.Show();

        }

        public static int ReturnIndexOfClickedButton()
        {
            return index;
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
