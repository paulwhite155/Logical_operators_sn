using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logical_operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 a;
            Int32.TryParse(textBox1.Text, out a);
            Int32 b;
            Int32.TryParse(textBox2.Text, out b);

            if ( (a >20) && (b > 20))
            {
                MessageBox.Show("both are over 20");
            }
            else
            {
                MessageBox.Show("someone or both are not over 20"); 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 a;
            Int32 b;
            Int32.TryParse(textBox1.Text, out a);
                Int32.TryParse(textBox2.Text, out b);

            if ((a > 20 ) || (b > 20))
            {
                MessageBox.Show("one or both are over 20");
            }
            else
            {
                MessageBox.Show("no one is over 20");
            }
        }
    }
}
