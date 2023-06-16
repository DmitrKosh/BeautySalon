using Salon2.Models;
using Salon2.Services;
using Salon2.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Salon2.Data;
using System.IO;

namespace Salon2
{
    public partial class App : Application
    {
        static UsersDB usersDB;
        public static UsersDB UsersDB
        {
            get
            {
                if (usersDB == null)
                {
                    usersDB = new UsersDB(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "DBColibri.db3"));
                }
                return usersDB;
            }
        }

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
