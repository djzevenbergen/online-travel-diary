using Microsoft.AspNetCore.Mvc;
using OnlineTravelDiary.Models;
using System.Collections.Generic;

namespace OnlineTravelDiary.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string cityname)
    {
      Place place = new Place(cityname);
      return RedirectToAction("Index", "Home");
    }
  }
}