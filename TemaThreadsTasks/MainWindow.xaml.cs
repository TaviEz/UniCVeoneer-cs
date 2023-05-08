using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace TemaThreadsTasks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Console.ReadLine();
        }


        private void normalExecute_Click(object sender, RoutedEventArgs e)
        {
            MainLabel.Content = "Start ";
            Thread.Sleep(5000);
            MainLabel.Content += "End ";
        }

        private async void asyncExecute_Click(object sender, RoutedEventArgs e)
        {
            SecondLabel.Content = "Start ";
            asyncExecute.IsEnabled = false;
            await Task.Delay(5000);
            SecondLabel.Content += "End";
            asyncExecute.IsEnabled = true;
        }
    }
}
