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

namespace CRask_Project.location.onsitelocation.gsmsteps.notregisteredsteps
{
    /// <summary>
    /// Interaction logic for yestmobile211.xaml
    /// </summary>
    public partial class yestmobile211 : Window
    {
        public yestmobile211()
        {
            InitializeComponent();
        }

        private void Under11_Click(object sender, RoutedEventArgs e)
        {
            under2111 Under2111 = new under2111();
            this.Hide();
            Under2111.ShowDialog();
        }

        private void Above11_Click(object sender, RoutedEventArgs e)
        {
            above2112 Above2112 = new above2112();
            this.Hide();
            Above2112.ShowDialog();
        }

        private void EqualTo99_Click(object sender, RoutedEventArgs e)
        {
            equal2113 Equal12113 = new equal2113();
            this.Hide();
            Equal12113.ShowDialog();
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Home = new MainWindow();
            this.Hide();
            Home.ShowDialog();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            yes21 Home = new yes21();
            this.Hide();
            Home.ShowDialog();
        }
    }
}
