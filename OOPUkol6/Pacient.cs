using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPUkol6
{
    internal class Pacient : Osoba
    {
        double obvodpasu;

        double ObvodPasu
        {
            get => obvodpasu;
            set
            {
                obvodpasu= value;
            }
        }
        public Pacient(string jmeno, string prijmeni, int hmotnost, double vyska, double obvodpasu) :base(jmeno,prijmeni,hmotnost,vyska)
        {
            this.ObvodPasu= obvodpasu;
        }
        public double ABSI()
        {
            return Math.Round(obvodpasu / (Math.Pow(BMI(), 0.66666666666) * (Math.Pow(vyska, 0.5)))*10, 3);
        }
        public override string ToString()
        {
            return Jmeno + " " + Prijmeni + ", hmotnost: " + Hmotnost + " kg, výška: " + Vyska + " m,\nBMI: " + BMI()+", obvod pasu: "+ObvodPasu+" m, ABSI: "+ABSI();
        }
    }
}
