
namespace _1_Flight_in_atmosphere
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.inpStep = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.inpWeight = new System.Windows.Forms.NumericUpDown();
            this.inpSize = new System.Windows.Forms.NumericUpDown();
            this.inpSpeed = new System.Windows.Forms.NumericUpDown();
            this.inpAngle = new System.Windows.Forms.NumericUpDown();
            this.inpHeight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtMyTable = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inpStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMyTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtMyTable);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.inpStep);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.inpWeight);
            this.panel1.Controls.Add(this.inpSize);
            this.panel1.Controls.Add(this.inpSpeed);
            this.panel1.Controls.Add(this.inpAngle);
            this.panel1.Controls.Add(this.inpHeight);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 223);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 53);
            this.button1.TabIndex = 12;
            this.button1.Text = "Смоделировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inpStep
            // 
            this.inpStep.DecimalPlaces = 4;
            this.inpStep.Location = new System.Drawing.Point(97, 178);
            this.inpStep.Name = "inpStep";
            this.inpStep.Size = new System.Drawing.Size(120, 22);
            this.inpStep.TabIndex = 11;
            this.inpStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Шаг";
            // 
            // inpWeight
            // 
            this.inpWeight.DecimalPlaces = 2;
            this.inpWeight.Location = new System.Drawing.Point(97, 145);
            this.inpWeight.Name = "inpWeight";
            this.inpWeight.Size = new System.Drawing.Size(120, 22);
            this.inpWeight.TabIndex = 9;
            this.inpWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // inpSize
            // 
            this.inpSize.DecimalPlaces = 2;
            this.inpSize.Location = new System.Drawing.Point(97, 114);
            this.inpSize.Name = "inpSize";
            this.inpSize.Size = new System.Drawing.Size(120, 22);
            this.inpSize.TabIndex = 8;
            this.inpSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // inpSpeed
            // 
            this.inpSpeed.Location = new System.Drawing.Point(97, 76);
            this.inpSpeed.Name = "inpSpeed";
            this.inpSpeed.Size = new System.Drawing.Size(120, 22);
            this.inpSpeed.TabIndex = 7;
            this.inpSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // inpAngle
            // 
            this.inpAngle.Location = new System.Drawing.Point(97, 43);
            this.inpAngle.Name = "inpAngle";
            this.inpAngle.Size = new System.Drawing.Size(120, 22);
            this.inpAngle.TabIndex = 6;
            this.inpAngle.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // inpHeight
            // 
            this.inpHeight.Location = new System.Drawing.Point(97, 13);
            this.inpHeight.Name = "inpHeight";
            this.inpHeight.Size = new System.Drawing.Size(120, 22);
            this.inpHeight.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Вес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Размер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Скорость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Угол";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Высота";
            // 
            // chart1
            // 
            chartArea2.AxisX.Maximum = 25D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Maximum = 6D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 223);
            this.chart1.Name = "chart1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1147, 457);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dtMyTable
            // 
            this.dtMyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMyTable.Location = new System.Drawing.Point(469, 17);
            this.dtMyTable.Name = "dtMyTable";
            this.dtMyTable.RowHeadersWidth = 51;
            this.dtMyTable.RowTemplate.Height = 24;
            this.dtMyTable.Size = new System.Drawing.Size(617, 183);
            this.dtMyTable.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 680);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inpStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMyTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown inpWeight;
        private System.Windows.Forms.NumericUpDown inpSize;
        private System.Windows.Forms.NumericUpDown inpSpeed;
        private System.Windows.Forms.NumericUpDown inpAngle;
        private System.Windows.Forms.NumericUpDown inpHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown inpStep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dtMyTable;
    }
}

