namespace VS_Proj
{
    partial class Graphics_1_Form
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.btnStopTimer = new System.Windows.Forms.Button();
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.LabelBorderWidth = 3;
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1041, 526);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Changes of angle";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            title2.Name = "title1";
            title2.Text = "Change angle";
            this.chart1.Titles.Add(title2);
            // 
            // timer1
            // 
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Location = new System.Drawing.Point(125, 602);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(100, 23);
            this.btnStartTimer.TabIndex = 1;
            this.btnStartTimer.Text = "Start";
            this.btnStartTimer.UseVisualStyleBackColor = true;
            // 
            // btnStopTimer
            // 
            this.btnStopTimer.Location = new System.Drawing.Point(125, 659);
            this.btnStopTimer.Name = "btnStopTimer";
            this.btnStopTimer.Size = new System.Drawing.Size(100, 23);
            this.btnStopTimer.TabIndex = 2;
            this.btnStopTimer.Text = "Stop";
            this.btnStopTimer.UseVisualStyleBackColor = true;
            // 
            // tbTimer
            // 
            this.tbTimer.Location = new System.Drawing.Point(125, 631);
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.Size = new System.Drawing.Size(100, 22);
            this.tbTimer.TabIndex = 3;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(312, 630);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(287, 22);
            this.tbData.TabIndex = 4;
            // 
            // Graphics_1_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 711);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.tbTimer);
            this.Controls.Add(this.btnStopTimer);
            this.Controls.Add(this.btnStartTimer);
            this.Controls.Add(this.chart1);
            this.Name = "Graphics_1_Form";
            this.Text = "Graphics_1_Form";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Button btnStopTimer;
        private System.Windows.Forms.TextBox tbTimer;
        private System.Windows.Forms.TextBox tbData;
    }
}