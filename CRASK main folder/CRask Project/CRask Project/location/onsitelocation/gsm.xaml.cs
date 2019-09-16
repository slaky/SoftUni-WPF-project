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

namespace CRask_Project.location.onsitelocation
{
    /// <summary>
    /// Interaction logic for gsm.xaml
    /// </summary>
    public partial class gsm : Window
    {
        public gsm()
        {
            InitializeComponent();
        }

        private void NoModemDetected_Click(object sender, RoutedEventArgs e)
        {
            gsmsteps.nomodem nomodemdetec = new gsmsteps.nomodem();
            this.Hide();
            nomodemdetec.ShowDialog();
        }

        private void NotRegistered_Click(object sender, RoutedEventArgs e)
        {
            gsmsteps.Notregistered notregestereddetec = new gsmsteps.Notregistered();
            this.Hide();
            notregestereddetec.ShowDialog();
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Home = new MainWindow();
            this.Hide();
            Home.ShowDialog();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            onsite Home = new onsite();
            this.Hide();
            Home.ShowDialog();
        }
    }
}
