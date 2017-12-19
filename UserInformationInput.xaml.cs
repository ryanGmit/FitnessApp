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
    public sealed partial class UserInformationInput : Page
    {
        public UserInformationInput()
        {
            this.InitializeComponent();
        }

        /* This is my first example of isolated storage in my app */
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /* This creates virtual storage*/
            IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication();
            /* Creates a directory call data */
            isf.CreateDirectory("Data");
            /* The streamwriter writes to the file in the data folder. */
            StreamWriter sw = new StreamWriter(new IsolatedStorageFileStream("Data\\myFile.txt", FileMode.Create, isf));
            /* The InputUserName is the text box where this happens */
            sw.WriteLine(InputUserName.Text);
            sw.Dispose();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication();
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(new IsolatedStorageFileStream("Data\\myFile.txt", FileMode.Open, isf));
                ReadToTextBlock.Text = sr.ReadLine();
                sr.Dispose();
            }

            catch
            {
                ReadToTextBlock.Text = "Error reading file";
            }
        }

        private void ContinueToChooseWorkout_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ChooseTrainingType), null);
        }

        private void InputUserName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
