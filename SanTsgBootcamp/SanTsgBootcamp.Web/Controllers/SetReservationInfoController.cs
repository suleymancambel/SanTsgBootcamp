using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SanTsgBootcamp.Web.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static SanTsgBootcamp.Web.Models.SetReservationInfoModel;

namespace SanTsgBootcamp.Web.Controllers
{
    public class SetReservationInfoController : Controller
    {

        public class Rootobject
        {
            public string transactionId { get; set; }
            public Traveller[] travellers { get; set; }
            public Customerinfo customerInfo { get; set; }
            public string reservationNote { get; set; }
            public string agencyReservationNumber { get; set; }
        }

        public class Customerinfo
        {
            public bool isCompany { get; set; } = false;
            public Passportinfo passportInfo { get; set; } 
            public Address address { get; set; }
            public Taxinfo taxInfo { get; set; } =new Taxinfo();
            public int title { get; set; } = 1;
            public string name { get; set; } 
            public string surname { get; set; } 
            public string birthDate { get; set; } = "1996-01-01";
            public string identityNumber { get; set; } = "11111111111";
        }

        public class Passportinfo
        {
        }

        public class Address
        {
            public City city { get; set; }
            public Country country { get; set; } 
            public string email { get; set; } = "cambelsuleyman@gmail.com";
            public string phone { get; set; } = "+902222222222";
            public string address { get; set; } = "Customer test";
            public string zipCode { get; set; } = "07000";
        }

        public class City
        {
            public string name { get; set; } = "Antalya";
        }

        public class Country
        {
            public string name { get; set; } = "Turkey";
        }

        public class Taxinfo
        {
        }

        public class Traveller
        {
            public string travellerId { get; set; }
            public int type { get; set; }
            public int title { get; set; }
            public int passengerType { get; set; }
            public string name { get; set; }
            public string surname { get; set; }
            public bool isLeader { get; set; }
            public DateTime birthDate { get; set; } 
            public Nationality nationality { get; set; } 
            public string identityNumber { get; set; } 
            public Passportinfo1 passportInfo { get; set; }
            public Address1 address { get; set; }
            public Destinationaddress destinationAddress { get; set; }
            public int orderNumber { get; set; } 
            public object[] documents { get; set; } = new object[] { };
            public object[] insertFields { get; set; } = new object[] { };
            public int status { get; set; }
        }

        public class Nationality
        {
            public string twoLetterCode { get; set; } = "DE";
        }

        public class Passportinfo1
        {
            public string serial { get; set; } = "a";
            public string number { get; set; } = "13";
            public DateTime expireDate { get; set; } = new DateTime(2030-01-01);
            public DateTime issueDate { get; set; } = new DateTime(2030-01-01);
            public string citizenshipCountryCode { get; set; } = "55";
        }

        public class Address1
        {
            public Contactphone contactPhone { get; set; }
            public string email { get; set; } = "cambelsuleyman@gmail.com";
            public string address { get; set; } = "Antalya";
            public string zipCode { get; set; } = "07070";
            public City1 city { get; set; } 
            public Country1 country { get; set; }
            public string phone { get; set; } = "5555555";
        }

        public class Contactphone
        {
            public string countryCode { get; set; } = "90";
            public string areaCode { get; set; } = "555";

            public string phoneNumber { get; set; } = "55555555";
        }

        public class City1
        {
            public string id { get; set; } = "2";
            public string name { get; set; } 
        }

        public class Country1
        {
            public string id { get; set; } = "1";
            public string name { get; set; } = "Turkey";
        }

        public class Destinationaddress
        {
        }

        public async Task<IActionResult> SetReservation(string transactionId ,string inputname,string inputsurname)
        {

            string tranid = transactionId.ToString();
            //var modelset = new Rootobject()
            //{

            //    //arrivalLocations = new Arrivallocation[] { new Arrivallocation() { id = hotelid } },
            //    //roomCriteria = new Roomcriteria[] { new Roomcriteria() { adult = 1, childAges = new int[] { 2 } } },
            //    transactionId = transactionId,
            //    travellers = new Traveller[] { new Traveller() {
            //        travellerId = "1",
            //        type = 1,
            //        title = 1,
            //        passengerType = 1,
            //        name = "süleyman",
            //        surname = "cambel",
            //        isLeader = true,
            //        birthDate = new DateTime(1998 - 04 - 05),
            //        nationality = new Nationality(),
            //        identityNumber = {},
            //        passportInfo = new Passportinfo1(),
            //        address = new Address1(),
            //        orderNumber = 1,
            //        documents = new object[] { },
            //        insertFields = new object[] { },
            //        status = 0,
            //        destinationAddress = { },




            //    }

            //    },




            //    customerInfo = new Customerinfo(),
            //    reservationNote = "note",
            //    agencyReservationNumber = "agency number"









            //};


            var modelset = new Rootobject()
            {

                
                transactionId = transactionId,
                travellers = new Traveller[] { new Traveller() {
                    travellerId = "1",
                    type = 1,
                    title = 1,
                    passengerType = 1,
                    name = inputname,
                    surname = inputsurname,
                    isLeader = true,
                    birthDate = new DateTime(1998 - 04 - 05),
                    nationality = new Nationality(),
                    identityNumber = {},
                    passportInfo = new Passportinfo1(),
                    address = new Address1(),
                    orderNumber = 1,
                    documents = new object[] { },
                    insertFields = new object[] { },
                    status = 0,
                    destinationAddress = { },




                },
                new Traveller() {
                    travellerId = "2",
                    type = 1,
                    title = 3,
                    passengerType = 1,
                    name = "süleyman",
                    surname = "cambel",
                    isLeader = false,
                    birthDate = new DateTime(1998 - 04 - 05),
                    nationality = new Nationality(),
                    identityNumber = {},
                    passportInfo = new Passportinfo1(),
                    address = new Address1(),
                    orderNumber = 2,
                    documents = new object[] { },
                    insertFields = new object[] { },
                    status = 0,
                    destinationAddress = { },

                }


                },
                




                customerInfo = new Customerinfo(),
                reservationNote = "note",
                agencyReservationNumber = "agency number"









            };





            var cookieValue = Request.Cookies["Token"];
            var newJsonObject = Newtonsoft.Json.JsonConvert.SerializeObject(modelset);

            var client = new HttpClient();
            var body = new StringContent(newJsonObject, Encoding.UTF8, "application/json");

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", cookieValue);

            var response = await client.PostAsync("http://service.stage.paximum.com/api/bookingservice/setreservationinfo", body);
            //response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            var resObj = Newtonsoft.Json.JsonConvert.DeserializeObject<Rootobject>(responseString);

            if (response.IsSuccessStatusCode)
            {
                var readprice = response.Content.ReadAsStringAsync();


                SetReservationInfoModel.Rootobject model2 = JsonConvert.DeserializeObject<SetReservationInfoModel.Rootobject>(readprice.Result);
                //List<pricesearchmodel.Rootobject> list = model2.body.hotels;

                //List<pricesearchmodel.Rootobject> listhotel = list.Where(item => item.city.name.Equals(city) && item.hotel != null).ToList();

                return View(model2.body);


            }
            ////commityapıalcak transactionId geliyor comite post et gitsin 03:05
           
            return View();
        }


    }
}

