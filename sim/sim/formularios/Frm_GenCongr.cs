using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sim.formularios
{
    public partial class Frm_GenCongr : Form
    {
        public Frm_GenCongr()
        {
            InitializeComponent();
        }


        private void Frm_GenCongr_Load(object sender, EventArgs e)
        {
            txt_g.Enabled = false;
            txt_k.Enabled = false;
            radiobtn_mixto.Checked = true;
        }


        private void btn_menuPrincipal_Click(object sender, EventArgs e)
        {
            principal ventana = new principal();
            ventana.Show();
            this.Close();

        }


        private void chkPeriodoMax_CheckedChanged(object sender, EventArgs e)
        {
            //Estan son validaciones para que si el usuario selecciona periodo maximo no pueda ingresar
            //valores de "a" y "m" manuales ya que se calculan en base a "k" y "g"
            if (chkPeriodoMax.Checked)
            {
                txt_a.Text = "";
                txt_m.Text = "";
                txt_a.Enabled = false;
                txt_m.Enabled = false;
                txt_g.Enabled = true;
                txt_k.Enabled = true;
            }
            else
            {
                txt_a.Enabled = true;
                txt_m.Enabled = true;
                txt_g.Enabled = false;
                txt_k.Enabled = false;
                txt_k.Text = "";
                txt_g.Text = "";

            }
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            //Antes de llamar al metodo cargadorDeGrilla validamos que los campos esten bien completados de acuerdo a las opciones que selecciono el usuario.Estas validaciones no pueden hacerse en el metodo cargadorDeGrilla sino antes.
            if (validarDatos())
            {
                gdrSerieAleatoria.Rows.Clear();
                cargadorDeGrilla();
            }


        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            cargadorDeGrilla();
        }

        private bool validarDatos()
        {
            if (chkPeriodoMax.Checked && radiobtn_multiplicativo.Checked)
            {
                if (int.Parse(txt_xo.Text) % 2 == 0)
                {
                    MessageBox.Show("La semilla X0 debe ser un numero impar.");
                    txt_xo.Text = "";
                    txt_xo.Focus();
                    return false;
                }
                return true;

            }
            if (radiobtn_mixto.Checked && chkPeriodoMax.Checked)
            {
                if (EsPrimoRelativo(Convert.ToDouble(txt_c.Text), Math.Pow(2, Convert.ToDouble(txt_g.Text))))
                {
                    return true;
                }
                MessageBox.Show("Introduzca un valor de 'c' que sea relativamente primo a 'm' donde 'm' es: 2 ^ g");
                txt_c.Text = "";
                txt_c.Focus();
                return false;
            }
            return true;
        }

        public void cargadorDeGrilla()
        {
            // La variable "var" va a contener la tupla de valores
            var valores = ObtenerValores();

            int X0 = valores.Item1;
            int A = valores.Item2;
            int C = valores.Item3;
            double M = valores.Item4;

            // Como los dos eventos "generar" y "proximo" conducen
            //al mismo metodo debemos verificar cual ejecutar en base
            //a si tenemos filas en la grilla o no
            if (gdrSerieAleatoria.Rows.Count.Equals(0))
            {

                double Xo = Convert.ToDouble((A * X0 + C) % M) / (M - 1);
                double resto = Convert.ToDouble((A * X0 + C) % M);

                //Con el ciclo for vamos generando cada valor y agregandolos
                //a la grilla al mismo tiempo. utilizamos la variable "resto"
                //para poder calcular el siguiente valor al final del ciclo.
                for (int i = 0; i < 20; i++)
                {
                    gdrSerieAleatoria.Rows.Add(i + 1, (Math.Truncate(Xo * 10000) / 10000));

                    double X1 = (A * resto + C) % M;
                    Xo = ((A * resto + C) % M) / (M - 1);
                    resto = X1;
                }
            }
            else
            {
                //Buscamos cuales son los ultimos valores de iteracion y valor de nuestra grilla para poder generar el siguiente valor
                int ultIter = gdrSerieAleatoria.Rows.Count;
                double ultValor = double.Parse(gdrSerieAleatoria.Rows[ultIter - 1].Cells[1].Value.ToString());
                double ultResto = Math.Round(ultValor * (M - 1));
                double Xo = Convert.ToDouble((A * ultResto + C) % M) / (M - 1);
                gdrSerieAleatoria.Rows.Add(ultIter + 1, (Math.Truncate(Xo * 10000) / 10000));
            }


        }

        private Tuple<int, int, int, double> ObtenerValores()
        {

            //Tomamos todos los valores de los TextBox y los pasamos a variables
            //y esos valores los retornamos en una tupla
            int Xo = Convert.ToInt32(txt_xo.Text);
            int c = Convert.ToInt32(txt_c.Text);


            if (chkPeriodoMax.Checked && radiobtn_multiplicativo.Checked)
            {
                int a = 3 + (8 * (Convert.ToInt32(txt_k.Text)));
                double m = Math.Pow(2, (Convert.ToDouble(txt_g.Text)));

                return Tuple.Create(Xo, a, c, m);
            }


            if (chkPeriodoMax.Checked && radiobtn_mixto.Checked)
            {
                int a = 1 + (4 * (Convert.ToInt32(txt_k.Text)));
                double m = Math.Pow(2, Convert.ToDouble(txt_g.Text));

                return Tuple.Create(Xo, a, c, m);
            }

            if (chkPeriodoMax.Checked == false)
            {
                int a = Convert.ToInt32(txt_a.Text);
                double m = Convert.ToDouble(txt_m.Text);

                return Tuple.Create(Xo, a, c, m);
            }

            return Tuple.Create(0, 0, 0, 0.0);


        }

        private void radiobtn_multiplicativo_CheckedChanged(object sender, EventArgs e)
        {
            //Aca nos aseguramos de que si la opcion de metodo es multiplicativo
            //textbox de c se autocomplete con 0 y se desactive.

            if (radiobtn_multiplicativo.Checked)
            {
                txt_c.Text = "0";
                txt_c.Enabled = false;
            }
            else
            {
                txt_c.Text = "";
                txt_c.Enabled = true;
            }
        }


        private bool EsPrimoRelativo(double num1, double num2)
        {

            //Dos numeros son primos relativos si no tienen otro divisor
            //común más que 1 y -1 por tanto lo que se debe hacer es calcular
            //el maximo divisor común entre dos numeros dados, y luego si el
            //resultado es igual a 1 o a -1, entonces los numeros son primos relativos, de lo contrario, no lo son.           
            {
                //calcular el maximo divisor común
                double resto;
                while (num2 != 0)
                {
                    resto = num1 % num2;
                    num1 = num2;
                    num2 = resto;
                }

                if (num1 == 1 || num1 == -1)
                {
                    return true;
                }
                return false;
            }
        }
    }

}
