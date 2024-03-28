using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consorcioOO
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
            double prest_total, prest_pagas, prest_valor;
            prest_total = double.Parse(txt_totalPrest.Text);
            prest_pagas = double.Parse(txt_Prestpagas.Text);
            prest_valor = double.Parse(txt_valorPrest.Text);
            txt_totalPago.Text = "" + op.ValorPago(prest_pagas, prest_valor);
            txt_saldoDevedor.Text = "" + op.ValorSaldo(prest_total, prest_pagas, prest_valor);
        }
    }
}
