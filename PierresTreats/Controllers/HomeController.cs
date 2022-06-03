using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

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