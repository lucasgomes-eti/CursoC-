using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FicheiroTexto
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter objFicheiro = new StreamWriter(@"C:\Users\lucas\Documents\Visual Studio 2015\Projects\CursoCSharp\FicheiroTexto\file.txt", true, Encoding.Default);

                objFicheiro.WriteLine(textBox1.Text);
                textBox1.Text = "";
                textBox1.Focus();
                objFicheiro.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
                throw;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            StreamReader objFicheiro = new StreamReader(@"C:\Users\lucas\Documents\Visual Studio 2015\Projects\CursoCSharp\FicheiroTexto\file.txt", Encoding.Default);

            while (!objFicheiro.EndOfStream)
            {
                listBox1.Items.Add(objFicheiro.ReadLine());
            }

            objFicheiro.Dispose();
        }
    }
}
