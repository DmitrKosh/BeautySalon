using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon2.Models
{
    public class Order
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int UserId { get; set; }
        public int MasterId { get; set; }
        public int ServiceId { get; set; }
        public DateTime? DateTime { get; set; }

        //public static implicit operator Order(List<Order> v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
