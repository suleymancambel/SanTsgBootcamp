using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using SanTsgBootcamp.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static SanTsgBootcamp.Web.Models.AuthenticationModel;

namespace SanTsgBootcamp.Web.Controllers
{

    
    public class HomeController : Controller
    {
      
        private readonly ILogger<HomeController> _logger;
        

        public HomeController(ILogger<HomeController> logger  )
        {
            _logger = logger;
          
            
        }

        public class LoginModel
        {
            public string Agency { get; set; }
            public string User { get; set; }
            public string Password { get; set; }
        }
        public  async Task<IActionResult>  Index()
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


            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Append("Token", resObj.body.token, options);


            var jsonTest = Newtonsoft.Json.JsonConvert.SerializeObject(response);

            return View();

           
        }

        public  IActionResult Privacy()
        {
            
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
