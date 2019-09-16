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
using System.Windows.Shapes;

namespace CRask_Project
{
    /// <summary>
    /// Interaction logic for InverterTroubleshoting.xaml
    /// </summary>
    public partial class InverterTroubleshoting : Window
    {
        public InverterTroubleshoting()
        {
            InitializeComponent();
        }

        //Code Value 1 - This is for the button in the main screen for no communication
        private void NoComms_Click(object sender, RoutedEventArgs e)
        {
            SiteStatus NoComms = new SiteStatus();
            this.Hide();
            NoComms.ShowDialog();
        }
        //Code Value 2 - This is for the button in the main screen for no production
        private void NoProd_Click(object sender, RoutedEventArgs e)
        {
            SiteStatus NoProd = new SiteStatus();
            this.Hide();
            NoProd.ShowDialog();
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Home = new MainWindow();
            this.Hide();
            Home.ShowDialog();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Home = new MainWindow();
            this.Hide();
            Home.ShowDialog();
        }
    }
}
