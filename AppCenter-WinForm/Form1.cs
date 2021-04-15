using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// AppCenter libs
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

// App Center Demo Windows Forms App
// atwork.at, Toni Pohl, April 2021
// https://docs.microsoft.com/en-us/appcenter/sdk/getting-started/wpf-winforms

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            AppCenter.Start("<your appcenter key>",
                   typeof(Analytics), typeof(Crashes));
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new System.Net.WebClient())
                {
                    string result = client.DownloadString(textBox1.Text.Trim());
                    textBox2.Text = result;
                    label2.Text = result.Length.ToString() + " Bytes";
                }
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
                label2.Text = ex.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
