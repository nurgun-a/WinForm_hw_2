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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string Coord_mouse_ToSting(MouseEventArgs e) => $"Координаты мыши: х = {e.X},  y = {e.Y}";
        public string Coord_mouse_ToSting1(MouseEventArgs e) => $"Координаты мыши: х = {e.X + 10},  y = {e.Y + 10}";
        private void panel1_MouseMove(object sender, MouseEventArgs e) => Text = Coord_mouse_ToSting1(e);
        private void Form2_MouseMove(object sender, MouseEventArgs e) => Text = Coord_mouse_ToSting(e);

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && ModifierKeys == Keys.Control)
            {
                Close();
            }
            else if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Вы находитесь снаружи панели");

            }
            else if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Вы находитесь снаружи панели", $"Координаты: х = {e.X},  y = {e.Y}");
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && ModifierKeys == Keys.Control)
            {
                Close();
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (e.X > 0 && e.Y > 0 && e.X != 299 && e.Y != 299) MessageBox.Show($"Вы находитесь внутри панели");
                else if (e.X == 0 || e.Y == 0 || e.X == 299 || e.Y == 299)
                {
                    MessageBox.Show($"Вы находитесь на контуре панели панели");
                }
            }

            else if (e.Button == MouseButtons.Right)
            {

                if (e.X > 0 && e.Y > 0 && e.X != 146 && e.Y != 299) MessageBox.Show($"Вы находитесь внутри панели", $"х = { e.X + 10},  y = { e.Y + 10}");
                else if (e.X == 0 || e.Y == 0 || e.X == 299 || e.Y == 299)
                {
                    MessageBox.Show($"Вы находитесь на контуре панели панели\n", $"х = {e.X + 10},  y = {e.Y + 10}");
                }
            }
        }
    }
}
