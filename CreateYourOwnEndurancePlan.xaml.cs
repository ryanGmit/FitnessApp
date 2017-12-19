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
    public sealed partial class CreateYourOwnEndurancePlan : Page
    {
        public CreateYourOwnEndurancePlan()
        {
            this.InitializeComponent();
        }
        
        /* Exercise one */
        private void Input1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Save1_Click(object sender, RoutedEventArgs e)
        {
            /* This creates virtual storage*/
            IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication();
            /* Creates a directory call data */
            isf.CreateDirectory("Data");
            /* The streamwriter writes to the file in the data folder. */
            StreamWriter sw = new StreamWriter(new IsolatedStorageFileStream("Data\\myEndurancesTrainingOne.txt", FileMode.Create, isf));
            /* The InputUserName is the text box where this happens */
            sw.WriteLine(Input1.Text);

            sw.Dispose();
        }

        private void Load1_Click(object sender, RoutedEventArgs e)
        {
            IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication();
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(new IsolatedStorageFileStream("Data\\myEndurancesTrainingOne.txt", FileMode.Open, isf));
                ReadTo1.Text = sr.ReadLine();
                sr.Dispose();
            }

            catch
            {
                ReadTo1.Text = "Error reading file";
            }
        }

        /* Exercise two */
        private void Input2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Save2_Click(object sender, RoutedEventArgs e)
        {
            /* This creates virtual storage*/
            IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication();
            /* Creates a directory call data */
            isf.CreateDirectory("Data");
            /* The streamwriter writes to the file in the data folder. */
            StreamWriter sw = new StreamWriter(new IsolatedStorageFileStream("Data\\myEndurancesTrainingTwo.txt", FileMode.Create, isf));
            /* The InputUserName is the text box where this happens */
            sw.WriteLine(Input2.Text);

            sw.Dispose();
        }

        private void Load2_Click(object sender, RoutedEventArgs e)
        {
            IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication();
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(new IsolatedStorageFileStream("Data\\myEndurancesTrainingTwo.txt", FileMode.Open, isf));
                ReadTo2.Text = sr.ReadLine();
                sr.Dispose();
            }

            catch
            {
                ReadTo2.Text = "Error reading file";
            }
        }


        /* Exercise three */
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
            StreamWriter sw = new StreamWriter(new IsolatedStorageFileStream("Data\\myEndurancesTrainingThree.txt", FileMode.Create, isf));
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
                sr = new StreamReader(new IsolatedStorageFileStream("Data\\myEndurancesTrainingThree.txt", FileMode.Open, isf));
                ReadTo3.Text = sr.ReadLine();
                sr.Dispose();
            }

            catch
            {
                ReadTo3.Text = "Error reading file";
            }
        }


        /* Exercise Four */
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
            StreamWriter sw = new StreamWriter(new IsolatedStorageFileStream("Data\\myEndurancesTrainingFour.txt", FileMode.Create, isf));
            /* The InputUserName is the text box where this happens */
            sw.WriteLine(Input4.Text);

            sw.Dispose();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication();
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(new IsolatedStorageFileStream("Data\\myEndurancesTrainingFour.txt", FileMode.Open, isf));
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
