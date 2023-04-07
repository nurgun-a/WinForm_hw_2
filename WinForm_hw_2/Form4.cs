using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_hw_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            stop_button.Enabled = false;
            start_button.Enabled = false;
            timer1.Tick += new EventHandler(Show_timer1);
        }
        private void Show_timer1(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0) numericUpDown1.Value--;
            else if (numericUpDown1.Value < 1)
            {
                timer1.Stop();
                MessageBox.Show("Таймер остановлен", "Таймер", MessageBoxButtons.OK);
                stop_button.Enabled = false;
            }

        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                stop_button.Enabled = true;
                start_button.Enabled = false;
                timer1.Start();
            }
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DialogResult res = MessageBox.Show($"Остаток времени: {numericUpDown1.Value} сек.\nВозобновить?", "Таймер", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                stop_button.Enabled = false;
                start_button.Enabled = true;
            }
            else if (res == DialogResult.No)
            {
                numericUpDown1.Value = 0;
                stop_button.Enabled = false;
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numericUpDown1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                start_button.Enabled = true;
            }
        }
    }
}
