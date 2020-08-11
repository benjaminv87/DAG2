using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToonDatum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dtpDatum.Value.ToString("dd/MM/yyyy"));
        }
    }
}
