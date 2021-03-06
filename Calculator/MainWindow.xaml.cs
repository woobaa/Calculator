﻿using System;
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
        bool multiply, divide, minus, plus;
        int currentValue = -1;
        int newText = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void clickNumber(object sender, RoutedEventArgs e)
        {
            if (currentValue == -1)
                currentValue = 0;

            Button curButton = sender as Button;
            
            newText = Int32.Parse(curButton.Content as string);

            int tempValue = (multiply ? (currentValue * newText) :
                        (divide ? (currentValue / newText) :
                        (plus ? (currentValue + newText) :
                        (minus ? (currentValue - newText) : newText))));

            multiply = divide = minus = plus = false;

            textBlock.Text = tempValue.ToString();

            currentValue = Int32.Parse(textBlock.Text);
        }

        private void clickMultiply(object sender, RoutedEventArgs e)
        {
            multiply = true;
            divide = minus = plus = false;
        }

        private void clickDivide(object sender, RoutedEventArgs e)
        {
            divide = true;
            multiply = minus = plus = false;
        }

        private void clickPlus(object sender, RoutedEventArgs e)
        {
            plus = true;
            multiply = divide = minus = false;
        }

        private void clickMinus(object sender, RoutedEventArgs e)
        {
            minus = true;
            multiply = divide = plus = false;
        }

        private void clickClear(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "0";
            currentValue = -1;
            newText = 0;
        }
    }
}
