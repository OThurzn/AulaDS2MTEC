using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prestacaoAtrasoOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            operacoes op = new operacoes();
            double vprest, tempo, taxa;
            vprest = double.Parse(txt_vprest.Text);
            taxa = double.Parse(txt_taxa.Text);
            tempo = double.Parse(txt_tempo.Text);

            txt_jurosFinal.Text = "" + op.calcular_juros(vprest, taxa, tempo);
            txt_valorFinal.Text = "" + op.calcular_valorFinal(vprest, taxa, tempo);
        }
    }
}
