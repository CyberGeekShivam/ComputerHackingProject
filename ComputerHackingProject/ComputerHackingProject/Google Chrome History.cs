using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WikitechyHackingLib;
namespace ComputerHackingProject
{
    public partial class Google_Chrome_History : Form
    {
        public Google_Chrome_History()
        {
            InitializeComponent();
        }
        WikitechyHackingLib.WikitechyHackingLib hackingLibrary = new WikitechyHackingLib.WikitechyHackingLib();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Google_Chrome_History_Load(object sender, EventArgs e)
        {
            DataSet dataSet = hackingLibrary.ChromeHackingConnection();
                if(dataSet !=null && dataSet.Tables.Count >0 && dataSet.Tables[0] != null)
            {
                DataTable dt = dataSet.Tables[0];
                DataTable hackingtable = new DataTable();
                DataColumn DC1 = new DataColumn("Browsing URL");
                DataColumn DC2 = new DataColumn("Browsing Site Title");
                DataColumn DC3 = new DataColumn("Browsing Site Count");
                DataColumn DC4 = new DataColumn("Browsing Site Timing");
              

                hackingtable.Columns.Add(DC1);
                hackingtable.Columns.Add(DC2);
                hackingtable.Columns.Add(DC3);
                hackingtable.Columns.Add(DC4);
                string URL = "";
                string visittiming = "";
                string title = "";
                string visit_count = "";
                foreach (DataRow chromehistory in dt.Rows)
                {
                    URL = Convert.ToString(chromehistory["url"]);
                    visittiming= Convert.ToString(chromehistory["last_visit_time"]);
                    long chromeMSData = Convert.ToInt64(visittiming);
                    DateTime dtWindows = DateTime.FromFileTimeUtc(10 * chromeMSData);
                    DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(dtWindows, TimeZoneInfo.Local);

                    title = Convert.ToString(chromehistory["title"]);
                    visit_count = Convert.ToString(chromehistory["visit_count"]);
                    DataRow dr = hackingtable.NewRow();
                    dr[0] = URL;
                    dr[1] = title;
                    dr[2] = visit_count;
                    dr[3] = localTime.ToString();
                    hackingtable.Rows.Add(dr);
                }
                dataGridView1.DataSource = hackingtable;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
