using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemploOrientaçãoObjeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double n1, n2;
        private void soma_Click(object sender, EventArgs e)
        {
            /* operações matématicas
            op é o nome do objeto (apelido)
            new operacoes_matematicas é a criação do construtor da classe.

            O código abaixo utilizado para ligar a classe com o formulario (instanciar objeto)*/
            operacoes_matematicas op = new operacoes_matematicas();
            n1 = double.Parse(txt_num1.Text);
            n2 = double.Parse(txt_num2.Text);
            txt_resultado.Text = "" + op.soma_dois_numeros(n1, n2);
        }

        private void subtracao_Click(object sender, EventArgs e)
        {
        operacoes_matematicas op = new operacoes_matematicas();
            n1 = double.Parse(txt_num1.Text);
            n2 = double.Parse(txt_num2.Text);
            txt_resultado.Text = "" + op.subtrai_dois_numeros(n1, n2);
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            operacoes_matematicas op = new operacoes_matematicas();
            n1 = double.Parse(txt_num1.Text);
            n2 = double.Parse(txt_num2.Text);
            txt_resultado.Text = "" + op.multiplica_dois_numeros(n1, n2);
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            operacoes_matematicas op = new operacoes_matematicas();
            n1 = double.Parse(txt_num1.Text);
            n2 = double.Parse(txt_num2.Text);
            txt_resultado.Text = "" + op.divisao_dois_numeros(n1, n2);
        }
    }
}
