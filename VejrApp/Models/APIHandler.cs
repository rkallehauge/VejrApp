using Microsoft.AspNetCore.Server.Kestrel.Core;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Diagnostics;

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

        public async Task <HttpResponseMessage> Get(double lon, double lat)            //Henter en Http-respons med API med brede og længdegrad
        {
            string apiKey = Models.StaticSecret.Secret;

            UriBuilder Builder = new(Client.BaseAddress);

            var Query = HttpUtility.ParseQueryString(Builder.Query);
            Query["lat"] = lat.ToString();
            Query["lon"] = lon.ToString();
            Query["appid"] = apiKey;
            Builder.Query = Query.ToString();
            
            var response = await Client.GetAsync(Builder.Uri);
            return response;



        }

        


    }


}
