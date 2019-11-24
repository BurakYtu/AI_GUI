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

namespace Leila_GUI
{
    public partial class UserControl_Train : UserControl
    {
        int second;
        int c = 0;
        int timer_hold = 0;
        int timer_current = 1;
        public UserControl_Train()
        {
            InitializeComponent();
        }

        private void Control_Timer_Tick(object sender, EventArgs e)
        {
            timer_current++;

            if (c > UserControl_Train_Setup.counter - 2) Control_Timer.Stop();

            if (UserControl_Train_Setup.loop[c] == 1)
            {
                second = UserControl_Train_Setup.loop[c + 1];
                timer_hold = second;
            }
            if (UserControl_Train_Setup.loop[c] == 2)
            {
                second = UserControl_Train_Setup.loop[c + 1];
                pictureBox.Image = Leila_GUI.ResourceIcons.right;
                timer_hold = second;
            }
            if (UserControl_Train_Setup.loop[c] == 3)
            {
                second = UserControl_Train_Setup.loop[c + 1];
                pictureBox.Image = Leila_GUI.ResourceIcons.left;
                timer_hold = second;
            }
            if (UserControl_Train_Setup.loop[c] == 4)
            {
                second = UserControl_Train_Setup.loop[c + 1];
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
            Control_Timer.Start();
            if(UserControl_Train_Setup.horizon_plane) pictureBox1.Image = Leila_GUI.ResourceIcons.artificial_horizon;
            else pictureBox1.Image = Leila_GUI.ResourceIcons.airplane;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Leila_GUI.ResourceIcons.man_with_right_arms_lifted;
            Thread.Sleep(1000);
            pictureBox.Image = Leila_GUI.ResourceIcons.man_with_left_arms_lifted;
        }

    }
}
