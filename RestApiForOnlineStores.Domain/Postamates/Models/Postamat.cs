﻿namespace RestApiForOnlineStores.Domain.Postamates.Models
{
    public class Postamat
    {
        public string Id { get; set; }
        public string Address { get; set; }
        //true - working, false - closed
        public bool State { get; set; }
    }
}