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
    public partial class PrintPreview : Form
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }

        private string total;
        public PrintPreview()
        {
            InitializeComponent();
        }

        public PrintPreview(System.Drawing.Printing.PrintDocument inp, string temp)
        {
            InitializeComponent();
            printPreviewControl1.Document = inp;
            total = temp;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new WebClient())
                {
                    
                    string temp = "This message is from TechnoKraft, This message is sent to notify you that your bike is serviced and ready to deliver. you bill amount is "+total.ToString()+" Rs";
                    var values = new NameValueCollection();
                    String message = HttpUtility.UrlEncode(temp);
                    using (var wb = new WebClient())
                    {
                        byte[] response = wb.UploadValues("http://api.textlocal.in/send/", new NameValueCollection()
                        {
                        {"username" , "muralikrishna6543@gmail.com"},
                        {"hash" , "6465095981aa3c0ef027314496be2863646d04d2"},
                        {"numbers" , "7411721178"},
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

        private void PrintPreview_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            for (int i = Convert.ToInt32(NumericupdownCopies.Value); i > 0;i--)
                printPreviewControl1.Document.Print();
        }
    }
}
