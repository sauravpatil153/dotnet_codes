using System.Collections.Generic;
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

    public IActionResult LoginErr(){
        return View();
    }

    
    public IActionResult Validate(string email, string password)
    {
        List<Authentication> userData = SerDeser.RetrieveData();
        foreach (Authentication user in userData)
        {
            if (user.Email==email && user.Password==password)
            {
                return Redirect("/Home/Index");
            }
        }
        return Redirect("/Home/LoginErr");
    }

    public IActionResult Register()
    {
        return View();
    }

    
    public IActionResult StoreData(string email, string password, string firstName, string lastName)
    {
        SerDeser.StoreData(email, password, firstName, lastName);
        return Redirect("/Home/Login");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
