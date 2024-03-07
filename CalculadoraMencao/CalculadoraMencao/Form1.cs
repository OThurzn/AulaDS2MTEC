using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMencao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            string mencao, cor;
            double media, nota1, nota2, nota3, nota4;

            nota1 = (double.Parse(txt_nota1.Text));
            nota2 = (double.Parse(txt_nota2.Text));
            nota3 = (double.Parse(txt_nota3.Text));
            nota4 = (double.Parse(txt_nota4.Text));
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            if (media < 5){
                mencao = "I";
                txt_mencao.BackColor = Color.Red;
            }
            else if(media >=5 && media<7){
                mencao = "R";
                txt_mencao.BackColor = Color.Orange;
            }
            else if(media >=7 && media < 9){
                mencao= "B";
                txt_mencao.BackColor = Color.Blue;
            }
            else{
                mencao = "MB";
                txt_mencao.BackColor = Color.Blue;
            }
            txt_mencao.Text = "Menção "+mencao;
        }
    }
}
