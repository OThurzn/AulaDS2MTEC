using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv_carro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Carro c = new Carro();

        private void btn_armazenar_Click_1(object sender, EventArgs e)
        {
            //Salvar
            c.setModelo(txt_modelo.Text);
            c.setCor(txt_cor.Text);
            c.setAno(int.Parse(txt_ano.Text));
            c.setPortas(int.Parse(txt_portas.Text));
            c.setMarca(txt_marca.Text);
            c.setQuilometragem(int.Parse(txt_quilometragem.Text));

            //Mostrar
            lbl_modelo.Text = c.getModelo();
            lbl_cor.Text = c.getCor();
            lbl_ano.Text = Convert.ToString(c.getAno());
            lbl_portas.Text = Convert.ToString(c.getPortas());
            lbl_marca.Text = c.getMarca();
            lbl_quilometragem.Text = Convert.ToString(c.getQuilometragem());
        }
    }
}
