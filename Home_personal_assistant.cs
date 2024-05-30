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
    public partial class Home_personal_assistant : Form
    {

        public static bool monday_has_plan = false;
        public static bool tuesday_has_plan = false;
        public static bool wednesday_has_plan = false;
        public static bool thursday_has_plan = false;
        public static bool friday_has_plan = false;
        public static bool saturday_has_plan = false; // değiştirmek için
        public static bool sunday_has_plan = false;

        public Home_personal_assistant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Home_assistant_day_choosing day = new Home_assistant_day_choosing();
            day.Show();
        }

        private void onlineHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form = new Form2();
            form.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Home_assistant_activities_showing activities = new Home_assistant_activities_showing();
            activities.Show();
        }

        private void Home_personal_assistant_Load(object sender, EventArgs e)
        {
            //
        }

        
    }
}