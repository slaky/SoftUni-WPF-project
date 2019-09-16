using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace CRask_Project
{
    /// <summary>
    /// Interaction logic for sidemenu.xaml
    /// </summary>
    public partial class Sidemenu : UserControl
    {
        
        public Sidemenu()
        {
            InitializeComponent();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, EventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }
        private void ButtonPopUpExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //SiteStatus NoComms = new SiteStatus();
            //this.Hide();
            //NoComms.ShowDialog();

            MainWindow home = new MainWindow();
            
            //home.ShowDialog();

           
        }


        public void ButtonRTmon_Click(object sender, RoutedEventArgs e)
        {
            //var localTools = ($@"{AppDomain.CurrentDomain.BaseDirectory}tools/RTMon.rdp");
            //Process.Start(localTools);




            const string localFile = @"C:\crask\tools\RTMon.rdp";
            Process.Start(localFile);

        }

        private void ButtonLoosePem_Click(object sender, RoutedEventArgs e)
        {
            

            const string localFile = @"C:\crask\tools\LoosePEM.rdp";
            Process.Start(localFile);
        }

        private void ButtonServerAdmin_Click(object sender, RoutedEventArgs e)
        {
            const string localFile = @"C:\crask\tools\ServerAdmin.rdp";
            Process.Start(localFile);
        }

        private void ButtonPacketSniffer_Click(object sender, RoutedEventArgs e)
        {
            const string localFile = @"C:\crask\tools\PacketSniffer.rdp";
            Process.Start(localFile);
        }

        private void ButtonStringMapper_Click(object sender, RoutedEventArgs e)
        {
            const string localFile = @"C:\crask\tools\StringMapper.rdp";
            Process.Start(localFile);
        }

        private void ButtonLogOff_Click(object sender, RoutedEventArgs e)
        {
            const string localFile = @"C:\crask\tools\logoff.rdp";
            Process.Start(localFile);
        }

        

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            const string webpageUrl = "https://www.solaredge.com/";

            Process.Start(webpageUrl);
            
        }

        private void Passport_Selected(object sender, RoutedEventArgs e)
        {
            const string webpageUrl = "http://passport/default.aspx";

            Process.Start(webpageUrl);
            
        }

        private void Monitoring_Selected(object sender, RoutedEventArgs e)
        {
            const string webpageUrl = "https://monitoring.solaredge.com/solaredge-web/p/home";

            Process.Start(webpageUrl);
        }

        private void CRedgeSearch_Selected(object sender, RoutedEventArgs e)
        {
            const string webpageUrl = "http://credge/index.php?module=Cases&action=index&parentTab=Support";

            Process.Start(webpageUrl);
        }

        private void CRedgeCreate_Selected(object sender, RoutedEventArgs e)
        {
            const string webpageUrl = "http://credge/index.php?module=Cases&action=EditView&return_module=Cases&return_action=DetailView";

            Process.Start(webpageUrl);
        }

        private void WebTools_Selected(object sender, RoutedEventArgs e)
        {
            const string webpageUrl = "https://webtools.solaredge.com/";

            Process.Start(webpageUrl);
        }
    }
}
