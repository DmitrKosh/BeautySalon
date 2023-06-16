using Salon2.Models;
using Salon2.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Salon2.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public Command OnRegistrationCommand { get; }

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

        private string _loginData;
        public string LoginData
        {
            get { return _loginData; }
            set
            {
                _loginData = value; OnPropertyChanged();
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

        private string _placeholderLogin;
        public string PlaceholderLogin
        {
            get { return _placeholderLogin; }
            set
            {
                _placeholderLogin = value; OnPropertyChanged();
            }
        }

        private string _placeholderPassword;
        public string PlaceholderPassword
        {
            get { return _placeholderPassword; }
            set
            {
                _placeholderPassword = value; OnPropertyChanged();
            }
        }

        public LoginViewModel()
        {
            //LoginCommand = new Command(OnLoginClicked);
            //OnRegistrationCommand = new Command(OnRegistrationClicked);

            
        }
    }
}
