using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using System.Web;

namespace billing
{
    public partial class ScheduleSms : Form
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }

        public ScheduleSms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new WebClient())
                {
                    var values = new NameValueCollection();
                    String message = HttpUtility.UrlEncode(richTextBox1.Text);
                    using (var wb = new WebClient())
                    {
                        byte[] response = wb.UploadValues("http://api.textlocal.in/send/", new NameValueCollection()
                        {
                        {"username" , "naseer036@gmail.com"},
                        {"hash" , "30d4019a197f1e8f318c7b39f886312e54c8fb6b"},
                        {"numbers" , TextBoxCusNumb.Text},
                        {"message" , message},
                        {"sender" , "TXTLCL"}
                        });
                        string result = System.Text.Encoding.UTF8.GetString(response);
                        MessageBox.Show(result);
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectCustomer SelectCustomerObj = new SelectCustomer();
            SelectCustomerObj.ShowDialog();
        }

        private void ScheduleSms_Load(object sender, EventArgs e)
        {

        }
    }
}
