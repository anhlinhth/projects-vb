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
    public partial class Frm_Personnel : Form
    {
        public Frm_Personnel()
        {
            InitializeComponent();
        }

        private void Frm_Personnel_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnPersonnel_detail_outCancel_Click(object sender, EventArgs e)
        {
            lblOut.Visible = false;
            dtpOut.Visible = false;
            btnOutCancel.Visible = false;

            btnOut.Visible = true;
            
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            lblOut.Visible = true;
            dtpOut.Visible = true;
            btnOutCancel.Visible = true;

            btnOut.Visible = false;
        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            openFileDialog_IMG.ShowDialog();
        }
    }
}
