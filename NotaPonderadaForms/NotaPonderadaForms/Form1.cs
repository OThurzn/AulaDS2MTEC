using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotaPonderadaForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double media, prova1, prova2, prova3;

            prova1 = (double.Parse(txt_nota1.Text));
            prova2 = (double.Parse(txt_nota2.Text));
            prova3 = (double.Parse(txt_nota3.Text));
            media = ((2 * prova1) + (3 * prova2) + (5 * prova3)) / 10;
            txt_total.Text = media.ToString();
        }
    }
}
