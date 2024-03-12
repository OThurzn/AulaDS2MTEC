using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            string resultado = "";
            double peso, altura, imc;
            peso = double.Parse(txt_peso.Text);
            altura = double.Parse(txt_altura.Text);
            imc = peso / (altura * altura);
            if (imc < 16)
            {
                resultado = "Baixo peso Grau III";
            }
            else if (imc >= 16 && imc < 17)
            {
                resultado = "Baixo peso Grau II";
            }
            else if (imc >= 17 && imc < 18.5)
            {
                resultado = "Baixo peso Grau I";
            }
            else if (imc >= 18.5 && imc < 25)
            {
                resultado = "Peso saudável";
            }
            else if (imc >= 25 && imc < 30)
            {
                resultado = "Sobrepeso";
            }
            else if (imc >= 30 && imc < 35)
            {
                resultado = "Obesidade Grau I";
            }
            else if (imc >= 35 && imc < 40)
            {
                resultado = "Obesidade Grau I";
            }
            else if (imc >= 40)
            {
                resultado = "Obesidade Grau III";
            }
            txt_resultado.Text = resultado;
        }
    }
}
