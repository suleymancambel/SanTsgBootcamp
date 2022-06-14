using System;

namespace SanTsgBootcamp.Web.Models
{
    public class getproductinfomodel
    {

        public class Rootobject
        {
            public Body body { get; set; }
            public Header header { get; set; }
        }

        public class Body
        {
            public Hotel hotel { get; set; }
        }

        public class Hotel
        {
            public Season[] seasons { get; set; }
            public Address address { get; set; }
            public string faxNumber { get; set; }
            public string phoneNumber { get; set; }
            public string homePage { get; set; }
            public int stopSaleGuaranteed { get; set; }
            public int stopSaleStandart { get; set; }
            public Geolocation1 geolocation { get; set; }
            public float stars { get; set; }
            public float rating { get; set; }
            public Theme[] themes { get; set; }
            public Location location { get; set; }
            public Country country { get; set; }
            public City1 city { get; set; }
            public Giatainfo giataInfo { get; set; }
            public int provider { get; set; }
            public string thumbnail { get; set; }
            public string thumbnailFull { get; set; }
            public Description description { get; set; }
            public string id { get; set; }
            public string name { get; set; }
        }

        public class Address
        {
            public City city { get; set; }
            public string[] addressLines { get; set; }
            public string street { get; set; }
            public string streetNumber { get; set; }
            public Geolocation geolocation { get; set; }
        }

        public class City
        {
            public string name { get; set; }
            public int provider { get; set; }
            public bool isTopRegion { get; set; }
        }

        public class Geolocation
        {
            public string longitude { get; set; }
            public string latitude { get; set; }
        }

        public class Geolocation1
        {
            public string longitude { get; set; }
            public string latitude { get; set; }
        }

        public class Location
        {
            public string name { get; set; }
            public string latitude { get; set; }
            public string longitude { get; set; }
            public int provider { get; set; }
            public bool isTopRegion { get; set; }
            public string id { get; set; }
        }

        public class Country
        {
            public string name { get; set; }
            public int provider { get; set; }
            public bool isTopRegion { get; set; }
            public string id { get; set; }
        }

        public class City1
        {
            public string name { get; set; }
            public string latitude { get; set; }
            public string longitude { get; set; }
            public int provider { get; set; }
            public bool isTopRegion { get; set; }
            public string id { get; set; }
        }

        public class Giatainfo
        {
            public string hotelId { get; set; }
            public string destinationId { get; set; }
        }

        public class Description
        {
            public string text { get; set; }
        }

        public class Season
        {
            public string name { get; set; }
            public Textcategory[] textCategories { get; set; }
            public Facilitycategory[] facilityCategories { get; set; }
            public Mediafile[] mediaFiles { get; set; }
        }

        public class Textcategory
        {
            public string name { get; set; }
            public Presentation[] presentations { get; set; }
        }

        public class Presentation
        {
            public int textType { get; set; }
            public string text { get; set; }
        }

        public class Facilitycategory
        {
            public string name { get; set; }
            public Facility[] facilities { get; set; }
        }

        public class Facility
        {
            public string id { get; set; }
            public string name { get; set; }
            public bool isPriced { get; set; }
        }

        public class Mediafile
        {
            public int fileType { get; set; }
            public string url { get; set; }
            public string urlFull { get; set; }
        }

        public class Theme
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
