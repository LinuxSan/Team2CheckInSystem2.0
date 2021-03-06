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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CheckInSystem.Domain_Layer;

namespace CheckInSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
        }

        private void GoToPinCodeWindow(object sender, RoutedEventArgs e)
        {
            PinCodeWindow pinWindow = new PinCodeWindow();
            pinWindow.Show();
            this.Close();
        }
    }
}
