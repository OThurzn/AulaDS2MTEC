using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace votoPorcentagemForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int vValidos, vBrancos, vNulos, total;
            double resValidos, resBrancos, resNulos;
            vValidos = (int.Parse(txt_validos.Text));
            vBrancos = (int.Parse(txt_brancos.Text));
            vNulos = (int.Parse(txt_nulos.Text));

            total = vValidos + vBrancos + vNulos;

            resValidos = (vValidos * 100) / total;
            resBrancos = (vBrancos * 100) / total;
            resNulos = (vNulos * 100) / total;

            txt_total.Text = total.ToString();
            prc_brancos.Text = resBrancos.ToString()+"%";
            prc_nulos.Text = resNulos.ToString() + "%";
            prc_validos.Text = resValidos.ToString() + "%";
        }
    }
}