using System;
using System.Windows.Forms;

namespace CalculadoraProject
{
    public enum Operacion
    {
        NoDefinida = 0,
        Suma = 1,
        Resta = 2,
        Division = 3,
        Multiplicacion = 4,
        Modulo = 5

    }
    public partial class Form1 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        Operacion operador = Operacion.NoDefinida;
        bool unNumeroLeido = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void LeerNumero(string numero)
        {
            unNumeroLeido = true;
            if (cajaResultado.Text == "0" && cajaResultado.Text != null)
            {
                cajaResultado.Text = numero;
            }
            else
            {
                cajaResultado.Text += numero;
            }
        }

        private decimal EjecutarOperacion()
        {
            decimal resultado = 0;
            switch (operador)
            {
                case Operacion.Suma:
                    resultado = valor1 + valor2;
                    break;
                case Operacion.Resta:
                    resultado = valor1 - valor2;
                    break;
                case Operacion.Division:
                    if(valor2 == 0)
                    {
                        lblHistorial.Text = "No se puede dividir entre 0";
                        resultado = 0;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;
                case Operacion.Multiplicacion:
                    resultado = valor1 * valor2;    
                    break;
                case Operacion.Modulo:
                    resultado = valor1 % valor2;
                    break;
            }

            return resultado;
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            unNumeroLeido = true;
            if (cajaResultado.Text == "0")
            {
                return;
            }
            else
            {
                cajaResultado.Text += "0";
            }
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            LeerNumero("1");
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            LeerNumero("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            LeerNumero("3");
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            LeerNumero("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            LeerNumero("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            LeerNumero("6");
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            LeerNumero("7");
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            LeerNumero("8");
        }
        private void btnNueve_Click(object sender, EventArgs e)
        {
            LeerNumero("9");
        }

        private void ObtenerValor(string operador)
        {
            valor1 = Convert.ToDecimal(cajaResultado.Text);
            lblHistorial.Text = cajaResultado.Text + operador;
            cajaResultado.Text = "0";
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = Operacion.Suma;
            ObtenerValor("+");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (valor2 == 0 && unNumeroLeido)
            {
                valor2 = Convert.ToDecimal(cajaResultado.Text);
                lblHistorial.Text += valor2 + "=";
                decimal resultado = EjecutarOperacion();
                valor1 = 0;
                valor2 = 0;
                unNumeroLeido = false;
                cajaResultado.Text = Convert.ToString(resultado);   

            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = Operacion.Resta;
            ObtenerValor("-");
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = Operacion.Multiplicacion;
            ObtenerValor("x");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = Operacion.Division;
            ObtenerValor("/");
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            operador = Operacion.Modulo;
            ObtenerValor("%");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cajaResultado.Text = "0";
            lblHistorial.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (cajaResultado.Text.Length > 1)
            {
                string txtResultado = cajaResultado.Text;   
                txtResultado = txtResultado.Substring(0,txtResultado.Length - 1);
                if(txtResultado.Length == 1 && txtResultado.Contains("-"))
                {
                    cajaResultado.Text = "0";
                }
                else
                {
                    cajaResultado.Text = txtResultado;
                }
            }
            else
            {
                cajaResultado.Text = "0";
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (cajaResultado.Text.Contains(","))
            {
                return;
            }
            else
            {
                cajaResultado.Text += ",";
            }  
        }

        private void cajaResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHistorial_Click(object sender, EventArgs e)
        {

        }
    }
}
