using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Robocrab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                portBox.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                portBox.SelectedIndex = 0;

                
                serialPort1.BaudRate = (9600);
                serialPort1.ReadTimeout = (2000);
                serialPort1.WriteTimeout = (2000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
                serialPort1.WriteLine("open");
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
                serialPort1.WriteLine("close");
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
                serialPort1.WriteLine("reset");
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
                serialPort1.WriteLine("test");
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRap_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
                serialPort1.WriteLine("rap");
                Thread.Sleep(20);
                serialPort1.WriteLine(speedText.Text);
                Thread.Sleep(20);
                serialPort1.WriteLine(durationText.Text);
                Thread.Sleep(20);
                serialPort1.WriteLine(angleText.Text);
                Thread.Sleep(20);
                serialPort1.WriteLine(rotationText.Text);
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void portBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = portBox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            help p = new help();
            p.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }


    }
}
