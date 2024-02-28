namespace ИМ_Лаб2
{
    partial class Form_Сurrency
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
            this.l_Head = new System.Windows.Forms.Label();
            this.el_Dollar = new System.Windows.Forms.NumericUpDown();
            this.el_Euro = new System.Windows.Forms.NumericUpDown();
            this.l_Dollar = new System.Windows.Forms.Label();
            this.l_Euro = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bt_Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bt_Clear = new System.Windows.Forms.Button();
            this.bt_Operation = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.el_Dollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.el_Euro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_Operation);
            this.panel1.Controls.Add(this.bt_Clear);
            this.panel1.Controls.Add(this.bt_Start);
            this.panel1.Controls.Add(this.l_Euro);
            this.panel1.Controls.Add(this.l_Dollar);
            this.panel1.Controls.Add(this.el_Euro);
            this.panel1.Controls.Add(this.el_Dollar);
            this.panel1.Controls.Add(this.l_Head);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 106);
            this.panel1.TabIndex = 0;
            // 
            // l_Head
            // 
            this.l_Head.AutoSize = true;
            this.l_Head.Location = new System.Drawing.Point(21, 10);
            this.l_Head.Name = "l_Head";
            this.l_Head.Size = new System.Drawing.Size(189, 20);
            this.l_Head.TabIndex = 1;
            this.l_Head.Text = "Начальный курс валют ";
            // 
            // el_Dollar
            // 
            this.el_Dollar.DecimalPlaces = 2;
            this.el_Dollar.Location = new System.Drawing.Point(25, 59);
            this.el_Dollar.Name = "el_Dollar";
            this.el_Dollar.Size = new System.Drawing.Size(120, 26);
            this.el_Dollar.TabIndex = 2;
            this.el_Dollar.Value = new decimal(new int[] {
            9241,
            0,
            0,
            131072});
            // 
            // el_Euro
            // 
            this.el_Euro.DecimalPlaces = 2;
            this.el_Euro.Location = new System.Drawing.Point(179, 59);
            this.el_Euro.Name = "el_Euro";
            this.el_Euro.Size = new System.Drawing.Size(120, 26);
            this.el_Euro.TabIndex = 3;
            this.el_Euro.Value = new decimal(new int[] {
            9949,
            0,
            0,
            131072});
            // 
            // l_Dollar
            // 
            this.l_Dollar.AutoSize = true;
            this.l_Dollar.Location = new System.Drawing.Point(21, 36);
            this.l_Dollar.Name = "l_Dollar";
            this.l_Dollar.Size = new System.Drawing.Size(68, 20);
            this.l_Dollar.TabIndex = 4;
            this.l_Dollar.Text = "Доллар";
            // 
            // l_Euro
            // 
            this.l_Euro.AutoSize = true;
            this.l_Euro.Location = new System.Drawing.Point(175, 36);
            this.l_Euro.Name = "l_Euro";
            this.l_Euro.Size = new System.Drawing.Size(47, 20);
            this.l_Euro.TabIndex = 5;
            this.l_Euro.Text = "Евро";
            // 
            // chart1
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 112);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Green;
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "f4";
            series1.Legend = "Legend1";
            series1.Name = "Доллар";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "f4";
            series2.Legend = "Legend1";
            series2.Name = "Евро";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1013, 501);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // bt_Start
            // 
            this.bt_Start.Location = new System.Drawing.Point(410, 11);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(191, 71);
            this.bt_Start.TabIndex = 2;
            this.bt_Start.Text = "Старт";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // bt_Clear
            // 
            this.bt_Clear.Location = new System.Drawing.Point(607, 11);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(191, 71);
            this.bt_Clear.TabIndex = 6;
            this.bt_Clear.Text = "Очистить";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // bt_Operation
            // 
            this.bt_Operation.Location = new System.Drawing.Point(804, 12);
            this.bt_Operation.Name = "bt_Operation";
            this.bt_Operation.Size = new System.Drawing.Size(197, 69);
            this.bt_Operation.TabIndex = 7;
            this.bt_Operation.Text = "Mode";
            this.bt_Operation.UseVisualStyleBackColor = true;
            this.bt_Operation.Click += new System.EventHandler(this.bt_Operation_Click);
            // 
            // Form_Сurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 614);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Сurrency";
            this.Text = "Моделирование двух валют в реальном времени";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.el_Dollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.el_Euro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label l_Euro;
        private System.Windows.Forms.Label l_Dollar;
        private System.Windows.Forms.NumericUpDown el_Euro;
        private System.Windows.Forms.NumericUpDown el_Dollar;
        private System.Windows.Forms.Label l_Head;
        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button bt_Operation;
    }
}

