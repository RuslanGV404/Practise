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

namespace SecondTask
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int Year; //задание 1
        int Day;
        double Price;
        double temperature;
        string personName;
        string cityName;
        bool Availability;
        bool Discount;
        char Uppercase;
        char firstLetter;


        int Crystal = 0; //задание 4

        private void Buy_Click(object sender, RoutedEventArgs e) 
        {
            double Gold = Convert.ToDouble(gold.Text);
            if (Gold > 56)
            {
                Gold -= 65;
                Crystal += 4;
                crystalQuantity.Content = $"Кол-во кристалов: {Crystal}";
                goldQuantity.Foreground = Brushes.Black;
                gold.Text = $"{Gold}";
            }
            else
            {
                goldQuantity.Foreground = Brushes.Red;
                goldQuantity.Content = "Недостаточно денег для покупки!";
            }
                
        }



        




        private void anwerP_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void countPeople_Click(object sender, RoutedEventArgs e)
        {
           
                double people = Convert.ToDouble(People.Text);
                try
                {
                    answer1.Content = $"Вы должны отстоять в очереди {people * 10 / 60} часа и {people * 10 % 60} минут";
                    answer1.Foreground = Brushes.Black;
                }
                catch
                {
                    answer1.Content = "Данные введены некоректно";
                    answer1.Foreground = Brushes.Red;
                }
            
        }

        private void count_Checked(object sender, RoutedEventArgs e)
        {
            double people = Convert.ToDouble(People.Text);
            try
            {
                answer1.Content = $"Вы должны отстоять в очереди {people * 10 / 60} часа и {people * 10 % 60} минут";
                answer1.Foreground = Brushes.Black;
            }
            catch
            {
                answer1.Content = "Данные введены некоректно";
                answer1.Foreground = Brushes.Red;
            }
        }

        private void mmmm_Click(object sender, RoutedEventArgs e)
        {
            double people = Convert.ToDouble(People.Text);
            try
            {
                answer1.Content = $"Вы должны отстоять в очереди {people * 10 / 60} часа и {people * 10 % 60} минут";
                answer1.Foreground = Brushes.Black;
            }
            catch
            {
                answer1.Content = "Данные введены некоректно";
                answer1.Foreground = Brushes.Red;
            }
        }
    }
}
