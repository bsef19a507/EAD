using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LengthConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

      
        private void covert_btn_Click(object sender, EventArgs e)
        {
            string user_input;
            user_input = input.Text;
            double length = Convert.ToDouble(user_input);

            Length_Inches length_inches = new Length_Inches();

            length_inches.setLength(length);

            double double_value = length_inches.convert();
            String temp_str = double_value.ToString();
            result.Text = temp_str;

        }
      
        private void feet_convert_btn_Click(object sender, EventArgs e)
        {
            string user_input;
            user_input = input.Text;
            double length = Convert.ToDouble(user_input);

            Length_Feet length_feet = new Length_Feet();

            length_feet.setLength(length);

            double double_value = length_feet.convert();
            String temp_str = double_value.ToString();
            result.Text = temp_str;

        }
    }
}
