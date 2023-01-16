using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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

        private void countPeople_Click(object sender, RoutedEventArgs e)//5 задание
        {
            double hour;
            double minut;
            double people = Convert.ToDouble(People.Text);
            if (people > 0 || people == 1)
            {
                hour = Math.Truncate(people * 10 / 60);
                minut = people * 10 % 60;
                if (hour < 5)
                {
                    answer1.Content = $"Вы должны отстоять в очереди {hour} часа и {minut} минут";
                    answer1.Foreground = Brushes.Black;
                }
                else if (hour > 4)
                {
                    answer1.Content = $"Вы должны отстоять в очереди {hour} часов и {minut} минут";
                    answer1.Foreground = Brushes.Black;
                }
                else if (hour == 0)
                {
                    answer1.Content = $"Вы должны отстоять в очереди {minut} минут";
                    answer1.Foreground = Brushes.Black;
                }

            }
            else 
            {
                answer1.Content = "Данные введены некоректно";
                answer1.Foreground = Brushes.Red;
            }
        }


        private void Info_Click(object sender, RoutedEventArgs e) //задание 6
        {
            string name = Convert.ToString(Name.Text);
            string age = Convert.ToString(Age.Text);
            string zodiac = Convert.ToString(Zodiac.Text);
            string work = Convert.ToString(Work.Text);
            Info.Content ="Вас зовут " + name + ", вам " + age + " лет, ваш знак задиака " + zodiac + " и вы работаете " + work + ".";
        }

        private void paint_Click(object sender, RoutedEventArgs e) //3 задание 
        {
            int photo = 52;
            int photoinrow = 3;
            full.Content = photo / photoinrow;
            over.Content = photo % photoinrow;
        }
    }
}
