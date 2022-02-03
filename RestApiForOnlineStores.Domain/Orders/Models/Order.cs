﻿using System.Collections;
using System.Collections.Generic;
using RestApiForOnlineStores.Domain.Orders.Types;

namespace RestApiForOnlineStores.Domain.Orders.Models
{
    public class Order
    {
        //can use guid type for Id
        public int Id { get; set; }
        public OrderState State { get; set; }
        public IEnumerable<string> Products { get; set; }
        public decimal Cost { get; set; }
        public string PostamatId { get; set; }
        public string PhoneNumber { get; set; }
        public string RecipientFullName { get; set; }
    }
}