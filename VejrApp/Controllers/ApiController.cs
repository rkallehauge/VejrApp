﻿using Microsoft.AspNetCore.Mvc;
using VejrApp.Models; 

namespace VejrApp.Controllers
{
    public class ApiController : Controller
    {
        public IActionResult Index()
        {
            APIHandler Client = new ();
            return View();
        }
    }
}
