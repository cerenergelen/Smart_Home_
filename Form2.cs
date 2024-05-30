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
            public partial class Form2 : Form
        {
            public static int time;
            public static string day;
            List<String> assistantAvatar = new List<string>();
            public static int chosenAvatar = Form1.currentAvatar;

            public Form2()
            {
                InitializeComponent();
            }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            // Kullanıcı üstteki etiketin üzerine geldiğinde
            richTextBox1.Visible = true;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            // Kullanıcı üstteki etiketin dışına çıktığında
            richTextBox1.Visible = false;
        }

      
       

        private void button1_MouseHover(object sender, EventArgs e)
        {
            // Kullanıcı ışık düğmesinin üzerine geldiğinde
            richTextBox2.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            // Kullanıcı ışıklar düğmesinin dışına çıktığında
            richTextBox2.Visible = false;
        }


        private void button3_MouseHover(object sender, EventArgs e)
        {
            // Kullanıcı klima düğmesinin üzerine geldiğinde
            richTextBox4.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            // Kullanıcı klima düğmesinin dışına çıktığında
            richTextBox4.Visible = false;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            // Kullanıcı televizyon düğmesinin üzerine geldiğinde
            richTextBox5.Visible = true;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            // Kullanıcı televizyon düğmesinin dışına çıktığında
            richTextBox5.Visible = false;
        }





        private void button7_MouseHover(object sender, EventArgs e)
        {
            // Kullanıcı akıllı besleyici düğmesinin üzerine geldiğinde
            richTextBox7.Visible = true;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            // Kullanıcı akıllı besleyici düğmesinin dışına çıktığında
            richTextBox7.Visible = false;
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            // Kullanıcı bilgi simgesinin üzerine geldiğinde
            richTextBox8.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            // Kullanıcı bilgi simgesinin dışına çıktığında
            richTextBox8.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            assistantAvatar.Add("pictures/cute.png");
            assistantAvatar.Add("pictures/walter_white.png");
            assistantAvatar.Add("pictures/woman3.png");
            assistantAvatar.Add("pictures/homer2_assistant.png");
            assistantAvatar.Add("pictures/man2_assistant.png");

            label2.Text = time.ToString();
            label6.Text = day;
            pictureBox2.ImageLocation = assistantAvatar[chosenAvatar];

            // Bu formu her açtığımda yüklenen resim
            // 

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello world");
        }



        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Home_AirCondition_choose air_condition = new Home_AirCondition_choose();
            air_condition.Show();

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Home_lights lights = new Home_lights();
            lights.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Home_personal_assistant personal_assistant = new Home_personal_assistant();
            personal_assistant.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Home_smart_feeder h = new Home_smart_feeder();


            h.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Home_tv_activity personal_assistant = new Home_tv_activity();
            personal_assistant.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = Form1.time;
            day = Form2.day;
            label2.Text = time.ToString();
            label6.Text = day;
        }


        private void button6_MouseHover(object sender, EventArgs e)
        {
            richTextBox9.Visible = true;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            richTextBox9.Visible = false;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }


    }

}
