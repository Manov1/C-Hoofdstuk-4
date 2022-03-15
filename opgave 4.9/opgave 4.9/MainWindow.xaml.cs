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

namespace opgave_4._9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double Ctotaal;
        uint Euro2;
        uint Euro1;
        uint Cent50;
        uint Cent20;
        uint Cent10;
        uint Cent5;
        uint Cent2;
        uint Cent1;
        public MainWindow()
        {
            InitializeComponent();
            
            btnC200.Click += BtnC_Click;
            btnC100.Click += BtnC_Click;
            btnC50.Click += BtnC_Click;
            btnC20.Click += BtnC_Click;
            btnC10.Click += BtnC_Click;
            btnC5.Click += BtnC_Click;
            btnC2.Click += BtnC_Click;
            btnC1.Click += BtnC_Click;
            btnSw.Click += Change;
            btnZZ.Click += Change;
            btnGd.Click += Change;
            btnAl.Click += Change;
            btnCc.Click += Change;
        }
        private void Change(object sender, RoutedEventArgs e)
        {
            if (sender == btnSw)
            {
                Ctotaal = Ctotaal - 150;
                txtblTotal.Text = Convert.ToString(Ctotaal / 100);
                txtblRecieved.Text = "Received: Super water";
                txtblEffect.Text = "-it's just water";

            }
            else if (sender == btnZZ)
            {
                Ctotaal = Ctotaal - 180;
                txtblTotal.Text = Convert.ToString(Ctotaal / 100);
                txtblRecieved.Text = "Received: ZZ drink";
                txtblEffect.Text = "-starting to feel sleepy";
            }
            else if (sender == btnGd)
            {
                Ctotaal = Ctotaal - 120;
                txtblTotal.Text = Convert.ToString(Ctotaal / 100);
                txtblRecieved.Text = "Received: Ghost drink";
                txtblEffect.Text = "-it's just an empty bottle";
            }
            else if (sender == btnAl)
            {
                Ctotaal = Ctotaal - 75;
                txtblTotal.Text = Convert.ToString(Ctotaal / 100);
                txtblRecieved.Text = "Received: A Lemon";
                txtblEffect.Text = "-it's a whole lemon, why is it here?";
            }
            else if (sender == btnCc)
            {
                Ctotaal = Ctotaal - 195;
                txtblTotal.Text = Convert.ToString(Ctotaal / 100);
                txtblRecieved.Text = "Received: Caca colo";
                txtblEffect.Text = "-it's cola, but blue and probably poisonous";
            }
            Euro2 = Convert.ToUInt32(Ctotaal) / 200;
            Ctotaal = Ctotaal - (Euro2 * 200);
            Euro1 = Convert.ToUInt32(Ctotaal) / 100;
            Ctotaal = Ctotaal - (Euro1 * 100);
            Cent50 = Convert.ToUInt32(Ctotaal) / 50;
            Ctotaal = Ctotaal - (Cent50 * 50);
            Cent20 = Convert.ToUInt32(Ctotaal) / 20;
            Ctotaal = Ctotaal - (Cent20 * 20);
            Cent10 = Convert.ToUInt32(Ctotaal) / 10;
            Ctotaal = Ctotaal - (Cent10 * 10);
            Cent5 = Convert.ToUInt32(Ctotaal) / 5;
            Ctotaal = Ctotaal - (Cent5 * 5);
            Cent2 = Convert.ToUInt32(Ctotaal) / 2;
            Ctotaal = Ctotaal - (Cent2 * 2);
            Cent1 = Convert.ToUInt32(Ctotaal) / 1;
            Ctotaal = Ctotaal - (Cent1 * 1);

            txtblE2.Text = "Number of 2 euro coins is " + Euro2;
            txtblE1.Text = "Number of 1 euro coins is " + Euro1;
            txtblC50.Text = "Number of 50 cent coins is " + Cent50;
            txtblC20.Text = "Number of 20 cent coins is " + Cent20;
            txtblC10.Text = "Number of 10 cent coins is " + Cent10;
            txtblC5.Text = "Number of 5 cent coins is " + Cent5;
            txtblC2.Text = "Number of 2 cent coins is " + Cent2;
            txtblC1.Text = "Number of 1 cent coins is " + Cent1;
            txtblTotal.Text = Convert.ToString(Ctotaal / 100);

        }
        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            if (sender == btnC200)
            {
                Ctotaal = Ctotaal + 200;
                txtblTotal.Text = Convert.ToString(Ctotaal / 100);
            } 
            else if (sender == btnC100)
            {
                Ctotaal = Ctotaal + 100;
                txtblTotal.Text = Convert.ToString(Ctotaal / 100);
            }
            else if (sender == btnC50)
            {
                Ctotaal = Ctotaal + 50;
                txtblTotal.Text = Convert.ToString(Ctotaal / 100);
            }
            else if (sender == btnC20)
            {
                Ctotaal = Ctotaal + 20;
                txtblTotal.Text = Convert.ToString(Ctotaal / 100);
            }
            else if (sender == btnC10)
            {
                Ctotaal = Ctotaal + 10;
                txtblTotal.Text = Convert.ToString(Ctotaal / 100);
            }
            else if (sender == btnC5)
            {
                Ctotaal = Ctotaal + 5;
                txtblTotal.Text = Convert.ToString(Ctotaal / 100);
            }
            else if (sender == btnC2)
            {
                Ctotaal = Ctotaal + 2;
                txtblTotal.Text = Convert.ToString(Ctotaal / 100);
            }
            else if (sender == btnC1)
            {
                Ctotaal = Ctotaal + 1;
                txtblTotal.Text = Convert.ToString(Ctotaal / 100);
            }
        }
    }
}
