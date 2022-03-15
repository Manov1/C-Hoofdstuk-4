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

namespace opgave_4._11
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
            int beginGetal;
            beginGetal = Convert.ToInt32(txtbxBegingetal.Text);
            if (beginGetal < 0 || beginGetal > 255)
            {
                txtblBinary.Text = "ERROR: nummer moet tussen 0 en 255 liggen";
            } else
            {
                txtblBinary.Text = "Binary: "+ Convert.ToString(beginGetal, 2);
            }
        }
    }
}
