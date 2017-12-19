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
    public sealed partial class WeightTrainingOption : Page
    {
        public WeightTrainingOption()
        {
            this.InitializeComponent();
        }

        private void ReturnToTrainingType_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ChooseTrainingType), null);
        }

        private void CreateYourOwnWeightTrainingPlan_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CreateYourOwnWeightTrainingProgram), null);
        }

        private void UsePreMadeWeightTrainingPlan_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PremadeWeightLiftingChoice), null);
        }
    }
}
