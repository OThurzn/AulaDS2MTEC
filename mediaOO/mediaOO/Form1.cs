using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediaOO
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
            double n1, n2, n3, n4;
            n1 = double.Parse(txt_num1.Text);
            n2 = double.Parse(txt_num2.Text);
            n3 = double.Parse(txt_num3.Text);
            n4 = double.Parse(txt_num4.Text);
            txt_result.Text = "" + calc.calcular_media(n1, n2, n3, n4);
        }
    }
}
