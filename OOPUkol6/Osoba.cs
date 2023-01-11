using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPUkol6
{
    internal class Osoba
    {
       protected string jmeno;
       protected string prijmeni;
       protected int hmotnost;
       protected double vyska;

       protected string Jmeno
        {
            get
            {
                return jmeno;
            }
            set
            {
                jmeno = value;
            }
        }
       protected string Prijmeni
        {
            get
            {
                return prijmeni;
            }
            set
            {
                prijmeni = value;
            }
        }
       protected int Hmotnost
        {
            get => hmotnost;
            set
            {
                if (value > 0 && value <= 300)
                {
                    hmotnost = value;
                }
                else
                {
                    MessageBox.Show("Hmotnost mimo rozsah!");
                }
            }
        }
       protected double Vyska
        {
            get => vyska;
            set
            {
                if (value > 2.4)
                {
                    vyska = value / 100;
                }
                else
                {
                    vyska = value;
                }
            }
        }

        public Osoba(string jmeno,string prijmeni,int hmotnost, double vyska)
        {
            this.Jmeno = jmeno;
            this.Prijmeni = prijmeni;
            this.Hmotnost = hmotnost;
            this.Vyska = vyska;
        }

        public double BMI()
        {
            return Math.Round( hmotnost / (vyska * vyska),2);
        }

        public override string ToString()
        {
            return Jmeno + " " + Prijmeni + ", hmotnost: " + Hmotnost+ ", výška: " + Vyska + ", BMI: " + BMI();
        }
    }
}
