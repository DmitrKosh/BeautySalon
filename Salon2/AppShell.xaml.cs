using Salon2.ViewModels;
using Salon2.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Salon2
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(BookingServicePage), typeof(BookingServicePage));
            Routing.RegisterRoute(nameof(BookingServicePage2), typeof(BookingServicePage2));
            Routing.RegisterRoute(nameof(Page1), typeof(Page1));
            Routing.RegisterRoute(nameof(RegistrationPage), typeof(RegistrationPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
