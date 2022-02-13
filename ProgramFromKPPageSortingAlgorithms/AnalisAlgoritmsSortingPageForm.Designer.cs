
namespace ProgramFromKPPageSortingAlgorithms
{
    partial class AnalisAlgoritmsSortingPageForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.QuentityEnterPages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIFO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LRU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureChart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuentityEnterPages,
            this.FIFO,
            this.LRU,
            this.NRU,
            this.SA,
            this.Clock});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 379);
            this.dataGridView1.TabIndex = 0;
            // 
            // QuentityEnterPages
            // 
            this.QuentityEnterPages.HeaderText = "Количество вошедших страниц";
            this.QuentityEnterPages.MinimumWidth = 6;
            this.QuentityEnterPages.Name = "QuentityEnterPages";
            this.QuentityEnterPages.ReadOnly = true;
            this.QuentityEnterPages.Width = 125;
            // 
            // FIFO
            // 
            this.FIFO.HeaderText = "FIFO";
            this.FIFO.MinimumWidth = 6;
            this.FIFO.Name = "FIFO";
            this.FIFO.ReadOnly = true;
            this.FIFO.Width = 80;
            // 
            // LRU
            // 
            this.LRU.HeaderText = "LRU";
            this.LRU.MinimumWidth = 6;
            this.LRU.Name = "LRU";
            this.LRU.ReadOnly = true;
            this.LRU.Width = 80;
            // 
            // NRU
            // 
            this.NRU.HeaderText = "NRU";
            this.NRU.MinimumWidth = 6;
            this.NRU.Name = "NRU";
            this.NRU.ReadOnly = true;
            this.NRU.Width = 80;
            // 
            // SA
            // 
            this.SA.HeaderText = "Вторая попытка";
            this.SA.MinimumWidth = 6;
            this.SA.Name = "SA";
            this.SA.ReadOnly = true;
            this.SA.Width = 93;
            // 
            // Clock
            // 
            this.Clock.HeaderText = "Часы";
            this.Clock.MinimumWidth = 6;
            this.Clock.Name = "Clock";
            this.Clock.ReadOnly = true;
            this.Clock.Width = 80;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Построить график";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureChart
            // 
            chartArea1.AxisX.Title = "Количество вхождений страниц";
            chartArea1.AxisY.Title = "Количество прерываний";
            chartArea1.Name = "ChartArea1";
            this.pictureChart.ChartAreas.Add(chartArea1);
            this.pictureChart.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            legend1.Title = "Цвета графиков";
            this.pictureChart.Legends.Add(legend1);
            this.pictureChart.Location = new System.Drawing.Point(0, 0);
            this.pictureChart.Name = "pictureChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.LegendText = "FIFO";
            series1.Name = "SeriesFiFO";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Yellow;
            series2.LabelBackColor = System.Drawing.Color.Yellow;
            series2.Legend = "Legend1";
            series2.LegendText = "LRU";
            series2.Name = "SeriesLRU";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series3.Legend = "Legend1";
            series3.LegendText = "NRU";
            series3.Name = "SeriesNRU";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Fuchsia;
            series4.Legend = "Legend1";
            series4.LegendText = "Вторая попытка";
            series4.Name = "SeriesSA";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series5.Legend = "Legend1";
            series5.LegendText = "Часы";
            series5.Name = "SeriesClock";
            this.pictureChart.Series.Add(series1);
            this.pictureChart.Series.Add(series2);
            this.pictureChart.Series.Add(series3);
            this.pictureChart.Series.Add(series4);
            this.pictureChart.Series.Add(series5);
            this.pictureChart.Size = new System.Drawing.Size(800, 391);
            this.pictureChart.TabIndex = 2;
            this.pictureChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            title1.Name = "TitleName";
            this.pictureChart.Titles.Add(title1);
            this.pictureChart.Visible = false;
            // 
            // AnalisAlgoritmsSortingPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureChart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AnalisAlgoritmsSortingPageForm";
            this.Text = "График сравнения алгоритмов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart pictureChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuentityEnterPages;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIFO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LRU;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRU;
        private System.Windows.Forms.DataGridViewTextBoxColumn SA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clock;
    }
}