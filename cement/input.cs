using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cement
{
    public partial class input : Form
    {
        public input()
        {
            InitializeComponent();
            richTextBox1.ContextMenuStrip = contextMenuStrip1; //привязка контекстного меню в текстовому полю
        }


        private void input_Load(object sender, EventArgs e)
        {
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu s = new menu();
            s.Show();
            Hide();//переход в меню
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();//создание нового документа
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                catch (System.ArgumentException)
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                this.Text = openFileDialog1.FileName;//открытие документа из файлов
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                this.Text = saveFileDialog1.FileName;//сохранение в файлах
            }
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog p1 = new PrintDialog();
            PrintDocument p2 = new PrintDocument();
            p2.DocumentName = "Печать документа";
            p1.Document = p2;
            p1.AllowSelection = true;
            p1.AllowSomePages = true;
            if (p1.ShowDialog() == DialogResult.OK)
                p2.Print();//вывод на печать
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void изменитьШрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void изменитьЦветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void поЛевомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void поПравомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
        string buffer;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            buffer = richTextBox1.SelectedText;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + buffer;
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
