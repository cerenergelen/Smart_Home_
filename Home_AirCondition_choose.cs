using Smart_Home_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Home_
{
    public partial class Home_AirCondition_choose : Form
    {

        public static bool bedroom1_airCondition_isOn = true;
        public static bool living_room_airCondition_isOn = true;
        public static bool bedroom2_airCondition_isOn = true;

        public static int bedroom1_temperature = 25;
        public static int living_room_temperature = 25;
        public static int bedroom2_temperature = 25;

        public static string bedroom1_fan_speed = "Düşük hız";
        public static string living_room_fan_speed = "Ortalama hız";
        public static string bedroom2_fan_speed = "Yüksek hız";

        public static string bedroom1_program = "Soğuk";
        public static string living_room_program = "Soğuk";
        public static string bedroom2_program = "Soğuk";


        public Home_AirCondition_choose()
        {
            InitializeComponent();
        }

        private void Home_AirCondition_choose_Load(object sender, EventArgs e)
        {
            richTextBox8.Text = bedroom1_program;
            richTextBox9.Text = bedroom1_fan_speed;
            richTextBox10.Text = bedroom1_temperature.ToString() + "°C";

            richTextBox11.Text = living_room_temperature.ToString() + "°C";
            richTextBox12.Text = living_room_fan_speed;
            richTextBox13.Text = living_room_program;

            richTextBox14.Text = bedroom2_temperature.ToString() + "°C";
            richTextBox15.Text = bedroom2_fan_speed;
            richTextBox16.Text = bedroom2_program;


            if (bedroom1_airCondition_isOn == true)
            {
                pictureBox1.ImageLocation = "pictures/air_condition_on.png";
                richTextBox8.BackColor = Color.PowderBlue;
                richTextBox9.BackColor = Color.PowderBlue;
                richTextBox10.BackColor = Color.PowderBlue;
            }
            else
            {
                pictureBox1.ImageLocation = "pictures/air_condition_off.png";
                richTextBox8.BackColor = Color.Firebrick;
                richTextBox9.BackColor = Color.Firebrick;
                richTextBox10.BackColor = Color.Firebrick;
            }

            if (living_room_airCondition_isOn == true)
            {
                pictureBox2.ImageLocation = "pictures/air_condition_on.png";
                richTextBox11.BackColor = Color.PowderBlue;
                richTextBox12.BackColor = Color.PowderBlue;
                richTextBox13.BackColor = Color.PowderBlue;
            }
            else
            {
                pictureBox2.ImageLocation = "pictures/air_condition_off.png";
                richTextBox11.BackColor = Color.Firebrick;
                richTextBox12.BackColor = Color.Firebrick;
                richTextBox13.BackColor = Color.Firebrick;
            }

            if (bedroom2_airCondition_isOn == true)
            {
                pictureBox3.ImageLocation = "pictures/air_condition_on.png";
                richTextBox14.BackColor = Color.PowderBlue;
                richTextBox15.BackColor = Color.PowderBlue;
                richTextBox16.BackColor = Color.PowderBlue;
            }
            else
            {
                pictureBox3.ImageLocation = "pictures/air_condition_off.png";
                richTextBox14.BackColor = Color.Firebrick;
                richTextBox15.BackColor = Color.Firebrick;
                richTextBox16.BackColor = Color.Firebrick;
            }
        }

        private void onlineHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu odada klima kurulu değildir. Başka bir tane seç", "Dikkat!");
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu odada klima kurulu değildir. Başka bir tane seç", "Dikkat!");
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu odada klima kurulu değildir. Başka bir tane seç", "Dikkat!");
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            richTextBox4.Visible = true;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            richTextBox4.Visible = false;
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            richTextBox5.Visible = true;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            richTextBox5.Visible = false;

        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            richTextBox6.Visible = true;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            richTextBox6.Visible = false;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            richTextBox7.Visible = true;
            richTextBox8.Visible = true;
            richTextBox9.Visible = true;
            richTextBox10.Visible = true;
            pictureBox1.Visible = true;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox7.Visible = false;
            richTextBox8.Visible = false;
            richTextBox9.Visible = false;
            richTextBox10.Visible = false;
            pictureBox1.Visible = false;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            richTextBox3.Visible = true;
            richTextBox11.Visible = true;
            richTextBox12.Visible = true;
            richTextBox13.Visible = true;
            pictureBox2.Visible = true;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            richTextBox3.Visible = false;
            richTextBox11.Visible = false;
            richTextBox12.Visible = false;
            richTextBox13.Visible = false;
            pictureBox2.Visible = false;
        }

        private void panel6_MouseHover(object sender, EventArgs e)
        {
            richTextBox2.Visible = true;
            richTextBox14.Visible = true;
            richTextBox15.Visible = true;
            richTextBox16.Visible = true;
            pictureBox3.Visible = true;
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            richTextBox2.Visible = false;
            richTextBox14.Visible = false;
            richTextBox15.Visible = false;
            richTextBox16.Visible = false;
            pictureBox3.Visible = false;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
            Home_AirCondition_Form form = new Home_AirCondition_Form(1);
            form.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Close();
            Home_AirCondition_Form form = new Home_AirCondition_Form(2);
            form.Show();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            this.Close();
            Home_AirCondition_Form form = new Home_AirCondition_Form(3);
            form.Show();
        }

        
    }
}
