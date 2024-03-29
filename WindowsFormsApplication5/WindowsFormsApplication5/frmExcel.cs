﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace WindowsFormsApplication5
{
    public partial class frmExcel : Form
    {
        public delegate void setTo(String mails);
        public setTo _setTo;

        public delegate void setCC(String mails);
        public setCC _setCC;

        public delegate void setBCC(String mails);
        public setBCC _setBCC;

        public frmExcel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel file|*.xlsx;*.xls";
            
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                richTextBox1.Text = "";
           
                textBox1.Text = openFileDialog1.FileName;
                getData(openFileDialog1.FileName);
            }
        }

        private void getData(String fileName)
        {
            FileInfo finfo;
            Microsoft.Office.Interop.Excel.ApplicationClass ExcelObj = new Microsoft.Office.Interop.Excel.ApplicationClass();
            ExcelObj.Visible = false;

            Microsoft.Office.Interop.Excel.Workbook theWorkbook ;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            finfo = new FileInfo(fileName);
            if (finfo.Extension == ".xls" || finfo.Extension == ".xlsx" || finfo.Extension == ".xlt" || finfo.Extension == ".xlsm" || finfo.Extension == ".csv")
            {
                theWorkbook = ExcelObj.Workbooks.Open(fileName, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, false, false);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)theWorkbook.Worksheets.get_Item(1);
               
                int row = 1;
                while (true)
                {
                    Microsoft.Office.Interop.Excel.Range rangr = worksheet.get_Range("A" + row.ToString(), "B"+row.ToString());
                    Object obj = rangr.Cells.Value;
                    System.Array myvalues = (System.Array)obj;
                    string[] strArray = ConvertToStringArray(myvalues);
                    if (strArray[0].Length == 0)
                        break;

                    richTextBox1.Text += strArray[0]+";" ;
                    row++;
                }
                theWorkbook.Close();
                ExcelObj.Quit();
            }

            
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

        private void button2_Click(object sender, EventArgs e)
        {
            if((cbTo.Checked == false && cbCC.Checked == false && cbBCC.Checked == false)||richTextBox1.Text == "" || richTextBox1.Text == null)
            {
                MessageBox.Show("Kiểm tra lại thông tin cài đặt !","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (cbTo.Checked == true)
                {
                    _setTo(richTextBox1.Text);
                }

                if (cbCC.Checked == true)
                {
                    _setCC(richTextBox1.Text);
                }

                if (cbBCC.Checked == true)
                {
                    _setBCC(richTextBox1.Text);
                }

                this.Close();
            }
        }
    }
}
