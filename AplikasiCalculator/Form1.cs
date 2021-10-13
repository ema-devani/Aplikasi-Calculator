using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            double hasil = 0;
            var a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);

            if(comboBox1.SelectedIndex == 0)
            {
                hasil = a + b;
            }else if(comboBox1.SelectedIndex == 1)
            {
                hasil = a - b;
            }else if(comboBox1.SelectedIndex == 2)
            {
                hasil = a * b;
            }else if(comboBox1.SelectedIndex == 3)
            {
                hasil = a / b;
            }

            Hasil.Text = Convert.ToString(hasil); 
        }
    }
}
