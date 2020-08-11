using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Notitie> notitieLijst = new List<Notitie>();
        private void btnLamineren_Click(object sender, EventArgs e)
        {
            btnSchrijfBij.Enabled = false;
            btnToevoegen.Enabled = false;
            btnVerwijderen.Enabled = false;
            btnLamineren.Enabled = false;
            tbText.Enabled = false;
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            using(Form2 f2 = new Form2(notitieLijst))
            {
                var result = f2.ShowDialog();
                if (result== DialogResult.OK)
                {
                    notitieLijst = f2.returnLijst;
                    VulLijst();
                }           
            }
        }

        private void lbNotities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbNotities.SelectedIndex >= 0)
            {
                tbToonNotitie.Text = notitieLijst[lbNotities.SelectedIndex].Inhoud;
            }
            else
            {
                tbToonNotitie.Clear();
            }
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            notitieLijst.RemoveAt(lbNotities.SelectedIndex);
            VulLijst();
        }
        public void VulLijst()
        {
            lbNotities.Items.Clear();
            foreach (var item in notitieLijst)
            {
                lbNotities.Items.Add(item.ToString());
            }
            tbToonNotitie.Clear();
            lbNotities.SelectedIndex = -1;
        }

        private void btnSchrijfBij_Click(object sender, EventArgs e)
        {
            if (tbText.Text != "")
            {
                notitieLijst[lbNotities.SelectedIndex].Inhoud += " " + tbText.Text;
                int i = lbNotities.SelectedIndex;
                lbNotities.SelectedIndex = -1;
                lbNotities.SelectedIndex = i;
                tbText.Clear();
            }
        }
    }
}
