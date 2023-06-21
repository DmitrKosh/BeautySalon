using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon2.Models
{
    public class Service
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string NameService { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }
}
