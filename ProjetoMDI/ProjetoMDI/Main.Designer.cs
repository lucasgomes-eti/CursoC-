namespace ProjetoMDI
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirFormulárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulário1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirFormulárioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirFormulárioToolStripMenuItem
            // 
            this.abrirFormulárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulário1ToolStripMenuItem});
            this.abrirFormulárioToolStripMenuItem.Name = "abrirFormulárioToolStripMenuItem";
            this.abrirFormulárioToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.abrirFormulárioToolStripMenuItem.Text = "Abrir Formulário";
            // 
            // formulário1ToolStripMenuItem
            // 
            this.formulário1ToolStripMenuItem.Name = "formulário1ToolStripMenuItem";
            this.formulário1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.formulário1ToolStripMenuItem.Text = "Formulário 1";
            this.formulário1ToolStripMenuItem.Click += new System.EventHandler(this.fromulário1ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 495);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirFormulárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulário1ToolStripMenuItem;
    }
}

