using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_RadioButton_CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSonucuGoster_Click(object sender, EventArgs e)
        {
            if (rdbFenerbahce.Checked)
            {
                lblTutulanTakim.Text = rdbFenerbahce.Text;
            }
            else if (rdbBesiktas.Checked)
            {
                lblTutulanTakim.Text = "Siz " + rdbBesiktas.Text + "siniz";
            }
            else if (rdbGalatasaray.Checked)
            {
                lblTutulanTakim.Text = "Siz " + rdbGalatasaray.Text + "siniz";
            }
        }

        private void rdbFenerbahce_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Değişti");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
