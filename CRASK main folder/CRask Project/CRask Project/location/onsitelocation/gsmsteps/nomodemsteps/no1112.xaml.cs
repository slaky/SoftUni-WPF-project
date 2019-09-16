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
    /// Interaction logic for no1112.xaml
    /// </summary>
    public partial class no1112 : Window
    {
        public no1112()
        {
            InitializeComponent();
        }

        private void Fourleds_Click(object sender, RoutedEventArgs e)
        {
            fourleds11121 fourledsnext = new fourleds11121();
            this.Hide();
            fourledsnext.ShowDialog();
        }

        private void Lessthanfourleds_Click(object sender, RoutedEventArgs e)
        {
            lessthanfour11122 lessthanfourenext = new lessthanfour11122();
            this.Hide();
            lessthanfourenext.ShowDialog();
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Home = new MainWindow();
            this.Hide();
            Home.ShowDialog();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            continue111 Home = new continue111();
            this.Hide();
            Home.ShowDialog();
        }
    }
}
