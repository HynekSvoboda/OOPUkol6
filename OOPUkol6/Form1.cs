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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                Osoba osoba = new Osoba(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToDouble(textBox4.Text));
                label5.Text = osoba.ToString();
           /* }
            catch
            {
                MessageBox.Show("Něco jsi zadal špatně");
            }*/
        }
    }
}
