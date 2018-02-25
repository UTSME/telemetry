using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Telemetry_Interface
{
    static class Program
    {

        static Thread readThread = new Thread(read);

        static SerialPort _port = new SerialPort();

        static bool _running = false;

        static Form1 mainForm;

        static public string portName;
        static public int baudRate;

        static int currentValue = 0;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            mainForm = new Form1();
            mainForm.FormClosing += Close_All;

            Application.Run(mainForm);

        }

        public static async void connect()
        {

            _port.PortName = portName;
            _port.BaudRate = baudRate;

            _port.Open();
            _running = true;

            readThread.Start();

            while (_running)
            {

                update();

                await Task.Delay(100);

            }





            readThread.Join();
            _port.Close();

        }

        public static void read()
        {

            while(_running)
            {

                try
                {
                    string message = _port.ReadLine();
                    System.Diagnostics.Debug.WriteLine(message);

                    if (message != "" && message != null)
                    {
                        currentValue = Convert.ToInt32(message);
                        System.Diagnostics.Debug.WriteLine("Attempting convert");


                    }
                }
                catch (TimeoutException) { }
            }


        }

        public static void update()
        {

            //update data feeds with data

            mainForm.progressBar1.Value = currentValue;



        }

        private static void Close_All (object sender, FormClosingEventArgs e)
        {

            _running = false;
            System.Diagnostics.Debug.WriteLine("Close called by user");

        }


    }


}
