using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerHackingProject
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Network_IP_Hcking networkIp = new Network_IP_Hcking();
            networkIp.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Google_Chrome_History googleChromeHacking = new Google_Chrome_History();
            googleChromeHacking.Show();
        }

      /*  private void button3_Click(object sender, EventArgs e)
        {
            Firefox_Browser_Hacking firefoxHacking = new Firefox_Browser_Hacking();
            firefoxHacking.Show();

        }*/

        private void button4_Click(object sender, EventArgs e)
        {
            Internet_Explore_Hacking IEHacking = new Internet_Explore_Hacking();
            IEHacking.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Track_User_Action computerhacking = new Track_User_Action();
            computerhacking.Show();

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void HomePage_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
