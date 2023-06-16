using Salon2.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Salon2.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public Command OnBookingClicked { get; }
        public Command OnCatalogClicked { get; }

        public AboutViewModel()
        {
            Title = "Главная";
            OnBookingClicked = new Command(OnLoginClicked);
            OnCatalogClicked = new Command(OnCatalog);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(Page1)}");
        }

        private async void OnCatalog(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(ItemsPage)}");
        }
    }
}