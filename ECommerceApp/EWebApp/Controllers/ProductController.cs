using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using EWebApp.Models;
using BOL;
using BLL;

namespace EWebApp.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;
    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Product> allProducts = ProductManager.GetAllProducts();
        this.ViewData["products"] = allProducts;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}