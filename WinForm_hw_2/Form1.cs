using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace WinForm_hw_2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text="Наведите курсор мыши к заданию для получения информации\n";
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "info";
        }

        private void button_panel_Click(object sender,EventArgs  e)
        {
             Form2 Form2 = new Form2();
             Form2.ShowDialog();
        }

        private void button_panel_MouseEnter(object sender, EventArgs e)
        {
            string str = @" ■ Обработчик нажатия левой кнопки мыши, который выводит сообщение о том, 
где находится текущая точка: 
внутри прямоугольника, снаружи, на границе прямоугольника.
Если при нажатии левой кнопки мыши была нажата кнопка Control(Ctrl), 
то приложение должно закрываться;
■ Обработчик нажатия правой кнопки мыши, который выводит 
в заголовок окна информацию о размере клиентской области окна в виде: 
Ширина = x, Высота = y, где x и y – соответствующие параметры вашего окна; 
■ Обработчик перемещения указателя мыши в пределах рабочей области, 
который должен выводить в заголовок окна текущие координаты мыши x и y.
";            
            label1.Text = str;
        }

        private void button_panel_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "info";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.ShowDialog();
        }

        private void button_calc_MouseEnter(object sender, EventArgs e)
        {
            string str = @" «Калькулятор» - создание новых действий 
(бинарных и унарных операций) и метод Clear для очищения окон.
- по желанию добавить методы на проверку ввода данных.
";
            label1.Text = str;
        }

        private void button_calc_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "info";
        }

        private void button_timer_MouseEnter(object sender, EventArgs e)
        {
            string str = @" Таймер – для работы, выполненной на уроке, 
добавить отображение обратного/прямого счета таймера. 
И вывести остаток времени при нажатии на кнопку  STOP.
";
            label1.Text = str;
        }

        private void button_timer_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "info";
        }

        private void button_timer_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.ShowDialog();
        }
    }
}
