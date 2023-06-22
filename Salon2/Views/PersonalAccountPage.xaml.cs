using Salon2.Dto;
using Salon2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Salon2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonalAccountPage : ContentPage
    {
        public PersonalAccountPage()
        {
            InitializeComponent();
            GetUser();
            
        }

        protected override async void OnAppearing()
        {
            //var sadfg = new List<User>();
            //sadfg = await App.UsersDB.GetUsersAsync();
            //collectionView.ItemsSource = sadfg;

            var orders = new List<Order>();
            orders = await App.UsersDB.GetOrderAsyncIdUer(IdUser);
            collectionView.ItemsSource = orders;

            GetUser();
            //GetDate();

            // Чтобы подгрузить данные
            base.OnAppearing();
        }
        private int IdUser;

        public List<User> Orders = new List<User>();
        private async void GetUser()
        {
            IdUser = UserDto.IdUserDto;
            var user = await App.UsersDB.GetUserAsyncId(IdUser);
            NameUser.Text = user.Name + " " + user.Surname;
            PhoneUser.Text = user.Phone;
        }
        
        //private async void GetDate()
        //{

        //    collectionView.ItemsSource = await App.UsersDB.GetOrdersAsync();
        //    base.OnAppearing();
        //}
    }
}