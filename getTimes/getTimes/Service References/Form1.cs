using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using System.IO;

namespace getTimes
{
    public partial class Form1 : Form
    {
        public bool recordding = false;
        DateTime start = new DateTime();
        long time = 0;
        bool interval = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            
        }

       
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (recordding == true)
            {
                if (!insertTime())
                    e.Cancel = true;
            }
            
        }


        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == System.Windows.Forms.FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (recordding == false)
                return;
            
            if(!insertTime())
                return;
            recordding = false;
            timer1.Stop();
            timer2.Stop();
            lblhc.Visible = true;
            btnStart.Image = global::getTimes.Properties.Resources.Icons_Land_Play_Stop_Pause_Record_Hot;
            

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (recordding == false)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("where your file ?", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (textBox2.Text == "")
                {
                    MessageBox.Show("what are yoi doing ?","Warrning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                btnStart_recordding();
                recordding = true;
            }
          

        }


        private void btnStart_recordding()
        {
            start = DateTime.Now;

                timer2.Start();

                timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time + (long) 1;
            int h = 0;
            h = (int)time / 60;
            int m = 0;
            m = (int)time % 60;

            lblH.Text = h.ToString();
            lblM.Text = m.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (interval == true)
            {
                btnStart.Image = global::getTimes.Properties.Resources.Icons_Land_Play_Stop_Pause_Record_Hot;
                interval = false;
                lblhc.Visible = true;
            }
            else
            {
                btnStart.Image = global::getTimes.Properties.Resources.Icons_Land_Play_Stop_Pause_Record_Pressed;
                interval = true;
                lblhc.Visible = false;
            }
        }

        private bool insertTime()
        {

            if (insertToEx(start.ToLongDateString(), textBox2.Text, lblH.Text + lblhc.Text + lblM.Text))
            {
                time = 0;
                lblH.Text = "0";
                lblM.Text = "0";
                return true;
            }
            else return false;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnBrows_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            textBox1.Text = openFileDialog1.FileName;
        }

        private bool insertToEx(String start,String job, String time)
        {

            String fileTemp = Path.GetDirectoryName(Application.ExecutablePath)+@"\temp2.xls" ;
            String fileS = textBox1.Text;

            File.Delete(fileTemp);

            if (IsFileInUse(fileS))
            {
                MessageBox.Show("Close process using file excel !", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
          
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workBook = excel.Workbooks.Open(fileS);
            Microsoft.Office.Interop.Excel.Worksheet sheet = workBook.ActiveSheet;
            Microsoft.Office.Interop.Excel.Range range = sheet.UsedRange;

            Microsoft.Office.Interop.Excel.Range range2 = sheet.Cells[1, 1];

            int row = 0;
            if (range.Rows.Count == 1 && range2.Value == null)
                row = 1;
            else
                row = range.Rows.Count + 1;
           
            sheet.Cells[row, 1] = start;
            sheet.Cells[row, 2] = job;
            sheet.Cells[row, 3] = time;
            
            workBook.SaveAs(fileTemp, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
            false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); 
            workBook.Close(true);            
            excel.Quit();

            File.Delete(fileS);
            File.Move(fileTemp, fileS);
            File.Delete(fileTemp);

            return true;
        }

        public static bool IsFileInUse(string fileFullPath)
        {
            if (System.IO.File.Exists(fileFullPath))
            {
                try
                {
                    //if this does not throw exception then the file is not use by another program
                    using (FileStream fileStream = File.OpenWrite(fileFullPath))
                    {
                        if (fileStream == null)
                            return true;
                    }
                    return false;
                }
                catch
                {
                    return true;
                }
            }
            else 
                return false;
        }
       
    }
}
