using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace operacoesForms
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

        private void soma_Click(object sender, EventArgs e)
        {
            double num1, num2, soma;
            num1 =double.Parse(txt_num1.Text);
            num2 = double.Parse(txt_num2.Text);
            soma = num1 + num2;
            txt_result.Text = soma.ToString();
        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            double num1, num2, subtracao;
            num1 = double.Parse(txt_num1.Text);
            num2 = double.Parse(txt_num2.Text);
            subtracao = num1 - num2;
            txt_result.Text = subtracao.ToString();
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            double num1, num2, multiplicacao;
            num1 = double.Parse(txt_num1.Text);
            num2 = double.Parse(txt_num2.Text);
            multiplicacao = num1 * num2;
            txt_result.Text = multiplicacao.ToString();
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            double num1, num2, divisao;
            num1 = double.Parse(txt_num1.Text);
            num2 = double.Parse(txt_num2.Text);
            divisao = num1 / num2;
            txt_result.Text = divisao.ToString();
        }
    }
}
