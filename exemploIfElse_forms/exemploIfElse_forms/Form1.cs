using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemploIfElse_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_escolha_Click(object sender, EventArgs e)
        {
            if (rdb_manha.Checked == true)
            {
                MessageBox.Show("Você escolheu manhã");
            }
            else if (rdb_tarde.Checked == true)
            {
                MessageBox.Show("Você escolher tarde");
            }
            else if (rdb_noite.Checked == true)
            {
                MessageBox.Show("Você escolheu noite");
            }
            else
            {
                MessageBox.Show("Escolha um dos periodos!");
            }

        }
        private void Form1_Click_1(object sender, EventArgs e)
        {
            rdb_manha.Checked = false;
            rdb_tarde.Checked = false;
            rdb_noite.Checked = false;
        }
    }
}
