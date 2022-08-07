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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оставитьОтзывToolStripMenuItem_Click(object sender, EventArgs e)
        {
            input s = new input();
            s.Show();
            Hide();//переход на окно отзывов
        }

        private void вебБраузерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brouser s = new brouser();
            s.Show();
            Hide();//переход на окно браузера
        }
        int shirina;
        int dlina;
        int kol;
        int komnat=0;//локальные переменные
        private void button1_Click(object sender, EventArgs e)
        {
            komnat = 0;
            try
            {
                shirina = Convert.ToInt32(textBox1.Text);
                dlina = Convert.ToInt32(textBox2.Text);

                kol = Convert.ToInt32(comboBox1.Text);//данные о комнате
                if(shirina<0 || dlina < 0 || kol < 0) { MessageBox.Show("Входные данные не могут быть отрицательными"); } else
                {
for (int i = 0; i < kol; i++)//цикл для расчета площади выбранных комнат
                { komnat = komnat + shirina * dlina; }
                richTextBox2.Text = "Итоговая площадь " + komnat.ToString() + " комнат = " + kol.ToString();//расчет площади
                groupBox3.Visible = true;
                }
                
            }
            catch
            {
                MessageBox.Show("вводить можно только числовые данные!");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;//модель для плитки
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;//модель для ламината
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int res=0;
            try
            {
                int a = Convert.ToInt32(textBox3.Text);
                if (a < 0) { MessageBox.Show("Входные не могут быть отрицательными!"); richTextBox3.Text = ""; }
                else
                {
                    if (checkBox1.Checked == true) { res = res + komnat * a; richTextBox3.Text = "Цена за материалы " + res.ToString() + "тг" + "\n"; }//расчет цены за материал
                    if (checkBox2.Checked == true) { res = res + 20000; richTextBox3.Text = richTextBox3.Text + "Цена за работу " + "20000тг" + "\n"; }//расчет цены за работу
                    richTextBox3.Text = richTextBox3.Text + "Итоговая цена " + res.ToString();//расчет итоговой цены
                }
                if (a == 0) { richTextBox3.Text = "Итоговая цена 0"; }
            }
            catch { MessageBox.Show("Входные данные не могут быть текстовым");richTextBox3.Text = ""; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int res = 0;
                int a = Convert.ToInt32(textBox4.Text);
                if (a < 0) { MessageBox.Show("Входные не могут быть отрицательными!"); richTextBox4.Text = ""; }
                else
                {
                    if (checkBox3.Checked == true) { res = res + komnat * a; richTextBox4.Text = "Цена за материалы " + res.ToString() + "тг" + "\n"; }//расчет цены за материал
                    if (checkBox4.Checked == true) { res = res + 10000; richTextBox4.Text = richTextBox4.Text + "Цена за работу " + "10000тг" + "\n"; }//расчет цены за работу
                    richTextBox4.Text = richTextBox4.Text + "Итоговая цена " + res.ToString();//расчет итоговой цены
                }
                if (a == 0) { richTextBox4.Text =  "Итоговая цена 0";  }
            }
            catch { MessageBox.Show("Входные данные не могут быть текстовым");richTextBox4.Text = ""; }
        }

        private void menu_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + Data.login;//вывод логина пользователя
        }
    }
}
