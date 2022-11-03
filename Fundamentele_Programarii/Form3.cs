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
    public partial class Problema_x : Form
    {
        static bool aReusit;
        public Problema_x(int indexulButonului)
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
            catch(Exception e)
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
            catch(Exception e)
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
            catch(Exception e)
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
            catch (Exception e) { return; }

            if (a % 4 == 0 && a % 100 != 0 || a % 400 == 0)
                Date_Iesire.Text = $"{a} este an bisect";
            else Date_Iesire.Text = $"{a} nu este an bisect";
        }
        #endregion

        private void P5()
        {
            int n = 1;int k = 1;
            try
            {
                (n, k) = IntroducereDate(n, k);
            }
            catch (Exception e) { return; }
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
            catch(Exception e) { return; }

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
            catch (FormatException e)
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
                catch(FormatException e)
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
            catch (FormatException e)
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
        #region unusedMethods

        private void ExceptionSentence(string ExceptionString)
        {
            Date_Iesire.Text = ExceptionString;
            Date_Intrare.Text = "";
            aReusit = false;
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



       
        #endregion
    }
}
