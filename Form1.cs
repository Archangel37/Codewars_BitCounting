using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codewars_BitCounting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Write a function that takes an (unsigned) integer as input, and returns the number of bits 
        //that are equal to one in the binary representation of that number.

        //Example: The binary representation of 1234 is 10011010010, so the function should return 5 in this case

//best solution:
//using System;
//using System.Linq;

//public class Kata
//{
//  public static int CountBits(int n)
//  {
//    return Convert.ToString(n, 2).Count(x => x == '1');
//  }
//}


        public int BitCount(int num)
        {
            
            string number_string = Convert.ToString(num, 2);
            int counter = 0;
            List<char> split = new List<char>();
            split = number_string.ToCharArray().ToList();
            foreach (char ch in split)
            {
                if (ch.Equals('1'))
                    counter++;
            }

            return counter;
        }


        private void button_calculate_Click(object sender, EventArgs e)
        {
            textBox_output.Text = BitCount(Convert.ToInt32(textBox_input.Text)).ToString();
        }
    }
}
