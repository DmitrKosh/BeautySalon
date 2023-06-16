using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Salon2.Views
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public CultureInfo Culture => new CultureInfo("ru-RU");
        public bool IsEnBt = false;

        public Page1()
        {
            InitializeComponent();
            CalCulture.Culture = Culture;

            bt14_00.IsEnabled = false;
            bt18_00.IsEnabled = false;
        }

        protected override void OnAppearing()
        {


            base.OnAppearing();
        }

        private void Button_Click9_00(object sender, EventArgs e)
        {
        }

        private void Button_Click10_00(object sender, EventArgs e)
        {
        }

        private void Button_Click11_00(object sender, EventArgs e)
        {
        }

        private void Button_Click12_00(object sender, EventArgs e)
        {
        }

        private void Button_Click13_00(object sender, EventArgs e)
        {
        }

        private void Button_Click14_00(object sender, EventArgs e)
        {
        }

        private void Button_Click15_00(object sender, EventArgs e)
        {
        }

        private void Button_Click16_00(object sender, EventArgs e)
        {
        }

        private void Button_Click17_00(object sender, EventArgs e)
        {
        }

        private void Button_Click18_00(object sender, EventArgs e)
        {
        }

        private void Button_Click19_00(object sender, EventArgs e)
        {
        }

        private void Button_Click20_00(object sender, EventArgs e)
        {
        }

        private void Button_Booking(object sender, EventArgs e)
        {

        }
    }
}