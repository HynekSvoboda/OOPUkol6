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
        string jmeno;
        string prijmeni;
        int hmotnost;
        double vyska;

        string Jmeno
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
        string Prijmeni
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
        int Hmotnost
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
        double Vyska
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
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.hmotnost = hmotnost;
            this.vyska = vyska;
        }

        public double BMI()
        {
            return hmotnost / (vyska * vyska);
        }

        public override string ToString()
        {
            return Jmeno + " " + Prijmeni + ", hmotnost: " + Hmotnost+ ", výška: " + Vyska + ", BMI: " + BMI();
        }
    }
}
