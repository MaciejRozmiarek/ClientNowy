using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Sockets;
using System.Net;

namespace ClientNowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runQueryButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a TcpClient.
                Int32 port = System.Convert.ToInt16(numericUpDown1.Value);
                IPAddress localAddr = IPAddress.Parse(ipTextBox.Text);
                string server = "127.0.0.1";
                if (queryTextBox.Text == "")
                {
                    MessageBox.Show("Postaraj się lepiej, nic nie wpisałeś :)", "ERROR");
                }
                else
                {


                    Byte[] data = System.Text.Encoding.UTF8.GetBytes(this.queryTextBox.Text);
                    TcpClient client = new TcpClient(server, port);

                    // Translate the passed message into ASCII and store it as a Byte array.


                    // Get a client stream for reading and writing.
                    NetworkStream stream = client.GetStream();

                    // Send the message to the connected TcpServer. 
                    stream.Write(data, 0, data.Length);

                    // Receive the TcpServer.response.

                    // Buffer to store the response bytes.
                    data = new Byte[256];

                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    var ds = (DataSet)binaryFormatter.Deserialize(stream);

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Refresh();

                    // Close everything.
                    stream.Close();
                    client.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ArgumentNullException: {0}", ex.ToString());
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            queryTextBox.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void queryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ipTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
