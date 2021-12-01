//#define RESEARCH
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;


namespace VS_Proj
{
    public partial class Serial_Port : Form
    {
        public delegate void AddDataDelegate();
        public AddDataDelegate RxDelegate;
        public const int ALL_P = 4;
        public const int NUM_ENC_DATABITS = 6;
        byte[] indata;
        double position;

        string filename = "DataAngles";
        string dataOUT;
        double detection_freq = 0;
        double tmp;
        double cur_tmp;
        double angle;
        double[] prev_angle;
        double[] max_angle;
        double[][] angles = new double[10000][]; 
        double[] min_angle;
        int num = -1;
        double[] factor;

        public Serial_Port()
        {
            InitializeComponent();
        }

        private void Serial_Port_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames(); //choosing ports
            COMcBox.Items.AddRange(ports);
            this.RxDelegate = new AddDataDelegate(AddDataMethod);
            indata = new byte[8];
        }

        private void Received_IRQh(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            if (serialPort1.IsOpen && serialPort1.BytesToRead > 0)
                try
                {
                    sp.Read(indata, 0, 8);
                    Readtb.Invoke(this.RxDelegate, new Object[] { });
                }
                catch (TimeoutException exp)
                {
                    MessageBox.Show(exp.Message, "Received distored package", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    serialPort1.Close();
                }
        }

        public void AddDataMethod()
        {
            Readtb.Text = Convert.ToString(BitConverter.ToInt32(indata, 0));
            Readtb.AppendText(Environment.NewLine);
        }

        private void Initbtn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = COMcBox.Text;
                serialPort1.BaudRate = Convert.ToInt32(BaudcBox.Text); //data, stop bits in settings
                serialPort1.Open();
                Readtb.Text = "Received data";
                progressBar1.Value = 100;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            progressBar1.Value = 0;
        }

        /*
         * description : при нажатии на кнопку "Start Timer" проверяем открытие порта, затем создаем прерыввние для приема данных с последовательного
         * порта, задаем значения множителей для вывода значений углов на график
         */
        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (detection_freq == 0)
                {
                    MessageBox.Show("Take a detection freq", "Receive can be start", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                tbTimer.Text = Convert.ToString(0);
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(Received_IRQh);
                prev_angle = new double[4];
                max_angle = new double[4];
                min_angle = new double[4];
                factor = new double[4];
             
                factor[0] = 5.625; //0-180
                factor[1] = 5.625;
                factor[2] = 5.625; //0-180
                factor[3] = 2.8125; //0-90
                timer1.Start();
            }
            else
            {
                MessageBox.Show("You must initialize the serial port or press the 'Start' button", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            if ((serialPort1.IsOpen) && (timer1.Enabled))
            {
                timer1.Stop();
                dataOUT = "stop";
                serialPort1.WriteLine(dataOUT);
                richTextBox1.Text = "Time:" + "\t" + Convert.ToString(tmp) + "\n";
                richTextBox1.Text += "Max course angle:" + "\t" + Convert.ToString(max_angle[0]) + "\n";
                richTextBox1.Text += "Max bank angle:" + "\t" + Convert.ToString(max(max_angle[2], max_angle[1])) + "\n";
                richTextBox1.Text += "Max pitch angle:" + "\t" + Convert.ToString(max_angle[3]) + "\n";
                richTextBox1.Text += "Min course angle:" + "\t" + Convert.ToString(min_angle[0]) + "\n";
                richTextBox1.Text += "Min bank angle:" + "\t" + Convert.ToString(min(min_angle[2], min_angle[1])) + "\n";
                richTextBox1.Text += "Min pitch angle:" + "\t" + Convert.ToString(min_angle[3]) + "\n";
            }
            else
            {
                MessageBox.Show("You must initialize the serial port or press the 'Start' button", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tmp = Convert.ToDouble(tbTimer.Text);
            tmp += detection_freq;
            tbTimer.Text = Convert.ToString(tmp); 
            cur_tmp = tmp;
            int time = (int)cur_tmp; 
            num += 1;

            string x = Convert.ToString(time);
            angle = angle_mask(indata); //текущее значение угла
            position = position_mask(indata); //текущее значение положения датчика наклона
#if RESEARCH
            schedule_entry_research(position, prev_angle, x, angle); //функция вывода значения энкодера для исследоввания 
#else 
            schedule_entry(position, prev_angle, x, angle, max_angle, min_angle); //функция вывода углов на графики
#endif
            assignment_angles(prev_angle, cur_tmp); //функция фиксации текущих значений углов для последующей записи в файл
        }

        /* input : tilt_position - текущее положение датчика наклона,  previous_angle - массив значений углов в предыдущий "тик", x - значение для оси абсцисс,
         * angle - текущее значение энкодера, MAX_angle - массив для хранения максимальных значений углов, MIN_angle - массив для хранения максимальных значений углов
         * output : 
         * description : вывод значений углов на графики, вызов функций максимума и минимума
         * Здесь происходит изменение массива previous_angle - после выполнения функции в массив записываются значения текущего тика
         * author : Ju
         * date : 2021-11-10
         * version : final
         */
        
        private void schedule_entry(double tilt_position, double[] previous_angle, string x, double angle, double[] MAX_angle, double[] MIN_angle)
        {
            int number_of_position = (int)tilt_position;

            double current_angle = angle* factor[number_of_position]; 

            tbAngle.Text = Convert.ToString(current_angle);
            tbPosition.Text = Convert.ToString(number_of_position);

            chart1.Series[number_of_position].Points.AddXY(x, current_angle); 

            maximum_angle(number_of_position, previous_angle, current_angle, MAX_angle); 
            minimum_angle(number_of_position, previous_angle, current_angle, MIN_angle); 

            previous_angle[number_of_position] = current_angle; 

            for (int i = 0; i < ALL_P; i++)
            {
                if (i != number_of_position)
                    chart1.Series[i].Points.AddXY(x, previous_angle[i]); 
            }
        }

        /* input : tilt_position - текущее положение датчика наклона,  previous_angle - массив значений углов в предыдущий "тик", x - значение для оси абсцисс,
        * angle - текущее значение энкодера
        * output : 
        * description : функция для исследования. Вывод на график только значений энкодера текущей позиции. Нет умножения на коэффициент, т.к. для наглядности мы используем 
        * показания самого датчика
        * author : Ju
        * date : 2021-11-12
        * version : final
        */
        private void schedule_entry_research(double tilt_position, double[] previous_angle, string x, double angle)
        {
            int number_of_position = (int)tilt_position;
            tbAngle.Text = Convert.ToString(angle);
            tbPosition.Text = Convert.ToString(number_of_position);
            chart1.Series[number_of_position].Points.AddXY(x, angle); //вывод на график текущего значения энкодера
            previous_angle[number_of_position] = angle;
        }

        /* input : previous_angle - массив значений углов на графиках в данный момент времени, time - текущее время
         * output : 
         * description : фиксация текцщих значений углов для последующей записи в файл 
         * author : Ju
         * date : 2021-11-05
         * version : final
         */

        private void assignment_angles(double[] previous_angle, double time)
        {
            angles[num] = new double[4];
            angles[num][0] = time;
            angles[num][1] = previous_angle[0];
            angles[num][2] = max(previous_angle[1], previous_angle[2]);
            angles[num][3] = previous_angle[3];
        }

       /* input : rx_data - данные, принимаемые с последовательного порта
        * output : double a - значение текущего угла
        * description : наложение маски 00111111
        * author : Ju
        * date : 2021-10-30
        * version : final
        */

        private double angle_mask(byte[] rx_data)
        {
            byte a = (byte)(rx_data[0] & 0x3f); 
            return Convert.ToDouble(a); 
        }

        /* input : rx_data - данные, принимаемые с последовательного порта
         * output : double p - значение текущей позиции
         * description : наложение маски 11000000
         * author : Ju
         * date : 2021-10-30
         * version : final
       */

        private double position_mask(byte[] rx_data)
        {
            byte p = (byte)((rx_data[0] & 0xc0) >> NUM_ENC_DATABITS); 
            return Convert.ToDouble(p);
        }

        private void btnFreq_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (tbFr.Text == "")
                {
                    MessageBox.Show("Set the readout time interval", "Reception cannot start", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                detection_freq = Convert.ToDouble(tbFr.Text);
                timer1.Interval = (int)(detection_freq * 1000);
            }
            else
            {
                MessageBox.Show("You have to init serial port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* input : number_of_position - номер текуей позиции, previous_angle - массив значений углов на графиках в предыдущий момент времени, 
         * current_angle - текущий угол, соответствующий текущей позиции, MAX_angle - массив для записи максимальных углов по позициям 
         * output : 
         * description : запись результата сравнения (т.е. большего угла) текущего угла и предыдущего угла текущей позиции в массив максимальных углов
         * author : Ju
         * date : 2021-11-11
         * version : final
       */
        private void maximum_angle(int number_of_position , double[] previous_angle, double current_angle, double[] MAX_angle)
        {
            MAX_angle[number_of_position] = max(current_angle, previous_angle[number_of_position]);
        }
        /* input : number_of_position - номер текуей позиции, previous_angle - массив значений углов на графиках в предыдущий момент времени, 
         * current_angle - текущий угол, соответствующий текущей позиции, MIN_angle - массив для записи минимальных углов по позициям 
         * output : 
         * description : запись результата сравнения (т.е. меньшего угла) текущего угла и предыдущего угла текущей позиции в массив минимальных углов
         * author : Ju
         * date : 2021-11-11
         * version : final
       */
        private void minimum_angle(int number_of_position, double[] previous_angle, double current_angle, double[] MIN_angle)
        {
            MIN_angle[number_of_position] = min(current_angle, previous_angle[number_of_position]);
        }
        /* input : a - первое значение, b - второе значение
        * output : a, если оно больше b; b, если оно больше a
        * description : сравнение двух значений и вывод большего из них
        * author : Ju
        * date : 2021-11-11
        * version : final
        */
        private double max(double a, double b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        /* input : a - первое значение, b - второе значение
        * output : a, если оно меньше b; b, если оно меньше a
        * description : сравнение двух значений и вывод меньшего из них
        * author : Ju
        * date : 2021-11-11
        * version : final
        */
        private double min(double a, double b)
        {
            if (a < b)
                return a;
            else
                return b;
        }

        private void btnWriteToFile_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\user\\Documents\\"+filename+".txt");
                sw.WriteLine("Время" + "\t" + "Курс" + "\t" + "Крен" + "\t" + "Тангаж");
                for (int i = 0; i < num + 1; i++)
                {
                    sw.WriteLine(Convert.ToString(angles[i][0]) + "\t" + Convert.ToString(angles[i][1]) + "\t" + Convert.ToString(angles[i][2]) + "\t" + Convert.ToString(angles[i][3]));
                }
                MessageBox.Show("Data written to file", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sw.Close();
            }
            catch (Exception e1)
            {
                Console.WriteLine("Exception: " + e1.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        private void btnOKFileName_Click(object sender, EventArgs e)
        {
            filename = tbFileName.Text;
        }
    }
}
