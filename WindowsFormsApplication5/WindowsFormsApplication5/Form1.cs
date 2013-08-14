using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public String _userMail = "";
        public String _userPass = "";
        public bool _logined = false;

        public String _variable = "%$Column";

        public String[] _listColumns;
        public List<String[]> _listData = new List<string[]>();

        public RichTextBox _textbox = new RichTextBox(); 
       

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
           if(_logined == false)
           {
               MessageBox.Show("Hãy đăng nhập trước khi gửi mail !","Chú ý",MessageBoxButtons.OK,MessageBoxIcon.Warning);
               return;
           }
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
            frmexcel._setTo = new frmExcel.setTo(setTo);
            frmexcel._setCC = new frmExcel.setCC(setCC);
            frmexcel._setBCC = new frmExcel.setBCC(setBCC);
            frmexcel.ShowDialog();
        }

        private void setTo(String val)
        {
            txtTo.Text = val;
        }

        private void setCC(String val)
        {
            txtCC.Text = val;
        }

        private void setBCC(String val)
        {
            txtBCC.Text = val;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel file|*.xlsx;*.xls";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //listView1.Clear();
                //listView1.Columns.Add("Mail");
                //listView1.Columns.Add("Contents");
                //listView1.Columns.Add("Contents2");

                //txtFile.Text = openFileDialog1.FileName;

                //List<String[]> list = getDataExcel(openFileDialog1.FileName);
                //foreach (String[] it in list)
                //{
                //    ListViewItem itemLV = new ListViewItem(it);
                //    //foreach (String i in it)
                //    //{
                //    //    itemLV.SubItems.Add(i);
                //    //}

                //    listView1.Items.Add(itemLV);
                //}

                txtFile.Text = openFileDialog1.FileName;

                setListData(openFileDialog1.FileName);
               
            }

            richTextBox2.Text = "";
        }

        private void setListData(String fileName)
        {
            listView1.Clear();
            _listData.Clear();

           _listData = getDataExcel(fileName);

           if (_listData != null)
            {
                for (int iCl = 0; iCl < _listColumns.Length; iCl++)
                {
                    listView1.Columns.Add(_listColumns[iCl]);
                }


                foreach (String[] it in _listData)
                {
                    ListViewItem itemLV = new ListViewItem(it);
                    //foreach (String i in it)
                    //{
                    //    itemLV.SubItems.Add(i);
                    //}

                    listView1.Items.Add(itemLV);
                }

                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }

        }

        private void getColumns(String fr, String to)
        {
           
            byte[] keyFr = Encoding.ASCII.GetBytes(fr);//.ToInt32(fr);
            byte[] keyTo = Encoding.ASCII.GetBytes(to); //Convert.ToInt32(to);

            int keycodeFr = Convert.ToInt32(keyFr[0]);
            int keycodeTo = Convert.ToInt32(keyTo[0]);

            int keycodeNow = 0;
            keycodeNow = keycodeFr;
             int count =0;
             _listColumns = new String[keycodeTo - keycodeFr +1];
            while(true)
            {
                if(keycodeNow> keycodeTo)
                    break;

                _listColumns[count] = char.ConvertFromUtf32(keycodeNow);//keyConverter.ConvertToString(keycodeNow);

                keycodeNow++;
                count++;
            }
          
        }

        private List<String[]> getDataExcel(String fileName)
        {
            List<String[]> data = new List<string[]>();

            String strFr = "A";
            String strTo = "B";
            if (txtColumnF.Text != "" && txtColumnF.Text != null)
                strFr = txtColumnF.Text;
            if (txtColumnT.Text != "" && txtColumnT.Text != null)
                strFr = txtColumnT.Text;

            if ((Convert.ToInt16(char.Parse(strTo)) - Convert.ToInt16(char.Parse(strFr)))<=0)
            {
                MessageBox.Show("Cột kết thúc phải đứng sau cột đứng đầu !","Chú ý",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtFile.Text = "";
                txtColumnT.Text = "";
                txtColumnF.Text = "";
                return null;
            }


            FileInfo finfo;
            Microsoft.Office.Interop.Excel.ApplicationClass ExcelObj = new Microsoft.Office.Interop.Excel.ApplicationClass();
            ExcelObj.Visible = false;

            Microsoft.Office.Interop.Excel.Workbook theWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            finfo = new FileInfo(fileName);
            if (finfo.Extension == ".xls" || finfo.Extension == ".xlsx" || finfo.Extension == ".xlt" || finfo.Extension == ".xlsm" || finfo.Extension == ".csv")
            {
                theWorkbook = ExcelObj.Workbooks.Open(fileName, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, false, false);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)theWorkbook.Worksheets.get_Item(1);

                
                getColumns(strFr, strTo);
                
                int row = 1;
                while (true)
                {
                    Microsoft.Office.Interop.Excel.Range rangr = worksheet.get_Range(strFr + row.ToString(), strTo + row.ToString());
                    Object obj = rangr.Cells.Value;
                    System.Array myvalues = (System.Array)obj;
                    string[] strArray = ConvertToStringArray(myvalues);
                    if (strArray[0].Length == 0)
                        break;

                    data.Add(strArray);
                    
                    row++;
                }
                theWorkbook.Close();
                ExcelObj.Quit();
            }

            return data;

        }

        string[] ConvertToStringArray(System.Array values)
        {

            // create a new string array
            string[] theArray = new string[values.Length];

            // loop through the 2-D System.Array and populate the 1-D String Array
            for (int i = 1; i <= values.Length; i++)
            {
                if (values.GetValue(1, i) == null)
                    theArray[i - 1] = "";
                else
                    theArray[i - 1] = (string)values.GetValue(1, i).ToString();
            }

            return theArray;
        }

        private void txtColumnF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) < 91 && Convert.ToInt16(e.KeyChar) > 64)
            {
                if (txtColumnF.TextLength > 0)
                    e.Handled = true;
                else
                    e.Handled = false;
            }
            else if( Convert.ToInt16(e.KeyChar) < 32 || Convert.ToInt16(e.KeyChar) == 127)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtColumnT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) < 91 && Convert.ToInt16(e.KeyChar) > 64)
            {
                if (txtColumnT.TextLength > 0)
                    e.Handled = true;
                else
                    e.Handled = false;
            }
            else if (Convert.ToInt16(e.KeyChar) < 32 || Convert.ToInt16(e.KeyChar) == 127)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_logined == false)
            {
                MessageBox.Show("Hãy đăng nhập trước khi gửi mail !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            foreach(String[] itemMail in _listData)
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(_userMail, _userPass);
                client.EnableSsl = true;
                client.SendCompleted += SendComplete;

                MailAddress from = new MailAddress(_userMail);
            

                MailMessage mail = new MailMessage();
                mail.From = from;
                mail.To.Add(new MailAddress(itemMail[0])); 
                mail.Subject = getContentMail(richTextBox3.Text,itemMail);
                mail.Body = getContentMail(richTextBox2.Text, itemMail);
                client.SendAsync(mail, "Fuck");
            }
           
        }

        private String getContentMail(String content, String[] data)
        {
            String cont = "";
            cont = richTextBox2.Text;

            int countCl = data.Length;
            for (int cl = 0; cl < countCl; cl++)
            {
                cont = cont.Replace("\""+_variable+_listColumns[cl]+"\"", data[cl]);
            }

            return cont;
        }

        private void txtColumnF_TextChanged(object sender, EventArgs e)
        {
            if (txtFile.Text != "" && txtFile.Text != null && txtFile.Text != null && txtFile.Text != "")
                setListData(txtFile.Text);
        }

        private void txtColumnT_TextChanged(object sender, EventArgs e)
        {
            if (txtFile.Text != "" && txtFile.Text != null && txtFile.Text != null && txtFile.Text!="")
                setListData(txtFile.Text);
        }

        private void txtVariable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) < 91 && Convert.ToInt16(e.KeyChar) > 64)
            {
                if (txtVariable.TextLength > 0)
                    e.Handled = true;
                else
                    e.Handled = false;
            }
            else if (Convert.ToInt16(e.KeyChar) < 32 || Convert.ToInt16(e.KeyChar) == 127)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void btnAddVariable_Click(object sender, EventArgs e)
        {
            if (txtVariable.Text =="" || txtVariable.Text==null )
            {
                return;
            }

            if(_listData == null)
            {
                MessageBox.Show("Nhập dữ liệu danh sách Excel trước !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String strFr = _listColumns[0];
            String strTo = _listColumns[_listColumns.Length - 1];
            if (Convert.ToInt16(char.Parse(strFr)) > Convert.ToInt16(char.Parse(txtVariable.Text)) || Convert.ToInt16(char.Parse(strTo)) < Convert.ToInt16(char.Parse(txtVariable.Text)))
            {
                MessageBox.Show("Cột này không có trong dữ liệu lấy được !","Chú ý",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            _textbox.Text += "\""+ _variable+ txtVariable.Text+"\"";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void richTextBox2_Click(object sender, EventArgs e)
        {
            _textbox = (RichTextBox)sender;
        }

        private void richTextBox3_Click(object sender, EventArgs e)
        {
            _textbox = (RichTextBox)sender;
        }

        

       
    }
}
