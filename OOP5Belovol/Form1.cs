using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP5Belovol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string var1 = textBoxVar1.Text;
            string var2 = textBoxVar2.Text;
            string var3 = textBoxVar3.Text;

            if (!char.IsDigit(var1[0]) || !char.IsDigit(var2[0]) || !char.IsDigit(var3[0]))
            {
                labelResult.Text = "Неможливо утворити число з символьних змінних.";
            }
            else
            {
                int number = int.Parse(var1 + var2 + var3);
                labelResult.Text = "Утворене число: " + number;
            }
        }
    }
}
