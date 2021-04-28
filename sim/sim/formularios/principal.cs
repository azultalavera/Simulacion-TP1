using sim.formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sim
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void showForm(Form form, Panel panel)
        {
            panel.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            panel.Controls.Add(form);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_GenCongr ventana = new Frm_GenCongr();
            showForm(ventana, panel1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_ChiCuadrado ventana = new Frm_ChiCuadrado();
            
            showForm(ventana, panel1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_ChiCuadMCM ventana = new Frm_ChiCuadMCM();
            
            showForm(ventana, panel1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void principal_Load(object sender, EventArgs e)
        {

        }
    }
}
