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

namespace opgave_4._7
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

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            int totalNumberOfSeconds = 2549;
            int Minutes;
            int Seconds;
            Minutes = totalNumberOfSeconds / 60;
            Seconds = 2549 - (Minutes * 60);
            txtblResult.Text = "H:" + Convert.ToString(totalNumberOfSeconds / 3600) + "  M:" + Convert.ToString(Minutes) + "  S:" + Convert.ToString(Seconds);
        }
    }
}
