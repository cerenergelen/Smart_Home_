using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Timers;
using Smart_Home_;

namespace Smart_Home_
{
    public partial class Home_smart_feeder : Form
    {
        int food;
        int zimia;
        Random rand = new Random(Guid.NewGuid().GetHashCode());

        public Home_smart_feeder()
        {
            InitializeComponent();
            food = 100;
            //Timer timer1 = new Timer();
            //Timer timer2 = new Timer();
            //Timer timer3 = new Timer();


            timer1.Start();
            timer3.Start();
            timer2.Start();
            button9.Text = +food + "%";



        }




        private void Home_smart_feeder_Load(object sender, EventArgs e)
        {









        }










        private void activo_tick(object sender, EventArgs e)
        {
            zimia = rand.Next(1, 60);


            if (zimia == 20)
            {
                richTextBox1.Text = "Hayvan tüm yemeğini yedi ";

            }
            if (zimia == 14)
            {
                richTextBox1.Text = "Hayvan yemeğinin tamamını yemedi ";
            }
            if (zimia == 45)
            {
                richTextBox1.Text = "Hayvanın o bölgede evin içinde koşturduğu görüldü: Mutfak ";
            }
            if (zimia == 45)
            {
                richTextBox1.Text = "Hayvan, o bölgede evde koşarken görüntülendi: Salon ";
            }

        }

        private void foodchoose(object sender, EventArgs e)
        {
            button7.Visible = true;
            button6.Visible = true;
            button5.Visible = false;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            textBox2.Text = "Mama";
            button7.Visible = false;
            button6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            textBox2.Text = "Su";
            button7.Visible = false;
            button6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            food = 100;
            timer3.Start();
            richTextBox1.Text = "%100 seviyesinde ";

        }

        private void onlineHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer3.Stop();
            timer2.Stop();
            this.Close();
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Home_pet_activity home = new Home_pet_activity();
            home.Show();
        }




        private void timer3_Tick(object sender, EventArgs e)
        {


            if (food <= 50)
            {

                pictureBox1.BackgroundImage = Image.FromFile(@"white.jpg");
                pictureBox4.Visible = true;
                MessageBox.Show("Yiyecek seviyesi %50'de");
                richTextBox1.Text = "Yiyecek seviyesi %50'de";
            }
            if (food <= 25)
            {
                pictureBox4.BackgroundImage = Image.FromFile(@"white.jpg");
                pictureBox3.Visible = true;
                MessageBox.Show("Yiyecek seviyesi %25'de");
                richTextBox1.Text = "Yiyecek seviyesi %25'de";

            }
            if (food == 3)
            {
                MessageBox.Show("%0 beslemede besleme seviyesi girilir ve 'Besleyiciyi Doldur'a basın' ");
                richTextBox1.Text = "Yiyecek seviyesi %0'da";
                timer3.Stop();
            }

        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            richTextBox8.Visible = true;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            richTextBox8.Visible = false;
        }

        private void richTextBox1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            richTextBox3.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox3.Visible = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            richTextBox4.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            richTextBox4.Visible = false;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            richTextBox6.Visible = true;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            richTextBox6.Visible = false;

        }

       

        private void Home_smart_feeder_Load_1(object sender, EventArgs e)
        {

        }
    }
}
























