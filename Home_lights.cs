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
    public partial class Home_lights : Form
    {

        public static bool bedroom1_lightsOn = true;
        public static int bedroom1_trackbar_value = 10;
        public static bool living_room_lightsOn = true;
        public static int living_room_trackbar_value = 10;
        public static bool kitchen_lightsOn = true;
        public static int kitchen_trackbar_value = 10;
        public static bool toilet_lightsOn = true;
        public static int toilet_trackbar_value = 10;
        public static bool bathroom_lightsOn = true;
        public static int bathroom_trackbar_value = 10;
        public static bool bedroom2_lightsOn = true;
        public static int bedroom2_trackbar_value = 10;

        public Home_lights()
        {
            InitializeComponent();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            richTextBox2.Visible = true;
            pictureBox2.Visible = true;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox2.Visible = false;
            pictureBox2.Visible = false;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            richTextBox3.Visible = true;
            pictureBox3.Visible = true;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            richTextBox3.Visible = false;
            pictureBox3.Visible = false;
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            richTextBox4.Visible = true;
            pictureBox7.Visible = true;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            richTextBox4.Visible = false;
            pictureBox7.Visible = false;
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            richTextBox5.Visible = true;
            pictureBox6.Visible = true;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            richTextBox5.Visible = false;
            pictureBox6.Visible = false;
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            richTextBox6.Visible = true;
            pictureBox5.Visible = true;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            richTextBox6.Visible = false;
            pictureBox5.Visible = false;
        }

        private void panel6_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            pictureBox4.Visible = true;
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            pictureBox4.Visible = false;
        }

        private void Home_lights_Load(object sender, EventArgs e)
        {
            if (bedroom1_lightsOn == true)
            {
                pictureBox2.ImageLocation = "pictures/lightbulb_open.png";
            }
            else
            {
                pictureBox2.ImageLocation = "pictures/lightbulb_closed.png";
            }

            if (living_room_lightsOn == true)
            {
                pictureBox3.ImageLocation = "pictures/lightbulb_open.png";
            }
            else
            {
                pictureBox3.ImageLocation = "pictures/lightbulb_closed.png";
            }

            if (bedroom2_lightsOn == true)
            {
                pictureBox4.ImageLocation = "pictures/lightbulb_open.png";
            }
            else
            {
                pictureBox4.ImageLocation = "pictures/lightbulb_closed.png";
            }

            if (bathroom_lightsOn == true)
            {
                pictureBox5.ImageLocation = "pictures/lightbulb_open.png";
            }
            else
            {
                pictureBox5.ImageLocation = "pictures/lightbulb_closed.png";
            }

            if (toilet_lightsOn == true)
            {
                pictureBox6.ImageLocation = "pictures/lightbulb_open.png";
            }
            else
            {
                pictureBox6.ImageLocation = "pictures/lightbulb_closed.png";
            }

            if (kitchen_lightsOn == true)
            {
                pictureBox7.ImageLocation = "pictures/lightbulb_open.png";
            }
            else
            {
                pictureBox7.ImageLocation = "pictures/lightbulb_closed.png";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
            Home_lights_bedroom1 bedroom1 = new Home_lights_bedroom1();
            bedroom1.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Close();
            Home_lights_living_room living_room = new Home_lights_living_room();
            living_room.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.Close();
            Home_lights_kitchen kitchen = new Home_lights_kitchen();
            kitchen.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            this.Close();
            Home_lights_toilet toilet = new Home_lights_toilet();
            toilet.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            this.Close();
            Home_lights_bathroom bathroom = new Home_lights_bathroom();
            bathroom.Show();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            this.Close();
            Home_lights_bedroom2 bedroom2 = new Home_lights_bedroom2();
            bedroom2.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void onlineHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void exitApplicationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void onlineHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://we.tl/t-RRnMcJTG8u");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }
    }
}

