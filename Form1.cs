using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vremya = Convert.ToDouble(textBox1.Text);
            if (vremya >= 0 && vremya <= 24)
            {
                label1.Text = "Время суток: " + vremya + ":00";
            }
            else label1.Text = "Введите значение из заданного промежутка";
        }
    
    }
}
