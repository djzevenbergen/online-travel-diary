using Microsoft.AspNetCore.Mvc;
using OnlineTravelDiary.Models;
using System;
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

    [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {

      Place foundPlace = Place.Find(id);
      if (foundPlace == null)
      {
        return RedirectToAction("Index", "Home");
      }
      else
      {
        return View(foundPlace);
      }
    }
  }
}