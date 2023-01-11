using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EWebApp.Models;

namespace EWebApp.Controllers;

public class DepartmentController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public DepartmentController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Departments(){
        List<Department> allDepartments = BLL.HRManager.GetAllDepartments();
        this.ViewData["departments"] = allDepartments;
        return View();
    }

    public IActionResult Details(int id){
        Department dept = BLL.HRManager.GetDepartmentDetails(id);
        this.ViewData["departmentdetails"] = dept;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
