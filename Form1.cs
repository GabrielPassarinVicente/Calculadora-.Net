using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnSomar_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt32(textBox1.Text);
            valor2 = Convert.ToInt32(textBox2.Text);    

            resultado = valor1 + valor2;

            label3.Text = resultado.ToString(); 
        }
        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt32(textBox1.Text);
            valor2 = Convert.ToInt32(textBox2.Text);

            resultado = valor1 - valor2;

            label3.Text = resultado.ToString();
        }
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt32(textBox1.Text);
            valor2 = Convert.ToInt32(textBox2.Text);

            resultado = valor1 * valor2;

            label3.Text = resultado.ToString();
        }
        private void btnDividir_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt32(textBox1.Text);
            valor2 = Convert.ToInt32(textBox2.Text);

            resultado = valor1 / valor2;

            label3.Text = resultado.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
