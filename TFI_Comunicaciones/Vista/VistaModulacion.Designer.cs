
namespace TFI_Comunicaciones
{
    partial class VistaModulacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelSenal = new System.Windows.Forms.Panel();
            this.cboxGrafica = new System.Windows.Forms.ComboBox();
            this.gridSimbolos = new System.Windows.Forms.DataGridView();
            this.clmSimbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAmplitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboxModulacion = new System.Windows.Forms.ComboBox();
            this.lblModulacion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPeriodoSimb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSenal = new System.Windows.Forms.Label();
            this.txtSimbolos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.lblSegCopy = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.txtBaudios = new System.Windows.Forms.TextBox();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblBinario = new System.Windows.Forms.Label();
            this.lblBaudios = new System.Windows.Forms.Label();
            this.lblBauds = new System.Windows.Forms.Label();
            this.lblFrecuencia = new System.Windows.Forms.Label();
            this.lblNASK = new System.Windows.Forms.Label();
            this.lblSeg = new System.Windows.Forms.Label();
            this.numDigSimb = new System.Windows.Forms.NumericUpDown();
            this.lblDigSimb = new System.Windows.Forms.Label();
            this.lblHz = new System.Windows.Forms.Label();
            this.txtPeriodoBit = new System.Windows.Forms.TextBox();
            this.txtFrecuencia = new System.Windows.Forms.TextBox();
            this.drawSpace = new System.Windows.Forms.PictureBox();
            this.bsSenal = new System.Windows.Forms.BindingSource(this.components);
            this.bsCodBinario = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelSenal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSimbolos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDigSimb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSenal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCodBinario)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(7);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelSenal);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.drawSpace);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 681);
            this.splitContainer1.SplitterDistance = 282;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelSenal
            // 
            this.panelSenal.Controls.Add(this.cboxGrafica);
            this.panelSenal.Controls.Add(this.gridSimbolos);
            this.panelSenal.Controls.Add(this.cboxModulacion);
            this.panelSenal.Controls.Add(this.lblModulacion);
            this.panelSenal.Controls.Add(this.label3);
            this.panelSenal.Controls.Add(this.txtPeriodoSimb);
            this.panelSenal.Controls.Add(this.label2);
            this.panelSenal.Controls.Add(this.lblSenal);
            this.panelSenal.Controls.Add(this.txtSimbolos);
            this.panelSenal.Controls.Add(this.label1);
            this.panelSenal.Controls.Add(this.btnGraficar);
            this.panelSenal.Controls.Add(this.lblSegCopy);
            this.panelSenal.Controls.Add(this.txtDuracion);
            this.panelSenal.Controls.Add(this.lblDuracion);
            this.panelSenal.Controls.Add(this.txtBaudios);
            this.panelSenal.Controls.Add(this.txtBinario);
            this.panelSenal.Controls.Add(this.lblPeriodo);
            this.panelSenal.Controls.Add(this.lblBinario);
            this.panelSenal.Controls.Add(this.lblBaudios);
            this.panelSenal.Controls.Add(this.lblBauds);
            this.panelSenal.Controls.Add(this.lblFrecuencia);
            this.panelSenal.Controls.Add(this.lblNASK);
            this.panelSenal.Controls.Add(this.lblSeg);
            this.panelSenal.Controls.Add(this.numDigSimb);
            this.panelSenal.Controls.Add(this.lblDigSimb);
            this.panelSenal.Controls.Add(this.lblHz);
            this.panelSenal.Controls.Add(this.txtPeriodoBit);
            this.panelSenal.Controls.Add(this.txtFrecuencia);
            this.panelSenal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSenal.Location = new System.Drawing.Point(0, 0);
            this.panelSenal.Name = "panelSenal";
            this.panelSenal.Size = new System.Drawing.Size(1264, 282);
            this.panelSenal.TabIndex = 17;
            // 
            // cboxGrafica
            // 
            this.cboxGrafica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGrafica.Location = new System.Drawing.Point(897, 230);
            this.cboxGrafica.Name = "cboxGrafica";
            this.cboxGrafica.Size = new System.Drawing.Size(173, 40);
            this.cboxGrafica.TabIndex = 28;
            // 
            // gridSimbolos
            // 
            this.gridSimbolos.AllowUserToAddRows = false;
            this.gridSimbolos.AllowUserToDeleteRows = false;
            this.gridSimbolos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSimbolos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSimbolos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSimbolo,
            this.clmAmplitud});
            this.gridSimbolos.Location = new System.Drawing.Point(466, 57);
            this.gridSimbolos.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.gridSimbolos.MultiSelect = false;
            this.gridSimbolos.Name = "gridSimbolos";
            this.gridSimbolos.Size = new System.Drawing.Size(402, 225);
            this.gridSimbolos.TabIndex = 4;
            // 
            // clmSimbolo
            // 
            this.clmSimbolo.HeaderText = "SIMBOLO";
            this.clmSimbolo.Name = "clmSimbolo";
            this.clmSimbolo.ReadOnly = true;
            // 
            // clmAmplitud
            // 
            this.clmAmplitud.HeaderText = "AMPLITUD";
            this.clmAmplitud.Name = "clmAmplitud";
            // 
            // cboxModulacion
            // 
            this.cboxModulacion.Enabled = false;
            this.cboxModulacion.Items.AddRange(new object[] {
            "ASK",
            "FSK",
            "PSK",
            "QAM"});
            this.cboxModulacion.Location = new System.Drawing.Point(231, 12);
            this.cboxModulacion.Name = "cboxModulacion";
            this.cboxModulacion.Size = new System.Drawing.Size(100, 40);
            this.cboxModulacion.TabIndex = 27;
            this.cboxModulacion.Text = "ASK";
            // 
            // lblModulacion
            // 
            this.lblModulacion.AutoSize = true;
            this.lblModulacion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblModulacion.Location = new System.Drawing.Point(12, 15);
            this.lblModulacion.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.lblModulacion.Name = "lblModulacion";
            this.lblModulacion.Size = new System.Drawing.Size(161, 32);
            this.lblModulacion.TabIndex = 26;
            this.lblModulacion.Text = "Modulación :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(337, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "s";
            // 
            // txtPeriodoSimb
            // 
            this.txtPeriodoSimb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSenal, "PeriodoSimb", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.txtPeriodoSimb.Location = new System.Drawing.Point(231, 186);
            this.txtPeriodoSimb.Name = "txtPeriodoSimb";
            this.txtPeriodoSimb.Size = new System.Drawing.Size(100, 39);
            this.txtPeriodoSimb.TabIndex = 24;
            this.txtPeriodoSimb.TextChanged += new System.EventHandler(this.txtBinario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "Periodo ( Simb. ) :";
            // 
            // lblSenal
            // 
            this.lblSenal.AutoSize = true;
            this.lblSenal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSenal.Location = new System.Drawing.Point(12, 54);
            this.lblSenal.Name = "lblSenal";
            this.lblSenal.Size = new System.Drawing.Size(90, 32);
            this.lblSenal.TabIndex = 22;
            this.lblSenal.Text = "Señal :";
            // 
            // txtSimbolos
            // 
            this.txtSimbolos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCodBinario, "Simbolos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.txtSimbolos.Location = new System.Drawing.Point(1030, 147);
            this.txtSimbolos.Name = "txtSimbolos";
            this.txtSimbolos.ReadOnly = true;
            this.txtSimbolos.Size = new System.Drawing.Size(136, 39);
            this.txtSimbolos.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(891, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Símbolos :";
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(1076, 219);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(176, 60);
            this.btnGraficar.TabIndex = 9;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // lblSegCopy
            // 
            this.lblSegCopy.AutoSize = true;
            this.lblSegCopy.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSegCopy.Location = new System.Drawing.Point(1172, 105);
            this.lblSegCopy.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.lblSegCopy.Name = "lblSegCopy";
            this.lblSegCopy.Size = new System.Drawing.Size(26, 32);
            this.lblSegCopy.TabIndex = 19;
            this.lblSegCopy.Text = "s";
            // 
            // txtDuracion
            // 
            this.txtDuracion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCodBinario, "Duracion", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N4"));
            this.txtDuracion.Location = new System.Drawing.Point(1030, 102);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.ReadOnly = true;
            this.txtDuracion.Size = new System.Drawing.Size(136, 39);
            this.txtDuracion.TabIndex = 18;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(891, 105);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(132, 32);
            this.lblDuracion.TabIndex = 17;
            this.lblDuracion.Text = "Duración :";
            // 
            // txtBaudios
            // 
            this.txtBaudios.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSenal, "Baudios", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.txtBaudios.Location = new System.Drawing.Point(231, 231);
            this.txtBaudios.Name = "txtBaudios";
            this.txtBaudios.Size = new System.Drawing.Size(100, 39);
            this.txtBaudios.TabIndex = 15;
            this.txtBaudios.TextChanged += new System.EventHandler(this.txtBinario_TextChanged);
            // 
            // txtBinario
            // 
            this.txtBinario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCodBinario, "Cadena", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBinario.Location = new System.Drawing.Point(897, 57);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(301, 39);
            this.txtBinario.TabIndex = 8;
            this.txtBinario.TextChanged += new System.EventHandler(this.txtBinario_TextChanged);
            this.txtBinario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBinario_KeyPress);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(12, 99);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(188, 32);
            this.lblPeriodo.TabIndex = 11;
            this.lblPeriodo.Text = "Periodo ( Bit ) :";
            // 
            // lblBinario
            // 
            this.lblBinario.AutoSize = true;
            this.lblBinario.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBinario.Location = new System.Drawing.Point(891, 15);
            this.lblBinario.Name = "lblBinario";
            this.lblBinario.Size = new System.Drawing.Size(199, 32);
            this.lblBinario.TabIndex = 7;
            this.lblBinario.Text = "Código Binario :";
            // 
            // lblBaudios
            // 
            this.lblBaudios.AutoSize = true;
            this.lblBaudios.Location = new System.Drawing.Point(12, 234);
            this.lblBaudios.Name = "lblBaudios";
            this.lblBaudios.Size = new System.Drawing.Size(213, 32);
            this.lblBaudios.TabIndex = 14;
            this.lblBaudios.Text = "Tasa de Baudios :";
            // 
            // lblBauds
            // 
            this.lblBauds.AutoSize = true;
            this.lblBauds.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBauds.Location = new System.Drawing.Point(337, 233);
            this.lblBauds.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.lblBauds.Name = "lblBauds";
            this.lblBauds.Size = new System.Drawing.Size(106, 32);
            this.lblBauds.TabIndex = 16;
            this.lblBauds.Text = "Baudios";
            // 
            // lblFrecuencia
            // 
            this.lblFrecuencia.AutoSize = true;
            this.lblFrecuencia.Location = new System.Drawing.Point(12, 144);
            this.lblFrecuencia.Name = "lblFrecuencia";
            this.lblFrecuencia.Size = new System.Drawing.Size(148, 32);
            this.lblFrecuencia.TabIndex = 5;
            this.lblFrecuencia.Text = "Frecuencia :";
            // 
            // lblNASK
            // 
            this.lblNASK.AutoSize = true;
            this.lblNASK.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNASK.Location = new System.Drawing.Point(778, 15);
            this.lblNASK.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.lblNASK.Name = "lblNASK";
            this.lblNASK.Size = new System.Drawing.Size(90, 32);
            this.lblNASK.TabIndex = 3;
            this.lblNASK.Text = "N-ASK";
            // 
            // lblSeg
            // 
            this.lblSeg.AutoSize = true;
            this.lblSeg.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSeg.Location = new System.Drawing.Point(337, 99);
            this.lblSeg.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.lblSeg.Name = "lblSeg";
            this.lblSeg.Size = new System.Drawing.Size(26, 32);
            this.lblSeg.TabIndex = 13;
            this.lblSeg.Text = "s";
            // 
            // numDigSimb
            // 
            this.numDigSimb.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsSenal, "CifrasSimb", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numDigSimb.Location = new System.Drawing.Point(666, 13);
            this.numDigSimb.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDigSimb.Name = "numDigSimb";
            this.numDigSimb.Size = new System.Drawing.Size(100, 39);
            this.numDigSimb.TabIndex = 1;
            this.numDigSimb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDigSimb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDigSimb.ValueChanged += new System.EventHandler(this.numDigSimb_ValueChanged);
            // 
            // lblDigSimb
            // 
            this.lblDigSimb.AutoSize = true;
            this.lblDigSimb.Location = new System.Drawing.Point(460, 15);
            this.lblDigSimb.Name = "lblDigSimb";
            this.lblDigSimb.Size = new System.Drawing.Size(200, 32);
            this.lblDigSimb.TabIndex = 2;
            this.lblDigSimb.Text = "Cifras/Símbolo :";
            // 
            // lblHz
            // 
            this.lblHz.AutoSize = true;
            this.lblHz.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHz.Location = new System.Drawing.Point(337, 144);
            this.lblHz.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.lblHz.Name = "lblHz";
            this.lblHz.Size = new System.Drawing.Size(45, 32);
            this.lblHz.TabIndex = 10;
            this.lblHz.Text = "Hz";
            // 
            // txtPeriodoBit
            // 
            this.txtPeriodoBit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSenal, "PeriodoBit", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.txtPeriodoBit.Location = new System.Drawing.Point(231, 96);
            this.txtPeriodoBit.Name = "txtPeriodoBit";
            this.txtPeriodoBit.Size = new System.Drawing.Size(100, 39);
            this.txtPeriodoBit.TabIndex = 12;
            this.txtPeriodoBit.TextChanged += new System.EventHandler(this.txtBinario_TextChanged);
            // 
            // txtFrecuencia
            // 
            this.txtFrecuencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSenal, "Frecuencia", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.txtFrecuencia.Location = new System.Drawing.Point(231, 141);
            this.txtFrecuencia.Name = "txtFrecuencia";
            this.txtFrecuencia.Size = new System.Drawing.Size(100, 39);
            this.txtFrecuencia.TabIndex = 6;
            this.txtFrecuencia.TextChanged += new System.EventHandler(this.txtBinario_TextChanged);
            // 
            // drawSpace
            // 
            this.drawSpace.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.drawSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawSpace.Location = new System.Drawing.Point(0, 0);
            this.drawSpace.Margin = new System.Windows.Forms.Padding(7);
            this.drawSpace.Name = "drawSpace";
            this.drawSpace.Size = new System.Drawing.Size(1264, 389);
            this.drawSpace.TabIndex = 0;
            this.drawSpace.TabStop = false;
            this.drawSpace.SizeChanged += new System.EventHandler(this.btnGraficar_Click);
            // 
            // bsSenal
            // 
            this.bsSenal.DataSource = typeof(TFI_Comunicaciones.Entidades.Senal);
            // 
            // bsCodBinario
            // 
            this.bsCodBinario.DataSource = typeof(TFI_Comunicaciones.Entidades.CodBinario);
            // 
            // VistaModulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "VistaModulacion";
            this.Text = "ANALIZADOR DE MODULACIÓN";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelSenal.ResumeLayout(false);
            this.panelSenal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSimbolos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDigSimb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSenal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCodBinario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox drawSpace;
        private System.Windows.Forms.Label lblDigSimb;
        private System.Windows.Forms.NumericUpDown numDigSimb;
        private System.Windows.Forms.Label lblNASK;
        private System.Windows.Forms.Label lblFrecuencia;
        private System.Windows.Forms.TextBox txtFrecuencia;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.Label lblBinario;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.DataGridView gridSimbolos;
        private System.Windows.Forms.Label lblHz;
        private System.Windows.Forms.Label lblBauds;
        private System.Windows.Forms.TextBox txtBaudios;
        private System.Windows.Forms.Label lblBaudios;
        private System.Windows.Forms.Label lblSeg;
        private System.Windows.Forms.TextBox txtPeriodoBit;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Panel panelSenal;
        private System.Windows.Forms.BindingSource bsSenal;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblSegCopy;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.BindingSource bsCodBinario;
        private System.Windows.Forms.TextBox txtSimbolos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSenal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSimbolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAmplitud;
        private System.Windows.Forms.TextBox txtPeriodoSimb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblModulacion;
        private System.Windows.Forms.ComboBox cboxModulacion;
        private System.Windows.Forms.ComboBox cboxGrafica;
    }
}

