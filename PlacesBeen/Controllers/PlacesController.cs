using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PlacesBeen.Models;

namespace PlacesBeen.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string cityName, string daysStayed, string journalEntry)
    {
      Place newPlace = new Place (cityName, daysStayed, journalEntry);
      return RedirectToAction("Index");
    }

    [HttpPost("/places/delete")]
    public ActionResult DeleteAll()
    {
      Place.ClearAll();
      return RedirectToAction("Index");
    }

    [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {
      Place foundPlace = Place.Find(id);
      return View(foundPlace);
    }
  }
}