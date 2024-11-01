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

namespace Height_calculator
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if(Int32.TryParse(text1.Text, out int height) &&  height > 130 && height < 250)
            {
                    text1.Visibility = Visibility.Hidden;
                    textblock2.Visibility = Visibility.Hidden;
                    textblock1.Visibility = Visibility.Hidden;
                    textblock4.Visibility = Visibility.Visible;
                    textblock5.Visibility = Visibility.Visible;
                    textblock6.Visibility = Visibility.Visible;
                    button1.Visibility = Visibility.Hidden;
                    textblock5.Text = text1.Text + "cm";
                
            }
            else
            {
                text1.Visibility = Visibility.Hidden;
                textblock2.Visibility = Visibility.Hidden;
                textblock1.Visibility = Visibility.Hidden;
                textblock4.Text = "Введи нормальные данные, окурок";
                textblock4.Visibility = Visibility.Visible;
                button1.Visibility = Visibility.Hidden;
                
            }
        }
    }
}
