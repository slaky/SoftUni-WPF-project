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
using System.Windows.Threading;

namespace CRask_Project.location.onsitelocation.gsmsteps
{
    /// <summary>
    /// Interaction logic for notregistered.xaml
    /// </summary>
    public partial class Notregistered : Window
    {
        public Notregistered()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            DispatcherTimer timer2 = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer2.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer2.Tick += timer_Tick1;
            timer.Start();
            timer2.Start();
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            notregisteredsteps.yes21 yes21next = new notregisteredsteps.yes21();
            this.Hide();
            yes21next.ShowDialog();
        }

        //private void No_Click(object sender, RoutedEventArgs e)
        //{
        //    notregisteredsteps.no22 no22next = new notregisteredsteps.no22();
        //    this.Hide();
        //    no22next.ShowDialog();
        //}


        //First video controls
        void timer_Tick(object sender, EventArgs e)
        {
            if (CheckFWmonitor.Source != null)
            {
                if (CheckFWmonitor.NaturalDuration.HasTimeSpan)
                    lblStatus.Content = String.Format("{0} / {1}", CheckFWmonitor.Position.ToString(@"mm\:ss"), CheckFWmonitor.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            }
            else
                lblStatus.Content = "No file selected...";
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            CheckFWmonitor.Play();
        }

        private void BtnPause_Click(object sender, RoutedEventArgs e)
        {
            CheckFWmonitor.Pause();
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            CheckFWmonitor.Stop();
        }


        //Second Video control
        void timer_Tick1(object sender, EventArgs e)
        {
            if (CheckFWlocaly.Source != null)
            {
                if (CheckFWlocaly.NaturalDuration.HasTimeSpan)
                    lblStatus2.Content = String.Format("{0} / {1}", CheckFWlocaly.Position.ToString(@"mm\:ss"), CheckFWlocaly.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            }
            else
                lblStatus.Content = "No file selected...";
        }

        private void BtnPlay2_Click(object sender, RoutedEventArgs e)
        {
            CheckFWlocaly.Play();
        }

        private void BtnPause2_Click(object sender, RoutedEventArgs e)
        {

            CheckFWlocaly.Pause();
        }

        private void BtnStop2_Click(object sender, RoutedEventArgs e)
        {
            CheckFWlocaly.Stop();
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            notregisteredsteps.no22 no22next = new notregisteredsteps.no22();
            this.Hide();
            no22next.ShowDialog();
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Home = new MainWindow();
            this.Hide();
            Home.ShowDialog();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            gsm Home = new gsm();
            this.Hide();
            Home.ShowDialog();
        }
    }
}
