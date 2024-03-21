using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermercadoOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            calculos calc = new calculos();
            int total = int.Parse(txt_num1.Text);
            int estoque = int.Parse(txt_num2.Text);
            txt_result.Text = "" + calc.calcular_compra(total, estoque);
        }
    }
}
