using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using SimpleTCP;

namespace Leila_GUI
{

    public partial class UserControl_Train : UserControl
    {
        //UdpClient Client = new UdpClient(10000); //this device Port number
        //string data = "";

        int second;
        int c = 0;
        int timer_hold = 0;
        int timer_current = 0;
        byte []send = new byte[1];
        SimpleTcpServer server;

        public UserControl_Train()
        {
            InitializeComponent();
        }

        private void Control_Timer_Tick(object sender, EventArgs e)
        {
            timer_current++;

            if (c > UserControl_Train_Setup.counter - 2)
            {
                Control_Timer.Stop();
                button1.Text = "STOPPED";
            }

            if (UserControl_Train_Setup.loop[c] == 1)
            {
                second = UserControl_Train_Setup.loop[c + 1];
                pictureBox.Image = Leila_GUI.ResourceIcons.subt___Kopyala;
                label1.Text = "Relaxed";
                timer_hold = second;
            }
            if (UserControl_Train_Setup.loop[c] == 2)
            {
                second = UserControl_Train_Setup.loop[c + 1];
                pictureBox.Image = Leila_GUI.ResourceIcons.right;
                label1.Text = "";
                timer_hold = second;
            }
            if (UserControl_Train_Setup.loop[c] == 3)
            {
                second = UserControl_Train_Setup.loop[c + 1];
                pictureBox.Image = Leila_GUI.ResourceIcons.left;
                label1.Text = "";
                timer_hold = second;
            }
            if (UserControl_Train_Setup.loop[c] == 4)
            {
                second = UserControl_Train_Setup.loop[c + 1];
                pictureBox.Image = Leila_GUI.ResourceIcons.add___Kopyala;
                label1.Text = "Focus";
                timer_hold = second;
            }

            if (timer_hold == timer_current)
            {
                c += 2;
                timer_current = 0;
            }

        }

        private void UserControl_Train_Load(object sender, EventArgs e)
        {
            //Control_Timer.Start();
            
            if(UserControl_Train_Setup.horizon_plane) pictureBox1.Image = Leila_GUI.ResourceIcons.artificial_horizon;
            else pictureBox1.Image = Leila_GUI.ResourceIcons.airplane;

            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;

            /*
            serialPort1.PortName = "COM5";
            serialPort1.BaudRate = 9600;
            serialPort1.StopBits = System.IO.Ports.StopBits.One;
            serialPort1.DataBits = 8;
            serialPort1.Open();
            */
        }


        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            label_tcp.Text = e.MessageString;
            e.ReplyLine(e.MessageString);
            /*
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += e.MessageString;
                txtStatus.Text += e.MessageString;
                e.ReplyLine(string.Format("You said: {0}", e.MessageString));
            });
            */
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Control_Timer_Tick(sender, e);
            Control_Timer.Enabled = true;
            button1.Text = "Started";
            
            System.Net.IPAddress ip = System.Net.IPAddress.Parse("192.168.43.239");
            server.Start(ip, Convert.ToInt32("7070"));
            label_tcp.Text = "server started";
            server.Broadcast("1");
            //send[0] = 12;
            //serialPort1.Write(send, 0, 1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {/*
          Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            IPAddress broadcast = IPAddress.Parse("192.168.214.20");

            byte[] sendbuf = Encoding.ASCII.GetBytes("5555");
            IPEndPoint ep = new IPEndPoint(broadcast, 12000); //slave adress, slave port

            s.SendTo(sendbuf, ep);
*/        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
 