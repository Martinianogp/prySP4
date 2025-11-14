namespace prySP4
{
    partial class frmInicio
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblGafico = new System.Windows.Forms.Label();
            this.cmbGrafico = new System.Windows.Forms.ComboBox();
            this.btnKilometros = new System.Windows.Forms.Button();
            this.btnGastos = new System.Windows.Forms.Button();
            this.btnKilogramos = new System.Windows.Forms.Button();
            this.btnViaticos = new System.Windows.Forms.Button();
            this.chtCamiones = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chtCamiones)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 517);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(719, 17);
            this.progressBar1.TabIndex = 0;
            // 
            // lblGafico
            // 
            this.lblGafico.AutoSize = true;
            this.lblGafico.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGafico.Location = new System.Drawing.Point(12, 35);
            this.lblGafico.Name = "lblGafico";
            this.lblGafico.Size = new System.Drawing.Size(68, 22);
            this.lblGafico.TabIndex = 1;
            this.lblGafico.Text = "Grafico:";
            // 
            // cmbGrafico
            // 
            this.cmbGrafico.FormattingEnabled = true;
            this.cmbGrafico.Location = new System.Drawing.Point(86, 38);
            this.cmbGrafico.Name = "cmbGrafico";
            this.cmbGrafico.Size = new System.Drawing.Size(234, 21);
            this.cmbGrafico.TabIndex = 2;
            // 
            // btnKilometros
            // 
            this.btnKilometros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKilometros.Location = new System.Drawing.Point(13, 77);
            this.btnKilometros.Name = "btnKilometros";
            this.btnKilometros.Size = new System.Drawing.Size(165, 37);
            this.btnKilometros.TabIndex = 3;
            this.btnKilometros.Text = "Kilometros por Camion";
            this.btnKilometros.UseVisualStyleBackColor = true;
            this.btnKilometros.Click += new System.EventHandler(this.btnKilometros_Click);
            // 
            // btnGastos
            // 
            this.btnGastos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGastos.Location = new System.Drawing.Point(188, 77);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(165, 37);
            this.btnGastos.TabIndex = 4;
            this.btnGastos.Text = "Gastos por Camion";
            this.btnGastos.UseVisualStyleBackColor = true;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // btnKilogramos
            // 
            this.btnKilogramos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKilogramos.Location = new System.Drawing.Point(364, 77);
            this.btnKilogramos.Name = "btnKilogramos";
            this.btnKilogramos.Size = new System.Drawing.Size(165, 37);
            this.btnKilogramos.TabIndex = 5;
            this.btnKilogramos.Text = "Kilogramos por Camion";
            this.btnKilogramos.UseVisualStyleBackColor = true;
            this.btnKilogramos.Click += new System.EventHandler(this.btnKilogramos_Click);
            // 
            // btnViaticos
            // 
            this.btnViaticos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViaticos.Location = new System.Drawing.Point(540, 77);
            this.btnViaticos.Name = "btnViaticos";
            this.btnViaticos.Size = new System.Drawing.Size(165, 37);
            this.btnViaticos.TabIndex = 6;
            this.btnViaticos.Text = "Gastos/Viaticos por Camion";
            this.btnViaticos.UseVisualStyleBackColor = true;
            this.btnViaticos.Click += new System.EventHandler(this.btnViaticos_Click);
            // 
            // chtCamiones
            // 
            chartArea1.Name = "ChartArea1";
            this.chtCamiones.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtCamiones.Legends.Add(legend1);
            this.chtCamiones.Location = new System.Drawing.Point(14, 132);
            this.chtCamiones.Name = "chtCamiones";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtCamiones.Series.Add(series1);
            this.chtCamiones.Size = new System.Drawing.Size(691, 368);
            this.chtCamiones.TabIndex = 7;
            this.chtCamiones.Text = "chart1";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(717, 534);
            this.Controls.Add(this.chtCamiones);
            this.Controls.Add(this.btnViaticos);
            this.Controls.Add(this.btnKilogramos);
            this.Controls.Add(this.btnGastos);
            this.Controls.Add(this.btnKilometros);
            this.Controls.Add(this.cmbGrafico);
            this.Controls.Add(this.lblGafico);
            this.Controls.Add(this.progressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtCamiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblGafico;
        private System.Windows.Forms.ComboBox cmbGrafico;
        private System.Windows.Forms.Button btnKilometros;
        private System.Windows.Forms.Button btnGastos;
        private System.Windows.Forms.Button btnKilogramos;
        private System.Windows.Forms.Button btnViaticos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCamiones;
    }
}