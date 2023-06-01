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

namespace RandomButtons
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Background = 
                new SolidColorBrush(Color.FromRgb(Convert.ToByte(Random.Shared.Next(0, 255)), 
                Convert.ToByte(Random.Shared.Next(0, 255)), 
                Convert.ToByte(Random.Shared.Next(0, 255))));
        }

        

        private void MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button button = (Button)sender;
            Title = button.Content.ToString();
            MyGrid.Children.Remove(button);
        }
    }
}
