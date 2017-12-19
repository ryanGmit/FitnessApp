using System;
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
    public sealed partial class ChooseTrainingType : Page
    {
        public ChooseTrainingType()
        {
            this.InitializeComponent();
        }

        /* This is the Weight Loss button */
        private void WeightLoss_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(WeightLossOption), null);
        }

        /* This is the Weight Training button */
        private void WeightTraining_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(WeightTrainingOption), null);
        }

        /* This is the Endurance Training button */
        private void EnduranceTraining_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EnduranceTraining), null);
        }

        /* This is the return to main page button */
        /* If a user decides to go back a step they may do so by selecting this option */
        private void ReturnToMainPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }
    }
}
