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
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Autorization : ContentPage
    {
        public string Login { get; set; }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged(); }
        }
        public Autorization()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {


            try
            {
                int id = 1;

                User user = await App.UsersDB.GetUserAsyncId(id);

                BindingContext = user;
            }
            catch { }
        }
    }
}