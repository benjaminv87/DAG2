using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAG2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            if (tbToevoegen.Text != "")
            {
                lbLinks.Items.Add(tbToevoegen.Text);
                tbToevoegen.Clear();
            }
        }

        private void btnListBoxRechts_Click(object sender, EventArgs e)
        {
            if(lbLinks.SelectedIndex >= 0)
            {
                lbRechts.Items.Add(lbLinks.SelectedItem);
                lbLinks.Items.RemoveAt(lbLinks.SelectedIndex) ;
            }
        }

        private void btnListBoxLinks_Click(object sender, EventArgs e)
        {
            if (lbRechts.SelectedIndex >= 0)
            {
                lbLinks.Items.Add(lbRechts.SelectedItem);
                lbRechts.Items.RemoveAt(lbRechts.SelectedIndex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
