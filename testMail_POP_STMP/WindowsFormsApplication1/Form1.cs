using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net.Security;
using System.IO;
using System.Net.Mail;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendMail();
        }

        private void login()
        {
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect("pop.vng.com.vn", 995);
            SslStream netStream = new SslStream(tcpClient.GetStream());
            netStream.AuthenticateAsClient("pop.vng.com.vn");//dùng để sử dụng dịch vụ bảo mật của server;
            StreamReader rd = new StreamReader(netStream);
            StreamWriter wt = new StreamWriter(netStream);

            string ReadBuffer = "";// dùng để chứa thông điệp từ server
            byte[] WriteBuffer = new byte[2048];// dùng để chứa thông điệp gửi lên server
            ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            rd.ReadLine();//nhận thông điệp từ server

            //WriteBuffer = enc.GetBytes("USER " + "haivllinhtavn@gmail.com"+"\r\n");//txtUsername.Text+cbxDomains.Text
            //netStream.Write(WriteBuffer, 0, WriteBuffer.Length);// gửi thông điệp lên server;
            //netStream.Flush();
            wt.Write("USER linhta@vng.com.vn\r\n");
            wt.Flush();
            ReadBuffer = rd.ReadLine();
            if (!ReadBuffer.StartsWith("+OK"))// username hợp lệ
            {
                MessageBox.Show("Tài khoản không hợp lệ. Kiểm tra lại tên đăng nhập và mật khẩu !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            WriteBuffer = enc.GetBytes("PASS " + "Conga1!1" + "\r\n");
            netStream.Write(WriteBuffer, 0, WriteBuffer.Length);
            netStream.Flush();

            //wt.Write("PASS Haivl17!&\r\n");
            //wt.Flush();
            ReadBuffer = rd.ReadLine();
            if (!ReadBuffer.StartsWith("+OK"))// kiem tra mat khau
            {
                MessageBox.Show("Tài khoản không hợp lệ. Kiểm tra lại tên đăng nhập và mật khẩu !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            return;
        }

        private void sendMail()
        {
            String mailF = "anhlinhth@zing.vn";
            String mailTo = "hoandalat@zing.vn";
            SmtpClient client = new SmtpClient("smtp.zing.vn", 25);
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(mailF, "173663242");
            client.EnableSsl = true;
            client.SendCompleted += SendComplete;

            MailAddress from = new MailAddress(mailF);
            MailMessage mail = new MailMessage();
            mail.From = from;

            mail.To.Add(new MailAddress(mailTo));
            mail.Subject = "t";
            mail.Body = "tét";
            client.SendAsync(mail, "mail");
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

    }
}
