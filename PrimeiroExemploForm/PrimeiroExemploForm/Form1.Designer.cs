namespace PrimeiroExemploForm
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
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_outro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.Brown;
            this.btn_1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_1.Location = new System.Drawing.Point(12, 190);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(117, 45);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "Click aqui";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_outro
            // 
            this.btn_outro.BackColor = System.Drawing.Color.Brown;
            this.btn_outro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_outro.Location = new System.Drawing.Point(147, 190);
            this.btn_outro.Name = "btn_outro";
            this.btn_outro.Size = new System.Drawing.Size(114, 45);
            this.btn_outro.TabIndex = 1;
            this.btn_outro.Text = "Outro botão";
            this.btn_outro.UseVisualStyleBackColor = false;
            this.btn_outro.Click += new System.EventHandler(this.btn_outro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_outro);
            this.Controls.Add(this.btn_1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_outro;
    }
}

