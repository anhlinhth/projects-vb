using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            String a = richTextBox1.Text.Trim();
            a = a.Replace("\n", " ");
            a = a.Replace("\"","");

            searchSeat(a);

            return;
        }

        private void searchSeat(String a)
        {
            String[] arr = a.Split(',');
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == null || arr[i] == "")
                    continue;
                String[] row = arr[i].Split(' ');
                try
                {
                    writeToEx(row[0], row[1]);
                }
                catch(Exception e)
                {}
            }
        }

        private void writeToEx(String seat, String name)
        {
            String fileTemp = Path.GetDirectoryName(Application.ExecutablePath) + @"\temp3.xls";
            String fileS = Path.GetDirectoryName(Application.ExecutablePath) + @"\temp4.xls";

            File.Delete(fileTemp);

           

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

            sheet.Cells[row, 1] = seat;
            sheet.Cells[row, 2] = name;

            workBook.SaveAs(fileTemp, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
            false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            workBook.Close(true);
            excel.Quit();

            File.Delete(fileS);
            File.Move(fileTemp, fileS);
            File.Delete(fileTemp);

        }
    }
}
