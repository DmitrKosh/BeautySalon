using Salon2.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Salon2.Views
{
    public partial class BookingServicePage : ContentPage
    {
        public BookingServicePage()
        {
            InitializeComponent();
            this.BindingContext = new BookingServiceViewModel();

            
        }
    }
}