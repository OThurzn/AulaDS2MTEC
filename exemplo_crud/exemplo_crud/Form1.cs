using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        colaborador c = new colaborador();
        private void btn_salvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                c.setCPF(txt_cpf.Text);
                c.setNome(txt_nome.Text);
                c.setSobrenome(txt_sobrenome.Text);
                //Chamar o metodo inserir
                c.inserir();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso");
            }
        }
    }
}
