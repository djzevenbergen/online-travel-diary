using Microsoft.AspNetCore.Mvc;
using OnlineTravelDiary.Models;
using System.Collections.Generic;

namespace OnlineTravelDiary.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetPlaces();
      return View(allPlaces);
    }
  }
}