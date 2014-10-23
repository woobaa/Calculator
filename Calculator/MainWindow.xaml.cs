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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Console.WriteLine("Welcome to the C# Station Tutorial!");
        }

        private void clickOne(object sender, RoutedEventArgs e)
        {
            textBlock.Text = textBlock.Text + 1;
        }

        private void clickTwo(object sender, RoutedEventArgs e)
        {

        }

        private void clickThree(object sender, RoutedEventArgs e)
        {

        }

        private void clickFour(object sender, RoutedEventArgs e)
        {

        }

        private void clickFive(object sender, RoutedEventArgs e)
        {

        }

        private void clickSix(object sender, RoutedEventArgs e)
        {

        }

        private void clickSeven(object sender, RoutedEventArgs e)
        {

        }

        private void clickEight(object sender, RoutedEventArgs e)
        {

        }

        private void clickThree(object sender, RoutedEventArgs e)
        {

        }

        private void clickZero(object sender, RoutedEventArgs e)
        {

        }

        private void clickMultiply(object sender, RoutedEventArgs e)
        {

        }

        private void clickDivide(object sender, RoutedEventArgs e)
        {

        }

        private void clickPlus(object sender, RoutedEventArgs e)
        {

        }

        private void clickDivide(object sender, RoutedEventArgs e)
        {

        }

        private void clickClear(object sender, RoutedEventArgs e)
        {
            textBlock.Text = null;
        }
    }
}
