using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateClick(object sender, RoutedEventArgs e)
        {
            try
            {
                int k = int.Parse(KInput.Text);
                int sum = 0;
                int count = 0;
                List<int> numbers = new List<int>();

                Random random = new Random();

                while (sum <= k)
                {
                    int number = random.Next(55, 71); // Случайное число от 55 до 70
                    numbers.Add(number);
                    sum += number;
                    count++;
                }

                ResultText.Text = $"Сгенерированные числа: {string.Join(", ", numbers)}\n" +
                                  $"Сумма: {sum}\n" +
                                  $"Количество чисел: {count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Автор: Цыпленков Кирилл"+"\n"+"Группа ИСП-34" + "\n"+ "Задание:Вычислить сумму целых случайных чисел, распределенных в диапазоне от 55 до \n70, пока эта сумма не превышает некоторого числа K. Вывести на экран \nсгенерированные числа, значение суммы, и количество сгенерированных чисел.");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

