namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart_Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bt_ = new System.Windows.Forms.Panel();
            this.bt_Stop = new System.Windows.Forms.Button();
            this.el_Weight = new System.Windows.Forms.NumericUpDown();
            this.el_Size = new System.Windows.Forms.NumericUpDown();
            this.l_Weight = new System.Windows.Forms.Label();
            this.l_Size = new System.Windows.Forms.Label();
            this.el_Step = new System.Windows.Forms.NumericUpDown();
            this.l_Step = new System.Windows.Forms.Label();
            this.bt_Start = new System.Windows.Forms.Button();
            this.el_Speed = new System.Windows.Forms.NumericUpDown();
            this.el_Angle = new System.Windows.Forms.NumericUpDown();
            this.el_Height = new System.Windows.Forms.NumericUpDown();
            this.l_Speed = new System.Windows.Forms.Label();
            this.l_Angle = new System.Windows.Forms.Label();
            this.l_Height = new System.Windows.Forms.Label();
            this.l_DistanceX_Value = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Graph)).BeginInit();
            this.bt_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.el_Weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.el_Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.el_Step)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.el_Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.el_Angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.el_Height)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart_Graph
            // 
            chartArea1.AxisX.Maximum = 25D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 6D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.Chart_Graph.ChartAreas.Add(chartArea1);
            this.Chart_Graph.Location = new System.Drawing.Point(-2, 117);
            this.Chart_Graph.Name = "Chart_Graph";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Name = "Series1";
            this.Chart_Graph.Series.Add(series1);
            this.Chart_Graph.Size = new System.Drawing.Size(812, 408);
            this.Chart_Graph.TabIndex = 0;
            this.Chart_Graph.Text = "chart1";
            // 
            // bt_
            // 
            this.bt_.Controls.Add(this.bt_Stop);
            this.bt_.Controls.Add(this.el_Weight);
            this.bt_.Controls.Add(this.el_Size);
            this.bt_.Controls.Add(this.l_Weight);
            this.bt_.Controls.Add(this.l_Size);
            this.bt_.Controls.Add(this.el_Step);
            this.bt_.Controls.Add(this.l_Step);
            this.bt_.Controls.Add(this.bt_Start);
            this.bt_.Controls.Add(this.el_Speed);
            this.bt_.Controls.Add(this.el_Angle);
            this.bt_.Controls.Add(this.el_Height);
            this.bt_.Controls.Add(this.l_Speed);
            this.bt_.Controls.Add(this.l_Angle);
            this.bt_.Controls.Add(this.l_Height);
            this.bt_.Location = new System.Drawing.Point(0, 0);
            this.bt_.Name = "bt_";
            this.bt_.Size = new System.Drawing.Size(810, 111);
            this.bt_.TabIndex = 1;
            // 
            // bt_Stop
            // 
            this.bt_Stop.Location = new System.Drawing.Point(632, 9);
            this.bt_Stop.Name = "bt_Stop";
            this.bt_Stop.Size = new System.Drawing.Size(160, 88);
            this.bt_Stop.TabIndex = 13;
            this.bt_Stop.Text = "Стоп";
            this.bt_Stop.UseVisualStyleBackColor = true;
            this.bt_Stop.Click += new System.EventHandler(this.bt_Stop_Click);
            // 
            // el_Weight
            // 
            this.el_Weight.DecimalPlaces = 2;
            this.el_Weight.Location = new System.Drawing.Point(327, 73);
            this.el_Weight.Name = "el_Weight";
            this.el_Weight.Size = new System.Drawing.Size(120, 26);
            this.el_Weight.TabIndex = 12;
            this.el_Weight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // el_Size
            // 
            this.el_Size.DecimalPlaces = 2;
            this.el_Size.Location = new System.Drawing.Point(327, 41);
            this.el_Size.Name = "el_Size";
            this.el_Size.Size = new System.Drawing.Size(120, 26);
            this.el_Size.TabIndex = 11;
            this.el_Size.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // l_Weight
            // 
            this.l_Weight.AutoSize = true;
            this.l_Weight.Location = new System.Drawing.Point(235, 75);
            this.l_Weight.Name = "l_Weight";
            this.l_Weight.Size = new System.Drawing.Size(37, 20);
            this.l_Weight.TabIndex = 10;
            this.l_Weight.Text = "Вес";
            // 
            // l_Size
            // 
            this.l_Size.AutoSize = true;
            this.l_Size.Location = new System.Drawing.Point(235, 43);
            this.l_Size.Name = "l_Size";
            this.l_Size.Size = new System.Drawing.Size(65, 20);
            this.l_Size.TabIndex = 9;
            this.l_Size.Text = "Размер";
            // 
            // el_Step
            // 
            this.el_Step.DecimalPlaces = 2;
            this.el_Step.Location = new System.Drawing.Point(327, 7);
            this.el_Step.Name = "el_Step";
            this.el_Step.Size = new System.Drawing.Size(120, 26);
            this.el_Step.TabIndex = 8;
            this.el_Step.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // l_Step
            // 
            this.l_Step.AutoSize = true;
            this.l_Step.Location = new System.Drawing.Point(235, 9);
            this.l_Step.Name = "l_Step";
            this.l_Step.Size = new System.Drawing.Size(38, 20);
            this.l_Step.TabIndex = 7;
            this.l_Step.Text = "Шаг";
            // 
            // bt_Start
            // 
            this.bt_Start.Location = new System.Drawing.Point(466, 9);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(160, 88);
            this.bt_Start.TabIndex = 6;
            this.bt_Start.Text = "Старт";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // el_Speed
            // 
            this.el_Speed.DecimalPlaces = 2;
            this.el_Speed.Location = new System.Drawing.Point(100, 71);
            this.el_Speed.Name = "el_Speed";
            this.el_Speed.Size = new System.Drawing.Size(120, 26);
            this.el_Speed.TabIndex = 5;
            this.el_Speed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // el_Angle
            // 
            this.el_Angle.DecimalPlaces = 2;
            this.el_Angle.Location = new System.Drawing.Point(100, 39);
            this.el_Angle.Name = "el_Angle";
            this.el_Angle.Size = new System.Drawing.Size(120, 26);
            this.el_Angle.TabIndex = 4;
            this.el_Angle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // el_Height
            // 
            this.el_Height.DecimalPlaces = 2;
            this.el_Height.Location = new System.Drawing.Point(100, 7);
            this.el_Height.Name = "el_Height";
            this.el_Height.Size = new System.Drawing.Size(120, 26);
            this.el_Height.TabIndex = 3;
            // 
            // l_Speed
            // 
            this.l_Speed.AutoSize = true;
            this.l_Speed.Location = new System.Drawing.Point(8, 73);
            this.l_Speed.Name = "l_Speed";
            this.l_Speed.Size = new System.Drawing.Size(81, 20);
            this.l_Speed.TabIndex = 2;
            this.l_Speed.Text = "Скорость";
            // 
            // l_Angle
            // 
            this.l_Angle.AutoSize = true;
            this.l_Angle.Location = new System.Drawing.Point(8, 41);
            this.l_Angle.Name = "l_Angle";
            this.l_Angle.Size = new System.Drawing.Size(45, 20);
            this.l_Angle.TabIndex = 1;
            this.l_Angle.Text = "Угол";
            // 
            // l_Height
            // 
            this.l_Height.AutoSize = true;
            this.l_Height.Location = new System.Drawing.Point(8, 9);
            this.l_Height.Name = "l_Height";
            this.l_Height.Size = new System.Drawing.Size(66, 20);
            this.l_Height.TabIndex = 0;
            this.l_Height.Text = "Высота";
            // 
            // l_DistanceX_Value
            // 
            this.l_DistanceX_Value.AutoSize = true;
            this.l_DistanceX_Value.Location = new System.Drawing.Point(42, 15);
            this.l_DistanceX_Value.Name = "l_DistanceX_Value";
            this.l_DistanceX_Value.Size = new System.Drawing.Size(0, 20);
            this.l_DistanceX_Value.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.l_DistanceX_Value);
            this.panel2.Location = new System.Drawing.Point(-2, 531);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 181);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(14, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(786, 153);
            this.dataGridView1.TabIndex = 17;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.FillWeight = 56.81819F;
            this.Column5.HeaderText = "N";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 56;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 110.7955F;
            this.Column1.HeaderText = "Временной шаг";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 110.7955F;
            this.Column2.HeaderText = "Дистанция полёта";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 110.7955F;
            this.Column3.HeaderText = "Максимальная высота";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 110.7955F;
            this.Column4.HeaderText = "Скорость в конечной точке";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bt_);
            this.Controls.Add(this.Chart_Graph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Имитация полёта";
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Graph)).EndInit();
            this.bt_.ResumeLayout(false);
            this.bt_.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.el_Weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.el_Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.el_Step)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.el_Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.el_Angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.el_Height)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Graph;
        private System.Windows.Forms.Panel bt_;
        private System.Windows.Forms.Label l_Speed;
        private System.Windows.Forms.Label l_Angle;
        private System.Windows.Forms.Label l_Height;
        private System.Windows.Forms.NumericUpDown el_Speed;
        private System.Windows.Forms.NumericUpDown el_Angle;
        private System.Windows.Forms.NumericUpDown el_Height;
        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown el_Step;
        private System.Windows.Forms.Label l_Step;
        private System.Windows.Forms.NumericUpDown el_Weight;
        private System.Windows.Forms.NumericUpDown el_Size;
        private System.Windows.Forms.Label l_Weight;
        private System.Windows.Forms.Label l_Size;
        private System.Windows.Forms.Label l_DistanceX_Value;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_Stop;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

