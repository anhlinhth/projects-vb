using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Security;
using System.Net.Sockets;
using System.IO;

namespace WindowsFormsApplication5
{
    public partial class frmLogin : Form
    {

        public delegate void setInfoLogin(String mail, String pass, bool login);
        public setInfoLogin setinfologin;
     

        public frmLogin()
        {
            InitializeComponent();
        }

       

        private void frmLogin_Load(object sender, EventArgs e)
        {
            loadForm();
           
        }

        private void loadForm()
        {
            cbxDomains.SelectedIndex = 0;
        }

       
        private bool checkAccount()
        {
            if (txtPass.TextLength < 6 || txtUsername.TextLength < 6)
            {
                MessageBox.Show("Tài khoản nhập sai chính tả !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtPass.Text) || String.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Tài khoản nhập sai chính tả !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private bool checkPrivaticy()
        {
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect("pop.gmail.com", 995);
            SslStream netStream = new SslStream(tcpClient.GetStream());
            netStream.AuthenticateAsClient("pop.gmail.com");//dùng để sử dụng dịch vụ bảo mật của server;
            StreamReader rd = new StreamReader(netStream);
            StreamWriter wt = new StreamWriter(netStream);

            string ReadBuffer = "";// dùng để chứa thông điệp từ server
            byte[] WriteBuffer = new byte[2048];// dùng để chứa thông điệp gửi lên server
            ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            rd.ReadLine();//nhận thông điệp từ server

            //WriteBuffer = enc.GetBytes("USER " + "haivllinhtavn@gmail.com"+"\r\n");//txtUsername.Text+cbxDomains.Text
            //netStream.Write(WriteBuffer, 0, WriteBuffer.Length);// gửi thông điệp lên server;
            //netStream.Flush();
            wt.Write("USER " + txtUsername.Text + cbxDomains.Text + "\r\n");
            wt.Flush();
            ReadBuffer = rd.ReadLine();
            if (!ReadBuffer.StartsWith("+OK"))// username hợp lệ
            {
                MessageBox.Show("Tài khoản không hợp lệ. Kiểm tra lại tên đăng nhập và mật khẩu !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            //WriteBuffer = enc.GetBytes("PASS " + txtPass.Text + "\r\n");
            //netStream.Write(WriteBuffer, 0, WriteBuffer.Length);
            //netStream.Flush();
            wt.Write("PASS " + txtPass.Text + "\r\n");
            wt.Flush();
            ReadBuffer = rd.ReadLine();
            if (!ReadBuffer.StartsWith("+OK"))// kiem tra mat khau
            {
                MessageBox.Show("Tài khoản không hợp lệ. Kiểm tra lại tên đăng nhập và mật khẩu !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (checkSpecialCharacter(Convert.ToInt16(e.KeyChar)))
                e.Handled = true;
        }


        private bool checkSpecialCharacter(int key)
        {
            if (key == 46)
                return false;
            if (key == 8)
                return false;
            if (key == 95)
                return false;
            if (key == 127)
                return false;

            if (key < 48)
                return true;
            if (key > 57 && key < 65)
                return true;
            if (key > 90 && key < 97)
                return true;
            if (key > 122 && key != 127)
                return true;

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkAccount() && checkPrivaticy())
            {
                setinfologin(txtUsername.Text + cbxDomains.Text,txtPass.Text,true);
                MessageBox.Show("Đăng nhập thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
               
            }
        }

        public void setUserEMail(String usemail)
        {
            //_userMail = usemail;
        }

        //public void setUserPass(String userpass)
        //{
        //    _userPass = userpass;
        //}

        //public void setLogined(bool login)
        //{
        //    _logined = login;
        //}

        

    }
}
