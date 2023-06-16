using Salon2.Views;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Salon2.ViewModels
{
    public class BookingServiceViewModel :BaseViewModel
    {
        

        DateTime _dateTime = DateTime.Today;

        public DateTime DateTime
        {
            get => _dateTime;
            set
            {
                _dateTime = value;
                OnPropertyChanged();
            }
        }

        

        int _month;
        int _year;
        int _dayOnMonth;
        int _dateOfWeek;

        public void data()
        {  //---------------------------------------------
            _month = _dateTime.Month;
            _year = _dateTime.Year;
            Month = _month;

            DateTime dateValue = new DateTime(_year, _month, 1);  //первый день месяца
            _dateOfWeek = Convert.ToInt32(dateValue.DayOfWeek);
            DayOfWeek = _dateOfWeek;
            int _dayOnMonth = DateTime.DaysInMonth(_year, _month); // дней в месяце
        }

        public int Month
        {
            get => _month;
            set
            {
                _month = value;
                OnPropertyChanged();
            }
        }

        public int DayOfWeek 
        {
            get => _dateOfWeek;
            set 
            {
                _dateOfWeek = value;
                OnPropertyChanged();
            }
        }


        // string _dayOfWeek = 

        private void OnPropertyChanged(DateTime _dateTime)
        {
            throw new NotImplementedException();
        }

        
    }
}
