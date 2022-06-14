using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using SanTsgBootcamp.Data;
using SanTsgBootcamp.Data.UnitOfWork;
using SanTsgBootcamp.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static SanTsgBootcamp.Web.Models.autocompleteModel;

namespace SanTsgBootcamp.Web.Controllers
{
    public class autocompleteController : Controller
    {
        


        public async Task<IActionResult> HotelSearch( )
        {

            return View();
        }
        
       //autoapi
        public async Task<IActionResult>  HotelList(string id)
        {

            


            string city = id.ToString();
           
            var modelTour = new RootobjectTour()
            {
                Culture = "en-Us",
                Query = city,
                ProductType = 2
            };

            var cookieValue = Request.Cookies["Token"];
            var newJsonObject = Newtonsoft.Json.JsonConvert.SerializeObject(modelTour);

            var client = new HttpClient();
            var body = new StringContent(newJsonObject, Encoding.UTF8, "application/json");

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", cookieValue);

            var response = await client.PostAsync("http://service.stage.paximum.com/api/productservice/getarrivalautocomplete", body);
            //response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            var resObj = Newtonsoft.Json.JsonConvert.DeserializeObject<Rootobject>(responseString);

            Body newBody = resObj.body;
            
            ViewBag.jsonBody = newBody.items;


            if (response.IsSuccessStatusCode)
            {
                var readhotel = response.Content.ReadAsStringAsync();
                

                autocompleteModel.Rootobject model2 = JsonConvert.DeserializeObject<autocompleteModel.Rootobject>(readhotel.Result);
                List<autocompleteModel.Item> list = model2.body.items.ToList();
                List<autocompleteModel.Item> listhotel = list.Where(item => item.city.name.Equals(city) && item.hotel != null).ToList();

                return View(listhotel);


            }


            return View();
        }
        public class RootobjectTour
        {
            public int ProductType { get; set; }
            public string Query { get; set; }
            public string Culture { get; set; }
        }
    }
}
