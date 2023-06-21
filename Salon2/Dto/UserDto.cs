using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Salon2.Dto
{
    [DataContract]
    public static class UserDto
    {
        [DataMember]
        public static int IdUserDto { get; set; }
        //private int _idUserDto;
        //public int IdUserDto
        //{
        //    get
        //    {
        //        return _idUserDto;
        //    }
        //    set
        //    {
        //        _idUserDto = value; OnPropertyChanged();
        //    }
        //}

        //private void OnPropertyChanged()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
