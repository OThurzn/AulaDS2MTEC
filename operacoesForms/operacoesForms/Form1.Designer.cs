namespace operacoesForms
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
            this.divisao = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.soma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // divisao
            // 
            this.divisao.Image = global::operacoesForms.Properties.Resources.math_divide_icon_157513;
            this.divisao.Location = new System.Drawing.Point(344, 157);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(86, 85);
            this.divisao.TabIndex = 3;
            this.divisao.Text = "Dividir";
            this.divisao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.divisao.UseVisualStyleBackColor = true;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // multiplicacao
            // 
            this.multiplicacao.Image = global::operacoesForms.Properties.Resources.cancel_music_close_cross_icon_1238791;
            this.multiplicacao.Location = new System.Drawing.Point(236, 157);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(86, 85);
            this.multiplicacao.TabIndex = 2;
            this.multiplicacao.Text = "Multiplicar";
            this.multiplicacao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.multiplicacao.UseVisualStyleBackColor = true;
            this.multiplicacao.Click += new System.EventHandler(this.multiplicacao_Click);
            // 
            // subtracao
            // 
            this.subtracao.Image = global::operacoesForms.Properties.Resources.minus_gross_horizontal_straight_line_symbol_icon_icons_com_74137;
            this.subtracao.Location = new System.Drawing.Point(344, 43);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(86, 85);
            this.subtracao.TabIndex = 1;
            this.subtracao.Text = "Subtrair";
            this.subtracao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.subtracao.Click += new System.EventHandler(this.subtracao_Click);
            // 
            // soma
            // 
            this.soma.Image = global::operacoesForms.Properties.Resources.plussign_87467;
            this.soma.Location = new System.Drawing.Point(236, 43);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(86, 85);
            this.soma.TabIndex = 0;
            this.soma.Text = "Somar";
            this.soma.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.soma.UseVisualStyleBackColor = true;
            this.soma.Click += new System.EventHandler(this.soma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Primeiro número:";
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(40, 85);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(124, 20);
            this.txt_num1.TabIndex = 5;
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(40, 149);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(124, 20);
            this.txt_num2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Segundo número:";
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(40, 220);
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(124, 20);
            this.txt_result.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 311);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.soma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button multiplicacao;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Label label3;
    }
}

