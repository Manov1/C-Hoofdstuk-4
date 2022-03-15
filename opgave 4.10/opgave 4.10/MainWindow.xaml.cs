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

namespace opgave_4._10
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
            double E;
            double b;
            double n;
            double r;
            b = Convert.ToDouble(txtbxBeginsaldo.Text);
            n = Convert.ToDouble(txtbxJaren.Text);
            r = Convert.ToDouble(txtbxRente.Text);
            E = b * ((1 + r / 100) * n);
            txtblEindsaldo.Text = "eindsaldo: " + Convert.ToString(E);
        }
    }
}
