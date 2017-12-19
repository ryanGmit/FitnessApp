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


using System.IO.IsolatedStorage;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FinalWorkoutApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateYourOwnWeightLossPlan : Page
    {
        public CreateYourOwnWeightLossPlan()
        {
            this.InitializeComponent();
        }

        /* Exercise one */
        private void InputWeightLossExerciseOne_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void saveFutureWeightLossWorkouts_Click(object sender, RoutedEventArgs e)
        {
            /* This creates virtual storage*/
            IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication();
            /* Creates a directory call data */
            isf.CreateDirectory("Data");
            /* The streamwriter writes to the file in the data folder. */
            StreamWriter sw = new StreamWriter(new IsolatedStorageFileStream("Data\\myWeightLossExercise.txt", FileMode.Create, isf));
            /* The InputUserName is the text box where this happens */
            sw.WriteLine(InputWeightLossExerciseOne.Text);
      
            sw.Dispose();
        }

        private void UpdateWeightLossExerciseButton_Click(object sender, RoutedEventArgs e)
        {
            IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication();
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(new IsolatedStorageFileStream("Data\\myWeightLossExercise.txt", FileMode.Open, isf));
                ReadToWeightLossWorkOuts.Text = sr.ReadLine();
                sr.Dispose();
            }

            catch
            {
                ReadToWeightLossWorkOuts.Text = "Error reading file";
            }
        }

        /* Second exercise  */
        private void InputWeightLossExerciseTwo_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void SaveFutureWeightLossWorkouts2_Click(object sender, RoutedEventArgs e)
        {
            /* This creates virtual storage*/
            IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication();
            /* Creates a directory call data */
            isf.CreateDirectory("Data");
            /* The streamwriter writes to the file in the data folder. */
            StreamWriter sw = new StreamWriter(new IsolatedStorageFileStream("Data\\myWeightLossExerciseTwo.txt", FileMode.Create, isf));
            /* The InputUserName is the text box where this happens */
            sw.WriteLine(InputWeightLossExerciseTwo.Text);

            sw.Dispose();

        }

        private void LoadWeightLossExerciseTwo_Click(object sender, RoutedEventArgs e)
        {

            IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication();
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(new IsolatedStorageFileStream("Data\\myWeightLossExerciseTwo.txt", FileMode.Open, isf));
                ReadToWeightLossWorkOuts2.Text = sr.ReadLine();
                sr.Dispose();
            }

            catch
            {
                ReadToWeightLossWorkOuts2.Text = "Error reading file";
            }

        }

        /* Third exercise  */
        private void Input3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Save3_Click(object sender, RoutedEventArgs e)
        {
            /* This creates virtual storage*/
            IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication();
            /* Creates a directory call data */
            isf.CreateDirectory("Data");
            /* The streamwriter writes to the file in the data folder. */
            StreamWriter sw = new StreamWriter(new IsolatedStorageFileStream("Data\\myWeightLossExerciseThree.txt", FileMode.Create, isf));
            /* The InputUserName is the text box where this happens */
            sw.WriteLine(Input3.Text);

            sw.Dispose();
        }

        private void Load3_Click(object sender, RoutedEventArgs e)
        {
            IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication();
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(new IsolatedStorageFileStream("Data\\myWeightLossExerciseThree.txt", FileMode.Open, isf));
                ReadTo3.Text = sr.ReadLine();
                sr.Dispose();
            }

            catch
            {
                ReadTo3.Text = "Error reading file";
            }
        }

        /* Fourth exercise  */
        private void Input4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Save4_Click(object sender, RoutedEventArgs e)
        {
            /* This creates virtual storage*/
            IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication();
            /* Creates a directory call data */
            isf.CreateDirectory("Data");
            /* The streamwriter writes to the file in the data folder. */
            StreamWriter sw = new StreamWriter(new IsolatedStorageFileStream("Data\\myWeightLossExerciseFour.txt", FileMode.Create, isf));
            /* The InputUserName is the text box where this happens */
            sw.WriteLine(Input4.Text);

            sw.Dispose();
        }

        private void Load4_Click(object sender, RoutedEventArgs e)
        {
            IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication();
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(new IsolatedStorageFileStream("Data\\myWeightLossExerciseFour.txt", FileMode.Open, isf));
                ReadTo4.Text = sr.ReadLine();
                sr.Dispose();
            }

            catch
            {
                ReadTo4.Text = "Error reading file";
            }
        }

       
    }
}
