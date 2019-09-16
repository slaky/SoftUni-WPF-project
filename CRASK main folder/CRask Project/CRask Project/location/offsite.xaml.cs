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

namespace CRask_Project.location
{
    /// <summary>
    /// Interaction logic for offsite.xaml
    /// </summary>
    public partial class offsite : Window
    {
        public offsite()
        {
            InitializeComponent();
        }

        private void GSM_Click(object sender, RoutedEventArgs e)
        {
            offsitelocation.gsm gsmcomm = new offsitelocation.gsm();
            this.Hide();
            gsmcomm.ShowDialog();
        }

        private void ZigBee_Click(object sender, RoutedEventArgs e)
        {
            offsitelocation.zigbee zigbeecomm = new offsitelocation.zigbee();
            this.Hide();
            zigbeecomm.ShowDialog();
        }
        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Home = new MainWindow();
            this.Hide();
            Home.ShowDialog();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            SiteStatus Home = new SiteStatus();
            this.Hide();
            Home.ShowDialog();
        }
    }
}
