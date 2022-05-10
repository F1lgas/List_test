using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<char> znaky = new List<char>();
        Random rnd = new Random();

        private void generovat_Click(object sender, EventArgs e)
        {
            try
            {
                znaky.Clear();
                textBox_vystup.Clear();

                for (int i = 0; i < Convert.ToInt32(textBox_N.Text); i++)
                {
                    char znak = Convert.ToChar(rnd.Next(32, 127));
                    znaky.Add(znak);
                }

                foreach (char znak in znaky)
                {
                    if (znak == 32)
                    {

                    }
                    else
                    {
                        textBox_vystup.Text += znak.ToString();
                    }
                }

                Vypis(listBox_znaku, znaky, listBox_cisel);
            }
            catch
            {
                MessageBox.Show("Zadej správné hodnoty!", "Error");
            }
                int min = 9;
                int max = 0;

                foreach (char cislo in listBox_cisel.Items)
                {
                    if (cislo < min)
                    {
                        min = cislo;
                    }
                    if (cislo > max)
                    {
                        max = cislo;
                    }
                }

                double median = ((double)(max - min) / 2) + min;

                MessageBox.Show("Medián čísel je " + median, "Výsledek");
            
            
        }

        private void Vypis(ListBox listbox, List<char> list, ListBox listbox2)
        {
            listbox.Items.Clear();

            foreach (char znak in list)
            {
                if (znak >= '0' && znak <= '9')
                {
                    listbox2.Items.Add(znak);
                }
                if (znak < '0' || znak >= ':' && znak <= '@' || znak > 'Z' && znak < 'a' || znak > 'z')
                {
                    listbox.Items.Add(znak);
                }
            }
        }
    }
}
