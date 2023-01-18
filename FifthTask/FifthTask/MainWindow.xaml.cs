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

namespace FifthTask
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

         public double Add()
         {
            double x = Convert.ToDouble(numberOne.Text);
            double y = Convert.ToDouble(numberTwo.Text);
            return x + y;   
         }

        public double Sub()
        {
            double x = Convert.ToDouble(numberOne.Text);
            double y = Convert.ToDouble(numberTwo.Text);
            return x - y;
        }

        public double Mul()
        {
            double x = Convert.ToDouble(numberOne.Text);
            double y = Convert.ToDouble(numberTwo.Text);
            return x * y;
        }

        public string Div()
        {
            double x = Convert.ToDouble(numberOne.Text);
            double y = Convert.ToDouble(numberTwo.Text);
            if (y != 0)
                return $"{x / y}";
            else
                return "На ноль не делтся";
        }

        private void count_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Method = Convert.ToString(method.Text);
                switch (Method)
                {
                    case "Div":
                        answer1.Content = Div();
                        break;
                    case "Sub":
                        answer1.Content = Sub();
                        break;
                    case "Mul":
                        answer1.Content = Mul();
                        break;
                    case "Add":
                        answer1.Content = Add();
                        break;
                }
            }
            catch
            {
                answer1.Content = "Error";
            }
        }

        private void countMoney_Click(object sender, RoutedEventArgs e)
        {
            double Money = Convert.ToDouble(money.Text);
            double Conversion = Convert.ToDouble(conversion.Text);
            answer2.Content = Money * Conversion;
        }

        private void check_Click(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(number1.Text);
            if (x != 0)
                answer3.Content = "Число положительное,";
            else
                answer3.Content = "Число отрицательное,";

            bool prost = true;
            int n = Convert.ToInt32(number1.Text);
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    prost = false;
                    break;
                }
            }
            if (prost)
            {
                answer3.Content += " число простое.";
            }
            else
            {
                answer3.Content += " число не простое.";
            }
        }

        int x = 0;
        int i = 0;
        private void pay_Click(object sender, RoutedEventArgs e)
        {
            int y = Convert.ToInt32(payment.Text);
            x += y;
            if (i <= 7)
            {
                if (x < 1000)
                {
                    Info.Content = $"Сумма задолженности {1000 - x}";
                    i++;
                }
                else if (x == 1000)
                {
                    i++;
                    Info.Content = "Долг погашен";
                }
                else if (x > 1000)
                {
                    i++;
                    Info.Content = $"Долг погашен, переплата {x - 1000}";
                }
            }
            else
                Info.Content = "Вы не успели погасить долг";
        }

        private void customersCount_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(customers.Text);
            int i = 1;
            int sum = 1;
        LB1: if (i <= n)
            {
                sum *= i;
                i++;
                goto LB1;
            }
            else
                answer4.Content = sum;
        }
    }
}
