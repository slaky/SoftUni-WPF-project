using CRask_Project.location;
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
    /// Interaction logic for SiteStatus.xaml
    /// </summary>
    public partial class SiteStatus : Window
    {
        public SiteStatus()
        {
            InitializeComponent();
        }

        private void OffSite_Click(object sender, RoutedEventArgs e)
        {
            location.offsite osite = new offsite();
            this.Hide();
            osite.ShowDialog();

        }

        private void OnSite_Click(object sender, RoutedEventArgs e)
        {
            location.onsite oosite = new onsite();
            this.Hide();
            oosite.ShowDialog();
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Home = new MainWindow();
            this.Hide();
            Home.ShowDialog();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            InverterTroubleshoting Home = new InverterTroubleshoting();
            this.Hide();
            Home.ShowDialog();
        }
    }
}
