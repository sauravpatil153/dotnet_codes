﻿using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MvcApp.Controllers;

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

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Validate(string email, string password)
    {
        if (email == "sauravpatil96@gmail.com" && password == "saurav")
        {
            return Redirect("/Home/Index");
        }
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult StoreData(string email, string password)
    {
        SerDeser.StoreData(email,password);
        return Redirect("/Home/Login");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
