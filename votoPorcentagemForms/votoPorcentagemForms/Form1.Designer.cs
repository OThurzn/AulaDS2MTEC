namespace votoPorcentagemForms
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
            this.txt_nulos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_brancos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_validos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prc_nulos = new System.Windows.Forms.TextBox();
            this.prc_brancos = new System.Windows.Forms.TextBox();
            this.prc_validos = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nulos
            // 
            this.txt_nulos.Location = new System.Drawing.Point(16, 193);
            this.txt_nulos.Name = "txt_nulos";
            this.txt_nulos.Size = new System.Drawing.Size(124, 20);
            this.txt_nulos.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Votos nulos:";
            // 
            // txt_brancos
            // 
            this.txt_brancos.Location = new System.Drawing.Point(16, 122);
            this.txt_brancos.Name = "txt_brancos";
            this.txt_brancos.Size = new System.Drawing.Size(124, 20);
            this.txt_brancos.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Votos brancos:";
            // 
            // txt_validos
            // 
            this.txt_validos.Location = new System.Drawing.Point(16, 58);
            this.txt_validos.Name = "txt_validos";
            this.txt_validos.Size = new System.Drawing.Size(124, 20);
            this.txt_validos.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Votos válidos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label6.Location = new System.Drawing.Point(471, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "porcentagem de votos nulos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label4.Location = new System.Drawing.Point(471, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "porcentagem de votos brancos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label5.Location = new System.Drawing.Point(471, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "porcentagem de votos válidos:";
            // 
            // prc_nulos
            // 
            this.prc_nulos.Location = new System.Drawing.Point(474, 193);
            this.prc_nulos.Name = "prc_nulos";
            this.prc_nulos.ReadOnly = true;
            this.prc_nulos.Size = new System.Drawing.Size(167, 20);
            this.prc_nulos.TabIndex = 27;
            // 
            // prc_brancos
            // 
            this.prc_brancos.AcceptsReturn = true;
            this.prc_brancos.Location = new System.Drawing.Point(474, 122);
            this.prc_brancos.Name = "prc_brancos";
            this.prc_brancos.ReadOnly = true;
            this.prc_brancos.Size = new System.Drawing.Size(167, 20);
            this.prc_brancos.TabIndex = 26;
            // 
            // prc_validos
            // 
            this.prc_validos.Location = new System.Drawing.Point(474, 58);
            this.prc_validos.Name = "prc_validos";
            this.prc_validos.ReadOnly = true;
            this.prc_validos.Size = new System.Drawing.Size(167, 20);
            this.prc_validos.TabIndex = 24;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(258, 67);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(124, 20);
            this.txt_total.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(265, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Total de votos:";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Image = global::votoPorcentagemForms.Properties.Resources.percent_icon_175006;
            this.btn_calcular.Location = new System.Drawing.Point(286, 122);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(60, 54);
            this.btn_calcular.TabIndex = 30;
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 234);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prc_nulos);
            this.Controls.Add(this.prc_brancos);
            this.Controls.Add(this.prc_validos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_nulos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_brancos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_validos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nulos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_brancos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_validos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prc_nulos;
        private System.Windows.Forms.TextBox prc_brancos;
        private System.Windows.Forms.TextBox prc_validos;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_calcular;
    }
}

