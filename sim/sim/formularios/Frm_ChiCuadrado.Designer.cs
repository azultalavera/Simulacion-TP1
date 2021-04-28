
namespace sim.formularios
{
    partial class Frm_ChiCuadrado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabla_serie = new System.Windows.Forms.DataGridView();
            this.n_tammuestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radiobtn_20 = new System.Windows.Forms.RadioButton();
            this.radiobtn_15 = new System.Windows.Forms.RadioButton();
            this.radiobtn_10 = new System.Windows.Forms.RadioButton();
            this.radiobtn_5 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tamMuestra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chrt_graf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_resHipotesis = new System.Windows.Forms.Label();
            this.txtNivelSignificancia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ValorTabulado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_serie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_graf)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabla_serie);
            this.groupBox3.Controls.Add(this.tabla);
            this.groupBox3.Location = new System.Drawing.Point(187, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(619, 609);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // tabla_serie
            // 
            this.tabla_serie.AllowUserToAddRows = false;
            this.tabla_serie.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tabla_serie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla_serie.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabla_serie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_serie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_serie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_serie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n_tammuestra,
            this.serie});
            this.tabla_serie.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabla_serie.Location = new System.Drawing.Point(21, 37);
            this.tabla_serie.Name = "tabla_serie";
            this.tabla_serie.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_serie.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabla_serie.RowHeadersVisible = false;
            this.tabla_serie.Size = new System.Drawing.Size(169, 557);
            this.tabla_serie.TabIndex = 21;
            // 
            // n_tammuestra
            // 
            this.n_tammuestra.HeaderText = "n";
            this.n_tammuestra.Name = "n_tammuestra";
            this.n_tammuestra.Width = 40;
            // 
            // serie
            // 
            this.serie.HeaderText = "serie";
            this.serie.Name = "serie";
            // 
            // tabla
            // 
            this.tabla.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desde,
            this.hasta,
            this.fo,
            this.fe,
            this.C,
            this.CAC});
            this.tabla.Location = new System.Drawing.Point(207, 37);
            this.tabla.Name = "tabla";
            this.tabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tabla.RowHeadersVisible = false;
            this.tabla.Size = new System.Drawing.Size(396, 453);
            this.tabla.TabIndex = 0;
            // 
            // desde
            // 
            this.desde.HeaderText = "desde";
            this.desde.Name = "desde";
            this.desde.Width = 65;
            // 
            // hasta
            // 
            this.hasta.HeaderText = "hasta";
            this.hasta.Name = "hasta";
            this.hasta.Width = 65;
            // 
            // fo
            // 
            this.fo.HeaderText = "fo";
            this.fo.Name = "fo";
            this.fo.Width = 65;
            // 
            // fe
            // 
            this.fe.HeaderText = "fe";
            this.fe.Name = "fe";
            this.fe.Width = 65;
            // 
            // C
            // 
            this.C.HeaderText = "C";
            this.C.Name = "C";
            this.C.Width = 65;
            // 
            // CAC
            // 
            this.CAC.HeaderText = "C(AC)";
            this.CAC.Name = "CAC";
            this.CAC.Width = 65;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radiobtn_20);
            this.groupBox2.Controls.Add(this.radiobtn_15);
            this.groupBox2.Controls.Add(this.radiobtn_10);
            this.groupBox2.Controls.Add(this.radiobtn_5);
            this.groupBox2.Location = new System.Drawing.Point(21, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 201);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Subintervalos (k)";
            // 
            // radiobtn_20
            // 
            this.radiobtn_20.AutoSize = true;
            this.radiobtn_20.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.radiobtn_20.Location = new System.Drawing.Point(42, 152);
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
            this.radiobtn_15.Location = new System.Drawing.Point(42, 112);
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
            this.radiobtn_10.Location = new System.Drawing.Point(42, 72);
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
            this.radiobtn_5.Location = new System.Drawing.Point(42, 32);
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
            this.groupBox1.Location = new System.Drawing.Point(21, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 157);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // txt_tamMuestra
            // 
            this.txt_tamMuestra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tamMuestra.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_tamMuestra.Location = new System.Drawing.Point(14, 114);
            this.txt_tamMuestra.Name = "txt_tamMuestra";
            this.txt_tamMuestra.Size = new System.Drawing.Size(110, 24);
            this.txt_tamMuestra.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 37);
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
            this.btn_generar.Location = new System.Drawing.Point(52, 525);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(89, 50);
            this.btn_generar.TabIndex = 28;
            this.btn_generar.Text = "generar";
            this.btn_generar.UseVisualStyleBackColor = false;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(16, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 2);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 30);
            this.label1.TabIndex = 26;
            this.label1.Text = "Prueba de Frecuencia - Chi Cuadrado";
            // 
            // chrt_graf
            // 
            chartArea1.Name = "ChartArea1";
            this.chrt_graf.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chrt_graf.Legends.Add(legend1);
            this.chrt_graf.Location = new System.Drawing.Point(35, 230);
            this.chrt_graf.Name = "chrt_graf";
            this.chrt_graf.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Frecuencia Observada";
            this.chrt_graf.Series.Add(series1);
            this.chrt_graf.Size = new System.Drawing.Size(346, 364);
            this.chrt_graf.TabIndex = 33;
            this.chrt_graf.Text = "chart1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel3);
            this.groupBox4.Controls.Add(this.chrt_graf);
            this.groupBox4.Location = new System.Drawing.Point(837, 85);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(410, 609);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(34, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 179);
            this.panel3.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lbl_resHipotesis);
            this.panel2.Controls.Add(this.txtNivelSignificancia);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_ValorTabulado);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(9, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 161);
            this.panel2.TabIndex = 34;
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
            this.txtNivelSignificancia.Size = new System.Drawing.Size(152, 29);
            this.txtNivelSignificancia.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor Tabulado";
            // 
            // txt_ValorTabulado
            // 
            this.txt_ValorTabulado.Location = new System.Drawing.Point(164, 62);
            this.txt_ValorTabulado.Name = "txt_ValorTabulado";
            this.txt_ValorTabulado.Size = new System.Drawing.Size(152, 29);
            this.txt_ValorTabulado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nivel de significancia";
            // 
            // Frm_ChiCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 723);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_ChiCuadrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ChiCuadrado";
            this.Load += new System.EventHandler(this.Frm_ChiCuadrado_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_serie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_graf)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tamMuestra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radiobtn_20;
        private System.Windows.Forms.RadioButton radiobtn_15;
        private System.Windows.Forms.RadioButton radiobtn_10;
        private System.Windows.Forms.RadioButton radiobtn_5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max;
        private System.Windows.Forms.DataGridView tabla_serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_tammuestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn serie;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_graf;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAC;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ValorTabulado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNivelSignificancia;
        private System.Windows.Forms.Label lbl_resHipotesis;
    }
}