using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ConversaoValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter objFicheiro = new StreamWriter(@"C:\Users\lucas\Documents\Visual Studio 2015\Projects\CursoCSharp\ConversaoValores\file.txt", false, Encoding.Default);

            //string
            objFicheiro.WriteLine("Teste");

            //int
            int valor = 10;
            objFicheiro.WriteLine(valor);

            //boleano
            bool resultado = true;
            objFicheiro.WriteLine(resultado);

            //data
            objFicheiro.WriteLine(DateTime.Now);

            //cor
            Color cor = Color.FromArgb(255, 255, 0);
            objFicheiro.WriteLine(cor.ToArgb());

            objFicheiro.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader objFicheiro = new StreamReader(@"C:\Users\lucas\Documents\Visual Studio 2015\Projects\CursoCSharp\ConversaoValores\file.txt", Encoding.Default);

            string a = objFicheiro.ReadLine();
            int b = int.Parse(objFicheiro.ReadLine());
            bool c = bool.Parse(objFicheiro.ReadLine());
            DateTime d = DateTime.Parse(objFicheiro.ReadLine());
            Color f = Color.FromArgb(Convert.ToInt16(objFicheiro.ReadLine()));

            objFicheiro.Dispose();

            pictureBox1.BackColor = f;
        }
    }
}
