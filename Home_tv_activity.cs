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
    public partial class Home_tv_activity : Form
    {
        int volume;
        int channel;
        Random rand = new Random(Guid.NewGuid().GetHashCode());
        int on;

        public Home_tv_activity()
        {
            InitializeComponent();

        }

        private void Home_tv_activity_Load(object sender, EventArgs e)
        {

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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            volume = rand.Next(0, 100);
            channel = rand.Next(0, 10);
            button20.Text = "" + volume;
            button21.Text = "" + channel;

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button20.Visible = true;
            button21.Visible = true;
            button22.Visible = true;
            button23.Visible = true;
            button24.Visible = true;
            button25.Visible = true;
            button26.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            on = 0;
            volume = rand.Next(0, 100);
            channel = rand.Next(0, 10);
            button20.Text = "" + volume;
            button21.Text = "" + channel;

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button20.Visible = true;
            button21.Visible = true;
            button22.Visible = true;
            button23.Visible = true;
            button24.Visible = true;
            button25.Visible = true;
            button26.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            on = 0;
            volume = rand.Next(0, 100);
            channel = rand.Next(0, 10);
            button20.Text = "" + volume;
            button21.Text = "" + channel;



            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button20.Visible = true;
            button21.Visible = true;
            button22.Visible = true;
            button23.Visible = true;
            button24.Visible = true;
            button25.Visible = true;
            button26.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;



        }

        private void button19_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false; ;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


            button25.BackColor = Color.Green;
            pictureBox2.BackgroundImage = Properties.Resources.TVON;


        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (volume < 100)
            {
                volume = volume + 1;
                button20.Text = "" + volume;
            }

        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (volume > 0)
            {
                volume = volume - 1;
                button20.Text = "" + volume;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (channel < 100)
            {
                channel = channel + 1;
                button21.Text = "" + channel;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (channel > 0)
            {
                channel = channel - 1;
                button21.Text = "" + channel;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button21.Text = button13.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button21.Text = button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button21.Text = button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button21.Text = button10.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button21.Text = button14.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button21.Text = button15.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button21.Text = button16.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button21.Text = button12.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button21.Text = button11.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button21.Text = button7.Text;
        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            button25.BackColor = Color.Red;
            pictureBox2.BackgroundImage = Properties.Resources.TVOFF;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            richTextBox8.Visible = true;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {

            richTextBox8.Visible = false;

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }

        private void button19_MouseHover(object sender, EventArgs e)
        {
            richTextBox2.Visible = true;
        }

        private void button19_MouseLeave(object sender, EventArgs e)
        {
            richTextBox2.Visible = false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button23_MouseHover(object sender, EventArgs e)
        {
            richTextBox4.Visible = true;
        }

        private void button23_MouseLeave(object sender, EventArgs e)
        {
            richTextBox4.Visible = false;
        }

        private void button24_MouseHover(object sender, EventArgs e)
        {
            richTextBox4.Visible = true;
        }

        private void button24_MouseLeave(object sender, EventArgs e)
        {
            richTextBox4.Visible = false;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            richTextBox5.Visible = true;

        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            richTextBox5.Visible = false;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            richTextBox5.Visible = true;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            richTextBox5.Visible = false;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            richTextBox6.Visible = true;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            richTextBox6.Visible = false;
        }

        private void button26_MouseHover(object sender, EventArgs e)
        {
            richTextBox7.Visible = true;
        }

        private void button26_MouseLeave(object sender, EventArgs e)
        {
            richTextBox7.Visible = false;
        }

      

        private void Home_tv_activity_Load_1(object sender, EventArgs e)
        {

        }
    }
}
