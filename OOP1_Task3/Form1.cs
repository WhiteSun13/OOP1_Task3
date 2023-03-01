using System;
using System.Text;
using System.Windows.Forms;

namespace OOP1_Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Нажатие кнопки "Конвертировать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            int i;//Значение из textBox            
            StringBuilder binary = new();//Изменяемая строка символов
            bool result = int.TryParse(intValue.Text, out var number);
            if (result == true)//Проверяем, введён ли int
            {
                if (number < 0) //Положительное ли число
                {
                    MessageBox.Show("Введите положительное число");
                    return;
                }
                else
                {
                    i = number; //Присваеваем i значение textBox                    
                    do //Выполняем цикл
                    {
                        int reminder = i % 2;//Сохраняем остаток
                        i /= 2;
                        binary.Insert(0, reminder); //Помещаем его в строку
                    } while (i > 0);
                    Result.Text = binary.ToString(); //Выводим результат
                }
            }
            else
            {
                MessageBox.Show("Введите число int");
                return;
            }
        }

    }
}
