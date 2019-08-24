using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrlHistoryLibrary;
namespace ComputerHackingProject
{
    public partial class Internet_Explore_Hacking : Form
    {
        public Internet_Explore_Hacking()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UrlHistoryWrapperClass urlHistoryWrapper = new UrlHistoryWrapperClass();
            UrlHistoryWrapperClass.STATURLEnumerator enumerator
                                                    = urlHistoryWrapper.GetEnumerator();
            DataTable hackingtable = new DataTable();
            DataColumn DC1 = new DataColumn("Browsing URL");
            DataColumn DC2 = new DataColumn(" Browsing  Site Title");
            hackingtable.Columns.Add(DC1);
            hackingtable.Columns.Add(DC2);
            while(enumerator.MoveNext())
            {
                string url = enumerator.Current.URL;
                    string title = "";
                try
                {
                    title = string.IsNullOrEmpty(enumerator.Current.Title)
                        ? enumerator.Current.LastVisited.ToLongDateString() : "";

                }
                catch(Exception ex)
                {
                    
                }
                int val = url.IndexOf("www");
                int val1 = url.IndexOf("http");
                if(val>0 || val1>0)
                {
                    DataRow dr = hackingtable.NewRow();
                    dr[0] = url;
                    dr[1] = title;
                    hackingtable.Rows.Add(dr);

                }
            }

            dataGridView1.DataSource = hackingtable;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
