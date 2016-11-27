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
                        {"username" , "muralikrishna6543@gmail.com"},
                        {"hash" , "6465095981aa3c0ef027314496be2863646d04d2"},
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
