using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_poliformismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //instanciamento do objeto incompleto
        empregado objeto = null;
        empregado ep = new empregado();
        private void btn_verificar_Click(object sender, EventArgs e)
        {
            //Captura de informações
            ep.setNome(txt_nome.Text);
            ep.setSobrenome(txt_sobrenome.Text);
            ep.setCPF(txt_cpf.Text);

            //Demonstrar as informações
            lbl_nome.Text = ep.getNome();
            lbl_sobrenome.Text = ep.getSobrenome();
            lbl_cpf.Text = ep.getCPF();

            if (rdb_assalariado.Checked)
            {
                objeto = new assalariado();
                double t;
                t = 0;
                lbl_vencimento.Text = objeto.vencimento(t).ToString();
            }

            else if (rdb_comissionado.Checked)
            {
                objeto = new comissionario();
                double t;
                t = 0;
                lbl_vencimento.Text = objeto.vencimento(t).ToString();
            }

            else if (rdb_horista.Checked)
            {
                objeto = new horista();
                double t;
                t = 0;
                lbl_vencimento.Text = objeto.vencimento(t).ToString();
            }
        }
    }
}
            /*
                Ativide: Demonstre as informações digitadas na caiza de texto nome,
                sobrenom e CPF utilize um botão (verificar) e demonstre em label ou caixa de texto.
            */