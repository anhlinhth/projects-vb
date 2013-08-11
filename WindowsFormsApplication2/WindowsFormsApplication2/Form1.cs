using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public bool chesse = false;
        public bool pepperoni = false;
        public bool bacon = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                pepperoni = false;
            }
            else
            {
                pepperoni = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                chesse = false;
            }
            else
            {
                chesse = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                bacon = false;
            }
            else
            {
                bacon = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pizza pizza = new Pizza.Builder(12).Addcheese(chesse).Addpepperoni(pepperoni).Addbacon(bacon).build();

            textBox2.Text ="buy a pizza : "+"cheese : " + pizza.getCheese() +" + pepperoni : "+ pizza.getPepperoni() +" + bacon :"+pizza.getBacon();
        }


    }

    public class Pizza
    {
        private int size;
        private bool cheese;
        private bool pepperoni;
        private bool bacon;

        public class Builder
        {
            //required
            private int size;

            //optional
            private bool cheese = false;
            private bool pepperoni = false;
            private bool bacon = false;

            public Builder(int size)
            {
                this.size = size;
            }

            public Builder Addcheese(bool value)
            {
                cheese = value;
                return this;
            }

            public Builder Addpepperoni(bool value)
            {
                pepperoni = value;
                return this;
            }

            public Builder Addbacon(bool value)
            {
                bacon = value;
                return this;
            }

            public Pizza build()
            {
                return new Pizza();
            }
        }

        public String getCheese()
        {
            return cheese.ToString();
        }

        public String getPepperoni()
        {
            return pepperoni.ToString();
        }

        public String getBacon()
        {
            return bacon.ToString();
        }
    }
}