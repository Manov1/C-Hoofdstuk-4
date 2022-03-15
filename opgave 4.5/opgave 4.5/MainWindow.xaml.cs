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

namespace opgave_4._5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnCalculate.Click += BtnCalculate_Click;
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double inkomen;
            inkomen = Convert.ToInt32(txtbxInkomen.Text);
            txtblZonderBelasting.Text = "Inkomsten zonder belasting: " + Convert.ToString(inkomen);
            txtblMetBelasting.Text = "Inkomsten met belasting: " + Convert.ToString(inkomen - (inkomen * 0.20));
        }
    }
}
