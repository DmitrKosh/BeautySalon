using Salon2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon2.Dto
{
    public class OrderDto : List<Order>
    {
        public string Name { get; private set; }

        public OrderDto(List<Order> orders) : base(orders)
        {
            //Name = name;
        }
    }
}
