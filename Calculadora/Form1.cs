using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class calculadora : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bot0_Click(object sender, EventArgs e)
        {
            texto.Text += "0";
        }

        private void bot1_Click(object sender, EventArgs e)
        {
            texto.Text += "1";
        }

        private void bot2_Click(object sender, EventArgs e)
        {
            texto.Text += "2";
        }

        private void bot3_Click(object sender, EventArgs e)
        {
            texto.Text += "3";
        }

        private void bot4_Click(object sender, EventArgs e)
        {
            texto.Text += "4";
        }

        private void bot5_Click(object sender, EventArgs e)
        {
            texto.Text += "5";
        }

        private void bot6_Click(object sender, EventArgs e)
        {
            texto.Text += "6";
        }

        private void bot7_Click(object sender, EventArgs e)
        {
            texto.Text += "7";
        }

        private void bot8_Click(object sender, EventArgs e)
        {
            texto.Text += "8";
        }

        private void bot9_Click(object sender, EventArgs e)
        {
            texto.Text += "9";
        }

        private void soma_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse (texto.Text, CultureInfo.InvariantCulture);
            texto.Text = "";
            operacao = "SOMA";
            lab.Text = "+";
        }

        private void exe_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(texto.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                texto.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUBTRAÇÃO")
            {
                texto.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULTIPLICAÇÃO")
            {
                texto.Text = Convert.ToString(valor1 * valor2);
            } 
            else if (operacao == "DIVISÃO")
            {
                texto.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void texto_TextChanged(object sender, EventArgs e)
        {

        }

        private void sub_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(texto.Text, CultureInfo.InvariantCulture);
            texto.Text = "";
            operacao = "SUBTRAÇÃO";
            lab.Text = "-";
        }

        private void mult_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(texto.Text, CultureInfo.InvariantCulture);
            texto.Text = "";
            operacao = "MULTIPLICAÇÃO";
            lab.Text = "x";
        }

        private void div_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(texto.Text, CultureInfo.InvariantCulture);
            texto.Text = "";
            operacao = "DIVISÃO";
            lab.Text = "/";
        }

        private void ce_Click(object sender, EventArgs e)
        {
            texto.Text = "";
        }

        private void c_Click(object sender, EventArgs e)
        {
            texto.Text = "";
            valor1 = 0;
            valor2 = 0;
            lab.Text = "";
        }

        private void ponto_Click(object sender, EventArgs e)
        {
            texto.Text += ".";
        }
    }
}
