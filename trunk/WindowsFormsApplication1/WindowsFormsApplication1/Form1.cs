using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Mode mode = new AdditionMode();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GroupBox grRadiobutton = new GroupBox();
            grRadiobutton.Container.Add(radioButton1);
            grRadiobutton.Container.Add(radioButton2);
            grRadiobutton.Container.Add(radioButton3);
            grRadiobutton.Container.Add(radioButton4);

            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "+";
            mode = new AdditionMode();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "-";
            mode = new SubMode();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "*";
            mode = new MuliMode();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "/";
                mode = new VisMode();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;

        }

        private void button1_Click(object sender, EventArgs e)
        {
          textBox3.Text = ( mode.calculate(int.Parse(textBox1.Text),int.Parse(textBox2.Text))).ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

                
    }

    public interface Mode
    {
       int calculate(int a, int b);

    }

    public class AdditionMode : Mode 
    {
        public int calculate(int a, int b) 
        {
         return (a+b);
        }
    }

    public class SubMode : Mode
    {
        public int calculate(int a, int b)
        {
            return (a - b);
        }
    }

    public class MuliMode : Mode
    {
        public int calculate(int a, int b)
        {
            return (a * b);
        }
    }

    public class VisMode : Mode
    {
        public int calculate(int a, int b)
        {
            return (a / b);
        }
    }
}
