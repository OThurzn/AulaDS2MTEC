namespace exemploOrientaçãoObjeto
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.divisao = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.soma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "resultado";
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(12, 37);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(92, 20);
            this.txt_num1.TabIndex = 3;
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(12, 82);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(92, 20);
            this.txt_num2.TabIndex = 4;
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(12, 122);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(92, 20);
            this.txt_resultado.TabIndex = 5;
            // 
            // divisao
            // 
            this.divisao.Location = new System.Drawing.Point(136, 118);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(76, 21);
            this.divisao.TabIndex = 13;
            this.divisao.Text = "Dividir";
            this.divisao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.divisao.UseVisualStyleBackColor = true;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // multiplicacao
            // 
            this.multiplicacao.Location = new System.Drawing.Point(136, 91);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(76, 21);
            this.multiplicacao.TabIndex = 12;
            this.multiplicacao.Text = "Multiplicar";
            this.multiplicacao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.multiplicacao.UseVisualStyleBackColor = true;
            this.multiplicacao.Click += new System.EventHandler(this.multiplicacao_Click);
            // 
            // subtracao
            // 
            this.subtracao.Location = new System.Drawing.Point(136, 64);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(76, 21);
            this.subtracao.TabIndex = 11;
            this.subtracao.Text = "Subtrair";
            this.subtracao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.subtracao.Click += new System.EventHandler(this.subtracao_Click);
            // 
            // soma
            // 
            this.soma.Location = new System.Drawing.Point(136, 37);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(76, 21);
            this.soma.TabIndex = 10;
            this.soma.Text = "Somar";
            this.soma.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.soma.UseVisualStyleBackColor = true;
            this.soma.Click += new System.EventHandler(this.soma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 151);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Button multiplicacao;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button soma;
    }
}

