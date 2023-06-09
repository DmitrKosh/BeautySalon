﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon2.Models
{
    public class Master
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
    }
}
