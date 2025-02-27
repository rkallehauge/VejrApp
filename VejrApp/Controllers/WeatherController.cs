using Microsoft.AspNetCore.Mvc;
using VejrApp.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace VejrApp.Controllers
{
    public class WeatherController : Controller
    {
        public async Task<IActionResult> Index(double lon, double lat)
        {
            APIHandler Client = new();

            try
            {
                var Response = await Client.Get(lon, lat);

                //Response.EnsureSuccessStatusCode();

                string JsonData = await Response.Content.ReadAsStringAsync();

                WeatherMeasurement measurement = JsonConvert.DeserializeObject<WeatherMeasurement>(JsonData);

                return View(measurement);

            }
            
            catch (HttpRequestException ex)
            {
                return View();
            }
        }
    }
}
