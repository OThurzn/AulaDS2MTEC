using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraDiasForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_idade_Click(object sender, EventArgs e)
        {
            txt_idade.Text = "";
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            int dias=(int.Parse(txt_idade.Text)*365);
            txt_dias.Text = dias.ToString();
        }
    }
}
