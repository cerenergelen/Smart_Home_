using System;
using System.Windows.Forms;

namespace Smart_Home_
{
    public partial class Home_lights_bathroom : Form
    {
        public static bool lightsOn;

        public Home_lights_bathroom()
        {
            InitializeComponent();
            // Olay işleyicilerin bağlanması
            this.Load += new EventHandler(Home_lights_bathroom_Load);
            pictureBox1.Click += new EventHandler(pictureBox1_Click);
            pictureBox2.Click += new EventHandler(pictureBox2_Click);
        }

        private void Home_lights_bathroom_Load(object sender, EventArgs e)
        {
            lightsOn = true;
            GuncelleIsikDurumu();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Home_lights lights = new Home_lights();
            lights.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lightsOn = !lightsOn; // Durumu tersine çevir
            GuncelleIsikDurumu();
        }

        private void GuncelleIsikDurumu()
        {
            if (lightsOn)
            {
                this.BackgroundImage = Smart_Home_.Properties.Resources.bathroom_lights_on;
            }
            else
            {
                this.BackgroundImage = Smart_Home_.Properties.Resources.bathroom_lights_off;
            }
        }
    }
}
