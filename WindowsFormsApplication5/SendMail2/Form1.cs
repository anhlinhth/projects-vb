using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net.Security;

namespace SendMail2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect("pop.gmail.com", 995);
            SslStream netStream = new SslStream(tcpClient.GetStream());
            netStream.AuthenticateAsClient("pop.gmail.com");//dùng để sử dụng dịch vụ bảo mật của server;
            StreamReader rd = new StreamReader(netStream);
            
            string ReadBuffer = "";// dùng để chứa thông điệp từ server
            byte[] WriteBuffer = new byte[1024];// dùng để chứa thông điệp gửi lên server
            ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            rd.ReadLine();//nhận thông điệp từ server
            WriteBuffer = enc.GetBytes("USER " + "anhlinhth@gmail.com" + "\r\n");
            netStream.Write(WriteBuffer, 0, WriteBuffer.Length);// gửi thông điệp lên server;
            netStream.Flush();
            ReadBuffer = rd.ReadLine();
            if (!ReadBuffer.StartsWith("+OK"))// username hợp lệ
                throw new Exception("Tên đăng nhập chưa chính xác.\nĐề nghị bạn nhập lại.");

            WriteBuffer = enc.GetBytes("PASS " + "Haivl17!&" + "\r\n");
            netStream.Write(WriteBuffer, 0, WriteBuffer.Length);
            netStream.Flush();
            ReadBuffer = rd.ReadLine();
            if (!ReadBuffer.StartsWith("+OK"))// kiem tra mat khau
                throw new Exception("Tên đăng nhập hoặc mật khẩu của bạn chưa chính xác.\nĐề nghị bạn nhập lại.");

           

        }
        
    }
}
