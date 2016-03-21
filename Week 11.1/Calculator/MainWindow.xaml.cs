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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string operator1;
        private string operator2;
        private char operation;
        private string result;
        private int index = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            TextBoxIO.Text += "1";
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            TextBoxIO.Text += "2";
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            TextBoxIO.Text += "3";
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            TextBoxIO.Text += "4";
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            TextBoxIO.Text += "5";
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            TextBoxIO.Text += "6";
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            TextBoxIO.Text += "7";
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            TextBoxIO.Text += "8";
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            TextBoxIO.Text += "9";
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            TextBoxIO.Text += "0";
        }

        private void ButtonSum_Click(object sender, RoutedEventArgs e)
        {
            operator1 = (string)TextBoxIO.Text.Clone();
            TextBoxIO.Text += "+";
            operation = '+';
            TextBoxIO.Text = string.Empty;
        }

        private void ButtonSub_Click(object sender, RoutedEventArgs e)
        {
            operator1 = (string)TextBoxIO.Text.Clone();
            TextBoxIO.Text += "-";
            operation = '-';
            TextBoxIO.Text = string.Empty;
        }

        private void ButtonMulti_Click(object sender, RoutedEventArgs e)
        {
            operator1 = (string)TextBoxIO.Text.Clone();
            TextBoxIO.Text += "*";
            operation = '*';
            TextBoxIO.Text = string.Empty;
        }

        private void ButtonDev_Click(object sender, RoutedEventArgs e)
        {
            operator1 = (string)TextBoxIO.Text.Clone();
            TextBoxIO.Text += "/";
            operation = '/';
            TextBoxIO.Text = string.Empty;
        }

        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {
            operator2 = TextBoxIO.Text;
            double opr1, opr2;
            opr1 = double.Parse(operator1);
            opr2 = double.Parse(operator2);

            TextBoxIO.Text = string.Empty;
            switch (operation)
            {
                case '+':
                    result = (opr1 + opr2).ToString();
                    TextBoxIO.Text = result;
                    break;
                case '-':
                    result = (opr1-opr2).ToString();
                    TextBoxIO.Text = result;
                    break;
                case '*':
                    result = (opr1 * opr2).ToString();
                    TextBoxIO.Text = result;
                    break;
                case '/':
                    if (opr2 != 0)
                    {
                        result = (opr1 / opr2).ToString();
                        TextBoxIO.Text = result;
                    }
                    else
                    {
                        throw new CannotDevideByZero("You are not able to devide by zero!");
                    }
                    break;
            }
        }

        private void ButtonLn_Click(object sender, RoutedEventArgs e)
        {
            operator1 = (string)TextBoxIO.Text.Clone();
            double opr = double.Parse(operator1);
            TextBoxIO.Text = string.Empty;

            result = Math.Log(opr).ToString();
            TextBoxIO.Text = result;
        }

        private void ButtonLog_Click(object sender, RoutedEventArgs e)
        {
            operator1 = (string)TextBoxIO.Text.Clone();
            double opr = double.Parse(operator1);
            TextBoxIO.Text = string.Empty;

            result = Math.Log(opr, 2).ToString();
            TextBoxIO.Text = result;
        }

        private void ButtonSqrt_Click(object sender, RoutedEventArgs e)
        {
            operator1 = (string)TextBoxIO.Text.Clone();
            double opr = double.Parse(operator1);
            TextBoxIO.Text = string.Empty;

            result = Math.Sqrt(opr).ToString();
            TextBoxIO.Text = result;
        }

        private void ButtonStyle_Click(object sender, RoutedEventArgs e)
        {
            switch (index)
            {
                case 0:
                    Application.Current.Resources.Source= new Uri("BlueTheme.xaml", UriKind.Relative);
                    index++;
                    break;
                case 1:
                    Application.Current.Resources.Source = new Uri("WhiteTheme.xaml", UriKind.Relative);
                    index++;
                    break;
                case 2:
                    Application.Current.Resources.Source = new Uri("DarkTheme.xaml", UriKind.Relative);
                    index = 0;
                    break;
                default:
                    break;
            }
            
            
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            operator2 = string.Empty;
        }

        private void ButtonClearAll_Click(object sender, RoutedEventArgs e)
        {
            operator1 = string.Empty;
            operator2 = string.Empty;
            TextBoxIO.Text = string.Empty;
        }

        private void ButtonDot_Click(object sender, RoutedEventArgs e)
        {
            string textTillNow = (string)TextBoxIO.Text.Clone();
            TextBoxIO.Text = textTillNow + ",";
        }
    }

    class CannotDevideByZero : Exception
    {
        public CannotDevideByZero()
        {

        }
        public CannotDevideByZero(string massage):base(massage)
        {

        }
    }
}
