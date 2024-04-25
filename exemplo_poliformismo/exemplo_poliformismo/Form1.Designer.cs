namespace exemplo_poliformismo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.txt_sobrenome = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_vencimento = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdb_comissionado = new System.Windows.Forms.RadioButton();
            this.rdb_horista = new System.Windows.Forms.RadioButton();
            this.rdb_assalariado = new System.Windows.Forms.RadioButton();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_sobrenome = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cpf);
            this.groupBox1.Controls.Add(this.txt_sobrenome);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empregado";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(94, 87);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(100, 20);
            this.txt_cpf.TabIndex = 5;
            // 
            // txt_sobrenome
            // 
            this.txt_sobrenome.Location = new System.Drawing.Point(94, 52);
            this.txt_sobrenome.Name = "txt_sobrenome";
            this.txt_sobrenome.Size = new System.Drawing.Size(100, 20);
            this.txt_sobrenome.TabIndex = 4;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(94, 19);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "SobreNome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_vencimento);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(266, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vencimento";
            // 
            // lbl_vencimento
            // 
            this.lbl_vencimento.AutoSize = true;
            this.lbl_vencimento.Location = new System.Drawing.Point(141, 52);
            this.lbl_vencimento.Name = "lbl_vencimento";
            this.lbl_vencimento.Size = new System.Drawing.Size(0, 13);
            this.lbl_vencimento.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Data de Vencimento:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdb_comissionado);
            this.groupBox3.Controls.Add(this.rdb_horista);
            this.groupBox3.Controls.Add(this.rdb_assalariado);
            this.groupBox3.Location = new System.Drawing.Point(12, 181);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo Empregado";
            // 
            // rdb_comissionado
            // 
            this.rdb_comissionado.AutoSize = true;
            this.rdb_comissionado.Location = new System.Drawing.Point(24, 67);
            this.rdb_comissionado.Name = "rdb_comissionado";
            this.rdb_comissionado.Size = new System.Drawing.Size(90, 17);
            this.rdb_comissionado.TabIndex = 2;
            this.rdb_comissionado.TabStop = true;
            this.rdb_comissionado.Text = "Comissionado";
            this.rdb_comissionado.UseVisualStyleBackColor = true;
            // 
            // rdb_horista
            // 
            this.rdb_horista.AutoSize = true;
            this.rdb_horista.Location = new System.Drawing.Point(24, 44);
            this.rdb_horista.Name = "rdb_horista";
            this.rdb_horista.Size = new System.Drawing.Size(58, 17);
            this.rdb_horista.TabIndex = 1;
            this.rdb_horista.TabStop = true;
            this.rdb_horista.Text = "Horista";
            this.rdb_horista.UseVisualStyleBackColor = true;
            // 
            // rdb_assalariado
            // 
            this.rdb_assalariado.AutoSize = true;
            this.rdb_assalariado.Location = new System.Drawing.Point(24, 22);
            this.rdb_assalariado.Name = "rdb_assalariado";
            this.rdb_assalariado.Size = new System.Drawing.Size(79, 17);
            this.rdb_assalariado.TabIndex = 0;
            this.rdb_assalariado.TabStop = true;
            this.rdb_assalariado.Text = "Assalariado";
            this.rdb_assalariado.UseVisualStyleBackColor = true;
            // 
            // btn_verificar
            // 
            this.btn_verificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_verificar.Location = new System.Drawing.Point(134, 287);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(207, 88);
            this.btn_verificar.TabIndex = 5;
            this.btn_verificar.Text = "Verificar";
            this.btn_verificar.UseVisualStyleBackColor = true;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_cpf);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.lbl_sobrenome);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lbl_nome);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(266, 181);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(207, 100);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados Empregado";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(65, 79);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(0, 13);
            this.lbl_cpf.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Nome:";
            // 
            // lbl_sobrenome
            // 
            this.lbl_sobrenome.AutoSize = true;
            this.lbl_sobrenome.Location = new System.Drawing.Point(85, 48);
            this.lbl_sobrenome.Name = "lbl_sobrenome";
            this.lbl_sobrenome.Size = new System.Drawing.Size(0, 13);
            this.lbl_sobrenome.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Sobrenome:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(66, 20);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(0, 13);
            this.lbl_nome.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "CPF:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 387);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_verificar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_vencimento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdb_comissionado;
        private System.Windows.Forms.RadioButton rdb_horista;
        private System.Windows.Forms.RadioButton rdb_assalariado;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.TextBox txt_sobrenome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_sobrenome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label label11;
    }
}

