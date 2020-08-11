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
    public partial class Form2 : Form
    {
        public Form2(List<Notitie> notities)
        {
            InitializeComponent();
            returnLijst = notities;
        }
        public List<Notitie> returnLijst;
        private void btnAanmaken_Click(object sender, EventArgs e)
        {
            if(tbNaam.Text!="" && tbInhoud.Text != "")
            {
                Notitie nieuweNotitie = new Notitie(tbNaam.Text, tbInhoud.Text);
                this.returnLijst.Add(nieuweNotitie);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
