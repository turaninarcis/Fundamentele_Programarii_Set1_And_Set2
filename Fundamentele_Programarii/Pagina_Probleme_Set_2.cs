using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

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
                        P1();
                        break;
                    }
                case 2:
                    {
                        P2();
                        break;
                    }
                case 3:
                    {
                        P3();
                        break;
                    }
                case 4:
                    {
                        P4();
                        break;
                    }
                case 5:
                    {
                        P5();
                        break;
                    }
                case 6:
                    {
                        P6();
                        break;
                    }
                case 7:
                    {
                        P7();
                        break;
                    }
                case 8:
                    {
                        P8();
                        break;
                    }
                case 9:
                    {
                        P9();
                        break;
                    }
                case 10:
                    {
                        P10();
                        break;
                    }
                case 11:
                    {
                        P11();
                        break;
                    }
                case 12:
                    {
                        P12();
                        break;
                    }
                case 13:
                    {
                        P13();
                        break;
                    }
                case 14:
                    {
                        P14();
                        break;
                    }
                case 15:
                    {
                        P15();
                        break;
                    }
                case 16:
                    {
                        P16();
                        break;
                    }
                case 17:
                    {
                        P17();
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
            int nr = 0;
            foreach (string numar in Date_Intrare.Text.Split(' '))
            {
                if (int.TryParse(numar, out nr) && nr % 2 == 0) nrPare++;
            }
            Date_Iesire.Text = nrPare.ToString();
        }
        private void P2()
        {
            int nrNeg = 0; int zeros = 0; int positives = 0;
            int nr;
            foreach (string numar in Date_Intrare.Text.Split(' '))
            {
                if (int.TryParse(numar, out nr))
                {
                    if (nr < 0) nrNeg++;
                    else if (nr == 0) zeros++;
                    else positives++;
                }
            }
            Date_Iesire.Text = $"In sirul dat sunt {nrNeg} numere negative, {positives} numere pozitive si {zeros} numere egale cu 0";
        }
        private void P3()
        {

            int nr;
            ulong suma = 0;
            BigInteger produs = new BigInteger(1);

            if (int.TryParse(Date_Intrare.Text, out nr) && nr >= 1)
            {
                for (int i = 1; i <= nr; i++)
                { suma += (ulong)i;
                    produs *= (BigInteger)i;
                }
            }
            else Date_Iesire.Text = "Introduceti un numar mai mare sau egal cu 1.";
            Date_Iesire.Text = $"Suma numerelor de la 1 la {nr} este {suma} iar produsul este {produs}";
        }
        private void P4()
        {
            int a;
            int pozitie = -1;
            int pozitieGasita = -1;

            if (!int.TryParse(Date_Intrare.Text.Split(' ')[0], out a))
            { Date_Iesire.Text = "Nu s-a putut introduce variabila a"; return; }

            string numereText = Date_Intrare.Text.Substring(a.ToString().Length);
            foreach (string nr in numereText.Split(' '))
            {

                if (int.TryParse(nr, out int aux))
                {
                    pozitie++;
                    if (aux == a) { pozitieGasita = pozitie; break; }
                }
            }
            Date_Iesire.Text = pozitieGasita.ToString();
        }
        private void P5()
        {
            int numere = 0;
            int pozitie = -1;

            foreach (string nr in Date_Intrare.Text.Split(' '))
            {

                if (int.TryParse(nr, out int aux))
                {
                    pozitie++;
                    if (aux == pozitie) { numere++; }
                }
            }
            Date_Iesire.Text = numere.ToString();
        }
        private void P6()
        {
            int? nr = null;
            bool crescatoare = true;
            foreach (string numar in Date_Intrare.Text.Split(' '))
            {
                if (int.TryParse(numar, out int aux))
                {
                    if (nr == null) nr = aux;
                    else if (nr > aux) { crescatoare = false; break; }
                    nr = aux;
                }
            }
            if (crescatoare) { Date_Iesire.Text = "Sirul este crescator"; }
            else Date_Iesire.Text = "Sirul nu este crescator";
        }
        private void P7()
        {
            int max = int.MinValue; int min = int.MaxValue;
            foreach (string numar in Date_Intrare.Text.Split(' '))
            {
                if (int.TryParse(numar, out int aux))
                {
                    if (max < aux) max = aux;
                    if (min > aux) min = aux;
                }
            }
            Date_Iesire.Text = $"Minimul sirului este {min} iar maximul sirului este {max}";
        }
        private void P8()
        {
            int n;
            if (int.TryParse(Date_Intrare.Text, out n) && n == 1)
                Date_Iesire.Text = "Primul element din sirul lui Fibonacci este " + Fibonacci(n - 1).ToString();
            else if (n > 1) Date_Iesire.Text = $"Al {n}-lea element din sirul lui Fibonacci este " + Fibonacci(n - 1).ToString();
            else Date_Iesire.Text = "Nu s-a putut efectua operatia, verificati datele de intrare";

        }
        private void P9()
        {
            int? nr = null;
            bool? crescatoare = null;
            bool monotona = true;
            foreach (string numar in Date_Intrare.Text.Split(' '))
            {
                if (int.TryParse(numar, out int aux))
                {
                    if (nr == null) nr = aux;
                    else if (nr > aux)
                    {
                        if (crescatoare == null) crescatoare = false;//daca nu s-a determinat inca monotonia sirului, spunem ca este descrescatoare
                        else if (crescatoare == true) { monotona = false; break; }//daca s-a aflat ca este crescatoare deja spunem ca nu este monotona
                    }
                    else if (nr < aux)
                    {
                        if (crescatoare == null) crescatoare = true;//daca nu s-a determinat inca monotonia sirului, spunem ca este crescatoare
                        else if (crescatoare == false) { monotona = false; break; }//daca s-a aflat ca este descrescatoare deja spunem ca nu este monotona
                    }
                    else { monotona = false; break; }//daca numerele sunt egale, stim din start faptul ca nu este monoton
                    nr = aux;
                }
            }
            if (crescatoare == true && monotona) { Date_Iesire.Text = "Sirul este strict crescator"; }
            else if (crescatoare == false && monotona) { Date_Iesire.Text = "Sirul este strict descrescator"; }
            else Date_Iesire.Text = "Sirul nu este monoton";
        }
        private void P10()
        {
            int? nrConsecutiveMax = null;
            int nrConsecutive = 0;
            int? nrPrecedent = null;
            foreach (string nr in Date_Intrare.Text.Split(' '))
            {

                if (int.TryParse(nr, out int aux))
                {
                    if (nrPrecedent == null) nrPrecedent = aux;
                    else if (nrPrecedent == aux) nrConsecutive++;
                    else
                    {
                        if (nrConsecutiveMax == null) nrConsecutiveMax = nrConsecutive;
                        else if (nrConsecutiveMax < nrConsecutive) { nrConsecutiveMax = nrConsecutive; }
                        nrConsecutive = 1;
                    }
                    nrPrecedent = aux;
                }

            }
            if (nrConsecutiveMax < nrConsecutive) nrConsecutiveMax = nrConsecutive;
            Date_Iesire.Text = nrConsecutiveMax.ToString();

        }

        private void P11()
        {
            int suma = 0;
            foreach (string numar in Date_Intrare.Text.Split(' '))
            {

                if (int.TryParse(numar, out int aux))
                {
                    int nrInversat = 0;

                    while (aux != 0)
                    {
                        nrInversat = nrInversat * 10 + aux % 10;
                        aux /= 10;
                    }
                    suma += nrInversat;
                }
            }
            Date_Iesire.Text = suma.ToString();
        }

        private void P12()
        {
            bool consecutive = true; ;
            int? previousNumber = null;
            int grupuriNrConsecutive = 0;
            foreach (string numar in Date_Intrare.Text.Split(',', ' '))
            {

                if (int.TryParse(numar, out int aux))
                {
                    if (aux == 0)
                    {
                        if (previousNumber != null && consecutive == true) grupuriNrConsecutive++;
                        previousNumber = null;
                        continue;
                    }
                    if (previousNumber == null) { previousNumber = aux; consecutive = true; }
                    else if (previousNumber >= aux) consecutive = false;
                    previousNumber = aux;
                }
            }
            if (previousNumber !=null) grupuriNrConsecutive++;
            Date_Iesire.Text = grupuriNrConsecutive.ToString();
        }

        private void P13()
        {
            bool? EsteADouaSecventaCrescatoare=null;
            int? primulElementAlSirului=null;
            int? ultimulElementAlSirului=null;
            foreach (string numar in Date_Intrare.Text.Split(',', ' '))
            {

                if (int.TryParse(numar, out int aux))
                {
                    if(ultimulElementAlSirului!=null)
                        if(ultimulElementAlSirului>aux && EsteADouaSecventaCrescatoare == null)
                            EsteADouaSecventaCrescatoare= true;
                        else if(ultimulElementAlSirului>aux&&EsteADouaSecventaCrescatoare!=null){ Date_Iesire.Text = "Secventa nu poate deveni una crescatoare prin rotire";EsteADouaSecventaCrescatoare = false; break; }


                    if(primulElementAlSirului==null) primulElementAlSirului= aux;
                    ultimulElementAlSirului= aux;
                }
            }
            if(EsteADouaSecventaCrescatoare==null) { Date_Iesire.Text = "Secventa poate deveni una crescatoare prin rotire"; }

            else if(primulElementAlSirului>=ultimulElementAlSirului&&EsteADouaSecventaCrescatoare==true)
            {
                Date_Iesire.Text = "Secventa poate deveni una crescatoare prin rotire";
            }
            else if(primulElementAlSirului < ultimulElementAlSirului && EsteADouaSecventaCrescatoare==true)
                Date_Iesire.Text = "Secventa nu poate deveni una crescatoare prin rotire";
        }
        private void P14()
        {
            Date_Iesire.Text = "";
            bool? EstePrimaSecventaCrescatoare = null;
            bool? EsteADouaSecventaCrescatoare = null;
            bool saTerminatPrimulSir = false;
            bool EsteMonotona = true;
            int? primulElementAlSirului = null;
            int? ultimulElementAlSirului = null;
            foreach (string numar in Date_Intrare.Text.Split(',', ' '))
            {

                if (int.TryParse(numar, out int aux))
                {
                    if (ultimulElementAlSirului != null)
                    {
                        if (ultimulElementAlSirului == aux) { EsteMonotona = false; break; }


                        if (EstePrimaSecventaCrescatoare == null)
                        {
                            if (ultimulElementAlSirului > aux)
                                EstePrimaSecventaCrescatoare = false;

                            else if (ultimulElementAlSirului < aux)
                                EstePrimaSecventaCrescatoare = true;
                        }

                        else if (EstePrimaSecventaCrescatoare == true && saTerminatPrimulSir == false)
                        {
                            if (ultimulElementAlSirului > aux)
                                saTerminatPrimulSir = true;
                        }
                        else if (EstePrimaSecventaCrescatoare == false && saTerminatPrimulSir == false)
                        {
                            if (ultimulElementAlSirului < aux)
                                saTerminatPrimulSir = true;
                        }

                        else if (saTerminatPrimulSir == true && EsteADouaSecventaCrescatoare == null)
                        {
                            if (ultimulElementAlSirului < aux)
                                EsteADouaSecventaCrescatoare = true;
                            else EsteADouaSecventaCrescatoare = false;
                        }

                        else if (EsteADouaSecventaCrescatoare != null)
                        {
                            if (ultimulElementAlSirului > aux && EsteADouaSecventaCrescatoare == true) { EsteMonotona = false; break; }
                            else if (ultimulElementAlSirului < aux && EsteADouaSecventaCrescatoare == false) {EsteMonotona = false; break;}

                        }
                    }

                    if (primulElementAlSirului == null) primulElementAlSirului = aux;
                    ultimulElementAlSirului = aux;
                }
            }
            if (!EsteMonotona) Date_Iesire.Text = "Secventa nu poate deveni una monotona prin rotire";
            else if (EsteADouaSecventaCrescatoare == null) { Date_Iesire.Text = "Secventa poate deveni una monotona prin rotire"; }
            else if (primulElementAlSirului > ultimulElementAlSirului&& EsteADouaSecventaCrescatoare == true|| primulElementAlSirului < ultimulElementAlSirului && EsteADouaSecventaCrescatoare == false)
            {
                Date_Iesire.Text = "Secventa poate deveni una monotona prin rotire";
            }
            else Date_Iesire.Text = "Secventa nu poate deveni una monotona prin rotire";

        }
        private void P15()
        {
            Date_Iesire.Text = "";
            bool? EstePrimaSecventaCrescatoare = null;
            bool? EsteADouaSecventaDescrescatoare = null;
            int? ultimulElementAlSirului = null;
            foreach (string numar in Date_Intrare.Text.Split(',', ' '))
            {

                if (int.TryParse(numar, out int aux))
                {
                    if (ultimulElementAlSirului != null)
                    {
                        if (EstePrimaSecventaCrescatoare == null)
                        {
                            if (ultimulElementAlSirului >= aux) { EstePrimaSecventaCrescatoare = false; break; }
                            else EstePrimaSecventaCrescatoare = true;
                        }
                        else if (EsteADouaSecventaDescrescatoare == null)
                        {
                            if (ultimulElementAlSirului > aux)
                                EsteADouaSecventaDescrescatoare = true;
                        }
                        else if (EsteADouaSecventaDescrescatoare == true && ultimulElementAlSirului < aux)
                        { EsteADouaSecventaDescrescatoare = false; break; }
                    }
                    ultimulElementAlSirului = aux;
                }
            }
            if (EstePrimaSecventaCrescatoare == true && EsteADouaSecventaDescrescatoare == true)
                Date_Iesire.Text = "Secventa data este una bitonica";
            else Date_Iesire.Text = "Secventa data nu este una bitonica";

        }

        private void P16()
        {
            Date_Iesire.Text = "";
            bool? EstePrimaSecventaCrescatoare = null;
            bool? EsteADouaSecventaCrescatoare = null;
            bool saTerminatPrimulSir = false;
            bool EsteBitonica = true;
            int? primulElementAlSirului = null;
            int? ultimulElementAlSirului = null;
            foreach (string numar in Date_Intrare.Text.Split(',', ' '))
            {

                if (int.TryParse(numar, out int aux))
                {
                    if (ultimulElementAlSirului != null)
                    {
                        if (EstePrimaSecventaCrescatoare == null)
                        {
                            if (ultimulElementAlSirului > aux)
                                EstePrimaSecventaCrescatoare = false;

                            else if (ultimulElementAlSirului < aux)
                                EstePrimaSecventaCrescatoare = true;
                        }

                        else if (EstePrimaSecventaCrescatoare == true && saTerminatPrimulSir == false)
                        {
                            if (ultimulElementAlSirului > aux)
                                saTerminatPrimulSir = true;
                        }
                        else if (EstePrimaSecventaCrescatoare == false && saTerminatPrimulSir == false)
                        {
                            if (ultimulElementAlSirului < aux)
                                saTerminatPrimulSir = true;
                        }

                        else if (saTerminatPrimulSir == true && EsteADouaSecventaCrescatoare == null)
                        {
                            if (ultimulElementAlSirului < aux)
                                EsteADouaSecventaCrescatoare = true;
                            else EsteADouaSecventaCrescatoare = false;
                        }

                        else if (EsteADouaSecventaCrescatoare != null)
                        {
                            if (ultimulElementAlSirului > aux && EsteADouaSecventaCrescatoare == true&&aux<primulElementAlSirului) { EsteBitonica = false; break; }
                            else if (ultimulElementAlSirului < aux && EsteADouaSecventaCrescatoare == false&&aux>primulElementAlSirului) { EsteBitonica = false; break; }

                        }
                    }

                    if (primulElementAlSirului == null) primulElementAlSirului = aux;
                    ultimulElementAlSirului = aux;
                }

               
            }

            if (EsteBitonica == false)
            {
                Date_Iesire.Text = "Secventa nu poate deveni una bitonica prin rotire";
            }
            else if (EstePrimaSecventaCrescatoare == true && EsteADouaSecventaCrescatoare == false || EstePrimaSecventaCrescatoare == false && EsteADouaSecventaCrescatoare == true)
            {
                Date_Iesire.Text = "Secventa poate deveni una bitonica prin rotire";
            }
            else
                Date_Iesire.Text = "Secventa nu poate deveni una bitonica prin rotire";


        }

        private void P17()
        {
            int numberOfOpenBrackets = 0;
            int maxNumberOfOpenBrackets = 0;
            int lastNumber=0;

            foreach (string nr in Date_Intrare.Text.Split(' '))
            {

                if (int.TryParse(nr, out int aux))
                {
                    if (aux == 0) { numberOfOpenBrackets++; lastNumber = aux; }
                    else if (aux == 1) { numberOfOpenBrackets--; lastNumber = aux; }
                    if(numberOfOpenBrackets>maxNumberOfOpenBrackets) { maxNumberOfOpenBrackets=numberOfOpenBrackets; }
                    if (numberOfOpenBrackets < 0) { Date_Iesire.Text = "Secventa introdusa nu reprezinta o secventa de paranteze corecta"; return; }
                }
                
            }
            if (numberOfOpenBrackets == 0&&lastNumber==1) { Date_Iesire.Text = maxNumberOfOpenBrackets.ToString(); }
            else Date_Iesire.Text = "Secventa introdusa nu reprezinta o secventa de paranteze corecta";
            
        }

        private int Fibonacci(int n)
        {
            if(n <= 0) return 0;
            if (n == 1) return 1;
            else return Fibonacci(n- 1)+Fibonacci(n-2);
        }
        #region unusedMethods
        private void Pagina_Probleme_Set_2_Load(object sender, EventArgs e)
        {

        }

        private void Date_Iesire_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void Enuntul_Problemei_Click(object sender, EventArgs e)
        {

        }
    }
}
