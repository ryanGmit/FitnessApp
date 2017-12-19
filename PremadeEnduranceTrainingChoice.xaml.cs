﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FinalWorkoutApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PremadeEnduranceTrainingChoice : Page
    {
        public PremadeEnduranceTrainingChoice()
        {
            this.InitializeComponent();
        }

        private void BeginnerButoon_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BeginnerEnduranceTrainingPlan), null);
        }

        private void AdvancedButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AdvancedPremadeEnduranceTrainingPlan), null);
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EnduranceTraining), null);
        }
    }
}
