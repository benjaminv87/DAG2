using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!File.Exists(fileName))
            {
                File.Create(fileName);

            }
        }
        public string fileName = "text.txt";
        public List<string> mijnLijst = new List<string>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbMijnText.Text != "")
            {
                mijnLijst.Add(tbMijnText.Text);
                tbMijnText.Clear();
            }
            VulLijst();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbMijnLijst.SelectedIndex >= 0)
            {
                mijnLijst.RemoveAt(lbMijnLijst.SelectedIndex);
            }
            VulLijst();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var item in mijnLijst)
                {
                    writer.WriteLine(item);
                }
            }
        }
        private void VulLijst()
        {
            lbMijnLijst.Items.Clear();

            foreach (var item in mijnLijst)
            {
                lbMijnLijst.Items.Add(item);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            mijnLijst.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    mijnLijst.Add(reader.ReadLine());
                }
            }
            VulLijst();
        }
    }
}
