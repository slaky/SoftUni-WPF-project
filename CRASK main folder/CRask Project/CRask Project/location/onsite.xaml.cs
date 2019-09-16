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
    /// Interaction logic for onsite.xaml
    /// </summary>
    public partial class onsite : Window
    {
        public onsite()
        {
            InitializeComponent();
        }

        private void GSM_Click(object sender, RoutedEventArgs e)
        {
            GSM.Resources["GSM"] = new TextBlock() { Text = "this it new dynamicresource", Background = new SolidColorBrush(Colors.Magenta) };
            onsitelocation.gsm gsmcomms = new onsitelocation.gsm();
            this.Hide();
            gsmcomms.ShowDialog();
        }

        private void ZigBee_Click(object sender, RoutedEventArgs e)
        {
            onsitelocation.zigbee zigbeecomms = new onsitelocation.zigbee();
            this.Hide();
            zigbeecomms.ShowDialog();
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
