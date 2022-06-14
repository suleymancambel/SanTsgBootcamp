using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static SanTsgBootcamp.Web.Models.AuthenticationModel;

namespace SanTsgBootcamp.Web.Controllers
{
    public class AuthencationController : Controller
    {

        public class LoginModel
        {
            public string Agency { get; set; }
            public string User { get; set; }
            public string Password { get; set; }
        }
        //TokenPost
        public async Task<IActionResult> apilist()
        {
            var model = new LoginModel()
            {
                Agency = "PXM25397",
                User = "USR1",
                Password = "test!23"
            };

            var newJsonObject = Newtonsoft.Json.JsonConvert.SerializeObject(model);

            var client = new HttpClient();
            var body = new StringContent(newJsonObject, Encoding.UTF8, "application/json");

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.PostAsync("http://service.stage.paximum.com/api/authenticationservice/login", body);
            //response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            var resObj = Newtonsoft.Json.JsonConvert.DeserializeObject<Rootobject>(responseString);

            ViewBag.Token = resObj.body.token;

            //cookiesappend
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Append("Token", resObj.body.token, options);


            var jsonTest = Newtonsoft.Json.JsonConvert.SerializeObject(response);

            return View();
        }
    }
}
