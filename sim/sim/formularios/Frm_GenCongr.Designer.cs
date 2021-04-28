
namespace sim.formularios
{
    partial class Frm_GenCongr
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.gdrSerieAleatoria = new System.Windows.Forms.DataGridView();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_aleatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_xo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_g = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_k = new System.Windows.Forms.TextBox();
            this.txt_m = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobtn_multiplicativo = new System.Windows.Forms.RadioButton();
            this.radiobtn_mixto = new System.Windows.Forms.RadioButton();
            this.btn_generar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkPeriodoMax = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrSerieAleatoria)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_proximo);
            this.groupBox3.Controls.Add(this.gdrSerieAleatoria);
            this.groupBox3.Location = new System.Drawing.Point(306, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(575, 496);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btn_proximo
            // 
            this.btn_proximo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_proximo.FlatAppearance.BorderSize = 0;
            this.btn_proximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proximo.Location = new System.Drawing.Point(203, 419);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(169, 50);
            this.btn_proximo.TabIndex = 20;
            this.btn_proximo.Text = "próximo";
            this.btn_proximo.UseVisualStyleBackColor = false;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // gdrSerieAleatoria
            // 
            this.gdrSerieAleatoria.AllowUserToAddRows = false;
            this.gdrSerieAleatoria.AllowUserToDeleteRows = false;
            this.gdrSerieAleatoria.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gdrSerieAleatoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdrSerieAleatoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gdrSerieAleatoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdrSerieAleatoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gdrSerieAleatoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrSerieAleatoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.nro_aleatorio});
            this.gdrSerieAleatoria.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gdrSerieAleatoria.Location = new System.Drawing.Point(96, 28);
            this.gdrSerieAleatoria.Name = "gdrSerieAleatoria";
            this.gdrSerieAleatoria.ReadOnly = true;
            this.gdrSerieAleatoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdrSerieAleatoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdrSerieAleatoria.RowHeadersVisible = false;
            this.gdrSerieAleatoria.Size = new System.Drawing.Size(403, 366);
            this.gdrSerieAleatoria.TabIndex = 0;
            // 
            // iteracion
            // 
            this.iteracion.HeaderText = "iteracion (i)";
            this.iteracion.Name = "iteracion";
            this.iteracion.ReadOnly = true;
            this.iteracion.Width = 200;
            // 
            // nro_aleatorio
            // 
            this.nro_aleatorio.HeaderText = "nro aleatorio";
            this.nro_aleatorio.Name = "nro_aleatorio";
            this.nro_aleatorio.ReadOnly = true;
            this.nro_aleatorio.Width = 200;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_a);
            this.groupBox2.Controls.Add(this.txt_xo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_g);
            this.groupBox2.Controls.Add(this.txt_c);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_k);
            this.groupBox2.Controls.Add(this.txt_m);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(21, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 284);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txt_a
            // 
            this.txt_a.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_a.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_a.Location = new System.Drawing.Point(59, 76);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(125, 24);
            this.txt_a.TabIndex = 4;
            // 
            // txt_xo
            // 
            this.txt_xo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_xo.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_xo.Location = new System.Drawing.Point(59, 34);
            this.txt_xo.Name = "txt_xo";
            this.txt_xo.Size = new System.Drawing.Size(125, 24);
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
            this.txt_g.Location = new System.Drawing.Point(59, 232);
            this.txt_g.Name = "txt_g";
            this.txt_g.Size = new System.Drawing.Size(125, 24);
            this.txt_g.TabIndex = 8;
            // 
            // txt_c
            // 
            this.txt_c.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_c.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_c.Location = new System.Drawing.Point(59, 115);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(125, 24);
            this.txt_c.TabIndex = 5;
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
            this.label4.Size = new System.Drawing.Size(17, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "c";
            // 
            // txt_k
            // 
            this.txt_k.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_k.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_k.Location = new System.Drawing.Point(59, 193);
            this.txt_k.Name = "txt_k";
            this.txt_k.Size = new System.Drawing.Size(125, 24);
            this.txt_k.TabIndex = 7;
            // 
            // txt_m
            // 
            this.txt_m.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_m.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_m.Location = new System.Drawing.Point(59, 154);
            this.txt_m.Name = "txt_m";
            this.txt_m.Size = new System.Drawing.Size(125, 24);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobtn_multiplicativo);
            this.groupBox1.Controls.Add(this.radiobtn_mixto);
            this.groupBox1.Location = new System.Drawing.Point(21, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 110);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radiobtn_multiplicativo
            // 
            this.radiobtn_multiplicativo.AutoSize = true;
            this.radiobtn_multiplicativo.Location = new System.Drawing.Point(18, 64);
            this.radiobtn_multiplicativo.Name = "radiobtn_multiplicativo";
            this.radiobtn_multiplicativo.Size = new System.Drawing.Size(115, 25);
            this.radiobtn_multiplicativo.TabIndex = 2;
            this.radiobtn_multiplicativo.TabStop = true;
            this.radiobtn_multiplicativo.Text = "multiplicativo";
            this.radiobtn_multiplicativo.UseVisualStyleBackColor = true;
            this.radiobtn_multiplicativo.CheckedChanged += new System.EventHandler(this.radiobtn_multiplicativo_CheckedChanged);
            // 
            // radiobtn_mixto
            // 
            this.radiobtn_mixto.AutoSize = true;
            this.radiobtn_mixto.Location = new System.Drawing.Point(18, 32);
            this.radiobtn_mixto.Name = "radiobtn_mixto";
            this.radiobtn_mixto.Size = new System.Drawing.Size(65, 25);
            this.radiobtn_mixto.TabIndex = 1;
            this.radiobtn_mixto.TabStop = true;
            this.radiobtn_mixto.Text = "mixto";
            this.radiobtn_mixto.UseVisualStyleBackColor = true;
            // 
            // btn_generar
            // 
            this.btn_generar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_generar.FlatAppearance.BorderSize = 0;
            this.btn_generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generar.Location = new System.Drawing.Point(42, 537);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(169, 50);
            this.btn_generar.TabIndex = 9;
            this.btn_generar.Text = "generar";
            this.btn_generar.UseVisualStyleBackColor = false;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Generadores Congrunciales\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(16, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 2);
            this.panel1.TabIndex = 21;
            // 
            // chkPeriodoMax
            // 
            this.chkPeriodoMax.AutoSize = true;
            this.chkPeriodoMax.Location = new System.Drawing.Point(21, 206);
            this.chkPeriodoMax.Name = "chkPeriodoMax";
            this.chkPeriodoMax.Size = new System.Drawing.Size(153, 25);
            this.chkPeriodoMax.TabIndex = 26;
            this.chkPeriodoMax.Text = "Periodo Maximo N";
            this.chkPeriodoMax.UseVisualStyleBackColor = true;
            this.chkPeriodoMax.CheckedChanged += new System.EventHandler(this.chkPeriodoMax_CheckedChanged);
            // 
            // Frm_GenCongr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 620);
            this.Controls.Add(this.chkPeriodoMax);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_GenCongr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_GenCongr";
            this.Load += new System.EventHandler(this.Frm_GenCongr_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdrSerieAleatoria)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.DataGridView gdrSerieAleatoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_aleatorio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_xo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_g;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_k;
        private System.Windows.Forms.TextBox txt_m;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobtn_multiplicativo;
        private System.Windows.Forms.RadioButton radiobtn_mixto;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkPeriodoMax;
    }
}