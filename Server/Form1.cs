using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.IO;

namespace Server
{
    public partial class Form1 : Form
    {
        private const int BUFFER_SIZE = 1024;
        private const int PORT_NUMBER = 8899;

        static ASCIIEncoding encoding = new ASCIIEncoding();

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                IPAddress address = IPAddress.Parse("127.0.0.1");

                TcpListener listener = new TcpListener(address, PORT_NUMBER);

                // 1. listen
                listener.Start();

                TbNotification.Text += "Server started on " + listener.LocalEndpoint + Environment.NewLine;
                TbNotification.Text += "Waiting for a connection..." + Environment.NewLine;

                // Start the listener in a separate task
                await Task.Run(() => ListenForClient(listener));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ListenForClient(TcpListener listener)
        {
            try
            {
                Socket socket = listener.AcceptSocket();
                TbNotification.Invoke(new Action(() =>
                {
                    TbNotification.Text += "Connection received from " + socket.RemoteEndPoint + Environment.NewLine;
                }));

                var stream = new NetworkStream(socket);
                StreamReader reader = new StreamReader(stream);
                StreamWriter writer = new StreamWriter(stream);
                writer.AutoFlush = true;

                // 2. receive
                while (true)
                {
                    string message = reader.ReadLine();
                    TbNotification.Invoke(new Action(() =>
                    {
                        TbNotification.Text += "Messsage: " + message + Environment.NewLine;
                    }));

                    // 3. send
                    writer.WriteLine(string.Format("Your message: {0}. There are {1} letters in your message", message, CountLetters(message)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int CountLetters(string input)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
