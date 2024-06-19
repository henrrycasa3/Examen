using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculadoraPostfija;
using CalculadoraPostfijaForms.Logica;

namespace CalculadoraPostfijaForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnDigito_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtExpresion.Text += btn.Text;
        }

        private void btnOperador_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtExpresion.Text += btn.Text;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string expresionInfija = txtExpresion.Text;
                string expresionPostfija = CalculadoraPostfijaForms.Logica.CalculadoraPostfija.ConvertirAPostfijo(expresionInfija);
                txtExpresionPostfija.Text = expresionPostfija;
                double resultado = CalculadoraPostfijaForms.Logica.CalculadoraPostfija.EvaluarPostfijo(expresionPostfija);
                txtResultado.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // Verificar si hay texto en el cuadro de texto
            if (!string.IsNullOrEmpty(txtExpresion.Text))
            {
                // Eliminar el último carácter
                txtExpresion.Text = txtExpresion.Text.Remove(txtExpresion.Text.Length - 1);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtExpresion.Text = "";
            txtExpresionPostfija.Text = "";
            txtResultado.Text = "";
        }
    }
}
