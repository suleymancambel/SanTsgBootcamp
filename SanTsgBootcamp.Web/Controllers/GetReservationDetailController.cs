using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SanTsgBootcamp.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SanTsgBootcamp.Web.Controllers
{
    public class GetReservationDetailController : Controller
    {

        public class Rootobject
        {
            public string ReservationNumber { get; set; }
        }

        public async Task<IActionResult> ReservationDetail(string reservationnumber)
        {


            string number = reservationnumber.ToString();
            var modelnumber = new Rootobject()
            {

                ReservationNumber = number,

            };

            var cookieValue = Request.Cookies["Token"];
            var newJsonObject = Newtonsoft.Json.JsonConvert.SerializeObject(modelnumber);

            var client = new HttpClient();
            var body = new StringContent(newJsonObject, Encoding.UTF8, "application/json");

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", cookieValue);

            var response = await client.PostAsync("http://service.stage.paximum.com/api/bookingservice/getreservationdetail", body);
            //response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            var resObj = Newtonsoft.Json.JsonConvert.DeserializeObject<Rootobject>(responseString);

            if (response.IsSuccessStatusCode)
            {
                var readprice = response.Content.ReadAsStringAsync();


                GetReservationDetailModel.Rootobject model2 = JsonConvert.DeserializeObject<GetReservationDetailModel.Rootobject>(readprice.Result);
               

               

                return View(model2.body);


            }


            return View();
        }
    }
}
