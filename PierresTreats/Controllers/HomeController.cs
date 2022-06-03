using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;

namespace PierresTreats.Controllers;

public class HomeController : Controller
{
    private readonly PierresTreatsContext_db;
    public HomeController(PierresTreats db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
			ViewBag.Treats = _db.Treats.ToList();
			ViewBag.Flavors = _db.Flavors.ToList();
      return View();
    }
}
