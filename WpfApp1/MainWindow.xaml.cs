﻿using System.Text;
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            mi_open.Background = Brushes.White;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            mi_open.Background = Brushes.Black;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            if (mi_open.Header == "")
            {
                mi_open.Header = "Прогу сделал я";
            }
            else
            {
                mi_open.Header = "";
            }
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
