using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WinForm_hw_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button16_MouseClick(object sender, MouseEventArgs e)
        {
            Button currentButton = sender as Button;
            textBox1.Text += currentButton.Text;
            
        }
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length > 0) textBox1.Text = textBox1.Text.Remove(textBox1.Text.Trim().Length - 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable d = new DataTable();
                Regex r_text1 = new Regex("[a-zA-Zа-яА-Я!@#$%^&]*");
                Regex r_text2 = new Regex(",");
                string str = r_text1.Replace(textBox1.Text, "");
                str = r_text2.Replace(str, ".");
                textBox1.Text = d.Compute(str, "").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button18_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
