﻿using System;

namespace SanTsgBootcamp.Web.Models
{
    public class autocompleteModel
    {

        public class Rootobject
        {
            public Body body { get; set; }
            public Header header { get; set; }
        }

        public class Body
        {
            public Item[] items { get; set; }
        }

        public class Item
        {
            public int type { get; set; }
            public Geolocation geolocation { get; set; }
            public Country country { get; set; }
            public State state { get; set; }
            public City city { get; set; }
            public int provider { get; set; }
            public int hotelCount { get; set; }
            public Hotel hotel { get; set; }
        }

        public class Geolocation
        {
            public string longitude { get; set; }
            public string latitude { get; set; }
        }

        public class Country
        {
            public string id { get; set; }
            public string name { get; set; }
        }

        public class State
        {
            public string id { get; set; }
            public string name { get; set; }
        }

        public class City
        {
            public string id { get; set; }
            public string name { get; set; }
        }

        public class Hotel
        {
            public string id { get; set; }
            public string name { get; set; }
        }

        public class Header
        {
            public string requestId { get; set; }
            public bool success { get; set; }
            public DateTime responseTime { get; set; }
            public Message[] messages { get; set; }
        }

        public class Message
        {
            public int id { get; set; }
            public string code { get; set; }
            public int messageType { get; set; }
            public string message { get; set; }
        }


    }
}
