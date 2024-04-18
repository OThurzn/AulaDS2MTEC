using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_heranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        funcionario f = new funcionario();
        private void btn_armazenar_Click(object sender, EventArgs e)
        {
            //Captura de informações
            f.setNome(txt_nome.Text);
            f.setCartao(txt_cartao.Text);
            f.setRg(txt_rg.Text);

            //Demonstrar as informações
            lbl_nome.Text = f.getNome();
            lbl_cartao.Text = f.getCartao();
            lbl_rg.Text = f.getRg();
        }
    }
}
