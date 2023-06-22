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
        public string MasterName { get; set; }
        public string ServiceName { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
