using Microsoft.AspNetCore.Server.Kestrel.Core;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;

namespace VejrApp.Models
{
   
    public class APIHandler
    {
        HttpClient Client;                          //Deklarer variable der hedder Client
        public APIHandler()                                 //Construktor
        {
            Client = new HttpClient();               //Intialiserer variablen
            
            Uri API = new Uri("https://api.openweathermap.org/data/2.5/weather");   //vi gemmer url´en
            Client.BaseAddress = API;                                               //Når der kommer forspørgelser, så peger den her hen
        }

        public async HttpResponseMessage Get(double lon, double lat)            //
        {
            string apiKey = Models.StaticSecret.Secret;
        }
            
    }


}
