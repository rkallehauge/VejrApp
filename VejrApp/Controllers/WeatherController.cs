using Microsoft.AspNetCore.Mvc;
using VejrApp.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;

namespace VejrApp.Controllers
{
    public class WeatherController : Controller
    {
        public async Task<IActionResult> Index(double lon, double lat)
        {
            APIHandler Client = new();

            WeatherMeasurement hole = new();

            if(lon==0 && lat == 0)
            {
                return View(hole);
            }

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
                return View(hole);
            }
        }
    }
}
