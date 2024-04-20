using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraGUI
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

        private void btnSuma_Click(object sender, EventArgs e)
        {

            string numero1 = txtPrimerNumero.Text;
            string numero2 = txtSegundoNumero.Text;
            int numero1_int = 0;
            int numero2_int = 0;

            if (numero1.Length > 0 && numero2.Length > 0)
            {
                try
                {
                    numero1_int = (int)Convert.ToDouble(numero1);
                    numero2_int = Convert.ToInt32(numero2);

                } catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                    txtPrimerNumero.Text = "";
                    txtSegundoNumero.Text = "";
                }
            } else {
                MessageBox.Show("El campo no puede estar vacio");
            }

            int resultado = numero1_int + numero2_int;
            lblResultado.Text = resultado.ToString();

        }

        private void btnResta_Click(object sender, EventArgs e)
        {

            string numero1 = txtPrimerNumero.Text;
            string numero2 = txtSegundoNumero.Text;
            int numero1_int = 0;
            int numero2_int = 0;

            if (numero1.Length > 0 && numero2.Length > 0)
            {
                try
                {
                    numero1_int = (int)Convert.ToDouble(numero1);
                    numero2_int = Convert.ToInt32(numero2);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtPrimerNumero.Text = "";
                    txtSegundoNumero.Text = "";
                }
            }
            else
            {
                MessageBox.Show("El campo no puede estar vacio");
            }

            int resultado = numero1_int - numero2_int;
            lblResultado.Text = resultado.ToString();

        }

        private void btnProducto_Click(object sender, EventArgs e)
        {

            string numero1 = txtPrimerNumero.Text;
            string numero2 = txtSegundoNumero.Text;
            int numero1_int = 0;
            int numero2_int = 0;

            if (numero1.Length > 0 && numero2.Length > 0)
            {
                try
                {
                    numero1_int = (int)Convert.ToDouble(numero1);
                    numero2_int = Convert.ToInt32(numero2);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtPrimerNumero.Text = "";
                    txtSegundoNumero.Text = "";
                }
            }
            else
            {
                MessageBox.Show("El campo no puede estar vacio");
            }

            int resultado = numero1_int * numero2_int;
            lblResultado.Text = resultado.ToString();

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {

            string numero1 = txtPrimerNumero.Text;
            string numero2 = txtSegundoNumero.Text;
            double numero1_double = 0;
            int numero1_int = 0;
            int numero2_int = 0;

            if(numero2 != "0")
            { 
                if (numero1.Length > 0 && numero2.Length > 0)
                {
                    try
                    {
                        numero1_int = Convert.ToInt32(numero1);
                        numero1_double = Convert.ToDouble(numero1_int);
                        numero2_int = Convert.ToInt32(numero2);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        txtPrimerNumero.Text = "";
                        txtSegundoNumero.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("El campo no puede estar vacio");
                }
            double resultado = numero1_double / numero2_int;
            lblResultado.Text = resultado.ToString("0.####");
            } else {
                MessageBox.Show("Error matemático: No se puede dividir por 0");
            }
        }
    }
}
