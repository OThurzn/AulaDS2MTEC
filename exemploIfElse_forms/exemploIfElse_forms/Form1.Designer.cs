namespace exemploIfElse_forms
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
            this.rdb_manha = new System.Windows.Forms.RadioButton();
            this.rdb_tarde = new System.Windows.Forms.RadioButton();
            this.rdb_noite = new System.Windows.Forms.RadioButton();
            this.btn_escolha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdb_manha
            // 
            this.rdb_manha.AutoSize = true;
            this.rdb_manha.Location = new System.Drawing.Point(32, 44);
            this.rdb_manha.Name = "rdb_manha";
            this.rdb_manha.Size = new System.Drawing.Size(58, 17);
            this.rdb_manha.TabIndex = 0;
            this.rdb_manha.TabStop = true;
            this.rdb_manha.Text = "Manhã";
            this.rdb_manha.UseVisualStyleBackColor = true;
            // 
            // rdb_tarde
            // 
            this.rdb_tarde.AutoSize = true;
            this.rdb_tarde.Location = new System.Drawing.Point(32, 79);
            this.rdb_tarde.Name = "rdb_tarde";
            this.rdb_tarde.Size = new System.Drawing.Size(53, 17);
            this.rdb_tarde.TabIndex = 1;
            this.rdb_tarde.Text = "Tarde";
            this.rdb_tarde.UseVisualStyleBackColor = true;
            // 
            // rdb_noite
            // 
            this.rdb_noite.AutoSize = true;
            this.rdb_noite.Location = new System.Drawing.Point(32, 115);
            this.rdb_noite.Name = "rdb_noite";
            this.rdb_noite.Size = new System.Drawing.Size(50, 17);
            this.rdb_noite.TabIndex = 2;
            this.rdb_noite.Text = "Noite";
            this.rdb_noite.UseVisualStyleBackColor = true;
            // 
            // btn_escolha
            // 
            this.btn_escolha.Location = new System.Drawing.Point(306, 53);
            this.btn_escolha.Name = "btn_escolha";
            this.btn_escolha.Size = new System.Drawing.Size(75, 23);
            this.btn_escolha.TabIndex = 3;
            this.btn_escolha.Text = "Escolher";
            this.btn_escolha.UseVisualStyleBackColor = true;
            this.btn_escolha.Click += new System.EventHandler(this.btn_escolha_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 290);
            this.Controls.Add(this.btn_escolha);
            this.Controls.Add(this.rdb_noite);
            this.Controls.Add(this.rdb_tarde);
            this.Controls.Add(this.rdb_manha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_manha;
        private System.Windows.Forms.RadioButton rdb_tarde;
        private System.Windows.Forms.RadioButton rdb_noite;
        private System.Windows.Forms.Button btn_escolha;
    }
}

