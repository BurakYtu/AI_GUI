using System;
using System.Windows.Forms;
using System.IO;

namespace Leila_GUI
{
    public partial class UserControl_Train_Setup : UserControl
    {
        int relax_second = 0;
        int right_second = 0;
        int left_second = 0;
        int nothing_second = 0;
        int time = 0;
        int delete_time = 0;

        int totalcharacters;
        int totalLines;
        string lastLine;
        int lastlinecharacters;

        public static bool isstart = false;

        public static int[] loop = new int[1000];
        public static int counter = 0;

        string time_data;

        public static bool horizon_plane; 
        public UserControl_Train_Setup()
        {
            InitializeComponent();

        }

        private void UserControl_Train_Setup_Load(object sender, EventArgs e)
        {
            try
            {
                richTextBox_mission.Text = File.ReadAllText("savedata.dat");
                time_data = File.ReadAllText("timedata.dat");
                time = Convert.ToInt16(time_data.Substring(0, 4));
                counter = Convert.ToInt16(time_data.Substring(5, 3));
                for (int i = 0; i < counter; i++)
                {
                    loop[i] = Convert.ToInt16(time_data.Substring((9 + i * 4), 3));
                }
            }
            catch
            {
                using (StreamWriter writer = new StreamWriter("savedata.dat"))
                {
                    writer.Write(richTextBox_mission.Text);
                }

                using (StreamWriter writer = new StreamWriter("timedata.dat"))
                {
                    writer.Write(time.ToString("0000") + " " + counter.ToString("000") + " ");
                }
            }
        }

        private void btn_add_relax_Click(object sender, EventArgs e)
        {
            relax_second++;
            update_buttons();
        }

        private void btn_sub_relax_Click(object sender, EventArgs e)
        {
            relax_second--;
            if (relax_second < 0) relax_second = 0;
            update_buttons();
        }

        private void btn_add_right_Click(object sender, EventArgs e)
        {
            right_second++;
            update_buttons();
        }

        private void btn_sub_right_Click(object sender, EventArgs e)
        {
            right_second--;
            if (right_second < 0) right_second = 0;
            update_buttons();
        }

        private void btn_add_left_Click(object sender, EventArgs e)
        {
            left_second++;
            update_buttons();
        }

        private void btn_sub_left_Click(object sender, EventArgs e)
        {
            left_second--;
            if (left_second < 0) left_second = 0;
            update_buttons();
        }

        private void btn_add_not_Click(object sender, EventArgs e)
        {
            nothing_second++;
            update_buttons();
        }

        private void btn_sub_not_Click(object sender, EventArgs e)
        {
            nothing_second--;
            if (nothing_second < 0) nothing_second = 0;
            update_buttons();
        }

        void update_buttons()
        {
            btn_relax.Text = "add "+ relax_second.ToString() + " second";
            btn_right.Text = "add " + right_second.ToString() + " second";
            btn_left.Text = "add " + left_second.ToString() + " second";
            btn_not.Text = "add " + nothing_second.ToString() + " second";
        }

        void update_misson(int add_time, string whitch)
        {
            if(add_time > 0)
            {
                int lasttime = time;
                delete_time = add_time;
                time += add_time;
                richTextBox_mission.Text += lasttime.ToString("00") + "  :  " + time.ToString("00") + "  ->  " + whitch + "\n";
            }
            
        }

        private void btn_delete_all_Click(object sender, EventArgs e)
        {
            relax_second = 0;
            right_second = 0;
            left_second = 0;
            nothing_second = 0;
            update_buttons();
            time = 0;
            richTextBox_mission.Text = "";
            counter = 0;
        }

        private void btn_relax_Click(object sender, EventArgs e)
        {
            update_misson(relax_second,"Relaxed");
            if (relax_second > 0)
            {
                loop[counter] = 1;
                loop[counter + 1] = relax_second;
                counter += 2;
            }
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            update_misson(right_second,"Right");
            if (right_second > 0)
            {
                loop[counter] = 2;
                loop[counter + 1] = right_second;
                counter += 2;
            }
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            update_misson(left_second,"Left");
            if (left_second > 0)
            {
                loop[counter] = 3;
                loop[counter + 1] = left_second;
                counter += 2;
            }
        }

        private void btn_not_Click(object sender, EventArgs e)
        {
            update_misson(nothing_second,"Nothing");
            if (nothing_second > 0)
            {
                loop[counter] = 4;
                loop[counter + 1] = nothing_second;
                counter += 2;
            }
        }

        private void btn_deletelast_Click(object sender, EventArgs e)
        {
            counter -= 2;
            time -= delete_time;
            totalcharacters = richTextBox_mission.Text.Trim().Length;
            totalLines = richTextBox_mission.Lines.Length;
            lastLine = richTextBox_mission.Lines[totalLines - 1];
            lastlinecharacters = lastLine.Trim().Length;
            richTextBox_mission.Text = richTextBox_mission.Text.Substring(0, totalcharacters - lastlinecharacters);

            totalcharacters = richTextBox_mission.Text.Trim().Length;
            totalLines = richTextBox_mission.Lines.Length;
            lastLine = richTextBox_mission.Lines[totalLines - 1];
            lastlinecharacters = lastLine.Trim().Length;
            richTextBox_mission.Text = richTextBox_mission.Text.Substring(0, totalcharacters - lastlinecharacters);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("savedata.dat"))
            {
                writer.Write(richTextBox_mission.Text);
            }

            using (StreamWriter writer = new StreamWriter("timedata.dat"))
            {
                writer.Write(time.ToString("0000") + " " + counter.ToString("000") + " ");
                for (int i = 0; i < counter; i++)
                {
                    writer.Write(loop[i].ToString("000") + " ");
                }
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (rb_airplane.Checked == true) horizon_plane = false;
            if (rb_horizon.Checked == true) horizon_plane = true;
            isstart = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
