using Microsoft.AspNetCore.Mvc;
using VejrApp.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace VejrApp.Controllers
{
    public class WeatherController : Controller
    {
        public IActionResult Index(double lon, double lat)
        {
            APIHandler Client = new();

            try
            {
                var Response = Client.Get(lon, lat);

                Response.EnsureSuccessStatusCode();

                string JsonData = Response.Content.ReadAsString();

                WeatherMeasurement measurement = JsonConvert.DeserializeObject<WeatherMeasurement>(JsonData);

                return View(measurement);

            }
            
            catch (HttpRequestException ex)
            {

            }
        }
    }
}
