using Microsoft.AspNetCore.Mvc;

namespace AnimalShelterApi.Controllers
{
  public class HomeController : Controller
  {
    [ApiExplorerSettings(IgnoreApi = true)]
    [HttpGet("/")]
    public ActionResult Index()
    {
      return Redirect("/swagger");
    }
  }
}