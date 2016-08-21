using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleCalculator
{
    public partial class Form1 : Form
    {
        double total;
        double ultimoNumero;
        string operador;
        // Subrotina Limpar 
        // todo private void é uma subrotina
        private void Limpar()
        {
            total = 0;
            ultimoNumero = 0;
            operador = "+";
            txtresult.Text = "";
        }

        private void Calcular()
        {
            switch (operador)
            {
                case "+": total = total + ultimoNumero;
                    break;
                case "-": total = total - ultimoNumero;
                    break;
                case "/": total = total / ultimoNumero;
                    break;
                case "x": total = total * ultimoNumero;
                    break;
            }
            ultimoNumero = 0;
            txtresult.Text = total.ToString();
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void gerarNumero(object sender, EventArgs e)
        {
            if (ultimoNumero == 0)
            {
                txtresult.Text = (sender as Button).Text;
            }
            else
            {
                txtresult.Text = txtresult.Text + (sender as Button).Text;
            }

            ultimoNumero = Convert.ToDouble(txtresult.Text);
        }

        private void operadores(object sender, EventArgs e)
        {
            ultimoNumero = Convert.ToDouble(txtresult.Text);
            Calcular();
            operador = (sender as Button).Text;
        }

        private void btresult_Click(object sender, EventArgs e)
        {
            ultimoNumero = Convert.ToDouble(txtresult.Text);
            Calcular();
            operador = "+";
            total = 0;
        }
    }
}
