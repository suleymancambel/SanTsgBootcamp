using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SanTsgBootcamp.Web.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SanTsgBootcamp.Web.Controllers
{
    public class CommitTransactionController : Controller
    {
        public class Rootobject
        {
            public string transactionId { get; set; }
        }

        public async Task<IActionResult> Commit(string transactionId)
        {



           

        string hotelid = transactionId.ToString();
        var modelcommit = new Rootobject()
        {

            transactionId = transactionId,

        };

        var cookieValue = Request.Cookies["Token"];
        var newJsonObject = Newtonsoft.Json.JsonConvert.SerializeObject(modelcommit);

        var client = new HttpClient();
        var body = new StringContent(newJsonObject, Encoding.UTF8, "application/json");

        client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", cookieValue);

        var response = await client.PostAsync("http://service.stage.paximum.com/api/bookingservice/committransaction", body);
        //response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();

        var resObj = Newtonsoft.Json.JsonConvert.DeserializeObject<Rootobject>(responseString);

            if (response.IsSuccessStatusCode)
            {
                var readprice = response.Content.ReadAsStringAsync();


        CommitModel.Rootobject model2 = JsonConvert.DeserializeObject<CommitModel.Rootobject>(readprice.Result);
               

                return View(model2.body);


    }


            return View();
}
    }
}
