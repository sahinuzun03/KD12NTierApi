using KD12NTierApi.Entities.Concrete;
using KD12NTierApi.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace KD12NTierApi.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult KisileriGetir()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7038/"); //Api local adresi verdim
                var responseTask = client.GetAsync("api/Person");
                responseTask.Wait();
                var resultTask = responseTask.Result;

                if (responseTask.IsCompletedSuccessfully)
                {
                    var readTask = resultTask.Content.ReadAsStringAsync();// Sen git o listeyi oku ve bana döndür
                    readTask.Wait();
                    var veri = JsonConvert.DeserializeObject<List<Person>>(readTask.Result);
                    return View(veri);
                }
                else
                {
                    ViewBag.EmptyListMessage = "Öğün Bulunamamıştır";
                    return View(new List<Person>());
                }
                
            }
        }
    }
}