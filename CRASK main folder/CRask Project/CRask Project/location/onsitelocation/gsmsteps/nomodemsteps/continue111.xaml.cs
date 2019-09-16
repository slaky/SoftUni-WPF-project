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
    /// Interaction logic for continue111.xaml
    /// </summary>
    public partial class continue111 : Window
    {
        public continue111()
        {
            InitializeComponent();
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            resolved1111 end = new resolved1111();
            this.Hide();
            end.ShowDialog();
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            no1112 nocontinue1112 = new no1112();
            this.Hide();
            nocontinue1112.ShowDialog();
        }
        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Home = new MainWindow();
            this.Hide();
            Home.ShowDialog();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            nomodem11 Home = new nomodem11();
            this.Hide();
            Home.ShowDialog();
        }
    }
}
