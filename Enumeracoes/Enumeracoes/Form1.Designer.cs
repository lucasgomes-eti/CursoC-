namespace Enumeracoes
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
            this.btnCima = new System.Windows.Forms.Button();
            this.btnBaixo = new System.Windows.Forms.Button();
            this.btnEsquerda = new System.Windows.Forms.Button();
            this.btnDireita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCima
            // 
            this.btnCima.Location = new System.Drawing.Point(148, 12);
            this.btnCima.Name = "btnCima";
            this.btnCima.Size = new System.Drawing.Size(75, 120);
            this.btnCima.TabIndex = 0;
            this.btnCima.Text = "Cima";
            this.btnCima.UseVisualStyleBackColor = true;
            this.btnCima.Click += new System.EventHandler(this.btnCima_Click);
            // 
            // btnBaixo
            // 
            this.btnBaixo.Location = new System.Drawing.Point(148, 167);
            this.btnBaixo.Name = "btnBaixo";
            this.btnBaixo.Size = new System.Drawing.Size(75, 120);
            this.btnBaixo.TabIndex = 1;
            this.btnBaixo.Text = "Baixo";
            this.btnBaixo.UseVisualStyleBackColor = true;
            this.btnBaixo.Click += new System.EventHandler(this.btnBaixo_Click);
            // 
            // btnEsquerda
            // 
            this.btnEsquerda.Location = new System.Drawing.Point(12, 138);
            this.btnEsquerda.Name = "btnEsquerda";
            this.btnEsquerda.Size = new System.Drawing.Size(139, 23);
            this.btnEsquerda.TabIndex = 2;
            this.btnEsquerda.Text = "Esquerda";
            this.btnEsquerda.UseVisualStyleBackColor = true;
            this.btnEsquerda.Click += new System.EventHandler(this.btnEsquerda_Click);
            // 
            // btnDireita
            // 
            this.btnDireita.Location = new System.Drawing.Point(221, 138);
            this.btnDireita.Name = "btnDireita";
            this.btnDireita.Size = new System.Drawing.Size(160, 23);
            this.btnDireita.TabIndex = 3;
            this.btnDireita.Text = "Direita";
            this.btnDireita.UseVisualStyleBackColor = true;
            this.btnDireita.Click += new System.EventHandler(this.btnDireita_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 299);
            this.Controls.Add(this.btnDireita);
            this.Controls.Add(this.btnEsquerda);
            this.Controls.Add(this.btnBaixo);
            this.Controls.Add(this.btnCima);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCima;
        private System.Windows.Forms.Button btnBaixo;
        private System.Windows.Forms.Button btnEsquerda;
        private System.Windows.Forms.Button btnDireita;
    }
}

