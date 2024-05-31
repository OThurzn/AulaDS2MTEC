namespace crd_polvo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_habitat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tamanho = new System.Windows.Forms.TextBox();
            this.txt_cor = new System.Windows.Forms.TextBox();
            this.txt_especie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_habitat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_peso);
            this.groupBox1.Controls.Add(this.btn_apagar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_tamanho);
            this.groupBox1.Controls.Add(this.txt_cor);
            this.groupBox1.Controls.Add(this.txt_especie);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(469, 210);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Polvo";
            // 
            // txt_habitat
            // 
            this.txt_habitat.Location = new System.Drawing.Point(119, 98);
            this.txt_habitat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_habitat.Name = "txt_habitat";
            this.txt_habitat.Size = new System.Drawing.Size(116, 22);
            this.txt_habitat.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Habitat";
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(336, 67);
            this.txt_peso.Margin = new System.Windows.Forms.Padding(4);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(116, 22);
            this.txt_peso.TabIndex = 9;
            // 
            // btn_apagar
            // 
            this.btn_apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_apagar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_apagar.Location = new System.Drawing.Point(134, 142);
            this.btn_apagar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(194, 59);
            this.btn_apagar.TabIndex = 42;
            this.btn_apagar.Text = "APAGAR";
            this.btn_apagar.UseVisualStyleBackColor = true;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Peso";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(120, 33);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(115, 22);
            this.txt_codigo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Código";
            // 
            // txt_tamanho
            // 
            this.txt_tamanho.Location = new System.Drawing.Point(336, 34);
            this.txt_tamanho.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tamanho.Name = "txt_tamanho";
            this.txt_tamanho.Size = new System.Drawing.Size(116, 22);
            this.txt_tamanho.TabIndex = 5;
            // 
            // txt_cor
            // 
            this.txt_cor.Location = new System.Drawing.Point(336, 99);
            this.txt_cor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cor.Name = "txt_cor";
            this.txt_cor.Size = new System.Drawing.Size(115, 22);
            this.txt_cor.TabIndex = 4;
            // 
            // txt_especie
            // 
            this.txt_especie.Location = new System.Drawing.Point(120, 65);
            this.txt_especie.Margin = new System.Windows.Forms.Padding(4);
            this.txt_especie.Name = "txt_especie";
            this.txt_especie.Size = new System.Drawing.Size(115, 22);
            this.txt_especie.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tamanho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Espécie";
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_excluir.Location = new System.Drawing.Point(786, 23);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(170, 77);
            this.btn_excluir.TabIndex = 41;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 266);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(890, 248);
            this.dataGridView1.TabIndex = 40;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_consultar.Image = ((System.Drawing.Image)(resources.GetObject("btn_consultar.Image")));
            this.btn_consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_consultar.Location = new System.Drawing.Point(505, 140);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(170, 77);
            this.btn_consultar.TabIndex = 39;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click_1);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_salvar.Image = ((System.Drawing.Image)(resources.GetObject("btn_salvar.Image")));
            this.btn_salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_salvar.Location = new System.Drawing.Point(505, 23);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(170, 77);
            this.btn_salvar.TabIndex = 37;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Enabled = false;
            this.btn_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_atualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_atualizar.Location = new System.Drawing.Point(786, 140);
            this.btn_atualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(170, 77);
            this.btn_atualizar.TabIndex = 42;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 525);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_salvar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tamanho;
        private System.Windows.Forms.TextBox txt_cor;
        private System.Windows.Forms.TextBox txt_especie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_habitat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_atualizar;
    }
}

