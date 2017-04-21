using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoMDI
{
    public partial class Form1 : Form
    {
        public Form1(Form fmrParent)
        {
            InitializeComponent();

            MdiParent = fmrParent;

            int largura = DisplayRectangle.Width;
            int altura = DisplayRectangle.Height;

            Location = new Point((largura / 2) - Width / 2,
                (altura / 2) - Height / 2);

            MessageBox.Show($"Dimensões: {largura} x {altura}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
