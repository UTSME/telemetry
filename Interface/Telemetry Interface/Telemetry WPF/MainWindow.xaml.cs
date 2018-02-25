using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO.Ports;
using System.Threading;

namespace Telemetry_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static Thread recieveThread = new Thread(Recieve);
        static SerialPort inPort = new SerialPort();
        static bool running = false;

        static int rpm = 0;

        public MainWindow()
        {
            InitializeComponent();

            string[] ports = SerialPort.GetPortNames();

            foreach (string s in ports)
            {
                comPortBox.Items.Add(s);
            }

            initGauges();

        }

        private async void connectBtn_Click(object sender, RoutedEventArgs e)
        {

            if (comPortBox.Text != "" && baudRateBox.Text != "")
            {

                inPort.PortName = comPortBox.Text;
                inPort.BaudRate = Convert.ToInt32(baudRateBox.Text);
                inPort.Open();
                running = true;

                recieveThread.Start();

                while (running)
                {

                    update();

                    await Task.Delay(100);

                }

                recieveThread.Join();
                inPort.Close();


            } else
            {
                MessageBox.Show("Invalid COM Port or Baud Rate!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            


        }

        private static void Recieve()
        {

            while (running)
            {

                try
                {
                    string msg = inPort.ReadLine();
                    System.Diagnostics.Debug.WriteLine(msg);

                    if (msg != "" || msg != null)
                    {
                        try
                        {
                            rpm = Convert.ToInt32(msg);
                        } catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine(ex.Message);
                        }
                        
                    }

                    

                } catch (TimeoutException e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message);
                }


            }


        }

        private void update()
        {

            gaugeSpeed.PrimaryScale.Value = rpm;

        }

        private void initGauges()
        {

            


        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            running = false;
        }

        private void refreshComBtn_Click(object sender, RoutedEventArgs e)
        {

            comPortBox.Items.Clear();

            string[] ports = SerialPort.GetPortNames();

            foreach (string s in ports)
            {
                comPortBox.Items.Add(s);
            }

        }

    }
}
