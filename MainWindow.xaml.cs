using System;
using System.Windows;
using LibMas;
using Lib_12;

namespace Practical2
{
    public partial class MainWindow : Window
    {
        private int[] numbersArray;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerateAndCalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(NumberOfNumbersTextBox.Text, out int n))
            {
                numbersArray = ArrayUtils.FillArray(n);
                Result.Text = $"Сгенерированный массив: [{string.Join(", ", numbersArray)}]\n";
                int sum = Calculation.SumNumbersGreaterThanFifteen(numbersArray);
                Result.Text += $"Сумма чисел > 15: {sum}";
            }
            else
            {
                Result.Text = "Введите число.";
            }
        }

        private void AboutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("2 практическую работу выполнил студент группы ИСП-34 Букин Ярослав. \nЗадание: Ввести n целых чисел. Найти сумму чисел >15. Результат вывести на экран.");
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
