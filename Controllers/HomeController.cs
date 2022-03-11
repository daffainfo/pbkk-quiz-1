using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Quiz.Models;

namespace Quiz.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return RedirectToAction("Index", "q1");
    }

}
