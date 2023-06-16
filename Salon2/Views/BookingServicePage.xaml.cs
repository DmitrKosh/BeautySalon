using Salon2.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Salon2.Views
{
    public partial class BookingServicePage : ContentPage
    {
        public CultureInfo Culture => new CultureInfo("ru-RU");

        private bool _clickedButtonService;
        public bool ClickedButtonService
        {
            get
            { return _clickedButtonService; }
            set
            {
                value = _clickedButtonService; OnPropertyChanged("ClickedButtonService");
            }
        }

        private bool _clickedButtonBooking;
        public bool ClickedButtonBooking
        {
            get
            { return _clickedButtonBooking; }
            set
            {
                value = _clickedButtonBooking; OnPropertyChanged("ClickedButtonBooking");
            }
        }


        List<string> Employees = new List<string>() { "Петрова Анна", "Шибзухова Евгения", "Ковлягина Валерия"};
        List<string> Services = new List<string>() { "Стрижка женская с укладкой", "Стрижка мужская", "Укладка" };

        //public class CombinedViewModel
        //{
        //    public BookingServicePage WebItemVM = new BookingServicePage();
        //    public BookingServiceViewModel InnerFlangVM = new BookingServiceViewModel();
        //}

        public BookingServicePage()
        {
            InitializeComponent();
            this.BindingContext = new BookingServiceViewModel(); //CombinedViewModel();

            ClickedButtonBooking = false;
        }

    }
}