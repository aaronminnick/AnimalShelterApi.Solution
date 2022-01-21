using Microsoft.AspNetCore.Mvc;

namespace AnimalShelterApi.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return Redirect("/swagger");
    }
  }
}