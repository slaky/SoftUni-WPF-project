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
    /// Interaction logic for yes21.xaml
    /// </summary>
    public partial class yes21 : Window
    {
        public yes21()
        {
            InitializeComponent();
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            yestmobile211 yesTmobile212 = new yestmobile211();
            this.Hide();
            yesTmobile212.ShowDialog();
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            notmobile212 noTmobile212 = new notmobile212();
            this.Hide();
            noTmobile212.ShowDialog();
        }
        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Home = new MainWindow();
            this.Hide();
            Home.ShowDialog();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Notregistered Home = new Notregistered();
            this.Hide();
            Home.ShowDialog();
        }
    }
}
