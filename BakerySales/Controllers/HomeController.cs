using Microsoft.AspNetCore.Mvc;

namespace BakerySales.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}