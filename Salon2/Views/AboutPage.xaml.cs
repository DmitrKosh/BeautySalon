using Salon2.Models;
using Salon2.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Salon2.Views
{
    //[QueryProperty(nameof(IdUser), nameof(IdUser))]
    public partial class AboutPage : ContentPage
    {
        public int IdUser
        {
            set
            {
                //SaveIdUser(value);
            }
        }

        private async void SaveIdUser(string value)
        {
            int idUser = Convert.ToInt32(value);
            User user = await App.UsersDB.GetUserAsyncId(idUser);
            BindingContext = user;
        }

        public AboutPage()
        {
            InitializeComponent();
        }

        //public void sdf(object sender, System.EventArgs e)
        //{
        //    Button button = (Button)sender;
        //    Application.Current.MainPage = new BookingServicesPage();
        //}
    }
}