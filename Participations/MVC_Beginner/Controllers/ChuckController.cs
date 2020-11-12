using MVC_Beginner.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVC_Beginner.Controllers
{
    public class ChuckController : Controller
    {
        // GET: Chuck
        public ActionResult Index()
        {
            string url = "https://api.chucknorris.io/jokes/random";
            ChuckNorrisAPI api;
            using (var Client = new HttpClient())
            {
                string results = Client.GetStringAsync(url).Result;
                api = JsonConvert.DeserializeObject<ChuckNorrisAPI>(results);
            }


            return View(api);
        }
    }
}