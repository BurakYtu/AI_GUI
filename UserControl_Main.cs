using System;
using System.Windows.Forms;

namespace Leila_GUI
{
    public partial class UserControl_Main : UserControl
    {
        public static bool btn_train_pressed = false;
        public static bool btn_test_pressed = false;
        public UserControl_Main()
        {
            InitializeComponent();
        }

        private void btn_train_Click(object sender, EventArgs e)
        {
            if(btn_train_pressed == false)
            {
                btn_train_pressed = true;
            }
            else
            {
                btn_train_pressed = false;
            }
                
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            if (btn_test_pressed == false)
            {
                btn_test_pressed = true;
            }
            else
            {
                btn_test_pressed = false;
            }
        }
    }
}
