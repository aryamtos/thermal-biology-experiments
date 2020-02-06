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
using System.Diagnostics;
using System.Threading;
using System.Globalization;

namespace Arduino_V._4._1
{


    public partial class Form1 : Form
    {
        private AnchorStyles anchor;
        private List<listPoints> g_graph = new List<listPoints>();
        int v;
        double x;
        bool toogle = false;
        bool preparar = false;
        private string serialReceived;
        private string[] without_SemiColon;
        double principalTemperature;
        double rate_of_change;
        double Y;
        double cold_temperature;
        int erro;
        double aux;
        int timer;
        double initial_temp;

        public virtual AnchorStyles GetAnchor()
        {
            return anchor;
        }

        public virtual void SetAnchor(AnchorStyles value)
        {
            anchor = value;
        }

        delegate void funcaoRecepcao();

        public Form1()
        {

            InitializeComponent();
            experiment.SelectedIndex = 0;
            
            double valinit = 25;
            btIniciar.Enabled = false;
            initTemp.Text = Convert.ToString(valinit);
            rateChange.Enabled = false;
            cold.Enabled = false;
            btSave.Enabled = false;

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Config_Port
            String[] valoresPort = SerialPort.GetPortNames();
            for (int i = 0; i < valoresPort.Length; i++)
            {
                cbPortItem.Items.Add(valoresPort[i]);
            }
            cbPortItem.Text = "COM1";
            #endregion
        }
        /**
         * Função responsável por receber dados da porta serial
         */
        public void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            funcaoRecepcao recepcaodelegate = new funcaoRecepcao(RecepcaoSerial);
            Invoke(recepcaodelegate);
        }

        /**
         * Função responsável por limpar buffer vindo da porta serial
         */
        public void FlushSerial()
        {
            serialPort1.DiscardInBuffer();
            serialPort1.DiscardOutBuffer();
        }

        /**
         * @serialReceived - lê cada linha e evita pegar dados quebrados
         * @without_Semicolon - pegar a string separando-a pelo ponto e virgula
         * @initial_temperature - pega primeira parte da string
         */
        public void RecepcaoSerial()
        {
            serialReceived = serialPort1.ReadLine();
            

            without_SemiColon = serialReceived.Split(';');
           

           if(preparar == true)
            {
                acionarPreparar();
            }
            if (toogle == true ) // chama a função initProcess para execução
            {
           
               // txtOut.AppendText(serialReceived + Environment.NewLine);
                initProcess();
            }

        }
        /**
         * Método responsável por executar e calcular a função de cada tipo de temperatura
         * As temperaturas são CTMAX -CTMIN - CONSTANTE
         * Y = (rate_-f_change * time) + temperatura inicial dos sistema
         * 
         */
        public void initProcess()
        {
            if (serialReceived != null)
            {
                if (experiment.Text == "CTMAX")
                {
                    CTMAX();
                    //emptyTank();
                }
                else if (experiment.Text == "CTMIN")
                {
                    CTMIN();
                }
                else
                {
                    Constante();
                }
            }
        }
        /**
         * Método responsável por salvar arquivo em csv
         * Pega dados da lista como função, tempo e temperatura e adiciona no arquivo
         */
        private void CTMAX()
        {

            int.TryParse(time.Text, out timer);
            double.TryParse(without_SemiColon[0], System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out principalTemperature);
            double.TryParse(initTemp.Text, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out initial_temp);
            double.TryParse(rateChange.Text, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out rate_of_change);

            timer1.Start();
            
            if(initial_temp >=25 || initial_temp< 60)
            {
                double fria;
                double.TryParse(without_SemiColon[1], out cold_temperature);
                int.TryParse(without_SemiColon[2], out erro);


                cold.Text = without_SemiColon[1];
                temperature.Text = without_SemiColon[0];
              
                Y = (Math.Abs(rate_of_change) * timer) / 60.0 + initial_temp;

                x = Math.Round(Y, 5);
                
                string texto = x.ToString("G", CultureInfo.CreateSpecificCulture("en-US"));

                function.Text = texto;
                serialPort1.Write(texto + ";" + 1 + Environment.NewLine);
                g_graph.Add(new listPoints(timer, x, principalTemperature)); // adiciona valores na lista
                graphPlotMax(timer, Y, temperature.Text); //realiza a plotagem gráfica
                
                // verifica se tanque está vazio
            }
            else
            {
                 toogle = false;
                 timer1.Stop();
                 MessageBox.Show("Erro nos sensores de Temperatura");
            }
        }
        private void CTMIN()
        {
           
            int.TryParse(time.Text, out timer);
            double.TryParse(without_SemiColon[0], System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out principalTemperature);
            double.TryParse(initTemp.Text, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out initial_temp);
            double.TryParse(rateChange.Text, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out (rate_of_change));

            timer1.Start();

            if (initial_temp >= 25 || initial_temp < 60)
            {
                double.TryParse(without_SemiColon[1], out cold_temperature);
                int.TryParse(without_SemiColon[2], out erro);
                cold.Text = without_SemiColon[1];
                temperature.Text = without_SemiColon[0];
                Y = -(Math.Abs(rate_of_change) * timer) / 60.0 + initial_temp;
                x = Math.Round(Y, 5);
                string texto = x.ToString("G", CultureInfo.CreateSpecificCulture("en-US"));
                function.Text = texto;
                serialPort1.Write(texto + ";" + 1 + Environment.NewLine);
                g_graph.Add(new listPoints(timer, x, principalTemperature)); // adiciona valores na lista
                graphPlotMin(timer, Y, temperature.Text); //realiza a plotagem gráfica
                //emptyTank(); // verifica se tanque está vazio
            }
            else
            {
                toogle = false;
                timer1.Stop();
                MessageBox.Show("Erro nos sensores de Temperatura");
            }
        }
        private void Constante()
        {
           
            int.TryParse(time.Text, out timer);
            double.TryParse(without_SemiColon[0], System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out principalTemperature);
            double.TryParse(initTemp.Text, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out initial_temp);
            double.TryParse(rateChange.Text, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out rate_of_change);

            timer1.Start();

            if (initial_temp >= 25 || initial_temp < 60)
            {
                double.TryParse(without_SemiColon[1], out cold_temperature);
                int.TryParse(without_SemiColon[2], out erro);

                cold.Text = without_SemiColon[1];
                temperature.Text = without_SemiColon[0];

                Y = initial_temp;

                x = Math.Round(Y, 5);

                string texto = x.ToString("G", CultureInfo.CreateSpecificCulture("en-US"));

                function.Text = texto;
                serialPort1.Write(texto + ";" + 1 + Environment.NewLine);
                g_graph.Add(new listPoints(timer, x, principalTemperature)); // adiciona valores na lista
                graphPlotConstante(timer, Y, temperature.Text); //realiza a plotagem gráfica
                
                //emptyTank(); // verifica se tanque está vazio
            }
            else
            {
                toogle = false;
                timer1.Stop();
                MessageBox.Show("Erro nos sensores de Temperatura");
            }
        }
       /**
         * Método responsável por salvar arquivo em csv
         * Pega dados da lista como função, tempo e temperatura e adiciona no arquivo
         */
        public void SaveFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Texto|*.txt";
            sfd.Title = "Salvar Texto";
            DialogResult drt = sfd.ShowDialog();
            if (drt != DialogResult.OK)
                return;
            String caminho = sfd.FileName;
            StreamWriter swriter = new StreamWriter(caminho);

            swriter.Write("{0}{1}", string.Empty.PadRight(0, ' '), "Tempo");
            swriter.Write("{0}{1}", string.Empty.PadRight(3, ' '), "Referência");
            swriter.Write("{0}{1}", string.Empty.PadRight(3, ' '), "Temperatura");
            swriter.Write("\n");

            for (int i = 0; i < g_graph.Count; i++)
            {
                swriter.Write("{0}{1}", string.Empty.PadRight(0, ' '), g_graph[i].Time);
                swriter.Write("{0}{1}", string.Empty.PadRight(3, ' '), g_graph[i].Y);
                swriter.Write("{0}{1}", string.Empty.PadRight(3, ' '), g_graph[i].temper);
                swriter.Write("\n");

            }
            swriter.Close();
        }

        /**
         * Método responsável por verificar se o tanque encontra-se vazio
         * Está vazio se recebe 1 que será o indicador de erro
         * Exibe mensagem de erro e envia 0 pela porta serial
         * Para a execução 
         */
        /*private void  emptyTank()
        {
            if(without_SemiColon[2] == "1")
            {
                MessageBox.Show("Tanque Vazio");
                txtOut.AppendText(serialReceived + Environment.NewLine);
                serialPort1.Write(function.Text + ";" + 0 + Environment.NewLine);
                toogle = false;
                timer1.Stop();
              
            }
        }*/
        /**
         * Função responsável pela plotagem gráfica - Tempo x função - Tempo x temperature
         */
        private void graphPlotMax(double timer, double function, string temperature)
        {
            if (chart.Series[1].Points.Count > 9)

            {

                chart.ChartAreas[0].AxisY.Minimum = 25;
                chart.Series[1].Points.RemoveAt(0);
                chart.Series[0].Points.RemoveAt(0);

                chart.Update();

            }
            chart.Series[1].Points.AddXY(timer, function);
            chart.Series[0].Points.AddXY(timer, temperature);
            chart.Show();

        }
        private void graphPlotConstante(double timer, double function, string temperature)
        {
            double.TryParse(initTemp.Text, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out initial_temp);
            if (chart.Series[1].Points.Count > 9)

            {

                chart.ChartAreas[0].AxisY.Maximum = initial_temp + 5;
                chart.ChartAreas[0].AxisY.Minimum = initial_temp - 5;
                    ;
                chart.Series[1].Points.RemoveAt(0);
                chart.Series[0].Points.RemoveAt(0);

                chart.Update();

            }
            chart.Series[1].Points.AddXY(timer, function);
            chart.Series[0].Points.AddXY(timer, temperature);
            chart.Show();

        }
        private void graphPlotMin(double timer, double function, string temperature)
        {
            if (chart.Series[1].Points.Count > 9)

            {

                chart.ChartAreas[0].AxisY.Maximum = 60;

                chart.Series[1].Points.RemoveAt(0);
                chart.Series[0].Points.RemoveAt(0);

                chart.Update();

            }
            chart.Series[1].Points.AddXY(timer, function);
            chart.Series[0].Points.AddXY(timer, temperature);
            chart.Show();

        }


        /**
         * Classe responsável pela lista, recebe como parâmetros função, tempo e temperatura
         */
        public class listPoints
        {
            public double temper { get; }
            public int Time { get; }             //Posicao no grafico
            public double Y { get; }

            public listPoints(int time, double funct, double temperature)
            {
                Time = time;
                temper = temperature;
                Y = funct;
            }
        }

        /**
         * Atualiza portas seriais
         */
        private void updateListComs()
        {
            int i = 0;
            bool differentAmount = false;


            if (cbPortItem.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (cbPortItem.Items[i++].Equals(s) == false)
                    {
                        differentAmount = true;
                    }
                }
            }
            else
            {
                differentAmount = true;
            }

            if (differentAmount == false)
            {
                return;
            }

            cbPortItem.Items.Clear();

            foreach (string s in SerialPort.GetPortNames())
            {
                cbPortItem.Items.Add(s);
            }

            cbPortItem.SelectedIndex = 0;
        }
        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();


            }
            else
            {
                serialPort1.PortName = cbPortItem.Text;
            }
            try
            {
                serialPort1.Open();
                btnConectar.Enabled = false;
                btDescon.Enabled = true;
                btClose.Enabled = true;
                btPrepare.Enabled = true;
                btIniciar.Enabled = false;
                toogle = false;
                FlushSerial();
          

            }
            catch
            {
                MessageBox.Show("Erro de comunicação com a porta!!");
                btnConectar.Enabled = true;
                btDescon.Enabled = false;
                btClose.Enabled = true;

                System.Threading.Thread.Sleep(1000 - DateTime.Now.TimeOfDay.Milliseconds);
            }
        }



        private void btDescon_Click(object sender, EventArgs e)
        {

            try
            {
                serialPort1.Close();
                btnConectar.Enabled = true;
                btDescon.Enabled = false;
                btClose.Enabled = true;
                time.Text = " ";
                temperature.Text = " ";
                initTemp.Text = string.Empty;
                rateChange.Text = string.Empty;
                function.Text = string.Empty;
                btIniciar.Enabled = false;
                timer1.Stop();
                rateChange.Enabled = false;
                btSave.Enabled = true;
                cold.Text = string.Empty;

//                FlushSerial();

            }

            catch
            {
                MessageBox.Show("Erro de comunicação com a porta!!");
                btnConectar.Enabled = false;
                btDescon.Enabled = true;
                btClose.Enabled = false;
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateListComs();
            int.TryParse(time.Text, out v);
            v = v + 1;
            time.Text = Convert.ToString(v);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void btPrepare_Click(object sender, EventArgs e)
        {

            preparar = true;

            /*double.TryParse(without_SemiColon[0], System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out principalTemperature);
           double.TryParse(initTemp.Text, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out initial_temp);

            if (serialPort1.IsOpen == true)
            {
                
               if(Math.Abs(principalTemperature - initial_temp) >= 0.5)
                {
                    serialPort1.Write(initTemp.Text + ";" + 1 + Environment.NewLine);
                    btIniciar.Enabled = true;
                    rateChange.Enabled = true;
                    cold.Text = without_SemiColon[1];
                    temperature.Text = without_SemiColon[0];
                }
                
            }
            else
            {
                MessageBox.Show("Verifique a porta de conexão");
            }*/
           

        }
        private void acionarPreparar()
        {

         
                double.TryParse(without_SemiColon[0], System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out principalTemperature);
                double.TryParse(initTemp.Text, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out initial_temp);

                if (preparar == true)
                {

                    if (Math.Abs(principalTemperature - initial_temp) >= 0.5)
                    {
                        serialPort1.Write(initTemp.Text + ";" + 1 + Environment.NewLine);
                        btIniciar.Enabled = true;
                        rateChange.Enabled = true;
                        cold.Text = without_SemiColon[1];
                        temperature.Text = without_SemiColon[0];
                    }


                }
                else
                {
                    MessageBox.Show("Verifique a porta de conexão");
                }
            

        }


        private void btfim_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                //txtOut.AppendText(serialReceived + Environment.NewLine);
                serialPort1.Write(function.Text + ";" + 2 + Environment.NewLine);
                toogle = false;
                btSave.Enabled = true;
                timer1.Stop();
                time.Text = string.Empty;
                cold.Text = string.Empty;
                rateChange.Text = string.Empty;
                temperature.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Porta desconectada!");
            }


        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void time_TextChanged(object sender, EventArgs e)
        {

        }

        private void btIniciar_Click(object sender, EventArgs e)
        {

            toogle = true;
        }

        private void temperature_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen == true)
            {
                //txtOut.AppendText(serialReceived + Environment.NewLine);

                serialPort1.Write(function.Text + ";" + 0 + Environment.NewLine);
                toogle = false;
                btSave.Enabled = true;
                function.Text = string.Empty;
                temperature.Text = string.Empty;
                cold.Text = string.Empty;
                rateChange.Text = string.Empty;
                time.Text = string.Empty;
                timer1.Stop();
                FlushSerial();
              
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string filename = "Manual_THL_Thermal_Biology_Experiments.pdf";

                System.Diagnostics.Process.Start(filename);
            }
            catch
            {
                MessageBox.Show("Manual não encontrado!Verifique local do arquivo!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // writeListToFile();

        }

        private void chart_Click(object sender, EventArgs e)
        {

        }
    }
}
