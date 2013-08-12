using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public String _userMail = "";
        public String _userPass = "";
        public bool _logined = false;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(_userMail , _userPass);
            client.EnableSsl = true;
            client.SendCompleted += SendComplete;

            MailAddress from = new MailAddress(_userMail);
             MailMessage mail = new MailMessage();
             mail.From = from;

             String[] listTo = getToEmail();
             String[] listCC = getCCEmail();
             String[] listBCC = getBCCEmail();

             if (listTo != null && listTo.Length>0)
                foreach ( String to in listTo)
                    if(to !="" && to.Length > 0)
                        mail.To.Add(new MailAddress(to));
             if (listCC != null && listCC.Length > 0) 
                 foreach (String cc in listCC)
                     if (cc != "" && cc.Length > 0)
                        mail.CC.Add(new MailAddress(cc));
             if (listBCC != null && listBCC.Length > 0) 
                 foreach (String bcc in listBCC)
                     if (bcc != "" && bcc.Length > 0) 
                         mail.Bcc.Add(new MailAddress(bcc));
            mail.Subject = txtSubject.Text;
            mail.Body = richTextBox1.Text;
            client.SendAsync(mail,"mail");
        }

        void SendComplete(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                //write your code here
            }
            if (e.Error != null)
            {
                //write your code here
            }
            else //mail sent
            {
                //write your code here
            }
        }

       
        private void loadForm()
        {
            
        }
        
        
        private void login_logout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.setinfologin = new frmLogin.setInfoLogin(setInfoLogin);
            frmLogin.Show();
        }

        public void setInfoLogin(String usemail, String userpass, bool login)
        {
            _userMail = usemail;
            _userPass = userpass;
            _logined = login;

            doLogin();
        }

        public void setUserMail(String usemail )
        {
            _userMail = usemail;            
        }

        public void setUserPass(String userpass)
        {
            _userPass = userpass;
        }

        public void setLogined(bool login)
        {
            _logined = login;
        }


        public String getUserMail()
        {
            return _userMail;
        }

        public String getUserPass()
        {
            return _userPass;
        }

        public bool getLogined()
        {
            return _logined;
        }

        private void logined(object sender, EventArgs e)
        {
            doLogin();
        }

        private void doLogin()
        {
            this.Text = this.Text + " : " + _userMail;

            ToolStripMenuItem item = new ToolStripMenuItem("Đăng xuất");
            item.Click += logouted;

            menuStrip1.Items.RemoveAt(0);
            menuStrip1.Items.Add(item);
        }

        private void logouted(object sender, EventArgs e)
        {
            _userMail = "";
            _userPass = "";
            _logined = false;

            this.Text ="[LinhTA]Gửi mail";

            ToolStripMenuItem item = new ToolStripMenuItem("Đăng nhập");
            item.Click += logined;

            menuStrip1.Items.RemoveAt(0);
            menuStrip1.Items.Add(item);
        }

        private String[] getToEmail()
        {
           // String[] list = new String[500];

            String to = txtTo.Text;
            String[] list = to.Split(';');
            
            return list;
        }

        private String[] getCCEmail()
        {
            // String[] list = new String[500];

            String cc = txtCC.Text;
            String[] list = cc.Split(';');

            return list;
        }

        private String[] getBCCEmail()
        {
            // String[] list = new String[500];

            String bcc = txtBCC.Text;
            String[] list = bcc.Split(';');

            return list;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            frmExcel frmexcel = new frmExcel();
            frmexcel.ShowDialog();
        }
    }
}
