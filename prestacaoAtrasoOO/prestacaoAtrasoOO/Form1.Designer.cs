namespace prestacaoAtrasoOO
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
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_jurosFinal = new System.Windows.Forms.TextBox();
            this.txt_tempo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_taxa = new System.Windows.Forms.TextBox();
            this.txt_vprest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_valorFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(163, 134);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(79, 60);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_jurosFinal
            // 
            this.txt_jurosFinal.Location = new System.Drawing.Point(163, 56);
            this.txt_jurosFinal.Name = "txt_jurosFinal";
            this.txt_jurosFinal.ReadOnly = true;
            this.txt_jurosFinal.Size = new System.Drawing.Size(92, 20);
            this.txt_jurosFinal.TabIndex = 25;
            // 
            // txt_tempo
            // 
            this.txt_tempo.Location = new System.Drawing.Point(33, 155);
            this.txt_tempo.Name = "txt_tempo";
            this.txt_tempo.Size = new System.Drawing.Size(92, 20);
            this.txt_tempo.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "valor juros";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "dias em atraso";
            // 
            // txt_taxa
            // 
            this.txt_taxa.Location = new System.Drawing.Point(33, 101);
            this.txt_taxa.Name = "txt_taxa";
            this.txt_taxa.Size = new System.Drawing.Size(92, 20);
            this.txt_taxa.TabIndex = 21;
            // 
            // txt_vprest
            // 
            this.txt_vprest.Location = new System.Drawing.Point(33, 56);
            this.txt_vprest.Name = "txt_vprest";
            this.txt_vprest.Size = new System.Drawing.Size(92, 20);
            this.txt_vprest.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "taxa juros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "valor emprestado";
            // 
            // txt_valorFinal
            // 
            this.txt_valorFinal.Location = new System.Drawing.Point(161, 101);
            this.txt_valorFinal.Name = "txt_valorFinal";
            this.txt_valorFinal.ReadOnly = true;
            this.txt_valorFinal.Size = new System.Drawing.Size(92, 20);
            this.txt_valorFinal.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "valor prestação";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 221);
            this.Controls.Add(this.txt_valorFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_jurosFinal);
            this.Controls.Add(this.txt_tempo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_taxa);
            this.Controls.Add(this.txt_vprest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_jurosFinal;
        private System.Windows.Forms.TextBox txt_tempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_taxa;
        private System.Windows.Forms.TextBox txt_vprest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_valorFinal;
        private System.Windows.Forms.Label label3;
    }
}

