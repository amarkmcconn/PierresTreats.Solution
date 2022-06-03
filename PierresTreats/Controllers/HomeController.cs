using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using PierresTreats.Models;

namespace PierresTreats.Controllers
{
    public class HomeController : Controller
    {
      private readonly PierresTreatsContext _db;

      public HomeController(PierresTreatsContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        ViewBag.Flavors = _db.Flavors.ToList();
        ViewBag.Treats = _db.Treats.ToList();
        return View();
      }

    }
}