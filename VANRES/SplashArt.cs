using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VANRES
{
    public partial class SplashArt : Form
    {
        public SplashArt()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Height += 30;
            if (panel2.Height >= 451)
            {
                timer1.Stop();
                HomeReservation lForm = new HomeReservation();
                lForm.Show();
                this.Hide();
            }
        }
    }
}
