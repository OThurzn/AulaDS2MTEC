﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplos_encapsulamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Aluno z = new Aluno();
        private void btn_armazenar_Click(object sender, EventArgs e)
        {
            z.setNome(txt_nome.Text);
            z.setcpf(txt_cpf.Text);
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            lbl_mostrar_nome.Text = z.getNome();
            lbl_mostrar_cpf.Text = z.getcpf();
        }
    }
}
