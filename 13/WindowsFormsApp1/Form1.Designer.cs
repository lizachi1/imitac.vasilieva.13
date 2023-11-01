namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.edEuro = new System.Windows.Forms.NumericUpDown();
            this.edDollar = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.edEuro);
            this.panel1.Controls.Add(this.edDollar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 131);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Circe Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(39, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Initial price: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Circe Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(547, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btStart.Font = new System.Drawing.Font("Circe Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btStart.Location = new System.Drawing.Point(547, 25);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(131, 38);
            this.btStart.TabIndex = 6;
            this.btStart.Text = "Let\'s go!";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // edEuro
            // 
            this.edEuro.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.edEuro.DecimalPlaces = 2;
            this.edEuro.Font = new System.Drawing.Font("Circe", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edEuro.Location = new System.Drawing.Point(290, 78);
            this.edEuro.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.edEuro.Name = "edEuro";
            this.edEuro.Size = new System.Drawing.Size(120, 25);
            this.edEuro.TabIndex = 5;
            this.edEuro.Value = new decimal(new int[] {
            9777,
            0,
            0,
            131072});
            this.edEuro.ValueChanged += new System.EventHandler(this.edEuro_ValueChanged);
            // 
            // edDollar
            // 
            this.edDollar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.edDollar.DecimalPlaces = 2;
            this.edDollar.Font = new System.Drawing.Font("Circe", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edDollar.Location = new System.Drawing.Point(290, 32);
            this.edDollar.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.edDollar.Name = "edDollar";
            this.edDollar.Size = new System.Drawing.Size(120, 25);
            this.edDollar.TabIndex = 4;
            this.edDollar.Value = new decimal(new int[] {
            8693,
            0,
            0,
            131072});
            this.edDollar.ValueChanged += new System.EventHandler(this.edDollar_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Circe Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(216, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Euro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Circe Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(205, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dollar:";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.SystemColors.WindowFrame;
            chartArea1.AxisX.Maximum = 20D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 150D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Circe", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.DashLine;
            legend1.HeaderSeparatorColor = System.Drawing.Color.BlanchedAlmond;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.White;
            legend1.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickGradientLine;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 137);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.CornflowerBlue;
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.RoyalBlue;
            series1.LabelFormat = "C";
            series1.Legend = "Legend1";
            series1.Name = "Dollar";
            series1.YValuesPerPoint = 2;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Orange;
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.DarkOrange;
            series2.LabelFormat = "C";
            series2.Legend = "Legend1";
            series2.Name = "Euro";
            series2.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(765, 363);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 512);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.NumericUpDown edEuro;
        private System.Windows.Forms.NumericUpDown edDollar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

