namespace VS_Proj
{
    partial class Serial_Port
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea21 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea22 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel6 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea23 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea24 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.COMcBox = new System.Windows.Forms.ComboBox();
            this.BaudcBox = new System.Windows.Forms.ComboBox();
            this.COMlabel = new System.Windows.Forms.Label();
            this.Baudlabel = new System.Windows.Forms.Label();
            this.Initbtn = new System.Windows.Forms.Button();
            this.Closebtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.btnStopTimer = new System.Windows.Forms.Button();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.tbAngle = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFreq = new System.Windows.Forms.Button();
            this.tbFr = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnWriteToFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Readtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btnOKFileName = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // COMcBox
            // 
            this.COMcBox.FormattingEnabled = true;
            this.COMcBox.Location = new System.Drawing.Point(141, 16);
            this.COMcBox.Name = "COMcBox";
            this.COMcBox.Size = new System.Drawing.Size(139, 24);
            this.COMcBox.TabIndex = 0;
            // 
            // BaudcBox
            // 
            this.BaudcBox.FormattingEnabled = true;
            this.BaudcBox.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "600"});
            this.BaudcBox.Location = new System.Drawing.Point(141, 51);
            this.BaudcBox.Name = "BaudcBox";
            this.BaudcBox.Size = new System.Drawing.Size(139, 24);
            this.BaudcBox.TabIndex = 1;
            // 
            // COMlabel
            // 
            this.COMlabel.AutoSize = true;
            this.COMlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.COMlabel.Location = new System.Drawing.Point(4, 12);
            this.COMlabel.Name = "COMlabel";
            this.COMlabel.Size = new System.Drawing.Size(119, 25);
            this.COMlabel.TabIndex = 2;
            this.COMlabel.Text = "COM-ports";
            // 
            // Baudlabel
            // 
            this.Baudlabel.AutoSize = true;
            this.Baudlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Baudlabel.Location = new System.Drawing.Point(4, 51);
            this.Baudlabel.Name = "Baudlabel";
            this.Baudlabel.Size = new System.Drawing.Size(112, 25);
            this.Baudlabel.TabIndex = 3;
            this.Baudlabel.Text = "Baud Rate";
            // 
            // Initbtn
            // 
            this.Initbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Initbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Initbtn.Location = new System.Drawing.Point(297, 6);
            this.Initbtn.Name = "Initbtn";
            this.Initbtn.Size = new System.Drawing.Size(106, 34);
            this.Initbtn.TabIndex = 4;
            this.Initbtn.Text = "Init port";
            this.Initbtn.UseVisualStyleBackColor = false;
            this.Initbtn.Click += new System.EventHandler(this.Initbtn_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.AutoSize = true;
            this.Closebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Closebtn.Location = new System.Drawing.Point(297, 46);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(106, 30);
            this.Closebtn.TabIndex = 5;
            this.Closebtn.Text = "Close port";
            this.Closebtn.UseVisualStyleBackColor = false;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 98);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(394, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea21.AxisX.Title = "Time, s";
            chartArea21.AxisY.Maximum = 180D;
            chartArea21.AxisY.Minimum = 0D;
            chartArea21.AxisY.Title = "Angle, deg";
            chartArea21.BorderWidth = 2;
            chartArea21.Name = "ChartArea2";
            customLabel6.Text = "Angle";
            chartArea22.AxisX.CustomLabels.Add(customLabel6);
            chartArea22.AxisX.Title = "Time, s";
            chartArea22.AxisY.Maximum = 180D;
            chartArea22.AxisY.Minimum = 0D;
            chartArea22.AxisY.Title = "Angle, deg";
            chartArea22.BorderWidth = 2;
            chartArea22.Name = "ChartArea1";
            chartArea23.AxisX.Title = "Time, s";
            chartArea23.AxisX2.Title = "Angle, deg";
            chartArea23.AxisY.Maximum = 180D;
            chartArea23.AxisY.Minimum = 0D;
            chartArea23.AxisY.Title = "Angle, deg";
            chartArea23.BorderWidth = 2;
            chartArea23.Name = "ChartArea3";
            chartArea24.AxisX.Title = "Time, s";
            chartArea24.AxisY.Maximum = 90D;
            chartArea24.AxisY.Minimum = 0D;
            chartArea24.AxisY.Title = "Angle, deg";
            chartArea24.BorderWidth = 2;
            chartArea24.Name = "ChartArea4";
            this.chart1.ChartAreas.Add(chartArea21);
            this.chart1.ChartAreas.Add(chartArea22);
            this.chart1.ChartAreas.Add(chartArea23);
            this.chart1.ChartAreas.Add(chartArea24);
            legend6.Alignment = System.Drawing.StringAlignment.Far;
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend6.IsDockedInsideChartArea = false;
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(425, 12);
            this.chart1.Name = "chart1";
            series21.BorderColor = System.Drawing.Color.Blue;
            series21.BorderWidth = 3;
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series21.Legend = "Legend1";
            series21.Name = "Course angle";
            series22.BorderColor = System.Drawing.Color.Red;
            series22.BorderWidth = 3;
            series22.ChartArea = "ChartArea2";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series22.Legend = "Legend1";
            series22.Name = "Right bank angle";
            series23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series23.BorderWidth = 3;
            series23.ChartArea = "ChartArea3";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series23.Legend = "Legend1";
            series23.Name = "Left bank angle";
            series24.BorderColor = System.Drawing.Color.Lime;
            series24.BorderWidth = 3;
            series24.ChartArea = "ChartArea4";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series24.Legend = "Legend1";
            series24.Name = "Pitch angle";
            this.chart1.Series.Add(series21);
            this.chart1.Series.Add(series22);
            this.chart1.Series.Add(series23);
            this.chart1.Series.Add(series24);
            this.chart1.Size = new System.Drawing.Size(1443, 848);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title6.Name = "Title1";
            title6.Text = "Position graphs";
            this.chart1.Titles.Add(title6);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbTimer
            // 
            this.tbTimer.Location = new System.Drawing.Point(97, 371);
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.Size = new System.Drawing.Size(206, 22);
            this.tbTimer.TabIndex = 16;
            // 
            // btnStopTimer
            // 
            this.btnStopTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStopTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStopTimer.Location = new System.Drawing.Point(203, 399);
            this.btnStopTimer.Name = "btnStopTimer";
            this.btnStopTimer.Size = new System.Drawing.Size(100, 35);
            this.btnStopTimer.TabIndex = 15;
            this.btnStopTimer.Text = "Stop";
            this.btnStopTimer.UseVisualStyleBackColor = false;
            this.btnStopTimer.Click += new System.EventHandler(this.btnStopTimer_Click);
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStartTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartTimer.Location = new System.Drawing.Point(97, 399);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(100, 35);
            this.btnStartTimer.TabIndex = 14;
            this.btnStartTimer.Text = "Start";
            this.btnStartTimer.UseVisualStyleBackColor = false;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // tbAngle
            // 
            this.tbAngle.Location = new System.Drawing.Point(97, 470);
            this.tbAngle.Name = "tbAngle";
            this.tbAngle.Size = new System.Drawing.Size(206, 22);
            this.tbAngle.TabIndex = 17;
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(97, 522);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(206, 22);
            this.tbPosition.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Readout time interval";
            // 
            // btnFreq
            // 
            this.btnFreq.Location = new System.Drawing.Point(12, 188);
            this.btnFreq.Name = "btnFreq";
            this.btnFreq.Size = new System.Drawing.Size(160, 23);
            this.btnFreq.TabIndex = 23;
            this.btnFreq.Text = "OK";
            this.btnFreq.UseVisualStyleBackColor = true;
            this.btnFreq.Click += new System.EventHandler(this.btnFreq_Click);
            // 
            // tbFr
            // 
            this.tbFr.Location = new System.Drawing.Point(13, 151);
            this.tbFr.Name = "tbFr";
            this.tbFr.Size = new System.Drawing.Size(159, 22);
            this.tbFr.TabIndex = 24;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.richTextBox1.Location = new System.Drawing.Point(52, 667);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(301, 160);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // btnWriteToFile
            // 
            this.btnWriteToFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnWriteToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWriteToFile.Location = new System.Drawing.Point(89, 237);
            this.btnWriteToFile.Name = "btnWriteToFile";
            this.btnWriteToFile.Size = new System.Drawing.Size(214, 84);
            this.btnWriteToFile.TabIndex = 26;
            this.btnWriteToFile.Text = "Write to file";
            this.btnWriteToFile.UseVisualStyleBackColor = false;
            this.btnWriteToFile.Click += new System.EventHandler(this.btnWriteToFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Time";
            // 
            // Readtb
            // 
            this.Readtb.Location = new System.Drawing.Point(434, 838);
            this.Readtb.Name = "Readtb";
            this.Readtb.Size = new System.Drawing.Size(100, 22);
            this.Readtb.TabIndex = 28;
            this.Readtb.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Current factor";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Enter file name";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(212, 151);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(159, 22);
            this.tbFileName.TabIndex = 33;
            // 
            // btnOKFileName
            // 
            this.btnOKFileName.Location = new System.Drawing.Point(211, 188);
            this.btnOKFileName.Name = "btnOKFileName";
            this.btnOKFileName.Size = new System.Drawing.Size(160, 23);
            this.btnOKFileName.TabIndex = 34;
            this.btnOKFileName.Text = "OK";
            this.btnOKFileName.UseVisualStyleBackColor = true;
            this.btnOKFileName.Click += new System.EventHandler(this.btnOKFileName_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Current angle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 558);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "1 - Course angle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 575);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "2 - Right bank angle ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 592);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "3 - Left bank angle ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(147, 609);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "4 -  Pitch angle";
            // 
            // Serial_Port
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1880, 872);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnOKFileName);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Readtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnWriteToFile);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tbFr);
            this.Controls.Add(this.btnFreq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.tbAngle);
            this.Controls.Add(this.tbTimer);
            this.Controls.Add(this.btnStopTimer);
            this.Controls.Add(this.btnStartTimer);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.Initbtn);
            this.Controls.Add(this.Baudlabel);
            this.Controls.Add(this.COMlabel);
            this.Controls.Add(this.BaudcBox);
            this.Controls.Add(this.COMcBox);
            this.Name = "Serial_Port";
            this.Text = "Onboard information system";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Serial_Port_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox COMcBox;
        private System.Windows.Forms.ComboBox BaudcBox;
        private System.Windows.Forms.Label COMlabel;
        private System.Windows.Forms.Label Baudlabel;
        private System.Windows.Forms.Button Initbtn;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbTimer;
        private System.Windows.Forms.Button btnStopTimer;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.TextBox tbAngle;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFreq;
        private System.Windows.Forms.TextBox tbFr;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnWriteToFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Readtb;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Button btnOKFileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

