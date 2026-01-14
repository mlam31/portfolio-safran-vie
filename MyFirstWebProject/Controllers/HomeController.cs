using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyFirstProject.Models;

namespace MyFirstProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Equipment.equipmentCountId = 0; // On remet à zéro à chaque affichage
            List<Equipment> equipmentList = new List<Equipment>();
            List<Equipment> equipmentList = new List<Equipment>();
            equipmentList.Add(new Equipment("Apple", "iPhone 17"));
            equipmentList.Add(new Equipment("Lenovo", "ThinkPad X1"));
            equipmentList.Add(new Equipment("Lenovo", "ThinkPad T1"));
            return View(equipmentList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
