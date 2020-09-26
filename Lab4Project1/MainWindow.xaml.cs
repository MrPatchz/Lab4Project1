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

namespace Lab4Project1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double speedVal;
            double speedLimit;
            String isSpeed;

            speedVal = (double.Parse(Speed.Text));
            speedLimit = (double.Parse(SpeedLim.Text));
            if (speedVal <= speedLimit) {
                tooFast.Text = "You are within' the speed limit";
                TempCanvas.Background = Brushes.Green;
            }
            else if ((speedVal <= speedLimit + 7) && (speedVal >= speedLimit)) {
                tooFast.Text = "You are above the speed limit. But not by a lot so no fine given";
                TempCanvas.Background = Brushes.Yellow;
            }
            else {
                tooFast.Text = "You were going too fast. You have been fined.";
                TempCanvas.Background = Brushes.Red;
            }
        }

        private void Speeding1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
