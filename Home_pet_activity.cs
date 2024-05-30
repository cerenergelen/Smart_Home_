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
    public partial class Home_pet_activity : Form
    {
        int zimia;
        Random rand = new Random(Guid.NewGuid().GetHashCode());
        public Home_pet_activity()
        {
            InitializeComponent();
            zimia = rand.Next(1, 7);
            if (zimia == 2)
            {
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                richTextBox1.Text = "Evcil Hayvanın Bulunduğu Yer: Mutfak";
            }
            if (zimia == 3)
            {
                button1.Visible = false;
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                richTextBox1.Text = "Evcil Hayvanın Bulunduğu Yer: Salon";
            }
            if (zimia == 4)
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = true;
                button4.Visible = false;
                button5.Visible = false;
                richTextBox1.Text = "Evcil Hayvanın Bulunduğu Yer: Banyo";
            }
            if (zimia == 5)
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = true;
                button5.Visible = false;
                richTextBox1.Text = "Evcil Hayvanın Bulunduğu Yer: yatakodası1";
            }
            if (zimia == 6)
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = true;
                richTextBox1.Text = "Evcil Hayvanın Bulunduğu Yer: yatakodası2";
            }
            else
            {
                button1.Visible = false;
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                richTextBox1.Text = "Evcil Hayvanın Bulunduğu Yer: Salon";
            }
        }

        private void Home_pet_activity_Load(object sender, EventArgs e)
        {

        }

        private void onlineHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Home_smart_feeder form2 = new Home_smart_feeder();
            form2.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
            Home_smart_feeder form2 = new Home_smart_feeder();
            form2.Show();
        }

       

        private void richTextBox1_TextChanged(object sender, EventArgs e)
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
    }
}
