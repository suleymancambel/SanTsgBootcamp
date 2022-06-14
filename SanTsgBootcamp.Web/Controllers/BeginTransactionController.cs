using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SanTsgBootcamp.Web.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static SanTsgBootcamp.Web.Models.BeginTransactionModel;

namespace SanTsgBootcamp.Web.Controllers
{
    public class BeginTransactionController : Controller
    {

        public class Rootobject
        {
            public string[] offerIds { get; set; }
            public string currency { get; set; }
            public string culture { get; set; }
        }

        public async Task<IActionResult> BeginTransaction(string offerid)
            {

                string hotelid = offerid.ToString();
                var modelbegin = new Rootobject()
                {
                    
                    offerIds = new string[] { hotelid },
                    currency = "EUR",
                    culture = "en-US",
                  

                };

                var cookieValue = Request.Cookies["Token"];
                var newJsonObject = Newtonsoft.Json.JsonConvert.SerializeObject(modelbegin);

                var client = new HttpClient();
                var body = new StringContent(newJsonObject, Encoding.UTF8, "application/json");

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", cookieValue);

                var response = await client.PostAsync("http://service.stage.paximum.com/api/bookingservice/begintransaction", body);
                //response.EnsureSuccessStatusCode();

                var responseString = await response.Content.ReadAsStringAsync();
          
              var resObj = Newtonsoft.Json.JsonConvert.DeserializeObject<Rootobject>(responseString);

                if (response.IsSuccessStatusCode)
                {
                    var readprice = response.Content.ReadAsStringAsync();


                    BeginTransactionModel.Rootobject model2 = JsonConvert.DeserializeObject<BeginTransactionModel.Rootobject>(readprice.Result);
                   
                  
                    return View(model2.body);


                }
               

                return View();
            }

            
        }
    }




