using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cifrado_Cesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Prueba Git
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCifrar_Click(object sender, EventArgs e)
        {
            richTextBoxCifrado.Text = CifradoCesar.Cifrado(textBox.Text, (int)numericUpDown1.Value);
        }

        private void btnDescif_Click(object sender, EventArgs e)
        {
            richTextBoxCifrado.Text = CifradoCesar.Descifrado(textBox.Text, (int)numericUpDown1.Value);
        }
    }
}
