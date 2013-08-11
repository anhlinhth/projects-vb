using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Suzuki Mehran")
            {
                Director car = new Director();
                IBuilder build = new SuzukiMehran();
                car.ConstructCar(build);
            }

            if (textBox1.Text == "Suzuki Khyber")
            {
                Director car = new Director();
                IBuilder build = new SuzukiKhyber();
                car.ConstructCar(build);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Suzuki Mehran";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Suzuki Khyber";
        }

       
 
        
    }

      public interface IBuilder
      {           
            void ManufactureCar();
      }

      public class SuzukiMehran : IBuilder
      {
          public void ManufactureCar()
          {
              MessageBox.Show("Suzuki Mehran Model 2002 "
                             + "Color Balck "
                             + "Air Conditioned ");
          }
      }

      public class SuzukiKhyber : IBuilder
      {
          public SuzukiKhyber()
          {
          }

          public void ManufactureCar()
          {
              MessageBox.Show("Suzuki Khyber Model 2002 Standard "
                     + "Color Red "
                     + "Air Conditioned "
                     + "Alloy Rim ");
          }
      }

     public class Director
      {
            public void ConstructCar(IBuilder build)
            {
                  build.ManufactureCar(); 
            }
      
    }
}
