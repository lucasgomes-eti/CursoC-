namespace Encapsulamento
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
            this.btnExecutar = new System.Windows.Forms.Button();
            this.rdAlimento = new System.Windows.Forms.RadioButton();
            this.rdRoupa = new System.Windows.Forms.RadioButton();
            this.rdHigiene = new System.Windows.Forms.RadioButton();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(12, 226);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(360, 23);
            this.btnExecutar.TabIndex = 0;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // rdAlimento
            // 
            this.rdAlimento.AutoSize = true;
            this.rdAlimento.Location = new System.Drawing.Point(12, 12);
            this.rdAlimento.Name = "rdAlimento";
            this.rdAlimento.Size = new System.Drawing.Size(65, 17);
            this.rdAlimento.TabIndex = 1;
            this.rdAlimento.TabStop = true;
            this.rdAlimento.Text = "Alimento";
            this.rdAlimento.UseVisualStyleBackColor = true;
            // 
            // rdRoupa
            // 
            this.rdRoupa.AutoSize = true;
            this.rdRoupa.Location = new System.Drawing.Point(12, 35);
            this.rdRoupa.Name = "rdRoupa";
            this.rdRoupa.Size = new System.Drawing.Size(57, 17);
            this.rdRoupa.TabIndex = 2;
            this.rdRoupa.TabStop = true;
            this.rdRoupa.Text = "Roupa";
            this.rdRoupa.UseVisualStyleBackColor = true;
            // 
            // rdHigiene
            // 
            this.rdHigiene.AutoSize = true;
            this.rdHigiene.Location = new System.Drawing.Point(12, 58);
            this.rdHigiene.Name = "rdHigiene";
            this.rdHigiene.Size = new System.Drawing.Size(61, 17);
            this.rdHigiene.TabIndex = 3;
            this.rdHigiene.TabStop = true;
            this.rdHigiene.Text = "Higiene";
            this.rdHigiene.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(12, 94);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(360, 20);
            this.txtValor.TabIndex = 4;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 78);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(277, 13);
            this.lblValor.TabIndex = 5;
            this.lblValor.Text = "Insira Valor Para Calculo de Porcentagem Sobre Produto:";
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 121);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(360, 102);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.rdHigiene);
            this.Controls.Add(this.rdRoupa);
            this.Controls.Add(this.rdAlimento);
            this.Controls.Add(this.btnExecutar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.RadioButton rdAlimento;
        private System.Windows.Forms.RadioButton rdRoupa;
        private System.Windows.Forms.RadioButton rdHigiene;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblResultado;
    }
}

