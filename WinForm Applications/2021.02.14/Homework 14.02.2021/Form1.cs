using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Домашняя_работа_14._02._2021
{
    public partial class Form1 : Form
    {
        
        private bool choice = new bool();
        private string[] info_massive = new string[] { };
        public Form1()
        {
            InitializeComponent();
            
        }

        private void SurnameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            choice = true;
            Information();
            
            if (choice == true && Check(info_massive, true) == true)
            {
                SaveFileDialog file = new SaveFileDialog();
                file.Filter = "txt files (*.txt)|*.txt";
                file.FilterIndex = 2;
                file.RestoreDirectory = true;
                if (file.ShowDialog() == DialogResult.OK)
                {
                    TextWriter tw = new StreamWriter(file.OpenFile());
                    if (tw != null)
                    {
                        foreach (String item in Information())
                            tw.WriteLine(item);
                        tw.Close();
                    }
                }
            }
        }

        private bool ErrorMessage(bool a, string message, string labeltext) 
        {

            string caption = "Ошибка в заполнении поля "+labeltext;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            a = false;
            return a;
        }

        private string SomeChoice(string choice1, string choice2, CheckBox Box1, CheckBox Box2, string labelname)
        {
            
            if (Box1.Checked)
            {
                return choice1;
            }
            else if (Box2.Checked)
            {
                return choice2;
            }
            else if (Box1.Checked && Box2.Checked)
            {
                ErrorMessage(choice, "Выберите одно значение", labelname);
                return "";
            }
            else
            {
                ErrorMessage(choice, "Выберите одно значение", labelname);
                return "";
            }

        }
        private bool Check(string[] mass, bool a)
        {
            
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] == "")
                    a = false;
            }
            return a;
        }
        private List<String> Information()
        {   
            string name = NameBox.Text;
            string surname = SurnameBox.Text;
            string thirdname = ThirdNameBox.Text;
            string gender_choice = SomeChoice("мужчина", "женщина", GenderManCheck, WomanGenderCheck, label4.Text);
            DateTime dateboxtext = DateTimePicker.Value;
            string data = dateboxtext.ToString("D");
            string marital_choice = "";
            if (GenderManCheck.Checked == true && WomanGenderCheck.Checked == false)
                marital_choice = SomeChoice("женат", "холост", MaritalStatusYesCheck, MaritalStatusNoCheck, label6.Text);
            else if (WomanGenderCheck.Checked == true && GenderManCheck.Checked == false)
            {
                marital_choice = SomeChoice("замужем", "не замужем", MaritalStatusYesCheck, MaritalStatusNoCheck, label6.Text);
            }
            else
            {
                ErrorMessage(choice, "Выберите одно значение", "Для любого поля");
            }

            string another_information = AnotherInfoBox.Text;
            
            info_massive = new string[]
            {
                name, surname, thirdname, gender_choice, data, marital_choice, another_information
            };
            
            //Check(info_massive, true);
            List<string> Info = new List<string>(info_massive);

            return Info;
        }

        private void DataBox_MouseClick(object sender, MouseEventArgs e)
        {
            DataBox.Text = "";
        }
    }
}
