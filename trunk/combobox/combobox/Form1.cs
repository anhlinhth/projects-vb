using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            make_DataTableCombobox();
            make_ColumnsCombobox();
        }

        private void make_DataTableCombobox()
        {
            DataTable dt = new DataTable("dataTable");
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            //add DataRow
            DataRow row = dt.NewRow();
            row["Id"] = 1;
            row["Name"] = "One";
            dt.Rows.Add(row);
            //assign to ComboBox
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void make_ColumnsCombobox()
        {
            GroupedComboBox groupedCombo = new GroupedComboBox();
            groupedCombo.ValueMember = "Value";
            groupedCombo.DisplayMember = "Display";
            groupedCombo.GroupMember = "Group";

            groupedCombo.DataSource = new ArrayList(new object[] 
            {
                new { Value=100, Display="Apples", Group="Fruit" },
                new { Value=101, Display="Pears", Group="Fruit" },
                new { Value=102, Display="Carrots", Group="Vegetables" },
                new { Value=103, Display="Beef", Group="Meat" },
                new { Value=104, Display="Cucumbers", Group="Vegetables" },
                new { Value=0, Display="(other)", Group=String.Empty },
                new { Value=105, Display="Chillies", Group="Vegetables" },
                new { Value=106, Display="Strawberries", Group="Fruit" }
            });

            DataTable dt = new DataTable();
            dt.Columns.Add("Value", typeof(int));
            dt.Columns.Add("Display");
            dt.Columns.Add("Group");

            dt.Rows.Add(100, "Apples", "Fruit");
            dt.Rows.Add(101, "Pears", "Fruit");
            dt.Rows.Add(102, "Carrots", "Vegetables");
            dt.Rows.Add(103, "Beef", "Meat");
            dt.Rows.Add(104, "Cucumbers", "Vegetables");
            dt.Rows.Add(DBNull.Value, "(other)", DBNull.Value);
            dt.Rows.Add(105, "Chillies", "Vegetables");
            dt.Rows.Add(106, "Strawberries", "Fruit");

            groupedCombo.DataSource = dt.DefaultView;

            //State 2:--------------------------
            //groupedCombo.ValueMember = null;
            //groupedCombo.DisplayMember = null;
            //groupedCombo.GroupMember = "Length";

            //string[] strings = new string[] { "Word", "Ace", "Book", "Dice", "Taste", "Two" };

            //groupedCombo.DataSource = strings;
            //end state 2 -------------------------

            groupedCombo.Location = new Point(20,20);
            this.Controls.Add(groupedCombo);
        }

        private void Form1_MinimumSizeChanged(object sender, EventArgs e)
        {
            MessageBox.Show("fu");
        }
    }
}
