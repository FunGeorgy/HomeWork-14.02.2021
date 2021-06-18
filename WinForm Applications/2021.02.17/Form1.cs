using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Домашняя_работа_17._02._2020
{
    public partial class Form1 : Form
    {
        private string caption = "";
        private string message1 = "Имя: Георгий Фамилия: Калмыков Отчество: Сергеевич";
        private string message2 = "Дата рождения: 13.08.1992 Образование: Высшее";
        private string message3 = "Опыт: Академия ШАГ";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons next_button = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show(message1, caption, next_button);
            if (result == DialogResult.OK)
            {
                result = MessageBox.Show(message2, caption, next_button);

                if (result == DialogResult.OK)
                {
                    result = MessageBox.Show(message3, caption, next_button);

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
            int[] mass = new int[2000];
            RandInt(mass, textBox1.Text, 1, 2000);
        }
        private void RandInt(int[] mass, string text, int first_item, int last_item) {

        /// <summary>
        ///  mass - заданный массив, text - тот текст, который мы приобразуем в число,
        ///  int first_item первое число диапозона,
        ///  int last_item последнее число диапозона
        /// </summary>
        
            MessageBoxButtons next_button = MessageBoxButtons.OK;
            DialogResult result;
            var random = new Random();
            int a;
            int count = 0;
            int number = 2001;
            if (Int32.TryParse(text, out a))
            {
                a = Convert.ToInt32(text);
                if (a > 2000)
                {
                    result = MessageBox.Show("Укажите число в заданном диапозоне", caption, next_button);
                    textBox1.Text = "";
                }
            }
            else
            {
                result = MessageBox.Show("Укажите число", caption, next_button);
                a = 2001;
                textBox1.Text = "";

            }
       
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random.Next(first_item, last_item);
                if (mass[i] == number && i > 0)
                {
                    i = 0;
                }
                else if (mass[i] != a)
                {
                    number = mass[i];
                    count++;
                }
                else if (mass[i] == a)
                {
                    string new_message = "Ваше число: " + text + " Количество попыток: " + count;
                    result = MessageBox.Show(new_message, caption, next_button);
                    i = mass.Length - 1;
                    textBox1.Text = "";
                }
            }
            button1.Update();
        }
    }

   
    
}
