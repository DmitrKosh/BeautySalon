using Salon2.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Salon2.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public Command BookingServicesCommand { get; }

        public AboutViewModel()
        {
            Title = "Главная";
            BookingServicesCommand = new Command(OnBookingClicked);
        }

        private void OnBookingClicked(object obj)
        {
            Application.Current.MainPage = new BookingServicePage();
        }
    }
}