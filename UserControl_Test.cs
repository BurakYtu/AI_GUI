using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Net;
//using System.Net.Sockets;

namespace Leila_GUI
{
    public partial class UserControl_Test : UserControl
    {
        //UdpClient Client = new UdpClient(25000); //this device Port number

        string data = "";
            
        public UserControl_Test()
        {
            InitializeComponent();
        }

        private void btn_begin_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Client.BeginReceive(new AsyncCallback(recv), null);
            //}
            //catch (Exception ex)
            //{
            //    richTextBox_udprecieve.Text += ex.Message.ToString();
            //}
            /*
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            IPAddress broadcast = IPAddress.Parse("192.168.214.20");

            byte[] sendbuf = Encoding.ASCII.GetBytes(richTextBox_udprecieve.Text);
            IPEndPoint ep = new IPEndPoint(broadcast, 25000); //slave adress, slave port

            s.SendTo(sendbuf, ep);
            */
        }
        /*
        void recv(IAsyncResult res)
        {
            
            IPEndPoint RemoteIP = new IPEndPoint(3232270736, 60240); //mater ip, 60240 UPD port
                                                                     //ip önce noktadan ayrılarak hexadecimal yapılacak
                                                                     //sonra hexadecimaller yan yana eklenip decimal yapılacak
                                                                     //sonra long formatında birinci değişkenin yerine yazılacak
                                                                     //haberleşme portu yukarıda tanımlanıyor
            byte[] recieved = Client.EndReceive(res, ref RemoteIP);
            data = Encoding.UTF8.GetString(recieved);

            this.Invoke(new MethodInvoker(delegate
            {
                richTextBox_udprecieve.Text += "\n Recieved data : " + data;
            }));

            Client.BeginReceive(new AsyncCallback(recv), null);
        }
         */
    }
}
