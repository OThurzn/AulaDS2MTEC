using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crd_polvo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        polvo p = new polvo();        
        
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                p.setEspecie(txt_especie.Text);
                p.setHabitat(txt_habitat.Text);
                p.setTamanho(txt_tamanho.Text); // tamanho is a string
                p.setPeso(int.Parse(txt_peso.Text)); // Converting text to int
                p.setCor(txt_cor.Text);
                //Chamar o método inserir
                p.inserir();
                //Consultar
                dataGridView1.DataSource = p.Consultar();
                //Apagar
                txt_codigo.Text = "";
                txt_especie.Text = "";
                txt_habitat.Text = "";
                txt_tamanho.Text = "";
                txt_peso.Text = "";
                txt_cor.Text = "";
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso");
            }
        }

        private void btn_consultar_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = p.Consultar();
        }

        private void btn_excluir_Click_1(object sender, EventArgs e)
        {
            try
            {
                p.setCodigo(txt_codigo.Text);
                p.Excluir();
                dataGridView1.DataSource = p.Consultar();
            }
            finally
            {
                MessageBox.Show("Informações excluídas com sucesso");
            }

        }

        private void btn_apagar_Click_1(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_especie.Text = "";
            txt_habitat.Text = "";
            txt_tamanho.Text = "";
            txt_peso.Text = "";
            txt_cor.Text = "";
        }
    }
}