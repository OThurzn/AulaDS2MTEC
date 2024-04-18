namespace exemplos_encapsulamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.btn_armazenar = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_mostrar_nome = new System.Windows.Forms.Label();
            this.lbl_mostrar_cpf = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o CPF:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(29, 59);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(111, 20);
            this.txt_nome.TabIndex = 2;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(29, 118);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(111, 20);
            this.txt_cpf.TabIndex = 3;
            // 
            // btn_armazenar
            // 
            this.btn_armazenar.Location = new System.Drawing.Point(319, 13);
            this.btn_armazenar.Name = "btn_armazenar";
            this.btn_armazenar.Size = new System.Drawing.Size(121, 50);
            this.btn_armazenar.TabIndex = 4;
            this.btn_armazenar.Text = "Armazenar em Set";
            this.btn_armazenar.UseVisualStyleBackColor = true;
            this.btn_armazenar.Click += new System.EventHandler(this.btn_armazenar_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(319, 97);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(121, 50);
            this.btn_mostrar.TabIndex = 5;
            this.btn_mostrar.Text = "Mostrar em Get";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "nome do Aluno:";
            // 
            // lbl_mostrar_nome
            // 
            this.lbl_mostrar_nome.AutoSize = true;
            this.lbl_mostrar_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mostrar_nome.Location = new System.Drawing.Point(135, 158);
            this.lbl_mostrar_nome.Name = "lbl_mostrar_nome";
            this.lbl_mostrar_nome.Size = new System.Drawing.Size(102, 18);
            this.lbl_mostrar_nome.TabIndex = 7;
            this.lbl_mostrar_nome.Text = "Mostrar nome";
            // 
            // lbl_mostrar_cpf
            // 
            this.lbl_mostrar_cpf.AutoSize = true;
            this.lbl_mostrar_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mostrar_cpf.Location = new System.Drawing.Point(137, 176);
            this.lbl_mostrar_cpf.Name = "lbl_mostrar_cpf";
            this.lbl_mostrar_cpf.Size = new System.Drawing.Size(102, 18);
            this.lbl_mostrar_cpf.TabIndex = 9;
            this.lbl_mostrar_cpf.Text = "Mostrar nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "nome do Aluno:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 220);
            this.Controls.Add(this.lbl_mostrar_cpf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_mostrar_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.btn_armazenar);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Button btn_armazenar;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_mostrar_nome;
        private System.Windows.Forms.Label lbl_mostrar_cpf;
        private System.Windows.Forms.Label label6;
    }
}

