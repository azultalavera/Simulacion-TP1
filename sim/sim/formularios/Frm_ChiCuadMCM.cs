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
    public partial class Frm_ChiCuadMCM : Form
    {
        public Frm_ChiCuadMCM()
        {
            InitializeComponent();
            txt_g.Enabled = false;
            txt_k.Enabled = false;
        }

        private void btn_menuPrincipal_Click(object sender, EventArgs e)
        {
            principal ventana = new principal();
            ventana.Show();
            this.Close();
        }
        private void btn_generar_Click(object sender, EventArgs e)
        {

        }

        public void cargadorDeGrilla(int N)
        {
            // La variable "var" va a contener la tupla de valores
            var valores = ObtenerValores();


            int X0 = valores.Item1;
            int A = valores.Item2;
            int C = valores.Item3;
            double M = valores.Item4;

            // Como los dos eventos "generar" y "proximo" conducen al mismo metodo debemos verificar cual ejecutar en base a si tenemos filas en la grilla o no

            double Xo = Convert.ToDouble((A * X0 + C) % (M)) / (M - 1);
            double resto = Convert.ToDouble((A * X0 + C) % M);
            //Con el ciclo for vamos generando cada valor y agregandolos a la grilla al mismo tiempo. utilizamos la variable "resto" para poder calcular el siguiente valor al final del ciclo.
            for (int i = 0; i < N; i++)
            {
                gdrSerieAleatoria.Rows.Add(i + 1, (Math.Truncate(Xo * 10000) / 10000));

                double X1 = (A * resto) % M;
                Xo = ((A * resto) % M) / (M - 1);
                resto = X1;
            }
        }

        private Tuple<int, int, int, double> ObtenerValores()
        {

            //Tomamos todos los valores de los TextBox y los pasamos a variables y esos valores los retornamos en una tupla
            int Xo = Convert.ToInt32(txt_xo.Text);
            int c = Convert.ToInt32(txt_c.Text);

            if (chkPeriodoMax.Checked)
            {
                int a = 3 + (8 * (Convert.ToInt32(txt_k.Text)));
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

        int tam_n;

        //double[] vectorS = new double[tam_n];
        int k;
        private int getK()
        {
            if (radiobtn_5.Checked)
                k = 5;
            else if (radiobtn_10.Checked)
                k = 10;
            else if (radiobtn_15.Checked)
                k = 15;
            else if (radiobtn_20.Checked)
                k = 20;

            return k;
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_ChiCuadMCM_Load(object sender, EventArgs e)
        {
            radiobtn_5.Checked = true;
            txtNivelSignificancia.Text = "95 %";
            txtNivelSignificancia.Enabled = false;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private double CalcularValorTab(int k)
        {
            if (k == 5)
                return 9.49;
            else if (k == 10)
                return 16.9;
            else if (k == 15)
                return 23.7;
            else if (k == 20)
                return 30.1;
            return 0;
        }

        private void ValidarHipotesis(int k)
        {

            int cantFilas = tabla.Rows.Count;
            double valorCalculado = Convert.ToDouble(tabla.Rows[cantFilas - 1].Cells[5].Value);
            double valorTabulado = CalcularValorTab(k);

            if (valorCalculado < valorTabulado)
                lbl_resHipotesis.Text = "se acepta la hipotesis!";
            else
                lbl_resHipotesis.Text = "no se acepta la hipotesis!";
            txt_ValorTabulado.Text = Convert.ToString(valorTabulado);
        }

        private double randomDouble(Random r)
        {
            double random = r.NextDouble();
            random = Math.Truncate(random * 100) / 100;

            return random;

        }

        private void frecuenciaObservada(DataGridView tabla_serie, DataGridView tabla)
        {
            for (int i = 0; i < tabla_serie.Rows.Count; i++)
            {
                for (int j = 0; j < tabla.Rows.Count; j++)
                {
                    if (Convert.ToDouble(tabla_serie.Rows[i].Cells[1].Value) >= Convert.ToDouble(tabla.Rows[j].Cells[0].Value) && Convert.ToDouble(tabla_serie.Rows[i].Cells[1].Value) <= Convert.ToDouble(tabla.Rows[j].Cells[1].Value))
                    {
                        tabla.Rows[j].Cells[2].Value = Convert.ToDouble(tabla.Rows[j].Cells[2].Value) + 1;
                    }

                }
            }

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (tabla.Rows[i].Cells[2].Value != null)
                {
                    chrt_graf.Series["Frecuencia Observada"].Points.AddXY(tabla.Rows[i].Cells[1].Value, tabla.Rows[i].Cells[2].Value);
                }
                else
                    tabla.Rows[i].Cells[2].Value = 0;
            }
        }

        private void frecuenciaEsperada(int n, int k, DataGridView tabla)
        {
            double frecuenciaEsperada = n / Convert.ToDouble(k);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                tabla.Rows[i].Cells[3].Value = frecuenciaEsperada;
            }
        }

        private void estadistico(int n, int k, DataGridView tabla)
        {
            double estadisticoAcumulado;

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                int fo = Convert.ToInt32(tabla.Rows[i].Cells[2].Value);
                int fe = Convert.ToInt32(tabla.Rows[i].Cells[3].Value);

                double estadistico = Math.Pow((fo - fe), 2) / fe;
                estadistico = Math.Truncate(estadistico * 1000) / 1000;
                tabla.Rows[i].Cells[4].Value = estadistico;

                if (i == 0)
                {
                    estadisticoAcumulado = Convert.ToDouble(tabla.Rows[i].Cells[4].Value);
                    tabla.Rows[i].Cells[5].Value = estadisticoAcumulado;

                }
                else
                {
                    estadisticoAcumulado = Convert.ToDouble(tabla.Rows[i].Cells[4].Value) + Convert.ToDouble(tabla.Rows[i - 1].Cells[5].Value);
                    tabla.Rows[i].Cells[5].Value = estadisticoAcumulado;
                }

                if ((tabla.Rows.Count - 1) == i)
                    tabla.Rows[i].Cells[5].Style.BackColor = Color.FromArgb(237, 187, 0);
            }
        }
        private void cargadorDeGrillaSerie2(DataGridView tabla, int n)
        {
            //tabla.RowCount = n;
            Random r = new Random();

            for (int i = 0; i < (n); i++)
            {
                double random = randomDouble(r);
                int indice = i + 1;
                tabla.Rows.Add(indice.ToString(), random.ToString());

            }
        }

        private double[][] vectorIntervalos(int k)
        {
            double[][] intervalo = new double[k][];
            double[] inter = new double[2];
            double m = Convert.ToDouble(k);
            double division = 1 / m;
            //MessageBox.Show(division.ToString(), "division");
            for (int i = 0; i < k; i++)
            {
                double limSuperior = (((i + 1) * division) - 0.01);
                double limInferior = (i * division);


                double[] interv = new double[2];
                interv[0] = Math.Truncate(limInferior * 100) / 100; ;
                interv[1] = Math.Truncate(limSuperior * 100) / 100;

                intervalo[i] = interv;

            }
            return intervalo;
        }

        private void cargadorDeGrillaIntervalos(int k, DataGridView tabla, double[][] vectorIntervalos)
        {
            tabla.RowCount = k;

            for (int i = 0; i < k; i++)
            {
                //j < vectorIntervalos[i].Length
                for (int j = 0; j < 2; j++)
                {
                    tabla.Rows[i].Cells[j].Value = vectorIntervalos[i][j].ToString();
                }
            }
        }

        private bool validaciones(TextBox txt, RadioButton radio1, RadioButton radio2, RadioButton radio3, RadioButton radio4)
        {
            bool valido = false;

            if (radio1.Checked == true || radio2.Checked == true || radio3.Checked == true || radio4.Checked == true)
            {
                valido = true;
            }
            else
            {
                valido = false;
            }
            return valido;

        }

        private void ChkPeriodoMax_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Btn_proximo_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_generar_Click_2(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(txt_tamMuestra.Text);
            cargadorDeGrilla(N);

            chrt_graf.Series.Clear();
            chrt_graf.Series.Add("Frecuencia Observada");

            int k = getK();

            int validarEntero;
            if (!int.TryParse(txt_tamMuestra.Text, out validarEntero))
            {
                MessageBox.Show("Error!, Ingresar un número entero!");
            }
            else
            {
                tam_n = Int32.Parse(txt_tamMuestra.Text);
            }

            bool v = validaciones(txt_tamMuestra, radiobtn_5, radiobtn_10, radiobtn_15, radiobtn_20);

            if (v)
            {
                tabla.Rows.Clear();
                gdrSerieAleatoria.Rows.Clear();

                double[][] vIntervalos = vectorIntervalos(k);
                cargadorDeGrillaSerie2(gdrSerieAleatoria, tam_n);
                cargadorDeGrillaIntervalos(k, tabla, vIntervalos);
                frecuenciaObservada(gdrSerieAleatoria, tabla);
                frecuenciaEsperada(tam_n, k, tabla);
                estadistico(tam_n, k, tabla);


            }
            ValidarHipotesis(k);
        }

        private void chkPeriodoMax_CheckedChanged(object sender, EventArgs e)
        {
            //Estan son validaciones para que si el usuario selecciona periodo maximo no pueda ingresar
            //valores de "a" y "m" manuales ya que se calculan en base a "k" y "g"
            if (chkPeriodoMax.Checked == true)
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

        private void Frm_ChiCuadMCM_Load_1(object sender, EventArgs e)
        {
            radiobtn_5.Checked = true;
            txtNivelSignificancia.Text = "95 %";
            txtNivelSignificancia.Enabled = false;
        }
    }
}
