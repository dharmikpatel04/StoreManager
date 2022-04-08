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
using Firebase.Database;
using Firebase.Database.Query;
using StoreManager.Common;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace StoreManager.Sanitization
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class sanitization : Page
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        public sanitization()
        {
            this.InitializeComponent();
            //dtpicker.SelectedDate = DateTime.Today;

            LoadLibraryMenuGrid();
        }

        private async void LoadLibraryMenuGrid()
        {
            var allPersons = await firebaseHelper.GetAllSelectedTime();
            //lstPersons.ItemsSource = allPersons;
        }

        private void btnhome_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private async void dtpicker_DateChanged(object sender, DatePickerValueChangedEventArgs e)
        {
            //var btnfdh11adata = await firebaseHelper.GetSelectedTime("FrontDoorHandles", "11am", dtpicker.Date.DateTime);
            //if (btnfdh11adata != null)
            //{
            //    btnfdh11a.Background = new SolidColorBrush(Windows.UI.Colors.Green);

            //}
            //var btnfdh12pdata = await firebaseHelper.GetSelectedTime("FrontDoorHandles", "12pm", dtpicker.Date.DateTime);
            //if (btnfdh12pdata != null)
            //{
            //    btnfdh12p.Background = new SolidColorBrush(Windows.UI.Colors.Green);

            //}
        }

        private async void btnfdh11a_Click(object sender, RoutedEventArgs e)
        {
            //await firebaseHelper.AddSelectedTime("FrontDoorHandles", "11am", dtpicker.Date.DateTime);
            //var allPersons = await firebaseHelper.GetAllSelectedTime();
            //lstPersons.ItemsSource = allPersons;
            //btnfdh11a.Background = new SolidColorBrush(Windows.UI.Colors.Green);
        }
    }
}
