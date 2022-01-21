using AnimalShelterConsumer.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnimalShelterConsumer.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Animals = Animal.GetAnimals();
      return View();
    }
  }
}