using Salon2.Dto;
using Salon2.Models;
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

        DateTime? calendarDate;
        DateTime? SaveDateBut;

        private int _iserId;
        public int UserID
        {
            get { return _iserId; }
            set { _iserId = value; OnPropertyChanged(); }
        }

        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged(); }
        }

        private int _masterId;
        public int MasterId 
        {
            get { return _masterId; } 
            set { _masterId = value; OnPropertyChanged(); }
        }

        private int _serviceId;
        public int ServiceId 
        { 
            get { return _serviceId; }
            set { _serviceId = value; OnPropertyChanged(); }
        }

        private DateTime? _dateTime;
        public DateTime? DateTime 
        {
            get { return _dateTime; }
            set { _dateTime = value; OnPropertyChanged(); }
        }

        public Page1()
        {
            InitializeComponent();
            BindingContext = new Order();
            CalCulture.Culture = Culture;
            CalCulture.MinimumDate = new DateTime(2020, 1, 1);
            bt9_00.IsEnabled = false;
            bt10_00.IsEnabled = false;
            bt11_00.IsEnabled = false;
            bt12_00.IsEnabled = false;
            bt13_00.IsEnabled = false;
            bt14_00.IsEnabled = false;
            bt15_00.IsEnabled = false;
            bt16_00.IsEnabled = false;
            bt17_00.IsEnabled = false;
            bt18_00.IsEnabled = false;
            bt19_00.IsEnabled = false;
            bt20_00.IsEnabled = false;
            UserID = UserDto.IdUserDto;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        


        #region Выбор услуги и работника и проверка записей

        private async void PickerService_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceId = PickerService.SelectedIndex;
        }

        DateTime SelectedDateTime;
        DateTime? aag;
        TimeSpan timeSpan = new TimeSpan(0, 9, 0, 0);
        TimeSpan timeSpan1 = new TimeSpan(0, 10, 0, 0);
        TimeSpan timeSpan2 = new TimeSpan(0, 11, 0, 0);
        TimeSpan timeSpan3 = new TimeSpan(0, 12, 0, 0);
        TimeSpan timeSpan4 = new TimeSpan(0, 13, 0, 0);
        TimeSpan timeSpan5 = new TimeSpan(0, 14, 0, 0);
        TimeSpan timeSpan6 = new TimeSpan(0, 15, 0, 0);
        TimeSpan timeSpan7 = new TimeSpan(0, 16, 0, 0);
        TimeSpan timeSpan8 = new TimeSpan(0, 17, 0, 0);
        TimeSpan timeSpan9 = new TimeSpan(0, 18, 0, 0);
        TimeSpan timeSpan10 = new TimeSpan(0, 19, 0, 0);
        TimeSpan timeSpan11 = new TimeSpan(0, 20, 0, 0);


        private async void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            MasterId = PickerEmployee.SelectedIndex;
            calendarDate = CalCulture.SelectedDate;
            if(calendarDate != null)
            {
                //Order order = await App.UsersDB.GetOtderAsyncDate(calendarDate);
                SelectedDateTime = Convert.ToDateTime(calendarDate) + timeSpan;
                aag = SelectedDateTime;
                try
                {
                    var order = await App.UsersDB.GetOrderAsyncDate(aag, UserID);

                    if (order.DateTime == aag)
                    {
                        bt9_00.IsEnabled = false;
                    }
                }
                catch
                {
                    bt9_00.IsEnabled = true;
                }

                SelectedDateTime = Convert.ToDateTime(calendarDate) + timeSpan1;
                aag = SelectedDateTime;
                try
                {
                    var order = await App.UsersDB.GetOrderAsyncDate(aag, UserID);

                    if (order.DateTime == aag)
                    {
                        bt10_00.IsEnabled = false;
                    }
                }
                catch
                {
                    bt10_00.IsEnabled = true;
                }

                SelectedDateTime = Convert.ToDateTime(calendarDate) + timeSpan2;
                aag = SelectedDateTime;
                try
                {
                    var order = await App.UsersDB.GetOrderAsyncDate(aag, UserID);

                    if (order.DateTime == aag)
                    {
                        bt11_00.IsEnabled = false;
                    }
                }
                catch
                {
                    bt11_00.IsEnabled = true;
                }

                SelectedDateTime = Convert.ToDateTime(calendarDate) + timeSpan3;
                aag = SelectedDateTime;
                try
                {
                    var order = await App.UsersDB.GetOrderAsyncDate(aag, UserID);

                    if (order.DateTime == aag)
                    {
                        bt18_00.IsEnabled = false;
                    }
                }
                catch
                {
                    bt12_00.IsEnabled = true;
                }

                SelectedDateTime = Convert.ToDateTime(calendarDate) + timeSpan4;
                aag = SelectedDateTime;
                try
                {
                    var order = await App.UsersDB.GetOrderAsyncDate(aag, UserID);

                    if (order.DateTime == aag)
                    {
                        bt18_00.IsEnabled = false;
                    }
                }
                catch
                {
                    bt13_00.IsEnabled = true;
                }

                SelectedDateTime = Convert.ToDateTime(calendarDate) + timeSpan5;
                aag = SelectedDateTime;
                try
                {
                    var order = await App.UsersDB.GetOrderAsyncDate(aag, UserID);

                    if (order.DateTime == aag)
                    {
                        bt18_00.IsEnabled = false;
                    }
                }
                catch
                {
                    bt14_00.IsEnabled = true;
                }

                SelectedDateTime = Convert.ToDateTime(calendarDate) + timeSpan6;
                aag = SelectedDateTime;
                try
                {
                    var order = await App.UsersDB.GetOrderAsyncDate(aag, UserID);

                    if (order.DateTime == aag)
                    {
                        bt18_00.IsEnabled = false;
                    }
                }
                catch
                {
                    bt15_00.IsEnabled = true;
                }

                SelectedDateTime = Convert.ToDateTime(calendarDate) + timeSpan7;
                aag = SelectedDateTime;
                try
                {
                    var order = await App.UsersDB.GetOrderAsyncDate(aag, UserID);

                    if (order.DateTime == aag)
                    {
                        bt18_00.IsEnabled = false;
                    }
                }
                catch
                {
                    bt16_00.IsEnabled = true;
                }

                SelectedDateTime = Convert.ToDateTime(calendarDate) + timeSpan8;
                aag = SelectedDateTime;
                try
                {
                    var order = await App.UsersDB.GetOrderAsyncDate(aag, UserID);

                    if (order.DateTime == aag)
                    {
                        bt18_00.IsEnabled = false;
                    }
                }
                catch
                {
                    bt17_00.IsEnabled = true;
                }

                SelectedDateTime = Convert.ToDateTime(calendarDate) + timeSpan9;
                aag = SelectedDateTime;
                try
                {
                    var order = await App.UsersDB.GetOrderAsyncDate(aag, UserID);
                    
                    if (order.DateTime == aag)
                    {
                        bt18_00.IsEnabled = false;
                    }
                    
                }
                catch
                {
                    bt18_00.IsEnabled = true;
                }

                SelectedDateTime = Convert.ToDateTime(calendarDate) + timeSpan10;
                aag = SelectedDateTime;
                try
                {
                    var order = await App.UsersDB.GetOrderAsyncDate(aag, UserID);

                    if (order.DateTime == aag)
                    {
                        bt18_00.IsEnabled = false;
                    }
                }
                catch
                {
                    bt19_00.IsEnabled = true;
                }

                SelectedDateTime = Convert.ToDateTime(calendarDate) + timeSpan11;
                aag = SelectedDateTime;
                try
                {
                    var order = await App.UsersDB.GetOrderAsyncDate(aag, UserID);

                    if (order.DateTime == aag)
                    {
                        bt18_00.IsEnabled = false;
                    }
                }
                catch
                {
                    bt20_00.IsEnabled = true;
                }
            }
        }
        #endregion


        #region ButtonSelectedTime

        private async void Button_Click9_00(object sender, EventArgs e)
        {
            bt9_00.BackgroundColor = Color.FromHex("#41D698");
            TimeSpan timeSaveSpan = new TimeSpan(0, 9, 0, 0);
            
            SaveDateBut = calendarDate + timeSaveSpan;
        }

        private async void Button_Click10_00(object sender, EventArgs e)
        {
            bt10_00.BackgroundColor = Color.FromHex("#41D698");
            TimeSpan timeSaveSpan = new TimeSpan(0, 10, 0, 0);
            SaveDateBut = calendarDate + timeSaveSpan;
        }

        private async void Button_Click11_00(object sender, EventArgs e)
        {
            bt11_00.BackgroundColor = Color.FromHex("#41D698");
            TimeSpan timeSaveSpan = new TimeSpan(0, 11, 0, 0);
            SaveDateBut = calendarDate + timeSaveSpan;
        }

        private async void Button_Click12_00(object sender, EventArgs e)
        {
            bt12_00.BackgroundColor = Color.FromHex("#41D698");
            TimeSpan timeSaveSpan = new TimeSpan(0, 12, 0, 0);
            SaveDateBut = calendarDate + timeSaveSpan;
        }

        private async void Button_Click13_00(object sender, EventArgs e)
        {
            bt13_00.BackgroundColor = Color.FromHex("#41D698");
            TimeSpan timeSaveSpan = new TimeSpan(0, 13, 0, 0);
            SaveDateBut = calendarDate + timeSaveSpan;
        }

        private async void Button_Click14_00(object sender, EventArgs e)
        {
            bt14_00.BackgroundColor = Color.FromHex("#41D698");
            TimeSpan timeSaveSpan = new TimeSpan(0, 14, 0, 0);
            SaveDateBut = calendarDate + timeSaveSpan;
        }

        private async void Button_Click15_00(object sender, EventArgs e)
        {
            bt15_00.BackgroundColor = Color.FromHex("#41D698");
            TimeSpan timeSaveSpan = new TimeSpan(0, 15, 0, 0);
            SaveDateBut = calendarDate + timeSaveSpan;
        }

        private async void Button_Click16_00(object sender, EventArgs e)
        {
            bt16_00.BackgroundColor = Color.FromHex("#41D698");
            TimeSpan timeSaveSpan = new TimeSpan(0, 16, 0, 0);
            SaveDateBut = calendarDate + timeSaveSpan;
        }

        private async void Button_Click17_00(object sender, EventArgs e)
        {
            bt17_00.BackgroundColor = Color.FromHex("#41D698");
            TimeSpan timeSaveSpan = new TimeSpan(0, 17, 0, 0);
            SaveDateBut = calendarDate + timeSaveSpan;
        }

        private async void Button_Click18_00(object sender, EventArgs e)
        {
            bt18_00.BackgroundColor = Color.FromHex("#41D698");
            TimeSpan timeSaveSpan = new TimeSpan(0, 18, 0, 0);
            SaveDateBut = calendarDate + timeSaveSpan;
        }

        private async void Button_Click19_00(object sender, EventArgs e)
        {
            bt19_00.BackgroundColor = Color.FromHex("#41D698");
            TimeSpan timeSaveSpan = new TimeSpan(0, 19, 0, 0);
            SaveDateBut = calendarDate + timeSaveSpan;
        }

        private async void Button_Click20_00(object sender, EventArgs e)
        {
            bt20_00.BackgroundColor = Color.FromHex("#41D698");
            TimeSpan timeSaveSpan = new TimeSpan(0, 20, 0, 0);
            SaveDateBut = calendarDate + timeSaveSpan;
        }
        #endregion


        #region сохранение записи
        private async void Button_Booking(object sender, EventArgs e)
        {
            DateTime? dateTimes = SaveDateBut;
            Order order = new Order();
            order.MasterId = MasterId;
            order.ServiceId = ServiceId;
            order.UserId = UserID;
            order.DateTime = dateTimes;
            try
            {
                Order order1 = (Order)BindingContext;

                if (order.MasterId != null & order.ServiceId != null & order.UserId != null & order.DateTime != null)
                {
                    await App.UsersDB.SaveOrderAsync(order);
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        #endregion
    }
}