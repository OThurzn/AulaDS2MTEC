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
                //Consultar
                dataGridView1.DataSource = c.Consultar();
                //Apagar
                txt_codigo.Text = "";
                txt_nome.Text = "";
                txt_sobrenome.Text = "";
                txt_cpf.Text = "";

            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso");
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.Consultar();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                c.setCodigo(txt_codigo.Text);
                c.Excluir();
                dataGridView1.DataSource = c.Consultar();
            }
            finally
            {
                MessageBox.Show("Informações excluidas com sucesso");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_nome.Text = "";
            txt_sobrenome.Text = "";
            txt_cpf.Text = "";
        }
    }
}
