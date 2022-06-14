using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SanTsgBootcamp.Web.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static SanTsgBootcamp.Web.Models.getproductinfomodel;

namespace SanTsgBootcamp.Web.Controllers
{
    public class GetproductinfoController : Controller
    {
        public async Task<IActionResult> GetProductInfo(string hotelid)
        {
            string id = hotelid.ToString();
            var modelinfo = new logininfoget()
            {
                productType = 2,
                ownerProvider = 2,
                product = id,
                culture = "en-US"
               
            };

            var cookieValue = Request.Cookies["Token"];
            var newJsonObject = Newtonsoft.Json.JsonConvert.SerializeObject(modelinfo);

            var client = new HttpClient();
            var body = new StringContent(newJsonObject, Encoding.UTF8, "application/json");

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", cookieValue);

            var response = await client.PostAsync("http://service.stage.paximum.com/api/productservice/getproductinfo", body);
            //response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            var resObj = Newtonsoft.Json.JsonConvert.DeserializeObject<Rootobject>(responseString);

            Body newBody = resObj.body;

            ViewBag.jsonBody = newBody.hotel.address;


            
                var readhotelinfo = response.Content.ReadAsStringAsync();


                getproductinfomodel.Rootobject model2 = JsonConvert.DeserializeObject<getproductinfomodel.Rootobject>(readhotelinfo.Result);








          



            return View(model2.body.hotel);
        }

        public class logininfoget
        {
            public int productType { get; set; }
            public int ownerProvider { get; set; }
            public string product { get; set; }
            public string culture { get; set; }
        }

    }

}
