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
    public partial class Form1 : Form
    {
        int _pX_old = 0;
        int _pY_old = 0;
        bool _drag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_DragEnter(object sender, DragEventArgs e)
        {
            _pX_old = e.X;
            _pY_old = e.Y;
        }

        private void button2_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            _pX_old = e.X;
            _pY_old = e.Y;
            _drag = true;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            if(_drag)
            {
                this.Location = new Point(this.Location.X + e.X - _pX_old, this.Location.Y + e.Y - _pY_old);
            }
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            _drag = false;
        }
    }
}
