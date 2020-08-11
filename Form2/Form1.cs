using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public string geslacht;
        public string provincie;


        private void btnIndienen_Click(object sender, EventArgs e)
        {
            foreach (var item in gbProvincie.Controls.OfType<RadioButton>())
            {
                if (item.Checked)
                {
                    provincie = item.Text;
                }
            }
            foreach(var item in gbGeslacht.Controls.OfType<RadioButton>())
            {
                if(item.Checked)
                {
                    geslacht = item.Text;
                }
            }
            if (provincie != null && tbAdres.Text != null && tbNaam.Text != null    && geslacht != null)
            {
                string Input = string.Format("Naam: {0}, Leeftijd: {1}, Gelsacht: {2}, Adres: {3}, {4}", tbNaam.Text,  numLeeftijd.Value, geslacht,tbAdres.Text, provincie);
                MessageBox.Show(Input);
            }
            else
            {
                MessageBox.Show("Gelieve alle velden in te vullen");
            }

        }
    }
}
