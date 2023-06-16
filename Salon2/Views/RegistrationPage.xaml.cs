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
    public partial class RegistrationPage : ContentPage
    {
        public Command RegistrationCommand { get; }

        #region Свойства
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

        private string _password2;
        public string Password2
        {
            get { return _password2; }
            set
            {
                _password2 = value; OnPropertyChanged();
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value; OnPropertyChanged();
            }
        }

        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set
            {
                _surname = value; OnPropertyChanged();
            }
        }

        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value; OnPropertyChanged();
            }
        }
        #endregion

        public RegistrationPage()
        {
            InitializeComponent();
            RegistrationCommand = new Command(RegistrationUser);
            BindingContext = new User();
        }

        private async void RegistrationUser()
        {
            
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                User user = (User)BindingContext;
                

                if (!string.IsNullOrWhiteSpace(user.Password) & !string.IsNullOrWhiteSpace(user.Login) & !string.IsNullOrWhiteSpace(user.Name) & !string.IsNullOrWhiteSpace(user.Surname) & !string.IsNullOrWhiteSpace(user.Phone) & user.Password == RepeatPasswordEntry.Text)
                {
                    await App.UsersDB.SaveUserAsync(user);
                    //await Shell.Current.GoToAsync("..");
                    await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
                }

                if (user.Password != RepeatPasswordEntry.Text)
                {
                    labelPassowrd.Text = "!";
                    labelPassowrd.FontSize = 20;
                }




            }
            catch { }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}