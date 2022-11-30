using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentele_Programarii
{
    public partial class Problema_Set_1 : Form
    {
        static Random rnd = new Random();
        int NumberToGuess = rnd.Next(1, 1024);
        static bool aReusit;
        public Problema_Set_1(int indexulButonului)
        {
            InitializeComponent();
            Enuntul_Problemei.Text = Setul_1.SelecteazaEnuntProblema(indexulButonului);            
        }
        private void Buton_Input_Click(object sender, EventArgs e)
        {
            ExecutareProblema(Setul_1.ReturnIndexOfClickedButton());
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
                case 18:
                    {
                        P18();
                        break;
                    }
                case 19:
                    {
                        P19();
                        break;
                    }
                case 20:
                    {
                        P20();
                        break;
                    }
                case 21:
                    {
                        P21();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }



#region methodeleProblemelor



        private void P1()
        {
            int a, b;
            double x;
            a = 0; b = 0;
            try
            { 
                (a, b) = IntroducereDate(a, b);
            }
            catch(Exception)
            {
                return;
            }
            x = -b / (float)a;
            Date_Iesire.Text = x.ToString();
        }

        private void P2()
        {
            int a, b, c;
            double x1=1, x2=1;
            a = b = c = 1;
            try
            {
                (a,b,c) = IntroducereDate(a, b,c);
            }
            catch(Exception)
            {
                return;
            }
            int delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                x2 = (-b - Math.Sqrt(delta)) / 2 * a;
            }
            else if (delta == 0)
            {
                x1 = x2 = (-b / 2 * a);
            }

            if (delta < 0) Date_Iesire.Text = $"x1=({-b}+{Math.Sqrt(Math.Abs(delta))}i)/{2 * a}\r\n" +
                                              $"x2=({-b}-{Math.Sqrt(Math.Abs(delta))}i)/{2 * a}";
            else Date_Iesire.Text = $"x1={x1} \r\n"+$"x2={x2}";



        }


        private void P3()
        {
            int n=1, k=1;
            try 
            { 
            (n, k) = IntroducereDate(n, k);
            }
            catch(Exception)
            {
                return;
            }
            if (n % k == 0)
                Date_Iesire.Text = $"{n} se divide cu {k}";
            else Date_Iesire.Text = $"{n} nu se divide cu {k}";
        }


        private void P4()
        {
            int a = 1;
            try 
            {
                a = IntroducereDate(a);
            }
            catch (Exception) { return; }

            if (EsteAnBisect(a))
                Date_Iesire.Text = $"{a} este an bisect";
            else Date_Iesire.Text = $"{a} nu este an bisect";
        }


        private void P5()
        {
            int n = 1;int k = 1;
            try
            {
                (n, k) = IntroducereDate(n, k);
            }
            catch (Exception) { return; }
            int n2 = n;

            for(int i = 1; i < k; i++)
            {
                n2 /= 10;
            }
            int c = n2 % 10;
            Date_Iesire.Text = $"A {k}-a cifra a numarului {n} este {c}";
        }


        private void P6()
        {
            int a, b, c;
            a = b = c = 1;
            try 
            {
                (a, b, c) = IntroducereDate(a, b, c);
            }
            catch(Exception) { return; }

            if(a<0||b<0||c<0)
            {
                Date_Iesire.Text = "Toate numerele trebuie sa fie pozitive";
                return;
            }
            int maxim = Math.Max(a, Math.Max(b, c));
            if (maxim < a + b + c - maxim)
            {
                Date_Iesire.Text = "Laturile pot forma un triunghi";
            }
            else Date_Iesire.Text = $"Laturile nu pot forma un triunghi deoarece {maxim} nu este mai mic decat suma celorlaltor doua laturi";


        }

        private void P7()
        {
            int a, b,aux;
            a = b = 1;
            try { (a, b) = IntroducereDate(a, b); }
            catch(Exception) { return; }
            aux = a;
            a = b;
            b = aux;
            Date_Iesire.Text = $"In (a) s-a stocat valoarea {a} iar in (b) s-a stocat valoarea {b}.";
        }


        private void P8()
        {
            int a, b;
            a = b = 1;
            try { (a, b) = IntroducereDate(a, b); }
            catch (Exception) { return; }
            a = a + b;
            b = a - b;
            a = a - b;
            Date_Iesire.Text = $"In (a) s-a stocat valoarea {a} iar in (b) s-a stocat valoarea {b}.";
        }

        private void P9()
        {
            int n;
            n = 1;
            try { n = IntroducereDate(n); }
            catch (Exception) { return; }

            Date_Iesire.Text = "";
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    Date_Iesire.Text += $"{i} ";
        }

        private void P10()
        {
            int n;
            n = 1;
            try { n = IntroducereDate(n); }
            catch(Exception) { return; }
            bool isPrime = true;
            if(n<2) isPrime = false;
            else if(n==2) isPrime = true;
            else if(n%2==0) isPrime = false;
            else
                for(int i = 3; i*i < n; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

            if (isPrime)
                Date_Iesire.Text = $"Numarul {n} este prim";
            else Date_Iesire.Text = $"Numarul {n} nu este prim";
        }

        private void P11()
        {
            int n, oglindit=0;
            n = 1;
            try { n = IntroducereDate(n); }
            catch (Exception) { return; }
            oglindit = Oglindit(n);

            Date_Iesire.Text = $"Cifrele numarului n in ordine inversa sunt: {oglindit}";
        }

        private void P12()
        {
            Date_Iesire.Text = "";
            int n, a, b;
            a = b = n = 1;
            try { (n, a, b) = IntroducereDate(n, a, b); }
            catch(Exception) { return; }
            int nrDivizibile = 0;

            for(int i =a;i<=b;i++)
            {
                if (i % n == 0)
                {
                    nrDivizibile++;
                }
            }
            Date_Iesire.Text += $"In intervalul [{a},{b}] sunt {nrDivizibile} numere divizibile cu {n}";
        }
        
        private void P13()
        {
            int y1, y2,nrAniBisecti=0;
            y1 = y2 = 1;
            
            try { (y1, y2) = IntroducereDate(y1, y2); }
            catch(Exception) { return; }
            for(int i = y1;i<=y2;i++)
            {
                if(EsteAnBisect(i))
                    nrAniBisecti++;
            }
            Date_Iesire.Text = $"Intre anul {y1} si anul {y2} sunt {nrAniBisecti} ani bisecti";
        }

        private void P14()
        {
            int n = 1;
            try { n = IntroducereDate(n); }
            catch(Exception) { return; }


            if (n == Oglindit(n))
                Date_Iesire.Text = $"Numarul {n} este palindrom";
            else Date_Iesire.Text = $"Numarul {n} nu este palindrom";

        }
        
        private void P15()
        {
            int a, b, c;
            a = b = c = 1;
            try { (a, b, c) = IntroducereDate(a, b, c); }
            catch (Exception) { return; }
            int min, max;
            min = Math.Min(a, Math.Min(b, c));
            max = Math.Max(a, Math.Max(b, c));
            Date_Iesire.Text = $"Numerele in ordine crescatoare sunt: {min}, {a+b+c-min-max}, {max}";

        }

        private void P16()
        {
            int a, b, c, d, e,aux;
            a = b = c = d = e = 1;
            try { (a, b, c, d, e) = IntroducereDate(a, b, c, d, e); }
            catch(Exception) { return; }
            bool suntAmestecate = true;

            while(suntAmestecate)
            {
                suntAmestecate = false;
                if (a > b) { suntAmestecate = true; aux = a;a = b;b = aux; }
                if(b>c) { suntAmestecate = true; aux = b;b = c;c = aux; }
                if (c > d) { suntAmestecate = true;aux = c;c = d;d = aux; }
                if(d>e) { suntAmestecate = true; aux = d;d = e;e = aux; }
            }

            Date_Iesire.Text = $"Numerele in ordine crescatoare sunt:{a}, {b}, {c}, {d}, {e}";
        }

        private void P17()
        {
            int a, b,a1,b1;
            a = b = 1;
            try { (a, b) = IntroducereDate(a, b); }
            catch (Exception) { return; }
            a1 = a; b1 = b;
            while(a1!=0&& b1!=0)
            {
                if (a1 > b1) { a1 = a1 - b1; }
                else b1 = b1 - a1;
            }
            Date_Iesire.Text = $"Cel mai mare divizor comun al numerelor {a} si {b} este {a1+b1} iar cel mai mic multiplu comun este {(a*b)/(a1+b1)}";
        }

        private void P18()
        {
            int aparitiiFactorPrim;
            int n = 1;
            try { n = IntroducereDate(n); }
            catch (Exception) { return; }
            int n2 = n;
            int i = 2;
            string descompunere = "";
            while (n2!=1)
            {
                aparitiiFactorPrim = 0;
                while(n2%i==0)    
                {
                    aparitiiFactorPrim++;
                    n2 /= i;

                }
                if(aparitiiFactorPrim!=0)
                {
                    descompunere += $"x {i}^{aparitiiFactorPrim} ";
                }
                i++;
            }

            Date_Iesire.Text = $"Descompunerea in factori primi a numarului {n} este: {descompunere.Substring(1)}";
        }

        private void P19()
        {
            int n = 1;
            try { n = IntroducereDate(n); }
            catch(Exception) { return; }
            int[] cifre = new int[10];
            int n2 = n;
            int nrdistincte = 0;
            while(n2!=0)
            {
                cifre[n2%10]++;
                n2 /= 10;
            }
            for(int i = 0; i<10; i++)
            {
                if (cifre[i] != 0) nrdistincte++;
            }
            if (nrdistincte == 2)
                Date_Iesire.Text = $"Numarul {n} este format doar din doua cifre distincte care se pot repeta";
            else Date_Iesire.Text = $"Numarul {n} nu este format doar din doua cifre distincte care se pot repeta";
        }
        private void P20()
        {
            Date_Iesire.Text = "";
            int m, n;
            m = n = 0;
            try { (m, n) = IntroducereDate(m, n); }
            catch(Exception) { return; }
            double d;

            int parteInt, parteFract;
            parteInt = m / n; // 0
            parteFract = m % n; // 13
            Date_Iesire.Text += $"{parteInt}.";
            int cifra, rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(parteFract);
            bool periodic = false;
            do
            {
                cifra = parteFract * 10 / n;
                cifre.Add(cifra);
                rest = parteFract * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }
                parteFract = rest;
            } while (rest != 0);

            if (!periodic)
            {
                foreach (var item in cifre)
                {
                    Date_Iesire.Text += item;
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Date_Iesire.Text += "(";
                    }
                    Date_Iesire.Text += cifre[i]; ;
                }
                Date_Iesire.Text += ")" ;
            }
        


    }
        private void P21()
        {
            int n = 1;
            try { n = IntroducereDate(n); }
            catch (Exception) { return; }
            if (n < NumberToGuess)
                Date_Iesire.Text = "Numarul este mai mare";
            else if (n == NumberToGuess) Date_Iesire.Text = "Ai ghicit numarul";
            else if (n>NumberToGuess) Date_Iesire.Text = "Numarul este mai mic";
            
            
        }
        #endregion




        #region methodeAjutatoare
        private int IntroducereDate(int a)
        {
            char[] despartitoare = { ' ', ';', ',' };
            aReusit = true;

            try
            {
                string[] numere = Date_Intrare.Text.Split(despartitoare, StringSplitOptions.RemoveEmptyEntries);
                if (numere.Length > 1)
                    throw new IndexOutOfRangeException();

                a = int.Parse(numere[0]);

            }
            catch (FormatException)
            {
                ExceptionSentence("Trebuie introduse doar un numar");
            }
            catch (OverflowException)
            {
                ExceptionSentence($"Trebuie introdus un numar mai mare decat {int.MinValue} si mai mic decat {int.MaxValue}");
            }
            catch (IndexOutOfRangeException)
            {
                ExceptionSentence("Trebuie introdus un singur numar");
            }
            catch (Exception e)
            {
                ExceptionSentence(e.Message);
            }
            if (aReusit)
                return a;
            else throw new Exception();



        }
        private (int,int) IntroducereDate(int a,int b)
        {
            char[] despartitoare = { ' ', ';', ',' };
            aReusit = true;
            
                try
                {
                    string[] numere = Date_Intrare.Text.Split(despartitoare, StringSplitOptions.RemoveEmptyEntries);
                    if (numere.Length > 2)
                        throw new IndexOutOfRangeException();
                        
                    a = int.Parse(numere[0]);
                    b = int.Parse(numere[1]);
                    
                }
                catch(FormatException)
                {
                ExceptionSentence("Trebuie introduse doar numere");
                }
                catch(OverflowException)
                {
                ExceptionSentence($"Trebuie introduse numere mai mari decat {int.MinValue} si mai mici decat {int.MaxValue}");
                }
                catch(IndexOutOfRangeException)
                {
                ExceptionSentence("Trebuie introduse doua numere");
                }
                catch (Exception e)
                {
                    ExceptionSentence(e.Message);
                }
            if (aReusit)
                return (a, b);
            else throw new Exception();
                

                   
        }
        private (int,int,int) IntroducereDate(int a,int b, int c)
        {
            char[] despartitoare = { ' ', ';', ',' };
            aReusit = true;

            try
            {
                string[] numere = Date_Intrare.Text.Split(despartitoare, StringSplitOptions.RemoveEmptyEntries);
                if (numere.Length > 3)
                    throw new IndexOutOfRangeException();

                a = int.Parse(numere[0]);
                b = int.Parse(numere[1]);
                c = int.Parse(numere[2]);
            }
            catch (FormatException)
            {
                ExceptionSentence("Trebuie introduse doar numere");
            }
            catch (OverflowException)
            {
                ExceptionSentence($"Trebuie introduse numere mai mari decat {int.MinValue} si mai mici decat {int.MaxValue}");
            }
            catch (IndexOutOfRangeException)
            {
                ExceptionSentence("Trebuie introduse trei numere");
            }
            catch (Exception e)
            {
                ExceptionSentence(e.Message);
            }
            if (aReusit)
                return (a, b, c);
            else throw new Exception();
        }

        private (int, int, int,int,int) IntroducereDate(int a, int b, int c,int d, int e)
        {
            char[] despartitoare = { ' ', ';', ',' };
            aReusit = true;

            try
            {
                string[] numere = Date_Intrare.Text.Split(despartitoare, StringSplitOptions.RemoveEmptyEntries);
                if (numere.Length > 5)
                    throw new IndexOutOfRangeException();

                a = int.Parse(numere[0]);
                b = int.Parse(numere[1]);
                c = int.Parse(numere[2]);
                d = int.Parse(numere[3]);
                e = int.Parse(numere[4]);
            }
            catch (FormatException)
            {
                ExceptionSentence("Trebuie introduse doar numere");
            }
            catch (OverflowException)
            {
                ExceptionSentence($"Trebuie introduse numere mai mari decat {int.MinValue} si mai mici decat {int.MaxValue}");
            }
            catch (IndexOutOfRangeException)
            {
                ExceptionSentence("Trebuie introduse cinci numere");
            }
            catch (Exception v)
            {
                ExceptionSentence(v.Message);
            }
            if (aReusit)
                return (a, b, c,d,e);
            else throw new Exception();
        }

        private bool EsteAnBisect(int a)
        {
            if (a % 4 == 0 && a % 100 != 0 || a % 400 == 0)
                return true;
            else return false;

        }
        private int Oglindit(int n)
        {
            int aux = 0;
            int n2 = n;
            while(n2>0)
            {
                aux = aux * 10 + n2 % 10;
                n2 /= 10;
            }
            return aux;
        }

        private void ExceptionSentence(string ExceptionString)
        {
            Date_Iesire.Text = ExceptionString;
            Date_Intrare.Text = "";
            aReusit = false;
        }

        #endregion


        #region unusedMethods


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




        #endregion

        private void Enuntul_Problemei_Click(object sender, EventArgs e)
        {

        }
    }
}
