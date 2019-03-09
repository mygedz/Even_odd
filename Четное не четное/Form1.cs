using System;
using System.Drawing;
using System.Windows.Forms;

namespace Четное_не_четное
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void verify_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.Visible = true;
                textBox1.BackColor = Color.LightCoral;
            }
            else
            {
                byte value = Convert.ToByte(textBox1.Text[textBox1.Text.Length - 1]);
                if (value % 2 == 0)
                {
                    MessageBox.Show("Четное");
                }
                else
                {
                    MessageBox.Show("Не четное");
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {            
            label1.Visible = false;
            textBox1.BackColor = Color.White;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}