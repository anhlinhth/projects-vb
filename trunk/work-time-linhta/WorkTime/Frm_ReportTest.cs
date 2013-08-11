using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorkTime
{
    public partial class Frm_ReportTest : Form
    {
        public Frm_ReportTest()
        {
            InitializeComponent();
        }

        private void Frm_ReportTest_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
