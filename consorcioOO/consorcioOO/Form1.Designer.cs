namespace consorcioOO
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
            this.txt_saldoDevedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_totalPago = new System.Windows.Forms.TextBox();
            this.txt_valorPrest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Prestpagas = new System.Windows.Forms.TextBox();
            this.txt_totalPrest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_saldoDevedor
            // 
            this.txt_saldoDevedor.Location = new System.Drawing.Point(161, 115);
            this.txt_saldoDevedor.Name = "txt_saldoDevedor";
            this.txt_saldoDevedor.ReadOnly = true;
            this.txt_saldoDevedor.Size = new System.Drawing.Size(92, 20);
            this.txt_saldoDevedor.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Saldo devedor";
            // 
            // txt_totalPago
            // 
            this.txt_totalPago.Location = new System.Drawing.Point(163, 70);
            this.txt_totalPago.Name = "txt_totalPago";
            this.txt_totalPago.ReadOnly = true;
            this.txt_totalPago.Size = new System.Drawing.Size(92, 20);
            this.txt_totalPago.TabIndex = 36;
            // 
            // txt_valorPrest
            // 
            this.txt_valorPrest.Location = new System.Drawing.Point(33, 169);
            this.txt_valorPrest.Name = "txt_valorPrest";
            this.txt_valorPrest.Size = new System.Drawing.Size(92, 20);
            this.txt_valorPrest.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Total pago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Valor prestação";
            // 
            // txt_Prestpagas
            // 
            this.txt_Prestpagas.Location = new System.Drawing.Point(33, 115);
            this.txt_Prestpagas.Name = "txt_Prestpagas";
            this.txt_Prestpagas.Size = new System.Drawing.Size(92, 20);
            this.txt_Prestpagas.TabIndex = 32;
            // 
            // txt_totalPrest
            // 
            this.txt_totalPrest.Location = new System.Drawing.Point(33, 70);
            this.txt_totalPrest.Name = "txt_totalPrest";
            this.txt_totalPrest.Size = new System.Drawing.Size(92, 20);
            this.txt_totalPrest.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Prestações pagas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Total prestações";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(163, 148);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(79, 60);
            this.btn_calcular.TabIndex = 28;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt_saldoDevedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_totalPago);
            this.Controls.Add(this.txt_valorPrest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Prestpagas);
            this.Controls.Add(this.txt_totalPrest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_saldoDevedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_totalPago;
        private System.Windows.Forms.TextBox txt_valorPrest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Prestpagas;
        private System.Windows.Forms.TextBox txt_totalPrest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_calcular;
    }
}

