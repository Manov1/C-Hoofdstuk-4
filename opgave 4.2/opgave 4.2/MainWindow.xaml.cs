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

namespace opgave_4._2
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
            double radius;
            double circumference;
            double area;
            double volume;
            radius = Convert.ToInt32(txtbxAmount.Text);
            circumference = 2 * Math.PI * radius;
            area = Math.PI * Math.Pow(radius, 2);
            volume = (4 * Math.PI / 3) * Math.Pow(radius, 3);
            txtblOmtrek.Text = Convert.ToString(circumference);
            txtblOppervlakte.Text = Convert.ToString(area);
            txtblVolume.Text = Convert.ToString(volume);
        }
    }
}
