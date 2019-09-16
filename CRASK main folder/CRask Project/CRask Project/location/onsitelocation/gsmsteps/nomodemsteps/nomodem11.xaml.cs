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

namespace CRask_Project.location.onsitelocation.gsmsteps.nomodemsteps
{
    /// <summary>
    /// Interaction logic for nomodem11.xaml
    /// </summary>
    public partial class nomodem11 : Window
    {
        public nomodem11()
        {
            InitializeComponent();
        }

        private void Orientation_Click(object sender, RoutedEventArgs e)
        {
            orientation112 orientfix = new orientation112();
            this.Hide();
            orientfix.ShowDialog();
        }

        private void WrongPN_Click(object sender, RoutedEventArgs e)
        {
            wrongpn113 wrongPnFix = new wrongpn113();
            this.Hide();
            wrongPnFix.ShowDialog();
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            continue111 continueFix = new continue111();
            this.Hide();
            continueFix.ShowDialog();
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Home = new MainWindow();
            this.Hide();
            Home.ShowDialog();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            nomodem Home = new nomodem();
            this.Hide();
            Home.ShowDialog();
        }
    }
}
