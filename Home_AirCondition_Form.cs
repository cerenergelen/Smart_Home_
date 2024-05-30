using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Smart_Home_
{
    public partial class Home_AirCondition_Form : Form
    {
        public static int temperature = 20;
        public static int room_code;
        public static bool airConditionOn;

        public Home_AirCondition_Form(int code)
        {
            room_code = code;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (room_code == 1)
            {

                if (airConditionOn == true)
                {
                    button1.BackColor = Color.Red;
                    button1.Text = "OFF";
                    airConditionOn = false;
                }
                else
                {
                    button1.BackColor = Color.Lime;
                    button1.Text = "ON";
                    airConditionOn = true;
                }
            }
            if (room_code == 2)
            {

                if (airConditionOn == true)
                {
                    button1.BackColor = Color.Red;
                    button1.Text = "OFF";
                    airConditionOn = false;
                }
                else
                {
                    button1.BackColor = Color.Lime;
                    button1.Text = "ON";
                    airConditionOn = true;
                }
            }
            if (room_code == 3)
            {

                if (airConditionOn == true)
                {
                    button1.BackColor = Color.Red;
                    button1.Text = "OFF";
                    airConditionOn = false;
                }
                else
                {
                    button1.BackColor = Color.Lime;
                    button1.Text = "ON";
                    airConditionOn = true;
                }
            }
        }

        private void Eva_AirCondition_Form_Load(object sender, EventArgs e)
        {
            label5.Text = temperature.ToString() + "°C";

            // If the user clicks on bedroom1
            if (room_code == 1)
            {
                temperature = Home_AirCondition_choose.bedroom1_temperature;
                airConditionOn = Home_AirCondition_choose.bedroom1_airCondition_isOn;

                if (airConditionOn == true)
                {
                    button1.BackColor = Color.Lime;
                    button1.Text = "ON";
                }
                else
                {
                    button1.BackColor = Color.Red;
                    button1.Text = "OFF";
                }

                if (Home_AirCondition_choose.bedroom1_program == "Soğuk")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }

                if (Home_AirCondition_choose.bedroom1_fan_speed == "Düşük hız")
                {
                    radioButton3.Checked = true;
                }
                else if (Home_AirCondition_choose.bedroom1_fan_speed == "Ortalama hız")
                {
                    radioButton4.Checked = true;
                }
                else if (Home_AirCondition_choose.bedroom1_fan_speed == "Υüksek hız")
                {
                    radioButton5.Checked = true;
                }
            }

            // If the user clicks on living room
            if (room_code == 2)
            {
                temperature = Home_AirCondition_choose.living_room_temperature;
                airConditionOn = Home_AirCondition_choose.living_room_airCondition_isOn;

                if (airConditionOn == true)
                {
                    button1.BackColor = Color.Lime;
                    button1.Text = "ON";
                }
                else
                {
                    button1.BackColor = Color.Red;
                    button1.Text = "OFF";
                }

                if (Home_AirCondition_choose.living_room_program == "Soğuk")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }

                if (Home_AirCondition_choose.living_room_fan_speed == "Düşük hız")
                {
                    radioButton3.Checked = true;
                }
                else if (Home_AirCondition_choose.living_room_fan_speed == "Ortalama hız")
                {
                    radioButton4.Checked = true;
                }
                else if (Home_AirCondition_choose.living_room_fan_speed == "Υüksek hız")
                {
                    radioButton5.Checked = true;
                }
            }

            // If the user clicks on bedroom2
            if (room_code == 3)
            {
                temperature = Home_AirCondition_choose.bedroom2_temperature;
                airConditionOn = Home_AirCondition_choose.bedroom2_airCondition_isOn;

                if (airConditionOn == true)
                {
                    button1.BackColor = Color.Lime;
                    button1.Text = "ON";
                }
                else
                {
                    button1.BackColor = Color.Red;
                    button1.Text = "OFF";
                }

                if (Home_AirCondition_choose.bedroom2_program == "Soğuk")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }

                if (Home_AirCondition_choose.bedroom2_fan_speed == "Düşük hız")
                {
                    radioButton3.Checked = true;
                }
                else if (Home_AirCondition_choose.bedroom2_fan_speed == "Ortalama hız")
                {
                    radioButton4.Checked = true;
                }
                else if (Home_AirCondition_choose.bedroom2_fan_speed == "Υüksek hız")
                {
                    radioButton5.Checked = true;
                }
            }
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            // For when the user hovers over the information icon
            richTextBox8.Visible = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            // For when the user hovers out of the information icon
            richTextBox8.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (temperature < 35)
            {
                temperature++;
                label5.Text = temperature.ToString() + "°C";
            }
            else
            {
                MessageBox.Show("35°C'nin üzerine çıkamazsınız", "⚠️ Error!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (temperature > 18)
            {
                temperature--;
                label5.Text = temperature.ToString() + "°C";
            }
            else
            {
                MessageBox.Show("18°C'nin altına inemezsiniz", "⚠️ Error!");
            }

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void onlineHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Home_AirCondition_choose ch = new  Home_AirCondition_choose();
            ch.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Değişiklikler başarıyla yapıldı!");


            if (room_code == 1)
            {
                Home_AirCondition_choose.bedroom1_airCondition_isOn = airConditionOn;
                // Setting the room program
                if (radioButton1.Checked == true)
                {
                    Home_AirCondition_choose.bedroom1_program = "Soğuk";
                }
                else if (radioButton2.Checked == true)
                {
                    Home_AirCondition_choose.bedroom1_program = "Sıcak";
                }

                // Setting the room fan speed for air condition
                if (radioButton3.Checked == true)
                {
                    Home_AirCondition_choose.bedroom1_fan_speed = "Düşük hız";
                }
                else if (radioButton4.Checked == true)
                {
                    Home_AirCondition_choose.bedroom1_fan_speed = "Ortalama hız";
                }
                else if (radioButton5.Checked == true)
                {
                    Home_AirCondition_choose.bedroom1_fan_speed = "Υüksek hız";
                }

                // Setting the room's temperature
                Home_AirCondition_choose.bedroom1_temperature = temperature;

            }
            if (room_code == 2)
            {
                MessageBox.Show("airConditionOn = " + airConditionOn.ToString());
                Home_AirCondition_choose.living_room_airCondition_isOn = airConditionOn;
                // Setting the room program
                if (radioButton1.Checked == true)
                {
                    Home_AirCondition_choose.living_room_program = "Soğuk";
                }
                else if (radioButton2.Checked == true)
                {
                    Home_AirCondition_choose.living_room_program = "Sıcak";
                }

                // Setting the room fan speed for air condition
                if (radioButton3.Checked == true)
                {
                    Home_AirCondition_choose.living_room_fan_speed = "Düşük hız";
                }
                else if (radioButton4.Checked == true)
                {
                    Home_AirCondition_choose.living_room_fan_speed = "Ortalama hız";
                }
                else if (radioButton5.Checked == true)
                {
                    Home_AirCondition_choose.living_room_fan_speed = "Υüksek hız";
                }

                // Setting the room's temperature
                Home_AirCondition_choose.living_room_temperature = temperature;

            }
            if (room_code == 3)
            {
                MessageBox.Show("airConditionOn = " + airConditionOn.ToString());
                Home_AirCondition_choose.bedroom2_airCondition_isOn = airConditionOn;
                // Setting the room program
                if (radioButton1.Checked == true)
                {
                    Home_AirCondition_choose.bedroom2_program = "Soğuk";
                }
                else if (radioButton2.Checked == true)
                {
                    Home_AirCondition_choose.bedroom2_program = "Sıcak";
                }

                // Setting the room fan speed for air condition
                if (radioButton3.Checked == true)
                {
                    Home_AirCondition_choose.bedroom2_fan_speed = "Düşük hız";
                }
                else if (radioButton4.Checked == true)
                {
                    Home_AirCondition_choose.bedroom2_fan_speed = "Ortalama hız";
                }
                else if (radioButton5.Checked == true)
                {
                    Home_AirCondition_choose.bedroom2_fan_speed = "Υüksek hız";
                }

                // Setting the room's temperature
                Home_AirCondition_choose.bedroom2_temperature = temperature;
            }
            this.Close();
            Home_AirCondition_choose form = new Home_AirCondition_choose();
            form.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}
