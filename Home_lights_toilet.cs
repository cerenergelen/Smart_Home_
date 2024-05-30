using System;
using System.Windows.Forms;

namespace Smart_Home_
{
    public partial class Home_lights_toilet : Form
    {
        public static bool lightsOn;

        public Home_lights_toilet()
        {
            InitializeComponent();

            // Olay işleyicilerin bağlanması
            pictureBox1.Click += pictureBox1_Click;
            pictureBox2.Click += pictureBox2_Click;
            this.Load += Home_lights_toilet_Load;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lightsOn = !lightsOn; // Durumu değiştir
            GuncelleIsikDurumu();
        }

        private void Home_lights_toilet_Load(object sender, EventArgs e)
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

        private void GuncelleIsikDurumu()
        {
            if (lightsOn)
            {
                this.BackgroundImage = Properties.Resources.toilet_lights_on;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.toilet_lights_off;
            }
            this.Invalidate(); // Formun yeniden çizilmesini sağlar
        }
    }
}

