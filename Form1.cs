using System;
using System.Windows.Forms;

namespace Leila_GUI
{
    public partial class Form1 : Form
    {
        UserControl_Main uc_main = new UserControl_Main();
        UserControl_Train_Setup uc_train_setup = new UserControl_Train_Setup();
        UserControl_Train uc_train = new UserControl_Train();
        UserControl_Test uc_test = new UserControl_Test();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_main.Controls.Add(uc_main);
            uc_main.Dock = DockStyle.Fill;
        }

        private void Main_Timer_Tick(object sender, EventArgs e)
        {
            if(UserControl_Main.btn_train_pressed == true)
            {
                panel_main.Controls.Clear();
                panel_main.Controls.Add(uc_train_setup);
                uc_main.Dock = DockStyle.Fill;
                UserControl_Main.btn_train_pressed = false;
            }

            if (UserControl_Main.btn_test_pressed == true)
            {
                panel_main.Controls.Clear();
                panel_main.Controls.Add(uc_test);
                uc_test.Dock = DockStyle.Fill;
                UserControl_Main.btn_test_pressed = false;
            }

            if (UserControl_Train_Setup.isstart == true)
            {
                panel_main.Controls.Clear();
                panel_main.Controls.Add(uc_train);
                uc_train.Dock = DockStyle.Fill;
                UserControl_Train_Setup.isstart = false;
            }


        }
        

    }
}
