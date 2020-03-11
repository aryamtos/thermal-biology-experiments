namespace Arduino_V._4._1
{
    partial class THL
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(THL));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btDescon = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.cbPortItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.experiment = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.function = new System.Windows.Forms.TextBox();
            this.cold = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
            this.temperature = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rateChange = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btIniciar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.initTemp = new System.Windows.Forms.TextBox();
            this.btPrepare = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btfim = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.manual = new System.Windows.Forms.Button();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btDescon);
            this.groupBox1.Controls.Add(this.btnConectar);
            this.groupBox1.Controls.Add(this.cbPortItem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONEXÃO";
            // 
            // btDescon
            // 
            this.btDescon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btDescon.Location = new System.Drawing.Point(133, 93);
            this.btDescon.Name = "btDescon";
            this.btDescon.Size = new System.Drawing.Size(111, 23);
            this.btDescon.TabIndex = 7;
            this.btDescon.Text = "DESCONECTAR";
            this.btDescon.UseVisualStyleBackColor = true;
            this.btDescon.Visible = false;
            this.btDescon.Click += new System.EventHandler(this.btDescon_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConectar.Location = new System.Drawing.Point(156, 93);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(88, 23);
            this.btnConectar.TabIndex = 6;
            this.btnConectar.Text = "CONECTAR";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // cbPortItem
            // 
            this.cbPortItem.FormattingEnabled = true;
            this.cbPortItem.Location = new System.Drawing.Point(141, 41);
            this.cbPortItem.Name = "cbPortItem";
            this.cbPortItem.Size = new System.Drawing.Size(103, 21);
            this.cbPortItem.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PORTA COM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(8, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TIPO DE EXPERIMENTO";
            // 
            // experiment
            // 
            this.experiment.FormattingEnabled = true;
            this.experiment.Items.AddRange(new object[] {
            "CTMAX",
            "CTMIN",
            "CONSTANTE"});
            this.experiment.Location = new System.Drawing.Point(149, 37);
            this.experiment.Name = "experiment";
            this.experiment.Size = new System.Drawing.Size(100, 21);
            this.experiment.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.function);
            this.groupBox2.Controls.Add(this.cold);
            this.groupBox2.Controls.Add(this.time);
            this.groupBox2.Controls.Add(this.temperature);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(9, 404);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 152);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EXPERIMENTO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "TEMPERATURA FRIA";
            // 
            // function
            // 
            this.function.Enabled = false;
            this.function.Location = new System.Drawing.Point(144, 154);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(100, 20);
            this.function.TabIndex = 7;
            this.function.Visible = false;
            // 
            // cold
            // 
            this.cold.Location = new System.Drawing.Point(144, 52);
            this.cold.Name = "cold";
            this.cold.Size = new System.Drawing.Size(100, 20);
            this.cold.TabIndex = 22;
            // 
            // time
            // 
            this.time.Enabled = false;
            this.time.Location = new System.Drawing.Point(144, 183);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(100, 20);
            this.time.TabIndex = 6;
            this.time.Visible = false;
            this.time.TextChanged += new System.EventHandler(this.time_TextChanged);
            // 
            // temperature
            // 
            this.temperature.Enabled = false;
            this.temperature.Location = new System.Drawing.Point(144, 112);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(100, 20);
            this.temperature.TabIndex = 4;
            this.temperature.TextChanged += new System.EventHandler(this.temperature_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "TEMPERATURA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "REFERÊNCIA";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "TEMPO [ s ]";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "TAXA DE VARIAÇÃO";
            // 
            // rateChange
            // 
            this.rateChange.Location = new System.Drawing.Point(149, 120);
            this.rateChange.Name = "rateChange";
            this.rateChange.Size = new System.Drawing.Size(100, 20);
            this.rateChange.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btIniciar);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.initTemp);
            this.groupBox3.Controls.Add(this.btPrepare);
            this.groupBox3.Controls.Add(this.experiment);
            this.groupBox3.Controls.Add(this.rateChange);
            this.groupBox3.Location = new System.Drawing.Point(9, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 197);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TESTE";
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(174, 168);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(75, 23);
            this.btIniciar.TabIndex = 7;
            this.btIniciar.Text = "INICIAR";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "TEMPERATURA INICIAL";
            // 
            // initTemp
            // 
            this.initTemp.Location = new System.Drawing.Point(149, 77);
            this.initTemp.Name = "initTemp";
            this.initTemp.Size = new System.Drawing.Size(100, 20);
            this.initTemp.TabIndex = 0;
            // 
            // btPrepare
            // 
            this.btPrepare.Location = new System.Drawing.Point(79, 168);
            this.btPrepare.Name = "btPrepare";
            this.btPrepare.Size = new System.Drawing.Size(75, 23);
            this.btPrepare.TabIndex = 5;
            this.btPrepare.Text = "PREPARAR";
            this.btPrepare.UseVisualStyleBackColor = true;
            this.btPrepare.Click += new System.EventHandler(this.btPrepare_Click);
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            this.chart.ContextMenuStrip = this.contextMenuStrip1;
            this.chart.ImeMode = System.Windows.Forms.ImeMode.On;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Name = "Temperatura";
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Name = "Referência";
            this.chart.Legends.Add(legend3);
            this.chart.Legends.Add(legend4);
            this.chart.Location = new System.Drawing.Point(280, 20);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopRight;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series3.Legend = "Temperatura";
            series3.LegendText = "Temperatura";
            series3.MarkerColor = System.Drawing.Color.Blue;
            series3.MarkerSize = 7;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series3.Name = "Temperatura";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Green;
            series4.Legend = "Referência";
            series4.LegendText = "Referência";
            series4.MarkerColor = System.Drawing.Color.Red;
            series4.MarkerSize = 7;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "Referência";
            this.chart.Series.Add(series3);
            this.chart.Series.Add(series4);
            this.chart.Size = new System.Drawing.Size(1078, 593);
            this.chart.SuppressExceptions = true;
            this.chart.TabIndex = 14;
            this.chart.Text = "GRAPH";
            title3.Name = "Tempo [s]";
            title4.ForeColor = System.Drawing.Color.White;
            title4.Name = "Temperatura [ºC]";
            title4.ShadowColor = System.Drawing.Color.White;
            this.chart.Titles.Add(title3);
            this.chart.Titles.Add(title4);
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btfim
            // 
            this.btfim.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btfim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btfim.Location = new System.Drawing.Point(1049, 619);
            this.btfim.Name = "btfim";
            this.btfim.Size = new System.Drawing.Size(75, 22);
            this.btfim.TabIndex = 16;
            this.btfim.Text = "PAUSE";
            this.btfim.UseVisualStyleBackColor = true;
            this.btfim.Click += new System.EventHandler(this.btfim_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // btSave
            // 
            this.btSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btSave.Location = new System.Drawing.Point(949, 619);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 22);
            this.btSave.TabIndex = 18;
            this.btSave.Text = "SALVAR";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btClose.Location = new System.Drawing.Point(1146, 619);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 22);
            this.btClose.TabIndex = 19;
            this.btClose.Text = "DESLIGAR";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // manual
            // 
            this.manual.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.manual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.manual.Location = new System.Drawing.Point(183, 583);
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(75, 22);
            this.manual.TabIndex = 20;
            this.manual.Text = "MANUAL";
            this.manual.UseVisualStyleBackColor = true;
            this.manual.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 583);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(1237, 619);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 22);
            this.button1.TabIndex = 25;
            this.button1.Text = "DESCONECTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_4);
            // 
            // THL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1370, 653);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.manual);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btfim);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "THL";
            this.Text = "THL Thermal Biology Experiments";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btDescon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ComboBox experiment;
        private System.Windows.Forms.ComboBox cbPortItem;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rateChange;
        private System.Windows.Forms.TextBox temperature;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btPrepare;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox initTemp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btfim;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button manual;
        private System.Windows.Forms.TextBox cold;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.TextBox function;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

