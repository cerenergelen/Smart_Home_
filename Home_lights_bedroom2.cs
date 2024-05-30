using System;
using System.Windows.Forms;

namespace Smart_Home_
{
    public partial class Home_lights_bedroom2 : Form
    {
        public static bool lightsOn;

        public Home_lights_bedroom2()
        {
            InitializeComponent();
            // Olay işleyicilerinin bağlandığından emin olun
            pictureBox1.Click += new EventHandler(pictureBox1_Click);
            pictureBox2.Click += new EventHandler(pictureBox2_Click);
            this.Load += new EventHandler(Home_lights_bedroom2_Load);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Home_lights lights = new Home_lights();
            lights.Show();
        }

        private void Home_lights_bedroom2_Load(object sender, EventArgs e)
        {
            lightsOn = true;
            GuncelleIsikDurumu();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lightsOn = !lightsOn; // Durumu değiştir
            GuncelleIsikDurumu();
        }

        private void GuncelleIsikDurumu()
        {
            if (lightsOn)
            {
                this.BackgroundImage = Smart_Home_.Properties.Resources.bedroom2_lights_on;
            }
            else
            {
                this.BackgroundImage = Smart_Home_.Properties.Resources.bedroom2_lights_off;
            }
        }
    }
}
