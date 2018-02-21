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

namespace Telemetry_Interface
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();

            string[] ports = SerialPort.GetPortNames();


            foreach (string s in ports)
            {
                comPortBox.Items.Add(s);
                System.Diagnostics.Debug.WriteLine(s);


            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void connectBtn_Click(object sender, EventArgs e)
        {

            Program.portName = comPortBox.Text;
            Program.baudRate = Convert.ToInt32(baudRateBox.Text);

            Program.connect();

        }

    }
}
