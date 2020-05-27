using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calkowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        double[] wielomian;

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            wielomian = new double[dataGridView1.Rows.Count - 1];
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                wielomian[i] = double.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());


            for (int i = 0; i < wielomian.Length; i++)
            {
                if ((wielomian.Length - i-1) == 0)
                    label1.Text += wielomian[i];
                else if ((wielomian.Length-i-1) == 1)
                    label1.Text += wielomian[i] + " x  + ";
                else
                    label1.Text += wielomian[i] + " x^" + (wielomian.Length-i-1) + " + ";
            }
        }
        
        private double ObliczFx(double x)
        {
            double wynik = 0;
            for (int i = 0; i < wielomian.Length; i++)
            {
                wynik += wielomian[i] * Math.Pow(x, wielomian.Length - i - 1);
            }
            return wynik;
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            double a = double.Parse(aBox.Text);
            double b = double.Parse(bBox.Text);
            double n = double.Parse(przedzialBox.Text);
            double h = (b - a) / n;

            double wynik = 0;
            label5.Text = "Krok: " + h;
            double podprzedzial_start = a;
            double podprzedzial_koniec = a + h;
            if(radioTrapez.Checked)//metoda trapezów
            {
                for (int i = 0; i < n; i++)
                {
                    if(i == n - 1)
                    {
                        podprzedzial_koniec = b;
                        wynik += (ObliczFx(podprzedzial_start) + ObliczFx(podprzedzial_koniec)) * h / 2;
                    }
                    else
                    {
                        wynik += (ObliczFx(podprzedzial_start) + ObliczFx(podprzedzial_koniec)) * h / 2;
                        podprzedzial_start = podprzedzial_koniec;
                        podprzedzial_koniec = podprzedzial_koniec + h;
                    }
                }
                label5.Text = wynik.ToString();
            }
            else if(radioSimps.Checked)//metoda simpsona
            {
                wynik = h / 3;
                double wartosc = 0;
                double x = a + h;
                if(n % 2 != 0)
                {
                    label5.Text = "Nieparzysta liczba podprzedziałów!";
                    return;
                }
                for (int i = 0; i <= n; i++)
                {
                    if(i == 0)
                    {
                        wartosc += ObliczFx(a);
                    }
                    else if(i == n)
                    {
                        wartosc += ObliczFx(b);
                    }
                    else
                    {
                        if (i % 2 == 0)
                            wartosc += 2 * ObliczFx(x);
                        else
                            wartosc += 4 * ObliczFx(x);

                        x += h;
                    }
                }
                wynik = wynik * wartosc;
                label5.Text = wynik.ToString();
            }
        }
    }
}
