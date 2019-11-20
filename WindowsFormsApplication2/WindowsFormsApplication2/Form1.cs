using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.A)
            {
                MessageBox.Show("You Pressed A");
            }
            if (e.KeyValue == (char)Keys.B)
            {
                MessageBox.Show("You Pressed B");
            }
            if (e.KeyValue == (char)Keys.C)
            {
                MessageBox.Show("You Pressed C");
            }
            if (e.KeyValue == (char)Keys.D)
            {
                MessageBox.Show("You Pressed D");
            }
            else
            {
                MessageBox.Show("I dont know");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
