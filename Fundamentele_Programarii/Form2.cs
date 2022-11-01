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
    public partial class Setul_1 : Form
    {
        public Setul_1()
        {
            InitializeComponent();
            AdaugaButoaneInPanou();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


        }


        private void AdaugaButoaneInPanou()
        {

            for (int i = 1; i <= 21; i++)
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




        /// <summary>
        /// Afisarea enuntului problemei atunci cand tinem clickul deasupra butonului cu problema respectiva
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static string SelecteazaEnuntProblema(int i)
        {
            switch(i)
            {
                case 1:
                    return "Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. ";
                case 2:
                    return "Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile.";
                case 3:
                    return "Determinati daca n se divide cu k, unde n si k sunt date de intrare.";
                case 4: 
                    return "Detreminati daca un an y este an bisect. ";
                case 5: return "Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. ";
                case 6:
                    return "Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. ";
                case 7:
                    return "(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. ";
                case 8:
                    return "(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  ";
                case 9:
                    return "Afisati toti divizorii numarului n";
                case 10:
                    return "Test de primalitate: determinati daca un numar n este prim.";
                case 11:
                    return "Afisati in ordine inversa cifrele unui numar n. ";
                case 12:
                    return "Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. ";
                case 13:
                    return "Determianti cati ani bisecti sunt intre anii y1 si y2.";
                case 14:
                    return "Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321.";
                case 15:
                    return "Se dau 3 numere. Sa se afiseze in ordine crescatoare. ";
                case 16:
                    return "Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)";
                case 17:
                    return "Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. ";
                case 18:
                    return "Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2.";
                case 19:
                    return "Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. ";
                case 20:
                    return "Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3)." +
                        "\r\nO fractie este neperiodica daca numitorul este de forma 2^m*5^n unde m si n sunt mai mari sau egale decat 0" +
                        "\r\nO fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5. \r\n" +
                        "O fractie este periodica mixta daca se divide cu 2 si/sau 5 SI se mai divide si cu alte numere prime diferite de 2 si 5. ";
                case 21:
                    return "Ghiciti un numar intre 1 si 1024 prin intrebari de forma \"numarul este mai mare sau egal decat x?\". ";
                default:
                    return "Error, problem not implemented";

            }
        }

        /// <summary>
        /// Ia indexul butonului apasat, creaza un form cu acel index si il afiseaza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnButtonPress(object sender, System.EventArgs e)
        {
            Button button = sender as Button;
            int index = button.TabIndex;
            Problema_x paginaProblema = new Problema_x(index);
            paginaProblema.Show();

        }
    }
}
