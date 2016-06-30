using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InsertionSortTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            int i, j, temp;
            List<string> array=new List<string>();
            List<int> arrayInt = new List<int>();

            array.AddRange(textBox1.Text.Split(',').Select(txt => txt.Trim()).ToArray());
            arrayInt = array.Select(s => int.Parse(s)).ToList(); //Converting string array to int array

            for (i = 1; i < array.Count(); i++)
            {
                j = i;

                while (j > 0 && arrayInt[j - 1] > arrayInt[j])
                {
                    temp = arrayInt[j];
                    arrayInt[j] = arrayInt[j - 1];
                    arrayInt[j - 1] = temp;
                    j--;
                }

            }

            for (i = 0; i < array.Count(); i++)
            {                
                textBox2.Text += arrayInt[i] + " ";
            }
        }
    }
}
