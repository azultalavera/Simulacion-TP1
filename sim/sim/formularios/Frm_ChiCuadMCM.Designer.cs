
namespace sim.formularios
{
    partial class Frm_ChiCuadMCM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_resHipotesis = new System.Windows.Forms.Label();
            this.txtNivelSignificancia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ValorTabulado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chrt_graf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdrSerieAleatoria = new System.Windows.Forms.DataGridView();
            this.desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_a = new System.Windows.Forms.Label();
            this.lbl_c = new System.Windows.Forms.Label();
            this.lbl_m = new System.Windows.Forms.Label();
            this.lbl_k = new System.Windows.Forms.Label();
            this.lbl_g = new System.Windows.Forms.Label();
            this.lbl_xo = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_xo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_g = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_k = new System.Windows.Forms.TextBox();
            this.txt_m = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radiobtn_20 = new System.Windows.Forms.RadioButton();
            this.radiobtn_15 = new System.Windows.Forms.RadioButton();
            this.radiobtn_10 = new System.Windows.Forms.RadioButton();
            this.radiobtn_5 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tamMuestra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.chkPeriodoMax = new System.Windows.Forms.CheckBox();
            this.groupBox5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_graf)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdrSerieAleatoria)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(16, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 2);
            this.panel1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 30);
            this.label1.TabIndex = 32;
            this.label1.Text = "Prueba de Frecuencia - Chi Cuadrado Metodo Congruencial Mixto\r\n";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.panel3);
            this.groupBox5.Controls.Add(this.chrt_graf);
            this.groupBox5.Location = new System.Drawing.Point(944, 78);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(322, 609);
            this.groupBox5.TabIndex = 51;
            this.groupBox5.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(17, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 125);
            this.panel3.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lbl_resHipotesis);
            this.panel2.Controls.Add(this.txtNivelSignificancia);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_ValorTabulado);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(9, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 107);
            this.panel2.TabIndex = 34;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbl_resHipotesis
            // 
            this.lbl_resHipotesis.AutoSize = true;
            this.lbl_resHipotesis.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_resHipotesis.Location = new System.Drawing.Point(12, 100);
            this.lbl_resHipotesis.Name = "lbl_resHipotesis";
            this.lbl_resHipotesis.Size = new System.Drawing.Size(0, 32);
            this.lbl_resHipotesis.TabIndex = 7;
            // 
            // txtNivelSignificancia
            // 
            this.txtNivelSignificancia.Location = new System.Drawing.Point(164, 18);
            this.txtNivelSignificancia.Name = "txtNivelSignificancia";
            this.txtNivelSignificancia.Size = new System.Drawing.Size(85, 29);
            this.txtNivelSignificancia.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 21);
            this.label9.TabIndex = 5;
            this.label9.Text = "Valor Tabulado";
            // 
            // txt_ValorTabulado
            // 
            this.txt_ValorTabulado.Location = new System.Drawing.Point(164, 62);
            this.txt_ValorTabulado.Name = "txt_ValorTabulado";
            this.txt_ValorTabulado.Size = new System.Drawing.Size(85, 29);
            this.txt_ValorTabulado.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nivel de significancia";
            // 
            // chrt_graf
            // 
            chartArea4.Name = "ChartArea1";
            this.chrt_graf.ChartAreas.Add(chartArea4);
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Name = "Legend1";
            this.chrt_graf.Legends.Add(legend4);
            this.chrt_graf.Location = new System.Drawing.Point(18, 190);
            this.chrt_graf.Name = "chrt_graf";
            this.chrt_graf.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Frecuencia Observada";
            this.chrt_graf.Series.Add(series4);
            this.chrt_graf.Size = new System.Drawing.Size(288, 364);
            this.chrt_graf.TabIndex = 33;
            this.chrt_graf.Text = "chart1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabla);
            this.groupBox3.Controls.Add(this.gdrSerieAleatoria);
            this.groupBox3.Location = new System.Drawing.Point(287, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(651, 609);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estadistico de prueba";
            // 
            // tabla
            // 
            this.tabla.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tabla.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabla.Location = new System.Drawing.Point(209, 50);
            this.tabla.Name = "tabla";
            this.tabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.tabla.RowHeadersVisible = false;
            this.tabla.Size = new System.Drawing.Size(436, 362);
            this.tabla.TabIndex = 44;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "desde";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 65;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "hasta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 65;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "fo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "fe";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "C";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "C(AC)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // gdrSerieAleatoria
            // 
            this.gdrSerieAleatoria.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gdrSerieAleatoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdrSerieAleatoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gdrSerieAleatoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdrSerieAleatoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.gdrSerieAleatoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrSerieAleatoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desde,
            this.hasta});
            this.gdrSerieAleatoria.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gdrSerieAleatoria.Location = new System.Drawing.Point(15, 50);
            this.gdrSerieAleatoria.Name = "gdrSerieAleatoria";
            this.gdrSerieAleatoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdrSerieAleatoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.gdrSerieAleatoria.RowHeadersVisible = false;
            this.gdrSerieAleatoria.Size = new System.Drawing.Size(188, 362);
            this.gdrSerieAleatoria.TabIndex = 0;
            // 
            // desde
            // 
            this.desde.HeaderText = "Iteracion(i)";
            this.desde.Name = "desde";
            this.desde.Width = 90;
            // 
            // hasta
            // 
            this.hasta.HeaderText = "Nro aleatorio";
            this.hasta.Name = "hasta";
            this.hasta.Width = 90;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_c);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.lbl_a);
            this.groupBox4.Controls.Add(this.lbl_c);
            this.groupBox4.Controls.Add(this.lbl_m);
            this.groupBox4.Controls.Add(this.lbl_k);
            this.groupBox4.Controls.Add(this.lbl_g);
            this.groupBox4.Controls.Add(this.lbl_xo);
            this.groupBox4.Controls.Add(this.txt_a);
            this.groupBox4.Controls.Add(this.txt_xo);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txt_g);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txt_k);
            this.groupBox4.Controls.Add(this.txt_m);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(8, 298);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(132, 284);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Variables";
            // 
            // txt_c
            // 
            this.txt_c.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_c.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_c.Location = new System.Drawing.Point(47, 115);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(70, 24);
            this.txt_c.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "c";
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.BackColor = System.Drawing.Color.Transparent;
            this.lbl_a.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_a.ForeColor = System.Drawing.Color.Red;
            this.lbl_a.Location = new System.Drawing.Point(188, 68);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(0, 32);
            this.lbl_a.TabIndex = 21;
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.BackColor = System.Drawing.Color.Transparent;
            this.lbl_c.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_c.ForeColor = System.Drawing.Color.Red;
            this.lbl_c.Location = new System.Drawing.Point(188, 106);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(0, 32);
            this.lbl_c.TabIndex = 20;
            // 
            // lbl_m
            // 
            this.lbl_m.AutoSize = true;
            this.lbl_m.BackColor = System.Drawing.Color.Transparent;
            this.lbl_m.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_m.ForeColor = System.Drawing.Color.Red;
            this.lbl_m.Location = new System.Drawing.Point(188, 145);
            this.lbl_m.Name = "lbl_m";
            this.lbl_m.Size = new System.Drawing.Size(0, 32);
            this.lbl_m.TabIndex = 19;
            // 
            // lbl_k
            // 
            this.lbl_k.AutoSize = true;
            this.lbl_k.BackColor = System.Drawing.Color.Transparent;
            this.lbl_k.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_k.ForeColor = System.Drawing.Color.Red;
            this.lbl_k.Location = new System.Drawing.Point(188, 183);
            this.lbl_k.Name = "lbl_k";
            this.lbl_k.Size = new System.Drawing.Size(0, 32);
            this.lbl_k.TabIndex = 18;
            // 
            // lbl_g
            // 
            this.lbl_g.AutoSize = true;
            this.lbl_g.BackColor = System.Drawing.Color.Transparent;
            this.lbl_g.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_g.ForeColor = System.Drawing.Color.Red;
            this.lbl_g.Location = new System.Drawing.Point(188, 223);
            this.lbl_g.Name = "lbl_g";
            this.lbl_g.Size = new System.Drawing.Size(0, 32);
            this.lbl_g.TabIndex = 17;
            // 
            // lbl_xo
            // 
            this.lbl_xo.AutoSize = true;
            this.lbl_xo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_xo.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_xo.ForeColor = System.Drawing.Color.Red;
            this.lbl_xo.Location = new System.Drawing.Point(188, 27);
            this.lbl_xo.Name = "lbl_xo";
            this.lbl_xo.Size = new System.Drawing.Size(0, 32);
            this.lbl_xo.TabIndex = 16;
            // 
            // txt_a
            // 
            this.txt_a.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_a.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_a.Location = new System.Drawing.Point(47, 76);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(70, 24);
            this.txt_a.TabIndex = 4;
            // 
            // txt_xo
            // 
            this.txt_xo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_xo.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_xo.Location = new System.Drawing.Point(47, 36);
            this.txt_xo.Name = "txt_xo";
            this.txt_xo.Size = new System.Drawing.Size(70, 24);
            this.txt_xo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Xo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "g";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "a";
            // 
            // txt_g
            // 
            this.txt_g.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_g.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_g.Location = new System.Drawing.Point(47, 232);
            this.txt_g.Name = "txt_g";
            this.txt_g.Size = new System.Drawing.Size(70, 24);
            this.txt_g.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "k";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 9;
            // 
            // txt_k
            // 
            this.txt_k.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_k.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_k.Location = new System.Drawing.Point(47, 193);
            this.txt_k.Name = "txt_k";
            this.txt_k.Size = new System.Drawing.Size(70, 24);
            this.txt_k.TabIndex = 7;
            // 
            // txt_m
            // 
            this.txt_m.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_m.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_m.Location = new System.Drawing.Point(47, 154);
            this.txt_m.Name = "txt_m";
            this.txt_m.Size = new System.Drawing.Size(70, 24);
            this.txt_m.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "m";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radiobtn_20);
            this.groupBox2.Controls.Add(this.radiobtn_15);
            this.groupBox2.Controls.Add(this.radiobtn_10);
            this.groupBox2.Controls.Add(this.radiobtn_5);
            this.groupBox2.Location = new System.Drawing.Point(154, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 284);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Subintervalos (k)";
            // 
            // radiobtn_20
            // 
            this.radiobtn_20.AutoSize = true;
            this.radiobtn_20.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.radiobtn_20.Location = new System.Drawing.Point(22, 182);
            this.radiobtn_20.Name = "radiobtn_20";
            this.radiobtn_20.Size = new System.Drawing.Size(50, 32);
            this.radiobtn_20.TabIndex = 7;
            this.radiobtn_20.TabStop = true;
            this.radiobtn_20.Text = "20";
            this.radiobtn_20.UseVisualStyleBackColor = true;
            // 
            // radiobtn_15
            // 
            this.radiobtn_15.AutoSize = true;
            this.radiobtn_15.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.radiobtn_15.Location = new System.Drawing.Point(22, 142);
            this.radiobtn_15.Name = "radiobtn_15";
            this.radiobtn_15.Size = new System.Drawing.Size(50, 32);
            this.radiobtn_15.TabIndex = 6;
            this.radiobtn_15.TabStop = true;
            this.radiobtn_15.Text = "15";
            this.radiobtn_15.UseVisualStyleBackColor = true;
            // 
            // radiobtn_10
            // 
            this.radiobtn_10.AutoSize = true;
            this.radiobtn_10.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.radiobtn_10.Location = new System.Drawing.Point(22, 102);
            this.radiobtn_10.Name = "radiobtn_10";
            this.radiobtn_10.Size = new System.Drawing.Size(50, 32);
            this.radiobtn_10.TabIndex = 5;
            this.radiobtn_10.TabStop = true;
            this.radiobtn_10.Text = "10";
            this.radiobtn_10.UseVisualStyleBackColor = true;
            // 
            // radiobtn_5
            // 
            this.radiobtn_5.AutoSize = true;
            this.radiobtn_5.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.radiobtn_5.Location = new System.Drawing.Point(22, 62);
            this.radiobtn_5.Name = "radiobtn_5";
            this.radiobtn_5.Size = new System.Drawing.Size(40, 32);
            this.radiobtn_5.TabIndex = 4;
            this.radiobtn_5.TabStop = true;
            this.radiobtn_5.Text = "5";
            this.radiobtn_5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tamMuestra);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(74, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 140);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // txt_tamMuestra
            // 
            this.txt_tamMuestra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tamMuestra.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_tamMuestra.Location = new System.Drawing.Point(18, 101);
            this.txt_tamMuestra.Name = "txt_tamMuestra";
            this.txt_tamMuestra.Size = new System.Drawing.Size(110, 24);
            this.txt_tamMuestra.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 63);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tamaño\r\nde Muestra\r\n(N)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_generar
            // 
            this.btn_generar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_generar.FlatAppearance.BorderSize = 0;
            this.btn_generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generar.Location = new System.Drawing.Point(101, 607);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(89, 50);
            this.btn_generar.TabIndex = 45;
            this.btn_generar.Text = "generar";
            this.btn_generar.UseVisualStyleBackColor = false;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click_2);
            // 
            // chkPeriodoMax
            // 
            this.chkPeriodoMax.AutoSize = true;
            this.chkPeriodoMax.Location = new System.Drawing.Point(69, 260);
            this.chkPeriodoMax.Name = "chkPeriodoMax";
            this.chkPeriodoMax.Size = new System.Drawing.Size(153, 25);
            this.chkPeriodoMax.TabIndex = 52;
            this.chkPeriodoMax.Text = "Periodo Maximo N";
            this.chkPeriodoMax.UseVisualStyleBackColor = true;
            this.chkPeriodoMax.CheckedChanged += new System.EventHandler(this.chkPeriodoMax_CheckedChanged);
            // 
            // Frm_ChiCuadMCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 723);
            this.Controls.Add(this.chkPeriodoMax);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_ChiCuadMCM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ChiCuadMCM";
            this.Load += new System.EventHandler(this.Frm_ChiCuadMCM_Load_1);
            this.groupBox5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_graf)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdrSerieAleatoria)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_resHipotesis;
        private System.Windows.Forms.TextBox txtNivelSignificancia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ValorTabulado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_graf;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView gdrSerieAleatoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.Label lbl_m;
        private System.Windows.Forms.Label lbl_k;
        private System.Windows.Forms.Label lbl_g;
        private System.Windows.Forms.Label lbl_xo;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_xo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_g;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_k;
        private System.Windows.Forms.TextBox txt_m;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radiobtn_20;
        private System.Windows.Forms.RadioButton radiobtn_15;
        private System.Windows.Forms.RadioButton radiobtn_10;
        private System.Windows.Forms.RadioButton radiobtn_5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tamMuestra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.CheckBox chkPeriodoMax;
    }
}