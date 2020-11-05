using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExternalAPICons.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.IdentityModel.Tokens;

namespace ExternalAPICons.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            List<Datum> datumList = null;
            using (var client = new HttpClient()) {
                client.BaseAddress = new Uri("https://gorest.co.in");
                HttpResponseMessage response = client.GetAsync("/public-api/users").Result;
                string jsonObj = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode) {
                    var deserialisedRootObj = JsonConvert.DeserializeObject<Root>(jsonObj);
                    datumList = deserialisedRootObj.data;
                }
            }
            return View(datumList);
        }
    }
}






// user =JsonConvert.DeserializeObject<List<UsersModel>>(stringData);

//if (result.IsSuccessStatusCode)
//{
//    var readJob = result.Content.ReadAsAsync<IList<UsersModel>>();
//    readJob.Wait();
//    user = readJob.Result;
//}
//else
//{
//    user = Enumerable.Empty<UsersModel>();
//    ModelState.AddModelError(string.Empty, "Server error");
//}
//client.BaseAddress = new Uri("https://gorest.co.in/public-api/users");

//var responseTask = client.GetAsync("users");
//responseTask.Wait();
//var result = responseTask.Result;