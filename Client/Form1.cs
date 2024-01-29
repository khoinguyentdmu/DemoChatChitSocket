using System;
using System.Text;
using System.Net.Sockets;
using System.Windows.Forms;
using System.IO;

namespace Client
{
    public partial class Form1 : Form
    {
        private const int BUFFER_SIZE = 1024;
        private const int PORT_NUMBER = 8899;

        static ASCIIEncoding encoding = new ASCIIEncoding();

        TcpClient client = new TcpClient();
        Stream stream;
        StreamReader reader;
        StreamWriter writer;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtSend_Click(object sender, EventArgs e)
        {
            try
            {
                string message = TbMessage.Text;

                // 2. send
                writer.WriteLine(message);
                writer.Flush();

                // 3. receive
                string respond = reader.ReadLine();

                TbNotification.Text += respond + Environment.NewLine;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. connect
            client.Connect("127.0.0.1", PORT_NUMBER);
            stream = client.GetStream();

            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);
            writer.AutoFlush = true;
        }

        private void TbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtSend_Click(null, null);
                TbMessage.Text = "";
            }
        }
    }
}
