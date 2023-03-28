using Salon2.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Salon2.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            this.BindingContext = new AboutViewModel();
        }

        //public void sdf(object sender, System.EventArgs e)
        //{
        //    Button button = (Button)sender;
        //    Application.Current.MainPage = new BookingServicesPage();
        //}
    }
}