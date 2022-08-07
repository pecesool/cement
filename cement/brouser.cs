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
    public partial class brouser : Form
    {
        public brouser()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text); //искать в браузере
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();//назад
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();//перезагрузка браузера
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            menu s = new menu();
            s.Show();
            Hide();//переход в меню
        }

        private void brouser_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.ru");//объявление браузера на форме
        }
    }
}
