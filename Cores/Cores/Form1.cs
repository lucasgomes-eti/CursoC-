using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void AlterarCor()
        {
            pictureBox1.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);

            label1.Text = $"Red: {trackBarRed.Value.ToString()}";
            label2.Text = $"Green: {trackBarGreen.Value.ToString()}";
            label3.Text = $"Blue: {trackBarBlue.Value.ToString()}";

            textBox1.Text = pictureBox1.BackColor.Name;
        }

        private void trackBarRed_ValueChanged(object sender, EventArgs e)
        {
            AlterarCor();
        }

        private void trackBarGreen_ValueChanged(object sender, EventArgs e)
        {
            AlterarCor();
        }

        private void trackBarBlue_ValueChanged(object sender, EventArgs e)
        {
            AlterarCor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AlterarCor();
        }
    }
}