﻿using System;
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
    /// Interaction logic for equal2113.xaml
    /// </summary>
    public partial class equal2113 : Window
    {
        public equal2113()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            yestmobile211 goback = new yestmobile211();
            this.Hide();
            goback.ShowDialog();
        }
    }
}
