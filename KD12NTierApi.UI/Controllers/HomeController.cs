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
                var responseTask = client.GetAsync("api/Person");//Bilgileri getirecek olan metot 
                responseTask.Wait();//Bilgilerin gelmesi için beklemesini söyledik
                var resultTask = responseTask.Result; //dönen sonucu resultta yakaladık

                if (responseTask.IsCompletedSuccessfully) //Bu işlem doğru döndü mü onu kontrol ediyorumz
                {
                    var readTask = resultTask.Content.ReadAsStringAsync();// Sen git o listeyi oku ve bana döndür
                    readTask.Wait(); //Listeyi okumasını bekledik
                    var veri = JsonConvert.DeserializeObject<List<Person>>(readTask.Result);//String json olan veriyi jsondan listeye çevirdik
                    return View(veri);//gelendatayı ekrana bastık.
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