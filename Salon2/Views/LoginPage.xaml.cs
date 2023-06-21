using Salon2.Dto;
using Salon2.Models;
using Salon2.ViewModels;
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
    public partial class LoginPage : ContentPage
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value; OnPropertyChanged();
            }
        }

        private string _login;
        public string Login
        {
            get { return _login; }
            set
            {
                _login = value; OnPropertyChanged();
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value; OnPropertyChanged();
            }
        }

        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
            BindingContext = new User();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //await Shell.Current.GoToAsync($"//{nameof(RegistrationPage)}");
            Navigation.PushAsync(new RegistrationPage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            string loginText = login.Text;
            string passwordText = password.Text;

            try
            {
                User user = await App.UsersDB.GetUserAsyncLogin(loginText, passwordText);
                BindingContext = user;

                if (user.Login == loginText & user.Password == passwordText & user.Login != null & user.Password != null)
                {
                    await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");

                    UserDto.IdUserDto = user.ID;
                }
            }
            catch
            {
                LbErrLogOrPas.Text = "Неверный пароль или логин";
            }
        }
    }
}