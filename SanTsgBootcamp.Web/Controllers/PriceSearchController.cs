using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SanTsgBootcamp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static SanTsgBootcamp.Web.Controllers.PriceSearchController.pricelogin;

namespace SanTsgBootcamp.Web.Controllers
{
    public class PriceSearchController : Controller
    {
        public class pricelogin
        {

            public class RootobjectHead
            {
                public Header header { get; set; }
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
                public string provider { get; set; }
            }

            public class Rootobject
            {
                public bool checkAllotment { get; set; }
                public bool checkStopSale { get; set; }
                public bool getOnlyDiscountedPrice { get; set; }
                public bool getOnlyBestOffers { get; set; }
                public int productType { get; set; }
                public Arrivallocation[] arrivalLocations { get; set; }
                public Roomcriteria[] roomCriteria { get; set; }
                public string nationality { get; set; }
                public string checkIn { get; set; }
                public int night { get; set; }
                public string currency { get; set; }
                public string culture { get; set; }
            }

            public class Arrivallocation
            {
                public string id { get; set; }
                public int type { get; set; } = 2;
            }

            public class Roomcriteria
            {
                public int adult { get; set; }
                public int[] childAges { get; set; }
            }

        }
        public async Task<IActionResult> PriceSearch(string id)
        {

            string hotelid = id.ToString();
            var modelprice = new Rootobject()
            {
                checkAllotment = true,
                checkStopSale = true,
                getOnlyDiscountedPrice = false,
                getOnlyBestOffers = true,
                productType = 2,
                arrivalLocations = new Arrivallocation[] { new Arrivallocation() { id = hotelid } },
                roomCriteria = new Roomcriteria[] { new Roomcriteria() { adult = 2, childAges = new int[] { } } },
                nationality = "DE",
                checkIn = "2023-06-20",
                night = 7,
                currency = "EUR",
                culture = "en-US"







            };

            var cookieValue = Request.Cookies["Token"];
            var newJsonObject = Newtonsoft.Json.JsonConvert.SerializeObject(modelprice);

            var client = new HttpClient();
            var body = new StringContent(newJsonObject, Encoding.UTF8, "application/json");

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", cookieValue);

            var response = await client.PostAsync("http://service.stage.paximum.com/api/productservice/pricesearch", body);
            //response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();


            var resObj = Newtonsoft.Json.JsonConvert.DeserializeObject<Rootobject>(responseString);
           // var resObj2 = Newtonsoft.Json.JsonConvert.DeserializeObject<RootobjectHead>(responseString);
           

            if (response.IsSuccessStatusCode)
            {
                var readprice = response.Content.ReadAsStringAsync();


                pricesearchmodel.Rootobject model2 = JsonConvert.DeserializeObject<pricesearchmodel.Rootobject>(readprice.Result);



                return View(model2.body.hotels);



            }



            return View();
        }


    }
}
