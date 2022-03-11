using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Quiz.Models;

namespace Quiz.Controllers;

public class q1controller : Controller
{
    public IActionResult Index()
    {
        return View("Index");
    }

    [Route("q1/profile")]
    public IActionResult Profile()
    {
        return View("Profile");
    }

    [Route("q1/company")]
    public IActionResult Company()
    {
        return View("Company");
    }

    [Route("q1/service")]
    public IActionResult Service()
    {
        return View("Service");
    }

    [Route("q1/collaboration")]
        public IActionResult Collaboration()
    {
        return View("Collaboration");
    }
}
