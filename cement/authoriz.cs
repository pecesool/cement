using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cement
{
    public partial class authoriz : Form
    {
        public authoriz()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")//проверка на правильность пароля и логина
            {
                Data.login = textBox1.Text;//сохранение логина пользователя в глобальную переменную
                axWindowsMediaPlayer1.Ctlcontrols.play();//запуск музыки
                menu s = new menu();
                s.Show();
                Hide();//переход на другую форму
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";//объявление об ошибке ввода
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();//выход
        }

        private void auto_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();//остановка музыки
        }
    }
    static class Data
    {
        public static string login { get; set; }// объявление глобальной переменной

    }
}
