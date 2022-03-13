using APICliente.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace APICliente.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("/Home/GoVender")]
        public ActionResult GoToVender()
        {
            return RedirectToAction("Vender", "VendasCliente");
        }









        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}