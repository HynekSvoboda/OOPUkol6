using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPUkol6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               /* Osoba osoba = new Osoba(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToDouble(textBox4.Text));
                label5.Text = osoba.ToString();*/
                Pacient pacient = new Pacient(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
                label5.Text= pacient.ToString();
            }
            catch
            {
                MessageBox.Show("Něco jsi zadal špatně");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vytvořte třídu Osoba, která bude obsahovat:\r\n Vlastnost Jméno pro čtení i zápis\r\n Vlastnost Příjmení pro čtení i zápis.\r\n Vlastnost Hmotnost (kg) pro čtení i zápis. Vlastnost naprogramujte tak, aby se při\r\núdaji mimo interval (0;300> vypsalo upozornění „Hmotnost mimo rozsah!“ a\r\nhodnota se neuložila\r\n Vlastnost Výška (v metrech, např. 1,85) pro čtení i zápis. Vlastnost naprogramujte\r\ntak, aby se hodnota uložila vždy v metrech, i když ji uživatel zadá v cm (poznáte\r\npodle velikosti).\r\nTřída bude mít jediný konstruktor, který nastaví jméno, příjmení, hmotnost a výšku.\r\nNapište metodu BMI, která zjistí BMI dané osoby dle vzorce\r\nPřepište metodu ToString – vrátí text se všemi údaji včetně BMI.\r\nVytvořte instanci třídy Osoba a vyzkoušejte v programu.\r\nVytvořte třídu Pacient odvozenou od třídy Osoba.\r\nTřída zdědí všechny atributy, vlastnosti a metody od třídy Osoba a navíc bude obsahovat:\r\n Vlastnost ObvodPasu (v metrech, např. 0,68) pro čtení i zápis\r\n Metodu ABSI, která vypočítá ABSI (A Body Shape Index – index tvaru těla)\r\npodle vzorce (Vychází reálné číslo okolo 0,060 – 0,090).\r\nKonstruktor nastaví stejné údaje jako předek a navíc nastaví ObvodPasu. Využijte\r\nkonstruktor předka.\r\nPřepište metodu ToString – vrátí text se všemi údaji včetně ABSI. Využijte metodu\r\npředka.\r\nVytvořte instanci třídy Pacient a vyzkoušejte v programu.");
        }
    }
}
