﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_number_7_Model
{
    public partial class HelloMenuForm : Form
    {
        public HelloMenuForm()
        {
            InitializeComponent();
            

        }

        //кнопка Выполнение расчетов или запуск модели
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        //дата и время
        private void HelloMenuForm_Load(object sender, EventArgs e)
        {
            this.linkLabel1.Text = DateTime.Now.ToShortTimeString();
            this.linkLabel2.Text = DateTime.Now.ToShortDateString();
        }

        //вывод основной части реферата и заключения
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.LoadFile(@"C:\Users\sv\Desktop\yakproj-master\yakproj-master\Lab_number_7_Model\Lab_number_7_Model\HelloMenuFormButton2.rtf"/*, RichTextBoxStreamType.PlainText*/);
                button2.Visible = false;
                button5.Visible = true;
        }
            catch(System.IO.FileNotFoundException)
            {
                richTextBox1.Text = "Неправильно указан путь к файлу(Исправить в коде, пока только так)";
            }

        }

        //отчитстка richtextbox той же кнопкой
        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            button5.Visible = false;
            button2.Visible = true;

        }

        //кнопка о программе
        private void button3_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutbox = new AboutBox1();
            aboutbox.Show();
        }

        //кнопка Структурная схема и алгоритм
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.LoadFile(@"C:\Users\sv\Desktop\yakproj-master\yakproj-master\Lab_number_7_Model\Lab_number_7_Model\HelloMenuFormButtonСхемыИАлгоритм.rtf"/*, RichTextBoxStreamType.PlainText*/);
                button4.Visible = false;
                button6.Visible = true;
            }
            catch (System.IO.FileNotFoundException)
            {
                richTextBox1.Text = "Неправильно указан путь к файлу(Исправить в коде, пока только так)";
            }
        }

        //отчитстка richtextbox той же кнопкой
        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            button6.Visible = false;
            button4.Visible = true;
        }
    }
}
