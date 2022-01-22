using AnimalShelterConsumer.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnimalShelterConsumer.Controllers
{
  public class AnimalsController : Controller
  {

    [HttpGet("edit/{id}")]
    public ActionResult Edit(int id)
    {
      Animal model = Animal.GetAnimal(id);
      return View(model);
    }

    [HttpPost]
    public ActionResult Edit(Animal animal)
    {
      Animal.EditAnimal(animal);
      return RedirectToAction("Index");
    }
  }
}