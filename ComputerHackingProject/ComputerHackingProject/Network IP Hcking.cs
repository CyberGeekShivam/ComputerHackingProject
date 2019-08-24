using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
namespace ComputerHackingProject
{
    public partial class Network_IP_Hcking : Form
    {
        public Network_IP_Hcking()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                foreach(UnicastIPAddressInformation Getip in networkInterface.GetIPProperties().UnicastAddresses)
                {
                    listBox1.Items.Add(Getip.Address.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                foreach (UnicastIPAddressInformation Getip in networkInterface.GetIPProperties().UnicastAddresses)
                {
                    if (!Getip.IsDnsEligible)
                    {

                        if (Getip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {

                            listBox1.Items.Add(Getip.Address.ToString());
                        }

                    }
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
